namespace DISM_GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLogDISMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSurLeWIMMontéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerLeWIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utiliserLeModeOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabGestion = new System.Windows.Forms.TabControl();
            this.GestionMontage = new System.Windows.Forms.TabPage();
            this.BtnOuvrirDossierMonte = new System.Windows.Forms.Button();
            this.BtnDemonterWim = new System.Windows.Forms.Button();
            this.BtnMonterWim = new System.Windows.Forms.Button();
            this.LblIndex = new System.Windows.Forms.Label();
            this.CmbBoxIndex = new System.Windows.Forms.ComboBox();
            this.chkMountReadOnly = new System.Windows.Forms.CheckBox();
            this.AfficheWimInfos = new System.Windows.Forms.Button();
            this.BtnChoisirDossier = new System.Windows.Forms.Button();
            this.BtnChoisirWim = new System.Windows.Forms.Button();
            this.TxtDossierMontage = new System.Windows.Forms.TextBox();
            this.LblDossierMontage = new System.Windows.Forms.Label();
            this.LblFichierWim = new System.Windows.Forms.Label();
            this.TxtFichierWim = new System.Windows.Forms.TextBox();
            this.GestionPilotes = new System.Windows.Forms.TabPage();
            this.BtnAfficheTousPilotes = new System.Windows.Forms.Button();
            this.BtnAffichePilotesWim = new System.Windows.Forms.Button();
            this.groupBoxSupprimerPilotes = new System.Windows.Forms.GroupBox();
            this.BtnSupprimePilote = new System.Windows.Forms.Button();
            this.TxtBoxNomPilote = new System.Windows.Forms.TextBox();
            this.groupBoxAjouterPilotes = new System.Windows.Forms.GroupBox();
            this.btnAjouterPilotes = new System.Windows.Forms.Button();
            this.LblCheminPilote = new System.Windows.Forms.Label();
            this.BtnChoixDossierPilote = new System.Windows.Forms.Button();
            this.TxtBoxDossierPilotes = new System.Windows.Forms.TextBox();
            this.ChkBoxRecurse = new System.Windows.Forms.CheckBox();
            this.ChkBoxForceUnsigned = new System.Windows.Forms.CheckBox();
            this.GestionPackage = new System.Windows.Forms.TabPage();
            this.BtnAffichePackagesWim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSupprimePackageBis = new System.Windows.Forms.Button();
            this.BtnSupprimePackage = new System.Windows.Forms.Button();
            this.LblDossierPackagebis = new System.Windows.Forms.Label();
            this.LblNomPackage = new System.Windows.Forms.Label();
            this.TxtBoxDossierPackageBis = new System.Windows.Forms.TextBox();
            this.TxtBoxNomPackage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAjoutPackage = new System.Windows.Forms.Button();
            this.BtnChoisirDossierPackage = new System.Windows.Forms.Button();
            this.ChkBoxIgnoreVerification = new System.Windows.Forms.CheckBox();
            this.LblDossierPackage = new System.Windows.Forms.Label();
            this.TxtBoxDossierPackage = new System.Windows.Forms.TextBox();
            this.GestionFeature = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDisableFeature = new System.Windows.Forms.Button();
            this.BtnEnableFeature = new System.Windows.Forms.Button();
            this.BtnAfficheFeatureWim = new System.Windows.Forms.Button();
            this.ChkBoxEnablePackagePath = new System.Windows.Forms.CheckBox();
            this.ChkBoxEnablePackageName = new System.Windows.Forms.CheckBox();
            this.TxtBoxFolderPackage = new System.Windows.Forms.TextBox();
            this.TxtBoxFeaturePackageName = new System.Windows.Forms.TextBox();
            this.TxtBoxFeatureName = new System.Windows.Forms.TextBox();
            this.ServiceEdition = new System.Windows.Forms.TabPage();
            this.LblEdition = new System.Windows.Forms.Label();
            this.LblProductKey = new System.Windows.Forms.Label();
            this.BtnFixeEdition = new System.Windows.Forms.Button();
            this.BtnFixeCleProduit = new System.Windows.Forms.Button();
            this.BtnAfficheEditionCible = new System.Windows.Forms.Button();
            this.BtnAfficheEditionCourante = new System.Windows.Forms.Button();
            this.TxtBoxEdition = new System.Windows.Forms.TextBox();
            this.TxtBoxProductKey = new System.Windows.Forms.TextBox();
            this.ServiceUnattend = new System.Windows.Forms.TabPage();
            this.BtnAppliqueUnattendXML = new System.Windows.Forms.Button();
            this.BtnChoisirXMLUnattend = new System.Windows.Forms.Button();
            this.TxtBoxFichierXMLUnattend = new System.Windows.Forms.TextBox();
            this.LblFichierXMLUnattend = new System.Windows.Forms.Label();
            this.ServiceApplication = new System.Windows.Forms.TabPage();
            this.BtnVerifierPatchsApplication = new System.Windows.Forms.Button();
            this.LblFichierMSP = new System.Windows.Forms.Label();
            this.LblPatchCode = new System.Windows.Forms.Label();
            this.LblCodeProduit = new System.Windows.Forms.Label();
            this.BtnChoisirFichierMSP = new System.Windows.Forms.Button();
            this.BtnAfficheInfosPatchsApplications = new System.Windows.Forms.Button();
            this.BtnAfficheApplicationsPatch = new System.Windows.Forms.Button();
            this.BtnAfficheInfosApplications = new System.Windows.Forms.Button();
            this.btnAfficheApplication = new System.Windows.Forms.Button();
            this.TxtBoxNomFichierMSP = new System.Windows.Forms.TextBox();
            this.TxtBoxPatchCode = new System.Windows.Forms.TextBox();
            this.TxtBoxCodeProduit = new System.Windows.Forms.TextBox();
            this.CaptureImage = new System.Windows.Forms.TabPage();
            this.LblDescriptionWIM = new System.Windows.Forms.Label();
            this.TxtBoxCaptureDescriptionWIM = new System.Windows.Forms.TextBox();
            this.ChkBoxCaptureVerifier = new System.Windows.Forms.CheckBox();
            this.LblCompression = new System.Windows.Forms.Label();
            this.LblNomFichierWIM = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.LblSource = new System.Windows.Forms.Label();
            this.CmbBoxCaptureCompression = new System.Windows.Forms.ComboBox();
            this.TxtBoxCaptureNomFichier = new System.Windows.Forms.TextBox();
            this.TxtBoxCaptureDestination = new System.Windows.Forms.TextBox();
            this.TxtBoxCaptureSource = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnCreer = new System.Windows.Forms.Button();
            this.ParcourirDestination = new System.Windows.Forms.Button();
            this.BtnParcourirSource = new System.Windows.Forms.Button();
            this.AppliqueImage = new System.Windows.Forms.TabPage();
            this.ChkBoxApplyVerifier = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBoxApplyIndex = new System.Windows.Forms.ComboBox();
            this.LblDestinationBis = new System.Windows.Forms.Label();
            this.LblSourceBis = new System.Windows.Forms.Label();
            this.TxtBoxApplyDestination = new System.Windows.Forms.TextBox();
            this.BtnAppliquerImage = new System.Windows.Forms.Button();
            this.BtnApplyParcourirDestination = new System.Windows.Forms.Button();
            this.TxtBoxApplySource = new System.Windows.Forms.TextBox();
            this.BtnApplyParcourirSource = new System.Windows.Forms.Button();
            this.ExportImage = new System.Windows.Forms.TabPage();
            this.LblExportName = new System.Windows.Forms.Label();
            this.TxtBoxNomFichier = new System.Windows.Forms.TextBox();
            this.ChkBoxExportCheckIntegrity = new System.Windows.Forms.CheckBox();
            this.ChkBoxExportWimBoot = new System.Windows.Forms.CheckBox();
            this.ChkBoxExportBootable = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbBoxExportCompression = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBoxExportIndex = new System.Windows.Forms.ComboBox();
            this.LblExportDestination = new System.Windows.Forms.Label();
            this.LblExportSource = new System.Windows.Forms.Label();
            this.TxtBoxExportDestination = new System.Windows.Forms.TextBox();
            this.BtnExportImage = new System.Windows.Forms.Button();
            this.BtnExportChoisirDossier = new System.Windows.Forms.Button();
            this.TxtBoxExportSourceFichier = new System.Windows.Forms.TextBox();
            this.BtnExportChoisirFichier = new System.Windows.Forms.Button();
            this.GestionLangue = new System.Windows.Forms.TabPage();
            this.BtnAllIntrlAppliquer = new System.Windows.Forms.Button();
            this.TxtBoxAllIntl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnInfosLangue = new System.Windows.Forms.Button();
            this.ExportDriver = new System.Windows.Forms.TabPage();
            this.BtnExportDriverOnline = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBoxExportDossierDriverOnline = new System.Windows.Forms.TextBox();
            this.BtnExportDriverChoisirDossierOnline = new System.Windows.Forms.Button();
            this.BtnExportDriverOffline = new System.Windows.Forms.Button();
            this.LblExportChoisirDossier = new System.Windows.Forms.Label();
            this.TxtBoxExportDossierDriverOffline = new System.Windows.Forms.TextBox();
            this.BtnExportDriverChoisirDossierOffline = new System.Windows.Forms.Button();
            this.OpenFileDialogue_ChoisirWIM = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_ChoisirDossier = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerMount = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerDismCommand = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerDismount = new System.ComponentModel.BackgroundWorker();
            this.BtnEffaceConsoleDism = new System.Windows.Forms.Button();
            this.OpenFileDialog_ChoisirMSP = new System.Windows.Forms.OpenFileDialog();
            this.TxtBox_DISMVersion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TabGestion.SuspendLayout();
            this.GestionMontage.SuspendLayout();
            this.GestionPilotes.SuspendLayout();
            this.groupBoxSupprimerPilotes.SuspendLayout();
            this.groupBoxAjouterPilotes.SuspendLayout();
            this.GestionPackage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GestionFeature.SuspendLayout();
            this.ServiceEdition.SuspendLayout();
            this.ServiceUnattend.SuspendLayout();
            this.ServiceApplication.SuspendLayout();
            this.CaptureImage.SuspendLayout();
            this.AppliqueImage.SuspendLayout();
            this.ExportImage.SuspendLayout();
            this.GestionLangue.SuspendLayout();
            this.ExportDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLogDISMToolStripMenuItem,
            this.informationSurLeWIMMontéToolStripMenuItem,
            this.nettoyerLeWIMToolStripMenuItem,
            this.nettoyerLimageToolStripMenuItem,
            this.utiliserLeModeOnlineToolStripMenuItem,
            this.aProposDeToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 25);
            this.toolStripMenuItem1.Text = "Outils";
            // 
            // ouvrirLogDISMToolStripMenuItem
            // 
            this.ouvrirLogDISMToolStripMenuItem.Name = "ouvrirLogDISMToolStripMenuItem";
            this.ouvrirLogDISMToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.ouvrirLogDISMToolStripMenuItem.Text = "Ouvrir le journal DISM";
            this.ouvrirLogDISMToolStripMenuItem.Click += new System.EventHandler(this.OuvrirLogDISMToolStripMenuItem_Click);
            // 
            // informationSurLeWIMMontéToolStripMenuItem
            // 
            this.informationSurLeWIMMontéToolStripMenuItem.Name = "informationSurLeWIMMontéToolStripMenuItem";
            this.informationSurLeWIMMontéToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.informationSurLeWIMMontéToolStripMenuItem.Text = "Informations  WIMs montés";
            this.informationSurLeWIMMontéToolStripMenuItem.Click += new System.EventHandler(this.informationSurLeWIMMontéToolStripMenuItem_Click);
            // 
            // nettoyerLeWIMToolStripMenuItem
            // 
            this.nettoyerLeWIMToolStripMenuItem.Name = "nettoyerLeWIMToolStripMenuItem";
            this.nettoyerLeWIMToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.nettoyerLeWIMToolStripMenuItem.Text = "Nettoyer le WIM";
            this.nettoyerLeWIMToolStripMenuItem.Click += new System.EventHandler(this.nettoyerLeWIMToolStripMenuItem_Click);
            // 
            // nettoyerLimageToolStripMenuItem
            // 
            this.nettoyerLimageToolStripMenuItem.Name = "nettoyerLimageToolStripMenuItem";
            this.nettoyerLimageToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.nettoyerLimageToolStripMenuItem.Text = "Nettoyer l\'image";
            this.nettoyerLimageToolStripMenuItem.Click += new System.EventHandler(this.nettoyerLimageToolStripMenuItem_Click);
            // 
            // utiliserLeModeOnlineToolStripMenuItem
            // 
            this.utiliserLeModeOnlineToolStripMenuItem.Name = "utiliserLeModeOnlineToolStripMenuItem";
            this.utiliserLeModeOnlineToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.utiliserLeModeOnlineToolStripMenuItem.Text = "Utiliser le mode Online";
            this.utiliserLeModeOnlineToolStripMenuItem.Click += new System.EventHandler(this.utiliserLeModeOnlineToolStripMenuItem_Click);
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.aProposDeToolStripMenuItem.Text = "A propos de";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // TabGestion
            // 
            this.TabGestion.Controls.Add(this.GestionMontage);
            this.TabGestion.Controls.Add(this.GestionPilotes);
            this.TabGestion.Controls.Add(this.GestionPackage);
            this.TabGestion.Controls.Add(this.GestionFeature);
            this.TabGestion.Controls.Add(this.ServiceEdition);
            this.TabGestion.Controls.Add(this.ServiceUnattend);
            this.TabGestion.Controls.Add(this.ServiceApplication);
            this.TabGestion.Controls.Add(this.CaptureImage);
            this.TabGestion.Controls.Add(this.AppliqueImage);
            this.TabGestion.Controls.Add(this.ExportImage);
            this.TabGestion.Controls.Add(this.GestionLangue);
            this.TabGestion.Controls.Add(this.ExportDriver);
            this.TabGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGestion.Location = new System.Drawing.Point(0, 27);
            this.TabGestion.Name = "TabGestion";
            this.TabGestion.SelectedIndex = 0;
            this.TabGestion.Size = new System.Drawing.Size(890, 290);
            this.TabGestion.TabIndex = 1;
            // 
            // GestionMontage
            // 
            this.GestionMontage.Controls.Add(this.BtnOuvrirDossierMonte);
            this.GestionMontage.Controls.Add(this.BtnDemonterWim);
            this.GestionMontage.Controls.Add(this.BtnMonterWim);
            this.GestionMontage.Controls.Add(this.LblIndex);
            this.GestionMontage.Controls.Add(this.CmbBoxIndex);
            this.GestionMontage.Controls.Add(this.chkMountReadOnly);
            this.GestionMontage.Controls.Add(this.AfficheWimInfos);
            this.GestionMontage.Controls.Add(this.BtnChoisirDossier);
            this.GestionMontage.Controls.Add(this.BtnChoisirWim);
            this.GestionMontage.Controls.Add(this.TxtDossierMontage);
            this.GestionMontage.Controls.Add(this.LblDossierMontage);
            this.GestionMontage.Controls.Add(this.LblFichierWim);
            this.GestionMontage.Controls.Add(this.TxtFichierWim);
            this.GestionMontage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionMontage.Location = new System.Drawing.Point(4, 29);
            this.GestionMontage.Name = "GestionMontage";
            this.GestionMontage.Padding = new System.Windows.Forms.Padding(3);
            this.GestionMontage.Size = new System.Drawing.Size(882, 257);
            this.GestionMontage.TabIndex = 0;
            this.GestionMontage.Text = "Gestion Montage";
            this.GestionMontage.UseVisualStyleBackColor = true;
            // 
            // BtnOuvrirDossierMonte
            // 
            this.BtnOuvrirDossierMonte.Location = new System.Drawing.Point(637, 122);
            this.BtnOuvrirDossierMonte.Name = "BtnOuvrirDossierMonte";
            this.BtnOuvrirDossierMonte.Size = new System.Drawing.Size(168, 50);
            this.BtnOuvrirDossierMonte.TabIndex = 14;
            this.BtnOuvrirDossierMonte.Text = "Ouvrir dossier monté";
            this.BtnOuvrirDossierMonte.UseVisualStyleBackColor = true;
            this.BtnOuvrirDossierMonte.Click += new System.EventHandler(this.BtnOuvrirDossierMonte_Click);
            // 
            // BtnDemonterWim
            // 
            this.BtnDemonterWim.Enabled = false;
            this.BtnDemonterWim.Location = new System.Drawing.Point(637, 70);
            this.BtnDemonterWim.Name = "BtnDemonterWim";
            this.BtnDemonterWim.Size = new System.Drawing.Size(168, 46);
            this.BtnDemonterWim.TabIndex = 13;
            this.BtnDemonterWim.Text = "Démonter WIM";
            this.BtnDemonterWim.UseVisualStyleBackColor = true;
            this.BtnDemonterWim.Click += new System.EventHandler(this.BtnDemonterWim_Click);
            // 
            // BtnMonterWim
            // 
            this.BtnMonterWim.Location = new System.Drawing.Point(637, 19);
            this.BtnMonterWim.Name = "BtnMonterWim";
            this.BtnMonterWim.Size = new System.Drawing.Size(168, 45);
            this.BtnMonterWim.TabIndex = 12;
            this.BtnMonterWim.Text = "Monter Wim";
            this.BtnMonterWim.UseVisualStyleBackColor = true;
            this.BtnMonterWim.Click += new System.EventHandler(this.BtnMonterWim_Click);
            // 
            // LblIndex
            // 
            this.LblIndex.AutoSize = true;
            this.LblIndex.Location = new System.Drawing.Point(552, 3);
            this.LblIndex.Name = "LblIndex";
            this.LblIndex.Size = new System.Drawing.Size(48, 20);
            this.LblIndex.TabIndex = 11;
            this.LblIndex.Text = "Index";
            // 
            // CmbBoxIndex
            // 
            this.CmbBoxIndex.FormattingEnabled = true;
            this.CmbBoxIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbBoxIndex.Location = new System.Drawing.Point(555, 28);
            this.CmbBoxIndex.Name = "CmbBoxIndex";
            this.CmbBoxIndex.Size = new System.Drawing.Size(45, 28);
            this.CmbBoxIndex.TabIndex = 10;
            // 
            // chkMountReadOnly
            // 
            this.chkMountReadOnly.AutoSize = true;
            this.chkMountReadOnly.Location = new System.Drawing.Point(12, 148);
            this.chkMountReadOnly.Name = "chkMountReadOnly";
            this.chkMountReadOnly.Size = new System.Drawing.Size(124, 24);
            this.chkMountReadOnly.TabIndex = 9;
            this.chkMountReadOnly.Text = "Lecture seule";
            this.chkMountReadOnly.UseVisualStyleBackColor = true;
            // 
            // AfficheWimInfos
            // 
            this.AfficheWimInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficheWimInfos.Location = new System.Drawing.Point(194, 60);
            this.AfficheWimInfos.Name = "AfficheWimInfos";
            this.AfficheWimInfos.Size = new System.Drawing.Size(169, 26);
            this.AfficheWimInfos.TabIndex = 8;
            this.AfficheWimInfos.Text = "Affiche WIM Infos";
            this.AfficheWimInfos.UseVisualStyleBackColor = true;
            this.AfficheWimInfos.Click += new System.EventHandler(this.AfficheWimInfos_Click);
            // 
            // BtnChoisirDossier
            // 
            this.BtnChoisirDossier.Location = new System.Drawing.Point(410, 103);
            this.BtnChoisirDossier.Name = "BtnChoisirDossier";
            this.BtnChoisirDossier.Size = new System.Drawing.Size(125, 26);
            this.BtnChoisirDossier.TabIndex = 7;
            this.BtnChoisirDossier.Text = "Choisir Dossier";
            this.BtnChoisirDossier.UseVisualStyleBackColor = true;
            this.BtnChoisirDossier.Click += new System.EventHandler(this.BtnChoisirDossier_Click);
            // 
            // BtnChoisirWim
            // 
            this.BtnChoisirWim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoisirWim.Location = new System.Drawing.Point(410, 28);
            this.BtnChoisirWim.Name = "BtnChoisirWim";
            this.BtnChoisirWim.Size = new System.Drawing.Size(125, 26);
            this.BtnChoisirWim.TabIndex = 6;
            this.BtnChoisirWim.Text = "Choisir WIM";
            this.BtnChoisirWim.UseVisualStyleBackColor = true;
            this.BtnChoisirWim.Click += new System.EventHandler(this.BtnChoisirWim_Click);
            // 
            // TxtDossierMontage
            // 
            this.TxtDossierMontage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDossierMontage.Location = new System.Drawing.Point(148, 103);
            this.TxtDossierMontage.Name = "TxtDossierMontage";
            this.TxtDossierMontage.Size = new System.Drawing.Size(256, 26);
            this.TxtDossierMontage.TabIndex = 5;
            // 
            // LblDossierMontage
            // 
            this.LblDossierMontage.AutoSize = true;
            this.LblDossierMontage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDossierMontage.Location = new System.Drawing.Point(8, 109);
            this.LblDossierMontage.Name = "LblDossierMontage";
            this.LblDossierMontage.Size = new System.Drawing.Size(134, 20);
            this.LblDossierMontage.TabIndex = 4;
            this.LblDossierMontage.Text = "Dossier Montage:";
            // 
            // LblFichierWim
            // 
            this.LblFichierWim.AutoSize = true;
            this.LblFichierWim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFichierWim.Location = new System.Drawing.Point(6, 31);
            this.LblFichierWim.Name = "LblFichierWim";
            this.LblFichierWim.Size = new System.Drawing.Size(95, 20);
            this.LblFichierWim.TabIndex = 3;
            this.LblFichierWim.Text = "Fichier Wim:";
            // 
            // TxtFichierWim
            // 
            this.TxtFichierWim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFichierWim.Location = new System.Drawing.Point(148, 28);
            this.TxtFichierWim.Name = "TxtFichierWim";
            this.TxtFichierWim.Size = new System.Drawing.Size(256, 26);
            this.TxtFichierWim.TabIndex = 2;
            // 
            // GestionPilotes
            // 
            this.GestionPilotes.Controls.Add(this.BtnAfficheTousPilotes);
            this.GestionPilotes.Controls.Add(this.BtnAffichePilotesWim);
            this.GestionPilotes.Controls.Add(this.groupBoxSupprimerPilotes);
            this.GestionPilotes.Controls.Add(this.groupBoxAjouterPilotes);
            this.GestionPilotes.Location = new System.Drawing.Point(4, 29);
            this.GestionPilotes.Name = "GestionPilotes";
            this.GestionPilotes.Padding = new System.Windows.Forms.Padding(3);
            this.GestionPilotes.Size = new System.Drawing.Size(882, 257);
            this.GestionPilotes.TabIndex = 1;
            this.GestionPilotes.Text = "Gestion des drivers";
            this.GestionPilotes.UseVisualStyleBackColor = true;
            // 
            // BtnAfficheTousPilotes
            // 
            this.BtnAfficheTousPilotes.Location = new System.Drawing.Point(678, 107);
            this.BtnAfficheTousPilotes.Name = "BtnAfficheTousPilotes";
            this.BtnAfficheTousPilotes.Size = new System.Drawing.Size(172, 77);
            this.BtnAfficheTousPilotes.TabIndex = 6;
            this.BtnAfficheTousPilotes.Text = "Affiche tous les pilotes présent dans le WIM";
            this.BtnAfficheTousPilotes.UseVisualStyleBackColor = true;
            this.BtnAfficheTousPilotes.Click += new System.EventHandler(this.BtnAfficheTousPilotes_Click);
            // 
            // BtnAffichePilotesWim
            // 
            this.BtnAffichePilotesWim.Location = new System.Drawing.Point(678, 6);
            this.BtnAffichePilotesWim.Name = "BtnAffichePilotesWim";
            this.BtnAffichePilotesWim.Size = new System.Drawing.Size(172, 82);
            this.BtnAffichePilotesWim.TabIndex = 5;
            this.BtnAffichePilotesWim.Text = "Affiche les pilotes tiers présent dans le WIM";
            this.BtnAffichePilotesWim.UseVisualStyleBackColor = true;
            this.BtnAffichePilotesWim.Click += new System.EventHandler(this.BtnAffichePilotesWim_Click);
            // 
            // groupBoxSupprimerPilotes
            // 
            this.groupBoxSupprimerPilotes.Controls.Add(this.BtnSupprimePilote);
            this.groupBoxSupprimerPilotes.Controls.Add(this.TxtBoxNomPilote);
            this.groupBoxSupprimerPilotes.Location = new System.Drawing.Point(12, 172);
            this.groupBoxSupprimerPilotes.Name = "groupBoxSupprimerPilotes";
            this.groupBoxSupprimerPilotes.Size = new System.Drawing.Size(623, 69);
            this.groupBoxSupprimerPilotes.TabIndex = 0;
            this.groupBoxSupprimerPilotes.TabStop = false;
            this.groupBoxSupprimerPilotes.Text = "Supprimer pilotes (nom publié)";
            // 
            // BtnSupprimePilote
            // 
            this.BtnSupprimePilote.Location = new System.Drawing.Point(435, 25);
            this.BtnSupprimePilote.Name = "BtnSupprimePilote";
            this.BtnSupprimePilote.Size = new System.Drawing.Size(172, 26);
            this.BtnSupprimePilote.TabIndex = 5;
            this.BtnSupprimePilote.Text = "Supprimer pilote";
            this.BtnSupprimePilote.UseVisualStyleBackColor = true;
            this.BtnSupprimePilote.Click += new System.EventHandler(this.BtnSupprimePilote_Click);
            // 
            // TxtBoxNomPilote
            // 
            this.TxtBoxNomPilote.Location = new System.Drawing.Point(6, 25);
            this.TxtBoxNomPilote.Name = "TxtBoxNomPilote";
            this.TxtBoxNomPilote.Size = new System.Drawing.Size(423, 26);
            this.TxtBoxNomPilote.TabIndex = 0;
            // 
            // groupBoxAjouterPilotes
            // 
            this.groupBoxAjouterPilotes.Controls.Add(this.btnAjouterPilotes);
            this.groupBoxAjouterPilotes.Controls.Add(this.LblCheminPilote);
            this.groupBoxAjouterPilotes.Controls.Add(this.BtnChoixDossierPilote);
            this.groupBoxAjouterPilotes.Controls.Add(this.TxtBoxDossierPilotes);
            this.groupBoxAjouterPilotes.Controls.Add(this.ChkBoxRecurse);
            this.groupBoxAjouterPilotes.Controls.Add(this.ChkBoxForceUnsigned);
            this.groupBoxAjouterPilotes.Location = new System.Drawing.Point(12, 6);
            this.groupBoxAjouterPilotes.Name = "groupBoxAjouterPilotes";
            this.groupBoxAjouterPilotes.Size = new System.Drawing.Size(623, 160);
            this.groupBoxAjouterPilotes.TabIndex = 0;
            this.groupBoxAjouterPilotes.TabStop = false;
            this.groupBoxAjouterPilotes.Text = "Ajouter pilotes";
            // 
            // btnAjouterPilotes
            // 
            this.btnAjouterPilotes.Location = new System.Drawing.Point(296, 101);
            this.btnAjouterPilotes.Name = "btnAjouterPilotes";
            this.btnAjouterPilotes.Size = new System.Drawing.Size(133, 40);
            this.btnAjouterPilotes.TabIndex = 5;
            this.btnAjouterPilotes.Text = "Ajouter pilotes";
            this.btnAjouterPilotes.UseVisualStyleBackColor = true;
            this.btnAjouterPilotes.Click += new System.EventHandler(this.btnAjouterPilotes_Click);
            // 
            // LblCheminPilote
            // 
            this.LblCheminPilote.AutoSize = true;
            this.LblCheminPilote.Location = new System.Drawing.Point(6, 34);
            this.LblCheminPilote.Name = "LblCheminPilote";
            this.LblCheminPilote.Size = new System.Drawing.Size(113, 20);
            this.LblCheminPilote.TabIndex = 1;
            this.LblCheminPilote.Text = "Dossier pilotes";
            // 
            // BtnChoixDossierPilote
            // 
            this.BtnChoixDossierPilote.Location = new System.Drawing.Point(435, 56);
            this.BtnChoixDossierPilote.Name = "BtnChoixDossierPilote";
            this.BtnChoixDossierPilote.Size = new System.Drawing.Size(172, 26);
            this.BtnChoixDossierPilote.TabIndex = 4;
            this.BtnChoixDossierPilote.Text = "Choisir dossier pilotes";
            this.BtnChoixDossierPilote.UseVisualStyleBackColor = true;
            this.BtnChoixDossierPilote.Click += new System.EventHandler(this.BtnChoixDossierPilote_Click);
            // 
            // TxtBoxDossierPilotes
            // 
            this.TxtBoxDossierPilotes.Location = new System.Drawing.Point(6, 56);
            this.TxtBoxDossierPilotes.Name = "TxtBoxDossierPilotes";
            this.TxtBoxDossierPilotes.Size = new System.Drawing.Size(423, 26);
            this.TxtBoxDossierPilotes.TabIndex = 1;
            // 
            // ChkBoxRecurse
            // 
            this.ChkBoxRecurse.AutoSize = true;
            this.ChkBoxRecurse.Location = new System.Drawing.Point(171, 100);
            this.ChkBoxRecurse.Name = "ChkBoxRecurse";
            this.ChkBoxRecurse.Size = new System.Drawing.Size(88, 24);
            this.ChkBoxRecurse.TabIndex = 3;
            this.ChkBoxRecurse.Text = "Recurse";
            this.ChkBoxRecurse.UseVisualStyleBackColor = true;
            // 
            // ChkBoxForceUnsigned
            // 
            this.ChkBoxForceUnsigned.AutoSize = true;
            this.ChkBoxForceUnsigned.Location = new System.Drawing.Point(6, 100);
            this.ChkBoxForceUnsigned.Name = "ChkBoxForceUnsigned";
            this.ChkBoxForceUnsigned.Size = new System.Drawing.Size(150, 24);
            this.ChkBoxForceUnsigned.TabIndex = 2;
            this.ChkBoxForceUnsigned.Text = "Forced Unsigned";
            this.ChkBoxForceUnsigned.UseVisualStyleBackColor = true;
            // 
            // GestionPackage
            // 
            this.GestionPackage.Controls.Add(this.BtnAffichePackagesWim);
            this.GestionPackage.Controls.Add(this.groupBox2);
            this.GestionPackage.Controls.Add(this.groupBox1);
            this.GestionPackage.Location = new System.Drawing.Point(4, 29);
            this.GestionPackage.Name = "GestionPackage";
            this.GestionPackage.Size = new System.Drawing.Size(882, 257);
            this.GestionPackage.TabIndex = 2;
            this.GestionPackage.Text = "Gestion des packages";
            this.GestionPackage.UseVisualStyleBackColor = true;
            // 
            // BtnAffichePackagesWim
            // 
            this.BtnAffichePackagesWim.Location = new System.Drawing.Point(750, 19);
            this.BtnAffichePackagesWim.Name = "BtnAffichePackagesWim";
            this.BtnAffichePackagesWim.Size = new System.Drawing.Size(117, 85);
            this.BtnAffichePackagesWim.TabIndex = 4;
            this.BtnAffichePackagesWim.Text = "Affiche les packages du WIM";
            this.BtnAffichePackagesWim.UseVisualStyleBackColor = true;
            this.BtnAffichePackagesWim.Click += new System.EventHandler(this.BtnAffichePackagesWim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSupprimePackageBis);
            this.groupBox2.Controls.Add(this.BtnSupprimePackage);
            this.groupBox2.Controls.Add(this.LblDossierPackagebis);
            this.groupBox2.Controls.Add(this.LblNomPackage);
            this.groupBox2.Controls.Add(this.TxtBoxDossierPackageBis);
            this.groupBox2.Controls.Add(this.TxtBoxNomPackage);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer Packages";
            // 
            // BtnSupprimePackageBis
            // 
            this.BtnSupprimePackageBis.Location = new System.Drawing.Point(539, 109);
            this.BtnSupprimePackageBis.Name = "BtnSupprimePackageBis";
            this.BtnSupprimePackageBis.Size = new System.Drawing.Size(187, 26);
            this.BtnSupprimePackageBis.TabIndex = 8;
            this.BtnSupprimePackageBis.Text = "Supprime Package";
            this.BtnSupprimePackageBis.UseVisualStyleBackColor = true;
            this.BtnSupprimePackageBis.Click += new System.EventHandler(this.BtnSupprimePackageBis_Click);
            // 
            // BtnSupprimePackage
            // 
            this.BtnSupprimePackage.Location = new System.Drawing.Point(539, 45);
            this.BtnSupprimePackage.Name = "BtnSupprimePackage";
            this.BtnSupprimePackage.Size = new System.Drawing.Size(187, 26);
            this.BtnSupprimePackage.TabIndex = 7;
            this.BtnSupprimePackage.Text = "Supprime Package";
            this.BtnSupprimePackage.UseVisualStyleBackColor = true;
            this.BtnSupprimePackage.Click += new System.EventHandler(this.BtnSupprimePackage_Click);
            // 
            // LblDossierPackagebis
            // 
            this.LblDossierPackagebis.AutoSize = true;
            this.LblDossierPackagebis.Location = new System.Drawing.Point(7, 86);
            this.LblDossierPackagebis.Name = "LblDossierPackagebis";
            this.LblDossierPackagebis.Size = new System.Drawing.Size(151, 20);
            this.LblDossierPackagebis.TabIndex = 6;
            this.LblDossierPackagebis.Text = "Dossier du Package";
            // 
            // LblNomPackage
            // 
            this.LblNomPackage.AutoSize = true;
            this.LblNomPackage.Location = new System.Drawing.Point(7, 22);
            this.LblNomPackage.Name = "LblNomPackage";
            this.LblNomPackage.Size = new System.Drawing.Size(130, 20);
            this.LblNomPackage.TabIndex = 5;
            this.LblNomPackage.Text = "Nom du Package";
            // 
            // TxtBoxDossierPackageBis
            // 
            this.TxtBoxDossierPackageBis.Location = new System.Drawing.Point(10, 109);
            this.TxtBoxDossierPackageBis.Name = "TxtBoxDossierPackageBis";
            this.TxtBoxDossierPackageBis.Size = new System.Drawing.Size(522, 26);
            this.TxtBoxDossierPackageBis.TabIndex = 4;
            // 
            // TxtBoxNomPackage
            // 
            this.TxtBoxNomPackage.Location = new System.Drawing.Point(11, 45);
            this.TxtBoxNomPackage.Name = "TxtBoxNomPackage";
            this.TxtBoxNomPackage.Size = new System.Drawing.Size(522, 26);
            this.TxtBoxNomPackage.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAjoutPackage);
            this.groupBox1.Controls.Add(this.BtnChoisirDossierPackage);
            this.groupBox1.Controls.Add(this.ChkBoxIgnoreVerification);
            this.groupBox1.Controls.Add(this.LblDossierPackage);
            this.groupBox1.Controls.Add(this.TxtBoxDossierPackage);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Packages";
            // 
            // BtnAjoutPackage
            // 
            this.BtnAjoutPackage.Location = new System.Drawing.Point(210, 75);
            this.BtnAjoutPackage.Name = "BtnAjoutPackage";
            this.BtnAjoutPackage.Size = new System.Drawing.Size(187, 26);
            this.BtnAjoutPackage.TabIndex = 6;
            this.BtnAjoutPackage.Text = "Ajouter Package";
            this.BtnAjoutPackage.UseVisualStyleBackColor = true;
            this.BtnAjoutPackage.Click += new System.EventHandler(this.BtnAjoutPackage_Click);
            // 
            // BtnChoisirDossierPackage
            // 
            this.BtnChoisirDossierPackage.Location = new System.Drawing.Point(539, 45);
            this.BtnChoisirDossierPackage.Name = "BtnChoisirDossierPackage";
            this.BtnChoisirDossierPackage.Size = new System.Drawing.Size(187, 26);
            this.BtnChoisirDossierPackage.TabIndex = 5;
            this.BtnChoisirDossierPackage.Text = "Choisir dossier package";
            this.BtnChoisirDossierPackage.UseVisualStyleBackColor = true;
            this.BtnChoisirDossierPackage.Click += new System.EventHandler(this.BtnChoisirDossierPackage_Click);
            // 
            // ChkBoxIgnoreVerification
            // 
            this.ChkBoxIgnoreVerification.AutoSize = true;
            this.ChkBoxIgnoreVerification.Location = new System.Drawing.Point(6, 77);
            this.ChkBoxIgnoreVerification.Name = "ChkBoxIgnoreVerification";
            this.ChkBoxIgnoreVerification.Size = new System.Drawing.Size(157, 24);
            this.ChkBoxIgnoreVerification.TabIndex = 2;
            this.ChkBoxIgnoreVerification.Text = "Ignore Vérification";
            this.ChkBoxIgnoreVerification.UseVisualStyleBackColor = true;
            // 
            // LblDossierPackage
            // 
            this.LblDossierPackage.AutoSize = true;
            this.LblDossierPackage.Location = new System.Drawing.Point(6, 22);
            this.LblDossierPackage.Name = "LblDossierPackage";
            this.LblDossierPackage.Size = new System.Drawing.Size(129, 20);
            this.LblDossierPackage.TabIndex = 3;
            this.LblDossierPackage.Text = "Dossier Package";
            // 
            // TxtBoxDossierPackage
            // 
            this.TxtBoxDossierPackage.Location = new System.Drawing.Point(6, 45);
            this.TxtBoxDossierPackage.Name = "TxtBoxDossierPackage";
            this.TxtBoxDossierPackage.Size = new System.Drawing.Size(527, 26);
            this.TxtBoxDossierPackage.TabIndex = 2;
            // 
            // GestionFeature
            // 
            this.GestionFeature.Controls.Add(this.label4);
            this.GestionFeature.Controls.Add(this.label3);
            this.GestionFeature.Controls.Add(this.label2);
            this.GestionFeature.Controls.Add(this.BtnDisableFeature);
            this.GestionFeature.Controls.Add(this.BtnEnableFeature);
            this.GestionFeature.Controls.Add(this.BtnAfficheFeatureWim);
            this.GestionFeature.Controls.Add(this.ChkBoxEnablePackagePath);
            this.GestionFeature.Controls.Add(this.ChkBoxEnablePackageName);
            this.GestionFeature.Controls.Add(this.TxtBoxFolderPackage);
            this.GestionFeature.Controls.Add(this.TxtBoxFeaturePackageName);
            this.GestionFeature.Controls.Add(this.TxtBoxFeatureName);
            this.GestionFeature.Location = new System.Drawing.Point(4, 29);
            this.GestionFeature.Name = "GestionFeature";
            this.GestionFeature.Size = new System.Drawing.Size(882, 257);
            this.GestionFeature.TabIndex = 3;
            this.GestionFeature.Text = "Gestion des features";
            this.GestionFeature.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dossier du package";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom du package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom du Feature";
            // 
            // BtnDisableFeature
            // 
            this.BtnDisableFeature.Location = new System.Drawing.Point(451, 163);
            this.BtnDisableFeature.Name = "BtnDisableFeature";
            this.BtnDisableFeature.Size = new System.Drawing.Size(240, 65);
            this.BtnDisableFeature.TabIndex = 7;
            this.BtnDisableFeature.Text = "Désactive un Feature";
            this.BtnDisableFeature.UseVisualStyleBackColor = true;
            this.BtnDisableFeature.Click += new System.EventHandler(this.BtnDisableFeature_Click);
            // 
            // BtnEnableFeature
            // 
            this.BtnEnableFeature.Location = new System.Drawing.Point(451, 87);
            this.BtnEnableFeature.Name = "BtnEnableFeature";
            this.BtnEnableFeature.Size = new System.Drawing.Size(240, 70);
            this.BtnEnableFeature.TabIndex = 6;
            this.BtnEnableFeature.Text = "Active un Feature";
            this.BtnEnableFeature.UseVisualStyleBackColor = true;
            this.BtnEnableFeature.Click += new System.EventHandler(this.BtnEnableFeature_Click);
            // 
            // BtnAfficheFeatureWim
            // 
            this.BtnAfficheFeatureWim.Location = new System.Drawing.Point(451, 16);
            this.BtnAfficheFeatureWim.Name = "BtnAfficheFeatureWim";
            this.BtnAfficheFeatureWim.Size = new System.Drawing.Size(240, 65);
            this.BtnAfficheFeatureWim.TabIndex = 5;
            this.BtnAfficheFeatureWim.Text = "Affiche les Features présent dans le WIM";
            this.BtnAfficheFeatureWim.UseVisualStyleBackColor = true;
            this.BtnAfficheFeatureWim.Click += new System.EventHandler(this.BtnAfficheFeatureWim_Click);
            // 
            // ChkBoxEnablePackagePath
            // 
            this.ChkBoxEnablePackagePath.AutoSize = true;
            this.ChkBoxEnablePackagePath.Location = new System.Drawing.Point(12, 179);
            this.ChkBoxEnablePackagePath.Name = "ChkBoxEnablePackagePath";
            this.ChkBoxEnablePackagePath.Size = new System.Drawing.Size(15, 14);
            this.ChkBoxEnablePackagePath.TabIndex = 4;
            this.ChkBoxEnablePackagePath.UseVisualStyleBackColor = true;
            // 
            // ChkBoxEnablePackageName
            // 
            this.ChkBoxEnablePackageName.AutoSize = true;
            this.ChkBoxEnablePackageName.Location = new System.Drawing.Point(12, 109);
            this.ChkBoxEnablePackageName.Name = "ChkBoxEnablePackageName";
            this.ChkBoxEnablePackageName.Size = new System.Drawing.Size(15, 14);
            this.ChkBoxEnablePackageName.TabIndex = 3;
            this.ChkBoxEnablePackageName.UseVisualStyleBackColor = true;
            // 
            // TxtBoxFolderPackage
            // 
            this.TxtBoxFolderPackage.Location = new System.Drawing.Point(33, 172);
            this.TxtBoxFolderPackage.Name = "TxtBoxFolderPackage";
            this.TxtBoxFolderPackage.Size = new System.Drawing.Size(385, 26);
            this.TxtBoxFolderPackage.TabIndex = 2;
            // 
            // TxtBoxFeaturePackageName
            // 
            this.TxtBoxFeaturePackageName.Location = new System.Drawing.Point(33, 106);
            this.TxtBoxFeaturePackageName.Name = "TxtBoxFeaturePackageName";
            this.TxtBoxFeaturePackageName.Size = new System.Drawing.Size(385, 26);
            this.TxtBoxFeaturePackageName.TabIndex = 1;
            // 
            // TxtBoxFeatureName
            // 
            this.TxtBoxFeatureName.Location = new System.Drawing.Point(33, 39);
            this.TxtBoxFeatureName.Name = "TxtBoxFeatureName";
            this.TxtBoxFeatureName.Size = new System.Drawing.Size(385, 26);
            this.TxtBoxFeatureName.TabIndex = 0;
            // 
            // ServiceEdition
            // 
            this.ServiceEdition.Controls.Add(this.LblEdition);
            this.ServiceEdition.Controls.Add(this.LblProductKey);
            this.ServiceEdition.Controls.Add(this.BtnFixeEdition);
            this.ServiceEdition.Controls.Add(this.BtnFixeCleProduit);
            this.ServiceEdition.Controls.Add(this.BtnAfficheEditionCible);
            this.ServiceEdition.Controls.Add(this.BtnAfficheEditionCourante);
            this.ServiceEdition.Controls.Add(this.TxtBoxEdition);
            this.ServiceEdition.Controls.Add(this.TxtBoxProductKey);
            this.ServiceEdition.Location = new System.Drawing.Point(4, 29);
            this.ServiceEdition.Name = "ServiceEdition";
            this.ServiceEdition.Size = new System.Drawing.Size(882, 257);
            this.ServiceEdition.TabIndex = 4;
            this.ServiceEdition.Text = "Service Edition";
            this.ServiceEdition.UseVisualStyleBackColor = true;
            // 
            // LblEdition
            // 
            this.LblEdition.AutoSize = true;
            this.LblEdition.Location = new System.Drawing.Point(27, 118);
            this.LblEdition.Name = "LblEdition";
            this.LblEdition.Size = new System.Drawing.Size(58, 20);
            this.LblEdition.TabIndex = 7;
            this.LblEdition.Text = "Edition";
            // 
            // LblProductKey
            // 
            this.LblProductKey.AutoSize = true;
            this.LblProductKey.Location = new System.Drawing.Point(27, 13);
            this.LblProductKey.Name = "LblProductKey";
            this.LblProductKey.Size = new System.Drawing.Size(86, 20);
            this.LblProductKey.TabIndex = 6;
            this.LblProductKey.Text = "Clé Produit";
            // 
            // BtnFixeEdition
            // 
            this.BtnFixeEdition.Location = new System.Drawing.Point(31, 173);
            this.BtnFixeEdition.Name = "BtnFixeEdition";
            this.BtnFixeEdition.Size = new System.Drawing.Size(138, 39);
            this.BtnFixeEdition.TabIndex = 5;
            this.BtnFixeEdition.Text = "Fixe édition";
            this.BtnFixeEdition.UseVisualStyleBackColor = true;
            this.BtnFixeEdition.Click += new System.EventHandler(this.BtnFixeEdition_Click);
            // 
            // BtnFixeCleProduit
            // 
            this.BtnFixeCleProduit.Location = new System.Drawing.Point(31, 68);
            this.BtnFixeCleProduit.Name = "BtnFixeCleProduit";
            this.BtnFixeCleProduit.Size = new System.Drawing.Size(138, 34);
            this.BtnFixeCleProduit.TabIndex = 4;
            this.BtnFixeCleProduit.Text = "Fixe clé produit";
            this.BtnFixeCleProduit.UseVisualStyleBackColor = true;
            this.BtnFixeCleProduit.Click += new System.EventHandler(this.BtnFixeCleProduit_Click);
            // 
            // BtnAfficheEditionCible
            // 
            this.BtnAfficheEditionCible.Location = new System.Drawing.Point(529, 130);
            this.BtnAfficheEditionCible.Name = "BtnAfficheEditionCible";
            this.BtnAfficheEditionCible.Size = new System.Drawing.Size(156, 49);
            this.BtnAfficheEditionCible.TabIndex = 3;
            this.BtnAfficheEditionCible.Text = "Affiche Les éditions cible";
            this.BtnAfficheEditionCible.UseVisualStyleBackColor = true;
            this.BtnAfficheEditionCible.Click += new System.EventHandler(this.BtnFixeEditionCible_Click);
            // 
            // BtnAfficheEditionCourante
            // 
            this.BtnAfficheEditionCourante.Location = new System.Drawing.Point(529, 21);
            this.BtnAfficheEditionCourante.Name = "BtnAfficheEditionCourante";
            this.BtnAfficheEditionCourante.Size = new System.Drawing.Size(156, 56);
            this.BtnAfficheEditionCourante.TabIndex = 2;
            this.BtnAfficheEditionCourante.Text = "Affiche édition courante";
            this.BtnAfficheEditionCourante.UseVisualStyleBackColor = true;
            this.BtnAfficheEditionCourante.Click += new System.EventHandler(this.BtnAfficheEditionCourante_Click);
            // 
            // TxtBoxEdition
            // 
            this.TxtBoxEdition.Location = new System.Drawing.Point(31, 141);
            this.TxtBoxEdition.Name = "TxtBoxEdition";
            this.TxtBoxEdition.Size = new System.Drawing.Size(492, 26);
            this.TxtBoxEdition.TabIndex = 1;
            // 
            // TxtBoxProductKey
            // 
            this.TxtBoxProductKey.Location = new System.Drawing.Point(31, 36);
            this.TxtBoxProductKey.Name = "TxtBoxProductKey";
            this.TxtBoxProductKey.Size = new System.Drawing.Size(492, 26);
            this.TxtBoxProductKey.TabIndex = 0;
            // 
            // ServiceUnattend
            // 
            this.ServiceUnattend.Controls.Add(this.BtnAppliqueUnattendXML);
            this.ServiceUnattend.Controls.Add(this.BtnChoisirXMLUnattend);
            this.ServiceUnattend.Controls.Add(this.TxtBoxFichierXMLUnattend);
            this.ServiceUnattend.Controls.Add(this.LblFichierXMLUnattend);
            this.ServiceUnattend.Location = new System.Drawing.Point(4, 29);
            this.ServiceUnattend.Name = "ServiceUnattend";
            this.ServiceUnattend.Size = new System.Drawing.Size(882, 257);
            this.ServiceUnattend.TabIndex = 5;
            this.ServiceUnattend.Text = "Service Unattend";
            this.ServiceUnattend.UseVisualStyleBackColor = true;
            // 
            // BtnAppliqueUnattendXML
            // 
            this.BtnAppliqueUnattendXML.Location = new System.Drawing.Point(561, 13);
            this.BtnAppliqueUnattendXML.Name = "BtnAppliqueUnattendXML";
            this.BtnAppliqueUnattendXML.Size = new System.Drawing.Size(145, 88);
            this.BtnAppliqueUnattendXML.TabIndex = 3;
            this.BtnAppliqueUnattendXML.Text = "Applique Unattend.xml";
            this.BtnAppliqueUnattendXML.UseVisualStyleBackColor = true;
            this.BtnAppliqueUnattendXML.Click += new System.EventHandler(this.BtnAppliqueUnattendXML_Click);
            // 
            // BtnChoisirXMLUnattend
            // 
            this.BtnChoisirXMLUnattend.Location = new System.Drawing.Point(393, 44);
            this.BtnChoisirXMLUnattend.Name = "BtnChoisirXMLUnattend";
            this.BtnChoisirXMLUnattend.Size = new System.Drawing.Size(162, 26);
            this.BtnChoisirXMLUnattend.TabIndex = 2;
            this.BtnChoisirXMLUnattend.Text = "Choisir fichier XML";
            this.BtnChoisirXMLUnattend.UseVisualStyleBackColor = true;
            this.BtnChoisirXMLUnattend.Click += new System.EventHandler(this.BtnChoisirXMLUnattend_Click);
            // 
            // TxtBoxFichierXMLUnattend
            // 
            this.TxtBoxFichierXMLUnattend.Location = new System.Drawing.Point(12, 44);
            this.TxtBoxFichierXMLUnattend.Name = "TxtBoxFichierXMLUnattend";
            this.TxtBoxFichierXMLUnattend.Size = new System.Drawing.Size(375, 26);
            this.TxtBoxFichierXMLUnattend.TabIndex = 1;
            // 
            // LblFichierXMLUnattend
            // 
            this.LblFichierXMLUnattend.AutoSize = true;
            this.LblFichierXMLUnattend.Location = new System.Drawing.Point(8, 21);
            this.LblFichierXMLUnattend.Name = "LblFichierXMLUnattend";
            this.LblFichierXMLUnattend.Size = new System.Drawing.Size(164, 20);
            this.LblFichierXMLUnattend.TabIndex = 0;
            this.LblFichierXMLUnattend.Text = "Fichier XML Unattend";
            // 
            // ServiceApplication
            // 
            this.ServiceApplication.Controls.Add(this.BtnVerifierPatchsApplication);
            this.ServiceApplication.Controls.Add(this.LblFichierMSP);
            this.ServiceApplication.Controls.Add(this.LblPatchCode);
            this.ServiceApplication.Controls.Add(this.LblCodeProduit);
            this.ServiceApplication.Controls.Add(this.BtnChoisirFichierMSP);
            this.ServiceApplication.Controls.Add(this.BtnAfficheInfosPatchsApplications);
            this.ServiceApplication.Controls.Add(this.BtnAfficheApplicationsPatch);
            this.ServiceApplication.Controls.Add(this.BtnAfficheInfosApplications);
            this.ServiceApplication.Controls.Add(this.btnAfficheApplication);
            this.ServiceApplication.Controls.Add(this.TxtBoxNomFichierMSP);
            this.ServiceApplication.Controls.Add(this.TxtBoxPatchCode);
            this.ServiceApplication.Controls.Add(this.TxtBoxCodeProduit);
            this.ServiceApplication.Location = new System.Drawing.Point(4, 29);
            this.ServiceApplication.Name = "ServiceApplication";
            this.ServiceApplication.Size = new System.Drawing.Size(882, 257);
            this.ServiceApplication.TabIndex = 6;
            this.ServiceApplication.Text = "Service Application";
            this.ServiceApplication.UseVisualStyleBackColor = true;
            // 
            // BtnVerifierPatchsApplication
            // 
            this.BtnVerifierPatchsApplication.Location = new System.Drawing.Point(38, 197);
            this.BtnVerifierPatchsApplication.Name = "BtnVerifierPatchsApplication";
            this.BtnVerifierPatchsApplication.Size = new System.Drawing.Size(292, 40);
            this.BtnVerifierPatchsApplication.TabIndex = 11;
            this.BtnVerifierPatchsApplication.Text = "Vérifier les Patchs d\'application";
            this.BtnVerifierPatchsApplication.UseVisualStyleBackColor = true;
            this.BtnVerifierPatchsApplication.Click += new System.EventHandler(this.BtnVerifierPatchsApplication_Click);
            // 
            // LblFichierMSP
            // 
            this.LblFichierMSP.AutoSize = true;
            this.LblFichierMSP.Location = new System.Drawing.Point(4, 130);
            this.LblFichierMSP.Name = "LblFichierMSP";
            this.LblFichierMSP.Size = new System.Drawing.Size(94, 20);
            this.LblFichierMSP.TabIndex = 10;
            this.LblFichierMSP.Text = "Fichier MSP";
            // 
            // LblPatchCode
            // 
            this.LblPatchCode.AutoSize = true;
            this.LblPatchCode.Location = new System.Drawing.Point(4, 69);
            this.LblPatchCode.Name = "LblPatchCode";
            this.LblPatchCode.Size = new System.Drawing.Size(89, 20);
            this.LblPatchCode.TabIndex = 9;
            this.LblPatchCode.Text = "Patch code";
            // 
            // LblCodeProduit
            // 
            this.LblCodeProduit.AutoSize = true;
            this.LblCodeProduit.Location = new System.Drawing.Point(4, 8);
            this.LblCodeProduit.Name = "LblCodeProduit";
            this.LblCodeProduit.Size = new System.Drawing.Size(100, 20);
            this.LblCodeProduit.TabIndex = 8;
            this.LblCodeProduit.Text = "Code produit";
            // 
            // BtnChoisirFichierMSP
            // 
            this.BtnChoisirFichierMSP.Location = new System.Drawing.Point(379, 153);
            this.BtnChoisirFichierMSP.Name = "BtnChoisirFichierMSP";
            this.BtnChoisirFichierMSP.Size = new System.Drawing.Size(159, 26);
            this.BtnChoisirFichierMSP.TabIndex = 7;
            this.BtnChoisirFichierMSP.Text = "Choisir fichier MSP";
            this.BtnChoisirFichierMSP.UseVisualStyleBackColor = true;
            this.BtnChoisirFichierMSP.Click += new System.EventHandler(this.BtnChoisirFichierMSP_Click);
            // 
            // BtnAfficheInfosPatchsApplications
            // 
            this.BtnAfficheInfosPatchsApplications.Location = new System.Drawing.Point(559, 184);
            this.BtnAfficheInfosPatchsApplications.Name = "BtnAfficheInfosPatchsApplications";
            this.BtnAfficheInfosPatchsApplications.Size = new System.Drawing.Size(257, 53);
            this.BtnAfficheInfosPatchsApplications.TabIndex = 6;
            this.BtnAfficheInfosPatchsApplications.Text = "Affiche les infos des patchs d\'applications";
            this.BtnAfficheInfosPatchsApplications.UseVisualStyleBackColor = true;
            this.BtnAfficheInfosPatchsApplications.Click += new System.EventHandler(this.BtnAfficheInfosPatchsApplications_Click);
            // 
            // BtnAfficheApplicationsPatch
            // 
            this.BtnAfficheApplicationsPatch.Location = new System.Drawing.Point(559, 127);
            this.BtnAfficheApplicationsPatch.Name = "BtnAfficheApplicationsPatch";
            this.BtnAfficheApplicationsPatch.Size = new System.Drawing.Size(257, 42);
            this.BtnAfficheApplicationsPatch.TabIndex = 5;
            this.BtnAfficheApplicationsPatch.Text = "Affiche les patchs d\'applications";
            this.BtnAfficheApplicationsPatch.UseVisualStyleBackColor = true;
            this.BtnAfficheApplicationsPatch.Click += new System.EventHandler(this.BtnAfficheApplicationsPatch_Click);
            // 
            // BtnAfficheInfosApplications
            // 
            this.BtnAfficheInfosApplications.Location = new System.Drawing.Point(559, 68);
            this.BtnAfficheInfosApplications.Name = "BtnAfficheInfosApplications";
            this.BtnAfficheInfosApplications.Size = new System.Drawing.Size(257, 45);
            this.BtnAfficheInfosApplications.TabIndex = 4;
            this.BtnAfficheInfosApplications.Text = "Affiche les infos des applications";
            this.BtnAfficheInfosApplications.UseVisualStyleBackColor = true;
            this.BtnAfficheInfosApplications.Click += new System.EventHandler(this.BtnAfficheInfosApplications_Click);
            // 
            // btnAfficheApplication
            // 
            this.btnAfficheApplication.Location = new System.Drawing.Point(559, 14);
            this.btnAfficheApplication.Name = "btnAfficheApplication";
            this.btnAfficheApplication.Size = new System.Drawing.Size(257, 43);
            this.btnAfficheApplication.TabIndex = 3;
            this.btnAfficheApplication.Text = "Affiche les applications";
            this.btnAfficheApplication.UseVisualStyleBackColor = true;
            this.btnAfficheApplication.Click += new System.EventHandler(this.btnAfficheApplication_Click);
            // 
            // TxtBoxNomFichierMSP
            // 
            this.TxtBoxNomFichierMSP.Location = new System.Drawing.Point(8, 153);
            this.TxtBoxNomFichierMSP.Name = "TxtBoxNomFichierMSP";
            this.TxtBoxNomFichierMSP.Size = new System.Drawing.Size(365, 26);
            this.TxtBoxNomFichierMSP.TabIndex = 2;
            // 
            // TxtBoxPatchCode
            // 
            this.TxtBoxPatchCode.Location = new System.Drawing.Point(8, 92);
            this.TxtBoxPatchCode.Name = "TxtBoxPatchCode";
            this.TxtBoxPatchCode.Size = new System.Drawing.Size(365, 26);
            this.TxtBoxPatchCode.TabIndex = 1;
            // 
            // TxtBoxCodeProduit
            // 
            this.TxtBoxCodeProduit.Location = new System.Drawing.Point(8, 31);
            this.TxtBoxCodeProduit.Name = "TxtBoxCodeProduit";
            this.TxtBoxCodeProduit.Size = new System.Drawing.Size(365, 26);
            this.TxtBoxCodeProduit.TabIndex = 0;
            // 
            // CaptureImage
            // 
            this.CaptureImage.Controls.Add(this.LblDescriptionWIM);
            this.CaptureImage.Controls.Add(this.TxtBoxCaptureDescriptionWIM);
            this.CaptureImage.Controls.Add(this.ChkBoxCaptureVerifier);
            this.CaptureImage.Controls.Add(this.LblCompression);
            this.CaptureImage.Controls.Add(this.LblNomFichierWIM);
            this.CaptureImage.Controls.Add(this.LblDestination);
            this.CaptureImage.Controls.Add(this.LblSource);
            this.CaptureImage.Controls.Add(this.CmbBoxCaptureCompression);
            this.CaptureImage.Controls.Add(this.TxtBoxCaptureNomFichier);
            this.CaptureImage.Controls.Add(this.TxtBoxCaptureDestination);
            this.CaptureImage.Controls.Add(this.TxtBoxCaptureSource);
            this.CaptureImage.Controls.Add(this.BtnAjouter);
            this.CaptureImage.Controls.Add(this.BtnCreer);
            this.CaptureImage.Controls.Add(this.ParcourirDestination);
            this.CaptureImage.Controls.Add(this.BtnParcourirSource);
            this.CaptureImage.Location = new System.Drawing.Point(4, 29);
            this.CaptureImage.Name = "CaptureImage";
            this.CaptureImage.Size = new System.Drawing.Size(882, 257);
            this.CaptureImage.TabIndex = 7;
            this.CaptureImage.Text = "Capture Image";
            this.CaptureImage.UseVisualStyleBackColor = true;
            // 
            // LblDescriptionWIM
            // 
            this.LblDescriptionWIM.AutoSize = true;
            this.LblDescriptionWIM.Location = new System.Drawing.Point(3, 155);
            this.LblDescriptionWIM.Name = "LblDescriptionWIM";
            this.LblDescriptionWIM.Size = new System.Drawing.Size(130, 20);
            this.LblDescriptionWIM.TabIndex = 14;
            this.LblDescriptionWIM.Text = "Description WIM:";
            // 
            // TxtBoxCaptureDescriptionWIM
            // 
            this.TxtBoxCaptureDescriptionWIM.Location = new System.Drawing.Point(158, 152);
            this.TxtBoxCaptureDescriptionWIM.Name = "TxtBoxCaptureDescriptionWIM";
            this.TxtBoxCaptureDescriptionWIM.Size = new System.Drawing.Size(300, 26);
            this.TxtBoxCaptureDescriptionWIM.TabIndex = 13;
            // 
            // ChkBoxCaptureVerifier
            // 
            this.ChkBoxCaptureVerifier.AutoSize = true;
            this.ChkBoxCaptureVerifier.Location = new System.Drawing.Point(158, 229);
            this.ChkBoxCaptureVerifier.Name = "ChkBoxCaptureVerifier";
            this.ChkBoxCaptureVerifier.Size = new System.Drawing.Size(78, 24);
            this.ChkBoxCaptureVerifier.TabIndex = 12;
            this.ChkBoxCaptureVerifier.Text = "Vérifier";
            this.ChkBoxCaptureVerifier.UseVisualStyleBackColor = true;
            // 
            // LblCompression
            // 
            this.LblCompression.AutoSize = true;
            this.LblCompression.Location = new System.Drawing.Point(3, 189);
            this.LblCompression.Name = "LblCompression";
            this.LblCompression.Size = new System.Drawing.Size(106, 20);
            this.LblCompression.TabIndex = 11;
            this.LblCompression.Text = "Compression:";
            // 
            // LblNomFichierWIM
            // 
            this.LblNomFichierWIM.AutoSize = true;
            this.LblNomFichierWIM.Location = new System.Drawing.Point(3, 118);
            this.LblNomFichierWIM.Name = "LblNomFichierWIM";
            this.LblNomFichierWIM.Size = new System.Drawing.Size(92, 20);
            this.LblNomFichierWIM.TabIndex = 10;
            this.LblNomFichierWIM.Text = "Nom fichier:";
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Location = new System.Drawing.Point(3, 76);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(149, 20);
            this.LblDestination.TabIndex = 9;
            this.LblDestination.Text = "Dossier destination:";
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(3, 31);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(119, 20);
            this.LblSource.TabIndex = 8;
            this.LblSource.Text = "Dossier source:";
            // 
            // CmbBoxCaptureCompression
            // 
            this.CmbBoxCaptureCompression.FormattingEnabled = true;
            this.CmbBoxCaptureCompression.Items.AddRange(new object[] {
            "none",
            "fast",
            "max"});
            this.CmbBoxCaptureCompression.Location = new System.Drawing.Point(158, 184);
            this.CmbBoxCaptureCompression.Name = "CmbBoxCaptureCompression";
            this.CmbBoxCaptureCompression.Size = new System.Drawing.Size(121, 28);
            this.CmbBoxCaptureCompression.TabIndex = 7;
            // 
            // TxtBoxCaptureNomFichier
            // 
            this.TxtBoxCaptureNomFichier.Location = new System.Drawing.Point(158, 118);
            this.TxtBoxCaptureNomFichier.Name = "TxtBoxCaptureNomFichier";
            this.TxtBoxCaptureNomFichier.Size = new System.Drawing.Size(300, 26);
            this.TxtBoxCaptureNomFichier.TabIndex = 6;
            // 
            // TxtBoxCaptureDestination
            // 
            this.TxtBoxCaptureDestination.Location = new System.Drawing.Point(158, 76);
            this.TxtBoxCaptureDestination.Name = "TxtBoxCaptureDestination";
            this.TxtBoxCaptureDestination.Size = new System.Drawing.Size(300, 26);
            this.TxtBoxCaptureDestination.TabIndex = 5;
            // 
            // TxtBoxCaptureSource
            // 
            this.TxtBoxCaptureSource.Location = new System.Drawing.Point(158, 34);
            this.TxtBoxCaptureSource.Name = "TxtBoxCaptureSource";
            this.TxtBoxCaptureSource.Size = new System.Drawing.Size(300, 26);
            this.TxtBoxCaptureSource.TabIndex = 4;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(634, 121);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(98, 42);
            this.BtnAjouter.TabIndex = 3;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnCreer
            // 
            this.BtnCreer.Location = new System.Drawing.Point(634, 37);
            this.BtnCreer.Name = "BtnCreer";
            this.BtnCreer.Size = new System.Drawing.Size(98, 46);
            this.BtnCreer.TabIndex = 2;
            this.BtnCreer.Text = "Créer";
            this.BtnCreer.UseVisualStyleBackColor = true;
            this.BtnCreer.Click += new System.EventHandler(this.BtnCreer_Click);
            // 
            // ParcourirDestination
            // 
            this.ParcourirDestination.Location = new System.Drawing.Point(475, 76);
            this.ParcourirDestination.Name = "ParcourirDestination";
            this.ParcourirDestination.Size = new System.Drawing.Size(96, 26);
            this.ParcourirDestination.TabIndex = 1;
            this.ParcourirDestination.Text = "Parcourir";
            this.ParcourirDestination.UseVisualStyleBackColor = true;
            this.ParcourirDestination.Click += new System.EventHandler(this.ParcourirDestination_Click);
            // 
            // BtnParcourirSource
            // 
            this.BtnParcourirSource.Location = new System.Drawing.Point(475, 34);
            this.BtnParcourirSource.Name = "BtnParcourirSource";
            this.BtnParcourirSource.Size = new System.Drawing.Size(96, 26);
            this.BtnParcourirSource.TabIndex = 0;
            this.BtnParcourirSource.Text = "Parcourir";
            this.BtnParcourirSource.UseVisualStyleBackColor = true;
            this.BtnParcourirSource.Click += new System.EventHandler(this.BtnParcourirSource_Click);
            // 
            // AppliqueImage
            // 
            this.AppliqueImage.Controls.Add(this.ChkBoxApplyVerifier);
            this.AppliqueImage.Controls.Add(this.label5);
            this.AppliqueImage.Controls.Add(this.CmbBoxApplyIndex);
            this.AppliqueImage.Controls.Add(this.LblDestinationBis);
            this.AppliqueImage.Controls.Add(this.LblSourceBis);
            this.AppliqueImage.Controls.Add(this.TxtBoxApplyDestination);
            this.AppliqueImage.Controls.Add(this.BtnAppliquerImage);
            this.AppliqueImage.Controls.Add(this.BtnApplyParcourirDestination);
            this.AppliqueImage.Controls.Add(this.TxtBoxApplySource);
            this.AppliqueImage.Controls.Add(this.BtnApplyParcourirSource);
            this.AppliqueImage.Location = new System.Drawing.Point(4, 29);
            this.AppliqueImage.Name = "AppliqueImage";
            this.AppliqueImage.Size = new System.Drawing.Size(882, 257);
            this.AppliqueImage.TabIndex = 8;
            this.AppliqueImage.Text = "Appliquer Image";
            this.AppliqueImage.UseVisualStyleBackColor = true;
            // 
            // ChkBoxApplyVerifier
            // 
            this.ChkBoxApplyVerifier.AutoSize = true;
            this.ChkBoxApplyVerifier.Location = new System.Drawing.Point(112, 205);
            this.ChkBoxApplyVerifier.Name = "ChkBoxApplyVerifier";
            this.ChkBoxApplyVerifier.Size = new System.Drawing.Size(78, 24);
            this.ChkBoxApplyVerifier.TabIndex = 9;
            this.ChkBoxApplyVerifier.Text = "Verifier";
            this.ChkBoxApplyVerifier.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Index:";
            // 
            // CmbBoxApplyIndex
            // 
            this.CmbBoxApplyIndex.FormattingEnabled = true;
            this.CmbBoxApplyIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CmbBoxApplyIndex.Location = new System.Drawing.Point(112, 153);
            this.CmbBoxApplyIndex.Name = "CmbBoxApplyIndex";
            this.CmbBoxApplyIndex.Size = new System.Drawing.Size(57, 28);
            this.CmbBoxApplyIndex.TabIndex = 7;
            // 
            // LblDestinationBis
            // 
            this.LblDestinationBis.AutoSize = true;
            this.LblDestinationBis.Location = new System.Drawing.Point(8, 105);
            this.LblDestinationBis.Name = "LblDestinationBis";
            this.LblDestinationBis.Size = new System.Drawing.Size(94, 20);
            this.LblDestinationBis.TabIndex = 6;
            this.LblDestinationBis.Text = "Destination:";
            // 
            // LblSourceBis
            // 
            this.LblSourceBis.AutoSize = true;
            this.LblSourceBis.Location = new System.Drawing.Point(8, 43);
            this.LblSourceBis.Name = "LblSourceBis";
            this.LblSourceBis.Size = new System.Drawing.Size(64, 20);
            this.LblSourceBis.TabIndex = 5;
            this.LblSourceBis.Text = "Source:";
            // 
            // TxtBoxApplyDestination
            // 
            this.TxtBoxApplyDestination.Location = new System.Drawing.Point(112, 99);
            this.TxtBoxApplyDestination.Name = "TxtBoxApplyDestination";
            this.TxtBoxApplyDestination.Size = new System.Drawing.Size(303, 26);
            this.TxtBoxApplyDestination.TabIndex = 4;
            // 
            // BtnAppliquerImage
            // 
            this.BtnAppliquerImage.Location = new System.Drawing.Point(563, 57);
            this.BtnAppliquerImage.Name = "BtnAppliquerImage";
            this.BtnAppliquerImage.Size = new System.Drawing.Size(136, 53);
            this.BtnAppliquerImage.TabIndex = 3;
            this.BtnAppliquerImage.Text = "Appliquer Image";
            this.BtnAppliquerImage.UseVisualStyleBackColor = true;
            this.BtnAppliquerImage.Click += new System.EventHandler(this.BtnAppliquerImage_Click);
            // 
            // BtnApplyParcourirDestination
            // 
            this.BtnApplyParcourirDestination.Location = new System.Drawing.Point(441, 99);
            this.BtnApplyParcourirDestination.Name = "BtnApplyParcourirDestination";
            this.BtnApplyParcourirDestination.Size = new System.Drawing.Size(89, 26);
            this.BtnApplyParcourirDestination.TabIndex = 2;
            this.BtnApplyParcourirDestination.Text = "Parcourir";
            this.BtnApplyParcourirDestination.UseVisualStyleBackColor = true;
            this.BtnApplyParcourirDestination.Click += new System.EventHandler(this.BtnApplyParcourirDestination_Click);
            // 
            // TxtBoxApplySource
            // 
            this.TxtBoxApplySource.Location = new System.Drawing.Point(112, 40);
            this.TxtBoxApplySource.Name = "TxtBoxApplySource";
            this.TxtBoxApplySource.Size = new System.Drawing.Size(303, 26);
            this.TxtBoxApplySource.TabIndex = 1;
            // 
            // BtnApplyParcourirSource
            // 
            this.BtnApplyParcourirSource.Location = new System.Drawing.Point(441, 40);
            this.BtnApplyParcourirSource.Name = "BtnApplyParcourirSource";
            this.BtnApplyParcourirSource.Size = new System.Drawing.Size(89, 26);
            this.BtnApplyParcourirSource.TabIndex = 0;
            this.BtnApplyParcourirSource.Text = "Parcourir";
            this.BtnApplyParcourirSource.UseVisualStyleBackColor = true;
            this.BtnApplyParcourirSource.Click += new System.EventHandler(this.BtnApplyParcourirSource_Click);
            // 
            // ExportImage
            // 
            this.ExportImage.Controls.Add(this.LblExportName);
            this.ExportImage.Controls.Add(this.TxtBoxNomFichier);
            this.ExportImage.Controls.Add(this.ChkBoxExportCheckIntegrity);
            this.ExportImage.Controls.Add(this.ChkBoxExportWimBoot);
            this.ExportImage.Controls.Add(this.ChkBoxExportBootable);
            this.ExportImage.Controls.Add(this.label9);
            this.ExportImage.Controls.Add(this.CmbBoxExportCompression);
            this.ExportImage.Controls.Add(this.label6);
            this.ExportImage.Controls.Add(this.CmbBoxExportIndex);
            this.ExportImage.Controls.Add(this.LblExportDestination);
            this.ExportImage.Controls.Add(this.LblExportSource);
            this.ExportImage.Controls.Add(this.TxtBoxExportDestination);
            this.ExportImage.Controls.Add(this.BtnExportImage);
            this.ExportImage.Controls.Add(this.BtnExportChoisirDossier);
            this.ExportImage.Controls.Add(this.TxtBoxExportSourceFichier);
            this.ExportImage.Controls.Add(this.BtnExportChoisirFichier);
            this.ExportImage.Location = new System.Drawing.Point(4, 29);
            this.ExportImage.Name = "ExportImage";
            this.ExportImage.Size = new System.Drawing.Size(882, 257);
            this.ExportImage.TabIndex = 9;
            this.ExportImage.Text = "Export Image";
            this.ExportImage.UseVisualStyleBackColor = true;
            // 
            // LblExportName
            // 
            this.LblExportName.AutoSize = true;
            this.LblExportName.Location = new System.Drawing.Point(28, 93);
            this.LblExportName.Name = "LblExportName";
            this.LblExportName.Size = new System.Drawing.Size(92, 20);
            this.LblExportName.TabIndex = 25;
            this.LblExportName.Text = "Nom fichier:";
            // 
            // TxtBoxNomFichier
            // 
            this.TxtBoxNomFichier.Location = new System.Drawing.Point(132, 90);
            this.TxtBoxNomFichier.Name = "TxtBoxNomFichier";
            this.TxtBoxNomFichier.Size = new System.Drawing.Size(303, 26);
            this.TxtBoxNomFichier.TabIndex = 24;
            // 
            // ChkBoxExportCheckIntegrity
            // 
            this.ChkBoxExportCheckIntegrity.AutoSize = true;
            this.ChkBoxExportCheckIntegrity.Location = new System.Drawing.Point(133, 233);
            this.ChkBoxExportCheckIntegrity.Name = "ChkBoxExportCheckIntegrity";
            this.ChkBoxExportCheckIntegrity.Size = new System.Drawing.Size(134, 24);
            this.ChkBoxExportCheckIntegrity.TabIndex = 22;
            this.ChkBoxExportCheckIntegrity.Text = "/CheckIntegrity";
            this.ChkBoxExportCheckIntegrity.UseVisualStyleBackColor = true;
            // 
            // ChkBoxExportWimBoot
            // 
            this.ChkBoxExportWimBoot.AutoSize = true;
            this.ChkBoxExportWimBoot.Location = new System.Drawing.Point(329, 198);
            this.ChkBoxExportWimBoot.Name = "ChkBoxExportWimBoot";
            this.ChkBoxExportWimBoot.Size = new System.Drawing.Size(97, 24);
            this.ChkBoxExportWimBoot.TabIndex = 21;
            this.ChkBoxExportWimBoot.Text = "/WimBoot";
            this.ChkBoxExportWimBoot.UseVisualStyleBackColor = true;
            // 
            // ChkBoxExportBootable
            // 
            this.ChkBoxExportBootable.AutoSize = true;
            this.ChkBoxExportBootable.Location = new System.Drawing.Point(132, 198);
            this.ChkBoxExportBootable.Name = "ChkBoxExportBootable";
            this.ChkBoxExportBootable.Size = new System.Drawing.Size(96, 24);
            this.ChkBoxExportBootable.TabIndex = 20;
            this.ChkBoxExportBootable.Text = "/Bootable";
            this.ChkBoxExportBootable.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Compression:";
            // 
            // CmbBoxExportCompression
            // 
            this.CmbBoxExportCompression.FormattingEnabled = true;
            this.CmbBoxExportCompression.Items.AddRange(new object[] {
            "fast",
            "max",
            "none",
            "recovery"});
            this.CmbBoxExportCompression.Location = new System.Drawing.Point(330, 154);
            this.CmbBoxExportCompression.Name = "CmbBoxExportCompression";
            this.CmbBoxExportCompression.Size = new System.Drawing.Size(132, 28);
            this.CmbBoxExportCompression.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Index:";
            // 
            // CmbBoxExportIndex
            // 
            this.CmbBoxExportIndex.FormattingEnabled = true;
            this.CmbBoxExportIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CmbBoxExportIndex.Location = new System.Drawing.Point(132, 154);
            this.CmbBoxExportIndex.Name = "CmbBoxExportIndex";
            this.CmbBoxExportIndex.Size = new System.Drawing.Size(57, 28);
            this.CmbBoxExportIndex.TabIndex = 16;
            // 
            // LblExportDestination
            // 
            this.LblExportDestination.AutoSize = true;
            this.LblExportDestination.Location = new System.Drawing.Point(28, 61);
            this.LblExportDestination.Name = "LblExportDestination";
            this.LblExportDestination.Size = new System.Drawing.Size(94, 20);
            this.LblExportDestination.TabIndex = 15;
            this.LblExportDestination.Text = "Destination:";
            // 
            // LblExportSource
            // 
            this.LblExportSource.AutoSize = true;
            this.LblExportSource.Location = new System.Drawing.Point(29, 29);
            this.LblExportSource.Name = "LblExportSource";
            this.LblExportSource.Size = new System.Drawing.Size(64, 20);
            this.LblExportSource.TabIndex = 14;
            this.LblExportSource.Text = "Source:";
            // 
            // TxtBoxExportDestination
            // 
            this.TxtBoxExportDestination.Location = new System.Drawing.Point(132, 58);
            this.TxtBoxExportDestination.Name = "TxtBoxExportDestination";
            this.TxtBoxExportDestination.Size = new System.Drawing.Size(303, 26);
            this.TxtBoxExportDestination.TabIndex = 13;
            // 
            // BtnExportImage
            // 
            this.BtnExportImage.Location = new System.Drawing.Point(650, 31);
            this.BtnExportImage.Name = "BtnExportImage";
            this.BtnExportImage.Size = new System.Drawing.Size(136, 53);
            this.BtnExportImage.TabIndex = 12;
            this.BtnExportImage.Text = "Export Image";
            this.BtnExportImage.UseVisualStyleBackColor = true;
            this.BtnExportImage.Click += new System.EventHandler(this.BtnExportImage_Click);
            // 
            // BtnExportChoisirDossier
            // 
            this.BtnExportChoisirDossier.Location = new System.Drawing.Point(464, 58);
            this.BtnExportChoisirDossier.Name = "BtnExportChoisirDossier";
            this.BtnExportChoisirDossier.Size = new System.Drawing.Size(137, 26);
            this.BtnExportChoisirDossier.TabIndex = 11;
            this.BtnExportChoisirDossier.Text = "Choisir Dossier";
            this.BtnExportChoisirDossier.UseVisualStyleBackColor = true;
            this.BtnExportChoisirDossier.Click += new System.EventHandler(this.BtnExportChoisirDossier_Click);
            // 
            // TxtBoxExportSourceFichier
            // 
            this.TxtBoxExportSourceFichier.Location = new System.Drawing.Point(133, 26);
            this.TxtBoxExportSourceFichier.Name = "TxtBoxExportSourceFichier";
            this.TxtBoxExportSourceFichier.Size = new System.Drawing.Size(303, 26);
            this.TxtBoxExportSourceFichier.TabIndex = 10;
            // 
            // BtnExportChoisirFichier
            // 
            this.BtnExportChoisirFichier.Location = new System.Drawing.Point(465, 26);
            this.BtnExportChoisirFichier.Name = "BtnExportChoisirFichier";
            this.BtnExportChoisirFichier.Size = new System.Drawing.Size(136, 26);
            this.BtnExportChoisirFichier.TabIndex = 9;
            this.BtnExportChoisirFichier.Text = "Choisir Fichier";
            this.BtnExportChoisirFichier.UseVisualStyleBackColor = true;
            this.BtnExportChoisirFichier.Click += new System.EventHandler(this.BtnExportChoisirFichier_Click);
            // 
            // GestionLangue
            // 
            this.GestionLangue.Controls.Add(this.BtnAllIntrlAppliquer);
            this.GestionLangue.Controls.Add(this.TxtBoxAllIntl);
            this.GestionLangue.Controls.Add(this.label7);
            this.GestionLangue.Controls.Add(this.BtnInfosLangue);
            this.GestionLangue.Location = new System.Drawing.Point(4, 29);
            this.GestionLangue.Name = "GestionLangue";
            this.GestionLangue.Size = new System.Drawing.Size(882, 257);
            this.GestionLangue.TabIndex = 10;
            this.GestionLangue.Text = "Gestion Langue";
            this.GestionLangue.UseVisualStyleBackColor = true;
            // 
            // BtnAllIntrlAppliquer
            // 
            this.BtnAllIntrlAppliquer.Location = new System.Drawing.Point(375, 22);
            this.BtnAllIntrlAppliquer.Name = "BtnAllIntrlAppliquer";
            this.BtnAllIntrlAppliquer.Size = new System.Drawing.Size(97, 26);
            this.BtnAllIntrlAppliquer.TabIndex = 3;
            this.BtnAllIntrlAppliquer.Text = "Appliquer";
            this.BtnAllIntrlAppliquer.UseVisualStyleBackColor = true;
            this.BtnAllIntrlAppliquer.Click += new System.EventHandler(this.BtnAllIntrlAppliquer_Click);
            // 
            // TxtBoxAllIntl
            // 
            this.TxtBoxAllIntl.Location = new System.Drawing.Point(125, 22);
            this.TxtBoxAllIntl.Name = "TxtBoxAllIntl";
            this.TxtBoxAllIntl.Size = new System.Drawing.Size(222, 26);
            this.TxtBoxAllIntl.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "/Set-AllIntl:";
            // 
            // BtnInfosLangue
            // 
            this.BtnInfosLangue.Location = new System.Drawing.Point(591, 19);
            this.BtnInfosLangue.Name = "BtnInfosLangue";
            this.BtnInfosLangue.Size = new System.Drawing.Size(278, 33);
            this.BtnInfosLangue.TabIndex = 0;
            this.BtnInfosLangue.Text = "Information language (mode offline)";
            this.BtnInfosLangue.UseVisualStyleBackColor = true;
            this.BtnInfosLangue.Click += new System.EventHandler(this.BtnInfosLangue_Click);
            // 
            // ExportDriver
            // 
            this.ExportDriver.Controls.Add(this.BtnExportDriverOnline);
            this.ExportDriver.Controls.Add(this.label8);
            this.ExportDriver.Controls.Add(this.TxtBoxExportDossierDriverOnline);
            this.ExportDriver.Controls.Add(this.BtnExportDriverChoisirDossierOnline);
            this.ExportDriver.Controls.Add(this.BtnExportDriverOffline);
            this.ExportDriver.Controls.Add(this.LblExportChoisirDossier);
            this.ExportDriver.Controls.Add(this.TxtBoxExportDossierDriverOffline);
            this.ExportDriver.Controls.Add(this.BtnExportDriverChoisirDossierOffline);
            this.ExportDriver.Location = new System.Drawing.Point(4, 29);
            this.ExportDriver.Name = "ExportDriver";
            this.ExportDriver.Size = new System.Drawing.Size(882, 257);
            this.ExportDriver.TabIndex = 11;
            this.ExportDriver.Text = "Export Pilotes";
            this.ExportDriver.UseVisualStyleBackColor = true;
            // 
            // BtnExportDriverOnline
            // 
            this.BtnExportDriverOnline.Location = new System.Drawing.Point(654, 162);
            this.BtnExportDriverOnline.Name = "BtnExportDriverOnline";
            this.BtnExportDriverOnline.Size = new System.Drawing.Size(198, 60);
            this.BtnExportDriverOnline.TabIndex = 7;
            this.BtnExportDriverOnline.Text = "Export Driver Online";
            this.BtnExportDriverOnline.UseVisualStyleBackColor = true;
            this.BtnExportDriverOnline.Click += new System.EventHandler(this.BtnExportDriverOnline_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dossier:";
            // 
            // TxtBoxExportDossierDriverOnline
            // 
            this.TxtBoxExportDossierDriverOnline.Location = new System.Drawing.Point(116, 176);
            this.TxtBoxExportDossierDriverOnline.Name = "TxtBoxExportDossierDriverOnline";
            this.TxtBoxExportDossierDriverOnline.Size = new System.Drawing.Size(501, 26);
            this.TxtBoxExportDossierDriverOnline.TabIndex = 5;
            // 
            // BtnExportDriverChoisirDossierOnline
            // 
            this.BtnExportDriverChoisirDossierOnline.Location = new System.Drawing.Point(279, 217);
            this.BtnExportDriverChoisirDossierOnline.Name = "BtnExportDriverChoisirDossierOnline";
            this.BtnExportDriverChoisirDossierOnline.Size = new System.Drawing.Size(150, 29);
            this.BtnExportDriverChoisirDossierOnline.TabIndex = 4;
            this.BtnExportDriverChoisirDossierOnline.Text = "Choisir Dossier";
            this.BtnExportDriverChoisirDossierOnline.UseVisualStyleBackColor = true;
            this.BtnExportDriverChoisirDossierOnline.Click += new System.EventHandler(this.BtnExportDriverChoisirDossierOnline_Click);
            // 
            // BtnExportDriverOffline
            // 
            this.BtnExportDriverOffline.Location = new System.Drawing.Point(654, 27);
            this.BtnExportDriverOffline.Name = "BtnExportDriverOffline";
            this.BtnExportDriverOffline.Size = new System.Drawing.Size(198, 60);
            this.BtnExportDriverOffline.TabIndex = 3;
            this.BtnExportDriverOffline.Text = "Export Driver Offline";
            this.BtnExportDriverOffline.UseVisualStyleBackColor = true;
            this.BtnExportDriverOffline.Click += new System.EventHandler(this.BtnExportDriverOffline_Click);
            // 
            // LblExportChoisirDossier
            // 
            this.LblExportChoisirDossier.AutoSize = true;
            this.LblExportChoisirDossier.Location = new System.Drawing.Point(8, 47);
            this.LblExportChoisirDossier.Name = "LblExportChoisirDossier";
            this.LblExportChoisirDossier.Size = new System.Drawing.Size(67, 20);
            this.LblExportChoisirDossier.TabIndex = 2;
            this.LblExportChoisirDossier.Text = "Dossier:";
            // 
            // TxtBoxExportDossierDriverOffline
            // 
            this.TxtBoxExportDossierDriverOffline.Location = new System.Drawing.Point(116, 41);
            this.TxtBoxExportDossierDriverOffline.Name = "TxtBoxExportDossierDriverOffline";
            this.TxtBoxExportDossierDriverOffline.Size = new System.Drawing.Size(501, 26);
            this.TxtBoxExportDossierDriverOffline.TabIndex = 1;
            // 
            // BtnExportDriverChoisirDossierOffline
            // 
            this.BtnExportDriverChoisirDossierOffline.Location = new System.Drawing.Point(279, 82);
            this.BtnExportDriverChoisirDossierOffline.Name = "BtnExportDriverChoisirDossierOffline";
            this.BtnExportDriverChoisirDossierOffline.Size = new System.Drawing.Size(150, 29);
            this.BtnExportDriverChoisirDossierOffline.TabIndex = 0;
            this.BtnExportDriverChoisirDossierOffline.Text = "Choisir Dossier";
            this.BtnExportDriverChoisirDossierOffline.UseVisualStyleBackColor = true;
            this.BtnExportDriverChoisirDossierOffline.Click += new System.EventHandler(this.BtnExportDriverChoisirDossierOffline_Click);
            // 
            // TxtBoxOutput
            // 
            this.TxtBoxOutput.Location = new System.Drawing.Point(4, 355);
            this.TxtBoxOutput.Multiline = true;
            this.TxtBoxOutput.Name = "TxtBoxOutput";
            this.TxtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBoxOutput.Size = new System.Drawing.Size(882, 244);
            this.TxtBoxOutput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dism (sortie console):";
            // 
            // backgroundWorkerMount
            // 
            this.backgroundWorkerMount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMount_DoWork);
            this.backgroundWorkerMount.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMount_RunWorkerCompleted);
            // 
            // backgroundWorkerDismCommand
            // 
            this.backgroundWorkerDismCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDismCommand_DoWork);
            this.backgroundWorkerDismCommand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDismCommand_RunWorkerCompleted);
            // 
            // backgroundWorkerDismount
            // 
            this.backgroundWorkerDismount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDismount_DoWork);
            this.backgroundWorkerDismount.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDismount_RunWorkerCompleted);
            // 
            // BtnEffaceConsoleDism
            // 
            this.BtnEffaceConsoleDism.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEffaceConsoleDism.Location = new System.Drawing.Point(709, 317);
            this.BtnEffaceConsoleDism.Name = "BtnEffaceConsoleDism";
            this.BtnEffaceConsoleDism.Size = new System.Drawing.Size(177, 32);
            this.BtnEffaceConsoleDism.TabIndex = 4;
            this.BtnEffaceConsoleDism.Text = "Efface la console DISM";
            this.BtnEffaceConsoleDism.UseVisualStyleBackColor = true;
            this.BtnEffaceConsoleDism.Click += new System.EventHandler(this.BtnEffaceConsoleDism_Click);
            // 
            // TxtBox_DISMVersion
            // 
            this.TxtBox_DISMVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_DISMVersion.Location = new System.Drawing.Point(571, 320);
            this.TxtBox_DISMVersion.Name = "TxtBox_DISMVersion";
            this.TxtBox_DISMVersion.Size = new System.Drawing.Size(132, 26);
            this.TxtBox_DISMVersion.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(453, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "DISM Version:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 604);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBox_DISMVersion);
            this.Controls.Add(this.BtnEffaceConsoleDism);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxOutput);
            this.Controls.Add(this.TabGestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Interface Graphique pour DISM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabGestion.ResumeLayout(false);
            this.GestionMontage.ResumeLayout(false);
            this.GestionMontage.PerformLayout();
            this.GestionPilotes.ResumeLayout(false);
            this.groupBoxSupprimerPilotes.ResumeLayout(false);
            this.groupBoxSupprimerPilotes.PerformLayout();
            this.groupBoxAjouterPilotes.ResumeLayout(false);
            this.groupBoxAjouterPilotes.PerformLayout();
            this.GestionPackage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GestionFeature.ResumeLayout(false);
            this.GestionFeature.PerformLayout();
            this.ServiceEdition.ResumeLayout(false);
            this.ServiceEdition.PerformLayout();
            this.ServiceUnattend.ResumeLayout(false);
            this.ServiceUnattend.PerformLayout();
            this.ServiceApplication.ResumeLayout(false);
            this.ServiceApplication.PerformLayout();
            this.CaptureImage.ResumeLayout(false);
            this.CaptureImage.PerformLayout();
            this.AppliqueImage.ResumeLayout(false);
            this.AppliqueImage.PerformLayout();
            this.ExportImage.ResumeLayout(false);
            this.ExportImage.PerformLayout();
            this.GestionLangue.ResumeLayout(false);
            this.GestionLangue.PerformLayout();
            this.ExportDriver.ResumeLayout(false);
            this.ExportDriver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLogDISMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationSurLeWIMMontéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nettoyerLeWIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nettoyerLimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utiliserLeModeOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.TabControl TabGestion;
        private System.Windows.Forms.TabPage GestionMontage;
        private System.Windows.Forms.TabPage GestionPilotes;
        private System.Windows.Forms.TabPage GestionPackage;
        private System.Windows.Forms.TabPage GestionFeature;
        private System.Windows.Forms.TabPage ServiceEdition;
        private System.Windows.Forms.TabPage ServiceUnattend;
        private System.Windows.Forms.TabPage ServiceApplication;
        private System.Windows.Forms.TabPage CaptureImage;
        private System.Windows.Forms.TabPage AppliqueImage;
        private System.Windows.Forms.Label LblFichierWim;
        private System.Windows.Forms.TextBox TxtFichierWim;
        private System.Windows.Forms.TextBox TxtDossierMontage;
        private System.Windows.Forms.Label LblDossierMontage;
        private System.Windows.Forms.Button BtnChoisirWim;
        private System.Windows.Forms.Button AfficheWimInfos;
        private System.Windows.Forms.Button BtnChoisirDossier;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogue_ChoisirWIM;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ChoisirDossier;
        private System.Windows.Forms.TextBox TxtBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMount;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDismCommand;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDismount;
        private System.Windows.Forms.CheckBox chkMountReadOnly;
        private System.Windows.Forms.Label LblIndex;
        private System.Windows.Forms.ComboBox CmbBoxIndex;
        private System.Windows.Forms.Button BtnOuvrirDossierMonte;
        private System.Windows.Forms.Button BtnDemonterWim;
        private System.Windows.Forms.Button BtnMonterWim;
        private System.Windows.Forms.GroupBox groupBoxSupprimerPilotes;
        private System.Windows.Forms.GroupBox groupBoxAjouterPilotes;
        private System.Windows.Forms.Button btnAjouterPilotes;
        private System.Windows.Forms.Label LblCheminPilote;
        private System.Windows.Forms.Button BtnChoixDossierPilote;
        private System.Windows.Forms.TextBox TxtBoxDossierPilotes;
        private System.Windows.Forms.CheckBox ChkBoxRecurse;
        private System.Windows.Forms.CheckBox ChkBoxForceUnsigned;
        private System.Windows.Forms.Button BtnSupprimePilote;
        private System.Windows.Forms.TextBox TxtBoxNomPilote;
        private System.Windows.Forms.Button BtnAfficheTousPilotes;
        private System.Windows.Forms.Button BtnAffichePilotesWim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAffichePackagesWim;
        private System.Windows.Forms.CheckBox ChkBoxIgnoreVerification;
        private System.Windows.Forms.Label LblDossierPackage;
        private System.Windows.Forms.TextBox TxtBoxDossierPackage;
        private System.Windows.Forms.Button BtnAjoutPackage;
        private System.Windows.Forms.Button BtnChoisirDossierPackage;
        private System.Windows.Forms.Button BtnSupprimePackageBis;
        private System.Windows.Forms.Button BtnSupprimePackage;
        private System.Windows.Forms.Label LblDossierPackagebis;
        private System.Windows.Forms.Label LblNomPackage;
        private System.Windows.Forms.TextBox TxtBoxDossierPackageBis;
        private System.Windows.Forms.TextBox TxtBoxNomPackage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDisableFeature;
        private System.Windows.Forms.Button BtnEnableFeature;
        private System.Windows.Forms.Button BtnAfficheFeatureWim;
        private System.Windows.Forms.CheckBox ChkBoxEnablePackagePath;
        private System.Windows.Forms.CheckBox ChkBoxEnablePackageName;
        private System.Windows.Forms.TextBox TxtBoxFolderPackage;
        private System.Windows.Forms.TextBox TxtBoxFeaturePackageName;
        private System.Windows.Forms.TextBox TxtBoxFeatureName;
        private System.Windows.Forms.Label LblEdition;
        private System.Windows.Forms.Label LblProductKey;
        private System.Windows.Forms.Button BtnFixeEdition;
        private System.Windows.Forms.Button BtnFixeCleProduit;
        private System.Windows.Forms.Button BtnAfficheEditionCible;
        private System.Windows.Forms.Button BtnAfficheEditionCourante;
        private System.Windows.Forms.TextBox TxtBoxEdition;
        private System.Windows.Forms.TextBox TxtBoxProductKey;
        private System.Windows.Forms.Button BtnAppliqueUnattendXML;
        private System.Windows.Forms.Button BtnChoisirXMLUnattend;
        private System.Windows.Forms.TextBox TxtBoxFichierXMLUnattend;
        private System.Windows.Forms.Label LblFichierXMLUnattend;
        private System.Windows.Forms.Label LblFichierMSP;
        private System.Windows.Forms.Label LblPatchCode;
        private System.Windows.Forms.Label LblCodeProduit;
        private System.Windows.Forms.Button BtnChoisirFichierMSP;
        private System.Windows.Forms.Button BtnAfficheInfosPatchsApplications;
        private System.Windows.Forms.Button BtnAfficheApplicationsPatch;
        private System.Windows.Forms.Button BtnAfficheInfosApplications;
        private System.Windows.Forms.Button btnAfficheApplication;
        private System.Windows.Forms.TextBox TxtBoxNomFichierMSP;
        private System.Windows.Forms.TextBox TxtBoxPatchCode;
        private System.Windows.Forms.TextBox TxtBoxCodeProduit;
        private System.Windows.Forms.CheckBox ChkBoxCaptureVerifier;
        private System.Windows.Forms.Label LblCompression;
        private System.Windows.Forms.Label LblNomFichierWIM;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.ComboBox CmbBoxCaptureCompression;
        private System.Windows.Forms.TextBox TxtBoxCaptureNomFichier;
        private System.Windows.Forms.TextBox TxtBoxCaptureDestination;
        private System.Windows.Forms.TextBox TxtBoxCaptureSource;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnCreer;
        private System.Windows.Forms.Button ParcourirDestination;
        private System.Windows.Forms.Button BtnParcourirSource;
        private System.Windows.Forms.Label LblDescriptionWIM;
        private System.Windows.Forms.TextBox TxtBoxCaptureDescriptionWIM;
        private System.Windows.Forms.CheckBox ChkBoxApplyVerifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBoxApplyIndex;
        private System.Windows.Forms.Label LblDestinationBis;
        private System.Windows.Forms.Label LblSourceBis;
        private System.Windows.Forms.TextBox TxtBoxApplyDestination;
        private System.Windows.Forms.Button BtnAppliquerImage;
        private System.Windows.Forms.Button BtnApplyParcourirDestination;
        private System.Windows.Forms.TextBox TxtBoxApplySource;
        private System.Windows.Forms.Button BtnApplyParcourirSource;
        private System.Windows.Forms.Button BtnEffaceConsoleDism;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_ChoisirMSP;
        private System.Windows.Forms.Button BtnVerifierPatchsApplication;
        private System.Windows.Forms.TabPage ExportImage;
        private System.Windows.Forms.Label LblExportName;
        private System.Windows.Forms.TextBox TxtBoxNomFichier;
        private System.Windows.Forms.CheckBox ChkBoxExportCheckIntegrity;
        private System.Windows.Forms.CheckBox ChkBoxExportWimBoot;
        private System.Windows.Forms.CheckBox ChkBoxExportBootable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbBoxExportCompression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBoxExportIndex;
        private System.Windows.Forms.Label LblExportDestination;
        private System.Windows.Forms.Label LblExportSource;
        private System.Windows.Forms.TextBox TxtBoxExportDestination;
        private System.Windows.Forms.Button BtnExportImage;
        private System.Windows.Forms.Button BtnExportChoisirDossier;
        private System.Windows.Forms.TextBox TxtBoxExportSourceFichier;
        private System.Windows.Forms.Button BtnExportChoisirFichier;
        private System.Windows.Forms.TabPage GestionLangue;
        private System.Windows.Forms.Button BtnInfosLangue;
        private System.Windows.Forms.Button BtnAllIntrlAppliquer;
        private System.Windows.Forms.TextBox TxtBoxAllIntl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage ExportDriver;
        private System.Windows.Forms.Label LblExportChoisirDossier;
        private System.Windows.Forms.TextBox TxtBoxExportDossierDriverOffline;
        private System.Windows.Forms.Button BtnExportDriverChoisirDossierOffline;
        private System.Windows.Forms.Button BtnExportDriverOffline;
        private System.Windows.Forms.Button BtnExportDriverOnline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBoxExportDossierDriverOnline;
        private System.Windows.Forms.Button BtnExportDriverChoisirDossierOnline;
        private System.Windows.Forms.TextBox TxtBox_DISMVersion;
        private System.Windows.Forms.Label label10;
    }
}

