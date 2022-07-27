// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// List<string>quiz = new List<string>();

//Console.WriteLine("ENTER REISTRATION NUMBER");
//quiz.Add("2022AB");
//quiz.Add("2022ABC");
//quiz.Add("2022ABCD");
//quiz.Add("2022ABCDE");
//quiz.Add("2022ABCDEF");


//static void Ques(string questions, string option1, string option2, string option3, string option4)
//{
//    Console.WriteLine(questions);
//    Console.WriteLine("A"+ option1);
//    Console.WriteLine("B" + option2);
//    Console.WriteLine("C" + option3);
//    Console.WriteLine("D" + option4);

//}

//string reg = Console.ReadLine();
//if (reg.Contains(reg))
//{
//    Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");
//    if (quiz.Contains(reg))
//    {
//        Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");
//        Ques("(Q4)	Who is the father of Computer science", "Pat3ick Eche", "Charles Babbag", "Eche Patrick", "Samuel Imanche");
//    }
//}



            Console.WriteLine("QUIZZ APP");
            Console.WriteLine("ENTER ANY KEY TO CONTINUE");
            Console.ReadLine();



            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("1234", "1234");
            dict.Add("3322", "3322");
            dict.Add("5454", "5454");
            dict.Add("6544", "6544");
            dict.Add("7876", "7876");
            dict.Add("8855", "8855");

            while (true)
            {
                Console.WriteLine("ENTER YOUR REGISTRATION NUMBER");



                for (int i = 0; i < dict.Count; i++)
                {


                    string regnum = Console.ReadLine();


                    if (dict.ContainsKey(regnum))
                    {
                        Console.WriteLine("INITIALISATION SUCCESSFUL");
                        Console.Clear();




                        List<int> total = new List<int>();
                        Console.WriteLine(" QUESTION 1: HOW MANY DAYS ARE THEY IN A WEEK?");
                        List<string> ques = new List<string>();

                        ques.Add("[A]. 8");
                        ques.Add("[B]. 4");
                        ques.Add("[C]. 6");
                        ques.Add("[D]. 7");

                        foreach (var test in ques)
                        {
                            Console.WriteLine(test);
                        }

                        string ques1 = Console.ReadLine();

                        if (ques1 == "A")
                        {
                            total.Add(20);
                            Console.WriteLine("CORRECT");
                        }
                        else if (ques1 == "B" || ques1 == "C" || ques1 == "D")
                        {
                            Console.WriteLine("FAILED");
                        }
                        else if (ques1 != "A" || ques1 != "B" || ques1 != "C" || ques1 != "D")
                        {
                            Console.WriteLine("KINDLY ENTER A CORRECT CODE");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("SKIPPED");
                        }


                        Console.Clear();

             /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        Console.WriteLine(" QUESTION 2: At what age are you expected to have account with the Bank ??____");
                        List<string> ques2 = new List<string>();

                        ques2.Add("[A]. 17");
                        ques2.Add("[B]. 18");
                        ques2.Add("[C]. 10");
                        ques2.Add("[D]. None of the above.");
                        //ques2.Add("SELECT ANY OTHER OPTION YOU HAVE SKIPPED THIS");

                        foreach (var test in ques2)
                        {
                            Console.WriteLine(test);
                        }

                        string que = Console.ReadLine();
                        if (que == "A")
                        {
                            total.Add(20);
                            Console.WriteLine("CORRECT");
                        }
                        else if (que == "B" || que == "C" || que == "D")
                        {
                            Console.WriteLine("FAILED");
                        }
                        else if (que != "A" || que != "B" || que != "C" || que != "D")
                        {
                            Console.WriteLine("KINDLY ENTER A CORRECT CODE");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("SKIPPED");
                            Console.ReadLine();
                        }
                        Console.Clear();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        Console.WriteLine(" QUESTION 3:  How many planets do we have ??____");
                        List<string> ques3 = new List<string>();

                        ques3.Add("[A]. 10");
                        ques3.Add("[B]. 8");
                        ques3.Add("[C]. 9");
                        ques3.Add("[D]. All Of THe Above.");
                        ques3.Add("SELECT ANY OTHER OPTION YOU HAVE SKIPPED THIS ");

                        foreach (var test in ques3)
                        {
                            Console.WriteLine(test);
                        }
                        string quess = Console.ReadLine();
                        if (quess == "B")
                        {
                            total.Add(20);
                            Console.WriteLine("CORRECT");
                        }
                        else if (quess == "A" || quess == "C" || quess == "D")
                        {
                            Console.WriteLine("FAILED");
                        }
                        else if (quess != "A" || quess != "B" || quess != "C" || quess != "D")
                        {
                            Console.WriteLine("KINDLY ENTER A CORRECT CODE");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("SKIPPED");
                        }
                        Console.Clear();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine(" QUESTION 4: Who is the Father of Electricity?");
            List<string> ques4 = new List<string>();
            ques4.Add("[A]. John Dalton");
            ques4.Add("[B]. Isaac Newton");
            ques4.Add("[C]. JIm Rues");
            ques4.Add("[D]. Mendel");
            ques4.Add("SELECT ANY OTHER OPTION YOU HAVE SKIPPED THIS ");

                    foreach (var test in ques4)
                    {
                        Console.WriteLine(test);
                    }
                    string quess1 = Console.ReadLine();
                    if (quess1 == "B")
                    {
                        total.Add(20);
                        Console.WriteLine("CORRECT");
                    }
                    else if (quess1 == "A" || quess1 == "C" || quess1 == "D")
                    {
                        Console.WriteLine("FAILED");
                    }
                    else if (quess1 != "A" || quess1 != "B" || quess1 != "C" || quess1 != "D")
                    {
                        Console.WriteLine("KINDLY ENTER A CORRECT CODE");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("SKIPPED");
                    }
                    Console.Clear();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine(" QUESTION 5: The Bone ia a? ");
            List<string> ques5 = new List<string>();
            ques5.Add("[A]. Cell");
            ques5.Add("[B]. Ligament");
            ques5.Add("[C]. Tissue");
            ques5.Add("[D]. Muscle");
            ques5.Add("SELECT ANY OTHER OPTION YOU HAVE SKIPPED THIS");

            foreach (var test in ques5)
            {
                Console.WriteLine(test);
            }
            string quess2 = Console.ReadLine();
            if (quess2 == "C")
            {
                total.Add(20);
                Console.WriteLine("CORRECT");
            }
            else if (quess2 == "A" || quess2 == "B" || quess2 == "D")
            {
                Console.WriteLine("FAILED");
            }
            else if (quess2 != "A" || quess2 != "B" || quess2 != "C" || quess2 != "D")
            {
                Console.WriteLine("KINDLY ENTER A CORRECT CODE");
                break;
            }
            else
            {
                Console.WriteLine("SKIPPED");
                Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("PRESS THE ENTER BUTTON TO SUBMIT");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("SUBMITED SUCWSSFULLY  ");
            Console.WriteLine("PRESS ENTER TO SEE YOUR RESULTS");
            Console.ReadLine();
            Console.Clear();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine($"You scored {total.Sum()} points");
            if (total.Sum() == 100)
            {
                Console.WriteLine("PERFECT! WAIT FOR YOUR ADDMISSION LETTER!");
            }


            else if (total.Sum() == 90 || total.Sum() == 80 || total.Sum() == 70 || total.Sum() == 60)
                    {
                Console.WriteLine("PASSED.. YOU MIGHT BE CONSIDERED!");
                    }


                else
                    {
                Console.WriteLine("POOR PERFOMANCE");
                break;
                    }


                    }
                    else
                    {
                Console.WriteLine("AUTHORISATION FAILED ");
                Console.Write($"u have {i} trial");
                    }

                    }
                Console.Clear();
            Console.WriteLine("SORRY YOUR ACCOUNT HAVE BEEN DISABLED");
            Console.WriteLine("try again in 30 minutes");
            break;
            }