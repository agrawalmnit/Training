﻿//using System;

//namespace ConsoleApp41
//{

//    public class Program3
//    {
//        public static void Main(string[] args)
//        {


//            Console.WriteLine("Welcome to Bethany's Pie Shop HRM");


//            int age3 = 23;

//            bool a = age3 == 23;
//            Console.WriteLine("Age is 23: " + a);

//            bool b = age3 > 23;
//            Console.WriteLine("Age is greater than 23: " + b);

//            bool c = (age3 >= 18) && (age3 <= 65);
//            Console.WriteLine("Age is between 18 and 65: " + c);


//            int age1 = 16;
//            int age2 = 64;
//            bool d = (age1 >= 18) && (age2 <= 65);
//            Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
//            bool e = (age1 >= 18) || (age2 <= 65);
//            Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);


//            Console.WriteLine("Enter the age of the new candidate: ");
//            int age = int.Parse(Console.ReadLine());

//            if (age < 18)
//                Console.WriteLine("Too young to apply");
//            else
//                Console.WriteLine("Great, you can now start with the application!");


            

//            if (age < 18)
//            {
//                Console.WriteLine("Too young to apply");
//                Console.WriteLine("Send email to candidate.");
//            }
//            else
//            {
//                Console.WriteLine("Great, you can now start with the application!");
//            }


//            if (age < 18)
//            {
//                Console.WriteLine("Too young to apply");
//                Console.WriteLine("Send email to candidate.");
//            }
//            else if (age > 65)
//            {
//                Console.WriteLine("Sorry, the selected age is too old");
//                Console.WriteLine("Send email to candidate.");
//            }
//            else
//            {
//                Console.WriteLine("Great, you can continue!");
//            }

//            DateTime today = DateTime.Now;
//            bool endOfMonthPaymentStarted = false;

//            if (today.Date.Day == 20)
//            {
//                Console.WriteLine("Please start end-of-month employee payments");
//            }
//            else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
//            {
//                Console.WriteLine("Payments will be late!");
//            }
//            //else isn't required!



//            switch (age)
//            {
//                case < 18:
//                    Console.WriteLine("Too young to apply");
//                    break;
//                case > 65:
//                    Console.WriteLine("Sorry, the selected age is too old");
//                    break;
//                case 23:
//                    Console.WriteLine("Wow, exactly what we are looking for");
//                    break;
//                default:
//                    Console.WriteLine("Great, you can continue!");
//                    break;
//            }

//            switch (age)
//            {
//                case < 18:
//                case > 65:
//                    Console.WriteLine("Sorry, your age is not within the range we are looking for");
//                    break;
//                case 23:
//                    Console.WriteLine("Wow, exactly what we are looking for");
//                    break;
//                default:
//                    Console.WriteLine("Great, you can continue!");
//                    break;
//            }

//            Console.WriteLine("Choose the action you want to do: ");
//            Console.WriteLine("1. Add employee");
//            Console.WriteLine("2. Update employee");
//            Console.WriteLine("3. Delete employee");
//            string selectedAction = Console.ReadLine();

//            switch (selectedAction)
//            {
//                case "1":
//                    Console.WriteLine("Adding new employee...");
//                    break;
//                case "2":
//                    Console.WriteLine("Updating employee...");
//                    break;
//                case "3":
//                    Console.WriteLine("Deleting employee...");
//                    break;
//                default:
//                    Console.WriteLine("Invalid input");
//                    break;
//            }



//            Console.WriteLine("Enter a value: ");
//            int max = int.Parse(Console.ReadLine());
//            int i = 0;

//            while (i < max)
//            {
//                Console.WriteLine(i);
//                i++;
//            }


//            Console.WriteLine("Choose the action you want to do: ");
//            Console.WriteLine("1. Add employee");
//            Console.WriteLine("2. Update employee");
//            Console.WriteLine("3. Delete employee");
//            Console.WriteLine("99. Exit application");
//            string selectedAction2 = Console.ReadLine();

//            while (selectedAction2 != "99")
//            {
//                switch (selectedAction2)
//                {
//                    case "1":
//                        Console.WriteLine("Adding new employee...");
//                        break;
//                    case "2":
//                        Console.WriteLine("Updating employee...");
//                        break;
//                    case "3":
//                        Console.WriteLine("Deleting employee...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid input");
//                        break;
//                }
//                Console.WriteLine("Choose the action you want to do: ");
//                Console.WriteLine("1. Add employee");
//                Console.WriteLine("2. Update employee");
//                Console.WriteLine("3. Delete employee");
//                Console.WriteLine("99. Exit application");
//                selectedAction2 = Console.ReadLine();
//            }

//            Console.WriteLine("Closing application");


//            int i5 = 0;
//            int j = 0;

//            while (i5 < 10)
//            {
//                while (j < 10)
//                {
//                    Console.WriteLine("i5: " + i5 + "   j: " + j);
//                    j++;
//                }
//                j = 0;
//                i5++;
//            }


//            while (true)
//            {
//                Console.WriteLine(DateTime.Now);
//            }



//            string selectedAction3 = "";

//            do
//            {
//                Console.WriteLine("Choose the action you want to do: ");
//                Console.WriteLine("1. Add employee");
//                Console.WriteLine("2. Update employee");
//                Console.WriteLine("3. Delete employee");
//                Console.WriteLine("99. Exit application");
//                selectedAction3 = Console.ReadLine();

//                switch (selectedAction3)
//                {
//                    case "1":
//                        Console.WriteLine("Adding new employee...");
//                        break;
//                    case "2":
//                        Console.WriteLine("Updating employee...");
//                        break;
//                    case "3":
//                        Console.WriteLine("Deleting employee...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid input");
//                        break;
//                }

//            } while (selectedAction3 != "99");

//            Console.WriteLine("Closing application");

//            for (int i2 = 0; i2 < 10; i2++)
//            {
//                Console.WriteLine(i2);
//            }


//            for (int i3 = 0, j2 = 10; i3 < 10 && j2 > 0; i3++, j2--)
//            {
//                Console.WriteLine("i3: " + i3 + "   j2: " + j2);
//            }

//            Console.WriteLine("Enter a value: ");
//            int max2 = int.Parse(Console.ReadLine());


//            for (int i4 = 0; i4 < max2; i4++)
//            {
//                if (i4 == 15)
//                {
//                    Console.WriteLine("Bingo! " + i4 + " was found!");
//                    continue;
//                    //break;
//                }
//                Console.WriteLine(i4);
//            }


//            Console.ReadLine();
//        } 
//    } 
//}