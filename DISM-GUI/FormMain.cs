﻿using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace DISM_GUI
{
    public partial class FormMain : Form
    {
        // Boolean Public Property RedirectStandardOutput;
        String StrFolderName;                     // Nom du dossier de montage du fichier WIM
        Boolean WIMMounted = false;               // état du montage du fichier WIM
        String StrMountedImageLocation;           // chemin de montage du WIM
        String StrIndex;                          // index du wim à monter
        String StrWIM;                            // nom du fichier WIM
        String StrOutput;                         // sortie de la console standard (redirigé)
        String StrDISMExitCode;                   // valeur de sortie de la commande DISM.EXE
        Boolean BlnDISMCommit;                    // mémorise état changement du fichier WIM monté
        String StrDriverLocation;                 // chemin ou se trouve les pilotes
        String BlnForceUnsigned;                  // force ou non l'installation de pilotes non signés
        String StrDISMArguments;                  // argument de la ligne de commande DISM.EXE
        String StrPackageLocation;                // chemin vers package en vu de les installer
        String StrLocation;                       // chemin ?
        Boolean BlnIgnoreCheck;                   // ignore la vérification 
        String StrDelDriverLocation;              // chemin des drivers à supprimer
        String StrPackageName;                    // nom des packages à installer
        String StrPackagePath;                    // chemin des packages à installer
        String StrFeatureName;                    // nom des features (services) à installer
        Boolean OnlineMode = false;               // activation du mode ONLINE
        String StrProductKey;                     // Clé d'activation windows
        String StrEdition;                        // type édition produit windows
        String StrXMLFileName;                    // nom du fichier XML (Unattend)
        String StrProductCode;                    // code produit
        String StrPatchCode;                      // chemin code ?
        String StrMSPFileName;                    // ?
        String StrSource;                         // mémorise chemin source
        String StrDest;                           // mémorise chemin destination
        String StrName;                           // mémorise nom ?
        String StrCompression;                    // mémorise compression WIM
        String StrAppendIndex;                    // mémorise Index d'ajout dans WIM

        FormProgress MaFormeProgress = new FormProgress();  // Pour instancier la forme FormProgress
        FormAbout MaFormAbout=new FormAbout();    // pour instancier la forme FormAbout
  

        public FormMain()
        {
            InitializeComponent();
        }

        // MENU TOOLS
        // Ouverture du journal de log de la commande DISM
        // Révision le 19/02/2020
        //
        private void OuvrirLogDISMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String StrWinDir;
            Process OpenDismLog;
            StrWinDir = System.Environment.GetEnvironmentVariable("windir");
            OpenDismLog = new Process();
            Process.Start("Notepad.exe", StrWinDir + "\\Logs\\DISM\\dism.log");
        }

        // MENU TOOLS
        // Information sur le WIM monté
        // Révision le 19/02/2020
        //
        private void informationSurLeWIMMontéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrDISMArguments = "/Get-MountedImageInfo";
            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
            MaFormeProgress.ShowDialog();  // Affiche une Progress Bar
            TxtBoxOutput.Text = StrOutput;
        }

        // Permet de choisir le fichier WIM dans le menu Gestion Montage
        // Révision 19/02/2020
        //
        private void BtnChoisirWim_Click(object sender, EventArgs e)
        {
            OpenFileDialogue_ChoisirWIM.InitialDirectory = "C:\\";
            OpenFileDialogue_ChoisirWIM.Title = "Choisir un fichier WIM à ouvrir";
            OpenFileDialogue_ChoisirWIM.Filter = ("Fichier WIM (*.wim)|*.wim|Fichier ESD (*.ESD)|*.ESD|All Files (*.*)|*.*");
            if (OpenFileDialogue_ChoisirWIM.ShowDialog() == DialogResult.OK)
                TxtFichierWim.Text = OpenFileDialogue_ChoisirWIM.FileName;
        }

        // Permet de choisir le dossier point de montage du fichier WIM menu gestion image
        // Attention il faut finir le bloc, il y a des contrôles à faire
        // Révision 19/02/2020
        //
        private void BtnChoisirDossier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_ChoisirDossier.ShowNewFolderButton = false;
            folderBrowserDialog_ChoisirDossier.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog_ChoisirDossier.ShowDialog() == DialogResult.OK)
            {
                TxtDossierMontage.Text = folderBrowserDialog_ChoisirDossier.SelectedPath;
            }

            //  dlgOpenFolder.ShowDialog()
            //  Dim strFolderName As String = dlgOpenFolder.SelectedPath
            //  Dim dirs As String() = System.IO.Directory.GetDirectories(strFolderName)
            //  Dim files As String() = System.IO.Directory.GetFiles(strFolderName)
            //  If dirs.Length = 0 AndAlso files.Length = 0 Then
            //  txtMount.Text = strFolderName
            //  Else
            //  If MessageBox.Show("You must choose an empty folder to mount the WIM") = DialogResult.OK Then
            //  Else
            //'Do Nothing
            //  End If
            // End If
        }

        // Affiche les informations du WIM sélectionné menu gestion montage menu gestion montage
        // Attention ne pas oublier d'encadrer les arguments avec des guillemets
        //
        private void AfficheWimInfos_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            if (TxtFichierWim.Text == "")
            {
                Result = MessageBox.Show("Vous devez sélectionner un fichier WIM en premier.", "Information WIM", MessageBoxButtons.OK);
            }

            else
            {
                StrWIM = TxtFichierWim.Text;
                StrDISMArguments = "/Get-WimInfo /WimFile:" + "\"" + TxtFichierWim.Text + "\"";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();       // Affiche une progress Bar
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Permet d'exécuter la commande DISM pour monter une image WIM spécifié
        // création d'un nouveau processus (commande dism avec les arguments)
        // qui sera exécuter en tâche de fond de maniére asynchrone
        // Attention ne pas oublier d'encadrer les arguments avec des guillemets
        //
        private void backgroundWorkerMount_DoWork(object sender, DoWorkEventArgs e)
        {
            StrDISMExitCode = "";
            Process DISM = new Process();                   // création d'un nouveau processus
            DISM.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
            DISM.StartInfo.RedirectStandardOutput = true;   // pour la redirection de la sortie standard
            DISM.StartInfo.RedirectStandardError = true;    // pour la redirection du canal d'erreur
            DISM.StartInfo.UseShellExecute = false;         // pas de shell d'exécution
            DISM.StartInfo.CreateNoWindow = true;           // pas de fenêtre d'exécution
            DISM.StartInfo.FileName = "DISM.EXE";           // nom de la commande dos ici dism.exe
            if (chkMountReadOnly.Checked == true)           // vérification si monté en lecture seule
                DISM.StartInfo.Arguments = "/Mount-Wim /WimFile:" + "\"" + StrWIM + "\"" + " /Index:" + StrIndex + " /MountDir:" + "\"" + StrFolderName + "\"" + " /ReadOnly";
            else
                DISM.StartInfo.Arguments = "/Mount-WIM /WimFile:" + "\"" + StrWIM + "\"" + " /Index:" + StrIndex + " /MountDir:" + "\"" + StrFolderName + "\"";

            StrOutput = "Exécution de la ligne de commande: DISM.EXE " + DISM.StartInfo.Arguments;
            TxtBoxOutput.Text = StrOutput;

            DISM.Start();                                   // démarre la commande
            StrOutput = StrOutput + DISM.StandardOutput.ReadToEnd();     // lire les caractères jusqu'a la fin de la commande DISM (octet par octet)
            DISM.WaitForExit();                             // attends la fin de commande
            StrDISMExitCode = DISM.ExitCode.ToString();     // conversion entier vers chaine de caractère (pour l'exit code)
        }



        // Gére le bouton de montage d'un Wim dans le menu Gestion Montage
        // Révision 19/02/2020
        //
        private void BtnMonterWim_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            TxtBoxOutput.Text = "";  // efface le contenu de la sortie console
            if ((TxtFichierWim.Text == "") || (TxtDossierMontage.Text == "") || (CmbBoxIndex.Text == ""))
                Result = MessageBox.Show("Vous devez sélectionner un fichier WIM en premier,puis sélectionner un index ainsi qu'un dossier de montage.", "", MessageBoxButtons.OK);
            else
            {
                StrFolderName = TxtDossierMontage.Text;     // mémorise dossier montage
                StrIndex = CmbBoxIndex.Text;                // idem pour l'index
                StrWIM = TxtFichierWim.Text;                // idem pour le nom du WIM
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerMount.RunWorkerAsync();     // lance la commande de manière asynchrone
                MaFormeProgress.ShowDialog();               // affiche la ProgressBar
                TxtBoxOutput.Text = StrOutput;              // met à jour la sortie console
                WIMMounted = true;                          // le fichier WIM est monté
                StrMountedImageLocation = TxtDossierMontage.Text; // mémorise point de montage de l'image WIM
            }
        }

        // Démontage du WIM préalablement monté dans le menu Gestion Montage
        // Révision 19/02/2020
        //
        private void BtnDemonterWim_Click(object sender, EventArgs e)
        {
            StrFolderName = TxtDossierMontage.Text;     // dossier à démonter
            if (StrFolderName == "")                    // présence d'un ancien point de montage ?
                MessageBox.Show("Aucun précédent dossier de montage détecté. Veuillez sélectionner un dossier de montage.", "", MessageBoxButtons.OK);
            else
            {
                StrIndex = CmbBoxIndex.Text;                // index
                StrWIM = TxtFichierWim.Text;                // chemin + nom fichier WIM à 
                TxtBoxOutput.Text = "";                     // efface la console de sortie DISM
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismount.RunWorkerAsync();  // exécute tâche
                MaFormeProgress.ShowDialog();               // Affiche la barre de progression
                TxtBoxOutput.Text = StrOutput;              // maj de la console
                WIMMounted = false;                         // le fichier WIM n'est plus monté
            }

        }

        // Gestion de la commande de démontage du WIM spécifié via la commande DISM
        // Attention ne pas oublier d'encadrer les arguments avec des guillemets
        //
        private void backgroundWorkerDismount_DoWork(object sender, DoWorkEventArgs e)
        {
            DialogResult Result;
            StrDISMExitCode = "";
            Process DISM;

            Result = MessageBox.Show("Voulez-vous appliquer les changements ?", "WIM monté", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
                BlnDISMCommit = true;
            else
                BlnDISMCommit = false;

            DISM = new Process();
            DISM.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
            DISM.StartInfo.RedirectStandardOutput = true;  // redirection sortie standard
            DISM.StartInfo.RedirectStandardError = true;   // redirection sortie erreur
            DISM.StartInfo.UseShellExecute = false;        // pas de shell
            DISM.StartInfo.CreateNoWindow = true;          // pas de fenêtre 
            DISM.StartInfo.FileName = "DISM.EXE";          // nom exécutable 

            if (BlnDISMCommit == true)  // sauvegarde les modifications du WIM avant démontage
            {
                DISM.StartInfo.Arguments = "/Unmount-Wim /MountDir:" + "\"" + StrFolderName + "\"" + " /Commit";
                StrOutput = "Exécution de la ligne de commande: DISM.EXE " + DISM.StartInfo.Arguments;
                TxtBoxOutput.Text = StrOutput;
                DISM.Start();           // exécute la commande de démontage du fichier WIM
            }

            else
            {
                DISM.StartInfo.Arguments = "/Unmount-Wim /MountDir:" + "\"" + StrFolderName + "\"" + " /Discard";
                StrOutput = "Exécution de la ligne de commande: DISM.EXE " + DISM.StartInfo.Arguments;
                TxtBoxOutput.Text = StrOutput;
                DISM.Start();
            }

            StrOutput = StrOutput + "\n" + "\n" + DISM.StandardOutput.ReadToEnd();  // lire tous les caractères au niveau de la console
            DISM.WaitForExit();                           // attendre la fin de l'exécution de la commande DISM
            StrDISMExitCode = DISM.ExitCode.ToString();   // code de retour de la commande
            TxtBoxOutput.Text = TxtBoxOutput.Text + StrOutput; // mettre à jour les informations de la commande DISM

        }

        // Exécute la commande DISM.EXE avec des arguments spécifiques (à la demande)
        //
        private void backgroundWorkerDismCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            String StrInput = e.Argument.ToString();

            StrDISMExitCode = "";
            Process DISM = new Process();

            DISM.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
            DISM.StartInfo.RedirectStandardOutput = true;       // redirection sortie standard
            DISM.StartInfo.RedirectStandardError = true;        // redirection sortie erreur
            DISM.StartInfo.UseShellExecute = false;             // pas de shell
            DISM.StartInfo.CreateNoWindow = true;               // pas de fenêtre
            DISM.StartInfo.FileName = "DISM.EXE";               // commande DISM.EXE à exécuter
            DISM.StartInfo.Arguments = StrInput;                // arguments passé à la fonction
            StrOutput = "Exécution de la ligne de commande: DISM.EXE " + DISM.StartInfo.Arguments;
            DISM.Start();                                        // exécute la commande DISM.EXE avec ses arguments
            StrOutput = StrOutput + "\n" + "\n" + DISM.StandardOutput.ReadToEnd();        // tous les caractères jusqu'à la fin de l'exécution de la commande
            DISM.WaitForExit();                                // attend la fin d'exécution de la commande DISM
            StrDISMExitCode = DISM.ExitCode.ToString();        // code de retour de la fonction (DISM.EXE)
            TxtBoxOutput.Text = TxtBoxOutput.Text + StrOutput; // mettre à jour les informations de la commande DISM
        }

        // Ouvre L'explorer sur le dossier WIM préalablement monté menu gestion montage
        // Révision 19/02/2020
        //
        private void BtnOuvrirDossierMonte_Click(object sender, EventArgs e)
        {
            Process DISM = new Process();
            Process.Start("explorer.exe", TxtDossierMontage.Text);
        }

        // Permet de choisir le dossier ou se trouve les pilotes à ajouter au fichier WIM dans menu Gestion Pilotes
        // on pourrait aussi filtrer les fichiers INF, à voir...
        // Révision 19/02/2020
        //
        private void BtnChoixDossierPilote_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
                TxtBoxDossierPilotes.Text = Dossier.SelectedPath;
        }

        // Permet d'ajouter des pilotes dans un WIM préalablement monté menu Gestion driver
        // Attention ne pas oublier d'encadrer les arguments avec des guillemets
        // Révision 19/02/2020
        //
        private void btnAjouterPilotes_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)                                    // WIM non monté
                MessageBox.Show("Aucun WIM Monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxDossierPilotes.Text == "")                    // WIM monté et dossier pilote non référencé
                    MessageBox.Show("Vous devez spécifier un dossier comportant les pilotes.");
                else
                {                                                       // WIM monté et dossier pilote renseigné 
                    StrDriverLocation = TxtBoxDossierPilotes.Text;      // non utile, mémorise dossier pilotes pour un usage futur
                    if (ChkBoxForceUnsigned.Checked == true)            // force l'installation des pilotes non signés
                        StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Add-Driver /Driver:" + "\"" + TxtBoxDossierPilotes.Text + "\"" + " /ForceUnsigned ";
                    else                                                // présence de pilotes signés
                        StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Add-Driver /Driver:" + "\"" + TxtBoxDossierPilotes.Text + "\"";
                    if (ChkBoxRecurse.Checked == true)
                        StrDISMArguments = StrDISMArguments + " /Recurse";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();                       // Affiche la progress bar
                    TxtBoxOutput.Text = StrOutput;
                }

            }

        }

        // Permet d'afficher l'ensemble des pilotes présent dans le WIM monté
        // Révision 19/02/2020
        //
        private void BtnAfficheTousPilotes_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)            // si fichier WIM démonté
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {                                   // si fichier WIM monté
                //StrDelDriverLocation = txtDelDriverLocation.Text;
                StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-Drivers /All";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Permet de supprimer un pilote menu gestion pilotes
        // Attention, le nom du pilote doit être le nom publié cf affichage de tous les pilotes
        // Révision 19/02/2020
        //
        private void BtnSupprimePilote_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)    // aucun fichier WIM monté
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {                           // un WIM est monté, mais nom du pilote incorrect
                if (TxtBoxNomPilote.Text == "")
                    // Or Microsoft.VisualBasic.Left(txtDelDriverLocation.Text, 3) <> "inf"
                    MessageBox.Show("Vous devez entrer un nom de pilote avant de continuer. Le nom du pilote doit se terminer par .inf");
                else
                {
                    StrDelDriverLocation = TxtBoxNomPilote.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Remove-Driver /Driver:" + "\"" + TxtBoxNomPilote.Text + "\"";
                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche une progress bar
                    TxtBoxOutput.Text = StrOutput;
                }
            }
        }

        // Permet d'afficher les pilotes d'un WIM menu gestion drivers
        // Révision 19/02/2020
        //
        private void BtnAffichePilotesWim_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-Drivers";  // ré-utilise la variable (globale StrMountedImageLocation)
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                // BackgroundGetDrivers.RunWorkerAsync()
                MaFormeProgress.ShowDialog();       // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;
            }

        }

        // affiche les package présent dans le WIM
        // Révision 19/02/2020
        //
        private void BtnAffichePackagesWim_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)        // wim non monté
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {                               // wim monté
                StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-Packages";
                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();       // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Permet de choisir le dossier package menu Gestion Package
        // Révision 19/02/2020
        //
        private void BtnChoisirDossierPackage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
                TxtBoxDossierPackage.Text = Dossier.SelectedPath;
        }

        // Permet d'ajouter un package menu Gestion Packages
        // Révision 19/02/2020
        //
        private void BtnAjoutPackage_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)                    // vérifie si une image est montée
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxDossierPackage.Text == "")    // chemin vers packages présent ?
                    MessageBox.Show("Vous devez spécifier un dossier ou se trouve le package.");
                else
                {
                    StrPackageLocation = TxtBoxDossierPackage.Text;  // non utile, sauf pour un usage ultérieur
                    if (ChkBoxIgnoreVerification.Checked == true)   // ignore les vérifications
                    {
                        BlnIgnoreCheck = true;          // 
                        StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Add-Package /PackagePath:" + "\"" + TxtBoxDossierPackage.Text + "\"" + " /IgnoreCheck";

                    }
                    else
                    {
                        BlnIgnoreCheck = false;                     // effectue les vérifications
                        StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Add-Package /PackagePath:" + "\"" + TxtBoxDossierPackage.Text + "\"";
                    }
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();               // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;              // mise à jour des messages dans la console
                }

            }
        }

        // Permet de supprimer un package menu Gestion Package
        // Révision 19/02/2020
        //
        private void BtnSupprimePackage_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxNomPackage.Text == "")
                    MessageBox.Show("Vous devez saisir un nom de package avant de continuer.");
                else
                {
                    StrPackageName = TxtBoxNomPackage.Text;  // non utile sauf pour un usage ultérieur
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Remove-Package /PackageName:" + TxtBoxNomPackage.Text;
                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();            // Affiche une progress bar
                    TxtBoxOutput.Text = StrOutput;           // mise à jour des messages dans console
                }

            }

        }

        // Affiche les Features présent dans le WIM préalablement monté Menu Gestion Features
        // Révision 19/02/2020
        //
        private void BtnAfficheFeatureWim_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-Features";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();   // Affiche la progress Bar
                TxtBoxOutput.Text = StrOutput;

            }
        }

        // Active un feature dans un WIM menu Gestion Features
        // Révision 19/02/2020
        //
        private void BtnEnableFeature_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxFeatureName.Text == "")
                    MessageBox.Show("La saisie du champ nom feature est requise pour continuer.");
                else
                {
                    if ((ChkBoxEnablePackageName.Checked == true) && (TxtBoxFeaturePackageName.Text == ""))
                        MessageBox.Show("Si vous validez le champ nom package, vous devez le renseigner");
                    else
                    {
                        if ((ChkBoxEnablePackagePath.Checked == true) && (TxtBoxFolderPackage.Text == ""))
                            MessageBox.Show("Si vous validez le champ dossier package, vous devez le renseigner");
                        else
                        {
                            StrFeatureName = TxtBoxFeatureName.Text;  // non utile, sauf pour un usage futur
                            StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Enable-Feature /FeatureName:" + "\"" + TxtBoxFeatureName.Text + "\"";
                            if (ChkBoxEnablePackageName.Checked == true)
                                StrDISMArguments = StrDISMArguments + "/PackageName:" + "\"" + TxtBoxFeaturePackageName.Text + "\"";
                            else
                            {
                                if (ChkBoxEnablePackagePath.Checked == true)
                                    StrDISMArguments = StrDISMArguments + "/PackagePath:" + "\"" + TxtBoxFolderPackage.Text + "\"";
                                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                                MaFormeProgress.ShowDialog();       // Affiche la Progress Bar
                                TxtBoxOutput.Text = StrOutput;
                            }

                        }
                    }

                }

            }

        }

        // Permet de choisir un fichier XML (Unattend.xml) pour le WIM menu Service Unattend
        // Révision 19/02/2020
        //
        private void BtnChoisirXMLUnattend_Click(object sender, EventArgs e)
        {
            OpenFileDialog MaBoiteDialogue = new OpenFileDialog();                        // instance de boite de dialogue
            MaBoiteDialogue.InitialDirectory = "c:\\";                                  // on démarre la recherche depuis le lecteur C:
            MaBoiteDialogue.Title = "Choisir un fichier XML ouvrir";                    // le titre
            MaBoiteDialogue.Filter = ("Fichier XML (*.xml)|*.XML|All Files (*.*)|*.*"); // le filtre fichier
            if (MaBoiteDialogue.ShowDialog() == DialogResult.OK)                        // si confirmation   
            {
                TxtBoxFichierXMLUnattend.Text = MaBoiteDialogue.FileName;               // récupére le fichier
                StrXMLFileName = TxtBoxFichierXMLUnattend.Text;                         // mémorise le nom du fichier       
            }
        }

        // Applique le fichier Unattend.XML au WIM préalablement monté menu Service Unattend
        // Révision 19/02/2020
        //
        private void BtnAppliqueUnattendXML_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxFichierXMLUnattend.Text == "")
                    MessageBox.Show("Vous devez spécifier un fichier XML.");
                else
                {
                    StrXMLFileName = TxtBoxFichierXMLUnattend.Text;                       // non utile, mémorise fichier XML pour un usage futur
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Apply-Unattend:" + "\"" + TxtBoxFichierXMLUnattend.Text + "\"";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }
            }
        }

        // Permet de parcourir le dossier source menu Capture Image
        // Révision 19/02/2020
        //
        private void BtnParcourirSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MaBoiteDossierDialogue = new FolderBrowserDialog();     // instance boite dialogue recherche dossier
            MaBoiteDossierDialogue.ShowNewFolderButton = false;
            MaBoiteDossierDialogue.RootFolder = Environment.SpecialFolder.MyComputer;
            if (MaBoiteDossierDialogue.ShowDialog() == DialogResult.OK)                 // si confirmation   
            {
                TxtBoxCaptureSource.Text = MaBoiteDossierDialogue.SelectedPath;         // récupére le fichier sélectionné par l'utilisateur
                StrFolderName = TxtBoxCaptureSource.Text;                               // non utile, mémorise le dossier source pour un usage futur
            }

            // Dim dirs As String() = System.IO.Directory.GetDirectories(strFolderName)
            // Dim files As String() = System.IO.Directory.GetFiles(strFolderName)
            // If dirs.Length = 0 AndAlso files.Length = 0 Then
            // If MessageBox.Show("You must choose a non-empty folder.") = DialogResult.OK Then
        }

        // Permet de parcourir le dossier destination menu Capture Image
        // Révision 19/02/2020
        //
        private void ParcourirDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MaBoiteDossierDialogue = new FolderBrowserDialog();     // instance boite dialogue recherche dossier
            MaBoiteDossierDialogue.ShowNewFolderButton = false;
            MaBoiteDossierDialogue.RootFolder = Environment.SpecialFolder.MyComputer;
            if (MaBoiteDossierDialogue.ShowDialog() == DialogResult.OK)                 // si confirmation   
                TxtBoxCaptureDestination.Text = MaBoiteDossierDialogue.SelectedPath;    // récupére le fichier sélectionné par l'utilisateur
        }

        // Créer un fichier WIM de capture d'une partition menu Capture Image
        // Révision 19/02/2020
        //
        private void BtnCreer_Click(object sender, EventArgs e)
        {
            if (TxtBoxCaptureSource.Text == "")                // fichier source présent
                MessageBox.Show("Vous devez sélectionner un dossier source.");
            else
            {
                if (TxtBoxCaptureDestination.Text == "")       // fichier destination présent
                    MessageBox.Show("Vous devez sélectionner un fichier destination.");
                else
                {
                    if (TxtBoxCaptureNomFichier.Text == "")    // nom fichier renseigné
                        MessageBox.Show("Vous devez saisir un nom pour le fichier WIM de destination.");
                    else
                    {
                        if (TxtBoxCaptureDescriptionWIM.Text == "")
                            MessageBox.Show("Vous devez renseigner le champ description WIM.");
                        else
                        {
                            StrSource = TxtBoxCaptureSource.Text;           // non utile, mémorisation pour un usage futur
                            StrDest = TxtBoxCaptureDestination.Text;        // non utile, mémorisation pour un usgae futur
                            StrName = TxtBoxCaptureNomFichier.Text;         // non utile, mémorisation pour un usage futur
                            StrCompression = CmbBoxCaptureCompression.Text; // non utile, mémorisation pour un usgae futur

                            if (ChkBoxCaptureVerifier.Checked == true)      // arguments avec option de vérification
                                StrDISMArguments = "/Capture-Image /ImageFile:" + "\"" + TxtBoxCaptureDestination.Text + "\\" + TxtBoxCaptureNomFichier.Text + "\"" + " /CaptureDir:" + "\"" + TxtBoxCaptureSource.Text + "\"" + " /Name:" + "\"" + TxtBoxCaptureDescriptionWIM.Text + "\"" + " /Compress:" + StrCompression + " /Verify";
                            else
                                StrDISMArguments = "/Capture-Image /ImageFile:" + "\"" + TxtBoxCaptureDestination.Text + "\\" + TxtBoxCaptureNomFichier.Text + "\"" + " /CaptureDir:" + "\"" + TxtBoxCaptureSource.Text + "\"" + " /Name:" + "\"" + TxtBoxCaptureDescriptionWIM.Text + "\"" + " /Compress:" + StrCompression;

                            TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                            MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                            TxtBoxOutput.Text = StrOutput;
                        }
                    }
                    
                }
            }


        }

        // Permet d'ajouter une image dans un WIM existant menu Capture Image
        // Révision le 19/02/2020
        //
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtBoxCaptureSource.Text == "")                             // fichier source présent
                MessageBox.Show("Vous devez sélectionner un dossier source.");
            else
            {
                if (TxtBoxCaptureDestination.Text == "")                    // fichier destination présent
                    MessageBox.Show("Vous devez sélectionner un fichier destination.");
                else
                {
                    if (TxtBoxCaptureNomFichier.Text == "")                 // nom fichier WIM renseigné
                        MessageBox.Show("Vous devez saisir un nom pour le fichier WIM de destination.");
                    else
                    {
                        if (TxtBoxCaptureDescriptionWIM.Text == "")
                            MessageBox.Show("Vous devez renseigner le champ description WIM.");
                        else
                        {
                            StrSource = TxtBoxCaptureSource.Text;               // non utile, mémorise source
                            StrDest = TxtBoxCaptureDestination.Text;            // non utile, mémorise destination
                            StrName = TxtBoxCaptureDescriptionWIM.Text;             // non utile, mémorise nom fichier
                            StrCompression = CmbBoxCaptureCompression.Text;     // non utile, mémorise niveau de compression

                            StrDISMArguments = "/Append-Image /ImageFile:" + "\"" + TxtBoxCaptureDestination.Text + "\\" + TxtBoxCaptureNomFichier.Text + "\"" + " /CaptureDir:" + "\"" + TxtBoxCaptureSource.Text + "\"" + " /Name:" + "\"" + TxtBoxCaptureDescriptionWIM.Text + "\"";
                            TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                            MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                            TxtBoxOutput.Text = StrOutput;
                        }
                        
                    }
                }
            }

        }

        //  Permet d'appliquer une image WIM menu Appliquer Image
        //  révision le 19/02/2020
        //
        private void BtnAppliquerImage_Click(object sender, EventArgs e)
        {
            if (TxtBoxApplySource.Text == "")                           // fichier WIM source référencé ?
                MessageBox.Show("Vous devez sélectionner un fichier source WIM.");
            else
            {
                if (TxtBoxApplyDestination.Text == "")                  // dossier destination référencé ?
                    MessageBox.Show("Vous devez sélectionner un dossier destination.");
                else
                {
                    if (CmbBoxApplyIndex.Text == "")                    // index image WIM référencé ?
                        MessageBox.Show("Vous devez sélectionner un numéro d'index.");
                    else
                    {
                        StrFolderName = TxtBoxApplyDestination.Text;    // non utile mémorise le dossier destination, dans un but de futur utilisation
                        StrSource = TxtBoxApplySource.Text;             // non utile mémorise le nom et chemin du fichier source
                        StrDest = TxtBoxApplyDestination.Text;          // non utile mémorise le dossier destination
                        StrAppendIndex = CmbBoxApplyIndex.Text;         // non utile mémorise l'index du fichier WIM

                        if (ChkBoxApplyVerifier.Checked == true)        // paramètres arguments ligne de commande avec vérification
                            StrDISMArguments = "/Apply-Image /ImageFile:" + "\"" + TxtBoxApplySource.Text + "\"" + " /Index:" + CmbBoxApplyIndex.Text + " /ApplyDir:" + "\"" + TxtBoxApplyDestination.Text + "\"" + " /Verify";
                        else                                            // paramètres arguments ligne de commande sans vérification
                            StrDISMArguments = "/Apply-Image /ImageFile:" + "\"" + TxtBoxApplySource.Text + "\"" + " /Index:" + CmbBoxApplyIndex.Text + " /ApplyDir:" + "\"" + TxtBoxApplyDestination.Text + "\"";
                        TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                        backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
                        MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                        TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)
                    }
                }
            }
        }

        // Permet de fixer le fichier source WIM à appliquer par la suite menu Appliquer Image
        // Révision le 19/02/2020
        //
        private void BtnApplyParcourirSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog MaBoiteDialogue = new OpenFileDialog();      // instance de boite de dialogue
            MaBoiteDialogue.InitialDirectory = "C:\\";                  // on démarre la recherche depuis le lecteur C:
            MaBoiteDialogue.Title = "Choisir un fichier WIM ouvrir";    // le titre
            MaBoiteDialogue.Filter = ("Fichier WIM (*.wim)|*.wim|All Files (*.*)|*.*"); // le filtre fichier
            if (MaBoiteDialogue.ShowDialog() == DialogResult.OK)        // si confirmation   
                TxtBoxApplySource.Text = MaBoiteDialogue.FileName;      // récupére le fichier sélectionné par l'utilisateur
        }

        // Permet de fixer le dossier destination du fichier WIM menu Appliquer Image
        // Révision le 19/02/2020
        //
        private void BtnApplyParcourirDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MaBoiteDossierDialogue = new FolderBrowserDialog();     // instance boite dialogue recherche dossier
            MaBoiteDossierDialogue.ShowNewFolderButton = false;
            MaBoiteDossierDialogue.RootFolder = Environment.SpecialFolder.MyComputer;
            if (MaBoiteDossierDialogue.ShowDialog() == DialogResult.OK)                  // si confirmation
                TxtBoxApplyDestination.Text = MaBoiteDossierDialogue.SelectedPath;       // récupére le chemin du dossier sélectionné par l'utilisateur
        }

        // Efface le contenu de la console DISM
        // Révision 19/02/2020
        // Attention modifier le test de l'extension du fichier .CAB
        // 
        private void BtnEffaceConsoleDism_Click(object sender, EventArgs e)
        {
            TxtBoxOutput.Text = "";
        }

        // Permet de supprimer un package Menu Gestion Packages
        // Révision 19/02/2020
        //
        private void BtnSupprimePackageBis_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)  // s'assure qu'un fichier WIM est monté
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxDossierPackageBis.Text == "")
                    MessageBox.Show("Vous devez saisir un dossier de package avant de continuer, il doit comporter une extension .CAB valide.");
                else
                {
                    StrPackagePath = TxtBoxDossierPackageBis.Text;  // non utile, sauf pour usage ultérieur
                    StrDISMArguments = "/Image:" + StrMountedImageLocation + " /Remove-Package /PackagePath:" + TxtBoxDossierPackageBis.Text;
                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();                   // Affiche une progress bar
                    TxtBoxOutput.Text = StrOutput;                  // mise à jour messages console
                }
            }

        }

        // Permet de désactiver un feature dans un WIM préalablemnt monté Menu Festion Features
        // Révision 19/02/2020
        //
        private void BtnDisableFeature_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxFeatureName.Text == "")
                    MessageBox.Show("Un nom de feature est requis pour continuer.");
                else
                {
                    if ((ChkBoxEnablePackageName.Checked == true) && (TxtBoxFeaturePackageName.Text == ""))
                        MessageBox.Show("si vous activez le champs nom du package, vous devez spécifier le nom du package");
                    else
                    {
                        if (ChkBoxEnablePackagePath.Checked == true)
                            MessageBox.Show("L'option dossier package ne peut être utilisé pour désactiver un feature. La valeur de ce champ sera ignoré.");

                        else
                        {
                            StrFeatureName = TxtBoxFeatureName.Text;
                            StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Disable-Feature /FeatureName:" + "\"" + TxtBoxFeatureName.Text + "\"";
                            if (ChkBoxEnablePackageName.Checked == true)
                                StrDISMArguments = StrDISMArguments + "/PackageName:" + "\"" + TxtBoxFeaturePackageName.Text + "\"";
                            TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                            MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                            TxtBoxOutput.Text = StrOutput;
                        }
                    }

                }
            }
        }

        // Vérifie que le WIM est monté correctement et arrête la progress bar
        // Révision 19/02/2020
        //
        private void backgroundWorkerMount_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // vérification si le WIM est monté correctement
            if (StrDISMExitCode == "0")                         // retour de fonction "0" tout est ok
            {
                BtnMonterWim.Enabled = false;                   // désactive le bouton BtnMonterWim
                BtnDemonterWim.Enabled = true;                  // active le bouton BtnDemonterWim
                WIMMounted = true;                              // mémorise que le WIM est monté
                if (StrMountedImageLocation == "")
                    StrMountedImageLocation = StrFolderName;
                MaFormeProgress.Close();                        // ferme la forme barre de progression
            }
        }

        private void backgroundWorkerDismCommand_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StrDISMArguments = "";      // remise à zéro des arguments
            MaFormeProgress.Close();    // Referme la Form FormProgress
        }

        private void backgroundWorkerDismount_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // vérifie qu'il n'y a pas d'erreur au niveau de la commande DISM
            if (StrDISMExitCode == "0")
            {
                BtnMonterWim.Enabled = true;        // Active le bouton Monter WIM du menu Gestion Montage
                BtnDemonterWim.Enabled = false;     // Désactive le bouton Démonter WIM du menu Gestion Montage
                WIMMounted = false;                 // Il n'y a plus de WIM monté
                StrMountedImageLocation = "";       // on libère la variable lieu du montage du fichier WIM
                MaFormeProgress.Close();            // on referme la form FormProgress
            }
            else MaFormeProgress.Close();           // on referme la form FormProgress
        }

        // sur chargement de la forme principale
        // Révision 19/02/2020
        // 
        private void FormMain_Load(object sender, EventArgs e)
        {
            CmbBoxIndex.Text = "1";                 // Fixe le premier index du menu Gestion Montage
            CmbBoxCaptureCompression.Text = "Fast"; // Fixe le niveau de compression du menu Gestion Capture
            CmbBoxApplyIndex.Text = "1";            // fixe le niveau de la compression du menu Appliquer Image
        }

        // Evenement sur en cours de chargement de la forme principale
        // Révision 19/02/2020
        // 
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûre de vouloir quitter ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (WIMMounted == true)
                {
                    if (MessageBox.Show("Vous avez actuellement un WIM monté. Voulez vous le démonter avant de quitter ?", "WIM monté", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        backgroundWorkerDismount.RunWorkerAsync();
                        MaFormeProgress.Show();
                        MessageBox.Show("Veuillez vérifier si une autre fenêtre est masquée par celle-ci et répondez à la question posée.\nPatientez et ne pas cliquer sur le bouton OK de cette fenêtre, celle-ci va disparaitre d'elle même.\nMerci");
                    }
                    else e.Cancel = false;
                }
            }
            else e.Cancel = true;
        }

        // Permet de fixer la clé produit de WINDOWS menu Service Edition
        // Révision le 19022020
        //

        private void BtnFixeCleProduit_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxProductKey.Text == "")
                    MessageBox.Show("Une clé produit est requise pour continuer.");

                else
                {
                    StrProductKey = TxtBoxProductKey.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Set-ProductKey:" + StrProductKey;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }
            }
        }

        // Permet de fixer l'édition cible de windows menu Service Edition
        // Révision le 19022020
        //
        private void BtnFixeEdition_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxEdition.Text == "")
                    MessageBox.Show("Edition ciblé est requis pour continuer.");
                else
                {
                    StrEdition = TxtBoxEdition.Text;
                    StrProductKey = TxtBoxProductKey.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Set-Edition:" + StrEdition;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }

            }

        }

        // Permet d'afficher l'édition courante Menu Service Edition
        // Révision le 19/02/2020
        //
        private void BtnAfficheEditionCourante_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                StrDISMArguments = "/Image:" + StrMountedImageLocation + " /Get-CurrentEdition";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Permet de fixer l'édition cible
        // Révision le 19/02/2020
        //
        private void BtnFixeEditionCible_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                StrDISMArguments = "/Image:" + StrMountedImageLocation + " /Get-TargetEditions";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Permet de choisir le fichier MSP Menu Service Applications
        // Révision le 19/02/2020
        //
        private void BtnChoisirFichierMSP_Click(object sender, EventArgs e)
        {

            String StrMSPFileName;
            OpenFileDialog_ChoisirMSP.InitialDirectory = "C:\\";
            OpenFileDialog_ChoisirMSP.Title = "Choisir un fichier Unattend XML à ouvrir";
            OpenFileDialog_ChoisirMSP.Filter = ("Fichier MSP (*.msp)|*.msp|Tous Fichier (*.*)|*.*");

            if (OpenFileDialog_ChoisirMSP.ShowDialog() == DialogResult.Cancel)
            {
                // rien
            }
            else
            {
                StrMSPFileName = OpenFileDialog_ChoisirMSP.FileName;
                TxtBoxNomFichierMSP.Text = StrMSPFileName;
            }
        }

        // Affiche les applications Menu Service Application
        // Révision le 19/02/2020
        //
        private void btnAfficheApplication_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                StrDISMArguments = "/Image:" + StrMountedImageLocation + " /Get-Apps";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                MaFormeProgress.ShowDialog();   // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Affiche les infos des applications
        // Révision le 19/02/2020
        //
        private void BtnAfficheInfosApplications_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxCodeProduit.Text == "{        -    -    -    -            }")
                {
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppInfo";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                }
                else
                {
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppInfo /ProductCode:" + StrProductCode;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                }
                TxtBoxOutput.Text = StrOutput;
            }
        }

        // Affiche les patchs d'applications
        // Révision le 19/02/2020
        //
        private void BtnAfficheApplicationsPatch_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxCodeProduit.Text == "{        -    -    -    -            }")
                {
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatches";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }
                else
                {
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatches  /ProductCode:" + StrProductCode;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }
            }
        }

        // Permet d'afficher les informations sur les patchs d'applications
        // Révision le 19/02/2020
        //
        private void BtnAfficheInfosPatchsApplications_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if ((TxtBoxPatchCode.Text == "{        -    -    -    -            }") && (TxtBoxCodeProduit.Text == "{        -    -    -    -            }"))
                {
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatchInfo";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }

                if ((TxtBoxPatchCode.Text != "{        -    -    -    -            }") && (TxtBoxCodeProduit.Text == "{        -    -    -    -            }"))
                {
                    StrPatchCode = TxtBoxPatchCode.Text;
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatchInfo /PatchCode:" + StrPatchCode;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }

                if ((TxtBoxPatchCode.Text == "{        -    -    -    -            }") && (TxtBoxCodeProduit.Text != "{        -    -    -    -            }"))
                {
                    StrPatchCode = TxtBoxPatchCode.Text;
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatchInfo /ProductCode:" + StrProductCode;
                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }

                if ((TxtBoxPatchCode.Text != "{        -    -    -    -            }") && (TxtBoxCodeProduit.Text != "{        -    -    -    -            }"))
                {
                    StrPatchCode = TxtBoxPatchCode.Text;
                    StrProductCode = TxtBoxCodeProduit.Text;
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-AppPatchInfo /PatchCode:" + StrPatchCode + " /ProductCode:" + StrProductCode;
                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;

                }
            }
        }

        // Permet de vérifier les patchs des applications Menu Service Applications
        // Révision le 19/02/2020
        //
        private void BtnVerifierPatchsApplication_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)
                MessageBox.Show("Aucun WIM monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxNomFichierMSP.Text == "")
                    MessageBox.Show("Vous devez entrer un fichier MSP.");
                else
                {
                    StrMSPFileName = TxtBoxNomFichierMSP.Text;
                    StrDISMArguments = "/Image:" + StrMountedImageLocation + " /Check-AppPatch /PatchLocation:" + StrMSPFileName;
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
                    MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;
                }

            }

        }

        // Permet de nettoyer le fichier WIM Menu Tools
        // Révision le 19/02/2020
        //
        private void nettoyerLeWIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrDISMArguments = "/Cleanup-WIM";
            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
            MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
            TxtBoxOutput.Text = StrOutput;
        }

        // Permet de nettoyer l'image Menu tools
        // Révision le 19/02/2020
        //
        private void nettoyerLimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrDISMArguments = "/Image:" + "`\"" + StrMountedImageLocation + "\"" + " /Cleanup-Image /RevertPendingActions";
            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);
            MaFormeProgress.ShowDialog();  // Affiche la Progress Bar
            TxtBoxOutput.Text = StrOutput;
        }

        // Permet de passer en mode ONLINE
        // Révision le 19/02/2020
        //
        private void utiliserLeModeOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (UseOnlineModeToolStripMenuItem.CheckState == CheckState.Checked)
            //{
            //    OnlineMode = true;
            //    btnMount.Enabled = false;
            //    btnOpenFolder.Enabled = false;
            //}
            //else
            //{
            //    OnlineMode = false;
            //    btnMount.Enabled = true;
            //    btnOpenFolder.Enabled = true;
            //}
        }

        // Choisir le dossier destination Menu Export Image
        // Révision 26/02/2020
        //
        private void BtnExportChoisirDossier_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
                TxtBoxExportDestination.Text = Dossier.SelectedPath;
        }

        // Choisir un fichier source Menu Export Image
        // Révision 26/02/2020
        //
        private void BtnExportChoisirFichier_Click(object sender, EventArgs e)
        {
            String NomFichierSource;
            OpenFileDialog OuvrirBoiteDialogue = new OpenFileDialog();
            OuvrirBoiteDialogue.InitialDirectory = "C:\\";
            OuvrirBoiteDialogue.Title = "Choisir un fichier source ESD à ouvrir";
            OuvrirBoiteDialogue.Filter = ("Fichier ESD (*.esd)|*.esd|Tous Fichier (*.*)|*.*");

            if (OuvrirBoiteDialogue.ShowDialog() == DialogResult.Cancel)
            {
                // rien
            }
            else
            {
                NomFichierSource = OuvrirBoiteDialogue.FileName;
                TxtBoxExportSourceFichier.Text = NomFichierSource;
            }
        }

        // Export d'une image esd Menu Export Image
        // Révision 26/02/2020
        //
        private void BtnExportImage_Click(object sender, EventArgs e)
        {
            String FicSrc;
            String FicDest;
            String FicNom;
            String Index;
            String Compr;

            if (TxtBoxExportSourceFichier.Text == "")                    // fichier WIM source référencé ?
                MessageBox.Show("Vous devez sélectionner un fichier source esd ou WIM.");
            else
            {
                if (TxtBoxExportDestination.Text == "")                  // dossier destination référencé ?
                    MessageBox.Show("Vous devez sélectionner un dossier destination.");
                else
                    if (TxtBoxNomFichier.Text == "")
                    MessageBox.Show("Vous devez sélectionner un nom de fchier destination.");
                else
                {
                    if (CmbBoxExportIndex.Text == "")                    // index image WIM référencé ?
                        MessageBox.Show("Vous devez sélectionner un numéro d'index.");
                    else
                        if (CmbBoxExportCompression.Text == "")
                        MessageBox.Show("Vous devez sélectionner un mode de compression.");
                    else
                    {
                        FicSrc = TxtBoxExportSourceFichier.Text;
                        FicDest = TxtBoxExportDestination.Text;
                        FicNom = TxtBoxNomFichier.Text;
                        Index = CmbBoxExportIndex.Text;
                        Compr = CmbBoxExportCompression.Text;

                        StrDISMArguments = "/Export-Image /SourceImageFile:" + "\"" + FicSrc + "\"" + " /SourceIndex:" + Index + " /DestinationImageFile:" + "\"" + FicDest + "\\" + FicNom + "\"" + " /Compress:" + Compr;

                        if (ChkBoxExportBootable.Checked == true)
                            StrDISMArguments = StrDISMArguments + " /Bootable";
                        if (ChkBoxExportWimBoot.Checked == true)
                            StrDISMArguments = StrDISMArguments + " /WIMBoot";
                        if (ChkBoxExportCheckIntegrity.Checked == true)
                            StrDISMArguments = StrDISMArguments + " /CheckIntegrity";
                        TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                        backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
                        MaFormeProgress.ShowDialog();                   // Affiche la Progress Bar
                        TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)
                    }
                }
            }
        }

        // permet d'obtenir des informations sur la langue
        // Révision 26/02/2020
        //
        private void BtnInfosLangue_Click(object sender, EventArgs e)
        {
            StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Get-Intl";
            TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
            MaFormeProgress.ShowDialog();                   // Affiche la Progress Bar
            TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)
        }

        // Fixe la langue par défaut à une valeur
        // Révision 26/02/2020
        //
        private void BtnAllIntrlAppliquer_Click(object sender, EventArgs e)
        {
            if (TxtBoxAllIntl.Text == "")
                MessageBox.Show("Vous devez renseigner le champ //Set-AllIntl.");
            StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Set-AllIntl:" + TxtBoxAllIntl.Text;
            TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

            backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
            MaFormeProgress.ShowDialog();                   // Affiche la Progress Bar
            TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)

        }

        // Permet de choisir un dossier pour la sauvegarde des drivers Offline
        // Révision 27/02/2020
        //
        private void BtnExportDriverChoisirDossierOffline_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MaBoiteDossierDialogue = new FolderBrowserDialog();     // instance boite dialogue recherche dossier
            MaBoiteDossierDialogue.ShowNewFolderButton = false;
            MaBoiteDossierDialogue.RootFolder = Environment.SpecialFolder.MyComputer;
            if (MaBoiteDossierDialogue.ShowDialog() == DialogResult.OK)                  // si confirmation
                TxtBoxExportDossierDriverOffline.Text = MaBoiteDossierDialogue.SelectedPath;       // récupére le chemin du dossier sélectionné par l'utilisateur
        }

        // Permet de choisir un dossier pour la sauvegarde des drivers Online
        // Révision 27/02/2020
        //
        private void BtnExportDriverChoisirDossierOnline_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MaBoiteDossierDialogue = new FolderBrowserDialog();     // instance boite dialogue recherche dossier
            MaBoiteDossierDialogue.ShowNewFolderButton = false;
            MaBoiteDossierDialogue.RootFolder = Environment.SpecialFolder.MyComputer;
            if (MaBoiteDossierDialogue.ShowDialog() == DialogResult.OK)                  // si confirmation
                TxtBoxExportDossierDriverOnline.Text = MaBoiteDossierDialogue.SelectedPath;       // récupére le chemin du dossier sélectionné par l'utilisateur
        }

        // Permet de sauvegarder les drivers en mode Offline
        // Révision 27/02/2020
        //
        private void BtnExportDriverOffline_Click(object sender, EventArgs e)
        {
            if (WIMMounted == false)                                    // WIM non monté
                MessageBox.Show("Aucun WIM Monté. Vous devez monter un WIM avant d'exécuter cette commande.");
            else
            {
                if (TxtBoxExportDossierDriverOffline.Text == "")
                    MessageBox.Show("Vous devez renseigner le champ Dossier (offline).");
                else
                {
                    StrDISMArguments = "/Image:" + "\"" + StrMountedImageLocation + "\"" + " /Export-Driver" + " /Destination:" + "\"" + TxtBoxExportDossierDriverOffline.Text + "\"";
                    TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                    backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
                    MaFormeProgress.ShowDialog();                   // Affiche la Progress Bar
                    TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)
                }
            }
        }

        private void BtnExportDriverOnline_Click(object sender, EventArgs e)
        {
            if (TxtBoxExportDossierDriverOnline.Text == "")
                MessageBox.Show("Vous devez renseigner le champ Dossier (online).");
            else
            {
                StrDISMArguments = "/Online" + " /Export-Driver" + " /Destination:" + "\"" + TxtBoxExportDossierDriverOnline.Text + "\"";
                TxtBoxOutput.Text = "Exécution de la ligne de commande: DISM.EXE " + StrDISMArguments;

                backgroundWorkerDismCommand.RunWorkerAsync(StrDISMArguments);  // exécute la commande DISM en tache de fond (asynchrone)
                MaFormeProgress.ShowDialog();                   // Affiche la Progress Bar
                TxtBoxOutput.Text = StrOutput;                  // Mise à jour des messages de la console (retour de commandes DISM)
            }
            
        }

        // Affiche une boite de dialogue A propos de 
        // Révision 27/02/2020
        //
        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MaFormAbout.ShowDialog();
        }
    }
}
