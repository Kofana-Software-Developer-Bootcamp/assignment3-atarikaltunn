using System;
using System.IO;

class Car //car class to car saling
{
    private string brand;
    private int year, kilometers, damageAmount;

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
    private int age;
    private string name, identityNumber, phoneNum;
    private Car[] carArray;

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
    public Car CarArray
    {
        get { return carArray; }
        set { carArray = value; }
    }

}
class Assignment
{

    // Main Method
    public static void Main()
    {


        Console.WriteLine(
            "Welcome to car rent!" +
            "To continue please Sign in (press 1)." +
            "Don't have an account? Sign up (press 2)." +
            "To exit, please press 'q'."
            );

        string statement = "";

        // while (true)
        // {

        //     if (statement = Console.ReadLine == "q")
        //     {
        //         break;
        //     }

        //     else if (statement = Console.ReadLine == "1")
        //     {

        //     }

        //     else if (statement = Console.ReadLine == "2")
        //     {
        //         Console.WriteLine("Enter your name: ");
        //         name = Console.ReadLine();


        //         Console.WriteLine("Enter your age: ");
        //         age = Convert.ToInt32(Console.ReadLine());

        //         Console.WriteLine("Enter your Identity Number: ");
        //         identityNumber = Console.ReadLine();


        //     }
        // }
    }
}