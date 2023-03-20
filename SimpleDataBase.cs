using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD5_1302210074
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData= new List<T>();
            inputDates= new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data Sekarang " + (i + 1) + "\n" + "Data yang disimpan" + storedData[i] + "\n"+ "Pada Waktu : " + inputDates[i] + " AM"); 
            }
        }
    }
}
