using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Computershare_Code_Test
{
    class ProgramMain
    {
        static void Main(string[] args)
        {            
            
            Person user;
            InputChecker iChecker = new InputChecker();
            string pickedNumAsString;
            int pickedNumAsInt;

            /*
                        Console.WriteLine("\nPress Escape on your keyboard to exit at any point");

                        do
                        {
                            while (!Console.KeyAvailable)            
                            {

                            }
                        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            */

            Console.WriteLine("\n WELCOME TO...");
            Console.WriteLine("\n     #     #    #     #####  #     # " +
                "\n     ##   ##   # #   #     # #     # " +
                "\n     # # # #  #   #  #       #     # " +
                "\n     #  #  # #     #  #####  ####### " +
                "\n     #     # #######       # #     # " +
                "\n     #     # #     # #     # #     # " +
                "\n     #     # #     #  #####  #     #  ");
            Console.WriteLine("\n A timeless school game classic, MASH stands for Mansion, Apartment, Shack, House.\n Choose a number, type in a list of answers to each question\n And watch as your future is predicted...");



            //Name
            Console.WriteLine("\nWhat's your name?\n");
            string nameInput = Console.ReadLine();
            iChecker.CheckStringNotNullOrEmpty(nameInput);

            //Age
            Console.WriteLine("\n\nHi " + iChecker.stringInput + ", nice to meet you \nHow old are you?\n");
            string ageInputAsString = Console.ReadLine();
            iChecker.CheckIntExists(ageInputAsString, false);
            int ageInputAsInt = Convert.ToInt32(iChecker.num);
           // PersonQuestion personQ = new PersonQuestion(nameInput, ageInputAsInt);

            //Pick a Number
            Console.WriteLine("\nCool. You're " + ageInputAsInt + ". Looking good. Now pick a magic number between 1 and 10");
            pickedNumAsString = Console.ReadLine();
            
            iChecker.CheckIntExists(pickedNumAsString, true);

            pickedNumAsInt = Convert.ToInt32(iChecker.numInRange);
           
            user = new Person(ageInputAsInt, nameInput, pickedNumAsInt);

            //Abode
            List<string> abodeList = new List<string>();

            abodeList.Add("Mansion");
            abodeList.Add("Apartment");
            abodeList.Add("Shack");
            abodeList.Add("House");

            GameQuestion AbodeQuestion = new GameQuestion(abodeList, false, pickedNumAsInt, null);
            AbodeQuestion.TakeListOfInputsOutputOne(abodeList);
            iChecker.CheckStringInListAreLegal(abodeList);
          
            AbodeQuestion.Answered = true;

            //Location
            Console.WriteLine("\nYour chosen magic number is " + pickedNumAsInt + ".\n\n Type in locations separated with a comma");
            string locationInput = Console.ReadLine();
            iChecker.SplitInputIntoStrings(locationInput);

            GameQuestion locationQuestion = new GameQuestion(iChecker.UserInputList, false, pickedNumAsInt, null);

            Console.WriteLine("\nThey sound like good places to visit! Maybe one day I'll go to " + locationInput + " and have some fun. ");
            locationQuestion.TakeListOfInputsOutputOne(iChecker.UserInputList);
            iChecker.CheckStringInListAreLegal(iChecker.UserInputList);
           // Console.WriteLine("THE LIST: ");
           // iChecker.UserInputList.ForEach(i => Console.Write("{0}\n", i));

            locationQuestion.Answered = true;

            //Vehicle
            Console.WriteLine("\n\nType in VEHICLES separated with a comma");
            string vehicleInput = Console.ReadLine();
            iChecker.SplitInputIntoStrings(vehicleInput);

            GameQuestion vehicleQuestion = new GameQuestion(iChecker.UserInputList, false, pickedNumAsInt, null);

            Console.WriteLine("\nSome rad rides you've listed there.");
            vehicleQuestion.TakeListOfInputsOutputOne(iChecker.UserInputList);
            iChecker.CheckStringInListAreLegal(iChecker.UserInputList);
            //Console.WriteLine("THE VEHICLE LIST: ");
            //iChecker.UserInputList.ForEach(i => Console.Write("{0}\n", i));

            vehicleQuestion.Answered = true;


            //Food
            Console.WriteLine("\n\nType in food separated with a comma");
            string foodInput = Console.ReadLine();
            iChecker.SplitInputIntoStrings(foodInput);

            GameQuestion foodQuestion = new GameQuestion(iChecker.UserInputList, false, pickedNumAsInt, null);

            Console.WriteLine("\nyum yum yum");
            foodQuestion.TakeListOfInputsOutputOne(iChecker.UserInputList);
            iChecker.CheckStringInListAreLegal(iChecker.UserInputList);
            //Console.WriteLine("THE FOOD LIST: ");
            //iChecker.UserInputList.ForEach(i => Console.Write("{0}\n", i));

            foodQuestion.Answered = true;

            //Are all the questions answered?
            if(locationQuestion.Answered && vehicleQuestion.Answered && foodQuestion.Answered == true)
            {
                Console.WriteLine("\n\nYou will retire in " + locationQuestion.FinalAnswer + " and live in a " + AbodeQuestion.FinalAnswer +  ". Your personal mode of transport will be a " + vehicleQuestion.FinalAnswer + ", and when you turn " + (user.Age + 1) + " you'll have a birthday meal of " + foodQuestion.FinalAnswer);
            }

            
        }

        public void GamePlay()
        {

        }

    }
}
