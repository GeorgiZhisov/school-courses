using static System.Net.Mime.MediaTypeNames;

namespace hangman;
class Program
{
    static void Main(string[] args)
    {

        const char Underscore = '_';

		const string winAnimation = @"
                                            ┌───────────────────────────┐
                                            │                           │
                                            │ WW       WW  **  NN   N   │
                                            │ WW       WW  ii  NNN  N   │
                                            │  WW  WW WW   ii  N NN N   │
                                            │   WWWWWWW    ii  N  NNN   │
                                            │    WW  W     ii  N   NN   │
                                            │                           │
                                            │         Good job!         │
                                            │   You guessed the word!   │
                                            └───────────────────────────┘
                                            ";

		const string loseAnimation = @"
                                            ┌────────────────────────────────────┐
                                            │  LLL          OOOO    SSSS   SSSS  │
                                            │  LLL         OO  OO  SS  SS SS  SS │
                                            │  LLL        OO    OO SS     SS     │
                                            │  LLL        OO    OO  SSSS   SSSS  │
                                            │  LLL        OO    OO     SS     SS │
                                            │  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
                                            │   LLLLLLLLL   OOOO    SSSS   SSSS  │
                                            │                                    |
                                            │        You were so close.          │
                                            │ Next time you will guess the word! │
                                            └────────────────────────────────────┘
                                            ";

		const int maxIncorrectGuesses = 6;

		string[] wrongGuessesFrames =
		{
				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"          ║   " + '\n' +
				@"          ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"          ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      |\  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"       \  ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══"

			};

		string[] deathAnimationFrames =
		{
				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"     ███  ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o>  ║   " + '\n' +
				@"     /|   ║   " + '\n' +
				@"      >\  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"     <o   ║   " + '\n' +
				@"      |\  ║   " + '\n' +
				@"     /<   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o>  ║   " + '\n' +
				@"     /|   ║   " + '\n' +
				@"      >\  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o>  ║   " + '\n' +
				@"     /|   ║   " + '\n' +
				@"      >\  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"     <o   ║   " + '\n' +
				@"      |\  ║   " + '\n' +
				@"     /<   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"     <o   ║   " + '\n' +
				@"      |\  ║   " + '\n' +
				@"     /<   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"     <o   ║   " + '\n' +
				@"      |\  ║   " + '\n' +
				@"     /<   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"     /|\  ║   " + '\n' +
				@"     / \  ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      o   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      |   ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      /   ║   " + '\n' +
				@"      \   ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    |__   ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    \__   ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"   ____   ║   " + '\n' +
				@"    ══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"    __    ║   " + '\n' +
				@"   /══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"    _ '   ║   " + '\n' +
				@"  _/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      _   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      _   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@"      _   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      .   ║   " + '\n' +
				@"          ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      '   ║   " + '\n' +
				@" __/══════╩═══",

				@"      ╔═══╗   " + '\n' +
				@"      |   ║   " + '\n' +
				@"      O   ║   " + '\n' +
				@"          ║   " + '\n' +
				@"          ║   " + '\n' +
				@"      _   ║   " + '\n' +
				@" __/══════╩═══"

			};
		string[] words = ReadWordsFromFile();

        Console.CursorVisible = false;


        while (true)
        {
            string word = GetRandomWord(words);

            string wordToGuess = new(Underscore, word.Length);

            int incorrectGuessCount = 0;

            List<char> playerUsedLetters = new List<char>();

			DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);

			PlayGame(word, wordToGuess, incorrectGuessCount, playerUsedLetters);

			Console.Write("If you want to play again press [Enter]. Else type 'quit':");
			string decision = Console.ReadLine();

			if (decision == "quit")
			{
				Console.Clear();
				Console.WriteLine("Thank you for playing! Hangman was closed.");
				return;
			}

			Console.Clear();


		}

        static string[] ReadWordsFromFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

            
            
            const string WordsFileName = "words.txt";

            
            string path = $@"{projectDirectory}\{WordsFileName} ";
            

            string[] words = File.ReadAllLines(path);


            return words;

        }

		bool CheckIfSymbolsIsContained(string words, char playerLetter)
		{
			if (!words.Contains(playerLetter))
			{
				return false;
			}

			return true;
		}



		string AddLetterToGuessWord(string words, char playerLetter, string wordToGuess)
		{

			char[] wordToGuessCharArr = wordToGuess.ToCharArray();

			for (int i = 0; i < wordToGuess.Length; i++)
			{
				if (playerLetter == words[i])
				{
					wordToGuessCharArr[i] = playerLetter;
				}

			}
			return new String(wordToGuessCharArr);
		}



		bool CheckIfPlayerWins(string wordToGuess)
		{
			const char Underscore = '_';
			if (wordToGuess.Contains(Underscore))
			{
				return false;
			}
			return true;
		}



		bool CheckIfPlayerLosses(int inccorectGuessCount)
		{
			const int MaxAllowedInccorectCharacters = 6;
			if (inccorectGuessCount == MaxAllowedInccorectCharacters)
			{
				return true;
			}

			return false;

		}



		string GetRandomWord(string[] words)
		{
			Random random = new Random();
			string word = words[random.Next(words.Length)];
			return word.ToLower();


		}

		void DrawDeathAnimation(string[] deathAnimation)
		{
			for (int i = 0; i < deathAnimation.Length; i++)
			{
				Console.WriteLine(deathAnimation[i]);
				Thread.Sleep(200);
				Console.SetCursorPosition(0, 0);
			}
		}


		void DrawCurrentGameState(bool inputIsInvalid, int incorrectGuessCount,
				string wordToGuess, List<char> playerUsedLetters)
		{
			Console.Clear();
			Console.WriteLine(wrongGuessesFrames[incorrectGuessCount]);

			Console.WriteLine($"Guess: {wordToGuess}");
			Console.WriteLine($"You have to guess {wordToGuess.Length} symbols");
			Console.WriteLine($"The following letters are used: {string.Join(", ", playerUsedLetters)}");

			if (inputIsInvalid)
			{
				Console.WriteLine("You should type only a single character!");
			}

			Console.Write("Your symbol: ");
		}

		void PlayGame(string word, string wordToGuess,
					int incorrectGuessCount, List<char> playerUsedLetters)
		{
			while (true)
			{
				string playerInput = Console.ReadLine().ToLower();

				if (playerInput.Length != 1)
				{
					DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
					continue;
				}

				char playerLetter = char.Parse(playerInput);
				playerUsedLetters.Add(playerLetter);

				bool playerLetterIsContained = CheckIfSymbolsIsContained(word, playerLetter);

				if (playerLetterIsContained)
				{
					wordToGuess = AddLetterToGuessWord(word, playerLetter, wordToGuess);
				}
				else
				{
					incorrectGuessCount++;
				}

				DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);

				bool playerWins = CheckIfPlayerWins(wordToGuess);

				if (playerWins)
				{
					Console.Clear();
					Console.WriteLine(winAnimation);
					Console.WriteLine($"The word you guessed is [{word}].");

					break;
				}

				bool playerLosses = CheckIfPlayerLosses(incorrectGuessCount);

				if (playerLosses)
				{
					Console.SetCursorPosition(0, 0);
					DrawDeathAnimation(deathAnimationFrames);

					Console.Clear();
					Console.WriteLine(loseAnimation);
					Console.WriteLine($"The exact word is [{word}].");

					break;
				}
			}
		}
    }    
}

