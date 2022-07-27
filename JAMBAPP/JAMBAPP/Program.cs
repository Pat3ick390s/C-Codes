// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("CBT APP");
int total = 0;

Dictionary<string, int> login = new Dictionary<string, int>();
login.Add("123", 123);
login.Add("456", 456);
login.Add("789", 789);
login.Add("147", 147);
login.Add("258", 258);

int attemptleft = 5;

while (true)
{
    Console.WriteLine("PLEASE ENTER YOUR REGISTRATION NUMBER");

    for (int i = 1; i <= 5; i++)
    {
        string reg = Console.ReadLine();
        if (login.ContainsKey(reg))
        {
            Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");


            QUESTION(" QUESTION 1: how many days do we have in a week", "[A].  3", "[B].  4", "[C].  6", "[D].  7");
            string op1 = Console.ReadLine();
            if (op1 == "D")
            {
                Console.WriteLine("CORRECT AMSWER");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
            QUESTION(" QUESTION 2: what programming language are you learning now?", "[A].  java", "[B]. javascript", "[C].  c#", "[D].  c++");
            string op2 = Console.ReadLine();
            if (op2 == "C")
            {
                Console.WriteLine("CORRECT AMSWER");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 3: who is the president of the united states?", "[A].  joe biden", "[B].  buhari", "[C].  osibanjo", "[D].  david");
            string op3 = Console.ReadLine();
            if (op3 == "A")
            {
                Console.WriteLine("CORRECT AMSWER");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 4: which is the brain of the computer?", "[A]. monitor", "[B].  cpu", "[C].  mouse", "[D].  keyboard");
            string op4 = Console.ReadLine();
            if (op4 == "A")
            {
                Console.WriteLine("CORRECT AMSWER");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            QUESTION(" QUESTION 5: which part of the computer is used to display information?", "[A].  mouse", "[B].  cpu", "[C].   monitor", "[D].  keyboard");
            string op5 = Console.ReadLine();
            if (op5 == "C")
            {
                Console.WriteLine("CORRECT AMSWER");
                total++;
                Console.WriteLine("You score 2 point");
            }
            else
            {
                Console.WriteLine("FAILED");
            }

            Console.WriteLine($"Your Total Score Is {total++ * 2}");
            break;
        }

        else
        {
            Console.WriteLine($"INVALID LOGIN DETAILS");
            Console.WriteLine($"You Have {attemptleft = attemptleft - 1} Attempt Left");

        }
        if (!login.ContainsKey(reg) && i >= 5)
        {
            Console.WriteLine("ACCOUNT TEMPORARILY SUSPENDED");
        }
    }

    break;
}

static void QUESTION(string question, string option1, string option2, string option3, string option4)
{
    Console.WriteLine($"{question},{option1},{option2},{option3},{option4}");

}