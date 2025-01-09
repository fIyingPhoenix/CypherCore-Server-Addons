﻿
using TrionControlPanelDesktop.Extensions.Modules;

namespace TrionControlPanelDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TimerWacher = new System.Windows.Forms.Timer(components);
            NIcon = new NotifyIcon(components);
            CMSNotify = new ContextMenuStrip(components);
            OpenTSMItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            StartLogonTSMItem = new ToolStripMenuItem();
            StartWorldTSMItem = new ToolStripMenuItem();
            StartDatabaseTSMItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ExitTSMItem = new ToolStripMenuItem();
            TimerLoadingCheck = new System.Windows.Forms.Timer(components);
            TLTHome = new TrionUI.Controls.CustomToolTip();
            BTNClean = new UI.Controls.CustomButton();
            TimerCrashDetected = new System.Windows.Forms.Timer(components);
            LayoutPanelMain = new TableLayoutPanel();
            HomeMenuCard = new MaterialSkin.Controls.MaterialCard();
            BTNStartWorld = new MaterialSkin.Controls.MaterialButton();
            BTNStartDatabase = new MaterialSkin.Controls.MaterialButton();
            BTNStartLogon = new MaterialSkin.Controls.MaterialButton();
            MainFormTabControler = new MaterialSkin.Controls.MaterialTabControl();
            TabHome = new TabPage();
            LayoutPanelHome = new TableLayoutPanel();
            CardLogonResorce = new MaterialSkin.Controls.MaterialCard();
            InfoLogonResorces = new PictureBox();
            LBLCardLogonResourcesTitle = new MaterialSkin.Controls.MaterialLabel();
            LBLCPUTextLogonResources = new MaterialSkin.Controls.MaterialLabel();
            PbarRAMLogonResources = new MaterialSkin.Controls.MaterialProgressBar();
            LBLRAMTextLogonResources = new MaterialSkin.Controls.MaterialLabel();
            PbarCPULogonResources = new MaterialSkin.Controls.MaterialProgressBar();
            CardWorldResources = new MaterialSkin.Controls.MaterialCard();
            InfoWorldResorces = new PictureBox();
            LBLCardWorldResourcesTitle = new MaterialSkin.Controls.MaterialLabel();
            LBLCPUTextWorldResources = new MaterialSkin.Controls.MaterialLabel();
            PbarRAMWordResources = new MaterialSkin.Controls.MaterialProgressBar();
            LBLRAMTextWorldResources = new MaterialSkin.Controls.MaterialLabel();
            PbarCPUWordResources = new MaterialSkin.Controls.MaterialProgressBar();
            CardServerStatus = new MaterialSkin.Controls.MaterialCard();
            LayerPNLCardServerREsorce = new TableLayoutPanel();
            PNLLogonServerStatus = new MetroFramework.Controls.MetroPanel();
            LBLLogonProcessID = new Label();
            LBLUpTimeLogon = new Label();
            PICLogonServerStatus = new PictureBox();
            LBLLogonServerStatus = new Label();
            PNLWorldServerStatus = new MetroFramework.Controls.MetroPanel();
            LBLWorldProcessID = new Label();
            LBLUpTimeWorld = new Label();
            PICWorldServerStatus = new PictureBox();
            LBLWorldServerStatus = new Label();
            PNLDatanasServerStatus = new MetroFramework.Controls.MetroPanel();
            LBLDatabaseProcessID = new Label();
            LBLUpTimeDatabase = new Label();
            PICMySqlServerStatus = new PictureBox();
            LBLDatabaseServerStatus = new Label();
            CardMachineResoruces = new MaterialSkin.Controls.MaterialCard();
            InfoMachineResources = new PictureBox();
            LBLCardMachineResourcesTitle = new MaterialSkin.Controls.MaterialLabel();
            LBLCPUTextMachineResources = new MaterialSkin.Controls.MaterialLabel();
            PbarRAMMachineResources = new MaterialSkin.Controls.MaterialProgressBar();
            LBLRAMTextMachineResources = new MaterialSkin.Controls.MaterialLabel();
            PbarCPUMachineResources = new MaterialSkin.Controls.MaterialProgressBar();
            TabSPP = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            materialCard12 = new MaterialSkin.Controls.MaterialCard();
            LBLCardSPPInstaledInfo = new PictureBox();
            ChecMOPInstalled = new MaterialSkin.Controls.MaterialCheckbox();
            ChecCATAInstalled = new MaterialSkin.Controls.MaterialCheckbox();
            ChecWOTLKInstalled = new MaterialSkin.Controls.MaterialCheckbox();
            ChecTBCInstalled = new MaterialSkin.Controls.MaterialCheckbox();
            ChecCLASSICInstalled = new MaterialSkin.Controls.MaterialCheckbox();
            materialCard13 = new MaterialSkin.Controls.MaterialCard();
            TGLMoPLaunch = new MaterialSkin.Controls.MaterialSwitch();
            TGLCataLaunch = new MaterialSkin.Controls.MaterialSwitch();
            TGLWotLKLaunch = new MaterialSkin.Controls.MaterialSwitch();
            TGLTBCLaunch = new MaterialSkin.Controls.MaterialSwitch();
            TGLClassicLaunch = new MaterialSkin.Controls.MaterialSwitch();
            LBLCardElulatorsInfo = new PictureBox();
            LBLCardSPPRunTitle = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            materialCard14 = new MaterialSkin.Controls.MaterialCard();
            BTNUninstallSPP = new MaterialSkin.Controls.MaterialButton();
            BTNRepairSPP = new MaterialSkin.Controls.MaterialButton();
            BTNInstallSPP = new MaterialSkin.Controls.MaterialButton();
            CBOXSPPVersion = new MaterialSkin.Controls.MaterialComboBox();
            LBLCardSPPversionInfo = new PictureBox();
            LBLCardSPPVersionTitle = new MaterialSkin.Controls.MaterialLabel();
            pictureBox3 = new PictureBox();
            TabDatabaseEditor = new TabPage();
            DatabaseEditorLayoutPanel = new TableLayoutPanel();
            DatabaseEditorTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            DatabaseEditorTabControl = new MaterialSkin.Controls.MaterialTabControl();
            TabRealmList = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            LBLCardRealmActionInfo = new PictureBox();
            BTNForceRefresh = new MaterialSkin.Controls.MaterialButton();
            BTNEditRealmlistData = new MaterialSkin.Controls.MaterialButton();
            BTNOpenIntern = new MaterialSkin.Controls.MaterialButton();
            BTNOpenPublic = new MaterialSkin.Controls.MaterialButton();
            LBLCardRealmActionTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            BTNReviveIP = new MaterialSkin.Controls.MaterialButton();
            LBLCardRealmOptionInfo = new PictureBox();
            TXTPublicIP = new MaterialSkin.Controls.MaterialTextBox2();
            TXTInternIP = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDomainName = new MaterialSkin.Controls.MaterialTextBox2();
            CBOXReamList = new MaterialSkin.Controls.MaterialComboBox();
            LBLCardRealmOptionTitle = new MaterialSkin.Controls.MaterialLabel();
            RealmlistInfosCard = new MaterialSkin.Controls.MaterialCard();
            LBLCardRealmDataInfo = new PictureBox();
            TXTRealmGameBuild = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmPort = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmSubnetMask = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmLocalAddress = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmAddress = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmName = new MaterialSkin.Controls.MaterialTextBox2();
            TXTRealmID = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardRealmDataTitle = new MaterialSkin.Controls.MaterialLabel();
            TabAccount = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            TGLAccountShowPassword = new MaterialSkin.Controls.MaterialSwitch();
            TXTBoxPassRePassword = new MaterialSkin.Controls.MaterialTextBox2();
            TXTBoxPassPassword = new MaterialSkin.Controls.MaterialTextBox2();
            TXTBoxPassUsername = new MaterialSkin.Controls.MaterialTextBox2();
            BTNTBoxPassResset = new MaterialSkin.Controls.MaterialButton();
            LBLCardPasswordResetInfo = new PictureBox();
            LBLCardAccountPassword = new MaterialSkin.Controls.MaterialLabel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            CBoxGMRealmSelect = new MaterialSkin.Controls.MaterialComboBox();
            CBOXAccountSecurityAccess = new MaterialSkin.Controls.MaterialComboBox();
            BTNGMCreate = new MaterialSkin.Controls.MaterialButton();
            TXTBoxGMUsername = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardAccountAccessInfo = new PictureBox();
            LBLCardAccountAdmin = new MaterialSkin.Controls.MaterialLabel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            CBOXAccountExpansion = new MaterialSkin.Controls.MaterialComboBox();
            BTNAccountCreate = new MaterialSkin.Controls.MaterialButton();
            TXTBoxCreateUserEmail = new MaterialSkin.Controls.MaterialTextBox2();
            TXTBoxCreateUserPassword = new MaterialSkin.Controls.MaterialTextBox2();
            TXTBoxCreateUserUsername = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardAccountCreateInfo = new PictureBox();
            LBLCardAccountCreate = new MaterialSkin.Controls.MaterialLabel();
            TabDDNS = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            materialCard20 = new MaterialSkin.Controls.MaterialCard();
            BTNDDNSTimerStart = new MaterialSkin.Controls.MaterialButton();
            BTNDDNSServiceWebiste = new MaterialSkin.Controls.MaterialButton();
            TGLDDNSRunOnStartup = new MaterialSkin.Controls.MaterialSwitch();
            TXTDDNSInterval = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardDDNSTimerInfos = new PictureBox();
            LBLCardDDNSTimerTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard19 = new MaterialSkin.Controls.MaterialCard();
            CBOXDDNService = new MaterialSkin.Controls.MaterialComboBox();
            TXTDDNSPassword = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDDNSUsername = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDDNSDomain = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardDDNSSettingsInfo = new PictureBox();
            LBLCardDDNSSettingsTitle = new MaterialSkin.Controls.MaterialLabel();
            TabSettings = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            SettingsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            SettingsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            TabTrion = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            LBLCardCustomPreferencesInfo = new PictureBox();
            LBLCardCustomPreferencesTitle = new MaterialSkin.Controls.MaterialLabel();
            CBOXColorSelect = new MaterialSkin.Controls.MaterialComboBox();
            CBOXLanguageSelect = new MaterialSkin.Controls.MaterialComboBox();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel10 = new TableLayoutPanel();
            metroPanel7 = new MetroFramework.Controls.MetroPanel();
            LBLMoPVersion = new Label();
            metroPanel6 = new MetroFramework.Controls.MetroPanel();
            LBLCataVersion = new Label();
            metroPanel5 = new MetroFramework.Controls.MetroPanel();
            LBLWotLKVersion = new Label();
            metroPanel4 = new MetroFramework.Controls.MetroPanel();
            LBLTBCVersion = new Label();
            metroPanel3 = new MetroFramework.Controls.MetroPanel();
            LBLClassicVersion = new Label();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            LBLDBVersion = new Label();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            LBLTrionVersion = new Label();
            LBLCardUpdateDashboardInfo = new PictureBox();
            LBLCardUpdateDashboardTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            TGLAutoUpdateDatabase = new MaterialSkin.Controls.MaterialSwitch();
            TGLAutoUpdateCore = new MaterialSkin.Controls.MaterialSwitch();
            TGLAutoUpdateTrion = new MaterialSkin.Controls.MaterialSwitch();
            TGLStayInTray = new MaterialSkin.Controls.MaterialSwitch();
            TGLNotificationSound = new MaterialSkin.Controls.MaterialSwitch();
            TGLHideConsole = new MaterialSkin.Controls.MaterialSwitch();
            TGLRunTrionStartup = new MaterialSkin.Controls.MaterialSwitch();
            TGLServerStartup = new MaterialSkin.Controls.MaterialSwitch();
            TGLServerCrashDetection = new MaterialSkin.Controls.MaterialSwitch();
            TabCustom = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            TXTCustomDatabaseLocation = new MaterialSkin.Controls.MaterialTextBox2();
            TXTCustomRepackLocation = new MaterialSkin.Controls.MaterialTextBox2();
            tableLayoutPanel7 = new TableLayoutPanel();
            materialCard11 = new MaterialSkin.Controls.MaterialCard();
            BTNAscEmuWebsite = new MaterialSkin.Controls.MaterialButton();
            BTNSkyFireWebsite = new MaterialSkin.Controls.MaterialButton();
            BTNTrinityCoreWebsite = new MaterialSkin.Controls.MaterialButton();
            BTNCypherWebsite = new MaterialSkin.Controls.MaterialButton();
            BTNCMangosWebsite = new MaterialSkin.Controls.MaterialButton();
            BTNACoreWebsite = new MaterialSkin.Controls.MaterialButton();
            materialCard10 = new MaterialSkin.Controls.MaterialCard();
            TGLCustomNames = new MaterialSkin.Controls.MaterialSwitch();
            LBLCardCustomNamesInfo = new PictureBox();
            TXTCustomDatabaseName = new MaterialSkin.Controls.MaterialTextBox2();
            TXTCustomWorldName = new MaterialSkin.Controls.MaterialTextBox2();
            TXTCustomAuthName = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardCustomNamesTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard9 = new MaterialSkin.Controls.MaterialCard();
            TGLUseCustomServer = new MaterialSkin.Controls.MaterialSwitch();
            LBLCardCustomEmulatorInfo = new PictureBox();
            BTNEmulatorLocation = new MaterialSkin.Controls.MaterialButton();
            BTNDatabaseLocation = new MaterialSkin.Controls.MaterialButton();
            CBOXSelectedEmulators = new MaterialSkin.Controls.MaterialComboBox();
            LBLCardCustomEmulatorTitle = new MaterialSkin.Controls.MaterialLabel();
            TabDatabase = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            materialCard18 = new MaterialSkin.Controls.MaterialCard();
            BTNFixDatabase = new MaterialSkin.Controls.MaterialButton();
            BTNLoadBackup = new MaterialSkin.Controls.MaterialButton();
            BTNDatabaseBackup = new MaterialSkin.Controls.MaterialButton();
            TGLWorldBackup = new MaterialSkin.Controls.MaterialSwitch();
            TGLCharBackup = new MaterialSkin.Controls.MaterialSwitch();
            TGLAuthBackup = new MaterialSkin.Controls.MaterialSwitch();
            LBLCardDatabaseBCInfo = new PictureBox();
            LBLCardDatabaseBCTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard17 = new MaterialSkin.Controls.MaterialCard();
            TGLCustomDB = new MaterialSkin.Controls.MaterialSwitch();
            TGLMopDB = new MaterialSkin.Controls.MaterialSwitch();
            TGLCataDB = new MaterialSkin.Controls.MaterialSwitch();
            TGLWotlkDB = new MaterialSkin.Controls.MaterialSwitch();
            TGLTbcDB = new MaterialSkin.Controls.MaterialSwitch();
            TGLClassicDB = new MaterialSkin.Controls.MaterialSwitch();
            LBLCardPreconfiguredDBInfo = new PictureBox();
            LBLCardPreconfiguredDBTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard16 = new MaterialSkin.Controls.MaterialCard();
            BTNDeleteWorld = new MaterialSkin.Controls.MaterialButton();
            BTNDeleteChar = new MaterialSkin.Controls.MaterialButton();
            BTNDeleteAuth = new MaterialSkin.Controls.MaterialButton();
            TXTWorldDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            TXTCharDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            TXTAuthDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardTableNameInfo = new PictureBox();
            LBLCardTableNameTitle = new MaterialSkin.Controls.MaterialLabel();
            materialCard15 = new MaterialSkin.Controls.MaterialCard();
            LBLCardDatabaseCredencialsInfo = new PictureBox();
            BTNTestConnection = new MaterialSkin.Controls.MaterialButton();
            TXTDatabasePassword = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDatabaseUser = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDatabasePort = new MaterialSkin.Controls.MaterialTextBox2();
            TXTDatabaseHost = new MaterialSkin.Controls.MaterialTextBox2();
            LBLCardDatabaseCredencialsTitle = new MaterialSkin.Controls.MaterialLabel();
            TabNotification = new TabPage();
            tableLayoutPanel11 = new TableLayoutPanel();
            DGVNotifications = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            IMGListTabControler = new ImageList(components);
            CMSNotify.SuspendLayout();
            LayoutPanelMain.SuspendLayout();
            HomeMenuCard.SuspendLayout();
            MainFormTabControler.SuspendLayout();
            TabHome.SuspendLayout();
            LayoutPanelHome.SuspendLayout();
            CardLogonResorce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoLogonResorces).BeginInit();
            CardWorldResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoWorldResorces).BeginInit();
            CardServerStatus.SuspendLayout();
            LayerPNLCardServerREsorce.SuspendLayout();
            PNLLogonServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PICLogonServerStatus).BeginInit();
            PNLWorldServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PICWorldServerStatus).BeginInit();
            PNLDatanasServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PICMySqlServerStatus).BeginInit();
            CardMachineResoruces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoMachineResources).BeginInit();
            TabSPP.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            materialCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardSPPInstaledInfo).BeginInit();
            materialCard13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardElulatorsInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardSPPversionInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            TabDatabaseEditor.SuspendLayout();
            DatabaseEditorLayoutPanel.SuspendLayout();
            DatabaseEditorTabControl.SuspendLayout();
            TabRealmList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmActionInfo).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmOptionInfo).BeginInit();
            RealmlistInfosCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmDataInfo).BeginInit();
            TabAccount.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardPasswordResetInfo).BeginInit();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardAccountAccessInfo).BeginInit();
            materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardAccountCreateInfo).BeginInit();
            TabDDNS.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            materialCard20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDDNSTimerInfos).BeginInit();
            materialCard19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDDNSSettingsInfo).BeginInit();
            TabSettings.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SettingsTabControl.SuspendLayout();
            TabTrion.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomPreferencesInfo).BeginInit();
            materialCard7.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            metroPanel7.SuspendLayout();
            metroPanel6.SuspendLayout();
            metroPanel5.SuspendLayout();
            metroPanel4.SuspendLayout();
            metroPanel3.SuspendLayout();
            metroPanel2.SuspendLayout();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardUpdateDashboardInfo).BeginInit();
            materialCard8.SuspendLayout();
            TabCustom.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            materialCard11.SuspendLayout();
            materialCard10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomNamesInfo).BeginInit();
            materialCard9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomEmulatorInfo).BeginInit();
            TabDatabase.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            materialCard18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDatabaseBCInfo).BeginInit();
            materialCard17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardPreconfiguredDBInfo).BeginInit();
            materialCard16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardTableNameInfo).BeginInit();
            materialCard15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDatabaseCredencialsInfo).BeginInit();
            TabNotification.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVNotifications).BeginInit();
            SuspendLayout();
            // 
            // TimerWacher
            // 
            TimerWacher.Enabled = true;
            TimerWacher.Interval = 1000;
            TimerWacher.Tick += TimerWacher_Tick;
            // 
            // NIcon
            // 
            NIcon.BalloonTipIcon = ToolTipIcon.Info;
            NIcon.BalloonTipText = "Control Panel for World of Warcraft Emulators!";
            NIcon.BalloonTipTitle = "Trion Control Panel";
            NIcon.ContextMenuStrip = CMSNotify;
            NIcon.Icon = (Icon)resources.GetObject("NIcon.Icon");
            NIcon.Text = "Trion Control Panel";
            // 
            // CMSNotify
            // 
            CMSNotify.BackColor = Color.FromArgb(28, 33, 40);
            CMSNotify.ImageScalingSize = new Size(20, 20);
            CMSNotify.Items.AddRange(new ToolStripItem[] { OpenTSMItem, toolStripSeparator1, StartLogonTSMItem, StartWorldTSMItem, StartDatabaseTSMItem, toolStripSeparator2, ExitTSMItem });
            CMSNotify.Name = "contextMenuStrip1";
            CMSNotify.RenderMode = ToolStripRenderMode.System;
            CMSNotify.Size = new Size(138, 196);
            // 
            // OpenTSMItem
            // 
            OpenTSMItem.BackgroundImageLayout = ImageLayout.Stretch;
            OpenTSMItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenTSMItem.ForeColor = Color.White;
            OpenTSMItem.ImageAlign = ContentAlignment.MiddleLeft;
            OpenTSMItem.Name = "OpenTSMItem";
            OpenTSMItem.Size = new Size(137, 36);
            OpenTSMItem.Text = "Open";
            OpenTSMItem.Click += OpenTSMItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // StartLogonTSMItem
            // 
            StartLogonTSMItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartLogonTSMItem.ForeColor = Color.White;
            StartLogonTSMItem.Image = (Image)resources.GetObject("StartLogonTSMItem.Image");
            StartLogonTSMItem.ImageScaling = ToolStripItemImageScaling.None;
            StartLogonTSMItem.Name = "StartLogonTSMItem";
            StartLogonTSMItem.Size = new Size(137, 36);
            StartLogonTSMItem.Text = "Logon";
            StartLogonTSMItem.Click += StartLogonTSMItem_Click;
            // 
            // StartWorldTSMItem
            // 
            StartWorldTSMItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartWorldTSMItem.ForeColor = Color.White;
            StartWorldTSMItem.ImageScaling = ToolStripItemImageScaling.None;
            StartWorldTSMItem.Name = "StartWorldTSMItem";
            StartWorldTSMItem.Size = new Size(137, 36);
            StartWorldTSMItem.Text = "World";
            StartWorldTSMItem.Click += StartWorldTSMItem_Click;
            // 
            // StartDatabaseTSMItem
            // 
            StartDatabaseTSMItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDatabaseTSMItem.ForeColor = Color.White;
            StartDatabaseTSMItem.Image = (Image)resources.GetObject("StartDatabaseTSMItem.Image");
            StartDatabaseTSMItem.ImageScaling = ToolStripItemImageScaling.None;
            StartDatabaseTSMItem.Name = "StartDatabaseTSMItem";
            StartDatabaseTSMItem.Size = new Size(137, 36);
            StartDatabaseTSMItem.Text = "Database";
            StartDatabaseTSMItem.Click += StartDatabaseTSMItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(134, 6);
            // 
            // ExitTSMItem
            // 
            ExitTSMItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitTSMItem.ForeColor = Color.White;
            ExitTSMItem.Name = "ExitTSMItem";
            ExitTSMItem.Size = new Size(137, 36);
            ExitTSMItem.Text = "Exit";
            ExitTSMItem.Click += ExitTSMItem_ClickAsync;
            // 
            // TimerLoadingCheck
            // 
            TimerLoadingCheck.Enabled = true;
            TimerLoadingCheck.Interval = 15000;
            // 
            // TLTHome
            // 
            TLTHome.BackColor = Color.White;
            TLTHome.BackgroundColor = Color.FromArgb(34, 39, 46);
            TLTHome.BorderColor = Color.FromArgb(0, 174, 219);
            TLTHome.BorderSize = 1;
            TLTHome.ForeColor = Color.WhiteSmoke;
            TLTHome.LinkColor = Color.DodgerBlue;
            TLTHome.LinkEnabled = false;
            TLTHome.LinkText = "";
            TLTHome.OwnerDraw = true;
            TLTHome.StripAmpersands = true;
            TLTHome.TextColor = Color.White;
            TLTHome.TextFont = new Font("Segoe UI Semibold", 10F);
            TLTHome.TitleBackgroundColor = Color.FromArgb(28, 33, 40);
            TLTHome.TitleColor = Color.FromArgb(0, 174, 219);
            TLTHome.ToolTipIcon = ToolTipIcon.Info;
            TLTHome.ToolTipTitle = "Information!";
            // 
            // BTNClean
            // 
            BTNClean.BackColor = Color.FromArgb(28, 33, 40);
            BTNClean.BackgroundColor = Color.FromArgb(28, 33, 40);
            BTNClean.BorderColor = Color.Black;
            BTNClean.BorderRadius = 0;
            BTNClean.BorderSize = 1;
            BTNClean.Cursor = Cursors.Hand;
            BTNClean.Dock = DockStyle.Fill;
            BTNClean.FlatAppearance.BorderSize = 0;
            BTNClean.FlatStyle = FlatStyle.Flat;
            BTNClean.ForeColor = Color.White;
            BTNClean.Image = (Image)resources.GetObject("BTNClean.Image");
            BTNClean.Location = new Point(3, 390);
            BTNClean.Name = "BTNClean";
            BTNClean.NotificationCount = 0;
            BTNClean.Size = new Size(942, 38);
            BTNClean.TabIndex = 38;
            BTNClean.TextColor = Color.White;
            TLTHome.SetToolTip(BTNClean, "Clear notification history.");
            BTNClean.UseVisualStyleBackColor = false;
            // 
            // TimerCrashDetected
            // 
            TimerCrashDetected.Enabled = true;
            TimerCrashDetected.Interval = 5000;
            // 
            // LayoutPanelMain
            // 
            LayoutPanelMain.ColumnCount = 1;
            LayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutPanelMain.Controls.Add(HomeMenuCard, 0, 1);
            LayoutPanelMain.Controls.Add(MainFormTabControler, 0, 0);
            LayoutPanelMain.Dock = DockStyle.Fill;
            LayoutPanelMain.Location = new Point(0, 72);
            LayoutPanelMain.Name = "LayoutPanelMain";
            LayoutPanelMain.RowCount = 2;
            LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LayoutPanelMain.Size = new Size(997, 525);
            LayoutPanelMain.TabIndex = 9;
            // 
            // HomeMenuCard
            // 
            HomeMenuCard.BackColor = Color.FromArgb(255, 255, 255);
            HomeMenuCard.Controls.Add(BTNStartWorld);
            HomeMenuCard.Controls.Add(BTNStartDatabase);
            HomeMenuCard.Controls.Add(BTNStartLogon);
            HomeMenuCard.Depth = 0;
            HomeMenuCard.Dock = DockStyle.Fill;
            HomeMenuCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            HomeMenuCard.Location = new Point(10, 449);
            HomeMenuCard.Margin = new Padding(10, 4, 10, 10);
            HomeMenuCard.MouseState = MaterialSkin.MouseState.HOVER;
            HomeMenuCard.Name = "HomeMenuCard";
            HomeMenuCard.Padding = new Padding(4);
            HomeMenuCard.Size = new Size(977, 66);
            HomeMenuCard.TabIndex = 0;
            // 
            // BTNStartWorld
            // 
            BTNStartWorld.Anchor = AnchorStyles.Top;
            BTNStartWorld.AutoSize = false;
            BTNStartWorld.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNStartWorld.Cursor = Cursors.Hand;
            BTNStartWorld.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNStartWorld.Depth = 0;
            BTNStartWorld.HighEmphasis = true;
            BTNStartWorld.Icon = (Image)resources.GetObject("BTNStartWorld.Icon");
            BTNStartWorld.Location = new Point(634, 16);
            BTNStartWorld.Margin = new Padding(4, 6, 4, 6);
            BTNStartWorld.MouseState = MaterialSkin.MouseState.HOVER;
            BTNStartWorld.Name = "BTNStartWorld";
            BTNStartWorld.NoAccentTextColor = Color.Empty;
            BTNStartWorld.Size = new Size(278, 36);
            BTNStartWorld.TabIndex = 8;
            BTNStartWorld.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNStartWorld.UseAccentColor = false;
            BTNStartWorld.UseVisualStyleBackColor = true;
            BTNStartWorld.Click += BTNStartWorld_Click;
            // 
            // BTNStartDatabase
            // 
            BTNStartDatabase.Anchor = AnchorStyles.Top;
            BTNStartDatabase.AutoSize = false;
            BTNStartDatabase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNStartDatabase.Cursor = Cursors.Hand;
            BTNStartDatabase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNStartDatabase.Depth = 0;
            BTNStartDatabase.HighEmphasis = true;
            BTNStartDatabase.Icon = (Image)resources.GetObject("BTNStartDatabase.Icon");
            BTNStartDatabase.Location = new Point(62, 16);
            BTNStartDatabase.Margin = new Padding(4, 6, 4, 6);
            BTNStartDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            BTNStartDatabase.Name = "BTNStartDatabase";
            BTNStartDatabase.NoAccentTextColor = Color.Empty;
            BTNStartDatabase.Size = new Size(278, 36);
            BTNStartDatabase.TabIndex = 7;
            BTNStartDatabase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNStartDatabase.UseAccentColor = false;
            BTNStartDatabase.UseVisualStyleBackColor = true;
            BTNStartDatabase.Click += BTNStartDatabase_Click;
            // 
            // BTNStartLogon
            // 
            BTNStartLogon.Anchor = AnchorStyles.Top;
            BTNStartLogon.AutoSize = false;
            BTNStartLogon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNStartLogon.Cursor = Cursors.Hand;
            BTNStartLogon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNStartLogon.Depth = 0;
            BTNStartLogon.HighEmphasis = true;
            BTNStartLogon.Icon = (Image)resources.GetObject("BTNStartLogon.Icon");
            BTNStartLogon.Location = new Point(348, 16);
            BTNStartLogon.Margin = new Padding(4, 6, 4, 6);
            BTNStartLogon.MouseState = MaterialSkin.MouseState.HOVER;
            BTNStartLogon.Name = "BTNStartLogon";
            BTNStartLogon.NoAccentTextColor = Color.Empty;
            BTNStartLogon.Size = new Size(278, 36);
            BTNStartLogon.TabIndex = 6;
            BTNStartLogon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNStartLogon.UseAccentColor = false;
            BTNStartLogon.UseVisualStyleBackColor = true;
            BTNStartLogon.Click += BTNStartLogon_Click;
            // 
            // MainFormTabControler
            // 
            MainFormTabControler.Alignment = TabAlignment.Left;
            MainFormTabControler.Controls.Add(TabHome);
            MainFormTabControler.Controls.Add(TabSPP);
            MainFormTabControler.Controls.Add(TabDatabaseEditor);
            MainFormTabControler.Controls.Add(TabDDNS);
            MainFormTabControler.Controls.Add(TabSettings);
            MainFormTabControler.Controls.Add(TabNotification);
            MainFormTabControler.Depth = 0;
            MainFormTabControler.Dock = DockStyle.Fill;
            MainFormTabControler.ImageList = IMGListTabControler;
            MainFormTabControler.Location = new Point(3, 3);
            MainFormTabControler.MouseState = MaterialSkin.MouseState.HOVER;
            MainFormTabControler.Multiline = true;
            MainFormTabControler.Name = "MainFormTabControler";
            MainFormTabControler.SelectedIndex = 0;
            MainFormTabControler.Size = new Size(991, 439);
            MainFormTabControler.TabIndex = 1;
            // 
            // TabHome
            // 
            TabHome.BackColor = Color.White;
            TabHome.Controls.Add(LayoutPanelHome);
            TabHome.ImageKey = "menu-35.png";
            TabHome.Location = new Point(39, 4);
            TabHome.Name = "TabHome";
            TabHome.Padding = new Padding(3);
            TabHome.Size = new Size(948, 431);
            TabHome.TabIndex = 0;
            TabHome.Text = "H";
            // 
            // LayoutPanelHome
            // 
            LayoutPanelHome.ColumnCount = 2;
            LayoutPanelHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelHome.Controls.Add(CardLogonResorce, 1, 1);
            LayoutPanelHome.Controls.Add(CardWorldResources, 0, 1);
            LayoutPanelHome.Controls.Add(CardServerStatus, 0, 0);
            LayoutPanelHome.Controls.Add(CardMachineResoruces, 1, 0);
            LayoutPanelHome.Dock = DockStyle.Fill;
            LayoutPanelHome.ForeColor = SystemColors.Control;
            LayoutPanelHome.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LayoutPanelHome.Location = new Point(3, 3);
            LayoutPanelHome.Name = "LayoutPanelHome";
            LayoutPanelHome.RowCount = 2;
            LayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LayoutPanelHome.Size = new Size(942, 425);
            LayoutPanelHome.TabIndex = 0;
            // 
            // CardLogonResorce
            // 
            CardLogonResorce.BackColor = Color.FromArgb(255, 255, 255);
            CardLogonResorce.Controls.Add(InfoLogonResorces);
            CardLogonResorce.Controls.Add(LBLCardLogonResourcesTitle);
            CardLogonResorce.Controls.Add(LBLCPUTextLogonResources);
            CardLogonResorce.Controls.Add(PbarRAMLogonResources);
            CardLogonResorce.Controls.Add(LBLRAMTextLogonResources);
            CardLogonResorce.Controls.Add(PbarCPULogonResources);
            CardLogonResorce.Depth = 0;
            CardLogonResorce.Dock = DockStyle.Fill;
            CardLogonResorce.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardLogonResorce.Location = new Point(475, 216);
            CardLogonResorce.Margin = new Padding(4);
            CardLogonResorce.MouseState = MaterialSkin.MouseState.HOVER;
            CardLogonResorce.Name = "CardLogonResorce";
            CardLogonResorce.Padding = new Padding(4);
            CardLogonResorce.Size = new Size(463, 205);
            CardLogonResorce.TabIndex = 7;
            // 
            // InfoLogonResorces
            // 
            InfoLogonResorces.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InfoLogonResorces.BackgroundImageLayout = ImageLayout.Stretch;
            InfoLogonResorces.Image = (Image)resources.GetObject("InfoLogonResorces.Image");
            InfoLogonResorces.Location = new Point(440, 10);
            InfoLogonResorces.Name = "InfoLogonResorces";
            InfoLogonResorces.Size = new Size(16, 16);
            InfoLogonResorces.TabIndex = 0;
            InfoLogonResorces.TabStop = false;
            // 
            // LBLCardLogonResourcesTitle
            // 
            LBLCardLogonResourcesTitle.AutoSize = true;
            LBLCardLogonResourcesTitle.Depth = 0;
            LBLCardLogonResourcesTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardLogonResourcesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardLogonResourcesTitle.HighEmphasis = true;
            LBLCardLogonResourcesTitle.Location = new Point(10, 10);
            LBLCardLogonResourcesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardLogonResourcesTitle.Name = "LBLCardLogonResourcesTitle";
            LBLCardLogonResourcesTitle.Size = new Size(133, 24);
            LBLCardLogonResourcesTitle.TabIndex = 1;
            LBLCardLogonResourcesTitle.Text = "logon resource";
            // 
            // LBLCPUTextLogonResources
            // 
            LBLCPUTextLogonResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLCPUTextLogonResources.Depth = 0;
            LBLCPUTextLogonResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCPUTextLogonResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLCPUTextLogonResources.Location = new Point(30, 140);
            LBLCPUTextLogonResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCPUTextLogonResources.Name = "LBLCPUTextLogonResources";
            LBLCPUTextLogonResources.Size = new Size(401, 15);
            LBLCPUTextLogonResources.TabIndex = 5;
            LBLCPUTextLogonResources.Text = "Central Processing Unit (CPU)";
            LBLCPUTextLogonResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarRAMLogonResources
            // 
            PbarRAMLogonResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarRAMLogonResources.Depth = 0;
            PbarRAMLogonResources.Location = new Point(30, 95);
            PbarRAMLogonResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarRAMLogonResources.Name = "PbarRAMLogonResources";
            PbarRAMLogonResources.PbarHeight = 15;
            PbarRAMLogonResources.ProgressText = "MB";
            PbarRAMLogonResources.Size = new Size(401, 15);
            PbarRAMLogonResources.Style = ProgressBarStyle.Continuous;
            PbarRAMLogonResources.TabIndex = 1;
            PbarRAMLogonResources.TextColor = Color.White;
            PbarRAMLogonResources.UsaeProcentage = false;
            // 
            // LBLRAMTextLogonResources
            // 
            LBLRAMTextLogonResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLRAMTextLogonResources.Depth = 0;
            LBLRAMTextLogonResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLRAMTextLogonResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLRAMTextLogonResources.Location = new Point(30, 75);
            LBLRAMTextLogonResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLRAMTextLogonResources.Name = "LBLRAMTextLogonResources";
            LBLRAMTextLogonResources.Size = new Size(401, 15);
            LBLRAMTextLogonResources.TabIndex = 3;
            LBLRAMTextLogonResources.Text = "Random-Acess Memory  (RAM)";
            LBLRAMTextLogonResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarCPULogonResources
            // 
            PbarCPULogonResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarCPULogonResources.Depth = 0;
            PbarCPULogonResources.Location = new Point(30, 160);
            PbarCPULogonResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarCPULogonResources.Name = "PbarCPULogonResources";
            PbarCPULogonResources.PbarHeight = 15;
            PbarCPULogonResources.ProgressText = "%";
            PbarCPULogonResources.Size = new Size(401, 15);
            PbarCPULogonResources.TabIndex = 4;
            PbarCPULogonResources.TextColor = Color.White;
            PbarCPULogonResources.UsaeProcentage = true;
            // 
            // CardWorldResources
            // 
            CardWorldResources.BackColor = Color.FromArgb(255, 255, 255);
            CardWorldResources.Controls.Add(InfoWorldResorces);
            CardWorldResources.Controls.Add(LBLCardWorldResourcesTitle);
            CardWorldResources.Controls.Add(LBLCPUTextWorldResources);
            CardWorldResources.Controls.Add(PbarRAMWordResources);
            CardWorldResources.Controls.Add(LBLRAMTextWorldResources);
            CardWorldResources.Controls.Add(PbarCPUWordResources);
            CardWorldResources.Depth = 0;
            CardWorldResources.Dock = DockStyle.Fill;
            CardWorldResources.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardWorldResources.Location = new Point(4, 216);
            CardWorldResources.Margin = new Padding(4);
            CardWorldResources.MouseState = MaterialSkin.MouseState.HOVER;
            CardWorldResources.Name = "CardWorldResources";
            CardWorldResources.Padding = new Padding(4);
            CardWorldResources.Size = new Size(463, 205);
            CardWorldResources.TabIndex = 6;
            // 
            // InfoWorldResorces
            // 
            InfoWorldResorces.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InfoWorldResorces.BackgroundImageLayout = ImageLayout.Stretch;
            InfoWorldResorces.Image = (Image)resources.GetObject("InfoWorldResorces.Image");
            InfoWorldResorces.Location = new Point(440, 10);
            InfoWorldResorces.Name = "InfoWorldResorces";
            InfoWorldResorces.Size = new Size(16, 16);
            InfoWorldResorces.TabIndex = 0;
            InfoWorldResorces.TabStop = false;
            // 
            // LBLCardWorldResourcesTitle
            // 
            LBLCardWorldResourcesTitle.AutoSize = true;
            LBLCardWorldResourcesTitle.Depth = 0;
            LBLCardWorldResourcesTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardWorldResourcesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardWorldResourcesTitle.HighEmphasis = true;
            LBLCardWorldResourcesTitle.Location = new Point(10, 10);
            LBLCardWorldResourcesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardWorldResourcesTitle.Name = "LBLCardWorldResourcesTitle";
            LBLCardWorldResourcesTitle.Size = new Size(260, 24);
            LBLCardWorldResourcesTitle.TabIndex = 1;
            LBLCardWorldResourcesTitle.Text = "WORLD SERVER RESOURCES";
            // 
            // LBLCPUTextWorldResources
            // 
            LBLCPUTextWorldResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLCPUTextWorldResources.Depth = 0;
            LBLCPUTextWorldResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCPUTextWorldResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLCPUTextWorldResources.Location = new Point(30, 140);
            LBLCPUTextWorldResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCPUTextWorldResources.Name = "LBLCPUTextWorldResources";
            LBLCPUTextWorldResources.Size = new Size(401, 15);
            LBLCPUTextWorldResources.TabIndex = 5;
            LBLCPUTextWorldResources.Text = "Central Processing Unit (CPU)";
            LBLCPUTextWorldResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarRAMWordResources
            // 
            PbarRAMWordResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarRAMWordResources.Depth = 0;
            PbarRAMWordResources.Location = new Point(30, 95);
            PbarRAMWordResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarRAMWordResources.Name = "PbarRAMWordResources";
            PbarRAMWordResources.PbarHeight = 15;
            PbarRAMWordResources.ProgressText = "MB";
            PbarRAMWordResources.Size = new Size(401, 15);
            PbarRAMWordResources.Style = ProgressBarStyle.Continuous;
            PbarRAMWordResources.TabIndex = 1;
            PbarRAMWordResources.TextColor = Color.White;
            PbarRAMWordResources.UsaeProcentage = false;
            // 
            // LBLRAMTextWorldResources
            // 
            LBLRAMTextWorldResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLRAMTextWorldResources.Depth = 0;
            LBLRAMTextWorldResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLRAMTextWorldResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLRAMTextWorldResources.Location = new Point(30, 75);
            LBLRAMTextWorldResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLRAMTextWorldResources.Name = "LBLRAMTextWorldResources";
            LBLRAMTextWorldResources.Size = new Size(401, 15);
            LBLRAMTextWorldResources.TabIndex = 3;
            LBLRAMTextWorldResources.Text = "Random-Access Memory  (RAM)";
            LBLRAMTextWorldResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarCPUWordResources
            // 
            PbarCPUWordResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarCPUWordResources.Depth = 0;
            PbarCPUWordResources.Location = new Point(30, 160);
            PbarCPUWordResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarCPUWordResources.Name = "PbarCPUWordResources";
            PbarCPUWordResources.PbarHeight = 15;
            PbarCPUWordResources.ProgressText = "%";
            PbarCPUWordResources.Size = new Size(401, 15);
            PbarCPUWordResources.TabIndex = 4;
            PbarCPUWordResources.TextColor = Color.White;
            PbarCPUWordResources.UsaeProcentage = true;
            // 
            // CardServerStatus
            // 
            CardServerStatus.BackColor = Color.FromArgb(255, 255, 255);
            CardServerStatus.Controls.Add(LayerPNLCardServerREsorce);
            CardServerStatus.Depth = 0;
            CardServerStatus.Dock = DockStyle.Fill;
            CardServerStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardServerStatus.Location = new Point(4, 4);
            CardServerStatus.Margin = new Padding(4);
            CardServerStatus.MouseState = MaterialSkin.MouseState.HOVER;
            CardServerStatus.Name = "CardServerStatus";
            CardServerStatus.Padding = new Padding(4);
            CardServerStatus.Size = new Size(463, 204);
            CardServerStatus.TabIndex = 5;
            // 
            // LayerPNLCardServerREsorce
            // 
            LayerPNLCardServerREsorce.ColumnCount = 1;
            LayerPNLCardServerREsorce.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayerPNLCardServerREsorce.Controls.Add(PNLLogonServerStatus, 0, 2);
            LayerPNLCardServerREsorce.Controls.Add(PNLWorldServerStatus, 0, 1);
            LayerPNLCardServerREsorce.Controls.Add(PNLDatanasServerStatus, 0, 0);
            LayerPNLCardServerREsorce.Dock = DockStyle.Fill;
            LayerPNLCardServerREsorce.Location = new Point(4, 4);
            LayerPNLCardServerREsorce.Name = "LayerPNLCardServerREsorce";
            LayerPNLCardServerREsorce.RowCount = 3;
            LayerPNLCardServerREsorce.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            LayerPNLCardServerREsorce.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            LayerPNLCardServerREsorce.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            LayerPNLCardServerREsorce.Size = new Size(455, 196);
            LayerPNLCardServerREsorce.TabIndex = 1;
            // 
            // PNLLogonServerStatus
            // 
            PNLLogonServerStatus.BackColor = Color.FromArgb(28, 33, 40);
            PNLLogonServerStatus.Border = true;
            PNLLogonServerStatus.BorderColor = Color.FromArgb(192, 0, 0);
            PNLLogonServerStatus.BorderSize = 1;
            PNLLogonServerStatus.Controls.Add(LBLLogonProcessID);
            PNLLogonServerStatus.Controls.Add(LBLUpTimeLogon);
            PNLLogonServerStatus.Controls.Add(PICLogonServerStatus);
            PNLLogonServerStatus.Controls.Add(LBLLogonServerStatus);
            PNLLogonServerStatus.CustomBackground = true;
            PNLLogonServerStatus.Dock = DockStyle.Fill;
            PNLLogonServerStatus.HorizontalScrollbar = true;
            PNLLogonServerStatus.HorizontalScrollbarBarColor = true;
            PNLLogonServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            PNLLogonServerStatus.HorizontalScrollbarSize = 10;
            PNLLogonServerStatus.Location = new Point(3, 133);
            PNLLogonServerStatus.Name = "PNLLogonServerStatus";
            PNLLogonServerStatus.Padding = new Padding(2);
            PNLLogonServerStatus.Size = new Size(449, 60);
            PNLLogonServerStatus.Style = MetroFramework.MetroColorStyle.Blue;
            PNLLogonServerStatus.StyleManager = null;
            PNLLogonServerStatus.TabIndex = 37;
            PNLLogonServerStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            PNLLogonServerStatus.VerticalScrollbar = true;
            PNLLogonServerStatus.VerticalScrollbarBarColor = true;
            PNLLogonServerStatus.VerticalScrollbarHighlightOnWheel = false;
            PNLLogonServerStatus.VerticalScrollbarSize = 10;
            // 
            // LBLLogonProcessID
            // 
            LBLLogonProcessID.Anchor = AnchorStyles.Left;
            LBLLogonProcessID.AutoSize = true;
            LBLLogonProcessID.ForeColor = Color.White;
            LBLLogonProcessID.Location = new Point(166, 31);
            LBLLogonProcessID.Name = "LBLLogonProcessID";
            LBLLogonProcessID.Size = new Size(66, 15);
            LBLLogonProcessID.TabIndex = 47;
            LBLLogonProcessID.Text = "Process ID:";
            // 
            // LBLUpTimeLogon
            // 
            LBLUpTimeLogon.Anchor = AnchorStyles.Left;
            LBLUpTimeLogon.AutoSize = true;
            LBLUpTimeLogon.ForeColor = Color.White;
            LBLUpTimeLogon.Location = new Point(166, 11);
            LBLUpTimeLogon.Name = "LBLUpTimeLogon";
            LBLUpTimeLogon.Size = new Size(46, 15);
            LBLUpTimeLogon.TabIndex = 46;
            LBLUpTimeLogon.Text = "Uptime";
            // 
            // PICLogonServerStatus
            // 
            PICLogonServerStatus.Anchor = AnchorStyles.Left;
            PICLogonServerStatus.Image = (Image)resources.GetObject("PICLogonServerStatus.Image");
            PICLogonServerStatus.Location = new Point(10, 12);
            PICLogonServerStatus.Name = "PICLogonServerStatus";
            PICLogonServerStatus.Size = new Size(35, 35);
            PICLogonServerStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            PICLogonServerStatus.TabIndex = 44;
            PICLogonServerStatus.TabStop = false;
            // 
            // LBLLogonServerStatus
            // 
            LBLLogonServerStatus.Anchor = AnchorStyles.Left;
            LBLLogonServerStatus.AutoSize = true;
            LBLLogonServerStatus.Font = new Font("Segoe UI", 12F);
            LBLLogonServerStatus.ForeColor = Color.White;
            LBLLogonServerStatus.Location = new Point(50, 20);
            LBLLogonServerStatus.Name = "LBLLogonServerStatus";
            LBLLogonServerStatus.Size = new Size(54, 21);
            LBLLogonServerStatus.TabIndex = 45;
            LBLLogonServerStatus.Text = "Logon";
            // 
            // PNLWorldServerStatus
            // 
            PNLWorldServerStatus.BackColor = Color.FromArgb(28, 33, 40);
            PNLWorldServerStatus.Border = true;
            PNLWorldServerStatus.BorderColor = Color.FromArgb(192, 0, 0);
            PNLWorldServerStatus.BorderSize = 1;
            PNLWorldServerStatus.Controls.Add(LBLWorldProcessID);
            PNLWorldServerStatus.Controls.Add(LBLUpTimeWorld);
            PNLWorldServerStatus.Controls.Add(PICWorldServerStatus);
            PNLWorldServerStatus.Controls.Add(LBLWorldServerStatus);
            PNLWorldServerStatus.CustomBackground = true;
            PNLWorldServerStatus.Dock = DockStyle.Fill;
            PNLWorldServerStatus.HorizontalScrollbar = true;
            PNLWorldServerStatus.HorizontalScrollbarBarColor = true;
            PNLWorldServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            PNLWorldServerStatus.HorizontalScrollbarSize = 10;
            PNLWorldServerStatus.Location = new Point(3, 68);
            PNLWorldServerStatus.Name = "PNLWorldServerStatus";
            PNLWorldServerStatus.Padding = new Padding(2);
            PNLWorldServerStatus.Size = new Size(449, 59);
            PNLWorldServerStatus.Style = MetroFramework.MetroColorStyle.Blue;
            PNLWorldServerStatus.StyleManager = null;
            PNLWorldServerStatus.TabIndex = 36;
            PNLWorldServerStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            PNLWorldServerStatus.VerticalScrollbar = true;
            PNLWorldServerStatus.VerticalScrollbarBarColor = true;
            PNLWorldServerStatus.VerticalScrollbarHighlightOnWheel = false;
            PNLWorldServerStatus.VerticalScrollbarSize = 10;
            // 
            // LBLWorldProcessID
            // 
            LBLWorldProcessID.Anchor = AnchorStyles.Left;
            LBLWorldProcessID.AutoSize = true;
            LBLWorldProcessID.ForeColor = Color.White;
            LBLWorldProcessID.Location = new Point(166, 32);
            LBLWorldProcessID.Name = "LBLWorldProcessID";
            LBLWorldProcessID.Size = new Size(66, 15);
            LBLWorldProcessID.TabIndex = 47;
            LBLWorldProcessID.Text = "Process ID:";
            // 
            // LBLUpTimeWorld
            // 
            LBLUpTimeWorld.Anchor = AnchorStyles.Left;
            LBLUpTimeWorld.AutoSize = true;
            LBLUpTimeWorld.ForeColor = Color.White;
            LBLUpTimeWorld.Location = new Point(166, 12);
            LBLUpTimeWorld.Name = "LBLUpTimeWorld";
            LBLUpTimeWorld.Size = new Size(46, 15);
            LBLUpTimeWorld.TabIndex = 46;
            LBLUpTimeWorld.Text = "Uptime";
            // 
            // PICWorldServerStatus
            // 
            PICWorldServerStatus.Anchor = AnchorStyles.Left;
            PICWorldServerStatus.Image = (Image)resources.GetObject("PICWorldServerStatus.Image");
            PICWorldServerStatus.Location = new Point(10, 12);
            PICWorldServerStatus.Name = "PICWorldServerStatus";
            PICWorldServerStatus.Size = new Size(35, 35);
            PICWorldServerStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            PICWorldServerStatus.TabIndex = 44;
            PICWorldServerStatus.TabStop = false;
            // 
            // LBLWorldServerStatus
            // 
            LBLWorldServerStatus.Anchor = AnchorStyles.Left;
            LBLWorldServerStatus.AutoSize = true;
            LBLWorldServerStatus.Font = new Font("Segoe UI", 12F);
            LBLWorldServerStatus.ForeColor = Color.White;
            LBLWorldServerStatus.Location = new Point(50, 20);
            LBLWorldServerStatus.Name = "LBLWorldServerStatus";
            LBLWorldServerStatus.Size = new Size(56, 21);
            LBLWorldServerStatus.TabIndex = 45;
            LBLWorldServerStatus.Text = "World ";
            // 
            // PNLDatanasServerStatus
            // 
            PNLDatanasServerStatus.BackColor = Color.FromArgb(28, 33, 40);
            PNLDatanasServerStatus.Border = true;
            PNLDatanasServerStatus.BorderColor = Color.FromArgb(192, 0, 0);
            PNLDatanasServerStatus.BorderSize = 1;
            PNLDatanasServerStatus.Controls.Add(LBLDatabaseProcessID);
            PNLDatanasServerStatus.Controls.Add(LBLUpTimeDatabase);
            PNLDatanasServerStatus.Controls.Add(PICMySqlServerStatus);
            PNLDatanasServerStatus.Controls.Add(LBLDatabaseServerStatus);
            PNLDatanasServerStatus.CustomBackground = true;
            PNLDatanasServerStatus.Dock = DockStyle.Fill;
            PNLDatanasServerStatus.HorizontalScrollbar = true;
            PNLDatanasServerStatus.HorizontalScrollbarBarColor = true;
            PNLDatanasServerStatus.HorizontalScrollbarHighlightOnWheel = false;
            PNLDatanasServerStatus.HorizontalScrollbarSize = 10;
            PNLDatanasServerStatus.Location = new Point(3, 3);
            PNLDatanasServerStatus.Name = "PNLDatanasServerStatus";
            PNLDatanasServerStatus.Padding = new Padding(2);
            PNLDatanasServerStatus.Size = new Size(449, 59);
            PNLDatanasServerStatus.Style = MetroFramework.MetroColorStyle.Blue;
            PNLDatanasServerStatus.StyleManager = null;
            PNLDatanasServerStatus.TabIndex = 35;
            PNLDatanasServerStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            PNLDatanasServerStatus.VerticalScrollbar = true;
            PNLDatanasServerStatus.VerticalScrollbarBarColor = true;
            PNLDatanasServerStatus.VerticalScrollbarHighlightOnWheel = false;
            PNLDatanasServerStatus.VerticalScrollbarSize = 10;
            // 
            // LBLDatabaseProcessID
            // 
            LBLDatabaseProcessID.Anchor = AnchorStyles.Left;
            LBLDatabaseProcessID.AutoSize = true;
            LBLDatabaseProcessID.ForeColor = Color.White;
            LBLDatabaseProcessID.Location = new Point(166, 30);
            LBLDatabaseProcessID.Name = "LBLDatabaseProcessID";
            LBLDatabaseProcessID.Size = new Size(66, 15);
            LBLDatabaseProcessID.TabIndex = 45;
            LBLDatabaseProcessID.Text = "Process ID:";
            // 
            // LBLUpTimeDatabase
            // 
            LBLUpTimeDatabase.Anchor = AnchorStyles.Left;
            LBLUpTimeDatabase.AutoSize = true;
            LBLUpTimeDatabase.ForeColor = Color.White;
            LBLUpTimeDatabase.Location = new Point(166, 10);
            LBLUpTimeDatabase.Name = "LBLUpTimeDatabase";
            LBLUpTimeDatabase.Size = new Size(46, 15);
            LBLUpTimeDatabase.TabIndex = 44;
            LBLUpTimeDatabase.Text = "Uptime";
            // 
            // PICMySqlServerStatus
            // 
            PICMySqlServerStatus.Anchor = AnchorStyles.Left;
            PICMySqlServerStatus.Image = (Image)resources.GetObject("PICMySqlServerStatus.Image");
            PICMySqlServerStatus.Location = new Point(10, 12);
            PICMySqlServerStatus.Name = "PICMySqlServerStatus";
            PICMySqlServerStatus.Size = new Size(35, 35);
            PICMySqlServerStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            PICMySqlServerStatus.TabIndex = 42;
            PICMySqlServerStatus.TabStop = false;
            // 
            // LBLDatabaseServerStatus
            // 
            LBLDatabaseServerStatus.Anchor = AnchorStyles.Left;
            LBLDatabaseServerStatus.AutoSize = true;
            LBLDatabaseServerStatus.Font = new Font("Segoe UI", 12F);
            LBLDatabaseServerStatus.ForeColor = Color.White;
            LBLDatabaseServerStatus.Location = new Point(50, 20);
            LBLDatabaseServerStatus.Name = "LBLDatabaseServerStatus";
            LBLDatabaseServerStatus.Size = new Size(74, 21);
            LBLDatabaseServerStatus.TabIndex = 43;
            LBLDatabaseServerStatus.Text = "Database";
            // 
            // CardMachineResoruces
            // 
            CardMachineResoruces.BackColor = Color.FromArgb(255, 255, 255);
            CardMachineResoruces.Controls.Add(InfoMachineResources);
            CardMachineResoruces.Controls.Add(LBLCardMachineResourcesTitle);
            CardMachineResoruces.Controls.Add(LBLCPUTextMachineResources);
            CardMachineResoruces.Controls.Add(PbarRAMMachineResources);
            CardMachineResoruces.Controls.Add(LBLRAMTextMachineResources);
            CardMachineResoruces.Controls.Add(PbarCPUMachineResources);
            CardMachineResoruces.Depth = 0;
            CardMachineResoruces.Dock = DockStyle.Fill;
            CardMachineResoruces.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardMachineResoruces.Location = new Point(475, 4);
            CardMachineResoruces.Margin = new Padding(4);
            CardMachineResoruces.MouseState = MaterialSkin.MouseState.HOVER;
            CardMachineResoruces.Name = "CardMachineResoruces";
            CardMachineResoruces.Padding = new Padding(4);
            CardMachineResoruces.Size = new Size(463, 204);
            CardMachineResoruces.TabIndex = 4;
            // 
            // InfoMachineResources
            // 
            InfoMachineResources.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InfoMachineResources.BackgroundImageLayout = ImageLayout.Stretch;
            InfoMachineResources.Image = (Image)resources.GetObject("InfoMachineResources.Image");
            InfoMachineResources.Location = new Point(440, 10);
            InfoMachineResources.Name = "InfoMachineResources";
            InfoMachineResources.Size = new Size(16, 16);
            InfoMachineResources.TabIndex = 0;
            InfoMachineResources.TabStop = false;
            // 
            // LBLCardMachineResourcesTitle
            // 
            LBLCardMachineResourcesTitle.AutoSize = true;
            LBLCardMachineResourcesTitle.Depth = 0;
            LBLCardMachineResourcesTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardMachineResourcesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardMachineResourcesTitle.HighEmphasis = true;
            LBLCardMachineResourcesTitle.Location = new Point(10, 10);
            LBLCardMachineResourcesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardMachineResourcesTitle.Name = "LBLCardMachineResourcesTitle";
            LBLCardMachineResourcesTitle.Size = new Size(205, 24);
            LBLCardMachineResourcesTitle.TabIndex = 1;
            LBLCardMachineResourcesTitle.Text = "MACHINE RESOURCES";
            // 
            // LBLCPUTextMachineResources
            // 
            LBLCPUTextMachineResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLCPUTextMachineResources.Depth = 0;
            LBLCPUTextMachineResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCPUTextMachineResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLCPUTextMachineResources.Location = new Point(30, 140);
            LBLCPUTextMachineResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCPUTextMachineResources.Name = "LBLCPUTextMachineResources";
            LBLCPUTextMachineResources.Size = new Size(400, 17);
            LBLCPUTextMachineResources.TabIndex = 5;
            LBLCPUTextMachineResources.Text = "Central Processing Unit (CPU)";
            LBLCPUTextMachineResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarRAMMachineResources
            // 
            PbarRAMMachineResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarRAMMachineResources.Depth = 0;
            PbarRAMMachineResources.Location = new Point(30, 95);
            PbarRAMMachineResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarRAMMachineResources.Name = "PbarRAMMachineResources";
            PbarRAMMachineResources.PbarHeight = 15;
            PbarRAMMachineResources.ProgressText = "MB";
            PbarRAMMachineResources.Size = new Size(401, 15);
            PbarRAMMachineResources.Style = ProgressBarStyle.Continuous;
            PbarRAMMachineResources.TabIndex = 1;
            PbarRAMMachineResources.TextColor = Color.White;
            PbarRAMMachineResources.UsaeProcentage = false;
            // 
            // LBLRAMTextMachineResources
            // 
            LBLRAMTextMachineResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBLRAMTextMachineResources.Depth = 0;
            LBLRAMTextMachineResources.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLRAMTextMachineResources.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            LBLRAMTextMachineResources.Location = new Point(30, 75);
            LBLRAMTextMachineResources.MouseState = MaterialSkin.MouseState.HOVER;
            LBLRAMTextMachineResources.Name = "LBLRAMTextMachineResources";
            LBLRAMTextMachineResources.Size = new Size(400, 17);
            LBLRAMTextMachineResources.TabIndex = 3;
            LBLRAMTextMachineResources.Text = "Random-Access Memory  (RAM)";
            LBLRAMTextMachineResources.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PbarCPUMachineResources
            // 
            PbarCPUMachineResources.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PbarCPUMachineResources.Depth = 0;
            PbarCPUMachineResources.Location = new Point(30, 160);
            PbarCPUMachineResources.MouseState = MaterialSkin.MouseState.HOVER;
            PbarCPUMachineResources.Name = "PbarCPUMachineResources";
            PbarCPUMachineResources.PbarHeight = 15;
            PbarCPUMachineResources.ProgressText = "%";
            PbarCPUMachineResources.Size = new Size(401, 15);
            PbarCPUMachineResources.TabIndex = 4;
            PbarCPUMachineResources.TextColor = Color.White;
            PbarCPUMachineResources.UsaeProcentage = true;
            // 
            // TabSPP
            // 
            TabSPP.BackColor = Color.White;
            TabSPP.Controls.Add(tableLayoutPanel6);
            TabSPP.ImageKey = "ds3-tool-30.png";
            TabSPP.Location = new Point(39, 4);
            TabSPP.Name = "TabSPP";
            TabSPP.Size = new Size(948, 431);
            TabSPP.TabIndex = 3;
            TabSPP.Text = "SPP";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.67F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Controls.Add(materialCard12, 2, 0);
            tableLayoutPanel6.Controls.Add(materialCard13, 1, 0);
            tableLayoutPanel6.Controls.Add(materialCard14, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(948, 431);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // materialCard12
            // 
            materialCard12.BackColor = Color.FromArgb(255, 255, 255);
            materialCard12.Controls.Add(LBLCardSPPInstaledInfo);
            materialCard12.Controls.Add(ChecMOPInstalled);
            materialCard12.Controls.Add(ChecCATAInstalled);
            materialCard12.Controls.Add(ChecWOTLKInstalled);
            materialCard12.Controls.Add(ChecTBCInstalled);
            materialCard12.Controls.Add(ChecCLASSICInstalled);
            materialCard12.Depth = 0;
            materialCard12.Dock = DockStyle.Fill;
            materialCard12.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard12.Location = new Point(761, 4);
            materialCard12.Margin = new Padding(4);
            materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard12.Name = "materialCard12";
            materialCard12.Padding = new Padding(4);
            materialCard12.Size = new Size(183, 423);
            materialCard12.TabIndex = 2;
            // 
            // LBLCardSPPInstaledInfo
            // 
            LBLCardSPPInstaledInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardSPPInstaledInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardSPPInstaledInfo.Image = (Image)resources.GetObject("LBLCardSPPInstaledInfo.Image");
            LBLCardSPPInstaledInfo.Location = new Point(160, 10);
            LBLCardSPPInstaledInfo.Name = "LBLCardSPPInstaledInfo";
            LBLCardSPPInstaledInfo.Size = new Size(16, 16);
            LBLCardSPPInstaledInfo.TabIndex = 14;
            LBLCardSPPInstaledInfo.TabStop = false;
            // 
            // ChecMOPInstalled
            // 
            ChecMOPInstalled.AutoSize = true;
            ChecMOPInstalled.Depth = 0;
            ChecMOPInstalled.Location = new Point(4, 218);
            ChecMOPInstalled.Margin = new Padding(0);
            ChecMOPInstalled.MouseLocation = new Point(-1, -1);
            ChecMOPInstalled.MouseState = MaterialSkin.MouseState.HOVER;
            ChecMOPInstalled.Name = "ChecMOPInstalled";
            ChecMOPInstalled.ReadOnly = true;
            ChecMOPInstalled.Ripple = true;
            ChecMOPInstalled.Size = new Size(95, 37);
            ChecMOPInstalled.TabIndex = 4;
            ChecMOPInstalled.Text = "Installed";
            ChecMOPInstalled.UseVisualStyleBackColor = true;
            // 
            // ChecCATAInstalled
            // 
            ChecCATAInstalled.AutoSize = true;
            ChecCATAInstalled.Depth = 0;
            ChecCATAInstalled.Location = new Point(4, 181);
            ChecCATAInstalled.Margin = new Padding(0);
            ChecCATAInstalled.MouseLocation = new Point(-1, -1);
            ChecCATAInstalled.MouseState = MaterialSkin.MouseState.HOVER;
            ChecCATAInstalled.Name = "ChecCATAInstalled";
            ChecCATAInstalled.ReadOnly = true;
            ChecCATAInstalled.Ripple = true;
            ChecCATAInstalled.Size = new Size(95, 37);
            ChecCATAInstalled.TabIndex = 3;
            ChecCATAInstalled.Text = "Installed";
            ChecCATAInstalled.UseVisualStyleBackColor = true;
            // 
            // ChecWOTLKInstalled
            // 
            ChecWOTLKInstalled.AutoSize = true;
            ChecWOTLKInstalled.Depth = 0;
            ChecWOTLKInstalled.Location = new Point(4, 144);
            ChecWOTLKInstalled.Margin = new Padding(0);
            ChecWOTLKInstalled.MouseLocation = new Point(-1, -1);
            ChecWOTLKInstalled.MouseState = MaterialSkin.MouseState.HOVER;
            ChecWOTLKInstalled.Name = "ChecWOTLKInstalled";
            ChecWOTLKInstalled.ReadOnly = true;
            ChecWOTLKInstalled.Ripple = true;
            ChecWOTLKInstalled.Size = new Size(95, 37);
            ChecWOTLKInstalled.TabIndex = 2;
            ChecWOTLKInstalled.Text = "Installed";
            ChecWOTLKInstalled.UseVisualStyleBackColor = true;
            // 
            // ChecTBCInstalled
            // 
            ChecTBCInstalled.AutoSize = true;
            ChecTBCInstalled.Depth = 0;
            ChecTBCInstalled.Location = new Point(4, 107);
            ChecTBCInstalled.Margin = new Padding(0);
            ChecTBCInstalled.MouseLocation = new Point(-1, -1);
            ChecTBCInstalled.MouseState = MaterialSkin.MouseState.HOVER;
            ChecTBCInstalled.Name = "ChecTBCInstalled";
            ChecTBCInstalled.ReadOnly = true;
            ChecTBCInstalled.Ripple = true;
            ChecTBCInstalled.Size = new Size(95, 37);
            ChecTBCInstalled.TabIndex = 1;
            ChecTBCInstalled.Text = "Installed";
            ChecTBCInstalled.UseVisualStyleBackColor = true;
            // 
            // ChecCLASSICInstalled
            // 
            ChecCLASSICInstalled.AutoSize = true;
            ChecCLASSICInstalled.Depth = 0;
            ChecCLASSICInstalled.Location = new Point(4, 70);
            ChecCLASSICInstalled.Margin = new Padding(0);
            ChecCLASSICInstalled.MouseLocation = new Point(-1, -1);
            ChecCLASSICInstalled.MouseState = MaterialSkin.MouseState.HOVER;
            ChecCLASSICInstalled.Name = "ChecCLASSICInstalled";
            ChecCLASSICInstalled.ReadOnly = true;
            ChecCLASSICInstalled.Ripple = true;
            ChecCLASSICInstalled.Size = new Size(95, 37);
            ChecCLASSICInstalled.TabIndex = 0;
            ChecCLASSICInstalled.Text = "Installed";
            ChecCLASSICInstalled.UseVisualStyleBackColor = true;
            // 
            // materialCard13
            // 
            materialCard13.BackColor = Color.FromArgb(255, 255, 255);
            materialCard13.Controls.Add(TGLMoPLaunch);
            materialCard13.Controls.Add(TGLCataLaunch);
            materialCard13.Controls.Add(TGLWotLKLaunch);
            materialCard13.Controls.Add(TGLTBCLaunch);
            materialCard13.Controls.Add(TGLClassicLaunch);
            materialCard13.Controls.Add(LBLCardElulatorsInfo);
            materialCard13.Controls.Add(LBLCardSPPRunTitle);
            materialCard13.Controls.Add(pictureBox2);
            materialCard13.Depth = 0;
            materialCard13.Dock = DockStyle.Fill;
            materialCard13.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard13.Location = new Point(319, 4);
            materialCard13.Margin = new Padding(4);
            materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard13.Name = "materialCard13";
            materialCard13.Padding = new Padding(4);
            materialCard13.Size = new Size(434, 423);
            materialCard13.TabIndex = 1;
            // 
            // TGLMoPLaunch
            // 
            TGLMoPLaunch.Depth = 0;
            TGLMoPLaunch.Location = new Point(10, 218);
            TGLMoPLaunch.Margin = new Padding(0);
            TGLMoPLaunch.MouseLocation = new Point(-1, -1);
            TGLMoPLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            TGLMoPLaunch.Name = "TGLMoPLaunch";
            TGLMoPLaunch.Ripple = true;
            TGLMoPLaunch.Size = new Size(417, 37);
            TGLMoPLaunch.TabIndex = 18;
            TGLMoPLaunch.Text = "mop";
            TGLMoPLaunch.UseVisualStyleBackColor = true;
            // 
            // TGLCataLaunch
            // 
            TGLCataLaunch.Depth = 0;
            TGLCataLaunch.Location = new Point(10, 181);
            TGLCataLaunch.Margin = new Padding(0);
            TGLCataLaunch.MouseLocation = new Point(-1, -1);
            TGLCataLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            TGLCataLaunch.Name = "TGLCataLaunch";
            TGLCataLaunch.Ripple = true;
            TGLCataLaunch.Size = new Size(417, 37);
            TGLCataLaunch.TabIndex = 17;
            TGLCataLaunch.Text = "cata";
            TGLCataLaunch.UseVisualStyleBackColor = true;
            // 
            // TGLWotLKLaunch
            // 
            TGLWotLKLaunch.Depth = 0;
            TGLWotLKLaunch.Location = new Point(10, 144);
            TGLWotLKLaunch.Margin = new Padding(0);
            TGLWotLKLaunch.MouseLocation = new Point(-1, -1);
            TGLWotLKLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            TGLWotLKLaunch.Name = "TGLWotLKLaunch";
            TGLWotLKLaunch.Ripple = true;
            TGLWotLKLaunch.Size = new Size(417, 37);
            TGLWotLKLaunch.TabIndex = 16;
            TGLWotLKLaunch.Text = "wotlk";
            TGLWotLKLaunch.UseVisualStyleBackColor = true;
            // 
            // TGLTBCLaunch
            // 
            TGLTBCLaunch.Depth = 0;
            TGLTBCLaunch.Location = new Point(10, 107);
            TGLTBCLaunch.Margin = new Padding(0);
            TGLTBCLaunch.MouseLocation = new Point(-1, -1);
            TGLTBCLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            TGLTBCLaunch.Name = "TGLTBCLaunch";
            TGLTBCLaunch.Ripple = true;
            TGLTBCLaunch.Size = new Size(417, 37);
            TGLTBCLaunch.TabIndex = 15;
            TGLTBCLaunch.Text = "tbc";
            TGLTBCLaunch.UseVisualStyleBackColor = true;
            // 
            // TGLClassicLaunch
            // 
            TGLClassicLaunch.AutoEllipsis = true;
            TGLClassicLaunch.Depth = 0;
            TGLClassicLaunch.Location = new Point(10, 70);
            TGLClassicLaunch.Margin = new Padding(0);
            TGLClassicLaunch.MouseLocation = new Point(-1, -1);
            TGLClassicLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            TGLClassicLaunch.Name = "TGLClassicLaunch";
            TGLClassicLaunch.Ripple = true;
            TGLClassicLaunch.Size = new Size(417, 37);
            TGLClassicLaunch.TabIndex = 14;
            TGLClassicLaunch.Text = "classic";
            TGLClassicLaunch.UseVisualStyleBackColor = false;
            // 
            // LBLCardElulatorsInfo
            // 
            LBLCardElulatorsInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardElulatorsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardElulatorsInfo.Image = (Image)resources.GetObject("LBLCardElulatorsInfo.Image");
            LBLCardElulatorsInfo.Location = new Point(410, 10);
            LBLCardElulatorsInfo.Name = "LBLCardElulatorsInfo";
            LBLCardElulatorsInfo.Size = new Size(16, 16);
            LBLCardElulatorsInfo.TabIndex = 13;
            LBLCardElulatorsInfo.TabStop = false;
            // 
            // LBLCardSPPRunTitle
            // 
            LBLCardSPPRunTitle.AutoSize = true;
            LBLCardSPPRunTitle.Depth = 0;
            LBLCardSPPRunTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardSPPRunTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardSPPRunTitle.HighEmphasis = true;
            LBLCardSPPRunTitle.Location = new Point(10, 10);
            LBLCardSPPRunTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardSPPRunTitle.Name = "LBLCardSPPRunTitle";
            LBLCardSPPRunTitle.Size = new Size(86, 24);
            LBLCardSPPRunTitle.TabIndex = 12;
            LBLCardSPPRunTitle.Text = "Emulator ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(509, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // materialCard14
            // 
            materialCard14.BackColor = Color.FromArgb(255, 255, 255);
            materialCard14.Controls.Add(BTNUninstallSPP);
            materialCard14.Controls.Add(BTNRepairSPP);
            materialCard14.Controls.Add(BTNInstallSPP);
            materialCard14.Controls.Add(CBOXSPPVersion);
            materialCard14.Controls.Add(LBLCardSPPversionInfo);
            materialCard14.Controls.Add(LBLCardSPPVersionTitle);
            materialCard14.Controls.Add(pictureBox3);
            materialCard14.Depth = 0;
            materialCard14.Dock = DockStyle.Fill;
            materialCard14.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard14.Location = new Point(4, 4);
            materialCard14.Margin = new Padding(4);
            materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard14.Name = "materialCard14";
            materialCard14.Padding = new Padding(4);
            materialCard14.Size = new Size(307, 423);
            materialCard14.TabIndex = 0;
            // 
            // BTNUninstallSPP
            // 
            BTNUninstallSPP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNUninstallSPP.AutoSize = false;
            BTNUninstallSPP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNUninstallSPP.Cursor = Cursors.Hand;
            BTNUninstallSPP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNUninstallSPP.Depth = 0;
            BTNUninstallSPP.HighEmphasis = true;
            BTNUninstallSPP.Icon = (Image)resources.GetObject("BTNUninstallSPP.Icon");
            BTNUninstallSPP.Location = new Point(9, 373);
            BTNUninstallSPP.Margin = new Padding(4, 6, 4, 6);
            BTNUninstallSPP.MouseState = MaterialSkin.MouseState.HOVER;
            BTNUninstallSPP.Name = "BTNUninstallSPP";
            BTNUninstallSPP.NoAccentTextColor = Color.Empty;
            BTNUninstallSPP.Size = new Size(289, 36);
            BTNUninstallSPP.TabIndex = 16;
            BTNUninstallSPP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNUninstallSPP.UseAccentColor = false;
            BTNUninstallSPP.UseVisualStyleBackColor = true;
            // 
            // BTNRepairSPP
            // 
            BTNRepairSPP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNRepairSPP.AutoSize = false;
            BTNRepairSPP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNRepairSPP.Cursor = Cursors.Hand;
            BTNRepairSPP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNRepairSPP.Depth = 0;
            BTNRepairSPP.HighEmphasis = true;
            BTNRepairSPP.Icon = (Image)resources.GetObject("BTNRepairSPP.Icon");
            BTNRepairSPP.Location = new Point(9, 325);
            BTNRepairSPP.Margin = new Padding(4, 6, 4, 6);
            BTNRepairSPP.MouseState = MaterialSkin.MouseState.HOVER;
            BTNRepairSPP.Name = "BTNRepairSPP";
            BTNRepairSPP.NoAccentTextColor = Color.Empty;
            BTNRepairSPP.Size = new Size(289, 36);
            BTNRepairSPP.TabIndex = 15;
            BTNRepairSPP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNRepairSPP.UseAccentColor = false;
            BTNRepairSPP.UseVisualStyleBackColor = true;
            // 
            // BTNInstallSPP
            // 
            BTNInstallSPP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNInstallSPP.AutoSize = false;
            BTNInstallSPP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNInstallSPP.Cursor = Cursors.Hand;
            BTNInstallSPP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNInstallSPP.Depth = 0;
            BTNInstallSPP.HighEmphasis = true;
            BTNInstallSPP.Icon = (Image)resources.GetObject("BTNInstallSPP.Icon");
            BTNInstallSPP.Location = new Point(9, 277);
            BTNInstallSPP.Margin = new Padding(4, 6, 4, 6);
            BTNInstallSPP.MouseState = MaterialSkin.MouseState.HOVER;
            BTNInstallSPP.Name = "BTNInstallSPP";
            BTNInstallSPP.NoAccentTextColor = Color.Empty;
            BTNInstallSPP.Size = new Size(289, 36);
            BTNInstallSPP.TabIndex = 14;
            BTNInstallSPP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNInstallSPP.UseAccentColor = false;
            BTNInstallSPP.UseVisualStyleBackColor = true;
            // 
            // CBOXSPPVersion
            // 
            CBOXSPPVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXSPPVersion.AutoResize = false;
            CBOXSPPVersion.BackColor = Color.FromArgb(255, 255, 255);
            CBOXSPPVersion.Depth = 0;
            CBOXSPPVersion.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXSPPVersion.DropDownHeight = 174;
            CBOXSPPVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXSPPVersion.DropDownWidth = 121;
            CBOXSPPVersion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXSPPVersion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXSPPVersion.FormattingEnabled = true;
            CBOXSPPVersion.Hint = "ID";
            CBOXSPPVersion.IntegralHeight = false;
            CBOXSPPVersion.ItemHeight = 43;
            CBOXSPPVersion.Location = new Point(10, 70);
            CBOXSPPVersion.MaxDropDownItems = 4;
            CBOXSPPVersion.MouseState = MaterialSkin.MouseState.OUT;
            CBOXSPPVersion.Name = "CBOXSPPVersion";
            CBOXSPPVersion.Size = new Size(290, 49);
            CBOXSPPVersion.StartIndex = 0;
            CBOXSPPVersion.TabIndex = 13;
            // 
            // LBLCardSPPversionInfo
            // 
            LBLCardSPPversionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardSPPversionInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardSPPversionInfo.Image = (Image)resources.GetObject("LBLCardSPPversionInfo.Image");
            LBLCardSPPversionInfo.Location = new Point(285, 10);
            LBLCardSPPversionInfo.Name = "LBLCardSPPversionInfo";
            LBLCardSPPversionInfo.Size = new Size(16, 16);
            LBLCardSPPversionInfo.TabIndex = 12;
            LBLCardSPPversionInfo.TabStop = false;
            // 
            // LBLCardSPPVersionTitle
            // 
            LBLCardSPPVersionTitle.AutoSize = true;
            LBLCardSPPVersionTitle.Depth = 0;
            LBLCardSPPVersionTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardSPPVersionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardSPPVersionTitle.HighEmphasis = true;
            LBLCardSPPVersionTitle.Location = new Point(10, 10);
            LBLCardSPPVersionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardSPPVersionTitle.Name = "LBLCardSPPVersionTitle";
            LBLCardSPPVersionTitle.Size = new Size(237, 24);
            LBLCardSPPVersionTitle.TabIndex = 11;
            LBLCardSPPVersionTitle.Text = "SINGLE PLAYER PROJECT";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(382, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // TabDatabaseEditor
            // 
            TabDatabaseEditor.BackColor = Color.White;
            TabDatabaseEditor.Controls.Add(DatabaseEditorLayoutPanel);
            TabDatabaseEditor.ImageKey = "database-administrator-64.png";
            TabDatabaseEditor.Location = new Point(39, 4);
            TabDatabaseEditor.Name = "TabDatabaseEditor";
            TabDatabaseEditor.Padding = new Padding(3);
            TabDatabaseEditor.Size = new Size(948, 431);
            TabDatabaseEditor.TabIndex = 1;
            TabDatabaseEditor.Text = "DBE";
            TabDatabaseEditor.Click += TabDatabaseEditor_Click;
            // 
            // DatabaseEditorLayoutPanel
            // 
            DatabaseEditorLayoutPanel.ColumnCount = 1;
            DatabaseEditorLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DatabaseEditorLayoutPanel.Controls.Add(DatabaseEditorTabSelector, 0, 0);
            DatabaseEditorLayoutPanel.Controls.Add(DatabaseEditorTabControl, 0, 1);
            DatabaseEditorLayoutPanel.Dock = DockStyle.Fill;
            DatabaseEditorLayoutPanel.Location = new Point(3, 3);
            DatabaseEditorLayoutPanel.Name = "DatabaseEditorLayoutPanel";
            DatabaseEditorLayoutPanel.RowCount = 2;
            DatabaseEditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            DatabaseEditorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DatabaseEditorLayoutPanel.Size = new Size(942, 425);
            DatabaseEditorLayoutPanel.TabIndex = 0;
            // 
            // DatabaseEditorTabSelector
            // 
            DatabaseEditorTabSelector.BaseTabControl = DatabaseEditorTabControl;
            DatabaseEditorTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            DatabaseEditorTabSelector.Depth = 0;
            DatabaseEditorTabSelector.Dock = DockStyle.Fill;
            DatabaseEditorTabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DatabaseEditorTabSelector.Location = new Point(3, 3);
            DatabaseEditorTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            DatabaseEditorTabSelector.Name = "DatabaseEditorTabSelector";
            DatabaseEditorTabSelector.Size = new Size(936, 44);
            DatabaseEditorTabSelector.TabIndex = 0;
            DatabaseEditorTabSelector.TabIndicatorHeight = 5;
            DatabaseEditorTabSelector.Text = "DatabaseEditorTabSelector";
            // 
            // DatabaseEditorTabControl
            // 
            DatabaseEditorTabControl.Alignment = TabAlignment.Left;
            DatabaseEditorTabControl.Controls.Add(TabRealmList);
            DatabaseEditorTabControl.Controls.Add(TabAccount);
            DatabaseEditorTabControl.Depth = 0;
            DatabaseEditorTabControl.Dock = DockStyle.Fill;
            DatabaseEditorTabControl.Location = new Point(3, 53);
            DatabaseEditorTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            DatabaseEditorTabControl.Multiline = true;
            DatabaseEditorTabControl.Name = "DatabaseEditorTabControl";
            DatabaseEditorTabControl.SelectedIndex = 0;
            DatabaseEditorTabControl.Size = new Size(936, 369);
            DatabaseEditorTabControl.TabIndex = 1;
            // 
            // TabRealmList
            // 
            TabRealmList.BackColor = Color.White;
            TabRealmList.Controls.Add(tableLayoutPanel1);
            TabRealmList.Location = new Point(27, 4);
            TabRealmList.Name = "TabRealmList";
            TabRealmList.Padding = new Padding(3);
            TabRealmList.Size = new Size(905, 361);
            TabRealmList.TabIndex = 0;
            TabRealmList.Text = "RealmList";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.Controls.Add(materialCard2, 2, 0);
            tableLayoutPanel1.Controls.Add(materialCard1, 1, 0);
            tableLayoutPanel1.Controls.Add(RealmlistInfosCard, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(899, 355);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(LBLCardRealmActionInfo);
            materialCard2.Controls.Add(BTNForceRefresh);
            materialCard2.Controls.Add(BTNEditRealmlistData);
            materialCard2.Controls.Add(BTNOpenIntern);
            materialCard2.Controls.Add(BTNOpenPublic);
            materialCard2.Controls.Add(LBLCardRealmActionTitle);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(602, 4);
            materialCard2.Margin = new Padding(4);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(4);
            materialCard2.Size = new Size(293, 347);
            materialCard2.TabIndex = 2;
            // 
            // LBLCardRealmActionInfo
            // 
            LBLCardRealmActionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardRealmActionInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardRealmActionInfo.Image = (Image)resources.GetObject("LBLCardRealmActionInfo.Image");
            LBLCardRealmActionInfo.Location = new Point(265, 10);
            LBLCardRealmActionInfo.Name = "LBLCardRealmActionInfo";
            LBLCardRealmActionInfo.Size = new Size(16, 16);
            LBLCardRealmActionInfo.TabIndex = 11;
            LBLCardRealmActionInfo.TabStop = false;
            // 
            // BTNForceRefresh
            // 
            BTNForceRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNForceRefresh.AutoSize = false;
            BTNForceRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNForceRefresh.Cursor = Cursors.Hand;
            BTNForceRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNForceRefresh.Depth = 0;
            BTNForceRefresh.HighEmphasis = true;
            BTNForceRefresh.Icon = (Image)resources.GetObject("BTNForceRefresh.Icon");
            BTNForceRefresh.Location = new Point(8, 214);
            BTNForceRefresh.Margin = new Padding(4, 6, 4, 6);
            BTNForceRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            BTNForceRefresh.Name = "BTNForceRefresh";
            BTNForceRefresh.NoAccentTextColor = Color.Empty;
            BTNForceRefresh.Size = new Size(271, 36);
            BTNForceRefresh.TabIndex = 8;
            BTNForceRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNForceRefresh.UseAccentColor = false;
            BTNForceRefresh.UseVisualStyleBackColor = true;
            // 
            // BTNEditRealmlistData
            // 
            BTNEditRealmlistData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNEditRealmlistData.AutoSize = false;
            BTNEditRealmlistData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNEditRealmlistData.Cursor = Cursors.Hand;
            BTNEditRealmlistData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNEditRealmlistData.Depth = 0;
            BTNEditRealmlistData.HighEmphasis = true;
            BTNEditRealmlistData.Icon = (Image)resources.GetObject("BTNEditRealmlistData.Icon");
            BTNEditRealmlistData.Location = new Point(8, 166);
            BTNEditRealmlistData.Margin = new Padding(4, 6, 4, 6);
            BTNEditRealmlistData.MouseState = MaterialSkin.MouseState.HOVER;
            BTNEditRealmlistData.Name = "BTNEditRealmlistData";
            BTNEditRealmlistData.NoAccentTextColor = Color.Empty;
            BTNEditRealmlistData.Size = new Size(271, 36);
            BTNEditRealmlistData.TabIndex = 7;
            BTNEditRealmlistData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNEditRealmlistData.UseAccentColor = false;
            BTNEditRealmlistData.UseVisualStyleBackColor = true;
            // 
            // BTNOpenIntern
            // 
            BTNOpenIntern.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNOpenIntern.AutoSize = false;
            BTNOpenIntern.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNOpenIntern.Cursor = Cursors.Hand;
            BTNOpenIntern.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNOpenIntern.Depth = 0;
            BTNOpenIntern.HighEmphasis = true;
            BTNOpenIntern.Icon = (Image)resources.GetObject("BTNOpenIntern.Icon");
            BTNOpenIntern.Location = new Point(8, 118);
            BTNOpenIntern.Margin = new Padding(4, 6, 4, 6);
            BTNOpenIntern.MouseState = MaterialSkin.MouseState.HOVER;
            BTNOpenIntern.Name = "BTNOpenIntern";
            BTNOpenIntern.NoAccentTextColor = Color.Empty;
            BTNOpenIntern.Size = new Size(271, 36);
            BTNOpenIntern.TabIndex = 6;
            BTNOpenIntern.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNOpenIntern.UseAccentColor = false;
            BTNOpenIntern.UseVisualStyleBackColor = true;
            // 
            // BTNOpenPublic
            // 
            BTNOpenPublic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNOpenPublic.AutoSize = false;
            BTNOpenPublic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNOpenPublic.Cursor = Cursors.Hand;
            BTNOpenPublic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNOpenPublic.Depth = 0;
            BTNOpenPublic.HighEmphasis = true;
            BTNOpenPublic.Icon = (Image)resources.GetObject("BTNOpenPublic.Icon");
            BTNOpenPublic.Location = new Point(8, 70);
            BTNOpenPublic.Margin = new Padding(4, 6, 4, 6);
            BTNOpenPublic.MouseState = MaterialSkin.MouseState.HOVER;
            BTNOpenPublic.Name = "BTNOpenPublic";
            BTNOpenPublic.NoAccentTextColor = Color.Empty;
            BTNOpenPublic.Size = new Size(271, 36);
            BTNOpenPublic.TabIndex = 5;
            BTNOpenPublic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNOpenPublic.UseAccentColor = false;
            BTNOpenPublic.UseVisualStyleBackColor = true;
            // 
            // LBLCardRealmActionTitle
            // 
            LBLCardRealmActionTitle.AutoSize = true;
            LBLCardRealmActionTitle.Depth = 0;
            LBLCardRealmActionTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardRealmActionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardRealmActionTitle.HighEmphasis = true;
            LBLCardRealmActionTitle.Location = new Point(7, 10);
            LBLCardRealmActionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardRealmActionTitle.Name = "LBLCardRealmActionTitle";
            LBLCardRealmActionTitle.Size = new Size(85, 24);
            LBLCardRealmActionTitle.TabIndex = 3;
            LBLCardRealmActionTitle.Text = "ACTIONS";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(BTNReviveIP);
            materialCard1.Controls.Add(LBLCardRealmOptionInfo);
            materialCard1.Controls.Add(TXTPublicIP);
            materialCard1.Controls.Add(TXTInternIP);
            materialCard1.Controls.Add(TXTDomainName);
            materialCard1.Controls.Add(CBOXReamList);
            materialCard1.Controls.Add(LBLCardRealmOptionTitle);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(303, 4);
            materialCard1.Margin = new Padding(4);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(4);
            materialCard1.Size = new Size(291, 347);
            materialCard1.TabIndex = 1;
            // 
            // BTNReviveIP
            // 
            BTNReviveIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTNReviveIP.AutoSize = false;
            BTNReviveIP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNReviveIP.Cursor = Cursors.Hand;
            BTNReviveIP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNReviveIP.Depth = 0;
            BTNReviveIP.HighEmphasis = true;
            BTNReviveIP.Icon = (Image)resources.GetObject("BTNReviveIP.Icon");
            BTNReviveIP.Location = new Point(245, 233);
            BTNReviveIP.Margin = new Padding(4, 6, 4, 6);
            BTNReviveIP.MouseState = MaterialSkin.MouseState.HOVER;
            BTNReviveIP.Name = "BTNReviveIP";
            BTNReviveIP.NoAccentTextColor = Color.Empty;
            BTNReviveIP.Size = new Size(40, 45);
            BTNReviveIP.TabIndex = 12;
            BTNReviveIP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNReviveIP.UseAccentColor = false;
            BTNReviveIP.UseVisualStyleBackColor = true;
            // 
            // LBLCardRealmOptionInfo
            // 
            LBLCardRealmOptionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardRealmOptionInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardRealmOptionInfo.Image = (Image)resources.GetObject("LBLCardRealmOptionInfo.Image");
            LBLCardRealmOptionInfo.Location = new Point(265, 10);
            LBLCardRealmOptionInfo.Name = "LBLCardRealmOptionInfo";
            LBLCardRealmOptionInfo.Size = new Size(16, 16);
            LBLCardRealmOptionInfo.TabIndex = 11;
            LBLCardRealmOptionInfo.TabStop = false;
            // 
            // TXTPublicIP
            // 
            TXTPublicIP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTPublicIP.AnimateReadOnly = true;
            TXTPublicIP.AutoCompleteMode = AutoCompleteMode.None;
            TXTPublicIP.AutoCompleteSource = AutoCompleteSource.None;
            TXTPublicIP.BackgroundImageLayout = ImageLayout.None;
            TXTPublicIP.CharacterCasing = CharacterCasing.Normal;
            TXTPublicIP.Depth = 0;
            TXTPublicIP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTPublicIP.HideSelection = true;
            TXTPublicIP.Hint = "ID";
            TXTPublicIP.LeadingIcon = null;
            TXTPublicIP.Location = new Point(10, 233);
            TXTPublicIP.MaxLength = 32767;
            TXTPublicIP.MouseState = MaterialSkin.MouseState.OUT;
            TXTPublicIP.Name = "TXTPublicIP";
            TXTPublicIP.PasswordChar = '⛊';
            TXTPublicIP.PrefixSuffixText = null;
            TXTPublicIP.ReadOnly = false;
            TXTPublicIP.RightToLeft = RightToLeft.No;
            TXTPublicIP.SelectedText = "";
            TXTPublicIP.SelectionLength = 0;
            TXTPublicIP.SelectionStart = 0;
            TXTPublicIP.ShortcutsEnabled = true;
            TXTPublicIP.Size = new Size(228, 48);
            TXTPublicIP.TabIndex = 10;
            TXTPublicIP.TabStop = false;
            TXTPublicIP.TextAlign = HorizontalAlignment.Left;
            TXTPublicIP.TrailingIcon = (Image)resources.GetObject("TXTPublicIP.TrailingIcon");
            TXTPublicIP.UseSystemPasswordChar = false;
            // 
            // TXTInternIP
            // 
            TXTInternIP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTInternIP.AnimateReadOnly = true;
            TXTInternIP.AutoCompleteMode = AutoCompleteMode.None;
            TXTInternIP.AutoCompleteSource = AutoCompleteSource.None;
            TXTInternIP.BackgroundImageLayout = ImageLayout.None;
            TXTInternIP.CharacterCasing = CharacterCasing.Normal;
            TXTInternIP.Depth = 0;
            TXTInternIP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTInternIP.HideSelection = true;
            TXTInternIP.Hint = "ID";
            TXTInternIP.LeadingIcon = null;
            TXTInternIP.Location = new Point(10, 179);
            TXTInternIP.MaxLength = 32767;
            TXTInternIP.MouseState = MaterialSkin.MouseState.OUT;
            TXTInternIP.Name = "TXTInternIP";
            TXTInternIP.PasswordChar = '\0';
            TXTInternIP.PrefixSuffixText = null;
            TXTInternIP.ReadOnly = false;
            TXTInternIP.RightToLeft = RightToLeft.No;
            TXTInternIP.SelectedText = "";
            TXTInternIP.SelectionLength = 0;
            TXTInternIP.SelectionStart = 0;
            TXTInternIP.ShortcutsEnabled = true;
            TXTInternIP.Size = new Size(274, 48);
            TXTInternIP.TabIndex = 9;
            TXTInternIP.TabStop = false;
            TXTInternIP.TextAlign = HorizontalAlignment.Left;
            TXTInternIP.TrailingIcon = (Image)resources.GetObject("TXTInternIP.TrailingIcon");
            TXTInternIP.UseSystemPasswordChar = false;
            // 
            // TXTDomainName
            // 
            TXTDomainName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDomainName.AnimateReadOnly = true;
            TXTDomainName.AutoCompleteMode = AutoCompleteMode.None;
            TXTDomainName.AutoCompleteSource = AutoCompleteSource.None;
            TXTDomainName.BackgroundImageLayout = ImageLayout.None;
            TXTDomainName.CharacterCasing = CharacterCasing.Normal;
            TXTDomainName.Depth = 0;
            TXTDomainName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDomainName.HideSelection = true;
            TXTDomainName.Hint = "ID";
            TXTDomainName.LeadingIcon = null;
            TXTDomainName.Location = new Point(10, 125);
            TXTDomainName.MaxLength = 32767;
            TXTDomainName.MouseState = MaterialSkin.MouseState.OUT;
            TXTDomainName.Name = "TXTDomainName";
            TXTDomainName.PasswordChar = '\0';
            TXTDomainName.PrefixSuffixText = null;
            TXTDomainName.ReadOnly = false;
            TXTDomainName.RightToLeft = RightToLeft.No;
            TXTDomainName.SelectedText = "";
            TXTDomainName.SelectionLength = 0;
            TXTDomainName.SelectionStart = 0;
            TXTDomainName.ShortcutsEnabled = true;
            TXTDomainName.Size = new Size(274, 48);
            TXTDomainName.TabIndex = 8;
            TXTDomainName.TabStop = false;
            TXTDomainName.TextAlign = HorizontalAlignment.Left;
            TXTDomainName.TrailingIcon = (Image)resources.GetObject("TXTDomainName.TrailingIcon");
            TXTDomainName.UseSystemPasswordChar = false;
            // 
            // CBOXReamList
            // 
            CBOXReamList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXReamList.AutoResize = false;
            CBOXReamList.BackColor = Color.FromArgb(255, 255, 255);
            CBOXReamList.Depth = 0;
            CBOXReamList.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXReamList.DropDownHeight = 174;
            CBOXReamList.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXReamList.DropDownWidth = 121;
            CBOXReamList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXReamList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXReamList.FormattingEnabled = true;
            CBOXReamList.Hint = "ID";
            CBOXReamList.IntegralHeight = false;
            CBOXReamList.ItemHeight = 43;
            CBOXReamList.Location = new Point(10, 70);
            CBOXReamList.MaxDropDownItems = 4;
            CBOXReamList.MouseState = MaterialSkin.MouseState.OUT;
            CBOXReamList.Name = "CBOXReamList";
            CBOXReamList.Size = new Size(274, 49);
            CBOXReamList.StartIndex = 0;
            CBOXReamList.TabIndex = 4;
            // 
            // LBLCardRealmOptionTitle
            // 
            LBLCardRealmOptionTitle.AutoSize = true;
            LBLCardRealmOptionTitle.Depth = 0;
            LBLCardRealmOptionTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardRealmOptionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardRealmOptionTitle.HighEmphasis = true;
            LBLCardRealmOptionTitle.Location = new Point(10, 10);
            LBLCardRealmOptionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardRealmOptionTitle.Name = "LBLCardRealmOptionTitle";
            LBLCardRealmOptionTitle.Size = new Size(86, 24);
            LBLCardRealmOptionTitle.TabIndex = 3;
            LBLCardRealmOptionTitle.Text = "OPTIONS";
            // 
            // RealmlistInfosCard
            // 
            RealmlistInfosCard.BackColor = Color.FromArgb(255, 255, 255);
            RealmlistInfosCard.Controls.Add(LBLCardRealmDataInfo);
            RealmlistInfosCard.Controls.Add(TXTRealmGameBuild);
            RealmlistInfosCard.Controls.Add(TXTRealmPort);
            RealmlistInfosCard.Controls.Add(TXTRealmSubnetMask);
            RealmlistInfosCard.Controls.Add(TXTRealmLocalAddress);
            RealmlistInfosCard.Controls.Add(TXTRealmAddress);
            RealmlistInfosCard.Controls.Add(TXTRealmName);
            RealmlistInfosCard.Controls.Add(TXTRealmID);
            RealmlistInfosCard.Controls.Add(LBLCardRealmDataTitle);
            RealmlistInfosCard.Depth = 0;
            RealmlistInfosCard.Dock = DockStyle.Fill;
            RealmlistInfosCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            RealmlistInfosCard.Location = new Point(4, 4);
            RealmlistInfosCard.Margin = new Padding(4);
            RealmlistInfosCard.MouseState = MaterialSkin.MouseState.HOVER;
            RealmlistInfosCard.Name = "RealmlistInfosCard";
            RealmlistInfosCard.Padding = new Padding(4);
            RealmlistInfosCard.Size = new Size(291, 347);
            RealmlistInfosCard.TabIndex = 0;
            // 
            // LBLCardRealmDataInfo
            // 
            LBLCardRealmDataInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardRealmDataInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardRealmDataInfo.Image = (Image)resources.GetObject("LBLCardRealmDataInfo.Image");
            LBLCardRealmDataInfo.Location = new Point(265, 10);
            LBLCardRealmDataInfo.Name = "LBLCardRealmDataInfo";
            LBLCardRealmDataInfo.Size = new Size(16, 16);
            LBLCardRealmDataInfo.TabIndex = 10;
            LBLCardRealmDataInfo.TabStop = false;
            // 
            // TXTRealmGameBuild
            // 
            TXTRealmGameBuild.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTRealmGameBuild.AnimateReadOnly = true;
            TXTRealmGameBuild.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmGameBuild.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmGameBuild.BackgroundImageLayout = ImageLayout.None;
            TXTRealmGameBuild.CharacterCasing = CharacterCasing.Normal;
            TXTRealmGameBuild.Depth = 0;
            TXTRealmGameBuild.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmGameBuild.HideSelection = true;
            TXTRealmGameBuild.Hint = "ID";
            TXTRealmGameBuild.LeadingIcon = null;
            TXTRealmGameBuild.Location = new Point(153, 287);
            TXTRealmGameBuild.MaxLength = 32767;
            TXTRealmGameBuild.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmGameBuild.Name = "TXTRealmGameBuild";
            TXTRealmGameBuild.PasswordChar = '\0';
            TXTRealmGameBuild.PrefixSuffixText = null;
            TXTRealmGameBuild.ReadOnly = true;
            TXTRealmGameBuild.RightToLeft = RightToLeft.No;
            TXTRealmGameBuild.SelectedText = "";
            TXTRealmGameBuild.SelectionLength = 0;
            TXTRealmGameBuild.SelectionStart = 0;
            TXTRealmGameBuild.ShortcutsEnabled = true;
            TXTRealmGameBuild.Size = new Size(131, 48);
            TXTRealmGameBuild.TabIndex = 9;
            TXTRealmGameBuild.TabStop = false;
            TXTRealmGameBuild.TextAlign = HorizontalAlignment.Left;
            TXTRealmGameBuild.TrailingIcon = (Image)resources.GetObject("TXTRealmGameBuild.TrailingIcon");
            TXTRealmGameBuild.UseSystemPasswordChar = false;
            TXTRealmGameBuild.KeyPress += TXTOnlyNumbers;
            // 
            // TXTRealmPort
            // 
            TXTRealmPort.AnimateReadOnly = true;
            TXTRealmPort.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmPort.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmPort.BackgroundImageLayout = ImageLayout.None;
            TXTRealmPort.CharacterCasing = CharacterCasing.Normal;
            TXTRealmPort.Depth = 0;
            TXTRealmPort.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmPort.HideSelection = true;
            TXTRealmPort.Hint = "ID";
            TXTRealmPort.LeadingIcon = null;
            TXTRealmPort.Location = new Point(10, 287);
            TXTRealmPort.MaxLength = 32767;
            TXTRealmPort.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmPort.Name = "TXTRealmPort";
            TXTRealmPort.PasswordChar = '\0';
            TXTRealmPort.PrefixSuffixText = null;
            TXTRealmPort.ReadOnly = true;
            TXTRealmPort.RightToLeft = RightToLeft.No;
            TXTRealmPort.SelectedText = "";
            TXTRealmPort.SelectionLength = 0;
            TXTRealmPort.SelectionStart = 0;
            TXTRealmPort.ShortcutsEnabled = true;
            TXTRealmPort.Size = new Size(137, 48);
            TXTRealmPort.TabIndex = 8;
            TXTRealmPort.TabStop = false;
            TXTRealmPort.TextAlign = HorizontalAlignment.Left;
            TXTRealmPort.TrailingIcon = (Image)resources.GetObject("TXTRealmPort.TrailingIcon");
            TXTRealmPort.UseSystemPasswordChar = false;
            TXTRealmPort.KeyPress += TXTOnlyNumbers;
            // 
            // TXTRealmSubnetMask
            // 
            TXTRealmSubnetMask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTRealmSubnetMask.AnimateReadOnly = true;
            TXTRealmSubnetMask.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmSubnetMask.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmSubnetMask.BackgroundImageLayout = ImageLayout.None;
            TXTRealmSubnetMask.CharacterCasing = CharacterCasing.Normal;
            TXTRealmSubnetMask.Depth = 0;
            TXTRealmSubnetMask.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmSubnetMask.HideSelection = true;
            TXTRealmSubnetMask.Hint = "ID";
            TXTRealmSubnetMask.LeadingIcon = null;
            TXTRealmSubnetMask.Location = new Point(10, 233);
            TXTRealmSubnetMask.MaxLength = 32767;
            TXTRealmSubnetMask.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmSubnetMask.Name = "TXTRealmSubnetMask";
            TXTRealmSubnetMask.PasswordChar = '\0';
            TXTRealmSubnetMask.PrefixSuffixText = null;
            TXTRealmSubnetMask.ReadOnly = true;
            TXTRealmSubnetMask.RightToLeft = RightToLeft.No;
            TXTRealmSubnetMask.SelectedText = "";
            TXTRealmSubnetMask.SelectionLength = 0;
            TXTRealmSubnetMask.SelectionStart = 0;
            TXTRealmSubnetMask.ShortcutsEnabled = true;
            TXTRealmSubnetMask.Size = new Size(274, 48);
            TXTRealmSubnetMask.TabIndex = 7;
            TXTRealmSubnetMask.TabStop = false;
            TXTRealmSubnetMask.TextAlign = HorizontalAlignment.Left;
            TXTRealmSubnetMask.TrailingIcon = (Image)resources.GetObject("TXTRealmSubnetMask.TrailingIcon");
            TXTRealmSubnetMask.UseSystemPasswordChar = false;
            // 
            // TXTRealmLocalAddress
            // 
            TXTRealmLocalAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTRealmLocalAddress.AnimateReadOnly = true;
            TXTRealmLocalAddress.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmLocalAddress.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmLocalAddress.BackgroundImageLayout = ImageLayout.None;
            TXTRealmLocalAddress.CharacterCasing = CharacterCasing.Normal;
            TXTRealmLocalAddress.Depth = 0;
            TXTRealmLocalAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmLocalAddress.HideSelection = true;
            TXTRealmLocalAddress.Hint = "ID";
            TXTRealmLocalAddress.LeadingIcon = null;
            TXTRealmLocalAddress.Location = new Point(10, 179);
            TXTRealmLocalAddress.MaxLength = 32767;
            TXTRealmLocalAddress.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmLocalAddress.Name = "TXTRealmLocalAddress";
            TXTRealmLocalAddress.PasswordChar = '\0';
            TXTRealmLocalAddress.PrefixSuffixText = null;
            TXTRealmLocalAddress.ReadOnly = true;
            TXTRealmLocalAddress.RightToLeft = RightToLeft.No;
            TXTRealmLocalAddress.SelectedText = "";
            TXTRealmLocalAddress.SelectionLength = 0;
            TXTRealmLocalAddress.SelectionStart = 0;
            TXTRealmLocalAddress.ShortcutsEnabled = true;
            TXTRealmLocalAddress.Size = new Size(274, 48);
            TXTRealmLocalAddress.TabIndex = 6;
            TXTRealmLocalAddress.TabStop = false;
            TXTRealmLocalAddress.TextAlign = HorizontalAlignment.Left;
            TXTRealmLocalAddress.TrailingIcon = (Image)resources.GetObject("TXTRealmLocalAddress.TrailingIcon");
            TXTRealmLocalAddress.UseSystemPasswordChar = false;
            // 
            // TXTRealmAddress
            // 
            TXTRealmAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTRealmAddress.AnimateReadOnly = true;
            TXTRealmAddress.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmAddress.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmAddress.BackgroundImageLayout = ImageLayout.None;
            TXTRealmAddress.CharacterCasing = CharacterCasing.Normal;
            TXTRealmAddress.Depth = 0;
            TXTRealmAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmAddress.HideSelection = true;
            TXTRealmAddress.Hint = "ID";
            TXTRealmAddress.LeadingIcon = null;
            TXTRealmAddress.Location = new Point(10, 125);
            TXTRealmAddress.MaxLength = 32767;
            TXTRealmAddress.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmAddress.Name = "TXTRealmAddress";
            TXTRealmAddress.PasswordChar = '\0';
            TXTRealmAddress.PrefixSuffixText = null;
            TXTRealmAddress.ReadOnly = true;
            TXTRealmAddress.RightToLeft = RightToLeft.No;
            TXTRealmAddress.SelectedText = "";
            TXTRealmAddress.SelectionLength = 0;
            TXTRealmAddress.SelectionStart = 0;
            TXTRealmAddress.ShortcutsEnabled = true;
            TXTRealmAddress.Size = new Size(274, 48);
            TXTRealmAddress.TabIndex = 5;
            TXTRealmAddress.TabStop = false;
            TXTRealmAddress.TextAlign = HorizontalAlignment.Left;
            TXTRealmAddress.TrailingIcon = (Image)resources.GetObject("TXTRealmAddress.TrailingIcon");
            TXTRealmAddress.UseSystemPasswordChar = false;
            // 
            // TXTRealmName
            // 
            TXTRealmName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTRealmName.AnimateReadOnly = true;
            TXTRealmName.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmName.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmName.BackgroundImageLayout = ImageLayout.None;
            TXTRealmName.CharacterCasing = CharacterCasing.Normal;
            TXTRealmName.Depth = 0;
            TXTRealmName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmName.HideSelection = true;
            TXTRealmName.Hint = "ID";
            TXTRealmName.LeadingIcon = null;
            TXTRealmName.Location = new Point(119, 70);
            TXTRealmName.MaxLength = 32767;
            TXTRealmName.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmName.Name = "TXTRealmName";
            TXTRealmName.PasswordChar = '\0';
            TXTRealmName.PrefixSuffixText = null;
            TXTRealmName.ReadOnly = true;
            TXTRealmName.RightToLeft = RightToLeft.No;
            TXTRealmName.SelectedText = "";
            TXTRealmName.SelectionLength = 0;
            TXTRealmName.SelectionStart = 0;
            TXTRealmName.ShortcutsEnabled = true;
            TXTRealmName.Size = new Size(165, 48);
            TXTRealmName.TabIndex = 4;
            TXTRealmName.TabStop = false;
            TXTRealmName.TextAlign = HorizontalAlignment.Left;
            TXTRealmName.TrailingIcon = (Image)resources.GetObject("TXTRealmName.TrailingIcon");
            TXTRealmName.UseSystemPasswordChar = false;
            // 
            // TXTRealmID
            // 
            TXTRealmID.AnimateReadOnly = true;
            TXTRealmID.AutoCompleteMode = AutoCompleteMode.None;
            TXTRealmID.AutoCompleteSource = AutoCompleteSource.None;
            TXTRealmID.BackgroundImageLayout = ImageLayout.None;
            TXTRealmID.CharacterCasing = CharacterCasing.Normal;
            TXTRealmID.Depth = 0;
            TXTRealmID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTRealmID.HideSelection = true;
            TXTRealmID.Hint = "ID";
            TXTRealmID.LeadingIcon = null;
            TXTRealmID.Location = new Point(10, 70);
            TXTRealmID.MaxLength = 32767;
            TXTRealmID.MouseState = MaterialSkin.MouseState.OUT;
            TXTRealmID.Name = "TXTRealmID";
            TXTRealmID.PasswordChar = '\0';
            TXTRealmID.PrefixSuffixText = null;
            TXTRealmID.ReadOnly = true;
            TXTRealmID.RightToLeft = RightToLeft.No;
            TXTRealmID.SelectedText = "";
            TXTRealmID.SelectionLength = 0;
            TXTRealmID.SelectionStart = 0;
            TXTRealmID.ShortcutsEnabled = true;
            TXTRealmID.Size = new Size(103, 48);
            TXTRealmID.TabIndex = 3;
            TXTRealmID.TabStop = false;
            TXTRealmID.TextAlign = HorizontalAlignment.Left;
            TXTRealmID.TrailingIcon = (Image)resources.GetObject("TXTRealmID.TrailingIcon");
            TXTRealmID.UseSystemPasswordChar = false;
            TXTRealmID.KeyPress += TXTOnlyNumbers;
            // 
            // LBLCardRealmDataTitle
            // 
            LBLCardRealmDataTitle.AutoSize = true;
            LBLCardRealmDataTitle.Depth = 0;
            LBLCardRealmDataTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardRealmDataTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardRealmDataTitle.HighEmphasis = true;
            LBLCardRealmDataTitle.Location = new Point(10, 10);
            LBLCardRealmDataTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardRealmDataTitle.Name = "LBLCardRealmDataTitle";
            LBLCardRealmDataTitle.Size = new Size(52, 24);
            LBLCardRealmDataTitle.TabIndex = 2;
            LBLCardRealmDataTitle.Text = "DATA";
            // 
            // TabAccount
            // 
            TabAccount.BackColor = Color.White;
            TabAccount.Controls.Add(tableLayoutPanel2);
            TabAccount.Location = new Point(27, 4);
            TabAccount.Name = "TabAccount";
            TabAccount.Padding = new Padding(3);
            TabAccount.Size = new Size(905, 361);
            TabAccount.TabIndex = 1;
            TabAccount.Text = "Account";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel2.Controls.Add(materialCard3, 2, 0);
            tableLayoutPanel2.Controls.Add(materialCard4, 1, 0);
            tableLayoutPanel2.Controls.Add(materialCard5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(899, 355);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(TGLAccountShowPassword);
            materialCard3.Controls.Add(TXTBoxPassRePassword);
            materialCard3.Controls.Add(TXTBoxPassPassword);
            materialCard3.Controls.Add(TXTBoxPassUsername);
            materialCard3.Controls.Add(BTNTBoxPassResset);
            materialCard3.Controls.Add(LBLCardPasswordResetInfo);
            materialCard3.Controls.Add(LBLCardAccountPassword);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(602, 4);
            materialCard3.Margin = new Padding(4);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(4);
            materialCard3.Size = new Size(293, 347);
            materialCard3.TabIndex = 2;
            // 
            // TGLAccountShowPassword
            // 
            TGLAccountShowPassword.AutoEllipsis = true;
            TGLAccountShowPassword.Depth = 0;
            TGLAccountShowPassword.Location = new Point(10, 232);
            TGLAccountShowPassword.Margin = new Padding(0);
            TGLAccountShowPassword.MouseLocation = new Point(-1, -1);
            TGLAccountShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            TGLAccountShowPassword.Name = "TGLAccountShowPassword";
            TGLAccountShowPassword.Ripple = true;
            TGLAccountShowPassword.Size = new Size(273, 37);
            TGLAccountShowPassword.TabIndex = 23;
            TGLAccountShowPassword.Text = "show pass";
            TGLAccountShowPassword.UseVisualStyleBackColor = false;
            // 
            // TXTBoxPassRePassword
            // 
            TXTBoxPassRePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxPassRePassword.AnimateReadOnly = true;
            TXTBoxPassRePassword.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxPassRePassword.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxPassRePassword.BackgroundImageLayout = ImageLayout.None;
            TXTBoxPassRePassword.CharacterCasing = CharacterCasing.Normal;
            TXTBoxPassRePassword.Depth = 0;
            TXTBoxPassRePassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxPassRePassword.HideSelection = true;
            TXTBoxPassRePassword.Hint = "ID";
            TXTBoxPassRePassword.LeadingIcon = null;
            TXTBoxPassRePassword.Location = new Point(7, 178);
            TXTBoxPassRePassword.MaxLength = 32767;
            TXTBoxPassRePassword.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxPassRePassword.Name = "TXTBoxPassRePassword";
            TXTBoxPassRePassword.PasswordChar = '\0';
            TXTBoxPassRePassword.PrefixSuffixText = null;
            TXTBoxPassRePassword.ReadOnly = false;
            TXTBoxPassRePassword.RightToLeft = RightToLeft.No;
            TXTBoxPassRePassword.SelectedText = "";
            TXTBoxPassRePassword.SelectionLength = 0;
            TXTBoxPassRePassword.SelectionStart = 0;
            TXTBoxPassRePassword.ShortcutsEnabled = true;
            TXTBoxPassRePassword.Size = new Size(274, 48);
            TXTBoxPassRePassword.TabIndex = 22;
            TXTBoxPassRePassword.TabStop = false;
            TXTBoxPassRePassword.TextAlign = HorizontalAlignment.Left;
            TXTBoxPassRePassword.TrailingIcon = null;
            TXTBoxPassRePassword.UseSystemPasswordChar = false;
            // 
            // TXTBoxPassPassword
            // 
            TXTBoxPassPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxPassPassword.AnimateReadOnly = true;
            TXTBoxPassPassword.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxPassPassword.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxPassPassword.BackgroundImageLayout = ImageLayout.None;
            TXTBoxPassPassword.CharacterCasing = CharacterCasing.Normal;
            TXTBoxPassPassword.Depth = 0;
            TXTBoxPassPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxPassPassword.HideSelection = true;
            TXTBoxPassPassword.Hint = "ID";
            TXTBoxPassPassword.LeadingIcon = null;
            TXTBoxPassPassword.Location = new Point(9, 124);
            TXTBoxPassPassword.MaxLength = 32767;
            TXTBoxPassPassword.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxPassPassword.Name = "TXTBoxPassPassword";
            TXTBoxPassPassword.PasswordChar = '\0';
            TXTBoxPassPassword.PrefixSuffixText = null;
            TXTBoxPassPassword.ReadOnly = false;
            TXTBoxPassPassword.RightToLeft = RightToLeft.No;
            TXTBoxPassPassword.SelectedText = "";
            TXTBoxPassPassword.SelectionLength = 0;
            TXTBoxPassPassword.SelectionStart = 0;
            TXTBoxPassPassword.ShortcutsEnabled = true;
            TXTBoxPassPassword.Size = new Size(274, 48);
            TXTBoxPassPassword.TabIndex = 21;
            TXTBoxPassPassword.TabStop = false;
            TXTBoxPassPassword.TextAlign = HorizontalAlignment.Left;
            TXTBoxPassPassword.TrailingIcon = null;
            TXTBoxPassPassword.UseSystemPasswordChar = false;
            // 
            // TXTBoxPassUsername
            // 
            TXTBoxPassUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxPassUsername.AnimateReadOnly = true;
            TXTBoxPassUsername.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxPassUsername.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxPassUsername.BackgroundImageLayout = ImageLayout.None;
            TXTBoxPassUsername.CharacterCasing = CharacterCasing.Normal;
            TXTBoxPassUsername.Depth = 0;
            TXTBoxPassUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxPassUsername.HideSelection = true;
            TXTBoxPassUsername.Hint = "ID";
            TXTBoxPassUsername.LeadingIcon = null;
            TXTBoxPassUsername.Location = new Point(9, 70);
            TXTBoxPassUsername.MaxLength = 32767;
            TXTBoxPassUsername.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxPassUsername.Name = "TXTBoxPassUsername";
            TXTBoxPassUsername.PasswordChar = '\0';
            TXTBoxPassUsername.PrefixSuffixText = null;
            TXTBoxPassUsername.ReadOnly = false;
            TXTBoxPassUsername.RightToLeft = RightToLeft.No;
            TXTBoxPassUsername.SelectedText = "";
            TXTBoxPassUsername.SelectionLength = 0;
            TXTBoxPassUsername.SelectionStart = 0;
            TXTBoxPassUsername.ShortcutsEnabled = true;
            TXTBoxPassUsername.Size = new Size(274, 48);
            TXTBoxPassUsername.TabIndex = 20;
            TXTBoxPassUsername.TabStop = false;
            TXTBoxPassUsername.TextAlign = HorizontalAlignment.Left;
            TXTBoxPassUsername.TrailingIcon = null;
            TXTBoxPassUsername.UseSystemPasswordChar = false;
            // 
            // BTNTBoxPassResset
            // 
            BTNTBoxPassResset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNTBoxPassResset.AutoSize = false;
            BTNTBoxPassResset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNTBoxPassResset.Cursor = Cursors.Hand;
            BTNTBoxPassResset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNTBoxPassResset.Depth = 0;
            BTNTBoxPassResset.HighEmphasis = true;
            BTNTBoxPassResset.Icon = (Image)resources.GetObject("BTNTBoxPassResset.Icon");
            BTNTBoxPassResset.Location = new Point(10, 300);
            BTNTBoxPassResset.Margin = new Padding(4, 6, 4, 6);
            BTNTBoxPassResset.MouseState = MaterialSkin.MouseState.HOVER;
            BTNTBoxPassResset.Name = "BTNTBoxPassResset";
            BTNTBoxPassResset.NoAccentTextColor = Color.Empty;
            BTNTBoxPassResset.Size = new Size(271, 36);
            BTNTBoxPassResset.TabIndex = 19;
            BTNTBoxPassResset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNTBoxPassResset.UseAccentColor = false;
            BTNTBoxPassResset.UseVisualStyleBackColor = true;
            // 
            // LBLCardPasswordResetInfo
            // 
            LBLCardPasswordResetInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardPasswordResetInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardPasswordResetInfo.Image = (Image)resources.GetObject("LBLCardPasswordResetInfo.Image");
            LBLCardPasswordResetInfo.Location = new Point(265, 10);
            LBLCardPasswordResetInfo.Name = "LBLCardPasswordResetInfo";
            LBLCardPasswordResetInfo.Size = new Size(16, 16);
            LBLCardPasswordResetInfo.TabIndex = 14;
            LBLCardPasswordResetInfo.TabStop = false;
            // 
            // LBLCardAccountPassword
            // 
            LBLCardAccountPassword.AutoSize = true;
            LBLCardAccountPassword.Depth = 0;
            LBLCardAccountPassword.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardAccountPassword.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardAccountPassword.HighEmphasis = true;
            LBLCardAccountPassword.Location = new Point(10, 10);
            LBLCardAccountPassword.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardAccountPassword.Name = "LBLCardAccountPassword";
            LBLCardAccountPassword.Size = new Size(171, 24);
            LBLCardAccountPassword.TabIndex = 13;
            LBLCardAccountPassword.Text = "RESET PASSWORD";
            LBLCardAccountPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(CBoxGMRealmSelect);
            materialCard4.Controls.Add(CBOXAccountSecurityAccess);
            materialCard4.Controls.Add(BTNGMCreate);
            materialCard4.Controls.Add(TXTBoxGMUsername);
            materialCard4.Controls.Add(LBLCardAccountAccessInfo);
            materialCard4.Controls.Add(LBLCardAccountAdmin);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Fill;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(303, 4);
            materialCard4.Margin = new Padding(4);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(4);
            materialCard4.Size = new Size(291, 347);
            materialCard4.TabIndex = 1;
            // 
            // CBoxGMRealmSelect
            // 
            CBoxGMRealmSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBoxGMRealmSelect.AutoResize = false;
            CBoxGMRealmSelect.BackColor = Color.FromArgb(255, 255, 255);
            CBoxGMRealmSelect.Depth = 0;
            CBoxGMRealmSelect.DrawMode = DrawMode.OwnerDrawVariable;
            CBoxGMRealmSelect.DropDownHeight = 174;
            CBoxGMRealmSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxGMRealmSelect.DropDownWidth = 121;
            CBoxGMRealmSelect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBoxGMRealmSelect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBoxGMRealmSelect.FormattingEnabled = true;
            CBoxGMRealmSelect.Hint = "ID";
            CBoxGMRealmSelect.IntegralHeight = false;
            CBoxGMRealmSelect.ItemHeight = 43;
            CBoxGMRealmSelect.Location = new Point(10, 124);
            CBoxGMRealmSelect.MaxDropDownItems = 4;
            CBoxGMRealmSelect.MouseState = MaterialSkin.MouseState.OUT;
            CBoxGMRealmSelect.Name = "CBoxGMRealmSelect";
            CBoxGMRealmSelect.Size = new Size(274, 49);
            CBoxGMRealmSelect.StartIndex = 0;
            CBoxGMRealmSelect.TabIndex = 20;
            // 
            // CBOXAccountSecurityAccess
            // 
            CBOXAccountSecurityAccess.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXAccountSecurityAccess.AutoResize = false;
            CBOXAccountSecurityAccess.BackColor = Color.FromArgb(255, 255, 255);
            CBOXAccountSecurityAccess.Depth = 0;
            CBOXAccountSecurityAccess.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXAccountSecurityAccess.DropDownHeight = 174;
            CBOXAccountSecurityAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXAccountSecurityAccess.DropDownWidth = 121;
            CBOXAccountSecurityAccess.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXAccountSecurityAccess.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXAccountSecurityAccess.FormattingEnabled = true;
            CBOXAccountSecurityAccess.Hint = "ID";
            CBOXAccountSecurityAccess.IntegralHeight = false;
            CBOXAccountSecurityAccess.ItemHeight = 43;
            CBOXAccountSecurityAccess.Location = new Point(10, 179);
            CBOXAccountSecurityAccess.MaxDropDownItems = 4;
            CBOXAccountSecurityAccess.MouseState = MaterialSkin.MouseState.OUT;
            CBOXAccountSecurityAccess.Name = "CBOXAccountSecurityAccess";
            CBOXAccountSecurityAccess.Size = new Size(274, 49);
            CBOXAccountSecurityAccess.StartIndex = 0;
            CBOXAccountSecurityAccess.TabIndex = 19;
            // 
            // BTNGMCreate
            // 
            BTNGMCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNGMCreate.AutoSize = false;
            BTNGMCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNGMCreate.Cursor = Cursors.Hand;
            BTNGMCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNGMCreate.Depth = 0;
            BTNGMCreate.HighEmphasis = true;
            BTNGMCreate.Icon = (Image)resources.GetObject("BTNGMCreate.Icon");
            BTNGMCreate.Location = new Point(10, 300);
            BTNGMCreate.Margin = new Padding(4, 6, 4, 6);
            BTNGMCreate.MouseState = MaterialSkin.MouseState.HOVER;
            BTNGMCreate.Name = "BTNGMCreate";
            BTNGMCreate.NoAccentTextColor = Color.Empty;
            BTNGMCreate.Size = new Size(271, 36);
            BTNGMCreate.TabIndex = 18;
            BTNGMCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNGMCreate.UseAccentColor = false;
            BTNGMCreate.UseVisualStyleBackColor = true;
            // 
            // TXTBoxGMUsername
            // 
            TXTBoxGMUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxGMUsername.AnimateReadOnly = true;
            TXTBoxGMUsername.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxGMUsername.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxGMUsername.BackgroundImageLayout = ImageLayout.None;
            TXTBoxGMUsername.CharacterCasing = CharacterCasing.Normal;
            TXTBoxGMUsername.Depth = 0;
            TXTBoxGMUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxGMUsername.HideSelection = true;
            TXTBoxGMUsername.Hint = "ID";
            TXTBoxGMUsername.LeadingIcon = null;
            TXTBoxGMUsername.Location = new Point(10, 70);
            TXTBoxGMUsername.MaxLength = 32767;
            TXTBoxGMUsername.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxGMUsername.Name = "TXTBoxGMUsername";
            TXTBoxGMUsername.PasswordChar = '\0';
            TXTBoxGMUsername.PrefixSuffixText = null;
            TXTBoxGMUsername.ReadOnly = false;
            TXTBoxGMUsername.RightToLeft = RightToLeft.No;
            TXTBoxGMUsername.SelectedText = "";
            TXTBoxGMUsername.SelectionLength = 0;
            TXTBoxGMUsername.SelectionStart = 0;
            TXTBoxGMUsername.ShortcutsEnabled = true;
            TXTBoxGMUsername.Size = new Size(274, 48);
            TXTBoxGMUsername.TabIndex = 14;
            TXTBoxGMUsername.TabStop = false;
            TXTBoxGMUsername.TextAlign = HorizontalAlignment.Left;
            TXTBoxGMUsername.TrailingIcon = null;
            TXTBoxGMUsername.UseSystemPasswordChar = false;
            // 
            // LBLCardAccountAccessInfo
            // 
            LBLCardAccountAccessInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardAccountAccessInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardAccountAccessInfo.Image = (Image)resources.GetObject("LBLCardAccountAccessInfo.Image");
            LBLCardAccountAccessInfo.Location = new Point(265, 10);
            LBLCardAccountAccessInfo.Name = "LBLCardAccountAccessInfo";
            LBLCardAccountAccessInfo.Size = new Size(16, 16);
            LBLCardAccountAccessInfo.TabIndex = 12;
            LBLCardAccountAccessInfo.TabStop = false;
            // 
            // LBLCardAccountAdmin
            // 
            LBLCardAccountAdmin.AutoSize = true;
            LBLCardAccountAdmin.Depth = 0;
            LBLCardAccountAdmin.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardAccountAdmin.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardAccountAdmin.HighEmphasis = true;
            LBLCardAccountAdmin.Location = new Point(7, 10);
            LBLCardAccountAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardAccountAdmin.Name = "LBLCardAccountAdmin";
            LBLCardAccountAdmin.Size = new Size(73, 24);
            LBLCardAccountAdmin.TabIndex = 11;
            LBLCardAccountAdmin.Text = "SET GM";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(CBOXAccountExpansion);
            materialCard5.Controls.Add(BTNAccountCreate);
            materialCard5.Controls.Add(TXTBoxCreateUserEmail);
            materialCard5.Controls.Add(TXTBoxCreateUserPassword);
            materialCard5.Controls.Add(TXTBoxCreateUserUsername);
            materialCard5.Controls.Add(LBLCardAccountCreateInfo);
            materialCard5.Controls.Add(LBLCardAccountCreate);
            materialCard5.Depth = 0;
            materialCard5.Dock = DockStyle.Fill;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(4, 4);
            materialCard5.Margin = new Padding(4);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(4);
            materialCard5.Size = new Size(291, 347);
            materialCard5.TabIndex = 0;
            // 
            // CBOXAccountExpansion
            // 
            CBOXAccountExpansion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXAccountExpansion.AutoResize = false;
            CBOXAccountExpansion.BackColor = Color.FromArgb(255, 255, 255);
            CBOXAccountExpansion.Depth = 0;
            CBOXAccountExpansion.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXAccountExpansion.DropDownHeight = 174;
            CBOXAccountExpansion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXAccountExpansion.DropDownWidth = 121;
            CBOXAccountExpansion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXAccountExpansion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXAccountExpansion.FormattingEnabled = true;
            CBOXAccountExpansion.Hint = "ID";
            CBOXAccountExpansion.IntegralHeight = false;
            CBOXAccountExpansion.ItemHeight = 43;
            CBOXAccountExpansion.Location = new Point(9, 232);
            CBOXAccountExpansion.MaxDropDownItems = 4;
            CBOXAccountExpansion.MouseState = MaterialSkin.MouseState.OUT;
            CBOXAccountExpansion.Name = "CBOXAccountExpansion";
            CBOXAccountExpansion.Size = new Size(274, 49);
            CBOXAccountExpansion.StartIndex = 0;
            CBOXAccountExpansion.TabIndex = 20;
            // 
            // BTNAccountCreate
            // 
            BTNAccountCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNAccountCreate.AutoSize = false;
            BTNAccountCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNAccountCreate.Cursor = Cursors.Hand;
            BTNAccountCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNAccountCreate.Depth = 0;
            BTNAccountCreate.HighEmphasis = true;
            BTNAccountCreate.Icon = (Image)resources.GetObject("BTNAccountCreate.Icon");
            BTNAccountCreate.Location = new Point(10, 300);
            BTNAccountCreate.Margin = new Padding(4, 6, 4, 6);
            BTNAccountCreate.MouseState = MaterialSkin.MouseState.HOVER;
            BTNAccountCreate.Name = "BTNAccountCreate";
            BTNAccountCreate.NoAccentTextColor = Color.Empty;
            BTNAccountCreate.Size = new Size(271, 36);
            BTNAccountCreate.TabIndex = 17;
            BTNAccountCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNAccountCreate.UseAccentColor = false;
            BTNAccountCreate.UseVisualStyleBackColor = true;
            // 
            // TXTBoxCreateUserEmail
            // 
            TXTBoxCreateUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxCreateUserEmail.AnimateReadOnly = true;
            TXTBoxCreateUserEmail.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxCreateUserEmail.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxCreateUserEmail.BackgroundImageLayout = ImageLayout.None;
            TXTBoxCreateUserEmail.CharacterCasing = CharacterCasing.Normal;
            TXTBoxCreateUserEmail.Depth = 0;
            TXTBoxCreateUserEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxCreateUserEmail.HideSelection = true;
            TXTBoxCreateUserEmail.Hint = "ID";
            TXTBoxCreateUserEmail.LeadingIcon = null;
            TXTBoxCreateUserEmail.Location = new Point(10, 178);
            TXTBoxCreateUserEmail.MaxLength = 32767;
            TXTBoxCreateUserEmail.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxCreateUserEmail.Name = "TXTBoxCreateUserEmail";
            TXTBoxCreateUserEmail.PasswordChar = '\0';
            TXTBoxCreateUserEmail.PrefixSuffixText = null;
            TXTBoxCreateUserEmail.ReadOnly = false;
            TXTBoxCreateUserEmail.RightToLeft = RightToLeft.No;
            TXTBoxCreateUserEmail.SelectedText = "";
            TXTBoxCreateUserEmail.SelectionLength = 0;
            TXTBoxCreateUserEmail.SelectionStart = 0;
            TXTBoxCreateUserEmail.ShortcutsEnabled = true;
            TXTBoxCreateUserEmail.Size = new Size(274, 48);
            TXTBoxCreateUserEmail.TabIndex = 15;
            TXTBoxCreateUserEmail.TabStop = false;
            TXTBoxCreateUserEmail.TextAlign = HorizontalAlignment.Left;
            TXTBoxCreateUserEmail.TrailingIcon = null;
            TXTBoxCreateUserEmail.UseSystemPasswordChar = false;
            // 
            // TXTBoxCreateUserPassword
            // 
            TXTBoxCreateUserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxCreateUserPassword.AnimateReadOnly = true;
            TXTBoxCreateUserPassword.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxCreateUserPassword.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxCreateUserPassword.BackgroundImageLayout = ImageLayout.None;
            TXTBoxCreateUserPassword.CharacterCasing = CharacterCasing.Normal;
            TXTBoxCreateUserPassword.Depth = 0;
            TXTBoxCreateUserPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxCreateUserPassword.HideSelection = true;
            TXTBoxCreateUserPassword.Hint = "ID";
            TXTBoxCreateUserPassword.LeadingIcon = null;
            TXTBoxCreateUserPassword.Location = new Point(10, 124);
            TXTBoxCreateUserPassword.MaxLength = 32767;
            TXTBoxCreateUserPassword.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxCreateUserPassword.Name = "TXTBoxCreateUserPassword";
            TXTBoxCreateUserPassword.PasswordChar = '\0';
            TXTBoxCreateUserPassword.PrefixSuffixText = null;
            TXTBoxCreateUserPassword.ReadOnly = false;
            TXTBoxCreateUserPassword.RightToLeft = RightToLeft.No;
            TXTBoxCreateUserPassword.SelectedText = "";
            TXTBoxCreateUserPassword.SelectionLength = 0;
            TXTBoxCreateUserPassword.SelectionStart = 0;
            TXTBoxCreateUserPassword.ShortcutsEnabled = true;
            TXTBoxCreateUserPassword.Size = new Size(274, 48);
            TXTBoxCreateUserPassword.TabIndex = 14;
            TXTBoxCreateUserPassword.TabStop = false;
            TXTBoxCreateUserPassword.TextAlign = HorizontalAlignment.Left;
            TXTBoxCreateUserPassword.TrailingIcon = null;
            TXTBoxCreateUserPassword.UseSystemPasswordChar = false;
            // 
            // TXTBoxCreateUserUsername
            // 
            TXTBoxCreateUserUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTBoxCreateUserUsername.AnimateReadOnly = true;
            TXTBoxCreateUserUsername.AutoCompleteMode = AutoCompleteMode.None;
            TXTBoxCreateUserUsername.AutoCompleteSource = AutoCompleteSource.None;
            TXTBoxCreateUserUsername.BackgroundImageLayout = ImageLayout.None;
            TXTBoxCreateUserUsername.CharacterCasing = CharacterCasing.Normal;
            TXTBoxCreateUserUsername.Depth = 0;
            TXTBoxCreateUserUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTBoxCreateUserUsername.HideSelection = true;
            TXTBoxCreateUserUsername.Hint = "ID";
            TXTBoxCreateUserUsername.LeadingIcon = null;
            TXTBoxCreateUserUsername.Location = new Point(10, 70);
            TXTBoxCreateUserUsername.MaxLength = 32767;
            TXTBoxCreateUserUsername.MouseState = MaterialSkin.MouseState.OUT;
            TXTBoxCreateUserUsername.Name = "TXTBoxCreateUserUsername";
            TXTBoxCreateUserUsername.PasswordChar = '\0';
            TXTBoxCreateUserUsername.PrefixSuffixText = null;
            TXTBoxCreateUserUsername.ReadOnly = false;
            TXTBoxCreateUserUsername.RightToLeft = RightToLeft.No;
            TXTBoxCreateUserUsername.SelectedText = "";
            TXTBoxCreateUserUsername.SelectionLength = 0;
            TXTBoxCreateUserUsername.SelectionStart = 0;
            TXTBoxCreateUserUsername.ShortcutsEnabled = true;
            TXTBoxCreateUserUsername.Size = new Size(274, 48);
            TXTBoxCreateUserUsername.TabIndex = 13;
            TXTBoxCreateUserUsername.TabStop = false;
            TXTBoxCreateUserUsername.TextAlign = HorizontalAlignment.Left;
            TXTBoxCreateUserUsername.TrailingIcon = null;
            TXTBoxCreateUserUsername.UseSystemPasswordChar = false;
            // 
            // LBLCardAccountCreateInfo
            // 
            LBLCardAccountCreateInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardAccountCreateInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardAccountCreateInfo.Image = (Image)resources.GetObject("LBLCardAccountCreateInfo.Image");
            LBLCardAccountCreateInfo.Location = new Point(265, 10);
            LBLCardAccountCreateInfo.Name = "LBLCardAccountCreateInfo";
            LBLCardAccountCreateInfo.Size = new Size(16, 16);
            LBLCardAccountCreateInfo.TabIndex = 12;
            LBLCardAccountCreateInfo.TabStop = false;
            // 
            // LBLCardAccountCreate
            // 
            LBLCardAccountCreate.AutoSize = true;
            LBLCardAccountCreate.Depth = 0;
            LBLCardAccountCreate.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardAccountCreate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardAccountCreate.HighEmphasis = true;
            LBLCardAccountCreate.Location = new Point(10, 10);
            LBLCardAccountCreate.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardAccountCreate.Name = "LBLCardAccountCreate";
            LBLCardAccountCreate.Size = new Size(170, 24);
            LBLCardAccountCreate.TabIndex = 11;
            LBLCardAccountCreate.Text = "ACCOUNT CREATE";
            // 
            // TabDDNS
            // 
            TabDDNS.BackColor = Color.White;
            TabDDNS.Controls.Add(tableLayoutPanel9);
            TabDDNS.ImageKey = "dns-32.png";
            TabDDNS.Location = new Point(39, 4);
            TabDDNS.Name = "TabDDNS";
            TabDDNS.Size = new Size(948, 431);
            TabDDNS.TabIndex = 4;
            TabDDNS.Text = "DNS";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(materialCard20, 1, 0);
            tableLayoutPanel9.Controls.Add(materialCard19, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(948, 431);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // materialCard20
            // 
            materialCard20.BackColor = Color.FromArgb(255, 255, 255);
            materialCard20.Controls.Add(BTNDDNSTimerStart);
            materialCard20.Controls.Add(BTNDDNSServiceWebiste);
            materialCard20.Controls.Add(TGLDDNSRunOnStartup);
            materialCard20.Controls.Add(TXTDDNSInterval);
            materialCard20.Controls.Add(LBLCardDDNSTimerInfos);
            materialCard20.Controls.Add(LBLCardDDNSTimerTitle);
            materialCard20.Depth = 0;
            materialCard20.Dock = DockStyle.Fill;
            materialCard20.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard20.Location = new Point(478, 4);
            materialCard20.Margin = new Padding(4);
            materialCard20.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard20.Name = "materialCard20";
            materialCard20.Padding = new Padding(4);
            materialCard20.Size = new Size(466, 423);
            materialCard20.TabIndex = 1;
            // 
            // BTNDDNSTimerStart
            // 
            BTNDDNSTimerStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDDNSTimerStart.AutoSize = false;
            BTNDDNSTimerStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDDNSTimerStart.Cursor = Cursors.Hand;
            BTNDDNSTimerStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDDNSTimerStart.Depth = 0;
            BTNDDNSTimerStart.HighEmphasis = true;
            BTNDDNSTimerStart.Icon = (Image)resources.GetObject("BTNDDNSTimerStart.Icon");
            BTNDDNSTimerStart.Location = new Point(8, 227);
            BTNDDNSTimerStart.Margin = new Padding(4, 6, 4, 6);
            BTNDDNSTimerStart.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDDNSTimerStart.Name = "BTNDDNSTimerStart";
            BTNDDNSTimerStart.NoAccentTextColor = Color.Empty;
            BTNDDNSTimerStart.Size = new Size(448, 36);
            BTNDDNSTimerStart.TabIndex = 14;
            BTNDDNSTimerStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDDNSTimerStart.UseAccentColor = false;
            BTNDDNSTimerStart.UseVisualStyleBackColor = true;
            // 
            // BTNDDNSServiceWebiste
            // 
            BTNDDNSServiceWebiste.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDDNSServiceWebiste.AutoSize = false;
            BTNDDNSServiceWebiste.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDDNSServiceWebiste.Cursor = Cursors.Hand;
            BTNDDNSServiceWebiste.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDDNSServiceWebiste.Depth = 0;
            BTNDDNSServiceWebiste.HighEmphasis = true;
            BTNDDNSServiceWebiste.Icon = (Image)resources.GetObject("BTNDDNSServiceWebiste.Icon");
            BTNDDNSServiceWebiste.Location = new Point(8, 179);
            BTNDDNSServiceWebiste.Margin = new Padding(4, 6, 4, 6);
            BTNDDNSServiceWebiste.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDDNSServiceWebiste.Name = "BTNDDNSServiceWebiste";
            BTNDDNSServiceWebiste.NoAccentTextColor = Color.Empty;
            BTNDDNSServiceWebiste.Size = new Size(448, 36);
            BTNDDNSServiceWebiste.TabIndex = 13;
            BTNDDNSServiceWebiste.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDDNSServiceWebiste.UseAccentColor = false;
            BTNDDNSServiceWebiste.UseVisualStyleBackColor = true;
            // 
            // TGLDDNSRunOnStartup
            // 
            TGLDDNSRunOnStartup.AutoSize = true;
            TGLDDNSRunOnStartup.Depth = 0;
            TGLDDNSRunOnStartup.Location = new Point(7, 130);
            TGLDDNSRunOnStartup.Margin = new Padding(0);
            TGLDDNSRunOnStartup.MouseLocation = new Point(-1, -1);
            TGLDDNSRunOnStartup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLDDNSRunOnStartup.Name = "TGLDDNSRunOnStartup";
            TGLDDNSRunOnStartup.Ripple = true;
            TGLDDNSRunOnStartup.Size = new Size(214, 37);
            TGLDDNSRunOnStartup.TabIndex = 12;
            TGLDDNSRunOnStartup.Text = "Server crash detection";
            TGLDDNSRunOnStartup.UseVisualStyleBackColor = true;
            // 
            // TXTDDNSInterval
            // 
            TXTDDNSInterval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDDNSInterval.AnimateReadOnly = true;
            TXTDDNSInterval.AutoCompleteMode = AutoCompleteMode.None;
            TXTDDNSInterval.AutoCompleteSource = AutoCompleteSource.None;
            TXTDDNSInterval.BackgroundImageLayout = ImageLayout.None;
            TXTDDNSInterval.CharacterCasing = CharacterCasing.Normal;
            TXTDDNSInterval.Depth = 0;
            TXTDDNSInterval.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDDNSInterval.HideSelection = true;
            TXTDDNSInterval.Hint = "ID";
            TXTDDNSInterval.LeadingIcon = null;
            TXTDDNSInterval.Location = new Point(7, 70);
            TXTDDNSInterval.MaxLength = 32767;
            TXTDDNSInterval.MouseState = MaterialSkin.MouseState.OUT;
            TXTDDNSInterval.Name = "TXTDDNSInterval";
            TXTDDNSInterval.PasswordChar = '\0';
            TXTDDNSInterval.PrefixSuffixText = null;
            TXTDDNSInterval.ReadOnly = true;
            TXTDDNSInterval.RightToLeft = RightToLeft.No;
            TXTDDNSInterval.SelectedText = "";
            TXTDDNSInterval.SelectionLength = 0;
            TXTDDNSInterval.SelectionStart = 0;
            TXTDDNSInterval.ShortcutsEnabled = true;
            TXTDDNSInterval.Size = new Size(449, 48);
            TXTDDNSInterval.TabIndex = 11;
            TXTDDNSInterval.TabStop = false;
            TXTDDNSInterval.TextAlign = HorizontalAlignment.Left;
            TXTDDNSInterval.TrailingIcon = (Image)resources.GetObject("TXTDDNSInterval.TrailingIcon");
            TXTDDNSInterval.UseSystemPasswordChar = false;
            // 
            // LBLCardDDNSTimerInfos
            // 
            LBLCardDDNSTimerInfos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardDDNSTimerInfos.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardDDNSTimerInfos.Image = (Image)resources.GetObject("LBLCardDDNSTimerInfos.Image");
            LBLCardDDNSTimerInfos.Location = new Point(444, 10);
            LBLCardDDNSTimerInfos.Name = "LBLCardDDNSTimerInfos";
            LBLCardDDNSTimerInfos.Size = new Size(16, 16);
            LBLCardDDNSTimerInfos.TabIndex = 10;
            LBLCardDDNSTimerInfos.TabStop = false;
            // 
            // LBLCardDDNSTimerTitle
            // 
            LBLCardDDNSTimerTitle.AutoSize = true;
            LBLCardDDNSTimerTitle.Depth = 0;
            LBLCardDDNSTimerTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardDDNSTimerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardDDNSTimerTitle.HighEmphasis = true;
            LBLCardDDNSTimerTitle.Location = new Point(10, 10);
            LBLCardDDNSTimerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardDDNSTimerTitle.Name = "LBLCardDDNSTimerTitle";
            LBLCardDDNSTimerTitle.Size = new Size(65, 24);
            LBLCardDDNSTimerTitle.TabIndex = 8;
            LBLCardDDNSTimerTitle.Text = "Update";
            // 
            // materialCard19
            // 
            materialCard19.BackColor = Color.FromArgb(255, 255, 255);
            materialCard19.Controls.Add(CBOXDDNService);
            materialCard19.Controls.Add(TXTDDNSPassword);
            materialCard19.Controls.Add(TXTDDNSUsername);
            materialCard19.Controls.Add(TXTDDNSDomain);
            materialCard19.Controls.Add(LBLCardDDNSSettingsInfo);
            materialCard19.Controls.Add(LBLCardDDNSSettingsTitle);
            materialCard19.Depth = 0;
            materialCard19.Dock = DockStyle.Fill;
            materialCard19.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard19.Location = new Point(4, 4);
            materialCard19.Margin = new Padding(4);
            materialCard19.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard19.Name = "materialCard19";
            materialCard19.Padding = new Padding(4);
            materialCard19.Size = new Size(466, 423);
            materialCard19.TabIndex = 0;
            // 
            // CBOXDDNService
            // 
            CBOXDDNService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXDDNService.AutoCompleteCustomSource.AddRange(new string[] { "freedns.afraid.org", "all-inkl.com", "cloudflare.com", "duckdns.org", "noip.com", "dynu.com", "dyn.com", "enom.com", "freemyip.com", "ovhcloud.com", "strato.de" });
            CBOXDDNService.AutoResize = false;
            CBOXDDNService.BackColor = Color.FromArgb(255, 255, 255);
            CBOXDDNService.Depth = 0;
            CBOXDDNService.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXDDNService.DropDownHeight = 174;
            CBOXDDNService.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXDDNService.DropDownWidth = 121;
            CBOXDDNService.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXDDNService.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXDDNService.FormattingEnabled = true;
            CBOXDDNService.Hint = "ID";
            CBOXDDNService.IntegralHeight = false;
            CBOXDDNService.ItemHeight = 43;
            CBOXDDNService.Items.AddRange(new object[] { "freedns.afraid.org", "all-inkl.com", "cloudflare.com", "duckdns.org", "noip.com", "dynu.com", "dyn.com", "enom.com", "freemyip.com", "ovhcloud.com", "strato.de" });
            CBOXDDNService.Location = new Point(10, 70);
            CBOXDDNService.MaxDropDownItems = 4;
            CBOXDDNService.MouseState = MaterialSkin.MouseState.OUT;
            CBOXDDNService.Name = "CBOXDDNService";
            CBOXDDNService.Size = new Size(449, 49);
            CBOXDDNService.StartIndex = 0;
            CBOXDDNService.TabIndex = 13;
            // 
            // TXTDDNSPassword
            // 
            TXTDDNSPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDDNSPassword.AnimateReadOnly = true;
            TXTDDNSPassword.AutoCompleteMode = AutoCompleteMode.None;
            TXTDDNSPassword.AutoCompleteSource = AutoCompleteSource.None;
            TXTDDNSPassword.BackgroundImageLayout = ImageLayout.None;
            TXTDDNSPassword.CharacterCasing = CharacterCasing.Normal;
            TXTDDNSPassword.Depth = 0;
            TXTDDNSPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDDNSPassword.HideSelection = true;
            TXTDDNSPassword.Hint = "ID";
            TXTDDNSPassword.LeadingIcon = null;
            TXTDDNSPassword.Location = new Point(10, 233);
            TXTDDNSPassword.MaxLength = 32767;
            TXTDDNSPassword.MouseState = MaterialSkin.MouseState.OUT;
            TXTDDNSPassword.Name = "TXTDDNSPassword";
            TXTDDNSPassword.PasswordChar = '\0';
            TXTDDNSPassword.PrefixSuffixText = null;
            TXTDDNSPassword.ReadOnly = true;
            TXTDDNSPassword.RightToLeft = RightToLeft.No;
            TXTDDNSPassword.SelectedText = "";
            TXTDDNSPassword.SelectionLength = 0;
            TXTDDNSPassword.SelectionStart = 0;
            TXTDDNSPassword.ShortcutsEnabled = true;
            TXTDDNSPassword.Size = new Size(449, 48);
            TXTDDNSPassword.TabIndex = 12;
            TXTDDNSPassword.TabStop = false;
            TXTDDNSPassword.TextAlign = HorizontalAlignment.Left;
            TXTDDNSPassword.TrailingIcon = (Image)resources.GetObject("TXTDDNSPassword.TrailingIcon");
            TXTDDNSPassword.UseSystemPasswordChar = false;
            // 
            // TXTDDNSUsername
            // 
            TXTDDNSUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDDNSUsername.AnimateReadOnly = true;
            TXTDDNSUsername.AutoCompleteMode = AutoCompleteMode.None;
            TXTDDNSUsername.AutoCompleteSource = AutoCompleteSource.None;
            TXTDDNSUsername.BackgroundImageLayout = ImageLayout.None;
            TXTDDNSUsername.CharacterCasing = CharacterCasing.Normal;
            TXTDDNSUsername.Depth = 0;
            TXTDDNSUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDDNSUsername.HideSelection = true;
            TXTDDNSUsername.Hint = "ID";
            TXTDDNSUsername.LeadingIcon = null;
            TXTDDNSUsername.Location = new Point(10, 179);
            TXTDDNSUsername.MaxLength = 32767;
            TXTDDNSUsername.MouseState = MaterialSkin.MouseState.OUT;
            TXTDDNSUsername.Name = "TXTDDNSUsername";
            TXTDDNSUsername.PasswordChar = '\0';
            TXTDDNSUsername.PrefixSuffixText = null;
            TXTDDNSUsername.ReadOnly = true;
            TXTDDNSUsername.RightToLeft = RightToLeft.No;
            TXTDDNSUsername.SelectedText = "";
            TXTDDNSUsername.SelectionLength = 0;
            TXTDDNSUsername.SelectionStart = 0;
            TXTDDNSUsername.ShortcutsEnabled = true;
            TXTDDNSUsername.Size = new Size(449, 48);
            TXTDDNSUsername.TabIndex = 11;
            TXTDDNSUsername.TabStop = false;
            TXTDDNSUsername.TextAlign = HorizontalAlignment.Left;
            TXTDDNSUsername.TrailingIcon = (Image)resources.GetObject("TXTDDNSUsername.TrailingIcon");
            TXTDDNSUsername.UseSystemPasswordChar = false;
            // 
            // TXTDDNSDomain
            // 
            TXTDDNSDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDDNSDomain.AnimateReadOnly = true;
            TXTDDNSDomain.AutoCompleteMode = AutoCompleteMode.None;
            TXTDDNSDomain.AutoCompleteSource = AutoCompleteSource.None;
            TXTDDNSDomain.BackgroundImageLayout = ImageLayout.None;
            TXTDDNSDomain.CharacterCasing = CharacterCasing.Normal;
            TXTDDNSDomain.Depth = 0;
            TXTDDNSDomain.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDDNSDomain.HideSelection = true;
            TXTDDNSDomain.Hint = "ID";
            TXTDDNSDomain.LeadingIcon = null;
            TXTDDNSDomain.Location = new Point(10, 125);
            TXTDDNSDomain.MaxLength = 32767;
            TXTDDNSDomain.MouseState = MaterialSkin.MouseState.OUT;
            TXTDDNSDomain.Name = "TXTDDNSDomain";
            TXTDDNSDomain.PasswordChar = '\0';
            TXTDDNSDomain.PrefixSuffixText = null;
            TXTDDNSDomain.ReadOnly = true;
            TXTDDNSDomain.RightToLeft = RightToLeft.No;
            TXTDDNSDomain.SelectedText = "";
            TXTDDNSDomain.SelectionLength = 0;
            TXTDDNSDomain.SelectionStart = 0;
            TXTDDNSDomain.ShortcutsEnabled = true;
            TXTDDNSDomain.Size = new Size(449, 48);
            TXTDDNSDomain.TabIndex = 10;
            TXTDDNSDomain.TabStop = false;
            TXTDDNSDomain.TextAlign = HorizontalAlignment.Left;
            TXTDDNSDomain.TrailingIcon = (Image)resources.GetObject("TXTDDNSDomain.TrailingIcon");
            TXTDDNSDomain.UseSystemPasswordChar = false;
            // 
            // LBLCardDDNSSettingsInfo
            // 
            LBLCardDDNSSettingsInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardDDNSSettingsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardDDNSSettingsInfo.Image = (Image)resources.GetObject("LBLCardDDNSSettingsInfo.Image");
            LBLCardDDNSSettingsInfo.Location = new Point(444, 10);
            LBLCardDDNSSettingsInfo.Name = "LBLCardDDNSSettingsInfo";
            LBLCardDDNSSettingsInfo.Size = new Size(16, 16);
            LBLCardDDNSSettingsInfo.TabIndex = 9;
            LBLCardDDNSSettingsInfo.TabStop = false;
            // 
            // LBLCardDDNSSettingsTitle
            // 
            LBLCardDDNSSettingsTitle.AutoSize = true;
            LBLCardDDNSSettingsTitle.Depth = 0;
            LBLCardDDNSSettingsTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardDDNSSettingsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardDDNSSettingsTitle.HighEmphasis = true;
            LBLCardDDNSSettingsTitle.Location = new Point(10, 10);
            LBLCardDDNSSettingsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardDDNSSettingsTitle.Name = "LBLCardDDNSSettingsTitle";
            LBLCardDDNSSettingsTitle.Size = new Size(65, 24);
            LBLCardDDNSSettingsTitle.TabIndex = 8;
            LBLCardDDNSSettingsTitle.Text = "Update";
            // 
            // TabSettings
            // 
            TabSettings.BackColor = Color.White;
            TabSettings.Controls.Add(tableLayoutPanel3);
            TabSettings.ImageKey = "settings-35.png";
            TabSettings.Location = new Point(39, 4);
            TabSettings.Name = "TabSettings";
            TabSettings.Padding = new Padding(3);
            TabSettings.Size = new Size(948, 431);
            TabSettings.TabIndex = 2;
            TabSettings.Text = "SET";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(SettingsTabSelector, 0, 0);
            tableLayoutPanel3.Controls.Add(SettingsTabControl, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(942, 425);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // SettingsTabSelector
            // 
            SettingsTabSelector.BaseTabControl = SettingsTabControl;
            SettingsTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            SettingsTabSelector.Depth = 0;
            SettingsTabSelector.Dock = DockStyle.Fill;
            SettingsTabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            SettingsTabSelector.Location = new Point(3, 3);
            SettingsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            SettingsTabSelector.Name = "SettingsTabSelector";
            SettingsTabSelector.Size = new Size(936, 44);
            SettingsTabSelector.TabIndex = 0;
            SettingsTabSelector.TabIndicatorHeight = 5;
            SettingsTabSelector.Text = "DatabaseEditorTabSelector";
            // 
            // SettingsTabControl
            // 
            SettingsTabControl.Alignment = TabAlignment.Left;
            SettingsTabControl.Controls.Add(TabTrion);
            SettingsTabControl.Controls.Add(TabCustom);
            SettingsTabControl.Controls.Add(TabDatabase);
            SettingsTabControl.Depth = 0;
            SettingsTabControl.Dock = DockStyle.Fill;
            SettingsTabControl.Location = new Point(3, 53);
            SettingsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            SettingsTabControl.Multiline = true;
            SettingsTabControl.Name = "SettingsTabControl";
            SettingsTabControl.SelectedIndex = 0;
            SettingsTabControl.Size = new Size(936, 369);
            SettingsTabControl.TabIndex = 1;
            // 
            // TabTrion
            // 
            TabTrion.BackColor = Color.White;
            TabTrion.Controls.Add(tableLayoutPanel4);
            TabTrion.Location = new Point(27, 4);
            TabTrion.Name = "TabTrion";
            TabTrion.Padding = new Padding(3);
            TabTrion.Size = new Size(905, 361);
            TabTrion.TabIndex = 0;
            TabTrion.Text = "Trion";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Controls.Add(materialCard6, 1, 0);
            tableLayoutPanel4.Controls.Add(materialCard7, 2, 0);
            tableLayoutPanel4.Controls.Add(materialCard8, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(899, 355);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(LBLCardCustomPreferencesInfo);
            materialCard6.Controls.Add(LBLCardCustomPreferencesTitle);
            materialCard6.Controls.Add(CBOXColorSelect);
            materialCard6.Controls.Add(CBOXLanguageSelect);
            materialCard6.Depth = 0;
            materialCard6.Dock = DockStyle.Fill;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(273, 4);
            materialCard6.Margin = new Padding(4);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(4);
            materialCard6.Size = new Size(261, 347);
            materialCard6.TabIndex = 5;
            // 
            // LBLCardCustomPreferencesInfo
            // 
            LBLCardCustomPreferencesInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardCustomPreferencesInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardCustomPreferencesInfo.Image = (Image)resources.GetObject("LBLCardCustomPreferencesInfo.Image");
            LBLCardCustomPreferencesInfo.Location = new Point(237, 10);
            LBLCardCustomPreferencesInfo.Name = "LBLCardCustomPreferencesInfo";
            LBLCardCustomPreferencesInfo.Size = new Size(16, 16);
            LBLCardCustomPreferencesInfo.TabIndex = 8;
            LBLCardCustomPreferencesInfo.TabStop = false;
            // 
            // LBLCardCustomPreferencesTitle
            // 
            LBLCardCustomPreferencesTitle.AutoSize = true;
            LBLCardCustomPreferencesTitle.Depth = 0;
            LBLCardCustomPreferencesTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardCustomPreferencesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardCustomPreferencesTitle.HighEmphasis = true;
            LBLCardCustomPreferencesTitle.Location = new Point(10, 10);
            LBLCardCustomPreferencesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardCustomPreferencesTitle.Name = "LBLCardCustomPreferencesTitle";
            LBLCardCustomPreferencesTitle.Size = new Size(65, 24);
            LBLCardCustomPreferencesTitle.TabIndex = 7;
            LBLCardCustomPreferencesTitle.Text = "Update";
            // 
            // CBOXColorSelect
            // 
            CBOXColorSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXColorSelect.AutoResize = false;
            CBOXColorSelect.BackColor = Color.FromArgb(255, 255, 255);
            CBOXColorSelect.Depth = 0;
            CBOXColorSelect.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXColorSelect.DropDownHeight = 174;
            CBOXColorSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXColorSelect.DropDownWidth = 121;
            CBOXColorSelect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXColorSelect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXColorSelect.FormattingEnabled = true;
            CBOXColorSelect.Hint = "ID";
            CBOXColorSelect.IntegralHeight = false;
            CBOXColorSelect.ItemHeight = 43;
            CBOXColorSelect.Location = new Point(10, 125);
            CBOXColorSelect.MaxDropDownItems = 4;
            CBOXColorSelect.MouseState = MaterialSkin.MouseState.OUT;
            CBOXColorSelect.Name = "CBOXColorSelect";
            CBOXColorSelect.Size = new Size(243, 49);
            CBOXColorSelect.StartIndex = 0;
            CBOXColorSelect.TabIndex = 6;
            CBOXColorSelect.SelectedIndexChanged += CBOXColorSelect_SelectedIndexChanged;
            // 
            // CBOXLanguageSelect
            // 
            CBOXLanguageSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXLanguageSelect.AutoResize = false;
            CBOXLanguageSelect.BackColor = Color.FromArgb(255, 255, 255);
            CBOXLanguageSelect.Depth = 0;
            CBOXLanguageSelect.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXLanguageSelect.DropDownHeight = 174;
            CBOXLanguageSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXLanguageSelect.DropDownWidth = 121;
            CBOXLanguageSelect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXLanguageSelect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXLanguageSelect.FormattingEnabled = true;
            CBOXLanguageSelect.Hint = "ID";
            CBOXLanguageSelect.IntegralHeight = false;
            CBOXLanguageSelect.ItemHeight = 43;
            CBOXLanguageSelect.Location = new Point(10, 70);
            CBOXLanguageSelect.MaxDropDownItems = 4;
            CBOXLanguageSelect.MouseState = MaterialSkin.MouseState.OUT;
            CBOXLanguageSelect.Name = "CBOXLanguageSelect";
            CBOXLanguageSelect.Size = new Size(243, 49);
            CBOXLanguageSelect.StartIndex = 0;
            CBOXLanguageSelect.TabIndex = 5;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(tableLayoutPanel10);
            materialCard7.Controls.Add(LBLCardUpdateDashboardInfo);
            materialCard7.Controls.Add(LBLCardUpdateDashboardTitle);
            materialCard7.Depth = 0;
            materialCard7.Dock = DockStyle.Fill;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(542, 4);
            materialCard7.Margin = new Padding(4);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(4);
            materialCard7.Size = new Size(353, 347);
            materialCard7.TabIndex = 4;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(metroPanel7, 0, 6);
            tableLayoutPanel10.Controls.Add(metroPanel6, 0, 5);
            tableLayoutPanel10.Controls.Add(metroPanel5, 0, 4);
            tableLayoutPanel10.Controls.Add(metroPanel4, 0, 3);
            tableLayoutPanel10.Controls.Add(metroPanel3, 0, 2);
            tableLayoutPanel10.Controls.Add(metroPanel2, 0, 1);
            tableLayoutPanel10.Controls.Add(metroPanel1, 0, 0);
            tableLayoutPanel10.Location = new Point(0, 70);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 7;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel10.Size = new Size(353, 277);
            tableLayoutPanel10.TabIndex = 10;
            // 
            // metroPanel7
            // 
            metroPanel7.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel7.Border = false;
            metroPanel7.BorderColor = Color.LimeGreen;
            metroPanel7.BorderSize = 0;
            metroPanel7.Controls.Add(LBLMoPVersion);
            metroPanel7.CustomBackground = false;
            metroPanel7.Dock = DockStyle.Fill;
            metroPanel7.HorizontalScrollbar = false;
            metroPanel7.HorizontalScrollbarBarColor = true;
            metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel7.HorizontalScrollbarSize = 10;
            metroPanel7.Location = new Point(3, 237);
            metroPanel7.Name = "metroPanel7";
            metroPanel7.Size = new Size(347, 37);
            metroPanel7.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel7.StyleManager = null;
            metroPanel7.TabIndex = 6;
            metroPanel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel7.VerticalScrollbar = false;
            metroPanel7.VerticalScrollbarBarColor = true;
            metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            metroPanel7.VerticalScrollbarSize = 10;
            // 
            // LBLMoPVersion
            // 
            LBLMoPVersion.Anchor = AnchorStyles.Left;
            LBLMoPVersion.AutoSize = true;
            LBLMoPVersion.ForeColor = Color.White;
            LBLMoPVersion.Location = new Point(5, 10);
            LBLMoPVersion.Name = "LBLMoPVersion";
            LBLMoPVersion.Size = new Size(46, 15);
            LBLMoPVersion.TabIndex = 47;
            LBLMoPVersion.Text = "Uptime";
            // 
            // metroPanel6
            // 
            metroPanel6.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel6.Border = false;
            metroPanel6.BorderColor = Color.LimeGreen;
            metroPanel6.BorderSize = 0;
            metroPanel6.Controls.Add(LBLCataVersion);
            metroPanel6.CustomBackground = false;
            metroPanel6.Dock = DockStyle.Fill;
            metroPanel6.HorizontalScrollbar = false;
            metroPanel6.HorizontalScrollbarBarColor = true;
            metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel6.HorizontalScrollbarSize = 10;
            metroPanel6.Location = new Point(3, 198);
            metroPanel6.Name = "metroPanel6";
            metroPanel6.Size = new Size(347, 33);
            metroPanel6.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel6.StyleManager = null;
            metroPanel6.TabIndex = 5;
            metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel6.VerticalScrollbar = false;
            metroPanel6.VerticalScrollbarBarColor = true;
            metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            metroPanel6.VerticalScrollbarSize = 10;
            // 
            // LBLCataVersion
            // 
            LBLCataVersion.Anchor = AnchorStyles.Left;
            LBLCataVersion.AutoSize = true;
            LBLCataVersion.ForeColor = Color.White;
            LBLCataVersion.Location = new Point(5, 10);
            LBLCataVersion.Name = "LBLCataVersion";
            LBLCataVersion.Size = new Size(46, 15);
            LBLCataVersion.TabIndex = 47;
            LBLCataVersion.Text = "Uptime";
            // 
            // metroPanel5
            // 
            metroPanel5.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel5.Border = false;
            metroPanel5.BorderColor = Color.LimeGreen;
            metroPanel5.BorderSize = 0;
            metroPanel5.Controls.Add(LBLWotLKVersion);
            metroPanel5.CustomBackground = false;
            metroPanel5.Dock = DockStyle.Fill;
            metroPanel5.HorizontalScrollbar = false;
            metroPanel5.HorizontalScrollbarBarColor = true;
            metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel5.HorizontalScrollbarSize = 10;
            metroPanel5.Location = new Point(3, 159);
            metroPanel5.Name = "metroPanel5";
            metroPanel5.Size = new Size(347, 33);
            metroPanel5.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel5.StyleManager = null;
            metroPanel5.TabIndex = 4;
            metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel5.VerticalScrollbar = false;
            metroPanel5.VerticalScrollbarBarColor = true;
            metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            metroPanel5.VerticalScrollbarSize = 10;
            // 
            // LBLWotLKVersion
            // 
            LBLWotLKVersion.Anchor = AnchorStyles.Left;
            LBLWotLKVersion.AutoSize = true;
            LBLWotLKVersion.ForeColor = Color.White;
            LBLWotLKVersion.Location = new Point(5, 10);
            LBLWotLKVersion.Name = "LBLWotLKVersion";
            LBLWotLKVersion.Size = new Size(46, 15);
            LBLWotLKVersion.TabIndex = 47;
            LBLWotLKVersion.Text = "Uptime";
            // 
            // metroPanel4
            // 
            metroPanel4.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel4.Border = false;
            metroPanel4.BorderColor = Color.LimeGreen;
            metroPanel4.BorderSize = 0;
            metroPanel4.Controls.Add(LBLTBCVersion);
            metroPanel4.CustomBackground = false;
            metroPanel4.Dock = DockStyle.Fill;
            metroPanel4.HorizontalScrollbar = false;
            metroPanel4.HorizontalScrollbarBarColor = true;
            metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel4.HorizontalScrollbarSize = 10;
            metroPanel4.Location = new Point(3, 120);
            metroPanel4.Name = "metroPanel4";
            metroPanel4.Size = new Size(347, 33);
            metroPanel4.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel4.StyleManager = null;
            metroPanel4.TabIndex = 3;
            metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel4.VerticalScrollbar = false;
            metroPanel4.VerticalScrollbarBarColor = true;
            metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            metroPanel4.VerticalScrollbarSize = 10;
            // 
            // LBLTBCVersion
            // 
            LBLTBCVersion.Anchor = AnchorStyles.Left;
            LBLTBCVersion.AutoSize = true;
            LBLTBCVersion.ForeColor = Color.White;
            LBLTBCVersion.Location = new Point(5, 10);
            LBLTBCVersion.Name = "LBLTBCVersion";
            LBLTBCVersion.Size = new Size(46, 15);
            LBLTBCVersion.TabIndex = 47;
            LBLTBCVersion.Text = "Uptime";
            // 
            // metroPanel3
            // 
            metroPanel3.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel3.Border = false;
            metroPanel3.BorderColor = Color.LimeGreen;
            metroPanel3.BorderSize = 0;
            metroPanel3.Controls.Add(LBLClassicVersion);
            metroPanel3.CustomBackground = false;
            metroPanel3.Dock = DockStyle.Fill;
            metroPanel3.HorizontalScrollbar = false;
            metroPanel3.HorizontalScrollbarBarColor = true;
            metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel3.HorizontalScrollbarSize = 10;
            metroPanel3.Location = new Point(3, 81);
            metroPanel3.Name = "metroPanel3";
            metroPanel3.Size = new Size(347, 33);
            metroPanel3.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel3.StyleManager = null;
            metroPanel3.TabIndex = 2;
            metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel3.VerticalScrollbar = false;
            metroPanel3.VerticalScrollbarBarColor = true;
            metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            metroPanel3.VerticalScrollbarSize = 10;
            // 
            // LBLClassicVersion
            // 
            LBLClassicVersion.Anchor = AnchorStyles.Left;
            LBLClassicVersion.AutoSize = true;
            LBLClassicVersion.ForeColor = Color.White;
            LBLClassicVersion.Location = new Point(5, 10);
            LBLClassicVersion.Name = "LBLClassicVersion";
            LBLClassicVersion.Size = new Size(46, 15);
            LBLClassicVersion.TabIndex = 47;
            LBLClassicVersion.Text = "Uptime";
            // 
            // metroPanel2
            // 
            metroPanel2.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel2.Border = false;
            metroPanel2.BorderColor = Color.LimeGreen;
            metroPanel2.BorderSize = 0;
            metroPanel2.Controls.Add(LBLDBVersion);
            metroPanel2.CustomBackground = false;
            metroPanel2.Dock = DockStyle.Fill;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(3, 42);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(347, 33);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 1;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // LBLDBVersion
            // 
            LBLDBVersion.Anchor = AnchorStyles.Left;
            LBLDBVersion.AutoSize = true;
            LBLDBVersion.ForeColor = Color.White;
            LBLDBVersion.Location = new Point(5, 10);
            LBLDBVersion.Name = "LBLDBVersion";
            LBLDBVersion.Size = new Size(46, 15);
            LBLDBVersion.TabIndex = 47;
            LBLDBVersion.Text = "Uptime";
            // 
            // metroPanel1
            // 
            metroPanel1.BackColor = Color.FromArgb(28, 33, 40);
            metroPanel1.Border = false;
            metroPanel1.BorderColor = Color.LimeGreen;
            metroPanel1.BorderSize = 0;
            metroPanel1.Controls.Add(LBLTrionVersion);
            metroPanel1.CustomBackground = false;
            metroPanel1.Dock = DockStyle.Fill;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(3, 3);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(347, 33);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 0;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LBLTrionVersion
            // 
            LBLTrionVersion.Anchor = AnchorStyles.Left;
            LBLTrionVersion.AutoSize = true;
            LBLTrionVersion.ForeColor = Color.White;
            LBLTrionVersion.Location = new Point(5, 10);
            LBLTrionVersion.Name = "LBLTrionVersion";
            LBLTrionVersion.Size = new Size(46, 15);
            LBLTrionVersion.TabIndex = 47;
            LBLTrionVersion.Text = "Uptime";
            // 
            // LBLCardUpdateDashboardInfo
            // 
            LBLCardUpdateDashboardInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardUpdateDashboardInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardUpdateDashboardInfo.Image = (Image)resources.GetObject("LBLCardUpdateDashboardInfo.Image");
            LBLCardUpdateDashboardInfo.Location = new Point(330, 10);
            LBLCardUpdateDashboardInfo.Name = "LBLCardUpdateDashboardInfo";
            LBLCardUpdateDashboardInfo.Size = new Size(16, 16);
            LBLCardUpdateDashboardInfo.TabIndex = 9;
            LBLCardUpdateDashboardInfo.TabStop = false;
            // 
            // LBLCardUpdateDashboardTitle
            // 
            LBLCardUpdateDashboardTitle.AutoSize = true;
            LBLCardUpdateDashboardTitle.Depth = 0;
            LBLCardUpdateDashboardTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardUpdateDashboardTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardUpdateDashboardTitle.HighEmphasis = true;
            LBLCardUpdateDashboardTitle.Location = new Point(10, 10);
            LBLCardUpdateDashboardTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardUpdateDashboardTitle.Name = "LBLCardUpdateDashboardTitle";
            LBLCardUpdateDashboardTitle.Size = new Size(65, 24);
            LBLCardUpdateDashboardTitle.TabIndex = 3;
            LBLCardUpdateDashboardTitle.Text = "Update";
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(TGLAutoUpdateDatabase);
            materialCard8.Controls.Add(TGLAutoUpdateCore);
            materialCard8.Controls.Add(TGLAutoUpdateTrion);
            materialCard8.Controls.Add(TGLStayInTray);
            materialCard8.Controls.Add(TGLNotificationSound);
            materialCard8.Controls.Add(TGLHideConsole);
            materialCard8.Controls.Add(TGLRunTrionStartup);
            materialCard8.Controls.Add(TGLServerStartup);
            materialCard8.Controls.Add(TGLServerCrashDetection);
            materialCard8.Depth = 0;
            materialCard8.Dock = DockStyle.Fill;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(4, 4);
            materialCard8.Margin = new Padding(4);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(4);
            materialCard8.Size = new Size(261, 347);
            materialCard8.TabIndex = 0;
            // 
            // TGLAutoUpdateDatabase
            // 
            TGLAutoUpdateDatabase.AutoSize = true;
            TGLAutoUpdateDatabase.Depth = 0;
            TGLAutoUpdateDatabase.Location = new Point(7, 310);
            TGLAutoUpdateDatabase.Margin = new Padding(0);
            TGLAutoUpdateDatabase.MouseLocation = new Point(-1, -1);
            TGLAutoUpdateDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            TGLAutoUpdateDatabase.Name = "TGLAutoUpdateDatabase";
            TGLAutoUpdateDatabase.Ripple = true;
            TGLAutoUpdateDatabase.Size = new Size(200, 37);
            TGLAutoUpdateDatabase.TabIndex = 8;
            TGLAutoUpdateDatabase.Text = "Auto update MySQL";
            TGLAutoUpdateDatabase.UseVisualStyleBackColor = true;
            // 
            // TGLAutoUpdateCore
            // 
            TGLAutoUpdateCore.AutoSize = true;
            TGLAutoUpdateCore.Depth = 0;
            TGLAutoUpdateCore.Location = new Point(7, 273);
            TGLAutoUpdateCore.Margin = new Padding(0);
            TGLAutoUpdateCore.MouseLocation = new Point(-1, -1);
            TGLAutoUpdateCore.MouseState = MaterialSkin.MouseState.HOVER;
            TGLAutoUpdateCore.Name = "TGLAutoUpdateCore";
            TGLAutoUpdateCore.Ripple = true;
            TGLAutoUpdateCore.Size = new Size(190, 37);
            TGLAutoUpdateCore.TabIndex = 7;
            TGLAutoUpdateCore.Text = "Auto update S.P.P.";
            TGLAutoUpdateCore.UseVisualStyleBackColor = true;
            // 
            // TGLAutoUpdateTrion
            // 
            TGLAutoUpdateTrion.AutoSize = true;
            TGLAutoUpdateTrion.Depth = 0;
            TGLAutoUpdateTrion.Location = new Point(7, 236);
            TGLAutoUpdateTrion.Margin = new Padding(0);
            TGLAutoUpdateTrion.MouseLocation = new Point(-1, -1);
            TGLAutoUpdateTrion.MouseState = MaterialSkin.MouseState.HOVER;
            TGLAutoUpdateTrion.Name = "TGLAutoUpdateTrion";
            TGLAutoUpdateTrion.Ripple = true;
            TGLAutoUpdateTrion.Size = new Size(185, 37);
            TGLAutoUpdateTrion.TabIndex = 6;
            TGLAutoUpdateTrion.Text = "Auto update Trion";
            TGLAutoUpdateTrion.UseVisualStyleBackColor = true;
            // 
            // TGLStayInTray
            // 
            TGLStayInTray.AutoSize = true;
            TGLStayInTray.Depth = 0;
            TGLStayInTray.Location = new Point(7, 199);
            TGLStayInTray.Margin = new Padding(0);
            TGLStayInTray.MouseLocation = new Point(-1, -1);
            TGLStayInTray.MouseState = MaterialSkin.MouseState.HOVER;
            TGLStayInTray.Name = "TGLStayInTray";
            TGLStayInTray.Ripple = true;
            TGLStayInTray.Size = new Size(208, 37);
            TGLStayInTray.TabIndex = 5;
            TGLStayInTray.Text = "Close to System Tray";
            TGLStayInTray.UseVisualStyleBackColor = true;
            // 
            // TGLNotificationSound
            // 
            TGLNotificationSound.AutoSize = true;
            TGLNotificationSound.Depth = 0;
            TGLNotificationSound.Location = new Point(7, 162);
            TGLNotificationSound.Margin = new Padding(0);
            TGLNotificationSound.MouseLocation = new Point(-1, -1);
            TGLNotificationSound.MouseState = MaterialSkin.MouseState.HOVER;
            TGLNotificationSound.Name = "TGLNotificationSound";
            TGLNotificationSound.Ripple = true;
            TGLNotificationSound.Size = new Size(197, 37);
            TGLNotificationSound.TabIndex = 4;
            TGLNotificationSound.Text = "Notification sounds";
            TGLNotificationSound.UseVisualStyleBackColor = true;
            // 
            // TGLHideConsole
            // 
            TGLHideConsole.AutoSize = true;
            TGLHideConsole.Depth = 0;
            TGLHideConsole.Location = new Point(7, 125);
            TGLHideConsole.Margin = new Padding(0);
            TGLHideConsole.MouseLocation = new Point(-1, -1);
            TGLHideConsole.MouseState = MaterialSkin.MouseState.HOVER;
            TGLHideConsole.Name = "TGLHideConsole";
            TGLHideConsole.Ripple = true;
            TGLHideConsole.Size = new Size(206, 37);
            TGLHideConsole.TabIndex = 3;
            TGLHideConsole.Text = "Hide server's console";
            TGLHideConsole.UseVisualStyleBackColor = true;
            // 
            // TGLRunTrionStartup
            // 
            TGLRunTrionStartup.AutoSize = true;
            TGLRunTrionStartup.Depth = 0;
            TGLRunTrionStartup.Location = new Point(7, 88);
            TGLRunTrionStartup.Margin = new Padding(0);
            TGLRunTrionStartup.MouseLocation = new Point(-1, -1);
            TGLRunTrionStartup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLRunTrionStartup.Name = "TGLRunTrionStartup";
            TGLRunTrionStartup.Ripple = true;
            TGLRunTrionStartup.Size = new Size(228, 37);
            TGLRunTrionStartup.TabIndex = 2;
            TGLRunTrionStartup.Text = "Launch Trion on startup";
            TGLRunTrionStartup.UseVisualStyleBackColor = true;
            // 
            // TGLServerStartup
            // 
            TGLServerStartup.AutoSize = true;
            TGLServerStartup.Depth = 0;
            TGLServerStartup.Location = new Point(7, 51);
            TGLServerStartup.Margin = new Padding(0);
            TGLServerStartup.MouseLocation = new Point(-1, -1);
            TGLServerStartup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLServerStartup.Name = "TGLServerStartup";
            TGLServerStartup.Ripple = true;
            TGLServerStartup.Size = new Size(244, 37);
            TGLServerStartup.TabIndex = 1;
            TGLServerStartup.Text = "Launch server's on startup";
            TGLServerStartup.UseVisualStyleBackColor = true;
            // 
            // TGLServerCrashDetection
            // 
            TGLServerCrashDetection.AutoSize = true;
            TGLServerCrashDetection.Depth = 0;
            TGLServerCrashDetection.Location = new Point(7, 14);
            TGLServerCrashDetection.Margin = new Padding(0);
            TGLServerCrashDetection.MouseLocation = new Point(-1, -1);
            TGLServerCrashDetection.MouseState = MaterialSkin.MouseState.HOVER;
            TGLServerCrashDetection.Name = "TGLServerCrashDetection";
            TGLServerCrashDetection.Ripple = true;
            TGLServerCrashDetection.Size = new Size(214, 37);
            TGLServerCrashDetection.TabIndex = 0;
            TGLServerCrashDetection.Text = "Server crash detection";
            TGLServerCrashDetection.UseVisualStyleBackColor = true;
            // 
            // TabCustom
            // 
            TabCustom.BackColor = Color.White;
            TabCustom.Controls.Add(tableLayoutPanel5);
            TabCustom.Location = new Point(27, 4);
            TabCustom.Name = "TabCustom";
            TabCustom.Size = new Size(905, 361);
            TabCustom.TabIndex = 3;
            TabCustom.Text = "Custom Repack";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(TXTCustomDatabaseLocation, 0, 0);
            tableLayoutPanel5.Controls.Add(TXTCustomRepackLocation, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(905, 361);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // TXTCustomDatabaseLocation
            // 
            TXTCustomDatabaseLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCustomDatabaseLocation.AnimateReadOnly = true;
            TXTCustomDatabaseLocation.AutoCompleteMode = AutoCompleteMode.None;
            TXTCustomDatabaseLocation.AutoCompleteSource = AutoCompleteSource.None;
            TXTCustomDatabaseLocation.BackgroundImageLayout = ImageLayout.None;
            TXTCustomDatabaseLocation.CharacterCasing = CharacterCasing.Normal;
            TXTCustomDatabaseLocation.Depth = 0;
            TXTCustomDatabaseLocation.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCustomDatabaseLocation.HideSelection = true;
            TXTCustomDatabaseLocation.Hint = "ID";
            TXTCustomDatabaseLocation.LeadingIcon = null;
            TXTCustomDatabaseLocation.Location = new Point(3, 3);
            TXTCustomDatabaseLocation.MaxLength = 32767;
            TXTCustomDatabaseLocation.MouseState = MaterialSkin.MouseState.OUT;
            TXTCustomDatabaseLocation.Name = "TXTCustomDatabaseLocation";
            TXTCustomDatabaseLocation.PasswordChar = '\0';
            TXTCustomDatabaseLocation.PrefixSuffixText = null;
            TXTCustomDatabaseLocation.ReadOnly = true;
            TXTCustomDatabaseLocation.RightToLeft = RightToLeft.No;
            TXTCustomDatabaseLocation.SelectedText = "";
            TXTCustomDatabaseLocation.SelectionLength = 0;
            TXTCustomDatabaseLocation.SelectionStart = 0;
            TXTCustomDatabaseLocation.ShortcutsEnabled = true;
            TXTCustomDatabaseLocation.Size = new Size(899, 48);
            TXTCustomDatabaseLocation.TabIndex = 9;
            TXTCustomDatabaseLocation.TabStop = false;
            TXTCustomDatabaseLocation.TextAlign = HorizontalAlignment.Left;
            TXTCustomDatabaseLocation.TrailingIcon = (Image)resources.GetObject("TXTCustomDatabaseLocation.TrailingIcon");
            TXTCustomDatabaseLocation.UseSystemPasswordChar = false;
            // 
            // TXTCustomRepackLocation
            // 
            TXTCustomRepackLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCustomRepackLocation.AnimateReadOnly = true;
            TXTCustomRepackLocation.AutoCompleteMode = AutoCompleteMode.None;
            TXTCustomRepackLocation.AutoCompleteSource = AutoCompleteSource.None;
            TXTCustomRepackLocation.BackgroundImageLayout = ImageLayout.None;
            TXTCustomRepackLocation.CharacterCasing = CharacterCasing.Normal;
            TXTCustomRepackLocation.Depth = 0;
            TXTCustomRepackLocation.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCustomRepackLocation.HideSelection = true;
            TXTCustomRepackLocation.Hint = "ID";
            TXTCustomRepackLocation.LeadingIcon = null;
            TXTCustomRepackLocation.Location = new Point(3, 53);
            TXTCustomRepackLocation.MaxLength = 32767;
            TXTCustomRepackLocation.MouseState = MaterialSkin.MouseState.OUT;
            TXTCustomRepackLocation.Name = "TXTCustomRepackLocation";
            TXTCustomRepackLocation.PasswordChar = '\0';
            TXTCustomRepackLocation.PrefixSuffixText = null;
            TXTCustomRepackLocation.ReadOnly = true;
            TXTCustomRepackLocation.RightToLeft = RightToLeft.No;
            TXTCustomRepackLocation.SelectedText = "";
            TXTCustomRepackLocation.SelectionLength = 0;
            TXTCustomRepackLocation.SelectionStart = 0;
            TXTCustomRepackLocation.ShortcutsEnabled = true;
            TXTCustomRepackLocation.Size = new Size(899, 48);
            TXTCustomRepackLocation.TabIndex = 8;
            TXTCustomRepackLocation.TabStop = false;
            TXTCustomRepackLocation.TextAlign = HorizontalAlignment.Left;
            TXTCustomRepackLocation.TrailingIcon = (Image)resources.GetObject("TXTCustomRepackLocation.TrailingIcon");
            TXTCustomRepackLocation.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel7.Controls.Add(materialCard11, 2, 0);
            tableLayoutPanel7.Controls.Add(materialCard10, 1, 0);
            tableLayoutPanel7.Controls.Add(materialCard9, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 103);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(899, 255);
            tableLayoutPanel7.TabIndex = 10;
            // 
            // materialCard11
            // 
            materialCard11.BackColor = Color.FromArgb(255, 255, 255);
            materialCard11.Controls.Add(BTNAscEmuWebsite);
            materialCard11.Controls.Add(BTNSkyFireWebsite);
            materialCard11.Controls.Add(BTNTrinityCoreWebsite);
            materialCard11.Controls.Add(BTNCypherWebsite);
            materialCard11.Controls.Add(BTNCMangosWebsite);
            materialCard11.Controls.Add(BTNACoreWebsite);
            materialCard11.Depth = 0;
            materialCard11.Dock = DockStyle.Fill;
            materialCard11.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard11.Location = new Point(602, 4);
            materialCard11.Margin = new Padding(4);
            materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard11.Name = "materialCard11";
            materialCard11.Padding = new Padding(14);
            materialCard11.Size = new Size(293, 247);
            materialCard11.TabIndex = 2;
            // 
            // BTNAscEmuWebsite
            // 
            BTNAscEmuWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNAscEmuWebsite.AutoSize = false;
            BTNAscEmuWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNAscEmuWebsite.Cursor = Cursors.Hand;
            BTNAscEmuWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNAscEmuWebsite.Depth = 0;
            BTNAscEmuWebsite.HighEmphasis = true;
            BTNAscEmuWebsite.Icon = (Image)resources.GetObject("BTNAscEmuWebsite.Icon");
            BTNAscEmuWebsite.Location = new Point(8, 6);
            BTNAscEmuWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNAscEmuWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNAscEmuWebsite.Name = "BTNAscEmuWebsite";
            BTNAscEmuWebsite.NoAccentTextColor = Color.Empty;
            BTNAscEmuWebsite.Size = new Size(278, 36);
            BTNAscEmuWebsite.TabIndex = 15;
            BTNAscEmuWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNAscEmuWebsite.UseAccentColor = false;
            BTNAscEmuWebsite.UseVisualStyleBackColor = true;
            // 
            // BTNSkyFireWebsite
            // 
            BTNSkyFireWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNSkyFireWebsite.AutoSize = false;
            BTNSkyFireWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNSkyFireWebsite.Cursor = Cursors.Hand;
            BTNSkyFireWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNSkyFireWebsite.Depth = 0;
            BTNSkyFireWebsite.HighEmphasis = true;
            BTNSkyFireWebsite.Icon = (Image)resources.GetObject("BTNSkyFireWebsite.Icon");
            BTNSkyFireWebsite.Location = new Point(8, 209);
            BTNSkyFireWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNSkyFireWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNSkyFireWebsite.Name = "BTNSkyFireWebsite";
            BTNSkyFireWebsite.NoAccentTextColor = Color.Empty;
            BTNSkyFireWebsite.Size = new Size(278, 36);
            BTNSkyFireWebsite.TabIndex = 14;
            BTNSkyFireWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNSkyFireWebsite.UseAccentColor = false;
            BTNSkyFireWebsite.UseVisualStyleBackColor = true;
            // 
            // BTNTrinityCoreWebsite
            // 
            BTNTrinityCoreWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNTrinityCoreWebsite.AutoSize = false;
            BTNTrinityCoreWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNTrinityCoreWebsite.Cursor = Cursors.Hand;
            BTNTrinityCoreWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNTrinityCoreWebsite.Depth = 0;
            BTNTrinityCoreWebsite.HighEmphasis = true;
            BTNTrinityCoreWebsite.Icon = (Image)resources.GetObject("BTNTrinityCoreWebsite.Icon");
            BTNTrinityCoreWebsite.Location = new Point(8, 168);
            BTNTrinityCoreWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNTrinityCoreWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNTrinityCoreWebsite.Name = "BTNTrinityCoreWebsite";
            BTNTrinityCoreWebsite.NoAccentTextColor = Color.Empty;
            BTNTrinityCoreWebsite.Size = new Size(278, 36);
            BTNTrinityCoreWebsite.TabIndex = 13;
            BTNTrinityCoreWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNTrinityCoreWebsite.UseAccentColor = false;
            BTNTrinityCoreWebsite.UseVisualStyleBackColor = true;
            // 
            // BTNCypherWebsite
            // 
            BTNCypherWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNCypherWebsite.AutoSize = false;
            BTNCypherWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNCypherWebsite.Cursor = Cursors.Hand;
            BTNCypherWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNCypherWebsite.Depth = 0;
            BTNCypherWebsite.HighEmphasis = true;
            BTNCypherWebsite.Icon = (Image)resources.GetObject("BTNCypherWebsite.Icon");
            BTNCypherWebsite.Location = new Point(8, 127);
            BTNCypherWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNCypherWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNCypherWebsite.Name = "BTNCypherWebsite";
            BTNCypherWebsite.NoAccentTextColor = Color.Empty;
            BTNCypherWebsite.Size = new Size(278, 36);
            BTNCypherWebsite.TabIndex = 12;
            BTNCypherWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNCypherWebsite.UseAccentColor = false;
            BTNCypherWebsite.UseVisualStyleBackColor = true;
            // 
            // BTNCMangosWebsite
            // 
            BTNCMangosWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNCMangosWebsite.AutoSize = false;
            BTNCMangosWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNCMangosWebsite.Cursor = Cursors.Hand;
            BTNCMangosWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNCMangosWebsite.Depth = 0;
            BTNCMangosWebsite.HighEmphasis = true;
            BTNCMangosWebsite.Icon = (Image)resources.GetObject("BTNCMangosWebsite.Icon");
            BTNCMangosWebsite.Location = new Point(8, 86);
            BTNCMangosWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNCMangosWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNCMangosWebsite.Name = "BTNCMangosWebsite";
            BTNCMangosWebsite.NoAccentTextColor = Color.Empty;
            BTNCMangosWebsite.Size = new Size(278, 36);
            BTNCMangosWebsite.TabIndex = 11;
            BTNCMangosWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNCMangosWebsite.UseAccentColor = false;
            BTNCMangosWebsite.UseVisualStyleBackColor = true;
            // 
            // BTNACoreWebsite
            // 
            BTNACoreWebsite.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNACoreWebsite.AutoSize = false;
            BTNACoreWebsite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNACoreWebsite.Cursor = Cursors.Hand;
            BTNACoreWebsite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNACoreWebsite.Depth = 0;
            BTNACoreWebsite.HighEmphasis = true;
            BTNACoreWebsite.Icon = (Image)resources.GetObject("BTNACoreWebsite.Icon");
            BTNACoreWebsite.Location = new Point(8, 46);
            BTNACoreWebsite.Margin = new Padding(4, 6, 4, 6);
            BTNACoreWebsite.MouseState = MaterialSkin.MouseState.HOVER;
            BTNACoreWebsite.Name = "BTNACoreWebsite";
            BTNACoreWebsite.NoAccentTextColor = Color.Empty;
            BTNACoreWebsite.Size = new Size(278, 36);
            BTNACoreWebsite.TabIndex = 10;
            BTNACoreWebsite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNACoreWebsite.UseAccentColor = false;
            BTNACoreWebsite.UseVisualStyleBackColor = true;
            // 
            // materialCard10
            // 
            materialCard10.BackColor = Color.FromArgb(255, 255, 255);
            materialCard10.Controls.Add(TGLCustomNames);
            materialCard10.Controls.Add(LBLCardCustomNamesInfo);
            materialCard10.Controls.Add(TXTCustomDatabaseName);
            materialCard10.Controls.Add(TXTCustomWorldName);
            materialCard10.Controls.Add(TXTCustomAuthName);
            materialCard10.Controls.Add(LBLCardCustomNamesTitle);
            materialCard10.Depth = 0;
            materialCard10.Dock = DockStyle.Fill;
            materialCard10.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard10.Location = new Point(303, 4);
            materialCard10.Margin = new Padding(4);
            materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard10.Name = "materialCard10";
            materialCard10.Padding = new Padding(14);
            materialCard10.Size = new Size(291, 247);
            materialCard10.TabIndex = 1;
            // 
            // TGLCustomNames
            // 
            TGLCustomNames.AutoSize = true;
            TGLCustomNames.Depth = 0;
            TGLCustomNames.Location = new Point(14, 214);
            TGLCustomNames.Margin = new Padding(0);
            TGLCustomNames.MouseLocation = new Point(-1, -1);
            TGLCustomNames.MouseState = MaterialSkin.MouseState.HOVER;
            TGLCustomNames.Name = "TGLCustomNames";
            TGLCustomNames.Ripple = true;
            TGLCustomNames.Size = new Size(80, 37);
            TGLCustomNames.TabIndex = 20;
            TGLCustomNames.Text = "tbc";
            TGLCustomNames.UseVisualStyleBackColor = true;
            // 
            // LBLCardCustomNamesInfo
            // 
            LBLCardCustomNamesInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardCustomNamesInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardCustomNamesInfo.Image = (Image)resources.GetObject("LBLCardCustomNamesInfo.Image");
            LBLCardCustomNamesInfo.Location = new Point(265, 10);
            LBLCardCustomNamesInfo.Name = "LBLCardCustomNamesInfo";
            LBLCardCustomNamesInfo.Size = new Size(16, 16);
            LBLCardCustomNamesInfo.TabIndex = 13;
            LBLCardCustomNamesInfo.TabStop = false;
            // 
            // TXTCustomDatabaseName
            // 
            TXTCustomDatabaseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCustomDatabaseName.AnimateReadOnly = true;
            TXTCustomDatabaseName.AutoCompleteMode = AutoCompleteMode.None;
            TXTCustomDatabaseName.AutoCompleteSource = AutoCompleteSource.None;
            TXTCustomDatabaseName.BackgroundImageLayout = ImageLayout.None;
            TXTCustomDatabaseName.CharacterCasing = CharacterCasing.Normal;
            TXTCustomDatabaseName.Depth = 0;
            TXTCustomDatabaseName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCustomDatabaseName.HideSelection = true;
            TXTCustomDatabaseName.Hint = "ID";
            TXTCustomDatabaseName.LeadingIcon = null;
            TXTCustomDatabaseName.Location = new Point(10, 163);
            TXTCustomDatabaseName.MaxLength = 32767;
            TXTCustomDatabaseName.MouseState = MaterialSkin.MouseState.OUT;
            TXTCustomDatabaseName.Name = "TXTCustomDatabaseName";
            TXTCustomDatabaseName.PasswordChar = '\0';
            TXTCustomDatabaseName.PrefixSuffixText = null;
            TXTCustomDatabaseName.ReadOnly = true;
            TXTCustomDatabaseName.RightToLeft = RightToLeft.No;
            TXTCustomDatabaseName.SelectedText = "";
            TXTCustomDatabaseName.SelectionLength = 0;
            TXTCustomDatabaseName.SelectionStart = 0;
            TXTCustomDatabaseName.ShortcutsEnabled = true;
            TXTCustomDatabaseName.Size = new Size(274, 48);
            TXTCustomDatabaseName.TabIndex = 12;
            TXTCustomDatabaseName.TabStop = false;
            TXTCustomDatabaseName.TextAlign = HorizontalAlignment.Left;
            TXTCustomDatabaseName.TrailingIcon = (Image)resources.GetObject("TXTCustomDatabaseName.TrailingIcon");
            TXTCustomDatabaseName.UseSystemPasswordChar = false;
            // 
            // TXTCustomWorldName
            // 
            TXTCustomWorldName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCustomWorldName.AnimateReadOnly = true;
            TXTCustomWorldName.AutoCompleteMode = AutoCompleteMode.None;
            TXTCustomWorldName.AutoCompleteSource = AutoCompleteSource.None;
            TXTCustomWorldName.BackgroundImageLayout = ImageLayout.None;
            TXTCustomWorldName.CharacterCasing = CharacterCasing.Normal;
            TXTCustomWorldName.Depth = 0;
            TXTCustomWorldName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCustomWorldName.HideSelection = true;
            TXTCustomWorldName.Hint = "ID";
            TXTCustomWorldName.LeadingIcon = null;
            TXTCustomWorldName.Location = new Point(10, 109);
            TXTCustomWorldName.MaxLength = 32767;
            TXTCustomWorldName.MouseState = MaterialSkin.MouseState.OUT;
            TXTCustomWorldName.Name = "TXTCustomWorldName";
            TXTCustomWorldName.PasswordChar = '\0';
            TXTCustomWorldName.PrefixSuffixText = null;
            TXTCustomWorldName.ReadOnly = true;
            TXTCustomWorldName.RightToLeft = RightToLeft.No;
            TXTCustomWorldName.SelectedText = "";
            TXTCustomWorldName.SelectionLength = 0;
            TXTCustomWorldName.SelectionStart = 0;
            TXTCustomWorldName.ShortcutsEnabled = true;
            TXTCustomWorldName.Size = new Size(274, 48);
            TXTCustomWorldName.TabIndex = 11;
            TXTCustomWorldName.TabStop = false;
            TXTCustomWorldName.TextAlign = HorizontalAlignment.Left;
            TXTCustomWorldName.TrailingIcon = (Image)resources.GetObject("TXTCustomWorldName.TrailingIcon");
            TXTCustomWorldName.UseSystemPasswordChar = false;
            // 
            // TXTCustomAuthName
            // 
            TXTCustomAuthName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCustomAuthName.AnimateReadOnly = true;
            TXTCustomAuthName.AutoCompleteMode = AutoCompleteMode.None;
            TXTCustomAuthName.AutoCompleteSource = AutoCompleteSource.None;
            TXTCustomAuthName.BackgroundImageLayout = ImageLayout.None;
            TXTCustomAuthName.CharacterCasing = CharacterCasing.Normal;
            TXTCustomAuthName.Depth = 0;
            TXTCustomAuthName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCustomAuthName.HideSelection = true;
            TXTCustomAuthName.Hint = "ID";
            TXTCustomAuthName.LeadingIcon = null;
            TXTCustomAuthName.Location = new Point(10, 55);
            TXTCustomAuthName.MaxLength = 32767;
            TXTCustomAuthName.MouseState = MaterialSkin.MouseState.OUT;
            TXTCustomAuthName.Name = "TXTCustomAuthName";
            TXTCustomAuthName.PasswordChar = '\0';
            TXTCustomAuthName.PrefixSuffixText = null;
            TXTCustomAuthName.ReadOnly = true;
            TXTCustomAuthName.RightToLeft = RightToLeft.No;
            TXTCustomAuthName.SelectedText = "";
            TXTCustomAuthName.SelectionLength = 0;
            TXTCustomAuthName.SelectionStart = 0;
            TXTCustomAuthName.ShortcutsEnabled = true;
            TXTCustomAuthName.Size = new Size(274, 48);
            TXTCustomAuthName.TabIndex = 10;
            TXTCustomAuthName.TabStop = false;
            TXTCustomAuthName.TextAlign = HorizontalAlignment.Left;
            TXTCustomAuthName.TrailingIcon = (Image)resources.GetObject("TXTCustomAuthName.TrailingIcon");
            TXTCustomAuthName.UseSystemPasswordChar = false;
            // 
            // LBLCardCustomNamesTitle
            // 
            LBLCardCustomNamesTitle.AutoSize = true;
            LBLCardCustomNamesTitle.Depth = 0;
            LBLCardCustomNamesTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardCustomNamesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardCustomNamesTitle.HighEmphasis = true;
            LBLCardCustomNamesTitle.Location = new Point(10, 10);
            LBLCardCustomNamesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardCustomNamesTitle.Name = "LBLCardCustomNamesTitle";
            LBLCardCustomNamesTitle.Size = new Size(65, 24);
            LBLCardCustomNamesTitle.TabIndex = 9;
            LBLCardCustomNamesTitle.Text = "Update";
            // 
            // materialCard9
            // 
            materialCard9.BackColor = Color.FromArgb(255, 255, 255);
            materialCard9.Controls.Add(TGLUseCustomServer);
            materialCard9.Controls.Add(LBLCardCustomEmulatorInfo);
            materialCard9.Controls.Add(BTNEmulatorLocation);
            materialCard9.Controls.Add(BTNDatabaseLocation);
            materialCard9.Controls.Add(CBOXSelectedEmulators);
            materialCard9.Controls.Add(LBLCardCustomEmulatorTitle);
            materialCard9.Depth = 0;
            materialCard9.Dock = DockStyle.Fill;
            materialCard9.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard9.Location = new Point(4, 4);
            materialCard9.Margin = new Padding(4);
            materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard9.Name = "materialCard9";
            materialCard9.Padding = new Padding(14);
            materialCard9.Size = new Size(291, 247);
            materialCard9.TabIndex = 0;
            // 
            // TGLUseCustomServer
            // 
            TGLUseCustomServer.AutoSize = true;
            TGLUseCustomServer.Depth = 0;
            TGLUseCustomServer.Location = new Point(10, 196);
            TGLUseCustomServer.Margin = new Padding(0);
            TGLUseCustomServer.MouseLocation = new Point(-1, -1);
            TGLUseCustomServer.MouseState = MaterialSkin.MouseState.HOVER;
            TGLUseCustomServer.Name = "TGLUseCustomServer";
            TGLUseCustomServer.Ripple = true;
            TGLUseCustomServer.Size = new Size(107, 37);
            TGLUseCustomServer.TabIndex = 19;
            TGLUseCustomServer.Text = "classic";
            TGLUseCustomServer.UseVisualStyleBackColor = false;
            // 
            // LBLCardCustomEmulatorInfo
            // 
            LBLCardCustomEmulatorInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardCustomEmulatorInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardCustomEmulatorInfo.Image = (Image)resources.GetObject("LBLCardCustomEmulatorInfo.Image");
            LBLCardCustomEmulatorInfo.Location = new Point(265, 10);
            LBLCardCustomEmulatorInfo.Name = "LBLCardCustomEmulatorInfo";
            LBLCardCustomEmulatorInfo.Size = new Size(16, 16);
            LBLCardCustomEmulatorInfo.TabIndex = 18;
            LBLCardCustomEmulatorInfo.TabStop = false;
            // 
            // BTNEmulatorLocation
            // 
            BTNEmulatorLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNEmulatorLocation.AutoSize = false;
            BTNEmulatorLocation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNEmulatorLocation.Cursor = Cursors.Hand;
            BTNEmulatorLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNEmulatorLocation.Depth = 0;
            BTNEmulatorLocation.HighEmphasis = true;
            BTNEmulatorLocation.Icon = (Image)resources.GetObject("BTNEmulatorLocation.Icon");
            BTNEmulatorLocation.Location = new Point(6, 109);
            BTNEmulatorLocation.Margin = new Padding(4, 6, 4, 6);
            BTNEmulatorLocation.MouseState = MaterialSkin.MouseState.HOVER;
            BTNEmulatorLocation.Name = "BTNEmulatorLocation";
            BTNEmulatorLocation.NoAccentTextColor = Color.Empty;
            BTNEmulatorLocation.Size = new Size(275, 36);
            BTNEmulatorLocation.TabIndex = 17;
            BTNEmulatorLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNEmulatorLocation.UseAccentColor = false;
            BTNEmulatorLocation.UseVisualStyleBackColor = true;
            // 
            // BTNDatabaseLocation
            // 
            BTNDatabaseLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDatabaseLocation.AutoSize = false;
            BTNDatabaseLocation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDatabaseLocation.Cursor = Cursors.Hand;
            BTNDatabaseLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDatabaseLocation.Depth = 0;
            BTNDatabaseLocation.HighEmphasis = true;
            BTNDatabaseLocation.Icon = (Image)resources.GetObject("BTNDatabaseLocation.Icon");
            BTNDatabaseLocation.Location = new Point(6, 149);
            BTNDatabaseLocation.Margin = new Padding(4, 6, 4, 6);
            BTNDatabaseLocation.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDatabaseLocation.Name = "BTNDatabaseLocation";
            BTNDatabaseLocation.NoAccentTextColor = Color.Empty;
            BTNDatabaseLocation.Size = new Size(275, 36);
            BTNDatabaseLocation.TabIndex = 16;
            BTNDatabaseLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDatabaseLocation.UseAccentColor = false;
            BTNDatabaseLocation.UseVisualStyleBackColor = true;
            // 
            // CBOXSelectedEmulators
            // 
            CBOXSelectedEmulators.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBOXSelectedEmulators.AutoResize = false;
            CBOXSelectedEmulators.BackColor = Color.FromArgb(255, 255, 255);
            CBOXSelectedEmulators.Depth = 0;
            CBOXSelectedEmulators.DrawMode = DrawMode.OwnerDrawVariable;
            CBOXSelectedEmulators.DropDownHeight = 174;
            CBOXSelectedEmulators.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOXSelectedEmulators.DropDownWidth = 121;
            CBOXSelectedEmulators.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBOXSelectedEmulators.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBOXSelectedEmulators.FormattingEnabled = true;
            CBOXSelectedEmulators.Hint = "ID";
            CBOXSelectedEmulators.IntegralHeight = false;
            CBOXSelectedEmulators.ItemHeight = 43;
            CBOXSelectedEmulators.Items.AddRange(new object[] { "AscEmu", "AzerothCore", "CMaNGOS", "CypherCore", "TrinityCore", "CypherCore", "TrinityCore Classic", "VMaNGOS" });
            CBOXSelectedEmulators.Location = new Point(6, 55);
            CBOXSelectedEmulators.MaxDropDownItems = 4;
            CBOXSelectedEmulators.MouseState = MaterialSkin.MouseState.OUT;
            CBOXSelectedEmulators.Name = "CBOXSelectedEmulators";
            CBOXSelectedEmulators.Size = new Size(275, 49);
            CBOXSelectedEmulators.StartIndex = 0;
            CBOXSelectedEmulators.TabIndex = 9;
            // 
            // LBLCardCustomEmulatorTitle
            // 
            LBLCardCustomEmulatorTitle.AutoSize = true;
            LBLCardCustomEmulatorTitle.Depth = 0;
            LBLCardCustomEmulatorTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardCustomEmulatorTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardCustomEmulatorTitle.HighEmphasis = true;
            LBLCardCustomEmulatorTitle.Location = new Point(10, 10);
            LBLCardCustomEmulatorTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardCustomEmulatorTitle.Name = "LBLCardCustomEmulatorTitle";
            LBLCardCustomEmulatorTitle.Size = new Size(65, 24);
            LBLCardCustomEmulatorTitle.TabIndex = 8;
            LBLCardCustomEmulatorTitle.Text = "Update";
            // 
            // TabDatabase
            // 
            TabDatabase.BackColor = Color.White;
            TabDatabase.Controls.Add(tableLayoutPanel8);
            TabDatabase.Location = new Point(27, 4);
            TabDatabase.Name = "TabDatabase";
            TabDatabase.Size = new Size(905, 361);
            TabDatabase.TabIndex = 4;
            TabDatabase.Text = "Database";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(materialCard18, 3, 0);
            tableLayoutPanel8.Controls.Add(materialCard17, 2, 0);
            tableLayoutPanel8.Controls.Add(materialCard16, 1, 0);
            tableLayoutPanel8.Controls.Add(materialCard15, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(905, 361);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // materialCard18
            // 
            materialCard18.BackColor = Color.FromArgb(255, 255, 255);
            materialCard18.Controls.Add(BTNFixDatabase);
            materialCard18.Controls.Add(BTNLoadBackup);
            materialCard18.Controls.Add(BTNDatabaseBackup);
            materialCard18.Controls.Add(TGLWorldBackup);
            materialCard18.Controls.Add(TGLCharBackup);
            materialCard18.Controls.Add(TGLAuthBackup);
            materialCard18.Controls.Add(LBLCardDatabaseBCInfo);
            materialCard18.Controls.Add(LBLCardDatabaseBCTitle);
            materialCard18.Depth = 0;
            materialCard18.Dock = DockStyle.Fill;
            materialCard18.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard18.Location = new Point(682, 4);
            materialCard18.Margin = new Padding(4);
            materialCard18.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard18.Name = "materialCard18";
            materialCard18.Padding = new Padding(14);
            materialCard18.Size = new Size(219, 353);
            materialCard18.TabIndex = 3;
            // 
            // BTNFixDatabase
            // 
            BTNFixDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNFixDatabase.AutoSize = false;
            BTNFixDatabase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNFixDatabase.Cursor = Cursors.Hand;
            BTNFixDatabase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNFixDatabase.Depth = 0;
            BTNFixDatabase.HighEmphasis = true;
            BTNFixDatabase.Icon = (Image)resources.GetObject("BTNFixDatabase.Icon");
            BTNFixDatabase.Location = new Point(7, 271);
            BTNFixDatabase.Margin = new Padding(4, 6, 4, 6);
            BTNFixDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            BTNFixDatabase.Name = "BTNFixDatabase";
            BTNFixDatabase.NoAccentTextColor = Color.Empty;
            BTNFixDatabase.Size = new Size(205, 36);
            BTNFixDatabase.TabIndex = 22;
            BTNFixDatabase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNFixDatabase.UseAccentColor = false;
            BTNFixDatabase.UseVisualStyleBackColor = true;
            // 
            // BTNLoadBackup
            // 
            BTNLoadBackup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNLoadBackup.AutoSize = false;
            BTNLoadBackup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNLoadBackup.Cursor = Cursors.Hand;
            BTNLoadBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNLoadBackup.Depth = 0;
            BTNLoadBackup.HighEmphasis = true;
            BTNLoadBackup.Icon = (Image)resources.GetObject("BTNLoadBackup.Icon");
            BTNLoadBackup.Location = new Point(7, 229);
            BTNLoadBackup.Margin = new Padding(4, 6, 4, 6);
            BTNLoadBackup.MouseState = MaterialSkin.MouseState.HOVER;
            BTNLoadBackup.Name = "BTNLoadBackup";
            BTNLoadBackup.NoAccentTextColor = Color.Empty;
            BTNLoadBackup.Size = new Size(205, 36);
            BTNLoadBackup.TabIndex = 21;
            BTNLoadBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNLoadBackup.UseAccentColor = false;
            BTNLoadBackup.UseVisualStyleBackColor = true;
            // 
            // BTNDatabaseBackup
            // 
            BTNDatabaseBackup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDatabaseBackup.AutoSize = false;
            BTNDatabaseBackup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDatabaseBackup.Cursor = Cursors.Hand;
            BTNDatabaseBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDatabaseBackup.Depth = 0;
            BTNDatabaseBackup.HighEmphasis = true;
            BTNDatabaseBackup.Icon = (Image)resources.GetObject("BTNDatabaseBackup.Icon");
            BTNDatabaseBackup.Location = new Point(7, 187);
            BTNDatabaseBackup.Margin = new Padding(4, 6, 4, 6);
            BTNDatabaseBackup.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDatabaseBackup.Name = "BTNDatabaseBackup";
            BTNDatabaseBackup.NoAccentTextColor = Color.Empty;
            BTNDatabaseBackup.Size = new Size(205, 36);
            BTNDatabaseBackup.TabIndex = 20;
            BTNDatabaseBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDatabaseBackup.UseAccentColor = false;
            BTNDatabaseBackup.UseVisualStyleBackColor = true;
            // 
            // TGLWorldBackup
            // 
            TGLWorldBackup.AutoSize = true;
            TGLWorldBackup.Depth = 0;
            TGLWorldBackup.Location = new Point(0, 144);
            TGLWorldBackup.Margin = new Padding(0);
            TGLWorldBackup.MouseLocation = new Point(-1, -1);
            TGLWorldBackup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLWorldBackup.Name = "TGLWorldBackup";
            TGLWorldBackup.Ripple = true;
            TGLWorldBackup.Size = new Size(228, 37);
            TGLWorldBackup.TabIndex = 17;
            TGLWorldBackup.Text = "Launch Trion on startup";
            TGLWorldBackup.UseVisualStyleBackColor = true;
            // 
            // TGLCharBackup
            // 
            TGLCharBackup.AutoSize = true;
            TGLCharBackup.Depth = 0;
            TGLCharBackup.Location = new Point(0, 107);
            TGLCharBackup.Margin = new Padding(0);
            TGLCharBackup.MouseLocation = new Point(-1, -1);
            TGLCharBackup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLCharBackup.Name = "TGLCharBackup";
            TGLCharBackup.Ripple = true;
            TGLCharBackup.Size = new Size(244, 37);
            TGLCharBackup.TabIndex = 16;
            TGLCharBackup.Text = "Launch server's on startup";
            TGLCharBackup.UseVisualStyleBackColor = true;
            // 
            // TGLAuthBackup
            // 
            TGLAuthBackup.AutoSize = true;
            TGLAuthBackup.Depth = 0;
            TGLAuthBackup.Location = new Point(0, 70);
            TGLAuthBackup.Margin = new Padding(0);
            TGLAuthBackup.MouseLocation = new Point(-1, -1);
            TGLAuthBackup.MouseState = MaterialSkin.MouseState.HOVER;
            TGLAuthBackup.Name = "TGLAuthBackup";
            TGLAuthBackup.Ripple = true;
            TGLAuthBackup.Size = new Size(214, 37);
            TGLAuthBackup.TabIndex = 15;
            TGLAuthBackup.Text = "Server crash detection";
            TGLAuthBackup.UseVisualStyleBackColor = true;
            // 
            // LBLCardDatabaseBCInfo
            // 
            LBLCardDatabaseBCInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardDatabaseBCInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardDatabaseBCInfo.Image = (Image)resources.GetObject("LBLCardDatabaseBCInfo.Image");
            LBLCardDatabaseBCInfo.Location = new Point(195, 10);
            LBLCardDatabaseBCInfo.Name = "LBLCardDatabaseBCInfo";
            LBLCardDatabaseBCInfo.Size = new Size(16, 16);
            LBLCardDatabaseBCInfo.TabIndex = 11;
            LBLCardDatabaseBCInfo.TabStop = false;
            // 
            // LBLCardDatabaseBCTitle
            // 
            LBLCardDatabaseBCTitle.AutoSize = true;
            LBLCardDatabaseBCTitle.Depth = 0;
            LBLCardDatabaseBCTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardDatabaseBCTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardDatabaseBCTitle.HighEmphasis = true;
            LBLCardDatabaseBCTitle.Location = new Point(10, 10);
            LBLCardDatabaseBCTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardDatabaseBCTitle.Name = "LBLCardDatabaseBCTitle";
            LBLCardDatabaseBCTitle.Size = new Size(65, 24);
            LBLCardDatabaseBCTitle.TabIndex = 10;
            LBLCardDatabaseBCTitle.Text = "Update";
            // 
            // materialCard17
            // 
            materialCard17.BackColor = Color.FromArgb(255, 255, 255);
            materialCard17.Controls.Add(TGLCustomDB);
            materialCard17.Controls.Add(TGLMopDB);
            materialCard17.Controls.Add(TGLCataDB);
            materialCard17.Controls.Add(TGLWotlkDB);
            materialCard17.Controls.Add(TGLTbcDB);
            materialCard17.Controls.Add(TGLClassicDB);
            materialCard17.Controls.Add(LBLCardPreconfiguredDBInfo);
            materialCard17.Controls.Add(LBLCardPreconfiguredDBTitle);
            materialCard17.Depth = 0;
            materialCard17.Dock = DockStyle.Fill;
            materialCard17.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard17.Location = new Point(456, 4);
            materialCard17.Margin = new Padding(4);
            materialCard17.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard17.Name = "materialCard17";
            materialCard17.Padding = new Padding(14);
            materialCard17.Size = new Size(218, 353);
            materialCard17.TabIndex = 2;
            // 
            // TGLCustomDB
            // 
            TGLCustomDB.AutoSize = true;
            TGLCustomDB.Depth = 0;
            TGLCustomDB.Location = new Point(-2, 255);
            TGLCustomDB.Margin = new Padding(0);
            TGLCustomDB.MouseLocation = new Point(-1, -1);
            TGLCustomDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLCustomDB.Name = "TGLCustomDB";
            TGLCustomDB.Ripple = true;
            TGLCustomDB.Size = new Size(111, 37);
            TGLCustomDB.TabIndex = 17;
            TGLCustomDB.Text = "custom";
            TGLCustomDB.UseVisualStyleBackColor = true;
            // 
            // TGLMopDB
            // 
            TGLMopDB.AutoSize = true;
            TGLMopDB.Depth = 0;
            TGLMopDB.Location = new Point(-2, 218);
            TGLMopDB.Margin = new Padding(0);
            TGLMopDB.MouseLocation = new Point(-1, -1);
            TGLMopDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLMopDB.Name = "TGLMopDB";
            TGLMopDB.Ripple = true;
            TGLMopDB.Size = new Size(90, 37);
            TGLMopDB.TabIndex = 16;
            TGLMopDB.Text = "mop";
            TGLMopDB.UseVisualStyleBackColor = true;
            // 
            // TGLCataDB
            // 
            TGLCataDB.AutoSize = true;
            TGLCataDB.Depth = 0;
            TGLCataDB.Location = new Point(-2, 181);
            TGLCataDB.Margin = new Padding(0);
            TGLCataDB.MouseLocation = new Point(-1, -1);
            TGLCataDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLCataDB.Name = "TGLCataDB";
            TGLCataDB.Ripple = true;
            TGLCataDB.Size = new Size(89, 37);
            TGLCataDB.TabIndex = 15;
            TGLCataDB.Text = "cata";
            TGLCataDB.UseVisualStyleBackColor = true;
            // 
            // TGLWotlkDB
            // 
            TGLWotlkDB.AutoSize = true;
            TGLWotlkDB.Depth = 0;
            TGLWotlkDB.Location = new Point(-2, 144);
            TGLWotlkDB.Margin = new Padding(0);
            TGLWotlkDB.MouseLocation = new Point(-1, -1);
            TGLWotlkDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLWotlkDB.Name = "TGLWotlkDB";
            TGLWotlkDB.Ripple = true;
            TGLWotlkDB.Size = new Size(96, 37);
            TGLWotlkDB.TabIndex = 14;
            TGLWotlkDB.Text = "wotlk";
            TGLWotlkDB.UseVisualStyleBackColor = true;
            // 
            // TGLTbcDB
            // 
            TGLTbcDB.AutoSize = true;
            TGLTbcDB.Depth = 0;
            TGLTbcDB.Location = new Point(-2, 107);
            TGLTbcDB.Margin = new Padding(0);
            TGLTbcDB.MouseLocation = new Point(-1, -1);
            TGLTbcDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLTbcDB.Name = "TGLTbcDB";
            TGLTbcDB.Ripple = true;
            TGLTbcDB.Size = new Size(80, 37);
            TGLTbcDB.TabIndex = 13;
            TGLTbcDB.Text = "tbc";
            TGLTbcDB.UseVisualStyleBackColor = true;
            // 
            // TGLClassicDB
            // 
            TGLClassicDB.AutoSize = true;
            TGLClassicDB.Depth = 0;
            TGLClassicDB.Font = new Font("Segoe UI Semibold", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TGLClassicDB.Location = new Point(-2, 70);
            TGLClassicDB.Margin = new Padding(0);
            TGLClassicDB.MouseLocation = new Point(-1, -1);
            TGLClassicDB.MouseState = MaterialSkin.MouseState.HOVER;
            TGLClassicDB.Name = "TGLClassicDB";
            TGLClassicDB.Ripple = true;
            TGLClassicDB.Size = new Size(107, 37);
            TGLClassicDB.TabIndex = 12;
            TGLClassicDB.Text = "classic";
            TGLClassicDB.UseVisualStyleBackColor = true;
            // 
            // LBLCardPreconfiguredDBInfo
            // 
            LBLCardPreconfiguredDBInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardPreconfiguredDBInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardPreconfiguredDBInfo.Image = (Image)resources.GetObject("LBLCardPreconfiguredDBInfo.Image");
            LBLCardPreconfiguredDBInfo.Location = new Point(195, 10);
            LBLCardPreconfiguredDBInfo.Name = "LBLCardPreconfiguredDBInfo";
            LBLCardPreconfiguredDBInfo.Size = new Size(16, 16);
            LBLCardPreconfiguredDBInfo.TabIndex = 11;
            LBLCardPreconfiguredDBInfo.TabStop = false;
            // 
            // LBLCardPreconfiguredDBTitle
            // 
            LBLCardPreconfiguredDBTitle.AutoSize = true;
            LBLCardPreconfiguredDBTitle.Depth = 0;
            LBLCardPreconfiguredDBTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardPreconfiguredDBTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardPreconfiguredDBTitle.HighEmphasis = true;
            LBLCardPreconfiguredDBTitle.Location = new Point(10, 10);
            LBLCardPreconfiguredDBTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardPreconfiguredDBTitle.Name = "LBLCardPreconfiguredDBTitle";
            LBLCardPreconfiguredDBTitle.Size = new Size(65, 24);
            LBLCardPreconfiguredDBTitle.TabIndex = 10;
            LBLCardPreconfiguredDBTitle.Text = "Update";
            // 
            // materialCard16
            // 
            materialCard16.BackColor = Color.FromArgb(255, 255, 255);
            materialCard16.Controls.Add(BTNDeleteWorld);
            materialCard16.Controls.Add(BTNDeleteChar);
            materialCard16.Controls.Add(BTNDeleteAuth);
            materialCard16.Controls.Add(TXTWorldDatabase);
            materialCard16.Controls.Add(TXTCharDatabase);
            materialCard16.Controls.Add(TXTAuthDatabase);
            materialCard16.Controls.Add(LBLCardTableNameInfo);
            materialCard16.Controls.Add(LBLCardTableNameTitle);
            materialCard16.Depth = 0;
            materialCard16.Dock = DockStyle.Fill;
            materialCard16.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard16.Location = new Point(230, 4);
            materialCard16.Margin = new Padding(4);
            materialCard16.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard16.Name = "materialCard16";
            materialCard16.Padding = new Padding(14);
            materialCard16.Size = new Size(218, 353);
            materialCard16.TabIndex = 1;
            // 
            // BTNDeleteWorld
            // 
            BTNDeleteWorld.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDeleteWorld.AutoSize = false;
            BTNDeleteWorld.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDeleteWorld.Cursor = Cursors.Hand;
            BTNDeleteWorld.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDeleteWorld.Depth = 0;
            BTNDeleteWorld.HighEmphasis = true;
            BTNDeleteWorld.Icon = (Image)resources.GetObject("BTNDeleteWorld.Icon");
            BTNDeleteWorld.Location = new Point(6, 316);
            BTNDeleteWorld.Margin = new Padding(4, 6, 4, 6);
            BTNDeleteWorld.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDeleteWorld.Name = "BTNDeleteWorld";
            BTNDeleteWorld.NoAccentTextColor = Color.Empty;
            BTNDeleteWorld.Size = new Size(205, 36);
            BTNDeleteWorld.TabIndex = 19;
            BTNDeleteWorld.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDeleteWorld.UseAccentColor = false;
            BTNDeleteWorld.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteChar
            // 
            BTNDeleteChar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDeleteChar.AutoSize = false;
            BTNDeleteChar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDeleteChar.Cursor = Cursors.Hand;
            BTNDeleteChar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDeleteChar.Depth = 0;
            BTNDeleteChar.HighEmphasis = true;
            BTNDeleteChar.Icon = (Image)resources.GetObject("BTNDeleteChar.Icon");
            BTNDeleteChar.Location = new Point(6, 274);
            BTNDeleteChar.Margin = new Padding(4, 6, 4, 6);
            BTNDeleteChar.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDeleteChar.Name = "BTNDeleteChar";
            BTNDeleteChar.NoAccentTextColor = Color.Empty;
            BTNDeleteChar.Size = new Size(205, 36);
            BTNDeleteChar.TabIndex = 18;
            BTNDeleteChar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDeleteChar.UseAccentColor = false;
            BTNDeleteChar.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteAuth
            // 
            BTNDeleteAuth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNDeleteAuth.AutoSize = false;
            BTNDeleteAuth.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNDeleteAuth.Cursor = Cursors.Hand;
            BTNDeleteAuth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNDeleteAuth.Depth = 0;
            BTNDeleteAuth.HighEmphasis = true;
            BTNDeleteAuth.Icon = (Image)resources.GetObject("BTNDeleteAuth.Icon");
            BTNDeleteAuth.Location = new Point(6, 232);
            BTNDeleteAuth.Margin = new Padding(4, 6, 4, 6);
            BTNDeleteAuth.MouseState = MaterialSkin.MouseState.HOVER;
            BTNDeleteAuth.Name = "BTNDeleteAuth";
            BTNDeleteAuth.NoAccentTextColor = Color.Empty;
            BTNDeleteAuth.Size = new Size(205, 36);
            BTNDeleteAuth.TabIndex = 17;
            BTNDeleteAuth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNDeleteAuth.UseAccentColor = false;
            BTNDeleteAuth.UseVisualStyleBackColor = true;
            // 
            // TXTWorldDatabase
            // 
            TXTWorldDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTWorldDatabase.AnimateReadOnly = true;
            TXTWorldDatabase.AutoCompleteMode = AutoCompleteMode.None;
            TXTWorldDatabase.AutoCompleteSource = AutoCompleteSource.None;
            TXTWorldDatabase.BackgroundImageLayout = ImageLayout.None;
            TXTWorldDatabase.CharacterCasing = CharacterCasing.Normal;
            TXTWorldDatabase.Depth = 0;
            TXTWorldDatabase.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTWorldDatabase.HideSelection = true;
            TXTWorldDatabase.Hint = "ID";
            TXTWorldDatabase.LeadingIcon = null;
            TXTWorldDatabase.Location = new Point(6, 178);
            TXTWorldDatabase.MaxLength = 32767;
            TXTWorldDatabase.MouseState = MaterialSkin.MouseState.OUT;
            TXTWorldDatabase.Name = "TXTWorldDatabase";
            TXTWorldDatabase.PasswordChar = '\0';
            TXTWorldDatabase.PrefixSuffixText = null;
            TXTWorldDatabase.ReadOnly = true;
            TXTWorldDatabase.RightToLeft = RightToLeft.No;
            TXTWorldDatabase.SelectedText = "";
            TXTWorldDatabase.SelectionLength = 0;
            TXTWorldDatabase.SelectionStart = 0;
            TXTWorldDatabase.ShortcutsEnabled = true;
            TXTWorldDatabase.Size = new Size(205, 48);
            TXTWorldDatabase.TabIndex = 16;
            TXTWorldDatabase.TabStop = false;
            TXTWorldDatabase.TextAlign = HorizontalAlignment.Left;
            TXTWorldDatabase.TrailingIcon = (Image)resources.GetObject("TXTWorldDatabase.TrailingIcon");
            TXTWorldDatabase.UseSystemPasswordChar = false;
            // 
            // TXTCharDatabase
            // 
            TXTCharDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTCharDatabase.AnimateReadOnly = true;
            TXTCharDatabase.AutoCompleteMode = AutoCompleteMode.None;
            TXTCharDatabase.AutoCompleteSource = AutoCompleteSource.None;
            TXTCharDatabase.BackgroundImageLayout = ImageLayout.None;
            TXTCharDatabase.CharacterCasing = CharacterCasing.Normal;
            TXTCharDatabase.Depth = 0;
            TXTCharDatabase.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTCharDatabase.HideSelection = true;
            TXTCharDatabase.Hint = "ID";
            TXTCharDatabase.LeadingIcon = null;
            TXTCharDatabase.Location = new Point(6, 124);
            TXTCharDatabase.MaxLength = 32767;
            TXTCharDatabase.MouseState = MaterialSkin.MouseState.OUT;
            TXTCharDatabase.Name = "TXTCharDatabase";
            TXTCharDatabase.PasswordChar = '\0';
            TXTCharDatabase.PrefixSuffixText = null;
            TXTCharDatabase.ReadOnly = true;
            TXTCharDatabase.RightToLeft = RightToLeft.No;
            TXTCharDatabase.SelectedText = "";
            TXTCharDatabase.SelectionLength = 0;
            TXTCharDatabase.SelectionStart = 0;
            TXTCharDatabase.ShortcutsEnabled = true;
            TXTCharDatabase.Size = new Size(205, 48);
            TXTCharDatabase.TabIndex = 15;
            TXTCharDatabase.TabStop = false;
            TXTCharDatabase.TextAlign = HorizontalAlignment.Left;
            TXTCharDatabase.TrailingIcon = (Image)resources.GetObject("TXTCharDatabase.TrailingIcon");
            TXTCharDatabase.UseSystemPasswordChar = false;
            // 
            // TXTAuthDatabase
            // 
            TXTAuthDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTAuthDatabase.AnimateReadOnly = true;
            TXTAuthDatabase.AutoCompleteMode = AutoCompleteMode.None;
            TXTAuthDatabase.AutoCompleteSource = AutoCompleteSource.None;
            TXTAuthDatabase.BackgroundImageLayout = ImageLayout.None;
            TXTAuthDatabase.CharacterCasing = CharacterCasing.Normal;
            TXTAuthDatabase.Depth = 0;
            TXTAuthDatabase.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTAuthDatabase.HideSelection = true;
            TXTAuthDatabase.Hint = "ID";
            TXTAuthDatabase.LeadingIcon = null;
            TXTAuthDatabase.Location = new Point(6, 70);
            TXTAuthDatabase.MaxLength = 32767;
            TXTAuthDatabase.MouseState = MaterialSkin.MouseState.OUT;
            TXTAuthDatabase.Name = "TXTAuthDatabase";
            TXTAuthDatabase.PasswordChar = '\0';
            TXTAuthDatabase.PrefixSuffixText = null;
            TXTAuthDatabase.ReadOnly = true;
            TXTAuthDatabase.RightToLeft = RightToLeft.No;
            TXTAuthDatabase.SelectedText = "";
            TXTAuthDatabase.SelectionLength = 0;
            TXTAuthDatabase.SelectionStart = 0;
            TXTAuthDatabase.ShortcutsEnabled = true;
            TXTAuthDatabase.Size = new Size(205, 48);
            TXTAuthDatabase.TabIndex = 14;
            TXTAuthDatabase.TabStop = false;
            TXTAuthDatabase.TextAlign = HorizontalAlignment.Left;
            TXTAuthDatabase.TrailingIcon = (Image)resources.GetObject("TXTAuthDatabase.TrailingIcon");
            TXTAuthDatabase.UseSystemPasswordChar = false;
            // 
            // LBLCardTableNameInfo
            // 
            LBLCardTableNameInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardTableNameInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardTableNameInfo.Image = (Image)resources.GetObject("LBLCardTableNameInfo.Image");
            LBLCardTableNameInfo.Location = new Point(195, 10);
            LBLCardTableNameInfo.Name = "LBLCardTableNameInfo";
            LBLCardTableNameInfo.Size = new Size(16, 16);
            LBLCardTableNameInfo.TabIndex = 11;
            LBLCardTableNameInfo.TabStop = false;
            // 
            // LBLCardTableNameTitle
            // 
            LBLCardTableNameTitle.AutoSize = true;
            LBLCardTableNameTitle.Depth = 0;
            LBLCardTableNameTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardTableNameTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardTableNameTitle.HighEmphasis = true;
            LBLCardTableNameTitle.Location = new Point(10, 10);
            LBLCardTableNameTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardTableNameTitle.Name = "LBLCardTableNameTitle";
            LBLCardTableNameTitle.Size = new Size(65, 24);
            LBLCardTableNameTitle.TabIndex = 10;
            LBLCardTableNameTitle.Text = "Update";
            // 
            // materialCard15
            // 
            materialCard15.BackColor = Color.FromArgb(255, 255, 255);
            materialCard15.Controls.Add(LBLCardDatabaseCredencialsInfo);
            materialCard15.Controls.Add(BTNTestConnection);
            materialCard15.Controls.Add(TXTDatabasePassword);
            materialCard15.Controls.Add(TXTDatabaseUser);
            materialCard15.Controls.Add(TXTDatabasePort);
            materialCard15.Controls.Add(TXTDatabaseHost);
            materialCard15.Controls.Add(LBLCardDatabaseCredencialsTitle);
            materialCard15.Depth = 0;
            materialCard15.Dock = DockStyle.Fill;
            materialCard15.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard15.Location = new Point(4, 4);
            materialCard15.Margin = new Padding(4);
            materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard15.Name = "materialCard15";
            materialCard15.Padding = new Padding(14);
            materialCard15.Size = new Size(218, 353);
            materialCard15.TabIndex = 0;
            // 
            // LBLCardDatabaseCredencialsInfo
            // 
            LBLCardDatabaseCredencialsInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLCardDatabaseCredencialsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            LBLCardDatabaseCredencialsInfo.Image = (Image)resources.GetObject("LBLCardDatabaseCredencialsInfo.Image");
            LBLCardDatabaseCredencialsInfo.Location = new Point(195, 10);
            LBLCardDatabaseCredencialsInfo.Name = "LBLCardDatabaseCredencialsInfo";
            LBLCardDatabaseCredencialsInfo.Size = new Size(16, 16);
            LBLCardDatabaseCredencialsInfo.TabIndex = 11;
            LBLCardDatabaseCredencialsInfo.TabStop = false;
            // 
            // BTNTestConnection
            // 
            BTNTestConnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTNTestConnection.AutoSize = false;
            BTNTestConnection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTNTestConnection.Cursor = Cursors.Hand;
            BTNTestConnection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTNTestConnection.Depth = 0;
            BTNTestConnection.HighEmphasis = true;
            BTNTestConnection.Icon = (Image)resources.GetObject("BTNTestConnection.Icon");
            BTNTestConnection.Location = new Point(6, 289);
            BTNTestConnection.Margin = new Padding(4, 6, 4, 6);
            BTNTestConnection.MouseState = MaterialSkin.MouseState.HOVER;
            BTNTestConnection.Name = "BTNTestConnection";
            BTNTestConnection.NoAccentTextColor = Color.Empty;
            BTNTestConnection.Size = new Size(205, 36);
            BTNTestConnection.TabIndex = 15;
            BTNTestConnection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTNTestConnection.UseAccentColor = false;
            BTNTestConnection.UseVisualStyleBackColor = true;
            // 
            // TXTDatabasePassword
            // 
            TXTDatabasePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDatabasePassword.AnimateReadOnly = true;
            TXTDatabasePassword.AutoCompleteMode = AutoCompleteMode.None;
            TXTDatabasePassword.AutoCompleteSource = AutoCompleteSource.None;
            TXTDatabasePassword.BackgroundImageLayout = ImageLayout.None;
            TXTDatabasePassword.CharacterCasing = CharacterCasing.Normal;
            TXTDatabasePassword.Depth = 0;
            TXTDatabasePassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDatabasePassword.HideSelection = true;
            TXTDatabasePassword.Hint = "ID";
            TXTDatabasePassword.LeadingIcon = null;
            TXTDatabasePassword.Location = new Point(6, 232);
            TXTDatabasePassword.MaxLength = 32767;
            TXTDatabasePassword.MouseState = MaterialSkin.MouseState.OUT;
            TXTDatabasePassword.Name = "TXTDatabasePassword";
            TXTDatabasePassword.PasswordChar = '\0';
            TXTDatabasePassword.PrefixSuffixText = null;
            TXTDatabasePassword.ReadOnly = true;
            TXTDatabasePassword.RightToLeft = RightToLeft.No;
            TXTDatabasePassword.SelectedText = "";
            TXTDatabasePassword.SelectionLength = 0;
            TXTDatabasePassword.SelectionStart = 0;
            TXTDatabasePassword.ShortcutsEnabled = true;
            TXTDatabasePassword.Size = new Size(205, 48);
            TXTDatabasePassword.TabIndex = 14;
            TXTDatabasePassword.TabStop = false;
            TXTDatabasePassword.TextAlign = HorizontalAlignment.Left;
            TXTDatabasePassword.TrailingIcon = (Image)resources.GetObject("TXTDatabasePassword.TrailingIcon");
            TXTDatabasePassword.UseSystemPasswordChar = false;
            // 
            // TXTDatabaseUser
            // 
            TXTDatabaseUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDatabaseUser.AnimateReadOnly = true;
            TXTDatabaseUser.AutoCompleteMode = AutoCompleteMode.None;
            TXTDatabaseUser.AutoCompleteSource = AutoCompleteSource.None;
            TXTDatabaseUser.BackgroundImageLayout = ImageLayout.None;
            TXTDatabaseUser.CharacterCasing = CharacterCasing.Normal;
            TXTDatabaseUser.Depth = 0;
            TXTDatabaseUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDatabaseUser.HideSelection = true;
            TXTDatabaseUser.Hint = "ID";
            TXTDatabaseUser.LeadingIcon = null;
            TXTDatabaseUser.Location = new Point(6, 178);
            TXTDatabaseUser.MaxLength = 32767;
            TXTDatabaseUser.MouseState = MaterialSkin.MouseState.OUT;
            TXTDatabaseUser.Name = "TXTDatabaseUser";
            TXTDatabaseUser.PasswordChar = '\0';
            TXTDatabaseUser.PrefixSuffixText = null;
            TXTDatabaseUser.ReadOnly = true;
            TXTDatabaseUser.RightToLeft = RightToLeft.No;
            TXTDatabaseUser.SelectedText = "";
            TXTDatabaseUser.SelectionLength = 0;
            TXTDatabaseUser.SelectionStart = 0;
            TXTDatabaseUser.ShortcutsEnabled = true;
            TXTDatabaseUser.Size = new Size(205, 48);
            TXTDatabaseUser.TabIndex = 13;
            TXTDatabaseUser.TabStop = false;
            TXTDatabaseUser.TextAlign = HorizontalAlignment.Left;
            TXTDatabaseUser.TrailingIcon = (Image)resources.GetObject("TXTDatabaseUser.TrailingIcon");
            TXTDatabaseUser.UseSystemPasswordChar = false;
            // 
            // TXTDatabasePort
            // 
            TXTDatabasePort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDatabasePort.AnimateReadOnly = true;
            TXTDatabasePort.AutoCompleteMode = AutoCompleteMode.None;
            TXTDatabasePort.AutoCompleteSource = AutoCompleteSource.None;
            TXTDatabasePort.BackgroundImageLayout = ImageLayout.None;
            TXTDatabasePort.CharacterCasing = CharacterCasing.Normal;
            TXTDatabasePort.Depth = 0;
            TXTDatabasePort.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDatabasePort.HideSelection = true;
            TXTDatabasePort.Hint = "ID";
            TXTDatabasePort.LeadingIcon = null;
            TXTDatabasePort.Location = new Point(6, 124);
            TXTDatabasePort.MaxLength = 32767;
            TXTDatabasePort.MouseState = MaterialSkin.MouseState.OUT;
            TXTDatabasePort.Name = "TXTDatabasePort";
            TXTDatabasePort.PasswordChar = '\0';
            TXTDatabasePort.PrefixSuffixText = null;
            TXTDatabasePort.ReadOnly = true;
            TXTDatabasePort.RightToLeft = RightToLeft.No;
            TXTDatabasePort.SelectedText = "";
            TXTDatabasePort.SelectionLength = 0;
            TXTDatabasePort.SelectionStart = 0;
            TXTDatabasePort.ShortcutsEnabled = true;
            TXTDatabasePort.Size = new Size(205, 48);
            TXTDatabasePort.TabIndex = 12;
            TXTDatabasePort.TabStop = false;
            TXTDatabasePort.TextAlign = HorizontalAlignment.Left;
            TXTDatabasePort.TrailingIcon = (Image)resources.GetObject("TXTDatabasePort.TrailingIcon");
            TXTDatabasePort.UseSystemPasswordChar = false;
            // 
            // TXTDatabaseHost
            // 
            TXTDatabaseHost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTDatabaseHost.AnimateReadOnly = true;
            TXTDatabaseHost.AutoCompleteMode = AutoCompleteMode.None;
            TXTDatabaseHost.AutoCompleteSource = AutoCompleteSource.None;
            TXTDatabaseHost.BackgroundImageLayout = ImageLayout.None;
            TXTDatabaseHost.CharacterCasing = CharacterCasing.Normal;
            TXTDatabaseHost.Depth = 0;
            TXTDatabaseHost.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXTDatabaseHost.HideSelection = true;
            TXTDatabaseHost.Hint = "ID";
            TXTDatabaseHost.LeadingIcon = null;
            TXTDatabaseHost.Location = new Point(6, 70);
            TXTDatabaseHost.MaxLength = 32767;
            TXTDatabaseHost.MouseState = MaterialSkin.MouseState.OUT;
            TXTDatabaseHost.Name = "TXTDatabaseHost";
            TXTDatabaseHost.PasswordChar = '\0';
            TXTDatabaseHost.PrefixSuffixText = null;
            TXTDatabaseHost.ReadOnly = true;
            TXTDatabaseHost.RightToLeft = RightToLeft.No;
            TXTDatabaseHost.SelectedText = "";
            TXTDatabaseHost.SelectionLength = 0;
            TXTDatabaseHost.SelectionStart = 0;
            TXTDatabaseHost.ShortcutsEnabled = true;
            TXTDatabaseHost.Size = new Size(205, 48);
            TXTDatabaseHost.TabIndex = 11;
            TXTDatabaseHost.TabStop = false;
            TXTDatabaseHost.TextAlign = HorizontalAlignment.Left;
            TXTDatabaseHost.TrailingIcon = (Image)resources.GetObject("TXTDatabaseHost.TrailingIcon");
            TXTDatabaseHost.UseSystemPasswordChar = false;
            // 
            // LBLCardDatabaseCredencialsTitle
            // 
            LBLCardDatabaseCredencialsTitle.AutoSize = true;
            LBLCardDatabaseCredencialsTitle.Depth = 0;
            LBLCardDatabaseCredencialsTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            LBLCardDatabaseCredencialsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            LBLCardDatabaseCredencialsTitle.HighEmphasis = true;
            LBLCardDatabaseCredencialsTitle.Location = new Point(10, 10);
            LBLCardDatabaseCredencialsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            LBLCardDatabaseCredencialsTitle.Name = "LBLCardDatabaseCredencialsTitle";
            LBLCardDatabaseCredencialsTitle.Size = new Size(65, 24);
            LBLCardDatabaseCredencialsTitle.TabIndex = 9;
            LBLCardDatabaseCredencialsTitle.Text = "Update";
            // 
            // TabNotification
            // 
            TabNotification.BackColor = Color.White;
            TabNotification.Controls.Add(tableLayoutPanel11);
            TabNotification.ImageKey = "notification-32.png";
            TabNotification.Location = new Point(39, 4);
            TabNotification.Name = "TabNotification";
            TabNotification.Size = new Size(948, 431);
            TabNotification.TabIndex = 5;
            TabNotification.Text = "Noti";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(BTNClean, 0, 1);
            tableLayoutPanel11.Controls.Add(DGVNotifications, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.Size = new Size(948, 431);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // DGVNotifications
            // 
            DGVNotifications.AllowUserToAddRows = false;
            DGVNotifications.AllowUserToDeleteRows = false;
            DGVNotifications.AllowUserToResizeColumns = false;
            DGVNotifications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DGVNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVNotifications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVNotifications.BackgroundColor = Color.FromArgb(34, 39, 46);
            DGVNotifications.BorderStyle = BorderStyle.None;
            DGVNotifications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVNotifications.Columns.AddRange(new DataGridViewColumn[] { ID, Message, Time });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGVNotifications.DefaultCellStyle = dataGridViewCellStyle4;
            DGVNotifications.Dock = DockStyle.Fill;
            DGVNotifications.EnableHeadersVisualStyles = false;
            DGVNotifications.GridColor = Color.Black;
            DGVNotifications.Location = new Point(3, 3);
            DGVNotifications.Name = "DGVNotifications";
            DGVNotifications.ReadOnly = true;
            DGVNotifications.RightToLeft = RightToLeft.No;
            DGVNotifications.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGVNotifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGVNotifications.RowHeadersVisible = false;
            DGVNotifications.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DGVNotifications.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DGVNotifications.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DGVNotifications.RowTemplate.ReadOnly = true;
            DGVNotifications.RowTemplate.Resizable = DataGridViewTriState.True;
            DGVNotifications.ShowCellErrors = false;
            DGVNotifications.ShowCellToolTips = false;
            DGVNotifications.ShowEditingIcon = false;
            DGVNotifications.ShowRowErrors = false;
            DGVNotifications.Size = new Size(942, 381);
            DGVNotifications.TabIndex = 37;
            // 
            // ID
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(28, 33, 40);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle3;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Message
            // 
            Message.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Message.HeaderText = "💬";
            Message.MinimumWidth = 6;
            Message.Name = "Message";
            Message.ReadOnly = true;
            // 
            // Time
            // 
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Time.FillWeight = 30F;
            Time.HeaderText = "🕠";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // IMGListTabControler
            // 
            IMGListTabControler.ColorDepth = ColorDepth.Depth32Bit;
            IMGListTabControler.ImageStream = (ImageListStreamer)resources.GetObject("IMGListTabControler.ImageStream");
            IMGListTabControler.TransparentColor = Color.Transparent;
            IMGListTabControler.Images.SetKeyName(0, "menu-35.png");
            IMGListTabControler.Images.SetKeyName(1, "settings-35.png");
            IMGListTabControler.Images.SetKeyName(2, "ds3-tool-30.png");
            IMGListTabControler.Images.SetKeyName(3, "database-administrator-64.png");
            IMGListTabControler.Images.SetKeyName(4, "dns-32.png");
            IMGListTabControler.Images.SetKeyName(5, "notification-32.png");
            IMGListTabControler.Images.SetKeyName(6, "notification-32-ring.png");
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1000, 600);
            Controls.Add(LayoutPanelMain);
            DrawerIndicatorWidth = 3;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = MainFormTabControler;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FormStyle = FormStyles.ActionBar_48;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            Padding = new Padding(0, 72, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trion Control Panel";
            Load += MainForm_LoadAsync;
            CMSNotify.ResumeLayout(false);
            LayoutPanelMain.ResumeLayout(false);
            HomeMenuCard.ResumeLayout(false);
            MainFormTabControler.ResumeLayout(false);
            TabHome.ResumeLayout(false);
            LayoutPanelHome.ResumeLayout(false);
            CardLogonResorce.ResumeLayout(false);
            CardLogonResorce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoLogonResorces).EndInit();
            CardWorldResources.ResumeLayout(false);
            CardWorldResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoWorldResorces).EndInit();
            CardServerStatus.ResumeLayout(false);
            LayerPNLCardServerREsorce.ResumeLayout(false);
            PNLLogonServerStatus.ResumeLayout(false);
            PNLLogonServerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PICLogonServerStatus).EndInit();
            PNLWorldServerStatus.ResumeLayout(false);
            PNLWorldServerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PICWorldServerStatus).EndInit();
            PNLDatanasServerStatus.ResumeLayout(false);
            PNLDatanasServerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PICMySqlServerStatus).EndInit();
            CardMachineResoruces.ResumeLayout(false);
            CardMachineResoruces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InfoMachineResources).EndInit();
            TabSPP.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            materialCard12.ResumeLayout(false);
            materialCard12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardSPPInstaledInfo).EndInit();
            materialCard13.ResumeLayout(false);
            materialCard13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardElulatorsInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard14.ResumeLayout(false);
            materialCard14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardSPPversionInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            TabDatabaseEditor.ResumeLayout(false);
            DatabaseEditorLayoutPanel.ResumeLayout(false);
            DatabaseEditorTabControl.ResumeLayout(false);
            TabRealmList.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmActionInfo).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmOptionInfo).EndInit();
            RealmlistInfosCard.ResumeLayout(false);
            RealmlistInfosCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardRealmDataInfo).EndInit();
            TabAccount.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardPasswordResetInfo).EndInit();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardAccountAccessInfo).EndInit();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardAccountCreateInfo).EndInit();
            TabDDNS.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            materialCard20.ResumeLayout(false);
            materialCard20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDDNSTimerInfos).EndInit();
            materialCard19.ResumeLayout(false);
            materialCard19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDDNSSettingsInfo).EndInit();
            TabSettings.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            SettingsTabControl.ResumeLayout(false);
            TabTrion.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomPreferencesInfo).EndInit();
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            metroPanel7.ResumeLayout(false);
            metroPanel7.PerformLayout();
            metroPanel6.ResumeLayout(false);
            metroPanel6.PerformLayout();
            metroPanel5.ResumeLayout(false);
            metroPanel5.PerformLayout();
            metroPanel4.ResumeLayout(false);
            metroPanel4.PerformLayout();
            metroPanel3.ResumeLayout(false);
            metroPanel3.PerformLayout();
            metroPanel2.ResumeLayout(false);
            metroPanel2.PerformLayout();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardUpdateDashboardInfo).EndInit();
            materialCard8.ResumeLayout(false);
            materialCard8.PerformLayout();
            TabCustom.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            materialCard11.ResumeLayout(false);
            materialCard10.ResumeLayout(false);
            materialCard10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomNamesInfo).EndInit();
            materialCard9.ResumeLayout(false);
            materialCard9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardCustomEmulatorInfo).EndInit();
            TabDatabase.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            materialCard18.ResumeLayout(false);
            materialCard18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDatabaseBCInfo).EndInit();
            materialCard17.ResumeLayout(false);
            materialCard17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardPreconfiguredDBInfo).EndInit();
            materialCard16.ResumeLayout(false);
            materialCard16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardTableNameInfo).EndInit();
            materialCard15.ResumeLayout(false);
            materialCard15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LBLCardDatabaseCredencialsInfo).EndInit();
            TabNotification.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer TimerWacher;
        private NotifyIcon NIcon;
        private ContextMenuStrip CMSNotify;
        private ToolStripMenuItem OpenTSMItem;
        private ToolStripMenuItem StartWorldTSMItem;
        private ToolStripMenuItem StartLogonTSMItem;
        private ToolStripMenuItem StartDatabaseTSMItem;
        private ToolStripMenuItem ExitTSMItem;
        private System.Windows.Forms.Timer TimerLoadingCheck;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private TrionUI.Controls.CustomToolTip TLTHome;
        private System.Windows.Forms.Timer TimerCrashDetected;
        private TableLayoutPanel LayoutPanelMain;
        private MaterialSkin.Controls.MaterialTabControl MainFormTabControler;
        private TabPage TabHome;
        private TabPage TabSettings;
        private ImageList IMGListTabControler;
        private TableLayoutPanel LayoutPanelHome;
        private MaterialSkin.Controls.MaterialCard HomeMenuCard;
        private MaterialSkin.Controls.MaterialCard CardMachineResoruces;
        private MaterialSkin.Controls.MaterialLabel LBLCPUTextMachineResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarCPUMachineResources;
        private MaterialSkin.Controls.MaterialLabel LBLRAMTextMachineResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarRAMMachineResources;
        private MaterialSkin.Controls.MaterialCard CardServerStatus;
        private MaterialSkin.Controls.MaterialLabel LBLCardMachineResourcesTitle;
        private PictureBox InfoMachineResources;
        private MaterialSkin.Controls.MaterialCard CardWorldResources;
        private PictureBox InfoWorldResorces;
        private MaterialSkin.Controls.MaterialLabel LBLCardWorldResourcesTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCPUTextWorldResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarRAMWordResources;
        private MaterialSkin.Controls.MaterialLabel LBLRAMTextWorldResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarCPUWordResources;
        private MaterialSkin.Controls.MaterialCard CardLogonResorce;
        private PictureBox InfoLogonResorces;
        private MaterialSkin.Controls.MaterialLabel LBLCardLogonResourcesTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCPUTextLogonResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarRAMLogonResources;
        private MaterialSkin.Controls.MaterialProgressBar PbarCPULogonResources;
        private MaterialSkin.Controls.MaterialLabel LBLRAMTextLogonResources;
        private TableLayoutPanel LayerPNLCardServerREsorce;
        private MetroFramework.Controls.MetroPanel PNLDatanasServerStatus;
        private MetroFramework.Controls.MetroPanel PNLLogonServerStatus;
        private MetroFramework.Controls.MetroPanel PNLWorldServerStatus;
        private Label LBLDatabaseProcessID;
        private Label LBLUpTimeDatabase;
        public PictureBox PICMySqlServerStatus;
        private Label LBLDatabaseServerStatus;
        private Label LBLWorldProcessID;
        private Label LBLUpTimeWorld;
        public PictureBox PICWorldServerStatus;
        private Label LBLWorldServerStatus;
        private Label LBLLogonProcessID;
        private Label LBLUpTimeLogon;
        public PictureBox PICLogonServerStatus;
        private Label LBLLogonServerStatus;
        private TabPage TabDatabaseEditor;
        private TableLayoutPanel DatabaseEditorLayoutPanel;
        private MaterialSkin.Controls.MaterialTabSelector DatabaseEditorTabSelector;
        private MaterialSkin.Controls.MaterialTabControl DatabaseEditorTabControl;
        private TabPage TabRealmList;
        private TabPage TabAccount;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard RealmlistInfosCard;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialTabSelector SettingsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl SettingsTabControl;
        private TabPage TabTrion;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private TabPage TabCustom;
        private TabPage TabDatabase;
        private MaterialSkin.Controls.MaterialLabel LBLCardRealmActionTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardRealmOptionTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardRealmDataTitle;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmID;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmName;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmAddress;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxPassRePassword;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmPort;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmSubnetMask;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmGameBuild;
        private MaterialSkin.Controls.MaterialComboBox CBOXReamList;
        private MaterialSkin.Controls.MaterialTextBox2 TXTPublicIP;
        private MaterialSkin.Controls.MaterialTextBox2 TXTInternIP;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDomainName;
        private MaterialSkin.Controls.MaterialButton BTNForceRefresh;
        private MaterialSkin.Controls.MaterialButton BTNEditRealmlistData;
        private MaterialSkin.Controls.MaterialButton BTNOpenIntern;
        private MaterialSkin.Controls.MaterialButton BTNOpenPublic;
        private MaterialSkin.Controls.MaterialButton BTNStartWorld;
        private MaterialSkin.Controls.MaterialButton BTNStartDatabase;
        private MaterialSkin.Controls.MaterialButton BTNStartLogon;
        private MaterialSkin.Controls.MaterialTextBox2 TXTRealmLocalAddress;
        private PictureBox LBLCardRealmDataInfo;
        private PictureBox LBLCardRealmActionInfo;
        private PictureBox LBLCardRealmOptionInfo;
        private PictureBox LBLCardAccountAccessInfo;
        private MaterialSkin.Controls.MaterialLabel LBLCardAccountAdmin;
        private PictureBox LBLCardAccountCreateInfo;
        private MaterialSkin.Controls.MaterialLabel LBLCardAccountCreate;
        private PictureBox LBLCardPasswordResetInfo;
        private MaterialSkin.Controls.MaterialLabel LBLCardAccountPassword;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxCreateUserUsername;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxCreateUserEmail;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxCreateUserPassword;
        private MaterialSkin.Controls.MaterialButton BTNAccountCreate;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxGMUsername;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxPassPassword;
        private MaterialSkin.Controls.MaterialTextBox2 TXTBoxPassUsername;
        private MaterialSkin.Controls.MaterialButton BTNTBoxPassResset;
        private MaterialSkin.Controls.MaterialButton BTNGMCreate;
        private MaterialSkin.Controls.MaterialComboBox CBOXAccountSecurityAccess;
        private MaterialSkin.Controls.MaterialSwitch TGLAutoUpdateCore;
        private MaterialSkin.Controls.MaterialSwitch TGLAutoUpdateTrion;
        private MaterialSkin.Controls.MaterialSwitch TGLStayInTray;
        private MaterialSkin.Controls.MaterialSwitch TGLNotificationSound;
        private MaterialSkin.Controls.MaterialSwitch TGLHideConsole;
        private MaterialSkin.Controls.MaterialSwitch TGLRunTrionStartup;
        private MaterialSkin.Controls.MaterialSwitch TGLServerStartup;
        private MaterialSkin.Controls.MaterialSwitch TGLServerCrashDetection;
        private MaterialSkin.Controls.MaterialComboBox CBOXAccountExpansion;
        private MaterialSkin.Controls.MaterialSwitch TGLAutoUpdateDatabase;
        private MaterialSkin.Controls.MaterialComboBox CBoxGMRealmSelect;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel LBLCardUpdateDashboardTitle;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialComboBox CBOXLanguageSelect;
        private MaterialSkin.Controls.MaterialComboBox CBOXColorSelect;
        private MaterialSkin.Controls.MaterialLabel LBLCardCustomPreferencesTitle;
        private TabPage TabSPP;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton BTNReviveIP;
        private PictureBox LBLCardElulatorsInfo;
        private MaterialSkin.Controls.MaterialLabel LBLCardSPPRunTitle;
        private PictureBox LBLCardSPPversionInfo;
        private MaterialSkin.Controls.MaterialLabel LBLCardSPPVersionTitle;
        private MaterialSkin.Controls.MaterialComboBox CBOXSPPVersion;
        private MaterialSkin.Controls.MaterialButton BTNUninstallSPP;
        private MaterialSkin.Controls.MaterialButton BTNRepairSPP;
        private MaterialSkin.Controls.MaterialButton BTNInstallSPP;
        private MaterialSkin.Controls.MaterialSwitch TGLMoPLaunch;
        private MaterialSkin.Controls.MaterialSwitch TGLCataLaunch;
        private MaterialSkin.Controls.MaterialSwitch TGLWotLKLaunch;
        private MaterialSkin.Controls.MaterialSwitch TGLTBCLaunch;
        private MaterialSkin.Controls.MaterialSwitch TGLClassicLaunch;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private MaterialSkin.Controls.MaterialCheckbox ChecMOPInstalled;
        private MaterialSkin.Controls.MaterialCheckbox ChecCATAInstalled;
        private MaterialSkin.Controls.MaterialCheckbox ChecWOTLKInstalled;
        private MaterialSkin.Controls.MaterialCheckbox ChecTBCInstalled;
        private MaterialSkin.Controls.MaterialCheckbox ChecCLASSICInstalled;
        private MaterialSkin.Controls.MaterialSwitch TGLAccountShowPassword;
        private TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCustomDatabaseLocation;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCustomRepackLocation;
        private TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialLabel LBLCardCustomEmulatorTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardCustomNamesTitle;
        private MaterialSkin.Controls.MaterialButton BTNSkyFireWebsite;
        private MaterialSkin.Controls.MaterialButton BTNTrinityCoreWebsite;
        private MaterialSkin.Controls.MaterialButton BTNCypherWebsite;
        private MaterialSkin.Controls.MaterialButton BTNCMangosWebsite;
        private MaterialSkin.Controls.MaterialButton BTNACoreWebsite;
        private MaterialSkin.Controls.MaterialButton BTNAscEmuWebsite;
        private PictureBox LBLCardSPPInstaledInfo;
        private MaterialSkin.Controls.MaterialComboBox CBOXSelectedEmulators;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCustomWorldName;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCustomAuthName;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCustomDatabaseName;
        private MaterialSkin.Controls.MaterialButton BTNEmulatorLocation;
        private MaterialSkin.Controls.MaterialButton BTNDatabaseLocation;
        private PictureBox LBLCardCustomPreferencesInfo;
        private PictureBox LBLCardUpdateDashboardInfo;
        private PictureBox LBLCardCustomNamesInfo;
        private PictureBox LBLCardCustomEmulatorInfo;
        private MaterialSkin.Controls.MaterialSwitch TGLCustomNames;
        private MaterialSkin.Controls.MaterialSwitch TGLUseCustomServer;
        private TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialCard materialCard18;
        private MaterialSkin.Controls.MaterialCard materialCard17;
        private MaterialSkin.Controls.MaterialCard materialCard16;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialLabel LBLCardTableNameTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardDatabaseCredencialsTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardDatabaseBCTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardPreconfiguredDBTitle;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDatabaseHost;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDatabasePassword;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDatabaseUser;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDatabasePort;
        private MaterialSkin.Controls.MaterialButton BTNTestConnection;
        private PictureBox LBLCardDatabaseBCInfo;
        private PictureBox LBLCardPreconfiguredDBInfo;
        private PictureBox LBLCardTableNameInfo;
        private PictureBox LBLCardDatabaseCredencialsInfo;
        private MaterialSkin.Controls.MaterialTextBox2 TXTWorldDatabase;
        private MaterialSkin.Controls.MaterialTextBox2 TXTCharDatabase;
        private MaterialSkin.Controls.MaterialTextBox2 TXTAuthDatabase;
        private MaterialSkin.Controls.MaterialButton BTNDeleteWorld;
        private MaterialSkin.Controls.MaterialButton BTNDeleteChar;
        private MaterialSkin.Controls.MaterialButton BTNDeleteAuth;
        private MaterialSkin.Controls.MaterialSwitch TGLCustomDB;
        private MaterialSkin.Controls.MaterialSwitch TGLMopDB;
        private MaterialSkin.Controls.MaterialSwitch TGLCataDB;
        private MaterialSkin.Controls.MaterialSwitch TGLWotlkDB;
        private MaterialSkin.Controls.MaterialSwitch TGLTbcDB;
        private MaterialSkin.Controls.MaterialSwitch TGLClassicDB;
        private MaterialSkin.Controls.MaterialButton BTNFixDatabase;
        private MaterialSkin.Controls.MaterialButton BTNLoadBackup;
        private MaterialSkin.Controls.MaterialButton BTNDatabaseBackup;
        private MaterialSkin.Controls.MaterialSwitch TGLWorldBackup;
        private MaterialSkin.Controls.MaterialSwitch TGLCharBackup;
        private MaterialSkin.Controls.MaterialSwitch TGLAuthBackup;
        private TabPage TabDDNS;
        private TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialCard materialCard20;
        private MaterialSkin.Controls.MaterialCard materialCard19;
        private MaterialSkin.Controls.MaterialLabel LBLCardDDNSTimerTitle;
        private MaterialSkin.Controls.MaterialLabel LBLCardDDNSSettingsTitle;
        private PictureBox LBLCardDDNSTimerInfos;
        private PictureBox LBLCardDDNSSettingsInfo;
        private MaterialSkin.Controls.MaterialComboBox CBOXDDNService;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDDNSPassword;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDDNSUsername;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDDNSDomain;
        private MaterialSkin.Controls.MaterialTextBox2 TXTDDNSInterval;
        private MaterialSkin.Controls.MaterialSwitch TGLDDNSRunOnStartup;
        private MaterialSkin.Controls.MaterialButton BTNDDNSTimerStart;
        private MaterialSkin.Controls.MaterialButton BTNDDNSServiceWebiste;
        private TableLayoutPanel tableLayoutPanel10;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Label LBLMoPVersion;
        private Label LBLCataVersion;
        private Label LBLWotLKVersion;
        private Label LBLTBCVersion;
        private Label LBLClassicVersion;
        private Label LBLDBVersion;
        private Label LBLTrionVersion;
        private TabPage TabNotification;
        private TableLayoutPanel tableLayoutPanel11;
        private DataGridView DGVNotifications;
        private UI.Controls.CustomButton BTNClean;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Message;
        private DataGridViewTextBoxColumn Time;
    }
}