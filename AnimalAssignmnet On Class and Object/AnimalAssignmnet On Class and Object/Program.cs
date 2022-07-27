//// See https://aka.ms/new-console-template for more information
namespace AnimalAssignment_On_Class_and_Object
{
   class progarm
   {
        static void Main(string[] agrs)
        {
            List<Annimals> Annimal = new List<Annimals>()
            {
                new Annimals("Goat", "mammal", true, "locker", true, 2, 0, 2),
                new Annimals("Fish", "Ray-finned", true, "water aquarium", false, 0, 0, 2),
                new Annimals("Dog", "mammal", true, "kennel", false, 2, 4, 2),
                new Annimals("Monkey", "mammal", true, "Tree", false, 2, 2, 2),
                new Annimals("Pig", "mammal", true, "mew", false, 2, 2, 2)
            };

            for (int i = 0; i < Annimal.Count; i++)
            {
                Console.WriteLine(Annimal[i].name);
            }


            //Annimals Animal1 = new Annimals();
            //Animal1.name = "Goat";
            //Animal1.Class = "mammal";
            //Animal1.Movemnt = true;
            //Animal1.Habitat = "locker";
            //Animal1.Horn = true;
            //Animal1.hand = 2;
            //Animal1.Legs = 0;
            //Animal1.Eye = 2;


            //Annimals Animal2 = new Annimals();
            //Animal2.name = "Fish";
            //Animal2.Class = "Ray-finned";
            //Animal2.Movemnt = true;
            //Animal2.Habitat = "water aquarium";
            //Animal2.Horn = false;
            //Animal2.hand = 0;
            //Animal2.Legs = 0;
            //Animal2.Eye = 2;


            //Annimals Animal3 = new Annimals();
            //Animal3.name = "Dog";
            //Animal3.Class = "Mammal";
            //Animal3.Movemnt = true;
            //Animal3.Habitat = "kennel";
            //Animal3.Horn = false;
            //Animal3.hand = 2;
            //Animal3.Legs = 4;
            //Animal3.Eye = 2;



            //Annimals Animal4 = new Annimals();
            //Animal4.name = "Monkey";
            //Animal4.Class = "mammal";
            //Animal4.Movemnt = true;
            //Animal4.Habitat = "Tree";
            //Animal4.Horn = false;
            //Animal4.hand = 2;
            //Animal4.Legs = 2;
            //Animal4.Eye = 2;


            //Annimals Animal5 = new Annimals();
            //Animal5.name = "Pig";
            //Animal5.Class = "mammal";
            //Animal5.Movemnt = true;
            //Animal5.Habitat = "mew";
            //Animal5.Horn = false;
            //Animal5.hand = 2;
            //Animal5.Legs = 2;
            //Animal5.Eye = 2;


            //Annimals Animal6 = new Annimals("Duck", true, "Pound", true, "Avies", 0, 2, 2);
            //Console.WriteLine(Animal6.name);
        }

    }



}


