using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp.SelfRisks
{
    public class Smoking : Person
    {
        private string doYouSmoke;
        private string TypeOfSmoker;
        private int numberOfyearsSmoking;
        public int NumberOfyears
        {
            get
            {
                return numberOfyearsSmoking;
            }
            set
            {
                numberOfyearsSmoking = value;
            }
        }

        public override void CalculateLifeExpectancy()
        {
            try
            {

                Console.WriteLine("Do you Smoke? \nA) Yes \nB) No");
                doYouSmoke = Console.ReadLine();

                if (doYouSmoke == "A" || doYouSmoke == "a")
                {
                    Console.WriteLine("Please select a type of smoking below:");
                    Console.WriteLine("A) Are you a SecondHand Smoker.");
                    Console.WriteLine("B) Are you a Full time Smoker.");
                    Console.WriteLine("C) Did you use to smoke and stop.");
                    TypeOfSmoker = Console.ReadLine();
                    if (TypeOfSmoker == "A" || TypeOfSmoker == "a")
                    {
                        NumberOfyearsInput();
                    }
                    else if (TypeOfSmoker == "B" || TypeOfSmoker == "b")
                    {
                        NumberOfyearsInput();
                    }
                    else if (TypeOfSmoker == "C" || TypeOfSmoker == "c")
                    {
                        NumberOfyearsInput();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
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
        public void NumberOfyearsInput()
        {
            Console.WriteLine("How many years?");
            numberOfyearsSmoking = int.Parse(Console.ReadLine());
            if (numberOfyearsSmoking < PersonsAge)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
