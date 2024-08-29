using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
      string wordle = "lover";
      string guess;
      bool solved = false;
      Console.WriteLine("Welcome to Console wordle!!");
      // Playing the game loop
      while (!solved)
      {
      // Getting valid input loop
      do
      {
        // Prompts user to enter their 5 character guess
        Console.WriteLine("Enter your 5 character guess:");
        // Takes user input as guess, if null then fills in aaaaa
        guess = Console.ReadLine() ?? "aaaaa";
        guess = guess.Trim().ToLower();
        if (guess.Length != 5)
        {
          Console.WriteLine("Invalid input. Please enter exactly 5 characters.");

        }
      } while (guess.Length != 5);
      // Sets up answer stringbuilder
      StringBuilder answer = new StringBuilder();


    // Loops through the guess, matching with the correct wordle
    for (int i = 0; i < wordle.Length; i++)
    {
      // if correct letter, put the correct letter
      if (guess[i] == wordle[i])
      {
        answer.Append(wordle[i]);
      }
      // If incorrect letter, put a underscore
      else{
        answer.Append('_');
      }
    }
    solved = wordle.Equals(answer.ToString());
      // Displays their guess
      Console.WriteLine("Your attempt is -> " + answer.ToString());
    }
    // Puzzle is solved!
    Console.WriteLine("Great work!");

    
}
}