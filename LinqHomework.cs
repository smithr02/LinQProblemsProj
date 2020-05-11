using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQProblems
{
   public class LinqHomework
    {
        List<string> wordlist = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
        List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"
        };

        public LinqHomework()
        {
            WordsThatStartWithTh(wordlist);
            RemoveDuplicates(names);
            GradesAveraged(classGrades);
            ShortenWord();
        }

        public void WordsThatStartWithTh(List<string> names)
        {

        }

        public void RemoveDuplicates(List<string> names)
        {

        }

        public void GradesAveraged(List<string> classGrades)
        {

        }

        public void ShortenWord()
        {

        }

    }
}
