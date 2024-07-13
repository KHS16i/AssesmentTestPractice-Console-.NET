using ConsoleProyect.Tests;

#region INSTANCIAS

Test_HDeLeon obj1 = new Test_HDeLeon();
TestCarlosAsaustre obj2 = new TestCarlosAsaustre();

#endregion

Console.WriteLine(obj1.txtReverted("Kevin"));

Console.WriteLine(obj1.charCount("Priscilla", 'l'));

Console.WriteLine(obj1.hammingDistance("Kevin", "Kifon"));

Console.WriteLine(obj1.wordsCounter("Hola como    estan todos? Me alegra que estén acá.    "));

Console.WriteLine(obj1.lettersCount("ddf25asd158f67ojhhj987"));

int[] array = { 1, 1, 2, 3, 3, 4, 5, 1 };
List<string> rst = (obj1.repeatCount(array));

foreach (var item in rst)
{
    Console.WriteLine(item);
}

//-------------------------------------------------------------------------------------------------//

Console.WriteLine(obj2.helloWorld("Kevin"));

List<string> cities = new List<string> { "San Jose", "Guana", "Heredia", "Guana", "Heredia", "Guana" };

foreach (string c in obj2.sortCities(cities))
{
    Console.WriteLine(c);
}