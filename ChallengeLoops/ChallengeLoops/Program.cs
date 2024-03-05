/*Imagine you are a developer and get a job in 
which you need to create a program for a teacher. 
He needs a program written in c# that calculates the average score of his students. 
So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. 
Finally once he is done entering scores, the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. 
Make sure the program doesn't crash if the teacher enters an incorrect value.
Test your program thoroughly.*/




namespace ChallengeLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 0;
            string gradesOfStudentsText;
            int totalGrades = 0;
            

            while (true)
            {
                Console.WriteLine("Please enter the grade of next student: ");
                gradesOfStudentsText = Console.ReadLine();
                bool isGrade = (int.TryParse(gradesOfStudentsText, out var gradesOfStudents) && gradesOfStudentsText != "-1" && (gradesOfStudents > 0 && gradesOfStudents < 21));
                if (isGrade)
                {
                    numberOfStudents++;
                    totalGrades += gradesOfStudents;
                }else if(gradesOfStudentsText.Equals("-1"))
                {
                    double average = totalGrades / numberOfStudents;
                    Console.WriteLine("Average grade is {0}", average);
                    break;
                }
                else if (gradesOfStudents != -1)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
            }
            Console.WriteLine(totalGrades);
            Console.WriteLine(numberOfStudents);
            Console.Read();

        }
    }
}
