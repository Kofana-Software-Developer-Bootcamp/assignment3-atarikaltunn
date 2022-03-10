using System;
using System.IO;

namespace Civciv
{
    class Assignment
    {
        class Car //car class to car saling
        {
            private string brand = "";
            private int year = 0, kilometers = 0, damageAmount = 0;

            // public functions to gets/sets car's informations
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public int DamageAmount
            {
                get { return damageAmount; }
                set { damageAmount = value; }
            }
            public int Kilometers
            {
                get { return kilometers; }
                set { kilometers = value; }
            }

        }

        class Person //person class to user seller/buyer
        {
            private int age = 0;
            private string name = "", identityNumber = "", phoneNum = "";
            //private Car[] carArray = new Car[] { };

            // public functions to gets/sets person's informations

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string IdentityNumber
            {
                get { return identityNumber; }
                set { identityNumber = value; }
            }
            public string PhoneNum
            {
                get { return phoneNum; }
                set { phoneNum = value; }
            }
            //public Car CarArray
            //{
            //    get { return carArray; }
            //    set { carArray = value; }
            //}

        }
        // Main Method
        public static void Main()
        {
            try
            {
                Console.WriteLine(
                "Welcome to car sale!\n" +
                "------------------------------------------\n" +
                "*To continue please Sign in (press 1).\n" +
                "*Don't have an account? Sign up (press 2).\n" +
                "*To exit, please press 'q'."
                );

                string? statement = "";

                while (true)
                {
                    statement = Console.ReadLine();
                    if (statement == "q") // want to leave statement
                    {
                        break;
                    }

                    else if (statement == "1") //signIn statement
                    {

                    }

                    else if (statement == "2") //signUp statement
                    {
                        Person newUser = new Person();
                        Console.WriteLine("Enter your name: ");
                        newUser.Name = Console.ReadLine();


                        Console.WriteLine("Enter your age: ");
                        newUser.Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter your Identity Number: ");
                        newUser.IdentityNumber = Console.ReadLine();

                        Console.WriteLine("Signing is successful! Name:" + newUser.Name + " , Age: " + newUser.Age + " , IdentityNumber: " + newUser.IdentityNumber);
                    }
                    else //Wrong typing statement
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }
    }
}
