using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renom_mass
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            int t = 0;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Ajouter les fichiers sélectionnés à la liste
                foreach (string fichier in dialog.FileNames)
                {
                    listBox1.Items.Add(fichier);
                    t++;
                }
                lbl_nombe.Text = t.ToString();
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            // Vérifier que l'utilisateur a sélectionné un fichier dans la liste
            if (listBox1.SelectedIndex != -1)
            {
                // Ouvrir une boîte de dialogue pour demander le nouveau nom de fichier
                string nouveauNom = Microsoft.VisualBasic.Interaction.InputBox("Entrez le nouveau nom de fichier", "Renommer le fichier", listBox1.SelectedItem.ToString());

                // Vérifier que l'utilisateur a entré un nom de fichier valide
                if (nouveauNom.Trim() != "")
                {
                    // Renommer le fichier
                    string ancienNom = listBox1.SelectedItem.ToString();
                    string nouveauChemin = Path.GetDirectoryName(ancienNom) + "\\" + nouveauNom;

                    try
                    {
                        File.Move(ancienNom, nouveauChemin);
                        listBox1.Items[listBox1.SelectedIndex] = nouveauChemin;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors du renommage du fichier: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un fichier à renommer.");
            }
        }

        private void btnRenommerAuto_Click(object sender, EventArgs e)
        {
            // Vérifier que l'utilisateur a sélectionné un dossier dans le contrôle FolderBrowserDialog
            if (fbdDossier.ShowDialog() == DialogResult.OK)
            {
                // Demander à l'utilisateur de saisir le format de nom de fichier
                string format = Microsoft.VisualBasic.Interaction.InputBox("Entrez le format de nom de fichier (utilisez {0} pour représenter le numéro de séquence)", "Renommer automatiquement les fichiers");

                // Vérifier que l'utilisateur a entré un format valide
                if (format.Trim() != "")
                {
                    // Récupérer la liste des fichiers dans le dossier sélectionné
                    string[] fichiers = Directory.GetFiles(fbdDossier.SelectedPath);

                    // Définir le compteur de séquence
                    int compteur = 1;

                    // Parcourir tous les fichiers dans le dossier
                    foreach (string fichier in fichiers)
                    {
                        // Obtenir l'extension du fichier
                        string extension = Path.GetExtension(fichier);

                        // Construire le nouveau nom de fichier
                        string nouveauNom = string.Format(format, compteur) + extension;
                        string nouveauChemin = Path.GetDirectoryName(fichier) + "\\" + nouveauNom;

                        try
                        {
                            File.Move(fichier, nouveauChemin);
                            compteur++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue lors du renommage du fichier: " + ex.Message);
                        }
                    }

                    // Actualiser la liste des fichiers dans la ListBox
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(Directory.GetFiles(fbdDossier.SelectedPath));
                }
            }
        }




    }
}
