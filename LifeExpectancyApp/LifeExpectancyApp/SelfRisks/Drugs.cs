using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp.SelfRisks
{
    public class Drugs : Person 
    {
        private string doYouDoDrugs;
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
                Console.WriteLine("Have you done Drugs? \nA) Yes \nB) No");
                doYouDoDrugs = Console.ReadLine();

                if (doYouDoDrugs == "A" || doYouDoDrugs == "a")
                {
                    Console.WriteLine("How Long have you been Drugs for?");
                    numberOfyears = int.Parse(Console.ReadLine());
                    if(numberOfyears < PersonsAge)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("Your Good.");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
