namespace WeihnachtsbaumLösung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //       *
            //      *o*
            //     *o*o*
            //    *o*o*o*
            //   *o*o*o*o*
            //      |||       

            //Stufe1:
            //
            //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
            //Du kannst dir das Aussehen des Baums selber aussuchen
            //Nutze für die Ausgabe Schleifen.
            //Stufe 2:
            //
            //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
            //Nutze ggf. Farben.

            //Stufe 3: 
            //
            //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

            //Stufe 4:
            //
            //Lass den Baum Blinken und Funkeln
            //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.

            //Stufe 1: 

            string[] baum = { "       *", "      *o*", "     *o*o*", "    *o*o*o*", "   *o*o*o*o*", "      |||" };

            foreach (string s in baum)
            {
                Console.WriteLine(s);
            }

            //Stufe 2: 

            string[] gruss = { "Frohe Weihnachten!", "Es Weihnachtet sehr!", "Stille Nacht, heilige Nacht!" };
            Random rand = new Random();
            int auswahl = rand.Next(0, gruss.Length);

            Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16);

            Console.WriteLine(gruss[auswahl]);


            //Stufe 3
            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.ResetColor();

                foreach (string s in baum)
                {
                    Console.WriteLine(s);
                }

                int letzteAuswahl = auswahl;
                while (true)
                {
                    auswahl = rand.Next(0, gruss.Length);
                    if (auswahl != letzteAuswahl)
                    {
                        break;
                    }

                }
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine(gruss[auswahl]);

                //Stufe 4 

                Console.SetCursorPosition(7, 1);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(6, 2);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(8, 2);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(5, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(7, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(9, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(4, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(6, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(8, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");

                Console.SetCursorPosition(10, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine("o");



            }

             






        }
    }
}
