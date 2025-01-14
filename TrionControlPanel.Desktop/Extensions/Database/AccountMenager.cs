﻿
using TrionControlPanel.Desktop.Extensions.Cryptography;
using TrionControlPanel.Desktop.Extensions.Modules.Lists;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TrionControlPanel.Desktop.Extensions.Modules.Enums;

namespace TrionControlPanel.Desktop.Extensions.Database
{
    public class AccountMenager
    {
        const int MaxAccountLength = 16;
        const int MaxEmailLength = 64;
        const int MaxPasswordLength = 16;
        const int MaxBnetEmailLength = 320;
        const int MaxBnetPassLength = 128;
        public static string Message { get; set; }

        public async static Task<AccountOpResult> CreateBnetAccount(string username, string email, string password, bool withGameAccount, AppSettings Settings)
        {
            if (string.IsNullOrEmpty(email) || email.Length > MaxEmailLength)
                return AccountOpResult.NameTooLong;

            if (string.IsNullOrEmpty(username) || username.Length > MaxBnetEmailLength)
                return AccountOpResult.NameTooLong;

            if (string.IsNullOrEmpty(password) || password.Length > MaxPasswordLength)
                return AccountOpResult.PassTooLong;

            if (await GetUser(username, Settings) != 0 || GetEmail(email) != 0)
                return AccountOpResult.NameAlreadyExist;

            return AccountOpResult.Ok;

        }
        public static async Task<AccountOpResult> CreateAccount(string username, string password, string email, AppSettings Settings)
        {
            if (string.IsNullOrEmpty(email) || username.Length > MaxAccountLength)
                return AccountOpResult.NameTooLong;

            if (string.IsNullOrEmpty(password) || password.Length > MaxPasswordLength)
                return AccountOpResult.PassTooLong;

            if (string.IsNullOrEmpty(email) || email.Length > MaxEmailLength)
                return AccountOpResult.NameTooLong;

            if (await GetUser(username, Settings) > 0)
                return AccountOpResult.NameAlreadyExist;

            if (GetEmail(email) > 0)
                return AccountOpResult.EmailAlreadyExist;

            if (Settings.SelectedCore == Cores.AzerothCore || Settings.SelectedCore == Cores.TrinityCore335 || Settings.SelectedCore == Cores.CMaNGOS || Settings.SelectedCore == Cores.VMaNGOS)
            {
                byte[] salt = SRP6.GenerateSalt();
                byte[] verifier = SRP6.LegecySHA1.CreateVerifier(username, password, salt);
                try
                {
                    await AccessMenager.SaveData(SqlQueryManager.CreateAccount(Settings.SelectedCore), new
                    {
                        Username = username,
                        Salt = salt,
                        Verifier = verifier,
                        Email = email,
                        RegMail = email,
                        JoinDate = DateTime.Now,
                    }, AccessMenager.ConnectionString(Settings, Settings.AuthDatabase));
                    return AccountOpResult.Ok;
                }
                catch (Exception ex)
                {
                    return AccountOpResult.DBInternalError;
                }

            }
            if (Settings.SelectedCore == Cores.AscEmu)
            {
                try
                {
                    var passhash = AscEmuSHA1.GetPasswordHash(username, password);
                    await AccessMenager.SaveData(SqlQueryManager.CreateAccount(Settings.SelectedCore), new
                    {
                        Username = username,
                        EncryptedPassword = passhash,
                        Email = email,
                        JoinDate = DateTime.Now,
                    }, AccessMenager.ConnectionString(Settings, Settings.AuthDatabase));
                    return AccountOpResult.Ok;
                }
                catch (Exception ex)
                {

                    return AccountOpResult.DBInternalError;
                }
            }
            if (Settings.SelectedCore == Cores.TrinityCore || Settings.SelectedCore == Cores.CypherCore)
            {
                byte[] salt = SRP6.GenerateSalt();
                byte[] verifier = SRP6.V2SHA256.CreateVerifier(username, password, salt);
                try
                {
                    await AccessMenager.SaveData(SqlQueryManager.CreateAccount(Settings.SelectedCore), new
                    {
                        Username = username,
                        Salt = salt,
                        Verifier = verifier,
                        Email = email,
                        RegMail = email,
                        JoinDate = DateTime.Now,
                    }, AccessMenager.ConnectionString(Settings, Settings.AuthDatabase));
                    return AccountOpResult.Ok;
                }
                catch (Exception ex)
                {
                    return AccountOpResult.DBInternalError;
                }
            }
            return AccountOpResult.BadLink;
        }
        private static async Task<int> GetUser(string Username, AppSettings Settings)
        {
            return await AccessMenager.LoadDataType<int ,dynamic>(SqlQueryManager.GetUserByUsername(Settings.SelectedCore), new { 
                Username 
            },AccessMenager.ConnectionString(Settings, Settings.AuthDatabase));
        }
        public static async Task<int> GetEmail(string Email, AppSettings Settings)
        {
            return await AccessMenager.LoadDataType<int, dynamic>(SqlQueryManager.GetEmailByEmail(Settings.SelectedCore), new
            {
                Email
            }, AccessMenager.ConnectionString(Settings, Settings.AuthDatabase));
        }
    }
}
