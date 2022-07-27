// See https://aka.ms/new-console-template for more information
namespace ClassObject
{
    class progarm
    {
        static void Main(string[] agrs)
        {

            List<QuizQuestion> listquestion = new List<QuizQuestion>()
            {
                new QuizQuestion("How many days are there in a week ??", "10", "7", "6 and half", "11", "B"),

                new QuizQuestion("How amny sec are there in 1 Min ??", "60", "7", "6", "All Of The Above", "A"),

                new QuizQuestion("Whats the brain of the computer?", "Keyboard", "CPU", "Mouse", "Capble", "B")
            };

            int totalgrade = 0;

             foreach (var Ques in listquestion)
            {
               AskQuestion(Ques);
               totalgrade += CheckAnswer(Ques.Answer);
            }
             Console.WriteLine("YOU SCORED: " + totalgrade);

            static int CheckAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! You have gotten 1 point.");
                    return 1;
                }
                else
                {
                    Console.WriteLine("You Failed ");
                    return 0;
                }
            }

            static void AskQuestion(QuizQuestion Question)

            {
                Console.WriteLine(Question.Qestion);
                Console.WriteLine("[A]. " + Question.OptionA);
                Console.WriteLine("[B]. " + Question.OptionB);
                Console.WriteLine("[C]. " + Question.OptionC);
                Console.WriteLine("[D]. " + Question.OptionD);
                Console.WriteLine("Kindly Enter An Option !");
            }
            //QuizQuestion Question1 = new QuizQuestion();
            //Question1.Qestion = "How many days are there in a week ??";
            //Question1.OptionA = "10";
            //Question1.OptionB = "7";
            //Question1.OptionC = "6 and half";
            //Question1.OptionD = "11";
            //Question1.Answer = "7";
            ////Console.WriteLine(Question1.Qestion);

            //QuizQuestion Question2 = new QuizQuestion();
            //Question2.Qestion = "How amny sec are there in 1 Min ??";
            //Question2.OptionA = "60";
            //Question2.OptionB = "7";
            //Question2.OptionC = "6";
            //Question2.OptionD = "All Of The Above";
            //Question2.Answer = "60";


            //QuizQuestion Question3 = new QuizQuestion("Whats the brain of the computer?", "Keyboard", "CPU", "Mouse", "Capble", "CPU");

            //Console.WriteLine(Question3.Qestion);
        }
    }
}
