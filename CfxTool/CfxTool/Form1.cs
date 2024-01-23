using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace CfxTool
{
    public partial class Form1 : Form
    {
        private string ComputerUsername = null;
        private string DefaultRedmPath = null;
        private string DefaultFivemPath = null;

        public Form1()
        {
            InitializeComponent();
            ComputerUsername = Environment.UserName;
            DefaultRedmPath = Path.Combine("C:\\Users", ComputerUsername, "AppData", "Local", "RedM");
            DefaultFivemPath = Path.Combine("C:\\Users", ComputerUsername, "AppData", "Local", "FiveM");
        }

        private void RedmToAzerty_Click(object sender, EventArgs e)
        {
            try
            {
                string DefaultMetaPath = Path.Combine(DefaultRedmPath, "RedM.app", "citizen", "common", "data", "control", "default.meta");

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://cdn.codoly.fr/p/default.meta", DefaultMetaPath);
                }

                MessageBox.Show("Le fichier default.meta a été remplacé avec succès. Votre jeu sera désormais en AZERTY.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du téléchargement du fichier : {ex.Message}.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCacheRedm_Click(object sender, EventArgs e)
        {
            try
            {
                string DefaultRedmCachePath = Path.Combine(DefaultRedmPath, "RedM.app", "data");
                foreach (var folder in Directory.GetDirectories(DefaultRedmCachePath))
                {
                    if (Path.GetFileName(folder) != "game-storage")
                    {
                        Directory.Delete(folder, true);
                    }
                }

                MessageBox.Show("Cache RedM nettoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du vidage du cache RedM : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ClearCacheFivem_Click(object sender, EventArgs e)
        {
            try
            {
                string DefaultFivemCachePath = Path.Combine(DefaultFivemPath, "RedM.app", "data");

                foreach (var folder in Directory.GetDirectories(DefaultFivemCachePath))
                {
                    if (Path.GetFileName(folder) != "game-storage")
                    {
                        Directory.Delete(folder, true);
                    }
                }

                MessageBox.Show("Cache FiveM nettoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du vidage du cache FiveM : {ex.Message}.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaunchFivem_Click(object sender, EventArgs e)
        {
            try
            {
                string FiveMExecutablePath = Path.Combine(DefaultFivemPath, "FiveM.exe");
                if (File.Exists(FiveMExecutablePath))
                {
                    Process.Start(FiveMExecutablePath);
                }
                else
                {
                    MessageBox.Show("Le fichier exécutable FiveM n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du démarrage de l'application FiveM : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaunchRedm_Click(object sender, EventArgs e)
        {
            try
            {
                string RedMExecutablePath = Path.Combine(DefaultRedmPath, "RedM.exe");
                if (File.Exists(RedMExecutablePath))
                {
                    Process.Start(RedMExecutablePath);
                }
                else
                {
                    MessageBox.Show("Le fichier exécutable RedM n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du démarrage de l'application RedM : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
