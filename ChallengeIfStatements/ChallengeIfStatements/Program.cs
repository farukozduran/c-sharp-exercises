/*Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the 
player is higher than the highscore, if so, "New highscore is + " score" and 
in another line "New highscore holder is " + playerName - should be written onto the console, 
if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.*/




namespace ChallengeIfStatements
{
    internal class Program
    {
        static int highScore;
        static string? highScorePlayer;
        static void Main(string[] args)
        {
            highScore = 100;
            highScorePlayer = "Faruk";
            HighScoreHolder(150, "Ecem");
            HighScoreHolder(150, "Sungur");
            HighScoreHolder(200, "Semih");
            Console.Read();
        }

        public static void HighScoreHolder(int score, string playerName)
        {
            switch(score > highScore)
            {
                case true:
                    highScore = score;
                    highScorePlayer = playerName;
                    Console.WriteLine("New highscore is " + score);
                    Console.WriteLine("New highscore holder is " + playerName);
                    break;
                default:
                    Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highScorePlayer);
                    break;

            }
        }
    }
}
