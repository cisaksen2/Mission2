using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            string two = "2:  "; //declaring strings for final display
            string three = "3:  ";
            string four = "4:  ";
            string five = "5:  ";
            string six = "6:  ";
            string seven = "7:  ";
            string eight = "8:  ";
            string nine = "9:  ";
            string ten = "10: ";
            string eleven = "11: ";
            string twelve = "12: ";

            Random die1 = new Random(); //starting instance of Random to simulate die1
            Random die2 = new Random(); //starting instance of Random to simulate die2

            int[] amountKeeper = new int[12]; //creating array to house the numbers and amounts of times they've been rolled

            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n"); //welcome message

            Console.Write("How many dice rolls would you like to simulate? "); //asking how many die to throw
            int numRolls = Convert.ToInt32(Console.ReadLine()); //taking user input and saving it to numRolls variable
            double numRollsDub = Convert.ToDouble(numRolls); //converting numrolls from int32 to double

            for (int i = 0; i < numRolls; i++) //loop to cycle through the amount of rolls specified by the user
            {
                int roll1 = die1.Next(6)+1; //make random number for die1
                int roll2 = die2.Next(6)+1; //make random number for die2

                int amount = (roll1 + roll2) - 1; //adding the two rolls together

                amountKeeper[amount]++; //going into the array and adding the occurence to the amount
            }
           
            double twopct = Math.Round(amountKeeper[1] / numRollsDub * 100); //calculating percentages
            double threepct = Math.Round(amountKeeper[2] / numRollsDub * 100);
            double fourpct = Math.Round(amountKeeper[3] / numRollsDub * 100);
            double fivepct = Math.Round(amountKeeper[4] / numRollsDub * 100);
            double sixpct = Math.Round(amountKeeper[5] / numRollsDub * 100);
            double sevenpct = Math.Round(amountKeeper[6] / numRollsDub * 100);
            double eightpct = Math.Round(amountKeeper[7] / numRollsDub * 100);
            double ninepct = Math.Round(amountKeeper[8] / numRollsDub * 100);
            double tenpct = Math.Round(amountKeeper[9] / numRollsDub * 100);
            double elevenpct = Math.Round(amountKeeper[10] / numRollsDub * 100);
            double twelvepct = Math.Round(amountKeeper[11] / numRollsDub * 100);

            for (int i = 0; i < twopct; i++) //for loops for each pct to place correct amount of asteriks
            {
                two = two + "*";
            }
            for (int i = 0; i < threepct; i++)
            {
                three = three + "*";
            }
            for (int i = 0; i < fourpct; i++)
            {
                four = four + "*";
            }
            for (int i = 0; i < fivepct; i++)
            {
                five = five + "*";
            }
            for (int i = 0; i < sixpct; i++)
            {
                six = six + "*";
            }
            for (int i = 0; i < sevenpct; i++)
            {
                seven = seven + "*";
            }
            for (int i = 0; i < eightpct; i++)
            {
                eight = eight + "*";
            }
            for (int i = 0; i < ninepct; i++)
            {
                nine = nine + "*";
            }
            for (int i = 0; i < tenpct; i++)
            {
                ten = ten + "*";
            }
            for (int i = 0; i < elevenpct; i++)
            {
                eleven = eleven + "*";
            }
            for (int i = 0; i < twelvepct; i++)
            {
                twelve = twelve + "*";
            }

            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS" + "\n" + "Each '*' represents 1% of the total number of rolls." +
                "\n" + "Total number of rolls = " + numRolls + "." + "\n"); //explanation message w/ number of rolls

            Console.WriteLine(two); //displaying the bell curve
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            Console.WriteLine(six);
            Console.WriteLine(seven);
            Console.WriteLine(eight);
            Console.WriteLine(nine);
            Console.WriteLine(ten);
            Console.WriteLine(eleven);
            Console.WriteLine(twelve);

            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!"); //goodbye message
        }
    }
}
