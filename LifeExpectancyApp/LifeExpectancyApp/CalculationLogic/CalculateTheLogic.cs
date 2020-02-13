using LifeExpectancyApp.SelfRisks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp.CalculationLogic
{
    public class CalculateTheLogic
    {
        public void Calculate()
        {
            UserInput input = new UserInput();
            var GetPerson = new Person();
            var drinks = new Drinking();
            var smoking = new Smoking();
            input.userInput();
            int ageToLive = GetPerson.PersonsAge - (drinks.NumberOfyears / 2);
            ageToLive = GetPerson.PersonsAge - (smoking.NumberOfyears / 2);
            Console.WriteLine("Age to live is: "+ ageToLive);
        }
    }
}
