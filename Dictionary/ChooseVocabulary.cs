using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class ChooseVocabulary : Form
    {
        public List<string> PathsToFolders { get; set; } = new List<string>();
        public List<string> NamesOfFolders { get; set; } = new List<string>();

        public int CountOfVocabularies { get; set; }
        public List<int> NumsOfRepeatings { get; set; } = new List<int>();

        public ChooseVocabulary()
        {
            InitializeComponent();
            CreatingForms();
            FillListsWithInfo();
            MakeLocationAsCenterOfScreen();
        }

        private void MakeLocationAsCenterOfScreen()
        {
            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            InfoClass.LocationOfForms = new Point((screenSize.Width / 2) - (this.Width / 2), (screenSize.Height / 2) - (this.Height / 2));
        }

        private void CreatingForms()
        {
            InfoClass.ChooseVocabulary = this;
            RenameVocabulary form1 = new RenameVocabulary();
            InfoClass.RenameVocabulary = form1;
            OpenVocabulary form2 = new OpenVocabulary();
            InfoClass.OpenVocabulary = form2;
            AddVocabulary form3 = new AddVocabulary();
            InfoClass.AddANewVocabulary = form3;
            PlayFirstGame form4 = new PlayFirstGame();
            InfoClass.PlayFirstGame = form4;
            PlaySecondGame form5 = new PlaySecondGame();
            InfoClass.PlaySecondGame = form5;
            ChangeWords form6 = new ChangeWords();
            InfoClass.ChangeWord = form6;
            MoveWords form7 = new MoveWords();
            InfoClass.MoveWords = form7;
            AddWords form8 = new AddWords();
            InfoClass.AddWords = form8;
        }

        private void StartAction()
        {
            lbVocabulary.SelectedItems.Clear();
            tbSearchWord.Clear();

            this.AcceptButton = bSearchWord;
            this.Location = InfoClass.LocationOfForms;
            tbSearchWord.Select();

            FillListBox();
            EnabalesOfButtons();
        }

        public void FillListBox()
        {
            lbVocabulary.Items.Clear();

            for (int i = 0; i < CountOfVocabularies; i++)
            {
                lbVocabulary.Items.Add($"{NamesOfFolders[i]}        ({NumsOfRepeatings[i]} times)");
            }

            lbVocabulary.SelectedIndex = lbVocabulary.Items.Count - 1;
            lbVocabulary.SelectedItems.Clear();
        }

        public void DelateVocabulary()
        {
            List<int> SelectedIndices = new List<int>();

            foreach (int item in lbVocabulary.SelectedIndices)
            {
                SelectedIndices.Add(item);
            }

            SelectedIndices.Sort((a, b) => b.CompareTo(a));

            foreach (var item in SelectedIndices)
            {
                File.Delete($@"{PathsToFolders[item]}\Words.txt");
                Directory.Delete(PathsToFolders[item]);

                PathsToFolders.RemoveAt(item);
                NamesOfFolders.RemoveAt(item);
                NumsOfRepeatings.RemoveAt(item);

                CountOfVocabularies--;
            }

            RefillTextDocWithNumOfRepeatingsAndNames();

            FillListBox();

            EnabalesOfButtons();
        }

        public void RefillTextDocWithNumOfRepeatingsAndNames()
        {
            File.WriteAllText(InfoClass.PathToNamesOfFoldersAndRepeating, "");

            for (int i = 0; i < NumsOfRepeatings.Count; i++)
            {
                File.AppendAllText(InfoClass.PathToNamesOfFoldersAndRepeating, $"{NamesOfFolders[i]} --- {NumsOfRepeatings[i]}\n");
            }
        }

        private void ShowFormForChangingDictionary()
        {
            InfoClass.IndexOfSelectedVocabulary = lbVocabulary.SelectedIndex;

            this.Hide();
            InfoClass.RenameVocabulary.Show();
        }

        private void lbDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabalesOfButtons();
        }

        private void EnabalesOfButtons()
        {
            //доступность кнопок
            if (lbVocabulary.SelectedItems.Count == 0)
            {
                contextMenuStrip.Items[0].Enabled = false;

                contextMenuStrip.Items[1].Enabled = false;
                contextMenuStrip.Items[2].Enabled = false;
            }

            else if (lbVocabulary.SelectedItems.Count > 1)
            {
                contextMenuStrip.Items[0].Enabled = true;

                contextMenuStrip.Items[1].Enabled = false;
                contextMenuStrip.Items[2].Enabled = false;
            }

            else if (lbVocabulary.SelectedItems.Count == 1)
            {
                contextMenuStrip.Items[0].Enabled = true;

                contextMenuStrip.Items[1].Enabled = true;
                contextMenuStrip.Items[2].Enabled = true;
            }
        }

        private void lbDictionary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenVocabulary();
        }

        private void OpenVocabulary()
        {
            if (ProverkaNaVubrannuiItem())
            {
                InfoClass.IndexOfSelectedVocabulary = lbVocabulary.SelectedIndex;

                InfoClass.OpenVocabulary.Show();
                this.Hide();
            }
        }

        private bool ProverkaNaVubrannuiItem()
        {
            if (lbVocabulary.SelectedItem != null)
            {
                return true;
            }

            return false;
        }

        private void FillListsWithInfo()
        {
            string addInfo = "Additional information";

            if (Directory.Exists(addInfo))
            {
                CountOfVocabularies = File.ReadAllLines(InfoClass.PathToNamesOfFoldersAndRepeating).Length;

                NamesOfFolders = new List<string>();
                PathsToFolders = new List<string>();

                List<string> NumsOfRepeatingsStr = new List<string>();
                InfoClass.SplitDocAndRefillLists(NamesOfFolders, NumsOfRepeatingsStr, InfoClass.PathToNamesOfFoldersAndRepeating);

                NumsOfRepeatings = new List<int>();

                foreach (var item in NumsOfRepeatingsStr)
                {
                    NumsOfRepeatings.Add(int.Parse(item));
                }

                foreach (string item in NamesOfFolders)
                {
                    PathsToFolders.Add($@"{InfoClass.PathToFolders}\{item}");
                }
            }

            else
            {
                Directory.CreateDirectory(addInfo);
                Directory.CreateDirectory(addInfo + "\\Folders");
                File.Create(addInfo + "\\Names of folders.txt");
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FormForChoosingDictionary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbDictionary_MouseDown(object sender, MouseEventArgs e)
        {
            int y = e.Y / lbVocabulary.ItemHeight;
            if (y >= lbVocabulary.Items.Count && e.Button == MouseButtons.Left)
            {
                lbVocabulary.ClearSelected();
            }
        }

        private void DelateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoClass.IfFalseChooseIfTrueWords = false;

            Confirm form = new Confirm();
            InfoClass.AreYouSure = form;
            
            this.Enabled = false;
            InfoClass.HowMuchItemsToDelate = lbVocabulary.SelectedIndices.Count;
            InfoClass.AreYouSure.Show();
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormForChangingDictionary();
        }

        private void addAVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormForAddingDictionary();
        }

        private void ShowFormForAddingDictionary()
        {
            this.Hide();
            InfoClass.AddANewVocabulary.Show();
        }

        private void PlayFirstGameAction()
        {
            string pathToWords = $"{PathsToFolders[lbVocabulary.SelectedIndex]}" +
            @"\Words.txt";

            int countOfWords = File.ReadAllLines(pathToWords).Length;

            if (countOfWords != 0)
            {
                InfoClass.IndexOfSelectedVocabulary = lbVocabulary.SelectedIndex;

                this.Hide();
                InfoClass.PlayFirstGame.Show();
            }
            else
            {
                MessageBox.Show("Vocabulary is empty, you have to fill it in");
            }
        }

        private void lbDictionary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete && contextMenuStrip.Items[0].Enabled == true)
            {
                contextMenuStrip.Items[0].PerformClick();
            }
        }

        private void FormForChoosingDictionary_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StartAction();
            }
        }

        private void FormForChoosingDictionary_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true) StartAction();
        }

        private void connectingWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayFirstGameAction();
        }

        private void guessingWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySecondGameAction();
        }

        private void PlaySecondGameAction()
        {
            string pathToWords = $"{PathsToFolders[lbVocabulary.SelectedIndex]}" +
            @"\Words.txt";

            int countOfWords = File.ReadAllLines(pathToWords).Length;

            if (countOfWords != 0)
            {
                InfoClass.IndexOfSelectedVocabulary = lbVocabulary.SelectedIndex;

                this.Hide();
                InfoClass.PlaySecondGame.Show();
            }
            else
            {
                MessageBox.Show("Vocabulary is empty, you have to fill it in");
            }
        }

        public void PlusOneRepeatingAndRefillingFile()
        {
            NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]++;

            RefillTextDocWithNumOfRepeatingsAndNames();
        }

        private void bSearchWord_Click(object sender, EventArgs e)
        {
            if (tbSearchWord.Text.Trim() != "") SearchWordAndIfYouFoundItShowMessegeWithLocation();
            else MessageBox.Show("You have to fill the text box out");
        }

        private void SearchWordAndIfYouFoundItShowMessegeWithLocation()
        {
            string theWord = tbSearchWord.Text;

            List<string> namesOfFoldersWithTheWord = new List<string>();
            foreach (string nameOfFolder in NamesOfFolders)
            {
                List<string> allLeftWords = new List<string>();
                List<string> allRightWords = new List<string>();

                List<string> leftWords = new List<string>();
                List<string> rightWords = new List<string>();

                InfoClass.SplitDocAndRefillLists(leftWords, rightWords, $@"{InfoClass.PathToFolders}\{nameOfFolder}\Words.txt");

                allRightWords.AddRange(rightWords);
                allLeftWords.AddRange(leftWords);

                if(InfoClass.OpenVocabulary.DoListsHavePhrase(allRightWords, allLeftWords, theWord))
                    namesOfFoldersWithTheWord.Add(nameOfFolder);
            }

            string result;

            if (namesOfFoldersWithTheWord.Count == 0) result = "No one dictionary has this word";

            else
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < namesOfFoldersWithTheWord.Count; i++)
                {
                    string str = namesOfFoldersWithTheWord[i];
                    if (i != namesOfFoldersWithTheWord.Count - 1) sb.Append($"{str}, ");
                    else sb.Append($"{str}");
                }

                result = $"These dictionaries contain this word: {sb}.";
            }

            MessageBox.Show(result);
        }

        private void tbSearchDictionary_TextChanged(object sender, EventArgs e)
        {
            lbVocabulary.SelectedIndices.Clear();
        }
    }
}