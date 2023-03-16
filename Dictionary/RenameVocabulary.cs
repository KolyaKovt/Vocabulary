using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class RenameVocabulary : Form
    {
        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> namesOfFolders = new List<string>() ;
        List<string> pathsToFolders = new List<string>() ;

        public RenameVocabulary()
        {
            InitializeComponent();
        }

        private void StartAction()
        {
            namesOfFolders = formWithDictioanaries.NamesOfFolders;
            pathsToFolders = formWithDictioanaries.PathsToFolders;

            this.Location = InfoClass.LocationOfForms;
            tbChangeADictionary.Text = namesOfFolders[InfoClass.IndexOfSelectedVocabulary];
            tbChangeADictionary.Select();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.ChooseVocabulary.Show();
        }

        private void bChangeADictionary_Click(object sender, EventArgs e)
        {
            ChangingNameOfDictionaryWithProverka();  
        }

        private void ChangingNameOfDictionaryWithProverka()
        {
            string nameOfFolder = tbChangeADictionary.Text.Trim();

            if (CheckValidation(nameOfFolder))
            {
                Directory.Move($@"{pathsToFolders[InfoClass.IndexOfSelectedVocabulary]}",
                    $@"{InfoClass.PathToFolders}\dsdsddsdsdsdsdsdsdsdsdsdsdsdsd");
                Directory.Move($@"{InfoClass.PathToFolders}\dsdsddsdsdsdsdsdsdsdsdsdsdsdsd",
                    $@"{InfoClass.PathToFolders}\{nameOfFolder}");

                pathsToFolders[InfoClass.IndexOfSelectedVocabulary] = $@"{InfoClass.PathToFolders}\{nameOfFolder}";
                namesOfFolders[InfoClass.IndexOfSelectedVocabulary] = nameOfFolder;

                File.WriteAllLines(InfoClass.PathToNamesOfFoldersAndRepeating, formWithDictioanaries.NamesOfFolders);

                formWithDictioanaries.RefillTextDocWithNumOfRepeatingsAndNames();

                this.Hide();
                InfoClass.ChooseVocabulary.Show();
                InfoClass.ChooseVocabulary.FillListBox();
            }
        }

        private bool CheckValidation(string nameOfFolder)
        {
            foreach (char ch in nameOfFolder)
            {
                if (ch == '?')
                {
                    MessageBox.Show("You cant use '?'.");
                    return false;
                }
            }

            foreach (string item in namesOfFolders)
            {
                if (item == nameOfFolder)
                {
                    MessageBox.Show("You already have a vocabulary with this name");
                    return false;
                }
            }
            return true;
        }

        private void FormForChangingTheNameOfDictionary_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FormForChangingTheNameOfDictionary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormForChangingTheNameOfDictionary_Activated(object sender, EventArgs e)
        {
            StartAction();
        }
    }
}
