using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    internal partial class InfoClass
    {
        //выбранный айтэм для слов
        public static int IndexOfSelectedWords { get; set; }

        //выбранный айтэм для словарей
        public static int IndexOfSelectedVocabulary { get; set; }

        public static List<int> IndeciesOfSelectedWords { get; set; }

        //локация форм
        public static Point LocationOfForms { get; set; } = new Point(350, 150);

        public static string PathToNamesOfFoldersAndRepeating { get; } = @"Additional information\Names of folders.txt";

        public static string PathToFolders { get; } = @"Additional information\Folders";

        public static Confirm AreYouSure { get; set; }
        public static AddVocabulary AddANewVocabulary { get; set; }
        public static AddWords AddWords { get; set; }
        public static RenameVocabulary RenameVocabulary { get; set; }
        public static ChangeWords ChangeWord { get; set; }
        public static ChooseVocabulary ChooseVocabulary { get; set; }
        public static PlayFirstGame PlayFirstGame { get; set; }
        public static OpenVocabulary OpenVocabulary { get; set; }
        public static MoveWords MoveWords { get; set; }
        public static PlaySecondGame PlaySecondGame { get; set; }

        public static bool IfFalseChooseIfTrueWords { get; set; }

        public static int HowMuchItemsToDelate { get; set; }
    }
}