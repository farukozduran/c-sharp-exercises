namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee("Schrute", "Dwight", 20000);

            newEmployee.Work();
            newEmployee.Pause();

            Boss newBoss = new Boss("Scott", "Michael", 55000, "Volvo S90");

            newBoss.Lead();


            Trainee newTrainee = new Trainee("Howard", "Ryan", 10000, 15, 25);

            newTrainee.Work();
            Console.ReadKey();
        }
    }
}
