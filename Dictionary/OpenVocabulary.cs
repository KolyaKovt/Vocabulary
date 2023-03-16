using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class OpenVocabulary : Form
    {
        string pathToWords;

        public List<string> leftWords = new List<string>();
        public List<string> rightWords = new List<string>();

        ChooseVocabulary chooseVocabulary = InfoClass.ChooseVocabulary;

        List<int> indeciesOfFoundWords = new List<int>();

        public int CountOfWords;

        public OpenVocabulary()
        {
            InitializeComponent();
        }

        private void StartActions()
        {
            tbSearch.Text = "";
            tbSearch.Select();
            this.Location = InfoClass.LocationOfForms;

            this.Text = $"{chooseVocabulary.NamesOfFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                $" ({InfoClass.ChooseVocabulary.NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]} times)";

            //пути к файлам
            pathToWords = $"{chooseVocabulary.PathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                @"\Words.txt";

            InfoClass.SplitDocAndRefillLists(leftWords, rightWords, pathToWords);

            CountOfWords = rightWords.Count;

            FillListBox();
            EnabalesOfButtons();
        }

        //действие при удалении слов из словаря
        public void DelateWords()
        {
            List<int> SelectedIndices = new List<int>();
            foreach (int item in lbVocabulary.SelectedIndices)
            {
                SelectedIndices.Add(item);
            }

            SelectedIndices.Sort((a, b) => b.CompareTo(a));

            foreach (var item in SelectedIndices)
            {
                rightWords.RemoveAt(item);
                leftWords.RemoveAt(item);

                InfoClass.OpenVocabulary.CountOfWords--;
            }

            InfoClass.RewriteFile(leftWords, rightWords, pathToWords);

            FillListBox();

            contextMenuStrip.Items[0].Enabled = false;
            contextMenuStrip.Items[1].Enabled = false;
        }

        private void ChangeWord()
        {
            InfoClass.IndexOfSelectedWords = lbVocabulary.SelectedIndex;

            this.Hide();
            InfoClass.ChangeWord.Show();
        }

        
        public void FillListBox()
        {
            lbVocabulary.Items.Clear();

            for (int i = 0; i < InfoClass.OpenVocabulary.CountOfWords; i++)
            {
                lbVocabulary.Items.Add($"{i + 1}. {leftWords[i]}  -  {rightWords[i]}");
            }

            lbVocabulary.SelectedIndex = lbVocabulary.Items.Count - 1;
            lbVocabulary.SelectedItems.Clear();
        }

        
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.ChooseVocabulary.Show();
        }

        private void FormForSeeingWords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void lbDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabalesOfButtons();
        }

        private void EnabalesOfButtons()
        {
            if (lbVocabulary.SelectedItems.Count == 0)
            {
                contextMenuStrip.Items[0].Enabled = false;
                contextMenuStrip.Items[2].Enabled = false;

                contextMenuStrip.Items[1].Enabled = false;
            }

            else if (lbVocabulary.SelectedItems.Count > 1)
            {
                contextMenuStrip.Items[0].Enabled = true;

                contextMenuStrip.Items[1].Enabled = false;
                contextMenuStrip.Items[2].Enabled = true;
            }

            else if (lbVocabulary.SelectedItems.Count == 1)
            {
                contextMenuStrip.Items[0].Enabled = true;
                contextMenuStrip.Items[1].Enabled = true;
                contextMenuStrip.Items[2].Enabled = true;
            }
        }

        private void FormForSeeingWords_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        public bool DoListsHavePhrase(List<string> leftWords, List<string> rightWords, string phrase)
        {
            indeciesOfFoundWords.Clear();
            lbVocabulary.SelectedIndices.Clear();

            phrase = phrase.Trim().ToLower();

            if (!(FindFrase(leftWords, phrase) || FindFrase(leftWords, phrase)))
            {
                FindOneOfWords(leftWords, phrase);
                FindOneOfWords(rightWords, phrase);
            }

            if (indeciesOfFoundWords.Count > 0) return true;

            return false;
        }

        private bool FindFrase(List<string> listToSearchIn, string phrase)
        {
            for (int i = 0; i < listToSearchIn.Count; i++)
            {
                if (phrase == listToSearchIn[i].ToLower())
                {
                    indeciesOfFoundWords.Add(i);
                }
            }

            if (indeciesOfFoundWords.Count > 0) return true;
            return false;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string theWord = tbSearch.Text.Trim();

            if (theWord == "") MessageBox.Show("You have to fill the text box out");

            else if (DoListsHavePhrase(leftWords, rightWords, tbSearch.Text.Trim()))
            {
                foreach (int ind in indeciesOfFoundWords)
                {
                    lbVocabulary.SetSelected(ind, true);
                }
            }

            else MessageBox.Show("The vocabulary doesn't have such a word");
        }

        private void FindOneOfWords(List<string> listToSearchIn, string phrase)
        {
            char[] seporators = new char[] { ',', ' ', '.', '!', '?', '(', ')', '/', '-' };

            string[] allPeacesOfSearchedPhrase = phrase.Split(seporators, StringSplitOptions.RemoveEmptyEntries); 

            for (int i = 0; i < listToSearchIn.Count; i++)
            {
                string[] allWordsInPhraseOfList = listToSearchIn[i].ToLower().Split(seporators);
                
                foreach (string wordFromList in allWordsInPhraseOfList)
                {
                    foreach (string searchedWord in allPeacesOfSearchedPhrase)
                    {
                        if (wordFromList == searchedWord)
                        {
                            indeciesOfFoundWords.Add(i);
                        }
                    }
                }
            }
        }

        private void FormForSeeingWords_MouseDown(object sender, MouseEventArgs e)
        {
            lbVocabulary.SelectedIndices.Clear();
        }

        private void lbDictionary_MouseDown(object sender, MouseEventArgs e)
        {
            int y = e.Y / lbVocabulary.ItemHeight;
            if (y >= lbVocabulary.Items.Count && e.Button == MouseButtons.Left)
            {
                lbVocabulary.ClearSelected();
            }
        }

        private void delateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoClass.IfFalseChooseIfTrueWords = true;

            if (InfoClass.AreYouSure == null)
            {
                Confirm form = new Confirm();
                InfoClass.AreYouSure = form;
            }

            this.Enabled = false;
            InfoClass.HowMuchItemsToDelate = lbVocabulary.SelectedIndices.Count;
            InfoClass.AreYouSure.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeWord();
        }

        private void moveInAnotherVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovingWord();
        }

        private void MovingWord()
        {
            InfoClass.IndeciesOfSelectedWords = new List<int>();
            foreach (int item in lbVocabulary.SelectedIndices)
            {
                InfoClass.IndeciesOfSelectedWords.Add(item);
            }

            this.Hide();
            InfoClass.MoveWords.Show();
        }

        private void addAWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.AddWords.Show();
        }

        private void FormForSeeingWords_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartActions();
            }
        }

        private void lbDictionary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete && contextMenuStrip.Items[0].Enabled == true)
            {
                contextMenuStrip.Items[0].PerformClick();
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            lbVocabulary.SelectedItems.Clear();
        }
    }
}