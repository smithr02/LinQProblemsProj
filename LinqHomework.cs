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
            var grades = classGrades;
            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();
            List<int> listThree = new List<int>();
            List<int> listFour = new List<int>();
            int i = 0;
            var splitGrade = grades.SelectMany(g => g.Split(','));
            var intGrade = splitGrade.Select(s => Int32.Parse(s));
            foreach (var grade in intGrade)
            {
                while (i <= 20)
                {
                    if (i < 5)
                    {
                        listOne.Add(grade);
                        i++;
                        break;
                    }
                    else if (i > 4 && i < 10)
                    {
                        listTwo.Add(grade);
                        i++;
                        break;
                    }
                    else if (i > 9 && i < 15)
                    {
                        listThree.Add(grade);
                        i++;
                        break;
                    }
                    else if (i > 14 && i < 20)
                    {
                        listFour.Add(grade);
                        i++;
                        break;
                    }
                }
            }
            var sListOne = listOne.OrderBy(s => s).Skip(1).Average();
            Console.WriteLine("First student average is: " + sListOne + "\n");

            var sListTwo = listTwo.OrderBy(s => s).Skip(1).Average();
            Console.WriteLine("First student average is: " + sListTwo + "\n");

            var sListThree = listThree.OrderBy(s => s).Skip(1).Average();
            Console.WriteLine("First student average is: " + sListThree + "\n");

            var sListFour = listFour.OrderBy(s => s).Skip(1).Average();
            Console.WriteLine("First student average is: " + sListFour + "\n");

            double classAverage = (sListOne + sListTwo + sListThree + sListFour) / 4;
            Console.WriteLine("Class average is: " + classAverage + "\n");
            Console.ReadLine();
        }

        public void ShortenWord()
        {
            Console.WriteLine("Enter word");
            string name = Console.ReadLine().ToUpper();
            var condensedName = name.OrderBy(n => n).GroupBy(n => n).Select(n => n);
            foreach (var characterCount in condensedName)
            {
                Console.WriteLine("" + characterCount.Key + characterCount.Count());
            }
            Console.ReadLine();
        }

    }

}


    

