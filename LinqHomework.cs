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

        public void WordsThatStartWithTh(List<string> wordString)
        {
            var words = wordString;
            var thWords = words.Where(w => w.Contains("th")); //w represents the words(strings objects) in the list wordString.
            foreach (var word in thWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

        }

        public void RemoveDuplicates(List<string> names)
        {
            var words = names;
            var removedWords = words.Distinct();
            foreach (var word in removedWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

        }

        public void GradesAveraged(List<string> classGrades)
        {

        }

        public void ShortenWord()
        {

        }

    }
}
