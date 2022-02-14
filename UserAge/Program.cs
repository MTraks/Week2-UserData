using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaasta konsoolis;
            //"oled sündinud aastal {yearOfBirth}";

            Console.WriteLine("Palun, sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBireth = 2021 - UserAge;

            Console.WriteLine($"Sa oled sündinud aastal {YearOfBireth}.");




        }
    }
}
