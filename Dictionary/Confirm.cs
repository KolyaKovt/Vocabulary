using System;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void FormAreYouSure_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                if (InfoClass.IfFalseChooseIfTrueWords == false)
                {
                    InfoClass.ChooseVocabulary.Enabled = false;
                }

                else
                {
                    InfoClass.OpenVocabulary.Enabled = false;
                }
                AskUserIfHesSure();
            }
        }

        private void AskUserIfHesSure()
        {
            label1.Text = $"Are you sure that you want to delate {InfoClass.HowMuchItemsToDelate}" +
                            $" objects?";
        }

        private void ActivatePreviosForm()
        {
            if (InfoClass.IfFalseChooseIfTrueWords == false)
            {
                InfoClass.ChooseVocabulary.Enabled = true;
                InfoClass.ChooseVocabulary.Show();
                InfoClass.ChooseVocabulary.Activate();
            }
            else
            {
                InfoClass.OpenVocabulary.Enabled = true;
                InfoClass.OpenVocabulary.Show();
                InfoClass.OpenVocabulary.Activate();
            }
        }

        private void bYes_Click(object sender, EventArgs e)
        {
            if (InfoClass.IfFalseChooseIfTrueWords == false)
            {
                InfoClass.ChooseVocabulary.DelateVocabulary();
            }
            else
            {
                InfoClass.OpenVocabulary.DelateWords();
            }
            this.Close();
        }

        private void bNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAreYouSure_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActivatePreviosForm();
            InfoClass.AreYouSure = default;
        }
    }
}
