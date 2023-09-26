using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class PlaySecondGame : Form
    {
        readonly private static Random rnd = new Random();

        int countOfWords;

        Font fontForButtons = new Font("Microsoft Sans Serif", 18, FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(204)));

        const int countOfButtons = 5;

        List<Button> buttons = new List<Button>();

        List<int> indexiesForRandom = new List<int>();

        int rndIndexOfRightButton;

        Color incorrectColor = Color.Red;

        Color defaultColor = Color.White;

        int centerOfThePnlFromScreenStart;

        int countOfRightAnswers;

        int rndIndexForRightAnswer;

        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> namesOfFolders = new List<string>();
        List<string> pathsToFolders = new List<string>();

        string pathToWords;

        List<string> leftWords = new List<string>();
        List<string> rightWords = new List<string>();

        public PlaySecondGame()
        {
            InitializeComponent();
            centerOfThePnlFromScreenStart = pnlButtons.Width / 2 + pnlButtons.Location.X;
            CreatingButtons();
        }

        private void HowMutchWords()
        {
            label1.Text = $"{leftWords.Count - countOfRightAnswers} words left";
        }

        private void CreatingButtons()
        {
            int heightOnElement = pnlButtons.Height / countOfButtons;

            for (int i = 0; i < countOfButtons; i++)
            {
                Button but = new Button();
                but.BackColor = SystemColors.WindowFrame;
                but.Font = label1.Font;
                but.Font = fontForButtons;
                but.AutoSize = true;
                but.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                but.Location = new Point(0, (heightOnElement * i));
                pnlButtons.Controls.Add(but);
                buttons.Add(but);
                but.MouseClick += But_MouseClick;
            }
        }

        private void But_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Select();

            if (sender is Button but)
            {
                if (isCorrectAnswer(but))
                {
                    if (!isGameOver())
                    {
                        FillButtonsAndLabel(rightWords, leftWords);
                        PutButtonsAndLabelOnTheRightDistance();
                        ClearButtons();
                        HowMutchWords();
                    }
                }

                else
                {
                    but.ForeColor = incorrectColor;
                }
            }
        }

        private void ClearButtons()
        {
            foreach (Button button in buttons)
            {
                button.ForeColor = defaultColor;
            }
        }

        private bool isCorrectAnswer(Button but)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (but == buttons[i] && i == rndIndexOfRightButton)
                {
                    indexiesForRandom.Remove(rndIndexForRightAnswer);
                    countOfRightAnswers++;
                    return true;
                }
            }
            
            return false;
        }

        private bool isGameOver()
        {
            if (countOfRightAnswers != leftWords.Count) return false;
            else
            {
                label1.Text = "You won - you overcame laziness!";
                SetRightLocationForUpperLabel();
                HideButtonsAndLabel();
                formWithDictioanaries.PlusOneRepeatingAndRefillingFile();
                this.Text = $"{namesOfFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                $" ({InfoClass.ChooseVocabulary.NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]} times)";
                return true;
            }
        }

        private void HideButtonsAndLabel()
        {
            lWordToGuess.Visible = false;
            bRestart.Enabled = true;

            foreach (Button but in buttons)
            {
                but.Visible = false;
                but.Enabled = false;
            }
        }

        private void FormForPlaySecondGame_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void FillRussianAndEnglishlists(List<string> leftWords, List<string> rightWords, List<int> indexiesForRandom)
        {
            InfoClass.SplitDocAndRefillLists(leftWords, rightWords, pathToWords);
            countOfWords = rightWords.Count;

            indexiesForRandom.Clear();
            for (int i = 0; i < countOfWords; i++)
            {
                indexiesForRandom.Add(i);
            }
        }

        private void CleanAllToRestart()
        {
            namesOfFolders = formWithDictioanaries.NamesOfFolders;
            pathsToFolders = formWithDictioanaries.PathsToFolders;

            pathToWords = $"{pathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
           @"\Words.txt";

            this.Location = InfoClass.LocationOfForms;
            this.Text = $"{namesOfFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                $" ({InfoClass.ChooseVocabulary.NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]} times)";

            countOfRightAnswers = 0;

            label1.Select();

            label1.Text = $"{leftWords.Count} words left";
            SetRightLocationForUpperLabel();

            ClearButtons();
            ShowButtonsAndLabel();

            FillRussianAndEnglishlists(leftWords, rightWords, indexiesForRandom);

            FillButtonsAndLabel(rightWords, leftWords);

            SetButtonsHowManyYouNeed();

            PutButtonsAndLabelOnTheRightDistance();

            HowMutchWords();
        }

        private void SetButtonsHowManyYouNeed()
        {
            int maxCountofButtons = Math.Min(countOfButtons, leftWords.Count);
            for (int i = maxCountofButtons; i < buttons.Count; i++)
            {
                buttons[i].Visible = false;
                buttons[i].Enabled = false;
            }
        }

        private void SetRightLocationForUpperLabel()
        {
            int XlocationForLabel = centerOfThePnlFromScreenStart - (label1.Width / 2);
            label1.Location = new Point(XlocationForLabel, label1.Location.Y);
        }

        private void ShowButtonsAndLabel()
        {
            lWordToGuess.Visible = true;
            bRestart.Enabled = false;

            foreach (Button but in buttons)
            {
                but.Visible = true;
                but.Enabled = true;
            }
        }

        private void PutButtonsAndLabelOnTheRightDistance()
        {
            int countOfCycles = Math.Min(countOfButtons, leftWords.Count);
            int SpaceBetweenY = pnlButtons.Height / countOfCycles;

            //Setting labels
            int XlocationForLabel = centerOfThePnlFromScreenStart - (lWordToGuess.Width / 2);
            lWordToGuess.Location = new Point(XlocationForLabel, lWordToGuess.Location.Y);
            //Setting buttons
            int centerOfThePnl = pnlButtons.Width / 2;

            for (int i = 0; i < countOfCycles; i++)
            {
                int XlocationForButton = centerOfThePnl - (buttons[i].Width / 2);
                buttons[i].Location = new Point(XlocationForButton, i * SpaceBetweenY);
            }
        }

        private void FillButtonsAndLabel(List<string> listForButtons, List<string> listForQuestion)
        {
            int maxCountofButtons = Math.Min(countOfButtons, listForButtons.Count);
            int maxCountCyclesForRestButtons = maxCountofButtons - 1;

            rndIndexForRightAnswer = indexiesForRandom[rnd.Next(0, indexiesForRandom.Count)];

            string questionWord = listForQuestion[rndIndexForRightAnswer];
            lWordToGuess.Text = questionWord;

            string rightAnswer = listForButtons[rndIndexForRightAnswer];
            rndIndexOfRightButton = rnd.Next(0, maxCountofButtons);
            buttons[rndIndexOfRightButton].Text = rightAnswer;

            List<int> indiciesForRestButtons = new List<int>();

            for (int i = 0; i < maxCountCyclesForRestButtons; i++)
            {
                int rndIndexForButtons = rnd.Next(0, listForButtons.Count);
                if (!indiciesForRestButtons.Contains(rndIndexForButtons) && rndIndexForButtons != rndIndexForRightAnswer)
                    indiciesForRestButtons.Add(rndIndexForButtons);
                else i--;
            }

            int j = 0;
            for (int i = 0; i < maxCountofButtons; i++)
            {
                if (i != rndIndexOfRightButton)
                {
                    buttons[i].Text = listForButtons[indiciesForRestButtons[j]];
                    j++;
                }
            }
        }

        private void FormForPlaySecondGame_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                CleanAllToRestart();
            }
        }

        private void FormForPlaySecondGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.ChooseVocabulary.Show();
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            CleanAllToRestart();
        }
    }
}
