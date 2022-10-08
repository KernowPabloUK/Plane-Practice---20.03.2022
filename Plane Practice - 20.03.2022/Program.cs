using System;
using System.Collections.Generic;

namespace Plane_Practice___20._03._2022
{
    internal class Program
    {
        // Note: for all these exercises, ignore input validation unless otherwise directed.
        // Assume the user enters a value in the format that the program expects.
        // For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not.
        // When testing your program, simply enter a number.

        #region Control Flow Exercises - Part 1
        // 1- Write a program and ask the user to enter a number.The number should be between 1 to 10.
        // If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
        // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

        // 2- Write a program which takes two numbers from the console and displays the maximum of the two.

        // 3- Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

        // 4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        // If the user enters a value less than the speed limit, program should display Ok on the console.
        // If the value is above the speed limit, the program should calculate the number of demerit points.
        // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        // If the number of demerit points is above 12, the program should display License Suspended.
        #endregion

        #region Control Flow Exercises (Iteration) - Part 2
        //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        //Display the count on the console.

        //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.

        //3- Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        //4- Write a program that picks a random number between 1 and 10.
        //Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost".
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

        //5- Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console.
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        #endregion

        // Note: For any of these exercises, ignore input validation unless otherwise directed. Assume the user enters values in the format that the program expects.

        #region Arrays and Lists Exercises
        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern.

        //2- Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.

        //3- Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates.
        //Display the unique numbers that the user has entered.

        //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.
        #endregion

        static void Main(string[] args)
        {
            #region CF Pt1: 1

            Console.WriteLine("Please enter a number between 1 & 10");
            int userEntryCF1EX1 = Convert.ToInt32(Console.ReadLine());
            if (userEntryCF1EX1 >= 1 && userEntryCF1EX1 <= 10)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

            #endregion

            #region CF Pt1: 2

            Console.WriteLine("Please enter a number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a different number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The maximum number is {firstNumber}");
            }
            else
            {
                Console.WriteLine($"The maximum number is {secondNumber}");
            }

            #endregion

            #region CF Pt1: 3

            Console.WriteLine("Please enter the width of the image.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the image.");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("The image is Landscape");
            }
            else
            {
                Console.WriteLine("The image is Portrait");
            }

            #endregion

            #region CF Pt1: 4

            Console.WriteLine("Please enter/set the speed limit for the camera:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car/vehicle:");
            int vehicleSpeed = Convert.ToInt32(Console.ReadLine());
            int speedVariance = vehicleSpeed - speedLimit;
            if (vehicleSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demeritPoints = speedVariance / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine($"The total demerit points are {demeritPoints}");
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"The total demerit points are {demeritPoints}");
                }
            }

            #endregion

            #region CF Pt2: 1

            int countOfNumbersDivisibleByThree = 0;
            for (int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0)
                {
                    countOfNumbersDivisibleByThree++;
                }

            }
            Console.WriteLine($"The sum of all numbers between 1 & 100 divisible by 3 with no remainder = {countOfNumbersDivisibleByThree}");

            #endregion

            #region CF Pt2: 2

            int sumOfNumbers = 0;
            bool boolStayInLoop = true;

            while (boolStayInLoop)
            {
                Console.WriteLine("Please enter a number or type \"ok\" to exit");
                string userEntryCF2EX2 = Console.ReadLine();

                if (userEntryCF2EX2.ToLower() == "ok")
                {
                    boolStayInLoop = false;
                }
                else
                {
                    int numberCF2EX2 = Convert.ToInt32(userEntryCF2EX2);
                    sumOfNumbers += numberCF2EX2;

                }

            }
            Console.WriteLine($"The sum of all numbers entered = {sumOfNumbers}");

            #endregion

            #region CF Pt2: 3

            Console.WriteLine("Please enter a number.");
            int numberCF2EX3 = Convert.ToInt32(Console.ReadLine());
            int factorialResult = 1;
            for (int index = numberCF2EX3; index > 0; index--)
            {
                factorialResult *= index;
            }
            Console.WriteLine($"The Factorial of {numberCF2EX3} is {factorialResult}");

            #endregion

            #region CF Pt2: 4

            Random randomNumber = new Random();
            int secretRandomNumber = randomNumber.Next(1, 10);
            Console.WriteLine(secretRandomNumber);
            int maximumGuesses = 4;
            int attempts = 0;
            Console.WriteLine("Please guess the secret (random) number:");
            int numberCF2EX4 = Convert.ToInt32(Console.ReadLine());

            while (numberCF2EX4 != secretRandomNumber && attempts <= maximumGuesses)
            {
                attempts++;
                maximumGuesses--;
                Console.WriteLine($"You have {maximumGuesses} attempts remaining, Try again...");
                int newGuess = Convert.ToInt32(Console.ReadLine());
                numberCF2EX4 = newGuess;
            }
            if (numberCF2EX4 == secretRandomNumber)
            {
                Console.WriteLine("YOU WON");
            }
            else
            {
                Console.WriteLine("YOU LOST :(");
            }

            #endregion

            #region CF Pt2: 5

            Console.WriteLine("Please enter a series of numbers seperated by comma.");
            string userEntryCF2EX5 = Console.ReadLine();
            string[] splitUserEntry = userEntryCF2EX5.Split(',');
            int[] intArray = new int[userEntryCF2EX5.Length];
            int currentPositionOfIntArray = 0;
            int maximumValue = 0;
            foreach (string item in splitUserEntry)
            {
                int numberCF2EX5 = Convert.ToInt32(item);
                intArray[currentPositionOfIntArray] += numberCF2EX5;
                currentPositionOfIntArray++;
                if (numberCF2EX5 > maximumValue)
                {
                    maximumValue = numberCF2EX5;
                }
            }
            Console.WriteLine($"The maxium value is {maximumValue}");

            #endregion

            #region A&L: 1

            List<string> listOfNames = new List<string>();
            bool boolStayInWhileLoop = true;

            while (boolStayInWhileLoop)
            {
                Console.WriteLine("Please enter a name of someone who 'likes your post', when finished please just press 'enter'.");
                string userEntryAL1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userEntryAL1))
                {
                    break;
                }
                else
                {
                    listOfNames.Add(userEntryAL1);
                }
            }
            if (listOfNames.Count == 0)
            {
                Console.WriteLine("You have no friends");
            }
            else if (listOfNames.Count == 1)
            {
                Console.WriteLine($"{listOfNames[0]} likes your post");
            }
            else if (listOfNames.Count == 2)
            {
                Console.WriteLine($"{listOfNames[0]} & {listOfNames[1]} like your post");
            }
            else if (listOfNames.Count > 2)
            {
                Console.WriteLine($"{listOfNames[0]}, {listOfNames[1]} and {listOfNames.Count - 2} others like your post");
            }

            #endregion

            #region A&L: 2

            Console.WriteLine("Please enter your name...");
            string nameEntry = Console.ReadLine();
            char[] nameArray = nameEntry.ToCharArray();
            Array.Reverse(nameArray);
            string result = new string(nameArray);
            Console.WriteLine($"Your name in reverse is \"{result}\"");

            #endregion

            #region A&L: 3

            List<int> listOfNumbersAL3 = new List<int>();
            while (listOfNumbersAL3.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                int userNumberEntryAL3 = Convert.ToInt32(Console.ReadLine());
                if (listOfNumbersAL3.Contains(userNumberEntryAL3))
                {
                    Console.WriteLine("Please enter a unique number");
                }
                else
                {
                    listOfNumbersAL3.Add(userNumberEntryAL3);
                }
            }
            listOfNumbersAL3.Sort();
            foreach (int item in listOfNumbersAL3)
            {
                Console.WriteLine($"{item}");
            }

            #endregion

            #region A&L: 4

            List<int> listOfInt = new List<int>();
            bool stayInLoop = true;
            string quitCommand = "QUIT";
            while (stayInLoop)
            {
                Console.WriteLine("Please enter a number or type \"QUIT\" to exit");
                string userString = Console.ReadLine();
                userString = userString.ToUpper();
                if (userString == quitCommand)
                {
                    break;
                }
                else
                {
                    int numberAL4 = Convert.ToInt32(userString);
                    listOfInt.Add(numberAL4);
                }
            }
            Console.WriteLine("The unique values are:");
            foreach (int numberAL4 in listOfInt)
            {
                if (listOfInt.IndexOf(numberAL4) == listOfInt.LastIndexOf(numberAL4))
                {
                    Console.Write($"{numberAL4} ");
                }
            }

            #endregion

            #region A&L: 5

            Console.WriteLine("Please enter a list of numbers seperated by comma...");
            List<int> intList = new List<int>();
            string userEntryAL5 = Console.ReadLine();
            string[] SplitUserEntryAL5 = userEntryAL5.Split(',');
            foreach (string item in SplitUserEntryAL5)
            {
                int numberAL5 = Convert.ToInt32(item);
                intList.Add(numberAL5);
            }
            if (intList.Count < 5)
            {
                Console.WriteLine("INVALID LIST, Please try again & enter a list of numbers seperated by comma...");
                intList.Clear();
            }
            else
            {
                intList.Sort();
                Console.WriteLine("The 3 lowest values entered are:");
                for (int indexOfList = 0; indexOfList <= 2; indexOfList++)
                {
                    Console.WriteLine($"{intList[indexOfList]}");
                }
            }

            #endregion





        }



    }
}
