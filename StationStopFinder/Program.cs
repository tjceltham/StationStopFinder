using System;

namespace StationStopFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            // You can correct these
            string[] bakerloo = { "st1", "st2", "st3", "st4" };
            string[] central = { "Hamersmith", "Bond Street", "Liverpool Street" };
            string menuOption = "", menuOption2="";
            string station1 = "";
            string station2 = "";
            string[] currentLine = bakerloo;

            do
            {

                Console.WriteLine("1 - Select Line");
                Console.WriteLine("2 - Enter Station 1");
                Console.WriteLine("3 - Enter Station 2");
                Console.WriteLine("4 - Get Stops betwenn Sation");
                Console.WriteLine("5 - Clear Stations");
                Console.WriteLine("6 - Exit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    Console.WriteLine("1 - Bakerloo");
                    Console.WriteLine("2 - Central");

                    menuOption2 = Console.ReadLine();

                    if (menuOption2 == "1") currentLine = bakerloo;
                    // add Central, Extension add additional lines
                }


                if (menuOption == "2")
                {
                    // Prompt User for Station
                    // store value in station1
                    // Extension 1 - keep asking for a station if users response is not greater than 2 characters
                    // or (Extension 2) has a number in the string

                }
                // Add menu option 3 to add 2nd station - this is where a validation method to check if a string is >2
                // and has no numbers in is useful

                if (menuOption == "4")
                {
                    printDistanceBetweenStations(currentLine, station1, station2);

                }

                // add Code to set station 1 and 2 to "" if user enters 5


            } while (menuOption != "6");
        }

        static void printDistanceBetweenStations(string[] line, string st1, string st2)
        {
            // Find positions of station1 in line array - I suggest a linear search
            // Find position  of station2 in line array - I suggest a linear search
            // Calculate difference between the two and prrint out difference
            // 

        }
    }
}
