using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class ChangeWords : Form
    {
        List<string> leftWords = new List<string>();
        List<string> rightWords = new List<string>();

        string pathToWords;

        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> pathsToFolders = new List<string>();

        public ChangeWords()
        {
            InitializeComponent();
        }

        private void StartAction()
        {
            pathsToFolders = formWithDictioanaries.PathsToFolders;

            tbRussianWord.Select();
            pathToWords = $"{pathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                @"\Words.txt";

            this.Location = InfoClass.LocationOfForms;

            InfoClass.SplitDocAndRefillLists(leftWords, rightWords, pathToWords);

            tbRussianWord.Text = leftWords[InfoClass.IndexOfSelectedWords];
            tbEnglishWord.Text = rightWords[InfoClass.IndexOfSelectedWords];
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.OpenVocabulary.Show();
        }

        private void bChangeAWord_Click(object sender, EventArgs e)
        {
            string wordInRussian = tbRussianWord.Text.Trim();
            string wordInEnglish = tbEnglishWord.Text.Trim();

            if (wordInRussian == "" || wordInEnglish == "")
            {
                MessageBox.Show("Вы должны заполнить оба поля");
                return;
            }

            ChangeWord(wordInRussian, wordInEnglish);
        }

        private void ChangeWord(string wordInRussian, string wordInEnglish)
        {
            //меняем списки
            leftWords.RemoveAt(InfoClass.IndexOfSelectedWords);
            rightWords.RemoveAt(InfoClass.IndexOfSelectedWords);

            leftWords.Insert(InfoClass.IndexOfSelectedWords, wordInRussian);
            rightWords.Insert(InfoClass.IndexOfSelectedWords, wordInEnglish);

            InfoClass.RewriteFile(leftWords, rightWords, pathToWords);

            this.Hide();
            InfoClass.OpenVocabulary.Show();
        }

        private void FormForChangingWord_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FormForChangingWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormForChangingWord_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartAction();
            }
        }
    }
}