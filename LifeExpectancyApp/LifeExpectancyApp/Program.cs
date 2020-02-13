using LifeExpectancyApp.CalculationLogic;
using System;

namespace LifeExpectancyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInput input = new UserInput();
            //input.userInput();
            CalculateTheLogic calc = new CalculateTheLogic();
            calc.Calculate();
        }
    }
}
