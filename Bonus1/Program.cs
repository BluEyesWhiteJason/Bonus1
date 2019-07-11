using System;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Please enter your numerical grade: ");
                int numGrade = Convert.ToInt32(Console.ReadLine());

                string letterGrade;

                if (numGrade > 89)
                {
                    letterGrade = Convert.ToString('A');
                }
                else if (numGrade < 90 && numGrade > 79)
                {
                    letterGrade = Convert.ToString('B');
                }
                else if (numGrade < 80 && numGrade > 69)
                {
                    letterGrade = Convert.ToString('C');
                }
                else if (numGrade < 70 && numGrade > 59)
                {
                    letterGrade = Convert.ToString('D');
                }
                else
                {
                    letterGrade = Convert.ToString('F');
                }

                // plus or minus

                char plinus = 'p';
                int mod = numGrade % 10;

                if (numGrade > 59)
                {
                    if (mod > 7)
                    {
                        plinus = '+';
                    }
                    else if (mod < 8 && mod > 3)
                    {
                        plinus = ' ';

                    }
                    else if (mod < 4)
                    {
                        plinus = '-';
                    }
                }
                else
                {
                    plinus = ' ';
                }
                Console.WriteLine("Letter Grade: " + letterGrade + plinus);

                //Check continue
                Console.WriteLine("Continue? y/n : ");
                string contEnter = Console.ReadLine();

                if (contEnter == "y")
                {
                    cont = true;
                }
                else if (contEnter == "n")
                {
                    cont = false;
                }
            }

        }
    }
}
