namespace Biblioteka
{
    public class PoleFigury
    {
        public static double Kwadrat(double a)
        {
            double pole;
            pole = a * a;
            return pole;
        }

        public static double Kolo(double r)
        {
            double pole;
            pole = Math.PI * r * r;
            return pole;
        }

    }
}
