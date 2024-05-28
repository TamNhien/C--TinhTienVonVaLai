using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so tien gui ban dau (trieu dong): ");
        double T = double.Parse(Console.ReadLine());

        Console.WriteLine("Nam\tTien von (trieu)\tLai (trieu)");

        for (int year = 1; year <= 15;  year++)
        {
            double tien_von = T * Math.Pow(1 + 0.08, year);
            double tien_lai = T * 0.08 * year;

            Console.WriteLine($"{year}\t{tien_von:F2}\t\t\t{tien_lai:F2}");
        }
    }
}