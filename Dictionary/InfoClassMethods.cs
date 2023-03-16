using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    internal partial class InfoClass
    {
        public static void SplitDocAndRefillLists(List<string> leftWords, List<string> rightWords, string path)
        {
            leftWords.Clear();
            rightWords.Clear();

            List<string> everything = new List<string>();

            everything.AddRange(File.ReadAllLines(path).ToList());

            char[] seporators = new char[] { '@', '#' };

            foreach (string word in everything)
            {
                string str = word.Replace(" --- ", "@#");
                string[] bothStrings = str.Split(seporators, StringSplitOptions.RemoveEmptyEntries);

                leftWords.Add(bothStrings[0].Trim());
                rightWords.Add(bothStrings[1]);
            }
        }
        public static void RewriteFile(List<string> leftWords, List<string> rightWords, string path)
        {
            File.WriteAllText(path, "");
            for (int i = 0; i < rightWords.Count; i++)
            {
                File.AppendAllText(path, $"{leftWords[i]} --- {rightWords[i]}\n");
            }
        }
    }
}