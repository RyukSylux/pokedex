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

        // Liste des attaques disponibles
        List<string> allAttacks = new List<string>
            {
                "-",
                // type psy tmts
                "Ultrason",
                // attaques acier
                "Griffe Acier",
                // Attaques normales
                "Charge", "Vive-Attaque", "Damoclès", "Météores", "Poursuite", "Rugissement", "Combo-Griffe", "Coup d'Boule", "Griffe", "Écrasement",

                // Attaques de type Feu
                "Flammèche", "Lance-Flammes", "Danse-Flamme", "Déflagration", "Nitrocharge", "Feu Follet", "Surchauffe", "Poing de Feu", "Boutefeu", "Vortex Magma",

                // Attaques de type Eau
                "Pistolet à O", "Surf", "Hydrocanon", "Cascade", "Ébullition", "Plongée", "Bulles d’O", "Danse Pluie", "Ocroupi", "Hydroqueue", "Rafale Hydro",

                // Attaques de type Plante
                "Fouet Lianes", "Canon Graine", "Tranch'Herbe", "Lance-Soleil", "Synthèse", "Vampigraine", "Méga-Sangsue", "Tempêteverte", "Noeud Herbe", "Feuillemagik",

                // Attaques de type Électrique
                "Éclair", "Fatal-Foudre", "Cage-Éclair", "Tonnerre", "Crocs Éclair", "Étincelle", "ChangeÉclair", "Parabocharge", "Électacle", "Tonnerre Charge",

                // Attaques de type Roche
                "Jet-Pierres", "Éboulement", "Lame de Roc", "Pouvoir Antique", "Piège de Roc", "Tacle Lourd", "Force Naturelle", "Tomberoche", "Roulade", "Hurlement",

                // Attaques de type Sol
                "Jet de Sable", "Séisme", "Tunnel", "Coud’Boue", "Piège de Sable", "Ampleur", "Telluriforce", "Tourbi-Sable", "Piétisol", "Abîme",

                // Attaques de type Insecte
                "Armure", "Dard-Venin", "Bourdon", "Vent Argenté", "Piqûre", "Coupe", "Plaie Croix", "Survinsecte", "Picore", "Demi-Tour",

                // Attaques de type Vol
                "Tornade", "Hâte", "Cru-Aile", "Aéropique", "Rapace", "Atterrissage", "Cyclone", "Vent Arrière", "Lame d’Air", "Hurle-Temps",

                // Attaques de type Combat
                "Balayette", "Poing-Karaté", "Close Combat", "Mitra-Poing", "Poing-Boost", "Mach Punch", "Coup-Croix", "Choc Météore", "Dynamopoing", "Riposte",

                // Attaques de type Fée
                "Charme", "Câlinerie", "Pouvoir Lunaire", "Voeu Soin", "Vague Psy", "Lumi-Éclat", "Vent Féérique", "Rune Protect", "Danse-Lune", "Écras’Face",

                // Attaques de type Spectre
                "Léchouille", "Ombre Portée", "Ball’Ombre", "Onde Folie", "Feu Fatu", "Ténèbres", "Spectres-Bouclier", "Ténèbrôme", "Vibrasoin", "Maléfice",

                // Attaques de type Dragon
                "Ultralaser", "Colère", "Draco-Rage", "Vibraqua", "Danse Draco", "Dracochoc", "Dracossouffle", "Hurle-Temps", "Tempêteverte", "Lance Draco",

                // Attaques de type Ténèbres
                "Morsure", "Poursuite", "Mâchouille", "Sabotage", "Provoc", "Crocs Feu", "Tricherie", "Bluff", "Coup Bas", "Sombre-Larme",

                // Attaques de type Glace
                "Poudreuse", "Laser Glace", "Blizzard", "Onde Boréale", "Vent Glacé", "Eclats Glace", "Avalanche", "Chute Glace", "Poing-Glace", "Grêle",

                // Attaques de statut (multitype)
                "Protection", "Mur Lumière", "Clonage", "Hypnose", "Provoc", "Boost", "Reflet", "Regard Noir", "Grincement", "Berceuse", "Téléport",
                // Attaques des Pokémon
                "Éboulement", "Coup d'Main", "Roulade", "Séisme", // Kranidos
                "Morsure", "Tacle", "Mimi-Queue", "Hâte", // Évoli
                "Crocs Éclair", "Griffe", "Vive-Attaque", "Tonnerre", // Lixy
                "Psyko", "Doux Baiser", "Méditation", "Soin", // Cerfrousse
                "Éclaboussure", "Barrage", "Aqua Jet", "Hydrocanon", // Azurill
                "Pistolet à O", "Rafale Hydro", "Ultrason", "Poudre Dodo", // Tiplouf
                "Aurasphère", "Poing-Glace", "Griffe", "Coup d'Poing", // Lucario
                "Ultralaser", "Draco-Rage", "Griffe", "Lance-Dragon", // Draco
                "Canon Graine", "Fouet Lianes", "Dard-Venin", "Rugissement", // Tortipouss
                "Tranch'Herbe", "Coup d'Main", "Vive-Attaque", "Rugissement", // Arcko
                "Spore Coton", "Fouet Lianes", "Poudre Dodo", "Tranch'Herbe", // Balignon
                "Parabocharge", "Tonnerre", "Vive-Attaque", "Queue de Fer", // Pachirisu
                "Surf", "Barrage", "Hydrocanon", "Plongeon", // Démanta
                "Force Chtonienne", "Draco-Queue", "Séisme", "Lance-Dragon" // Zygarde
            };

        public Form1()
        {
            // Liste de Pokémon préremplis

            pokemons = new List<Pokemon>
                {
                    new Pokemon { ID = 1, Name = "Bulbizarre", Type = "Plante", Description = "Un Pokémon graine qui aime le soleil.", Weight = 6.9, Height = 0.7, IsCaptured = true, ImagePath = ImagesFolderPath + "bulbizarre.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Fouet Lianes",Attacks = new List<string> { "Fouet Lianes", "Tranch'Herbe", "Canon Graine", "Dard-Venin" } },
                    new Pokemon { ID = 2, Name = "Salamèche", Type = "Feu", Description = "Sa queue brûle en permanence.", Weight = 8.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "salameche.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flammèche", Attacks = new List<string> { "Flammèche", "Griffe", "Lance-Flammes", "Griffe Acier" } },
                    new Pokemon { ID = 3, Name = "Carapuce", Type = "Eau", Description = "Sa carapace le protège des attaques.", Weight = 9.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "carapuce.png", Region = "Kanto", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet à O", Attacks = new List<string> { "Pistolet à O", "Morsure", "Ultrason", "Rafale Hydro" }},
                    new Pokemon { ID = 4, Name = "Pikachu", Type = "Électrique", Description = "Un Pokémon très populaire qui stocke l'électricité dans ses joues.", Weight = 6.0, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "pikachu.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "Éclair", Attacks = new List<string> { "Éclair", "Vive-Attaque", "Queue de Fer", "Tonnerre" }},
                    new Pokemon { ID = 5, Name = "Roucool", Type = "Vol", Description = "Il est souvent trouvé dans les champs et forêts.", Weight = 1.8, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "roucool.png", Region = "Kanto", Weakness = "Électrique", CanEvolve = true, AtqSign = "Tornade", Attacks = new List<string> { "Tornade", "Mimi-Queue", "Vive-Attaque", "Vent Violent" }},
                    new Pokemon { ID = 6, Name = "Rattata", Type = "Normal", Description = "Un rongeur rapide et agressif.", Weight = 3.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "rattata.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Vive-Attaque" , Attacks = new List<string> { "Vive-Attaque", "Griffe", "Morsure", "Queue de Fer" } },
                    new Pokemon { ID = 7, Name = "Sabelette", Type = "Sol", Description = "Il s'enroule pour se protéger.", Weight = 12.0, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "sabelette.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Jet de Sable" , Attacks = new List<string> { "Jet de Sable", "Griffe", "Piège de Roc", "Séisme" }},
                    new Pokemon { ID = 8, Name = "Goupix", Type = "Feu", Description = "Sa queue s'illumine lorsqu'il est heureux.", Weight = 9.9, Height = 0.6, IsCaptured = true, ImagePath = ImagesFolderPath + "goupix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Flammèche" , Attacks = new List<string> { "Flammèche", "Rugissement", "Lance-Flammes", "Griffe" }},
                    new Pokemon { ID = 9, Name = "Mélofée", Type = "Fée", Description = "Il danse à la lumière de la lune.", Weight = 7.5, Height = 0.6, IsCaptured = false, ImagePath = ImagesFolderPath + "melofee.png", Region = "Kanto", Weakness = "Acier", CanEvolve = true, AtqSign = "Vague Psy" , Attacks = new List<string> { "Vague Psy", "Doux Baiser", "Méditation", "Soin" }},
                    new Pokemon { ID = 10, Name = "Paras", Type = "Insecte", Description = "Il transporte des spores sur son dos.", Weight = 5.4, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "paras.png", Region = "Kanto", Weakness = "Vol", CanEvolve = true, AtqSign = "Spore" , Attacks = new List<string> { "Spore", "Coup d'Main", "Dard-Venin", "Poudre Dodo" }},
                    new Pokemon { ID = 11, Name = "Mimitoss", Type = "Insecte", Description = "Ses yeux brillants sont fascinants.", Weight = 30.0, Height = 1.0, IsCaptured = false, ImagePath = ImagesFolderPath + "mimitoss.png", Region = "Kanto", Weakness = "Feu", CanEvolve = true, AtqSign = "Poudre Toxik" , Attacks = new List<string> { "Poudre Toxik", "Soin", "Mimi-Queue", "Psychup" }},
                    new Pokemon { ID = 12, Name = "Tentacool", Type = "Eau", Description = "Un Pokémon marin avec des tentacules venimeux.", Weight = 45.5, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "tentacool.png", Region = "Kanto", Weakness = "Électrique", CanEvolve = true, AtqSign = "Acide" , Attacks = new List<string> { "Acide", "Pistolet à O", "Toxic", "Rafale Hydro" }},
                    new Pokemon { ID = 13, Name = "Ponyta", Type = "Feu", Description = "Ses flammes ne brûlent que s'il est en danger.", Weight = 30.0, Height = 1.0, IsCaptured = true, ImagePath = ImagesFolderPath + "ponyta.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Charge" , Attacks = new List<string> { "Charge", "Flammèche", "Rugissement", "Lance-Flammes" }},
                    new Pokemon { ID = 14, Name = "Magnéti", Type = "Électrique", Description = "Il génère des champs magnétiques puissants.", Weight = 6.0, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "magneti.png", Region = "Kanto", Weakness = "Sol", CanEvolve = true, AtqSign = "Onde de Choc" , Attacks = new List<string> { "Onde de Choc", "Électromagnétisme", "Toxik", "Puissance" }},
                    new Pokemon { ID = 15, Name = "Onix", Type = "Roche", Description = "Un énorme serpent de pierre.", Weight = 210.0, Height = 8.8, IsCaptured = true, ImagePath = ImagesFolderPath + "onix.png", Region = "Kanto", Weakness = "Eau", CanEvolve = true, AtqSign = "Éboulement" , Attacks = new List<string> { "Éboulement", "Coup d'Main", "Roulade", "Séisme" }},
                    new Pokemon { ID = 16, Name = "Fantominus", Type = "Spectre", Description = "Un Pokémon gaz qui peut traverser les murs.", Weight = 0.1, Height = 1.3, IsCaptured = false, ImagePath = ImagesFolderPath + "fantominus.png", Region = "Kanto", Weakness = "Ténèbres", CanEvolve = true, AtqSign = "Léchouille" , Attacks = new List<string> { "Léchouille", "Psyko", "Ball'Ombre", "Vibraqua" }},
                    new Pokemon { ID = 17, Name = "Kranidos", Type = "Roche", Description = "Un dinosaure avec une tête dure comme le roc.", Weight = 37.0, Height = 0.9, IsCaptured = false, ImagePath = ImagesFolderPath + "kranidos.png", Region = "Sinnoh", Weakness = "Eau", CanEvolve = true, AtqSign = "Coup d'Boule", Attacks = new List<string> { "Éboulement", "Coup d'Main", "Roulade", "Séisme" } },
                    new Pokemon { ID = 18, Name = "Évoli", Type = "Normal", Description = "Il peut évoluer sous différentes formes.", Weight = 6.5, Height = 0.3, IsCaptured = true, ImagePath = ImagesFolderPath + "evoli.png", Region = "Kanto", Weakness = "Combat", CanEvolve = true, AtqSign = "Morsure", Attacks = new List<string> { "Morsure", "Tacle", "Mimi-Queue", "Hâte" } },
                    new Pokemon { ID = 19, Name = "Lixy", Type = "Électrique", Description = "Un lionceau qui émet des étincelles.", Weight = 9.5, Height = 0.5, IsCaptured = false, ImagePath = ImagesFolderPath + "lixy.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = true, AtqSign = "Crocs Éclair", Attacks = new List<string> { "Crocs Éclair", "Griffe", "Vive-Attaque", "Tonnerre" } },
                    new Pokemon { ID = 20, Name = "Cerfrousse", Type = "Normal", Description = "Il ressemble à un cerf majestueux.", Weight = 71.2, Height = 1.4, IsCaptured = true, ImagePath = ImagesFolderPath + "cerfrousse.png", Region = "Johto", Weakness = "Combat", CanEvolve = false, AtqSign = "Psyko", Attacks = new List<string> { "Psyko", "Doux Baiser", "Méditation", "Soin" } },
                    new Pokemon { ID = 21, Name = "Azurill", Type = "Eau", Description = "Un petit Pokémon qui joue avec sa queue flottante.", Weight = 2.0, Height = 0.2, IsCaptured = false, ImagePath = ImagesFolderPath + "azurill.png", Region = "Hoenn", Weakness = "Plante", CanEvolve = true, AtqSign = "Éclaboussure", Attacks = new List<string> { "Éclaboussure", "Barrage", "Aqua Jet", "Hydrocanon" } },
                    new Pokemon { ID = 22, Name = "Tiplouf", Type = "Eau", Description = "Un pingouin élégant et courageux.", Weight = 5.2, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "tiplouf.png", Region = "Sinnoh", Weakness = "Plante", CanEvolve = true, AtqSign = "Pistolet à O", Attacks = new List<string> { "Pistolet à O", "Rafale Hydro", "Ultrason", "Poudre Dodo" } },
                    new Pokemon { ID = 23, Name = "Lucario", Type = "Combat", Description = "Il ressent les auras des êtres vivants.", Weight = 54.0, Height = 1.2, IsCaptured = false, ImagePath = ImagesFolderPath + "lucario.png", Region = "Sinnoh", Weakness = "Psy", CanEvolve = false, AtqSign = "Aurasphère", Attacks = new List<string> { "Aurasphère", "Poing-Glace", "Griffe", "Coup d'Poing" } },
                    new Pokemon { ID = 24, Name = "Draco", Type = "Dragon", Description = "Un Pokémon dragon au corps élégant.", Weight = 16.5, Height = 4.0, IsCaptured = true, ImagePath = ImagesFolderPath + "draco.png", Region = "Kanto", Weakness = "Glace", CanEvolve = true, AtqSign = "Ultralaser", Attacks = new List<string> { "Ultralaser", "Draco-Rage", "Griffe", "Lance-Dragon" } },
                    new Pokemon { ID = 25, Name = "Tortipouss", Type = "Plante", Description = "Il porte une petite pousse sur sa tête.", Weight = 10.2, Height = 0.4, IsCaptured = false, ImagePath = ImagesFolderPath + "tortipouss.png", Region = "Sinnoh", Weakness = "Feu", CanEvolve = true, AtqSign = "Canon Graine", Attacks = new List<string> { "Canon Graine", "Fouet Lianes", "Dard-Venin", "Rugissement" } },
                    new Pokemon { ID = 26, Name = "Arcko", Type = "Plante", Description = "Un Pokémon agile et vif.", Weight = 5.0, Height = 0.5, IsCaptured = true, ImagePath = ImagesFolderPath + "arcko.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Tranch'Herbe", Attacks = new List<string> { "Tranch'Herbe", "Coup d'Main", "Vive-Attaque", "Rugissement" } },
                    new Pokemon { ID = 27, Name = "Balignon", Type = "Plante", Description = "Il ressemble à un champignon.", Weight = 4.5, Height = 0.3, IsCaptured = false, ImagePath = ImagesFolderPath + "balignon.png", Region = "Hoenn", Weakness = "Feu", CanEvolve = true, AtqSign = "Spore Coton", Attacks = new List<string> { "Spore Coton", "Fouet Lianes", "Poudre Dodo", "Tranch'Herbe" } },
                    new Pokemon { ID = 28, Name = "Pachirisu", Type = "Électrique", Description = "Un écureuil électrique rapide.", Weight = 3.9, Height = 0.4, IsCaptured = true, ImagePath = ImagesFolderPath + "pachirisu.png", Region = "Sinnoh", Weakness = "Sol", CanEvolve = false, AtqSign = "Parabocharge", Attacks = new List<string> { "Parabocharge", "Tonnerre", "Vive-Attaque", "Queue de Fer" } },
                    new Pokemon { ID = 29, Name = "Démanta", Type = "Eau", Description = "Un Pokémon marin qui glisse sur l'eau.", Weight = 220.0, Height = 2.1, IsCaptured = false, ImagePath = ImagesFolderPath + "demanta.png", Region = "Johto", Weakness = "Électrique", CanEvolve = false, AtqSign = "Surf", Attacks = new List<string> { "Surf", "Barrage", "Hydrocanon", "Plongeon" } },
                    new Pokemon { ID = 30, Name = "Zygarde", Type = "Dragon", Description = "Le gardien de l'équilibre écologique.", Weight = 305.0, Height = 5.0, IsCaptured = true, ImagePath = ImagesFolderPath + "zygarde.png", Region = "Kalos", Weakness = "Fée", CanEvolve = false, AtqSign = "Force Chtonienne", Attacks = new List<string> { "Force Chtonienne", "Draco-Queue", "Séisme", "Lance-Dragon" } }
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
            try
            {
                if (ValidateInputFields())
                {
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
                        Attacks = new List<string> { comboBoxAttck1.Text, comboBoxAttck2.Text, comboBoxAttck3.Text, comboBoxAttck4.Text }
                    };
                    pokemons.Add(pokemon);
                    allAttacks = allAttacks.Union(pokemon.Attacks).ToList();

                    comboBoxAttck1.DataSource = new List<string>(allAttacks);
                    comboBoxAttck2.DataSource = new List<string>(allAttacks);
                    comboBoxAttck3.DataSource = new List<string>(allAttacks);
                    comboBoxAttck4.DataSource = new List<string>(allAttacks);

                    UpdatePokemonList();
                    listBoxPokemons.SelectedItem = pokemon;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout du Pokémon : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Supprimer un Pokémon
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                pokemons.Remove(selectedPokemon);
                UpdatePokemonList();
                ClearInputFields();
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
                        else if (txtImagePath.Text == "")
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
                    selectedPokemon.Attacks = new List<string> { comboBoxAttck1.Text, comboBoxAttck2.Text, comboBoxAttck3.Text, comboBoxAttck4.Text };

                    allAttacks = allAttacks.Union(selectedPokemon.Attacks).ToList();

                    comboBoxAttck1.DataSource = new List<string>(allAttacks);
                    comboBoxAttck2.DataSource = new List<string>(allAttacks);
                    comboBoxAttck3.DataSource = new List<string>(allAttacks);
                    comboBoxAttck4.DataSource = new List<string>(allAttacks);
                    UpdatePokemonList();

                    listBoxPokemons.SelectedItem = txtName.Text;
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
                textAtqS.Text = selectedPokemon.AtqSign;
                string imgType = ImagesFolderPath + selectedPokemon.Type + ".png";

                if (selectedPokemon.Attacks.Count >= 1) comboBoxAttck1.SelectedItem = selectedPokemon.Attacks[0]; else { comboBoxAttck1.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 2) comboBoxAttck2.SelectedItem = selectedPokemon.Attacks[1]; else { comboBoxAttck2.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 3) comboBoxAttck3.SelectedItem = selectedPokemon.Attacks[2]; else { comboBoxAttck3.SelectedIndex = 0; }
                if (selectedPokemon.Attacks.Count >= 4) comboBoxAttck4.SelectedItem = selectedPokemon.Attacks[3]; else { comboBoxAttck4.SelectedIndex = 0; }

                comboBoxAttck1.Refresh();
                comboBoxAttck2.Refresh();
                comboBoxAttck3.Refresh();
                comboBoxAttck4.Refresh();


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
            txtName.Text = null;
            txtDescription.Text = null;
            cmbType.SelectedIndex = -1;
            cmbRegion.SelectedIndex = -1;
            cmbWeak.SelectedIndex = -1;
            txtWeight.Text = null;
            txtHeight.Text = null;
            chkCaptured.Checked = false;
            chkEvolve.Checked = false;
            txtImagePath.Text = null;
            pictureBoxPokemon.ImageLocation = null;
            textAtqS.Text = null;
            comboBoxAttck1.SelectedIndex = 0;
            comboBoxAttck2.SelectedIndex = 0;
            comboBoxAttck3.SelectedIndex = 0;
            comboBoxAttck4.SelectedIndex = 0;
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


            foreach (var pokemon in pokemons)
            {
                allAttacks = allAttacks.Union(pokemon.Attacks).ToList();
            }

            // Remplir les ComboBox avec les attaques
            comboBoxAttck1.DataSource = new List<string>(allAttacks);
            comboBoxAttck2.DataSource = new List<string>(allAttacks);
            comboBoxAttck3.DataSource = new List<string>(allAttacks);
            comboBoxAttck4.DataSource = new List<string>(allAttacks);

            listBoxPokemons.SelectedIndex = 0;
            listBoxPokemons.SelectedIndex = 1;
            listBoxPokemons.SelectedIndex = 0;

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

        private void newPkm_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItem is Pokemon selectedPokemon)
            {
                string imgType = ImagesFolderPath + selectedPokemon.Type + ".png";
                if (!string.IsNullOrEmpty(selectedPokemon.Type) && System.IO.File.Exists(imgType))
                {
                    pictureBoxType.ImageLocation = imgType;
                }
            }

        }
    }
}
