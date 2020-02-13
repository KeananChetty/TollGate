using LifeExpectancyApp.SelfRisks;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp
{
    public class UserInput
    {
        
        public void userInput()
        {
            var GetPerson = new Person();
            var drinks = new Drinking();
            var smoking = new Smoking();
            GetPerson.GetClientInfo();
            drinks.CalculateLifeExpectancy();
            smoking.CalculateLifeExpectancy();

            
            GetPerson.PersonGender.ToString();
            var dringkNumberOfyers = drinks.NumberOfyears;
            var smokesnumberOfYers = smoking.NumberOfyears;





        }
    }
}
