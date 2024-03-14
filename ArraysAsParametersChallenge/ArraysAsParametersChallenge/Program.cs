// CHALLENGE - Create an array of happiness in the main method and assign 5 values to it.
// Create a method SunIsShining, which has an array of type int as its parameter
// This method should increase the argument given by 2, for each entry.
// Call this method in the main method and use "happiness" as the argument.
// Create a foreach loop in the main method to write all values onto the console.




namespace ArraysAsParametersChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 7, 15, 17, 3, 14 };
            Console.WriteLine("Before the method: ");
            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }
            SunIsShining(happiness);
            Console.WriteLine("After the method: ");
            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void SunIsShining(int[] array)
        {
            int size = array.Length;
            for(int i = 0; i < size; i++) 
            {
                array[i] += 2;
            }
        }
    }
}
