using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class AddWords : Form
    {
        string pathToWords;

        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> pathsToFolders = new List<string>();

        public AddWords()
        {
            InitializeComponent();
        }

        private void StartAction()
        {
            pathsToFolders = formWithDictioanaries.PathsToFolders;

            tbRussianWord.Select();
            pathToWords = $"{pathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                @"\Words.txt";

            tbEnglishWord.Text = "";
            tbRussianWord.Text = "";
            this.Location = InfoClass.LocationOfForms;
        }

        //возвращаемся
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.OpenVocabulary.Show();
        }

        //закрываем приложение при закрытии окна
        private void FormForAddingWords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //добавляем слово
        private void bAddOneWord_Click(object sender, EventArgs e)
        {
            AddingWordsWithProverka();
        }

        private void AddingWordsWithProverka()
        {
            string wordInRussian = tbRussianWord.Text.Trim();
            string wordInEnglish = tbEnglishWord.Text.Trim();

            if (wordInRussian == "" || wordInEnglish == "")
            {
                MessageBox.Show("You have to fill out both fields.");
                return;
            }

            if (wordInRussian.Contains(" --- ") || wordInRussian.Contains(" --- "))
            {
                MessageBox.Show(@"You can't use this combination of symbols: "" --- "".");
                return;
            }

            AddTheWordIntoTheDictionary(wordInRussian, wordInEnglish);
        }

        //добавление слова в словарь
        private void AddTheWordIntoTheDictionary(string leftTbWords, string rightTbWords)
        {
            InfoClass.OpenVocabulary.CountOfWords++;

            File.AppendAllText(pathToWords, $"{leftTbWords} --- {rightTbWords}\n");

            //очистка текстбоксов
            tbRussianWord.Text = "";
            tbEnglishWord.Text = "";

            tbRussianWord.Focus();
        }
        //действие при изменении местоположения формы
        private void FormForAddingWords_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FormForAddingWords_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartAction();
            }
        }
    }
}
