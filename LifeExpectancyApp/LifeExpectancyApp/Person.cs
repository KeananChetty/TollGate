using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp
{
    public class Person
    {
        private bool personGender;
        private int personAge;
        private int personWeight;
        private int personMaxAge = 70;


        public bool PersonGender 
        {
            get
            {
                return personGender;
            }
            set
            {
                personGender = value;
            }
        }
        public int PersonsAge
        {
            get
            {
                return personAge;
            }
            set
            {
                personAge = value;
            }
        }
        public int PersonsWeight
        {
            get
            {
                return personWeight;
            }
            set
            {
                personWeight = value;
            }
        }
        public int PersonMaxAge { 
            get 
            {
                return personMaxAge;
            }
            set
            {
                if (PersonGender == true)
                {
                    personMaxAge = 65;
                }else
                {
                    personMaxAge = 70;
                }
            }
        }

        public Person()
        {

        }


        public void GetClientInfo()
        {
            try 
            { 
                Console.WriteLine("What is your gender? \nA) Male \nB)Female ");
                string gender = Console.ReadLine();
               
                    if (gender == "A" || gender == "a")
                    {
                        PersonGender = true;
                    }
                    else if (gender == "B" || gender == "b")
                    {
                        PersonGender = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Please chose A or B");
                    }
               
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            try 
            { 
                Console.WriteLine("What is your Age? ");
                personAge = int.Parse(Console.ReadLine());
                if(personAge > PersonMaxAge)
                {
                    Console.WriteLine("Please enter a correct age < 40");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        public virtual void CalculateLifeExpectancy()
        {

        }

    }
}
