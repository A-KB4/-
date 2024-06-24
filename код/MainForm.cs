using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class MainForm : Form
    {
        private List<CrimeRecord> crimeRecords;
        private CrimeRecordArchive archive; public MainForm()
        {
            InitializeComponent();
            crimeRecords = new List<CrimeRecord>();
            archive = new CrimeRecordArchive();
            AddDefaultCriminals();
            UpdateCrimeRecordListBox(crimeRecords);
        }

   
        private void MainForm_Load(object sender, EventArgs e)
        {
            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crimeRecordListBox.SelectedIndex != -1) {
                var selectedRecord = crimeRecords[crimeRecordListBox.SelectedIndex];
                crimeRecords.Remove(selectedRecord);
                UpdateCrimeRecordListBox(crimeRecords);
            }
            else {
                MessageBox.Show("Please select a criminal record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AddDefaultCriminals()
        {
            var criminals = new List<CrimeRecord>
            {
        new CrimeRecord {
        FirstName = "John",
        LastName = "Doe",
        Nickname = "The Shadow",
        Height = 180,
        EyeColor = "Brown",
        Nationality = "American",
        BirthDate = new DateTime(1985, 7, 15),
        BirthPlace = "New York City, NY",
        },

        new CrimeRecord {
        Height = 165,
        EyeColor = "Green",
        Nationality = "British",
        BirthDate = new DateTime(1990, 4, 22),
        BirthPlace = "London, UK",
        LastKnownAddress = "456 Secret Street, London",
        CriminalProfession = "International Spy",
        HairColor = "Blonde"
        },

        new CrimeRecord {
        FirstName = "Max",
        LastName = "Johnson",
        Nickname = "The Hacker",
        Height = 175,
        EyeColor = "Blue",
        LastKnownAddress = "789 Underground Hideout, Toronto",
        CriminalProfession = "Cyber Criminal",
        HairColor = "Brown"
        },

        new CrimeRecord {
        FirstName = "Elena",
        LastName = "Garcia",
        Nickname = "Black Widow",
        Height = 170,
        EyeColor = "Brown",
        LastKnownAddress = "321 Dark Corner, Madrid",
        CriminalProfession = "Assassin",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Mikhail",
        LastName = "Ivanov",
        Nationality = "Russian",
        BirthDate = new DateTime(1975, 6, 18),
        BirthPlace = "Moscow, Russia",
        LastKnownAddress = "567 Kremlin Street, Moscow",
        CriminalProfession = "Mob Boss",
        HairColor = "Brown"
        },
        new CrimeRecord {
        FirstName = "Luna",
        LastName = "Chang",
        Nickname = "Nightshade",
        Height = 160,
        EyeColor = "Brown",
        Nationality = "Chinese",
        BirthDate = new DateTime(1995, 2, 28),
        BirthPlace = "Beijing, China",
        LastKnownAddress = "876 Shadow Lane, Beijing",
        },
        new CrimeRecord {
        FirstName = "Antonio",
        LastName = "Moreno",
        Nickname = "El Diablo",
        Height = 175,
        EyeColor = "Green",
        Nationality = "Mexican",
        BirthDate = new DateTime(1980, 11, 3),
        BirthPlace = "Mexico City, Mexico",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Sophia",
        LastName = "Andersson",
        Nickname = "Ice Queen",
        BirthDate = new DateTime(1987, 10, 12),
        BirthPlace = "Stockholm, Sweden",
        LastKnownAddress = "543 Frozen Lake, Stockholm",
        CriminalProfession = "Art Thief",
        HairColor = "Blonde"
        },
        new CrimeRecord {
        Nickname = "The Ghost",
        Height = 180,
        EyeColor = "Brown",
        Nationality = "Egyptian",
        BirthDate = new DateTime(1982, 4, 30),
        BirthPlace = "Cairo, Egypt",
        LastKnownAddress = "654 Phantom Street, Cairo",
        CriminalProfession = "Smuggler",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Maria",
        LastName = "Santos",
        Nickname = "La Loba",
        Height = 163,
        EyeColor = "Brown",
        Nationality = "Brazilian",
        BirthDate = new DateTime(1993, 8, 25),
        CriminalProfession = "Kidnapper",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Alexei",
        LastName = "Petrov",
        Nickname = "The Butcher",
        BirthDate = new DateTime(1970, 5, 14),
        BirthPlace = "St. Petersburg, Russia",
        LastKnownAddress = "876 Blood Alley, St. Petersburg",
        CriminalProfession = "Serial Killer",
        HairColor = "Gray"
        },
        new CrimeRecord {
        FirstName = "Chloe",
        LastName = "Leclerc",
        Nickname = "Mademoiselle Venom",
        Height = 165,
        EyeColor = "Green",
        BirthPlace = "Paris, France",
        LastKnownAddress = "567 Poison Lane, Paris",
        CriminalProfession = "Blackmailer",
        HairColor = "Brown"
        },
        new CrimeRecord {
        FirstName = "ххх",
        LastName = "ххх",
        Nickname = "El Gato",
        Height = 175,
        EyeColor = "Brown",
        Nationality = "Spanish",
        BirthDate = new DateTime(1984, 3, 19),
        BirthPlace = "Barcelona, Spain",
        LastKnownAddress = "ххх",
        CriminalProfession = "Burglar",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Anastasia",
        LastName = "Ivanova",
        Nickname = "Scarlet",
        Height = 170,
        BirthDate = new DateTime(1986, 9, 28),
        BirthPlace = "Moscow, Russia",
        LastKnownAddress = "321 Crimson Boulevard, Moscow",
        CriminalProfession = "Black Widow",
        HairColor = "Red"
        },
        new CrimeRecord {
        FirstName = "Jack",
        LastName = "Murphy",
        Nickname = "Spectre",
        Height = 185,
        EyeColor = "Blue",
        Nationality = "Irish",
        BirthDate = new DateTime(1978, 12, 3),
        BirthPlace = "Dublin, Ireland",
        LastKnownAddress = "654 Haunted House, Dublin",
        },
        new CrimeRecord {
        FirstName = "Aiko",
        LastName = "Tanaka",
        Nickname = "Oni",
        Nationality = "Japanese",
        BirthDate = new DateTime(1992, 2, 14),
        BirthPlace = "Tokyo, Japan",
        LastKnownAddress = "789 Demon Street, Tokyo",
        CriminalProfession = "Yakuza Enforcer",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Viktor",
        LastName = "Ilyin",
        Nickname = "The Bear",
        Height = 190,
        EyeColor = "Brown",
        Nationality = "Russian",
        LastKnownAddress = "876 Bear Den, Moscow",
        CriminalProfession = "Arms Dealer",
        HairColor = "Brown"
        },
        new CrimeRecord {
        FirstName = "Luis",
        LastName = "Silva",
        Nickname = "El Loco",
        Height = 180,
        EyeColor = "ххх",
        Nationality = "ххх",
        BirthDate = new DateTime(1981, 10, 20),
        BirthPlace = "Bogotá, Colombia",
        LastKnownAddress = "543 Crazy Street, Bogotá",
        CriminalProfession = "ххх",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Hana",
        LastName = "Kwon",
        Nickname = "Tiger Lily",
        Height = 162,
        EyeColor = "Black",
        Nationality = "ххх",
        BirthDate = new DateTime(1991, 5, 17),
        BirthPlace = "Seoul, South Korea",
        LastKnownAddress = "321 Flower Lane, Seoul",
        CriminalProfession = "ххх",
        HairColor = "Black"
        },
        new CrimeRecord {
        FirstName = "Igor",
        LastName = "Nikolaev",
        Nickname = "The Beast",
        Height = 195,
        EyeColor = "Gray",
        Nationality = "Ukrainian",
        BirthDate = new DateTime(1973, 1, 22),
        BirthPlace = "Kyiv, Ukraine",
        LastKnownAddress = "ххх",
        CriminalProfession = "ххх",
        HairColor = "Gray"
        }
        };

            foreach (var criminal in criminals) {
                crimeRecords.Add(criminal);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try {
                var crimeRecord = new CrimeRecord {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    HairColor = hairColorComboBox.SelectedItem?.ToString(),
                    Nickname = nicknameTextBox.Text,
                    Height = int.Parse(heightTextBox.Text),
                    EyeColor = eyeColorTextBox.Text,
                    Nationality = nationalityTextBox.Text,
                    BirthDate = DateTime.Parse(birthDateTextBox.Text),
                    BirthPlace = birthPlaceTextBox.Text,
                    LastKnownAddress = lastKnownAddressTextBox.Text,
                    CriminalProfession = criminalProfessionTextBox.Text
                };

                if (ValidateCrimeRecord(crimeRecord)) {
                    crimeRecords.Add(crimeRecord);
                    crimeRecordListBox.Items.Add(crimeRecord.GetInfo());
                    ClearInputFields();
                }
            }
            catch (FormatException) {
                MessageBox.Show("Invalid input format. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCrimeRecord(CrimeRecord crimeRecord)
        {
            if (string.IsNullOrWhiteSpace(crimeRecord.FirstName) ||
                string.IsNullOrWhiteSpace(crimeRecord.LastName) ||
                string.IsNullOrWhiteSpace(crimeRecord.Nickname) ||
                string.IsNullOrWhiteSpace(crimeRecord.EyeColor) ||
                string.IsNullOrWhiteSpace(crimeRecord.Nationality) ||
                string.IsNullOrWhiteSpace(crimeRecord.BirthPlace) ||
                string.IsNullOrWhiteSpace(crimeRecord.LastKnownAddress) ||
                string.IsNullOrWhiteSpace(crimeRecord.CriminalProfession) ||
                crimeRecord.Height <= 0 ||
                crimeRecord.BirthDate == null) {
                MessageBox.Show("Please provide all required information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (crimeRecords.Any()) {
                foreach (var record in crimeRecords.ToList()) {
                    archive.AddToArchive(record);
                    crimeRecords.Remove(record);
                    crimeRecordListBox.Items.Remove(record.GetInfo());
                }
                archive.SaveToFile("archive.xml");
            }
            else {
                MessageBox.Show("No crime records to archive.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchCriteria = CreateSearchCriteria();
            var matchingRecords = crimeRecords.Where(record => record.Matches(searchCriteria)).ToList();
            UpdateCrimeRecordListBox(matchingRecords);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            UpdateCrimeRecordListBox(crimeRecords);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            archive.LoadFromFile("archive.xml");
            var archivedRecords = archive.GetArchivedRecords();
            crimeRecords.AddRange(archivedRecords);
            UpdateCrimeRecordListBox(crimeRecords);
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            string fileName = "crime_records.txt";
            using (StreamWriter writer = new StreamWriter(fileName)) {
                foreach (var record in crimeRecords) {
                    writer.WriteLine($"First Name: {record.FirstName}");
                    writer.WriteLine($"Last Name: {record.LastName}");
                    writer.WriteLine($"Nickname: {record.Nickname}");
                    writer.WriteLine($"Height: {record.Height}");
                    writer.WriteLine($"Eye color: {record.EyeColor}");
                    writer.WriteLine($"Nationality: {record.Nationality}");
                    writer.WriteLine($"Birth Date: {record.BirthDate.GetValueOrDefault().ToShortDateString()}");
                    writer.WriteLine($"Birth Place: {record.BirthPlace}");
                    writer.WriteLine($"Last Known Address: {record.LastKnownAddress}");
                    writer.WriteLine($"Criminal Profession: {record.CriminalProfession}");
                    writer.WriteLine($"Hair Color: {record.HairColor}");
                    writer.WriteLine(); // Blank line to separate records
                }
            }
            MessageBox.Show("Crime records saved to text file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadTextButton_Click(object sender, EventArgs e)
        {
            string fileName = "crime_records.txt";
            if (File.Exists(fileName)) {
                string[] lines = File.ReadAllLines(fileName);
                var records = new List<CrimeRecord>();
                var currentRecord = new CrimeRecord();

                foreach (string line in lines) {
                    if (string.IsNullOrWhiteSpace(line)) {
                        records.Add(currentRecord);
                        currentRecord = new CrimeRecord();
                    }
                    else {
                        string[] parts = line.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length != 2) continue;  
                        string fieldName = parts[0];
                        string fieldValue = parts[1];

                        switch (fieldName) {
                            case "First Name":
                                currentRecord.FirstName = fieldValue;
                                break;
                            case "Last Name":
                                currentRecord.LastName = fieldValue;
                                break;
                            case "Nickname":
                                currentRecord.Nickname = fieldValue;
                                break;
                            case "Height":
                                currentRecord.Height = int.Parse(fieldValue);
                                break;
                            case "Eye Color":
                                currentRecord.EyeColor = fieldValue;
                                break;
                            case "Nationality":
                                currentRecord.Nationality = fieldValue;
                                break;
                            case "Birth Date":
                                currentRecord.BirthDate = DateTime.Parse(fieldValue);
                                break;
                            case "Birth Place":
                                currentRecord.BirthPlace = fieldValue;
                                break;
                            case "Last Known Address":
                                currentRecord.LastKnownAddress = fieldValue;
                                break;
                            case "Criminal Profession":
                                currentRecord.CriminalProfession = fieldValue;
                                break;
                            case "Hair Color":
                                currentRecord.HairColor = fieldValue;
                                break;
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(lines.Last())) {
                    records.Add(currentRecord);
                }

                crimeRecords.AddRange(records);
                UpdateCrimeRecordListBox(crimeRecords);

                MessageBox.Show("Crime records loaded from text file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Text file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewArchiveButton_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm(archive);
            archiveForm.ShowDialog();
        }

        private CrimeRecord CreateSearchCriteria()
        {
            return new CrimeRecord {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Nickname = nicknameTextBox.Text,
                Height = string.IsNullOrWhiteSpace(heightTextBox.Text) ? (int?)null : int.Parse(heightTextBox.Text),
                EyeColor = eyeColorTextBox.Text,
                Nationality = nationalityTextBox.Text,
                BirthDate = string.IsNullOrWhiteSpace(birthDateTextBox.Text) ? (DateTime?)null : DateTime.Parse(birthDateTextBox.Text),
                BirthPlace = birthPlaceTextBox.Text,
                LastKnownAddress = lastKnownAddressTextBox.Text,
                CriminalProfession = criminalProfessionTextBox.Text,
                HairColor = hairColorComboBox.SelectedItem?.ToString(),
            };
        }

        private void UpdateCrimeRecordListBox(List<CrimeRecord> records)
        {
            crimeRecordListBox.Items.Clear();
            foreach (var record in records) {
                crimeRecordListBox.Items.Add(record.GetInfo());
            }
        }

        private void ClearInputFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            nicknameTextBox.Clear();
            heightTextBox.Clear();
            eyeColorTextBox.Clear();
            nationalityTextBox.Clear();
            birthDateTextBox.Clear();
            birthPlaceTextBox.Clear();
            lastKnownAddressTextBox.Clear();
            criminalProfessionTextBox.Clear();
            hairColorComboBox.SelectedIndex = -1;
        }
    }
}