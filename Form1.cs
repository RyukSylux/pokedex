using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace PokedexApp
{

    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons = new List<Pokemon>();
        private int nextId = 31; // Pour auto-incrémenter les IDs
        private static readonly string ImagesFolderPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "images\\");

        public Form1()
        {
            // Liste de Pokémon préremplis

            pokemons = new List<Pokemon>
    {
      new Pokemon { ID = 1, Name = "Bulbizarre", Type = "Plante", Description = "Un Pokémon graine qui aime le soleil.", Weight = 6.9, Height = 0.7, IsCaptured = true, ImagePath = ImagesFolderPath + "bulbizarre.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Fouet Lianes" },
new Pokemon { ID = 2, Name = "Salamèche", Type = "Feu", Description = "Sa queue brûle en permanence.", Weight = 8.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "salameche.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flammèche" },
new Pokemon { ID = 3, Name = "Carapuce", Type = "Eau", Description = "Sa carapace le protège des attaques.", Weight = 9.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "carapuce.png", Region = "Kanto", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet à O" },
new Pokemon { ID = 4, Name = "Pikachu", Type = "Électrique", Description = "Un Pokémon très populaire qui stocke l'électricité dans ses joues.", Weight = 6.0, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "pikachu.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "Éclair" },
new Pokemon { ID = 5, Name = "Roucool", Type = "Vol", Description = "Il est souvent trouvé dans les champs et forêts.", Weight = 1.8, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "roucool.png", Region = "Kanto", Weakness = "Électrique", CanEvolve = true, AtqSign = "Tornade" },
new Pokemon { ID = 6, Name = "Rattata", Type = "Normal", Description = "Un rongeur rapide et agressif.", Weight = 3.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "rattata.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Vive-Attaque" },
new Pokemon { ID = 7, Name = "Sabelette", Type = "Sol", Description = "Il s'enroule pour se protéger.", Weight = 12.0, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "sabelette.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Jet de Sable" },
new Pokemon { ID = 8, Name = "Goupix", Type = "Feu", Description = "Sa queue s'illumine lorsqu'il est heureux.", Weight = 9.9, Height = 0.6, IsCaptured = true, ImagePath = ImagesFolderPath + "goupix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flammèche" },
new Pokemon { ID = 9, Name = "Mélofée", Type = "Fée", Description = "Il danse à la lumière de la lune.", Weight = 7.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "melofee.png", Region = "Kanto", Weakness = "Acier", CanEvolve = true, AtqSign = "Vague Psy" },
new Pokemon { ID = 10, Name = "Paras", Type = "Insecte", Description = "Il transporte des spores sur son dos.", Weight = 5.4, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "paras.png", Region = "Kanto", Weakness = "Vol", CanEvolve = true, AtqSign = "Spore" },
new Pokemon { ID = 11, Name = "Mimitoss", Type = "Insecte", Description = "Ses yeux brillants sont fascinants.", Weight = 30.0, Height = 1.0, IsCaptured = false, ImagePath = ImagesFolderPath + "mimitoss.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Poudre Toxik" },
new Pokemon { ID = 12, Name = "Tentacool", Type = "Eau", Description = "Un Pokémon marin avec des tentacules venimeux.", Weight = 45.5, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "tentacool.png", Region = "Kanto", Weakness = "Électrique", CanEvolve = true, AtqSign = "Acide" },
new Pokemon { ID = 13, Name = "Ponyta", Type = "Feu", Description = "Ses flammes ne brûlent que s'il est en danger.", Weight = 30.0, Height = 1.0, IsCaptured = true, ImagePath = ImagesFolderPath + "ponyta.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Charge" },
new Pokemon { ID = 14, Name = "Magnéti", Type = "Électrique", Description = "Il génère des champs magnétiques puissants.", Weight = 6.0, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "magneti.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "Onde de Choc" },
new Pokemon { ID = 15, Name = "Onix", Type = "Roche", Description = "Un énorme serpent de pierre.", Weight = 210.0, Height = 8.8, IsCaptured = true, ImagePath = ImagesFolderPath + "onix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Éboulement" },
new Pokemon { ID = 16, Name = "Fantominus", Type = "Spectre", Description = "Un Pokémon gaz qui peut traverser les murs.", Weight = 0.1, Height = 1.3, IsCaptured = false, ImagePath = ImagesFolderPath + "fantominus.png", Region = "Kanto", Weakness = "Ténèbres", CanEvolve = true, AtqSign = "Léchouille" },
new Pokemon { ID = 17, Name = "Kranidos", Type = "Roche", Description = "Un dinosaure avec une tête dure comme le roc.", Weight = 37.0, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "kranidos.png", Region = "Sinnoh", Weakness = "Eau", CanEvolve = true, AtqSign = "Coup d'Boule" },
new Pokemon { ID = 18, Name = "Évoli", Type = "Normal", Description = "Il peut évoluer sous différentes formes.", Weight = 6.5, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "evoli.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Morsure" },
new Pokemon { ID = 19, Name = "Lixy", Type = "Électrique", Description = "Un lionceau qui émet des étincelles.", Weight = 9.5, Height = 0.5, IsCaptured = false, ImagePath = ImagesFolderPath + "lixy.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = true, AtqSign = "Crocs Éclair" },
new Pokemon { ID = 20, Name = "Cerfrousse", Type = "Normal", Description = "Il ressemble à un cerf majestueux.", Weight = 71.2, Height = 1.4, IsCaptured = true, ImagePath = ImagesFolderPath + "cerfrousse.png", Region = "Johto", Weakness = "Combat", CanEvolve = false, AtqSign = "Psyko" },
new Pokemon { ID = 21, Name = "Azurill", Type = "Eau", Description = "Un petit Pokémon qui joue avec sa queue flottante.", Weight = 2.0, Height = 0.2, IsCaptured = false, ImagePath = ImagesFolderPath + "azurill.png", Region = "Hoenn", Weakness = "Plante", CanEvolve = true, AtqSign = "Éclaboussure" },
new Pokemon { ID = 22, Name = "Tiplouf", Type = "Eau", Description = "Un pingouin élégant et courageux.", Weight = 5.2, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "tiplouf.png", Region = "Sinnoh", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet à O" },
new Pokemon { ID = 23, Name = "Lucario", Type = "Combat", Description = "Il ressent les auras des êtres vivants.", Weight = 54.0, Height = 1.2, IsCaptured = false, ImagePath = ImagesFolderPath + "lucario.png", Region = "Sinnoh", Weakness = "Psy", CanEvolve = false, AtqSign = "Aurasphère" },
new Pokemon { ID = 24, Name = "Draco", Type = "Dragon", Description = "Un Pokémon dragon au corps élégant.", Weight = 16.5, Height = 4.0, IsCaptured = true, ImagePath = ImagesFolderPath + "draco.png", Region = "Kanto", Weakness = "Glace", CanEvolve = true, AtqSign = "Ultralaser" },
new Pokemon { ID = 25, Name = "Tortipouss", Type = "Plante", Description = "Il porte une petite pousse sur sa tête.", Weight = 10.2, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "tortipouss.png", Region = "Sinnoh", Weakness = "Feu", CanEvolve = true, AtqSign = "Canon Graine" },
new Pokemon { ID = 26, Name = "Arcko", Type = "Plante", Description = "Un Pokémon agile et vif.", Weight = 5.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "arcko.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Tranch'Herbe" },
new Pokemon { ID = 27, Name = "Balignon", Type = "Plante", Description = "Il ressemble à un champignon.", Weight = 4.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "balignon.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Spore Coton" },
new Pokemon { ID = 28, Name = "Pachirisu", Type = "Électrique", Description = "Un écureuil électrique rapide.", Weight = 3.9, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "pachirisu.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = false, AtqSign = "Parabocharge" },
new Pokemon { ID = 29, Name = "Démanta", Type = "Eau", Description = "Un Pokémon marin qui glisse sur l'eau.", Weight = 220.0, Height = 2.1, IsCaptured = false, ImagePath = ImagesFolderPath + "demanta.png", Region = "Johto", Weakness = "Électrique", CanEvolve = false, AtqSign = "Surf" },
new Pokemon { ID = 30, Name = "Zygarde", Type = "Dragon", Description = "Le gardien de l'équilibre écologique.", Weight = 305.0, Height = 5.0, IsCaptured = true, ImagePath = ImagesFolderPath + "zygarde.png", Region = "Kalos", Weakness = "Fée", CanEvolve = false, AtqSign = "Force Chtonienne" }

    };

            InitializeComponent();

            UpdatePokemonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Sélectionner une image pour le Pokémon";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Afficher l'image sélectionnée dans le PictureBox
                    pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                    // Stocker le chemin de l'image temporairement
                    txtImagePath.Text = openFileDialog.FileName;
                }
                else
                {
                    pictureBoxPokemon.ImageLocation = ImagesFolderPath + "missingno.png";
                    txtImagePath.Text = ImagesFolderPath + "missingno.png";
                }
            }

            // Ajouter un Pokémon
            var pokemon = new Pokemon
            {
                ID = nextId++,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Type = cmbType.SelectedItem.ToString(),
                Weight = double.Parse(txtWeight.Text),
                Height = double.Parse(txtHeight.Text),
                IsCaptured = chkCaptured.Checked,
                CanEvolve = chkEvolve.Checked,
                ImagePath = txtImagePath.Text,
                Region = cmbRegion.SelectedItem.ToString(),
                Weakness = cmbWeak.SelectedItem.ToString(),
                AtqSign = textAtqS.Text,
               
            };

            pokemons.Add(pokemon);
            UpdatePokemonList();
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Supprimer un Pokémon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                pokemons.Remove(selectedPokemon);
                UpdatePokemonList();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un Pokémon à supprimer.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Éditer un Pokémon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                if (ValidateInputFields())
                {

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.bmp";
                        openFileDialog.Title = "Sélectionner une image pour le Pokémon";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Afficher l'image sélectionnée dans le PictureBox
                            pictureBoxPokemon.ImageLocation = openFileDialog.FileName;

                            // Stocker le chemin de l'image temporairement
                            txtImagePath.Text = openFileDialog.FileName;
                        }
                        else
                        {
                            pictureBoxPokemon.ImageLocation = ImagesFolderPath + "missingno.png";
                            txtImagePath.Text = ImagesFolderPath + "missingno.png";
                        }
                    }


                    selectedPokemon.Name = txtName.Text;
                    selectedPokemon.Description = txtDescription.Text;
                    selectedPokemon.Type = cmbType.SelectedItem.ToString();
                    selectedPokemon.Weight = double.Parse(txtWeight.Text);
                    selectedPokemon.Height = double.Parse(txtHeight.Text);
                    selectedPokemon.IsCaptured = chkCaptured.Checked;
                    selectedPokemon.CanEvolve = chkEvolve.Checked;
                    selectedPokemon.ImagePath = txtImagePath.Text;
                    selectedPokemon.Region = cmbRegion.Text;
                    selectedPokemon.Weakness = cmbWeak.Text;
                    selectedPokemon.AtqSign = textAtqS.Text;


                    UpdatePokemonList();
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un Pokémon à éditer.");
            }
        }

        private void listBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vérifie si un Pokémon est sélectionné
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                //Remplit les champs avec les informations du Pokémon
                txtName.Text = selectedPokemon.Name;
                txtDescription.Text = selectedPokemon.Description;
                cmbType.SelectedItem = selectedPokemon.Type;
                txtWeight.Text = selectedPokemon.Weight.ToString();
                txtHeight.Text = selectedPokemon.Height.ToString();
                chkCaptured.Checked = selectedPokemon.IsCaptured;
                chkEvolve.Checked = selectedPokemon.CanEvolve;
                txtImagePath.Text = selectedPokemon.ImagePath;
                cmbRegion.SelectedItem = selectedPokemon.Region;
                cmbWeak.SelectedItem = selectedPokemon.Weakness;
                string imgType = ImagesFolderPath + selectedPokemon.Type + ".png";

                if (!string.IsNullOrEmpty(selectedPokemon.ImagePath) && System.IO.File.Exists(selectedPokemon.ImagePath))
                {
                    pictureBoxPokemon.ImageLocation = selectedPokemon.ImagePath;
                }
                else
                {
                    pictureBoxPokemon.Image = null; // Si aucune image, vide le PictureBox
                }

                if (!string.IsNullOrEmpty(selectedPokemon.Type) && System.IO.File.Exists(imgType))
                {
                    pictureBoxType.ImageLocation = imgType;
                }
                else
                {
                    pictureBoxType.Image = null; // Si aucune image, vide le PictureBox
                }


            }
            else
            {
                // Si rien n'est sélectionné, vide les champs
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
            cmbRegion.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            txtWeight.Text = "";
            txtHeight.Text = "";
            chkCaptured.Checked = false;
            chkEvolve.Checked = false;
            txtImagePath.Text = "";
            textImgTypePath.Text = "";
            pictureBoxPokemon.ImageLocation = null;
            textAtqS.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[]
            {
                "Normal", "Feu", "Eau", "Plante", "Électrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "Ténèbres", "Acier", "Fée"
            });

            cmbRegion.Items.AddRange(new string[]{
                "Kanto", "Johto", "Hoenn", "Sinnoh","Kalos"
            });

            cmbWeak.Items.AddRange(new string[]{
                "Feu", "Eau", "Plante", "Électrique", "Glace",
                "Combat", "Poison", "Sol", "Vol", "Psy", "Insecte",
                "Roche", "Spectre", "Dragon", "Ténèbres", "Acier", "Fée"
            });

            //définir une valeur par défaut
            cmbType.SelectedIndex = 0;
            cmbRegion.SelectedIndex = 0;
            cmbWeak.SelectedIndex = 0;
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
                MessageBox.Show("Veuillez sélectionner un type de Pokémon.");
                return false;
            }
            if (!double.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Le champ Poids doit être un nombre valide.");
                return false;
            }
            if (!double.TryParse(txtHeight.Text, out _))
            {
                MessageBox.Show("Le champ Taille doit être un nombre valide.");
                return false;
            }

            return true;
        }

        private void SearchByType()
        {
            if (cmbType.SelectedItem != null)
            {
                string selectedType = cmbType.SelectedItem.ToString();

                // Filtrer les Pokémon en fonction du type sélectionné
                var filteredPokemons = pokemons.FindAll(p => p.Type == selectedType);

                // Met à jour la ListBox avec les résultats filtrés
                listBoxPokemons.DataSource = null; // Réinitialise la source de données
                listBoxPokemons.DataSource = filteredPokemons;

                if (filteredPokemons.Count == 0)
                {
                    MessageBox.Show($"Aucun Pokémon trouvé pour le type '{selectedType}'.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type dans la liste déroulante.");
            }
        }

        private void SearchByName()
        {
            if (txtName.Text != null)
            {
                string search = txtName.Text;
                var filteredPokemons = pokemons.FindAll(p => p.Name.Contains(search));

                listBoxPokemons.DataSource = null; // Réinitialise la source de données
                listBoxPokemons.DataSource = filteredPokemons;
            }
            else
            {
                MessageBox.Show("Aucun pokemon trouvé.");
            }
        }

        private void SearchByRegion()
        {
            if (cmbRegion.SelectedItem != null)
            {
                string selectedRegion = cmbRegion.SelectedItem.ToString();

                // Filtrer les Pokémon en fonction du type sélectionné
                var filteredPokemons = pokemons.FindAll(p => p.Region == selectedRegion);

                // Met à jour la ListBox avec les résultats filtrés
                listBoxPokemons.DataSource = null; // Réinitialise la source de données
                listBoxPokemons.DataSource = filteredPokemons;

                if (filteredPokemons.Count == 0)
                {
                    MessageBox.Show($"Aucun Pokémon trouvé pour la rgion '{selectedRegion}'.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type dans la liste déroulante.");
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

        private void btnSearchByRegion_Click(object sender, EventArgs e)
        {
            SearchByRegion();
        }
    }
}
