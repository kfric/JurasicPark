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


                //  if input = Q
                if (answer == "Q")
                {
                    //  bool = false // exit
                    contProg = false;
                }
                // if input = V
                else if (answer == "V")
                {

                    // foreach dinosaur in list
                    foreach (var dino in dinos)
                    {

                        // Console.WriteLine("{name} is a {diet type}. I was received on {date.time}. It weights {weight}.
                        // It is located at {enclosure number}")
                        Console.WriteLine($"{dino.DinoDescription}");
                    }


                }
                // else if input = A
                else if (answer == "A")
                {
                    //   prompt name
                    //   prompt diet
                    //   prompt when acquired
                    //   prompt weighta
                    //   prompt enclosure number

                    var dino = new Dino();

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
                    dino.DinoDescription = ($"NAME: {dino.Name}. TYPE: {dino.DietType}. ACQUIRED: {dino.WhenAcquired}. WEIGHT: {dino.Weight}lbs. LOCATED IN PEN #{dino.EnclosureNumber}");


                    // add the collections of values to the list
                    dinos.Add(dino);
                }
                // else if input = T
                else if (answer == "T")
                {
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

                }
                // else if input = R
                else if (answer == "R")
                {
                    //   var dinoRemove = prompt string for "What dino are you looking for?"
                    var name = PromptForString("What is the name of the dinosaur that you want remove?");
                    //   var dinoToRemove = dino by name in dino list with the name equal to the name to be deleted
                    Dino foundDino = dinos.FirstOrDefault(dino => dino.Name == name);

                    //   if false/null
                    if (foundDino == null)
                    {
                        //   return no dino by that name
                        Console.WriteLine("There are no dinosaurs by that name");
                    }
                    else
                    {
                        //   else dino.remove dino to be deleted
                        dinos.Remove(foundDino);
                        //   write dino was removed
                        Console.WriteLine($"{name} has been removed");
                    }




                }





                //   if null
                //   return no dino by that name


                // if dino found in park return true
                // else return NOT FOUND



                //   add properties to dino list




                // else if input = S
                //   need them the number for carno and herbos instend..LINQ 


            }
        }
    }
}
