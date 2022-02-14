using System;

namespace InstagramPageCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //progeamm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrami kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun, sisesta on vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if(UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");

            }
            else if(UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else
            {
                Console.WriteLine("Oled 13 aastat vana, nüüd saad Instagrami kontot luua.");
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}
