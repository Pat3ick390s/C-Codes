// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<int, string> numberNames = new Dictionary<int, string>();

numberNames.Add(1, "Coding");
numberNames.Add(2, "Eating");
numberNames.Add(3, "Playing Vidoe Game");
numberNames.Add(4, "Playing Music");

//foreach (var Hubbies in numberNames)
//{
//    Console.WriteLine("Key " + Hubbies.Key + "Value" + Hubbies.Value);
//}

for ( int i = 1; i <= numberNames.Count; i++)
{
    Console.WriteLine(numberNames[i]);
    //Console.WriteLine(i);
}  