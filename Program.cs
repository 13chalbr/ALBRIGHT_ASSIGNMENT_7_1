using System.Security.Cryptography.X509Certificates;

namespace ALBRIGHT_ASSIGNMENT_7_1
    
{
    internal class Program
    {
       
            // MSSA CCAD16 - 16DEC2024
            // CHRIS ALBRIGHT
            // ASSIGNMENT 7.1 - WEEK 7
            static void Main(string[] args)
            {
                //Assignment 7.1.1.---------------------------------------------------------------------------------------------

                // You are a student who has recently taken an exam with your classmates. However, the professor has not yet
                // provided the students with a sorted list of exam scores. To make things easier, you write a program to sort
                // exam scores in ascending order using the selection sort algorithm. This way, you can obtain the sorted list
                // of scores and see how you performed compared to your classmates. Also, you choose selection sort since that
                // is an easy way of implementation.

                Console.WriteLine("Assignment 7.1.1: ---------------------------------------------------------------------");
                Console.WriteLine("GRADE SORTER:");
                char hold1 = 'y';
                do
                {
                    List<Student> students = new List<Student>
                    {
                        new Student {Score = 85, Name = "Amy" },
                        new Student {Score = 95, Name = "Brenden" },
                        new Student {Score = 60, Name = "Chris"},
                        new Student {Score = 100, Name = "David" },
                        new Student {Score = 93, Name ="Eugene" },
                    };
                    Console.WriteLine("\nUnsorted Grades:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"Student: {student.Name}, Score: {student.Score}");
                    }

                    Console.WriteLine("\n\nSorted Grades:");
                    SelectionSort(students);

                    foreach (var student in students)
                    {
                        Console.WriteLine($"Student: {student.Name}, Score: {student.Score}");
                    }
                    Console.WriteLine($"\nWant to run 7.1 again? type y/n");
                    hold1 = Console.ReadKey().KeyChar;
                    hold1 = Char.ToLower(hold1);
                }
                while (hold1 == 'y');

            //Assignment 7.1.2.---------------------------------------------------------------------------------------------

            // You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting
            // with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
            // Return the merged string.

            Console.WriteLine("\nAssignment 7.1.2: ---------------------------------------------------------------------");
            Console.WriteLine("STRING ZIPPER:");
            char hold2 = 'y';
            do
            {
                Console.WriteLine("\nEnter string 1");
                string wordOne = Console.ReadLine();
                Console.WriteLine("\nEnter string 2");
                string wordTwo = Console.ReadLine();
                string result = "";
                int n = wordOne.Length;
                int diff = Math.Abs(wordTwo.Length - wordOne.Length);
                if (wordOne.Length > wordTwo.Length)
                {
                    n = wordTwo.Length;
                }
                for (int i = 0; i < n; i++)
                {
                    result += wordOne[i];
                    result += wordTwo[i];
                }
                if (wordOne.Length>wordTwo.Length)
                {
                    string lastDiffChars = wordOne.Substring(wordOne.Length - diff);
                    result += lastDiffChars;
                }
                if (wordOne.Length < wordTwo.Length)
                {
                    string lastDiffChars = wordTwo.Substring(wordTwo.Length - diff);
                    result += lastDiffChars;
                }
                Console.WriteLine($"\nZippered and appended result:");
                Console.WriteLine(result);
                Console.WriteLine($"\nWant to run 7.2 again? type y/n");
                hold2 = Console.ReadKey().KeyChar;
                hold2 = Char.ToLower(hold2);
            }
            while (hold2 == 'y');
            Console.WriteLine("\nGoodbye!");
        }
        //-------------------------------------------------Methods-----------------------------------------------------------
        public static List<Student> SelectionSort(in List<Student>students)
        {
            int n = students.Count;
            for (int i = 0; i < n-1; i++)
            {
                int maxIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (students[j].Score > students[maxIndex].Score)
                    {
                       maxIndex = j;
                    }
                }
                Student tempStudent = students[maxIndex];
                students[maxIndex] = students[i];
                students[i] = tempStudent;
            }
            return students;
        }
    }
}