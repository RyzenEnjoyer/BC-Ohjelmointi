using System;
using System.Collections.Generic;

class Ovi
{

    public enum Oventila { Auki, Kiinni, Lukossa }
   
    static void Main()
    {
        string Ovi;

        Oventila tila = Oventila.Lukossa;
        while (true)
        {
            Ovi = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Mitä ovelle tehdään = {0}", Ovi);
            Console.WriteLine(" ");

            if (tila == Oventila.Lukossa)
                    {
                        if (Ovi == "Avaalukko")
                        {
                            Console.WriteLine("Lukko avataan");
                            tila = Oventila.Kiinni;
                            
                        }
                    }

            if (tila == Oventila.Kiinni)
            {


                if (Ovi == "Avaa")
                {
                    Console.WriteLine("Ovi avataa");
                    tila = Oventila.Auki;
                   
                }
            }

            if (tila == Oventila.Auki)
            {
                if (Ovi == "Sulje")
                {
                    Console.WriteLine("Ovi suljetaan");
                    tila = Oventila.Kiinni;
                    
                }
            }

            if (tila == Oventila.Kiinni)
            {
                if (Ovi == "Lukitse")
                {
                    Console.WriteLine("Ovi lukitaan");
                    tila = Oventila.Lukossa;
                    
                }
            }

            
            
            
        }


    }
}
// Lukko aukeaa komennolla Avaalukko
//Ovi avataan komennolla Avaa
//Ovi suljetaan komennolla Sulje
//Ovi lukitaan komennolla Lukitse
