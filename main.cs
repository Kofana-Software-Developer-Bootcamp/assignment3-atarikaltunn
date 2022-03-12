using System;
using System.IO;

namespace Civciv
{
    class Assignment
    {
        class Car //car class to car saling
        {
            private string 
                brand = "";
            private int 
                year = 0, 
                kilometers = 0, 
                damageAmount = 0;
            //private Person 
            //    owner = new Person();

            // public functions to gets/sets car's informations
            //public Person Owner
            //{ 
            //    get { return owner; } 
            //    set { owner = value; }
            //}
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
            private int
                age = 0;
            private string 
                name = "",
                username = "",
                identityNumber = "",
                phoneNum = "", 
                password = "";
            private Car 
                carArray = new Car() { };

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
            public string Username
            {
                get { return username; }
                set { username = value; }
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
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            public Car CarArray
            {
                get { return carArray; }
                set { carArray = value; }
            }

        }
        // Main Method
        public static void Main()
        {
            try
            {
                int 
                    personID = 0, 
                    carID = 0;

                string? 
                    statement, 
                    choice = "";

                Person[] 
                    users = new Person[5];

                Car[] 
                    onSaleCars = new Car[5];

                while (true)
                {
                    Console.WriteLine(
                        "Welcome to car sale!\n" +
                        "------------------------------------------\n" +
                        "*To continue please Sign in: (press 1).\n" +
                        "*Don't have an account? Sign up: (press 2).\n" +
                        "*Users info: (press 3).\n" +
                        "*To exit, please press 'q'."
                );
                    if (personID == users.Length) // not to any exception occurs because of array index out of range
                    {
                        Array.Resize(ref users, users.Length + 1);
                    }

                    statement = Console.ReadLine();
                    if (statement == "q") // want to leave statement
                    {
                        break;
                    }

                    else if (statement == "1") //signIn statement
                    {
                        Console.WriteLine("Enter your username or name: ");
                        var name = Console.ReadLine();

                        Console.WriteLine("Enter your password: ");
                        var password = Console.ReadLine();

                        for (int j = 0; j < personID; j++)
                        {
                            if ((users[j].Name == name || users[j].Username == name) && users[j].Password == password) //signin is successfull
                            {
                                Session:
                                Console.WriteLine(
                                    "Welcome!"               +
                                    "What do you want to do:\n"+
                                    "1- Buy a car:\n"          +
                                    "2- Sell a car:"
                                    );
                                choice = Console.ReadLine();

                                if(choice == "1") // wants to buy
                                {
                                    if(carID == 0)
                                    {
                                        Console.WriteLine("There is no car on sale!");
                                        goto Session;
                                    }
                                    else 
                                    {

                                        Console.WriteLine("Vehicles on sale:");

                                        for (int k = 0; k < carID; k++)
                                        {
                                            Console.WriteLine(
                                        "\nCar ID: " + k +
                                        "\nBrand: " + onSaleCars[k].Brand +
                                        "\nYear: " + onSaleCars[k].Year +
                                        "\nKilometers: " + onSaleCars[k].Kilometers +
                                        "\nDamage Amount: " + onSaleCars[k].DamageAmount + "\n\n"
                                        );
                                        }
                                        goto Session;
                                    }
                                }
                                else if (choice == "2") // wants to sell
                                {
                                    Car newCar = new Car();
                                    Console.WriteLine("Please enter the features of the car:");

                                    Console.WriteLine("Brand:");
                                    newCar.Brand = Console.ReadLine();

                                    Console.WriteLine("Year:");
                                    newCar.Year = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Kilometers:");
                                    newCar.Kilometers = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("DamageAmount:");
                                    newCar.DamageAmount = Convert.ToInt32(Console.ReadLine());

                                    //newCar.Owner = users[j];

                                    onSaleCars[carID] = newCar;
                                    Console.WriteLine(
                                        "Car register is successful!" +
                                        "\nCar ID: " + carID +
                                        //"\nOwner: " + newCar.Owner +
                                        "\nBrand: " + newCar.Brand +
                                        "\nYear: " + newCar.Year +
                                        "\nKilometers: " + newCar.Kilometers +
                                        "\nDamage Amount: " + newCar.DamageAmount + "\n\n"
                                        );
                                    carID++;
                                    goto Session;
                                }
                                else
                                {
                                    Console.WriteLine("Typed wrong!");
                                    goto Session;
                                }


                            }
                        }
                        Console.WriteLine("\nUsername or password is wrong, please try again!\n\n");
                    }

                    else if (statement == "2") //signUp statement
                    {
                        try
                        {
                            Person newUser = new Person();
                            Console.WriteLine("Enter your name: ");
                            newUser.Name = Console.ReadLine();

                            Console.WriteLine("Enter your username: ");
                            newUser.Username = Console.ReadLine();

                            Console.WriteLine("Enter your password: ");
                            newUser.Password = Console.ReadLine();

                            Console.WriteLine("Enter your age: ");
                            newUser.Age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter your Identity Number: ");
                            newUser.IdentityNumber = Console.ReadLine();

                            users[personID] = newUser;
                            Console.WriteLine(
                                "\n\nSigning is successful!\n" +
                                "\nIndex: " + personID +
                                "\nUsername: " + newUser.Username +
                                "\nName: " + newUser.Name +
                                "\nAge: " + newUser.Age +
                                "\nIdentityNumber: " + newUser.IdentityNumber);

                            personID++;

                            Console.WriteLine("\n ***Directing to main page.***\n\n\n");

                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else if (statement == "3") //info 
                    {
                        for (int j = 0; j < personID; j++)
                        {
                            if (users[j].Name == null)
                            {
                                break;
                            }
                            Console.WriteLine("\nUser-" + j + ": " + users[j].Name);

                            Console.WriteLine("\n ***Directing to main page.***\n\n");

                        }
                    }
                    else //Wrong typed statement
                    {
                        Console.WriteLine("You have entered wrong, please try again: \n\n");
                        continue;
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
