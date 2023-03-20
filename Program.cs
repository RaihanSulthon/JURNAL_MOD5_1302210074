// See https://aka.ms/new-console-template for more information
namespace JURNAL_MOD5_1302210074
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Penjumlahan<double> hitung = new Penjumlahan<double>();
            Console.WriteLine("Masukkan Angka: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            hitung.JumlahTigaAngka(a, b, c);

            SimpleDataBase<int> data = new SimpleDataBase<int>();

        }
    }
}