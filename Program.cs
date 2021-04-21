using System;

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
        public string WhenAcquired { get; set; }
        // Weight int {get; set;}
        public int Weight { get; set; }
        // EnclosureNumber int {get; set;}
        public int EnclosureNumber { get; set; }

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
            // - read line and set it as the userInout
            var validUserInput = Int32.TryParse(Console.ReadLine(), out userInput);
            // - return response
            return userInput;
        }
        static void Main(string[] args)
        {
            // display welcome
            DisplayWelcome();

            var dino = new Dino();

            // create prompt for getting the dino Name 
            dino.Name = PromptForString("What is the Dinosaurs name?");
            // create prompt for getting the dino DietType
            dino.DietType = PromptForString("Is it a [Carnivore] or a [Herbivore]");
            // create prompt for getting the dino WhenAcquired
            dino.WhenAcquired = PromptForString("When did the dinosaur arrive?");
            // create prompt for getting the dino Weight
            dino.Weight = PromptForInterger("How much does the dinosaur weight in lbs? ");
            // create prompt for getting the dino EnclosureNumber
            dino.EnclosureNumber = PromptForInterger("What pen number is the dinosaur be held?");

            Console.WriteLine("");
            Console.WriteLine("programing in progress...");
            Console.WriteLine("");


            // if dino found in park return true
            // else return NOT FOUND

            // display greeting

            // prompt "what is the dinosuar's name?"
            // prompt "what is its diet type?"
            // prompt "when was is acquired?"
            // prompt "what is its weight?"
            // prompt "what pen is it located in?"

            // create new dinos list to hold the values of a dino
            // - add the collections of values to the list

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
