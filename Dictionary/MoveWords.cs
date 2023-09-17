using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class MoveWords : Form
    {
        string pathToWords;

        List<string> leftWords = new List<string>();
        List<string> rightWords = new List<string>();

        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> pathsToFolders = new List<string>();
        List<string> namesOfFolders = new List<string>();

        public MoveWords()
        {
            InitializeComponent();
        }

        private void StartAction()
        {
            this.Location = InfoClass.LocationOfForms;
            FillListsWithWords();
            FillListBoxes();
        }

        private void FillListsWithWords()
        {
            pathsToFolders = formWithDictioanaries.PathsToFolders;
            namesOfFolders = formWithDictioanaries.NamesOfFolders;

            pathToWords = $"{pathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                @"\Words.txt";

            InfoClass.SplitDocAndRefillLists(leftWords, rightWords, pathToWords);
        }

        private void FillListBoxes()
        {
            lbDictionary.Items.Clear();
            int count = formWithDictioanaries.CountOfVocabularies;

            for (int i = 0; i < count; i++)
            {
                lbDictionary.Items.Add(namesOfFolders[i]);
            }

            lbDictionary.SelectedIndex = lbDictionary.Items.Count - 1;
            lbDictionary.SelectedItems.Clear();
        }

        private void lbDictionary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbDictionary.SelectedItems.Count != 0 && InfoClass.IndexOfSelectedVocabulary != lbDictionary.SelectedIndex)
                MovingTheWords();
            else MessageBox.Show("The words are already here choose another one");
        }

        private void MovingTheWords()
        {
            List<int> delatingList = InfoClass.IndeciesOfSelectedWords;
            string pathToMove = $@"{InfoClass.PathToFolders}\{namesOfFolders[lbDictionary.SelectedIndex]}";

            foreach (int indx in delatingList)
            {
                File.AppendAllText($@"{pathToMove}\Words.txt", $"{leftWords[indx]} --- {rightWords[indx]}\n");
            }

            for (int i = delatingList.Count - 1; i >= 0; i--)
            {
                rightWords.RemoveAt(delatingList[i]);
                leftWords.RemoveAt(delatingList[i]);
            }

            string pathToRemove = $@"{InfoClass.PathToFolders}\{namesOfFolders[InfoClass.IndexOfSelectedVocabulary]}";

            InfoClass.RewriteFile(leftWords, rightWords, $@"{pathToRemove}\Words.txt");

            this.Hide();
            InfoClass.OpenVocabulary.Show();
        }

        private void FormWhereToMoveWords_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FormWhereToMoveWords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.OpenVocabulary.Show();
        }

        private void FormWhereToMoveWords_MouseDown(object sender, MouseEventArgs e)
        {
            lbDictionary.SelectedIndices.Clear();
        }

        private void lbDictionary_MouseDown(object sender, MouseEventArgs e)
        {
            //если мы не попали не по одному элементу списка, то очищаем выделенные элементы
            int y = e.Y / lbDictionary.ItemHeight;
            if (y >= lbDictionary.Items.Count)
            {
                lbDictionary.ClearSelected();
            }
        }

        private void FormWhereToMoveWords_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartAction();
            }
        }
    }
}
