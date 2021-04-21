using System;
using System.Collections.Generic;

namespace JurasicPark
{
    //       create a class dino
    class Dino
    {
        // Name string {get; set;}
        public string Name { get; set; }
        // DietType string get; set;
        public string DietType { get; set; }
        // WhenAcquired string {get; set;}
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        // Weight int {get; set;}
        public int Weight { get; set; }
        // EnclosureNumber int {get; set;}
        public int EnclosureNumber { get; set; }

        // Create dinoDescription to hold all the properties of a dino from user input
        public string DinoDescription { get; set; }

    }
    class Program
    {
        static void DisplayWelcome()
        {
            // greeting to show that the program is currenting running
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--- Welcome to Jurassic Park ---");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }
        // method to prompt for string response
        static string PromptForString(string prompt)
        {
            // - write line
            Console.WriteLine(prompt);
            // - read line and set it as the userInout
            var userInput = Console.ReadLine();
            // - return response
            return userInput;
        }
        // method to prompt for int response
        static int PromptForInterger(string prompt)
        {
            // - read line
            Console.WriteLine(prompt);

            int userInput;
            // - read line and set it as the userIpout
            var validUserInput = Int32.TryParse(Console.ReadLine(), out userInput);
            // - return response
            return userInput;
        }
        static void Main(string[] args)
        {
            // display welcome
            DisplayWelcome();

            // create new dinos list hold the values of a dino
            var dinoList = new List<Dino>();
            var dino = new Dino();

            // - add the collections of values to the list
            dinoList.Add(dino);



            // create prompt for getting the dino Name 
            dino.Name = PromptForString("What is the Dinosaurs name?");
            // create prompt for getting the dino DietType
            dino.DietType = PromptForString("Is it a [Carnivore] or a [Herbivore]");
            // create prompt that logs the current date and time
            dino.WhenAcquired = DateTime.Now;
            // create prompt for getting the dino Weight
            dino.Weight = PromptForInterger("How much does the dinosaur weight in lbs? ");
            // create prompt for getting the dino EnclosureNumber
            dino.EnclosureNumber = PromptForInterger("What pen number is the dinosaur be held?");
            // define dino.DinoDescription from the input from the user
            dino.DinoDescription = ($"{dino.Name}, {dino.DietType}, {dino.WhenAcquired}, {dino.Weight}, {dino.EnclosureNumber}");

            Console.WriteLine("");
            Console.WriteLine("programing in progress...");

            foreach (var saur in dinoList)
            {
                Console.WriteLine(saur.DinoDescription);
            }


            // if dino found in park return true

            // else return NOT FOUND


            // create menu
            // "Choose from the menu. [V]eiw the two types of dinos. [A]dd new dino.
            // [R]emove a dino. [T]ransfer a dino. [S]ummary to display how many dinos.
            // [Q]uit.

            // if input = V
            // Console.WriteLine("{name} is a {diet type}. I was recieved on {date.time}. It weights {weight}.
            // It is located at {enclosure number}")

            // else if input = A
            //   var dino = new dino();

            //   prompt name
            //   prompt diet
            //   prompt when acquired
            //   prompt weight
            //   prompt enclosure number

            //   add properties to dino lsit

            // else if input = R
            //   var dinoRemove = prompt string for "What dino are you looking for?"

            //   var dinoToRemove = dino by name in dino list with the name equal to the name to be deleted
            //   if false/null
            //   return no dino by that name

            //   else dino.remove dino to be deleted
            //   write dino was removed

            // else if input = T
            //   var dinoTransfer = prompt string for "what dino do you want to transfer?"

            //   var dinoToTransfer = dino by name in dino list with the name equal to the name to be transfered

            //   if null
            //   return no dino by that name

            //   else newPenNum = prompt for string "what is {dinoToTransfer}'s new pen number?"

            //   dinoToTransfer.EnclosureNum = newPenNum

            // else if input = S
            //   need them the number for carno and herbos instend..LINQ 

            // else if inoput = Q
            //   bool = false // exit
        }
    }
}
