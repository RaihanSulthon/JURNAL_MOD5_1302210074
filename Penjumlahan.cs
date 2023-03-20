using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD5_1302210074
{
    internal class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T a,T b, T c)
        {
            dynamic result = 0;
            result = result+ c;
            result= result+ a;
            result= result+ b;
            Console.WriteLine("Penjumlahan 3 angka: " + result);
        }
    }
}
