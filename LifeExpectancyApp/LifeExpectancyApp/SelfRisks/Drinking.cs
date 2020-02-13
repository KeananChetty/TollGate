using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp.SelfRisks
{
    public class Drinking : Person
    {
        private string doYouDrink;
        private int numberOfyears;
        public int NumberOfyears 
        { 
            get 
            {
                return numberOfyears; 
            } 
            set 
            { 
                numberOfyears = value; 
            } 
        }

        public override void CalculateLifeExpectancy()
        {
            try
            {
                Console.WriteLine("Do you drink? \nA) Yes \nB) No");
                doYouDrink = Console.ReadLine();

                if (doYouDrink == "A" || doYouDrink == "a")
                {
                    Console.WriteLine("How Long have you been drinking for?");
                    numberOfyears = int.Parse(Console.ReadLine());
                    if (numberOfyears < PersonsAge)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("Your Good.");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

    }
}
