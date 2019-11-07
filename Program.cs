using System;
using System.Collections.Generic;



namespace Lab8Validate

{

    class Program

    {

        static void Main(string[] args)

        {
            List<string> nameList = new List<string>();
            {
                nameList.Add("Mike");
                nameList.Add("Brittany");
                nameList.Add("Joe");

            };

            List<string> foodList = new List<string>();
            {
                foodList.Add("Pizza");
                foodList.Add("Pasta");
                foodList.Add("Tacos");
            };

            List<string> townList = new List<string>();
            {
                townList.Add("Toledo");
                townList.Add("Toledo");
                townList.Add("Temperance");
            };
            List<string> colorList = new List<string>();
            {
                colorList.Add("Blue");
                colorList.Add("Pink");
                colorList.Add("Green");
            }

            Console.WriteLine($"Welcome to our C# class.");
            Start1:
            Console.WriteLine("Which student would you like to learn more about?\n" +
            $"(enter a number 0 - 2):");

            string studentNumber = GetInput();
            numValidate(studentNumber);

            Console.WriteLine($"Student {studentNumber} is {nameList[int.Parse(studentNumber)]}. " +
            $"What would you like to know about {nameList[int.Parse(studentNumber)]}? (enter \"hometown\", \"favorite food\", or \"color\")");

            string color = "color";
            string homeTown = "hometown";
            string favoriteFood = "favorite food";
            string yes = "yes";
            string no = "no";
            string choice = Console.ReadLine();

            if (choice == homeTown)
            {
                Console.WriteLine($"{nameList[int.Parse(studentNumber)]} is from {townList[int.Parse(studentNumber)]}. " +
                $"Would you like to know more? (enter \"favorite food\", \"color\", or \"no\")");
                choice = Console.ReadLine();

                if (choice == favoriteFood)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite color is {colorList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }
                }
                if (choice == color)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite color is {colorList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }

                }
                if (choice == no) { Console.WriteLine("Thanks!"); return; }
                else if (choice != yes || choice != no)
                {
                    try
                    {
                        Console.WriteLine("Sorry, did you want to close the app? (\"yes\" to close, or \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect format. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Number was too large. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                }
            }

            if (choice == favoriteFood)
            {
                Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}." +
                $"Would you like to know more? (enter \"hometown\", \"color\", or \"no\")");
                choice = Console.ReadLine();

                if (choice == homeTown)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s hometown is {townList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite color is {colorList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }
                }
                if (choice == color)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite color is {colorList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }

                }
                if (choice == no) { Console.WriteLine("Thanks!"); return; }
                else if (choice != yes || choice != no)
                {
                    try
                    {
                        Console.WriteLine("Sorry, did you want to close the app? (\"yes\" to close, or \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect format. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Number was too large. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                }
            }
            if (choice == color)
            {
                Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite color is {colorList[int.Parse(studentNumber)]}. " +
                $"Would you like to know more? (enter \"favorite food\", \"hometown\", \"no\")");
                choice = Console.ReadLine();

                if (choice == homeTown)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s hometown is {townList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }
                }
                if (choice == favoriteFood)
                {
                Start2:
                    Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s favorite food is {foodList[int.Parse(studentNumber)]}. " +
                    $"Would you like to learn more? (enter \"yes\" or \"no\")");
                    choice = Console.ReadLine();

                    if (choice == yes)
                    {
                    Start3:
                        Console.WriteLine($"{nameList[int.Parse(studentNumber)]}'s hometown is {townList[int.Parse(studentNumber)]}. " +
                        $"Would you like to learn about another student? (enter \"yes\" or \"no\")");
                        choice = Console.ReadLine();

                        if (choice == yes) { goto Start1; }
                        if (choice == no) { Console.WriteLine("Thanks!"); return; }
                        else { goto Start3; }
                    }
                    if (choice == no) { Console.WriteLine("Thanks!"); return; }
                    else { goto Start2; }

                }
                if (choice == no) { Console.WriteLine("Thanks!"); return; }
                else if (choice != yes || choice != no)
                {
                    try
                    {
                        Console.WriteLine("Sorry, did you want to close the app? (\"yes\" to close, or \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect format. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Number was too large. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Did you want to close the app? (\"yes\" to close, \"no\" to restart.");
                        choice = Console.ReadLine();

                        if (choice == yes) { Console.WriteLine("Good bye!"); return; }
                        else if (choice == no) { goto Start1; }
                    }
                }
            }
            else { goto Start1; }
        
        }
            public static int numValidate(string input)
            {
            Start2:
                int validatedNumber = 0;
                
                try {validatedNumber = int.Parse(input);}

                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Must have some input.");
                    goto Start2;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Input was in incorrect format.");
                    goto Start2;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Input was out of reach of index.");
                    goto Start2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured.");
                    goto Start2;
                }
                return validatedNumber;
            }
            public static string GetInput() { return Console.ReadLine(); }
        
    }
}