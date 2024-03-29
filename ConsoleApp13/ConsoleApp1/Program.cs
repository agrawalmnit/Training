﻿namespace ConsoleApp1;
class Program {
    static void Main(string[] args) { 

    
    Array myArray = Array.CreateInstance(typeof(string), 12);
    myArray.SetValue("the", 0);
myArray.SetValue("quick", 1);
myArray.SetValue("brown", 2);
myArray.SetValue("fox", 3);
myArray.SetValue("jumps", 4);
myArray.SetValue("over", 5);
myArray.SetValue("the", 6);
myArray.SetValue("lazy", 7);
myArray.SetValue("dog", 8);
myArray.SetValue("in", 9);
myArray.SetValue("the", 10);
myArray.SetValue("barn", 11);


Console.WriteLine("The Array contains the following values:");
PrintIndexAndValues(myArray);

    
    string myString = "the";
    int myIndex = Array.LastIndexOf(myArray, myString);
    Console.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);


myIndex = Array.LastIndexOf(myArray, myString, 8);
Console.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);


myIndex = Array.LastIndexOf(myArray, myString, 10, 6);
Console.WriteLine("The last occurrence of \"{0}\" between index 5 and index 10 is at index {1}.", myString, myIndex);

void PrintIndexAndValues(Array anArray)
    {
        for (int i = anArray.GetLowerBound(0); i <= anArray.GetUpperBound(0); i++)
            Console.WriteLine("\t[{0}]:\t{1}", i, anArray.GetValue(i));
            Console.WriteLine(anArray.GetUpperBound(0));
    }

}
}