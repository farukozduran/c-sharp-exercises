namespace ChallengeString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];
            //Gets the Index of the character from the string
            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name: ");
            //Read the first name
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            //Read the last name
            string lastName = Console.ReadLine();

            //Concatinate the firstName and lastName variable and assign that to fullName variable.
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();
        }
    }
}
