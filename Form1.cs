using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokedexApp
{

    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons = new List<Pokemon>();
        private int nextId = 1; // Pour auto-incr�menter les IDs



        public Form1()
        {
            // Liste de Pok�mon pr�remplis
            pokemons = new List<Pokemon>
                {
                    new Pokemon { ID = 1, Name = "Bulbizarre", Type = "Plante", Description = "Un Pok�mon graine qui aime le soleil.", Weight = 6.9, Height = 0.7, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 2, Name = "Salam�che", Type = "Feu", Description = "Sa queue br�le en permanence.", Weight = 8.5, Height = 0.6, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 3, Name = "Carapuce", Type = "Eau", Description = "Sa carapace le prot�ge des attaques.", Weight = 9.0, Height = 0.5, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 4, Name = "Pikachu", Type = "�lectrique", Description = "Un Pok�mon tr�s populaire qui stocke l'�lectricit� dans ses joues.", Weight = 6.0, Height = 0.4, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 5, Name = "Roucool", Type = "Vol", Description = "Il est souvent trouv� dans les champs et for�ts.", Weight = 1.8, Height = 0.3, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 6, Name = "Rattata", Type = "Normal", Description = "Un rongeur rapide et agressif.", Weight = 3.5, Height = 0.3, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 7, Name = "Sabelette", Type = "Sol", Description = "Il s'enroule pour se prot�ger.", Weight = 12.0, Height = 0.6, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 8, Name = "Goupix", Type = "Feu", Description = "Sa queue s'illumine lorsqu'il est heureux.", Weight = 9.9, Height = 0.6, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 9, Name = "M�lof�e", Type = "F�e", Description = "Il danse � la lumi�re de la lune.", Weight = 7.5, Height = 0.6, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 10, Name = "Paras", Type = "Insecte", Description = "Il transporte des spores sur son dos.", Weight = 5.4, Height = 0.3, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 11, Name = "Mimitoss", Type = "Insecte", Description = "Ses yeux brillants sont fascinants.", Weight = 30.0, Height = 1.0, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 12, Name = "Tentacool", Type = "Eau", Description = "Un Pok�mon marin avec des tentacules venimeux.", Weight = 45.5, Height = 0.9, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 13, Name = "Ponyta", Type = "Feu", Description = "Ses flammes ne br�lent que s'il est en danger.", Weight = 30.0, Height = 1.0, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 14, Name = "Magn�ti", Type = "�lectrique", Description = "Il g�n�re des champs magn�tiques puissants.", Weight = 6.0, Height = 0.3, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 15, Name = "Onix", Type = "Roche", Description = "Un �norme serpent de pierre.", Weight = 210.0, Height = 8.8, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 16, Name = "Fantominus", Type = "Spectre", Description = "Un Pok�mon gaz qui peut traverser les murs.", Weight = 0.1, Height = 1.3, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 17, Name = "Kranidos", Type = "Roche", Description = "Un dinosaure avec une t�te dure comme le roc.", Weight = 37.0, Height = 0.9, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 18, Name = "�voli", Type = "Normal", Description = "Il peut �voluer sous diff�rentes formes.", Weight = 6.5, Height = 0.3, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 19, Name = "Lixy", Type = "�lectrique", Description = "Un lionceau qui �met des �tincelles.", Weight = 9.5, Height = 0.5, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 20, Name = "Cerfrousse", Type = "Normal", Description = "Il ressemble � un cerf majestueux.", Weight = 71.2, Height = 1.4, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 21, Name = "Azurill", Type = "Eau", Description = "Un petit Pok�mon qui joue avec sa queue flottante.", Weight = 2.0, Height = 0.2, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 22, Name = "Tiplouf", Type = "Eau", Description = "Un pingouin �l�gant et courageux.", Weight = 5.2, Height = 0.4, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 23, Name = "Lucario", Type = "Combat", Description = "Il ressent les auras des �tres vivants.", Weight = 54.0, Height = 1.2, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 24, Name = "Draco", Type = "Dragon", Description = "Un Pok�mon dragon au corps �l�gant.", Weight = 16.5, Height = 4.0, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 25, Name = "Tortipouss", Type = "Plante", Description = "Il porte une petite pousse sur sa t�te.", Weight = 10.2, Height = 0.4, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 26, Name = "Arcko", Type = "Plante", Description = "Un Pok�mon agile et vif.", Weight = 5.0, Height = 0.5, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 27, Name = "Balignon", Type = "Plante", Description = "Il ressemble � un champignon.", Weight = 4.5, Height = 0.3, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 28, Name = "Pachirisu", Type = "�lectrique", Description = "Un �cureuil �lectrique rapide.", Weight = 3.9, Height = 0.4, IsCaptured = true, ImagePath = "" },
                    new Pokemon { ID = 29, Name = "D�manta", Type = "Eau", Description = "Un Pok�mon marin qui glisse sur l'eau.", Weight = 220.0, Height = 2.1, IsCaptured = false, ImagePath = "" },
                    new Pokemon { ID = 30, Name = "Zygarde", Type = "Dragon", Description = "Le gardien de l'�quilibre �cologique.", Weight = 305.0, Height = 5.0, IsCaptured = true, ImagePath = "" }
                };
            InitializeComponent();

            UpdatePokemonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "S�lectionner une image pour le Pok�mon";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Afficher l'image s�lectionn�e dans le PictureBox
                    pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                    // Stocker le chemin de l'image temporairement
                    txtImagePath.Text = openFileDialog.FileName;
                }
            }

            // Ajouter un Pok�mon
            var pokemon = new Pokemon
            {
                ID = nextId++,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Type = cmbType.SelectedItem.ToString(),
                Weight = double.Parse(txtWeight.Text),
                Height = double.Parse(txtHeight.Text),
                IsCaptured = chkCaptured.Checked,
                ImagePath = txtImagePath.Text
            };

            pokemons.Add(pokemon);
            UpdatePokemonList();
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Supprimer un Pok�mon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                pokemons.Remove(selectedPokemon);
                UpdatePokemonList();
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un Pok�mon � supprimer.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // �diter un Pok�mon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                if (ValidateInputFields())
                {

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                        openFileDialog.Title = "S�lectionner une image pour le Pok�mon";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Afficher l'image s�lectionn�e dans le PictureBox
                            pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                            // Stocker le chemin de l'image temporairement
                            txtImagePath.Text = openFileDialog.FileName;
                        }
                    }


                    selectedPokemon.Name = txtName.Text;
                    selectedPokemon.Description = txtDescription.Text;
                    selectedPokemon.Type = cmbType.SelectedItem.ToString();
                    selectedPokemon.Weight = double.Parse(txtWeight.Text);
                    selectedPokemon.Height = double.Parse(txtHeight.Text);
                    selectedPokemon.IsCaptured = chkCaptured.Checked;
                    selectedPokemon.ImagePath = txtImagePath.Text;

                    UpdatePokemonList();
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un Pok�mon � �diter.");
            }
        }

        private void listBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //V�rifie si un Pok�mon est s�lectionn�
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                //Remplit les champs avec les informations du Pok�mon
                txtName.Text = selectedPokemon.Name;
                txtDescription.Text = selectedPokemon.Description;
                cmbType.SelectedItem = selectedPokemon.Type;
                txtWeight.Text = selectedPokemon.Weight.ToString();
                txtHeight.Text = selectedPokemon.Height.ToString();
                chkCaptured.Checked = selectedPokemon.IsCaptured;

                if (!string.IsNullOrEmpty(selectedPokemon.ImagePath) && System.IO.File.Exists(selectedPokemon.ImagePath))
                {
                    pictureBoxPokemon.ImageLocation = selectedPokemon.ImagePath;
                }
                else
                {
                    pictureBoxPokemon.Image = null; // Si aucune image, vide le PictureBox
                }


            }
            else
            {
                // Si rien n'est s�lectionn�, vide les champs
                ClearInputFields();
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            UpdatePokemonList();
        }

        private void UpdatePokemonList()
        {
            listBoxPokemons.DataSource = null;
            listBoxPokemons.DataSource = pokemons;
        }

        private void ClearInputFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            cmbType.SelectedIndex = 0;
            txtWeight.Text = "";
            txtHeight.Text = "";
            chkCaptured.Checked = false;
            txtImagePath.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[]
            {
                "Normal", "Feu", "Eau", "Plante", "�lectrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "T�n�bres", "Acier", "F�e"
            });

            //d�finir une valeur par d�faut
            cmbType.SelectedIndex = 0;
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Le champ Nom est obligatoire.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Le champ Description est obligatoire.");
                return false;
            }
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez s�lectionner un type de Pok�mon.");
                return false;
            }
            if (!double.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Le champ Poids doit �tre un nombre valide.");
                return false;
            }
            if (!double.TryParse(txtHeight.Text, out _))
            {
                MessageBox.Show("Le champ Taille doit �tre un nombre valide.");
                return false;
            }

            return true;
        }

        private void SearchByType()
        {
            if (cmbType.SelectedItem != null)
            {
                string selectedType = cmbType.SelectedItem.ToString();

                // Filtrer les Pok�mon en fonction du type s�lectionn�
                var filteredPokemons = pokemons.FindAll(p => p.Type == selectedType);

                // Met � jour la ListBox avec les r�sultats filtr�s
                listBoxPokemons.DataSource = null; // R�initialise la source de donn�es
                listBoxPokemons.DataSource = filteredPokemons;

                if (filteredPokemons.Count == 0)
                {
                    MessageBox.Show($"Aucun Pok�mon trouv� pour le type '{selectedType}'.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un type dans la liste d�roulante.");
            }
        }

        private void SearchByName()
        {
            if (txtName.Text != null)
            {
                string search = txtName.Text;
                var filteredPokemons = pokemons.FindAll(p => p.Name.Contains(search));

                listBoxPokemons.DataSource = null; // R�initialise la source de donn�es
                listBoxPokemons.DataSource = filteredPokemons;
            }
            else
            {
                MessageBox.Show("Aucun pokemon trouv�.");
            }
        }
        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            SearchByType();
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {
            SearchByName();
        }
    }
}
