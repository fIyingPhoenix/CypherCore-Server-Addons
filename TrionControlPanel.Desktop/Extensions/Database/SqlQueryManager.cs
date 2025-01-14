﻿
using TrionControlPanel.Desktop.Extensions.Modules;
using TrionControlPanel.Desktop.Extensions.Modules.Lists;

namespace TrionControlPanel.Desktop.Extensions.Database
{
    public class SqlQueryManager
    {
        public static string SaveRealmList(Enums.Cores SelectedCore)
        {
            return SelectedCore switch
            {
                Enums.Cores.AscEmu => "UPDATE `realms` SET `password` = @Password, `status_change_time` = @StatusChangeTime WHERE `id` = @ID;",
                Enums.Cores.AzerothCore => "UPDATE `realmlist` SET `name` = @Name, `address` = @Address, `localAddress` = @LocalAddress, `localSubnetMask` = @LocalSubnetMask, `port` = @Port, `icon` = @Icon, `flag` = @Flag, `timezone` = @Timezone WHERE `id` = @ID;",
                Enums.Cores.CMaNGOS => "UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `port` = @Port, `icon` = @Icon, `realmflags` = @Realmflags, `timezone` = @Timezone, `allowedSecurityLevel` = @AllowedSecurityLevel WHERE `id` = @ID;",
                Enums.Cores.CypherCore => "UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `localAddress` = '@LocalAddress', `localSubnetMask` = '@LocalSubnetMask', `port` = @Port, `icon` = @Icon, `flag` = @Flag, `timezone` = @Timezone WHERE `id` = @ID;",
                Enums.Cores.TrinityCore335 => $"UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `localAddress` = '@LocalAddress', `localSubnetMask` = '@LocalSubnetMask', `port` = @Port, `icon` = @Icon, `flag` = @Flag, `timezone` = @Timezone WHERE `id` = @ID;",
                Enums.Cores.TrinityCore => "UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `localAddress` = '@LocalAddress', `localSubnetMask` = '@LocalSubnetMask', `port` = @Port, `icon` = @Icon, `flag` = @Flag, `timezone` = @Timezone WHERE `id` = @ID;",
                Enums.Cores.TrinityCoreClassic => $"UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `localAddress` = '@LocalAddress', `localSubnetMask` = '@LocalSubnetMask', `port` = @Port, `icon` = @Icon, `flag` = @Flag, `timezone` = @Timezone WHERE `id` = @ID;",
                Enums.Cores.VMaNGOS => "UPDATE `realmlist` SET `name` = '@Name', `address` = '@Address', `port` = @Port, `icon` = @Icon, `realmflags` = @Realmflags, `timezone` = @Timezone WHERE `id` = @ID;",
                _ => ""
            };
        }
        public static string GetRealmList(Enums.Cores SelectedCore)
        {
            return SelectedCore switch
            {
                Enums.Cores.AscEmu => $"SELECT * FROM `realms` LIMIT 10;",
                Enums.Cores.AzerothCore => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.CMaNGOS => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.CypherCore => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.TrinityCore335 => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.TrinityCore => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.TrinityCoreClassic => $"SELECT * FROM `realmlist` LIMIT 10;",
                Enums.Cores.VMaNGOS => $"SELECT * FROM `realmlist` LIMIT 10;",
                _ => ""
            };
        }
        public static string CreateAccount(Enums.Cores SelectedCore)
        {
            switch (SelectedCore)
            {
                case Enums.Cores.AscEmu:
                    return "INSERT INTO accounts(acc_name, encrypted_password, email, joindate) VALUES (@Username, @EncryptedPassword, @Email, @JoinDate)";
                case Enums.Cores.AzerothCore:
                    return "INSERT INTO account(username, salt, verifier, email, reg_mail, joindate) VALUES(@Username, @Salt, @Verifier, @Email, @RegMail, @JoinDate)";
                case Enums.Cores.CMaNGOS:
                    return "INSERT INTO `account` (`username`, `gmlevel`, `v`, `s`, `email`, `joindate`, `expansion`) VALUES (@Username, @GMLevel, @Verifier, @Salt, @Email, @JoinDate, @Expansion)";
                case Enums.Cores.CypherCore:
                    return "INSERT INTO account(username, salt, verifier, email, joindate) VALUES (@Username, @Salt, @Verifier, @Email, @JoinDate)";
                case Enums.Cores.TrinityCore335:
                    return "INSERT INTO account(username, sha_pass_hash, email, joindate) VALUES (@Username, @ShaPassHash, @Email, @JoinDate)";
                case Enums.Cores.TrinityCore:
                    return "INSERT INTO account(username, sha_pass_hash, email, joindate) VALUES (@Username, @ShaPassHash, @Email, @JoinDate)";
                case Enums.Cores.TrinityCoreClassic:
                    return "INSERT INTO account(username, sha_pass_hash, email, joindate) VALUES (@Username, @ShaPassHash, @Email, @JoinDate)";
                case Enums.Cores.VMaNGOS:
                    return "INSERT INTO `account` (`username`, `gmlevel`, `v`, `s`, `email`, `joindate`, `expansion`) VALUES (@Username, @GMLevel, @Verifier, @Salt, @Email, @JoinDate, @Expansion)";
                default:
                    return "";
            }
        }
        public static string GetUserByUsername(Enums.Cores SelectedCore)
        {
            switch (SelectedCore)
            {
                case Enums.Cores.AscEmu:
                    return "SELECT username FROM accounts WHERE username = @Username";
                case Enums.Cores.AzerothCore:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.CMaNGOS:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.CypherCore:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.TrinityCore335:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.TrinityCore:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.TrinityCoreClassic:
                    return "SELECT username FROM account WHERE username = @Username";
                case Enums.Cores.VMaNGOS:
                    return "SELECT username FROM account WHERE username = @Username";
                default:
                    return "";
            };
        }
        public static string GetEmailByEmail(Enums.Cores SelectedCore)
        {
            switch (SelectedCore)
            {
                case Enums.Cores.AscEmu:
                    return "SELECT email FROM accounts WHERE email = @Email";
                case Enums.Cores.AzerothCore:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.CMaNGOS:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.CypherCore:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.TrinityCore335:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.TrinityCore:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.TrinityCoreClassic:
                    return "SELECT email FROM account WHERE email = @Email";
                case Enums.Cores.VMaNGOS:
                    return "SELECT email FROM account WHERE email = @Email";
                default:
                    return "";
            };
        }
    }
}
