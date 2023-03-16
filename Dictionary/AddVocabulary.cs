using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class AddVocabulary : Form
    {
        string pathForFolder, pathToWords;

        ChooseVocabulary formWithVocabularies = InfoClass.ChooseVocabulary;

        List<string> namesOfFolders = new List<string>();
        List<string> pathsToFolders = new List<string>();

        public AddVocabulary()
        {
            InitializeComponent();
        }
        
        private void StartAction()
        {
            namesOfFolders = formWithVocabularies.NamesOfFolders;
            pathsToFolders = formWithVocabularies.PathsToFolders;
            FormClear();
        }

        private void FormClear()
        {
            tbAddADictionary.Select();
            this.Location = InfoClass.LocationOfForms;
            tbAddADictionary.Text = "";
        }

        //закрытие и возвращение
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.ChooseVocabulary.Show();
        }

        private void FormForCreattingANewDictionary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bAddADictionary_Click(object sender, EventArgs e)
        {
            string nameOfNewDict = tbAddADictionary.Text.Trim();
            if (nameOfNewDict != "")
            {
                if (CheckValidOfName(nameOfNewDict))
                {
                    CreatingPaths(nameOfNewDict);
                    AddADictionary(nameOfNewDict);
                }
            }

            else MessageBox.Show("Name of the vocabulary can't be empty");
        }

        private void AddADictionary(string nameOfNewDict)
        {
            Directory.CreateDirectory($"{pathForFolder}");
            File.Create($"{pathToWords}").Close();

            namesOfFolders.Add(nameOfNewDict);
            pathsToFolders.Add(pathForFolder);

            formWithVocabularies.NumsOfRepeatings.Add(0);

            File.AppendAllText(InfoClass.PathToNamesOfFoldersAndRepeating, $"{nameOfNewDict} --- {0}\n");

            formWithVocabularies.CountOfVocabularies++;

            tbAddADictionary.Text = "";
        }

        private bool CheckValidOfName(string nameOfNewDict)
        {
            foreach (char ch in nameOfNewDict)
            {
                if (ch == '?')
                {
                    MessageBox.Show("You cant use '?'.");
                    return false;
                }

                if (ch == '.')
                {
                    MessageBox.Show("You cant use '.'.");
                    return false;
                }

                if (ch == '/')
                {
                    MessageBox.Show("You cant use '/'.");
                    return false;
                }

                if (ch.ToString() == @"\")
                {
                    MessageBox.Show(@"You cant use '\'.");
                    return false;
                }
            }

            if (nameOfNewDict.Contains(" --- "))
            {
                MessageBox.Show(@"You can't use this combination of symbols: "" --- "".");
                return false;
            }

            foreach (string item in namesOfFolders)
            {
                if (item.ToLower() == nameOfNewDict.ToLower())
                {
                    MessageBox.Show("You already have a vocabulary with this name");
                    return false;
                }
            }
            
            return true;
        }

        private void FormForAddANewDictionary_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartAction();
            }
        }

        private void CreatingPaths(string nameOfNewDict)
        {
            pathForFolder = $@"{InfoClass.PathToFolders}\{nameOfNewDict}";
            pathToWords = $@"{InfoClass.PathToFolders}\{nameOfNewDict}\Words.txt";
        }

        private void FormForCreattingANewDictionary_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }
    }
}
