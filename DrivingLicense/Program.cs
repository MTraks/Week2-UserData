using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada"
            //kui kasutaj aon vanem kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis;
            //"Palju õnne! Nüüd sa saad ka juhilube taotleda.";

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - yearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");

            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad ka juhilube taotleda.");
            }

            Console.WriteLine("Ohutut sõitu!");




        }
    }
}
