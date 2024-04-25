namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj długość boku kwadratu: ");
            double bok = Convert.ToDouble(Console.ReadLine());
            double kw = Biblioteka.PoleFigury.Kwadrat(bok);
            Console.WriteLine("Pole kwadratu - {0}", kw);

            Console.Write("\nPodaj długość promienia: ");
            double promien = Convert.ToDouble(Console.ReadLine());
            double ko = Biblioteka.PoleFigury.Kolo(promien);
            Console.WriteLine("Pole koła - {0}", ko);

            Console.WriteLine("\nKoniec Programu");
            Console.ReadKey();


        }
    }
}
