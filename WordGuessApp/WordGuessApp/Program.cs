// See https://aka.ms/new-console-template for more information
namespace WordGuessApp
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLVE THE RIGHT PUZZLE BELOW ; ");
            Console.WriteLine("HINT: GUESSES SHOULD NOT BE LESS THAN THREE LETTER WORDS.");
            List<ScrabbleWork> word = new List<ScrabbleWork>()
            {
                new ScrabbleWork ("1. UABTUIFLE","BEAUTIFUL", "BAT", "EAT"),
                new ScrabbleWork ("2. EERHRASAL","REHEARSAL", "HERE", "HEAR"),
                new ScrabbleWork ("3. ERINFD","DIE", "END", "FRIEND"),
                new ScrabbleWork ("4. BIRTHDAY","DAY", "BIRTH", "RAY"),
                new ScrabbleWork ("5. SYATRWRBER","BET", "BERRY", "STRAWBERRY"),
                new ScrabbleWork ("6. EVERYTHING","VERY", "HINT", "EVERY"),
                new ScrabbleWork ("7. IFNFEDRET","TEN", "DIFFERENT", "RENT"),
                new ScrabbleWork ("8. TECHNOLOGY","TECHNO", "LOG", "ONE"),
                new ScrabbleWork ("9. FOUNDATION","FOUNTAIN", "DONATION", "NATION"),
                new ScrabbleWork ("10. RECEPTION","POINT", "COIN", "CREEP"),
            };
            int totalscore = 0;
            foreach (var words in word)
            {
                AskQuestion(words);
                totalscore += Correct(words.scrabble1, words.scrabble2, words.scrabble3);
                totalscore += Correct(words.scrabble1, words.scrabble2, words.scrabble3);
                totalscore += Correct(words.scrabble1, words.scrabble2, words.scrabble3);
            }
            Console.WriteLine($"total score = {totalscore}");
            static void AskQuestion(ScrabbleWork question)
            {
                Console.WriteLine(question.scrabble);
            }
            static int Correct(string puzzle1, string puzzle2, string puzzle3)
            {
                while (true)
                {
                    string answer = Console.ReadLine();
                    if (answer.Equals(puzzle1, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(puzzle2, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(puzzle3, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("PASS! YOU HAVE GOTTEN 1 POINT");
                        return 1;
                    }
                    else if (answer != puzzle1 || answer != puzzle2 || answer != puzzle3)
                    {
                        Console.WriteLine("WRONG GUESS. TRY AGAIN");
                    }
                    else
                    {
                        Console.WriteLine("YOU FAILED");
                        return 0;
                    }
                }
            }
            foreach (var words in word)
            {
                Console.WriteLine(words.scrabble1);
                Console.WriteLine(words.scrabble2);
                Console.WriteLine(words.scrabble3);
            }
        }
    }
}