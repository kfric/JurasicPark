using System;
using System.Collections.Generic;
using System.Linq;

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
        public string DinoDescription()
        {
            var newDinoDescription = $"NAME: {Name}. TYPE: {DietType}. ACQUIRED: {WhenAcquired}. WEIGHT: {Weight}lbs. LOCATED IN PEN #{EnclosureNumber}";
            return newDinoDescription;
        }

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
            var goodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (goodInput)
            {
                // - return response
                return userInput;
            }
            else
            {
                // if input not a number then default to 0
                Console.WriteLine("Invalid numbers default to 0");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            // create new dinos list hold the values of a dino
            var dinos = new List<Dino>();

            // display welcome
            DisplayWelcome();

            // create bool statement to determine if prog cont.
            var contProg = true;
            // create loop to decide next step depending on the user input
            while (contProg)
            {
                // create menu like prompt
                // "Choose from the menu. [V]eiw the two types of dinos. [A]dd new dino.
                // [R]emove a dino. [T]ransfer a dino. [S]ummary to display how many dinos.
                // [Q]uit.
                Console.WriteLine();
                Console.WriteLine("Menu options: [V]iew, [A]dd, [R]emove, [T]ransfer, [S]ummary, [Q]uit.");
                // read response
                var answer = Console.ReadLine().ToUpper();

                // covert to switch statement to clean up???

                switch (answer)
                {
                    //  if input = Q
                    case "Q":
                        //  bool = false // exit
                        contProg = false;
                        break;

                    // if input = V
                    case "V":
                        // foreach dinosaur in list
                        var WhenAcquired = dinos.OrderBy(monster => monster.WhenAcquired);
                        foreach (var monster in WhenAcquired)
                        {
                            // Console.WriteLine("{name} is a {diet type}. I was received on {date.time}. It weights {weight}.
                            // It is located at {enclosure number}")
                            Console.WriteLine(monster.DinoDescription());
                        }



                    // else if input = A
                    case "A":

                        //   prompt name
                        //   prompt diet
                        //   prompt when acquired
                        //   prompt weighta
                        //   prompt enclosure number

                        var dino = new Dino();

                        // create prompt for getting the dino Name 
                        dino.Name = PromptForString("What is the Dinosaurs name?");
                        // create prompt for getting the dino DietType
                        dino.DietType = PromptForString("Is it a [C]arnivore or a [H]erbivore");
                        // create prompt that logs the current date and time
                        dino.WhenAcquired = DateTime.Now;
                        // create prompt for getting the dino Weight
                        dino.Weight = PromptForInterger("How much does the dinosaur weight in lbs? ");
                        // create prompt for getting the dino EnclosureNumber
                        dino.EnclosureNumber = PromptForInterger("What pen number is the dinosaur be held?");
                        // define dino.DinoDescription from the input from the user
                        // dino.DinoDescription = ($"NAME: {dino.Name}. TYPE: {dino.DietType}. ACQUIRED: {dino.WhenAcquired}. WEIGHT: {dino.Weight}lbs. LOCATED IN PEN #{dino.EnclosureNumber}");


                        // add the collections of values to the list
                        dinos.Add(dino);

                        break;

                    // else if input = T
                    case "T":

                        //   var dinoTransfer = prompt string for "what dino do you want to transfer?"
                        var name = PromptForString("The name of the dinosaur you want to transfer: ");
                        //   var dinoToTransfer = monster by name in monster list with the name equal to 
                        //    the name to be transferred
                        Dino foundDino = dinos.FirstOrDefault(dino => dino.Name == name);

                        if (foundDino == null)
                        {
                            Console.WriteLine("There are no dinosaurs here by that name");
                        }
                        else
                        {
                            //   else newPenNum = prompt for string "what is {dinoToTransfer}'s new pen number?"
                            var newEnclosureNum = PromptForInterger($"What is {name}'s new Enclosure number?");

                            //   dinoTransfer.EnclosureNum = newPenNum
                            foundDino.EnclosureNumber = newEnclosureNum;
                        }

                        break;


                    // else if input = R
                    case "R":

                        //   var dinoRemove = prompt string for "What dino are you looking for?"
                        var dinoToRemove = PromptForString("What is the name of the dinosaur that you want remove?");
                        //   var dinoToRemove = dino by name in dino list with the name equal to the name to be deleted
                        Dino foundDinoToRemove = dinos.FirstOrDefault(dino => dino.Name == dinoToRemove);

                        //   if false/null
                        if (foundDinoToRemove == null)
                        {
                            //   return no dino by that name
                            Console.WriteLine("There are no dinosaurs by that name");
                        }
                        else
                        {
                            //   else dino.remove dino to be deleted
                            dinos.Remove(foundDinoToRemove);
                            //   write dino was removed
                            Console.WriteLine($"{dinoToRemove} has been removed");
                        }

                        break;


                    // else if input = S
                    case "S":

                        // carnivore is equal to the count of inputs "c" in dino.DietType
                        var carnivore = dinos.Where(dino => dino.DietType == "c").Count();
                        // carnivore is equal to the count of inputs "h" in dino.DietType
                        var herbivore = dinos.Where(dino => dino.DietType == "h").Count();

                        var dinoType = $"There are {carnivore} Carnivore[s] and {herbivore} Herbivore[s]";

                        Console.WriteLine(dinoType);


                        break;


                }


            }
        }
    }
}
