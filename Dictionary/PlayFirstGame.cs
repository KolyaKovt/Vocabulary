using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class PlayFirstGame : Form
    {
        const int countOfButtonsForOneLanguage = 5;

        //пути к файлам
        string pathToWords;

        List<Button> russianButtons = new List<Button>();
        List<Button> englishButtons = new List<Button>();

        List<string> leftWords = new List<string>();
        List<string> rightWords = new List<string>();

        List<int> russianIndeciesForRandom = new List<int>();

        readonly private static Random rnd = new Random();

        List<int> currentFilledRussianWordsForMakingTextForEnglishLabels = new List<int>();
        List<int> currentFilledEnglishWords = new List<int>();
        int countOfFilledRussianWords;

        int countOfRightAnswers;

        int indexOfSelectedRussianLabel;
        int indexOfSelectedEnglishLabel;

        int countOfUsedWords;

        int countOfItterationsForFillingIn;

        int countOfWordsInVocabulary;

        bool russianButtonActivated;
        bool englishButtonActivated;

        Color colorOfUnselectedLabel = Color.White;
        Color colorOfSelectedLabel = Color.LightBlue;
        Color colorOfWrongAnswer = Color.Red;

        Font fontForButtons = new Font("Microsoft Sans Serif", 18, FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(204)));

        ChooseVocabulary formWithDictioanaries = InfoClass.ChooseVocabulary;

        List<string> namesOfFolders = new List<string>();

        public PlayFirstGame()
        {
            InitializeComponent();
            CreatingAllButtons();
        }

        private void howMutchWords()
        {
            label1.Text = $"{leftWords.Count - countOfRightAnswers} words left";
        }

        private void FillListsWithWords()
        {
            InfoClass.SplitDocAndRefillLists(leftWords, rightWords, pathToWords);

            countOfWordsInVocabulary = leftWords.Count;

            for (int i = 0; i < countOfWordsInVocabulary; i++)
            {
                russianIndeciesForRandom.Add(i);
            }
        }

        private void CreatingAllButtons()
        {
            int XRussianLocation = 0;
            int XEnglishLocation = 450;

            CreatingButtons(XRussianLocation, russianButtons);
            CreatingButtons(XEnglishLocation, englishButtons);
        }

        private void CreatingButtons(int XLocation, List<Button> list)
        {
            int heightOnElement = pnlButtons.Height / countOfButtonsForOneLanguage;

            for (int i = 0; i < countOfButtonsForOneLanguage; i++)
            {
                Button but = new Button();
                but.BackColor = SystemColors.WindowFrame;
                but.Font = label1.Font;
                but.Font = fontForButtons;
                but.AutoSize = true;
                but.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                but.Location = new Point(XLocation, (heightOnElement * i));
                but.TabStop = false;
                pnlButtons.Controls.Add(but);
                list.Add(but);
                but.MouseClick += Button_MouseClick;
                but.MouseUp += Button_MouseUp;
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button button = sender as Button;

                if (russianButtons.Contains(button))
                {
                    ClearFocus(ref russianButtonActivated, button);
                }

                else
                {
                    ClearFocus(ref englishButtonActivated, button);
                }
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Select();
            if (timer1.Enabled == false)
            {
                Button button = sender as Button;

                if (russianButtons.Contains(button))
                {
                    ChooseButton(russianButtons, button, ref indexOfSelectedRussianLabel, ref russianButtonActivated);
                }

                else
                {
                    ChooseButton(englishButtons, button, ref indexOfSelectedEnglishLabel, ref englishButtonActivated);
                }

                DoWeNeedToFillLabelsIfYesDoIt();
                howMutchWords();
                IsItFinish();
            }
        }

        private void ClearFocus(ref bool buttonActivated, Button button)
        {
            if (button.ForeColor != colorOfUnselectedLabel)
            {
                button.ForeColor = colorOfUnselectedLabel;
                buttonActivated = false;
            }
        }

        private void ChooseButton(List<Button> listButtons, Button button,
            ref int indexOfSelectedLabel, ref bool labelactivated)
        {
            for (int j = 0; j < listButtons.Count; j++)
            {
                listButtons[j].ForeColor = colorOfUnselectedLabel;
            }

            for (int i = 0; i < listButtons.Count; i++)
            {
                if (button == listButtons[i])
                {
                    indexOfSelectedLabel = i;
                    labelactivated = true;
                    listButtons[i].ForeColor = colorOfSelectedLabel;
                    if (russianButtonActivated && englishButtonActivated)
                    {
                        ProverkaNaPopadanie();
                        russianButtonActivated = default;
                        englishButtonActivated = default;
                    }
                    return;
                }
            }
        }

        private void DoWeNeedToFillLabelsIfYesDoIt()
        {
            if (countOfUsedWords == countOfItterationsForFillingIn && countOfFilledRussianWords < leftWords.Count)
            {
                ActivateButtons();
                FillRussianAndEnglishButtons();
                countOfUsedWords = 0;
            }
        }

        private void ActivateButtons()
        {
            for (int i = 0; i < countOfButtonsForOneLanguage; i++)
            {
                russianButtons[i].Visible = true;
                russianButtons[i].Enabled = true;

                englishButtons[i].Visible = true;
                englishButtons[i].Enabled = true;

                bRestart.Enabled = false;
            }
        }

        private void IsItFinish()
        {
            if (countOfRightAnswers == leftWords.Count)
            {
                label1.Text = "You won - you overcame laziness!";
                bRestart.Enabled = true;
                formWithDictioanaries.PlusOneRepeatingAndRefillingFile();
                this.Text = $"{namesOfFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                $" ({InfoClass.ChooseVocabulary.NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]} times)";
            }
        }

        private void CreatingTextForRussianLabel()
        {
            if (leftWords.Count - countOfFilledRussianWords >= countOfButtonsForOneLanguage)
            {
                countOfItterationsForFillingIn = countOfButtonsForOneLanguage;
            }

            else
            {
                countOfItterationsForFillingIn = leftWords.Count % countOfButtonsForOneLanguage;
            }

            currentFilledEnglishWords.Clear();

            for (int i = 0; i < countOfItterationsForFillingIn; i++)
            {
                int IndexOfIndexOfWord = rnd.Next(0, russianIndeciesForRandom.Count);
                int IndexOfWord = russianIndeciesForRandom[IndexOfIndexOfWord];

                russianIndeciesForRandom.Remove(IndexOfWord);

                russianButtons[i].Text = leftWords[IndexOfWord];
                currentFilledRussianWordsForMakingTextForEnglishLabels.Add(IndexOfWord);
                currentFilledEnglishWords.Add(IndexOfWord);
                countOfFilledRussianWords++;
            }
        }
        //создаём текст для английских лейблов
        private void CreatingTextForEnglishLabel()
        {
            for (int i = 0; i < countOfItterationsForFillingIn; i++)
            {
                int randomIndex = rnd.Next(0, currentFilledRussianWordsForMakingTextForEnglishLabels.Count);
                englishButtons[i].Text = rightWords[currentFilledRussianWordsForMakingTextForEnglishLabels[randomIndex]];
                currentFilledRussianWordsForMakingTextForEnglishLabels.Remove(
                    currentFilledRussianWordsForMakingTextForEnglishLabels[randomIndex]);
            }
        }

        private void FillRussianAndEnglishButtons()
        {
            CreatingTextForRussianLabel();
            CreatingTextForEnglishLabel();
            SetRightDistanceForLabels();
        }

        private void SetRightDistanceForLabels()
        {
            int countOfCycles;
            if ((leftWords.Count - countOfRightAnswers) >= countOfButtonsForOneLanguage) countOfCycles = countOfButtonsForOneLanguage;
            else countOfCycles = (leftWords.Count - countOfRightAnswers) % countOfButtonsForOneLanguage;

            int SpaceBetweenY = pnlButtons.Height / countOfCycles;
            int centerOfTheScreen = pnlButtons.Width / 2;

            for (int i = 0; i < countOfCycles; i++)
            {
                int xLocationOfEnglLab = russianButtons[i].Location.X + russianButtons[i].Size.Width + 30;

                int centetBetweenLabels = (russianButtons[i].Location.X + xLocationOfEnglLab
                    + englishButtons[i].Width) / 2;
                int razniza = centerOfTheScreen - centetBetweenLabels;

                russianButtons[i].Location = new Point(russianButtons[i].Location.X + razniza
                    , SpaceBetweenY * i);
                englishButtons[i].Location = new Point(xLocationOfEnglLab + razniza
                    , SpaceBetweenY * i);
            }

            for (int i = countOfCycles; i < countOfButtonsForOneLanguage; i++)
            {
                //убираем баттоны не удаляя их
                russianButtons[i].Enabled = false;
                englishButtons[i].Enabled = false;
                russianButtons[i].Visible = false;
                englishButtons[i].Visible = false;
            }
        }

        private bool ProverkaNaPopadanie()
        {
            string russianSelectedWord = russianButtons[indexOfSelectedRussianLabel].Text;
            string englishSelectedWord = englishButtons[indexOfSelectedEnglishLabel].Text;

            string whichEnglishWordHasToBe = rightWords[currentFilledEnglishWords[indexOfSelectedRussianLabel]];

            if (whichEnglishWordHasToBe == englishSelectedWord)
            {
                TakeAwayButtonsNotDeletingThem();

                return true;
            }

            else if (russianSelectedWord != "" && englishSelectedWord != "")
            {
                russianButtons[indexOfSelectedRussianLabel].ForeColor = colorOfWrongAnswer;
                englishButtons[indexOfSelectedEnglishLabel].ForeColor = colorOfWrongAnswer;

                timer1.Start();
                return true;
            }

            else return false;
        }

        private void TakeAwayButtonsNotDeletingThem()
        {
            russianButtons[indexOfSelectedRussianLabel].Visible = false;
            englishButtons[indexOfSelectedEnglishLabel].Visible = false;
            russianButtons[indexOfSelectedRussianLabel].Enabled = false;
            englishButtons[indexOfSelectedEnglishLabel].Enabled = false;

            countOfUsedWords++;
            countOfRightAnswers++;

            russianButtons[indexOfSelectedRussianLabel].ForeColor = colorOfUnselectedLabel;
            englishButtons[indexOfSelectedEnglishLabel].ForeColor = colorOfUnselectedLabel;
        }

        private void FormForPlayAGame_LocationChanged(object sender, EventArgs e)
        {
            InfoClass.LocationOfForms = this.Location;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoClass.ChooseVocabulary.Show();
        }

        private void FormForPlayAGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            russianButtons[indexOfSelectedRussianLabel].ForeColor = colorOfUnselectedLabel;
            englishButtons[indexOfSelectedEnglishLabel].ForeColor = colorOfUnselectedLabel;

            timer1.Stop();
        }

        private void FormForPlayAGame_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Start();
            }
        }

        private void Start()
        {
            namesOfFolders = formWithDictioanaries.NamesOfFolders;

            label1.Select();
            ActivateButtons();
            for (int i = 0; i < countOfButtonsForOneLanguage; i++)
            {
                russianButtons[i].ForeColor = colorOfUnselectedLabel;
                englishButtons[i].ForeColor = colorOfUnselectedLabel;
            }

            currentFilledEnglishWords.Clear();
            currentFilledRussianWordsForMakingTextForEnglishLabels.Clear();

            countOfFilledRussianWords = 0;

            countOfRightAnswers = 0;

            russianButtonActivated = default;
            englishButtonActivated = default;

            countOfUsedWords = 0;

            countOfItterationsForFillingIn = 0;

            countOfWordsInVocabulary = 0;

            russianIndeciesForRandom.Clear();


            pathToWords = $"{formWithDictioanaries.PathsToFolders[InfoClass.IndexOfSelectedVocabulary]}" +
            @"\Words.txt";

            this.Location = InfoClass.LocationOfForms;
            this.Text = $"{namesOfFolders[InfoClass.IndexOfSelectedVocabulary]}" +
                $" ({InfoClass.ChooseVocabulary.NumsOfRepeatings[InfoClass.IndexOfSelectedVocabulary]} times)";

            FillListsWithWords();
            FillRussianAndEnglishButtons();
            howMutchWords();
        }

        private void bPlayOneMoreTime_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}