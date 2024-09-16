using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số lượng số trong danh sách: ");

            // Hai biến để kiểm tra xem sô nhập vào có phải là số không
            string checkNumber = Console.ReadLine();
            int number;

            while (!int.TryParse(checkNumber, out number))
            {
                Console.Write("Số nhập vào không hợp lệ. Hãy nhập vào số khác: ");
                checkNumber = Console.ReadLine();
            }

            // Tạo một danh sách để add thêm các số được nhập vào
            int[] intList = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Nhập vào số thứ {0}: ", i + 1);
                string checkinput = Console.ReadLine();
                int input;

                while (!int.TryParse(checkinput, out input))
                {
                    Console.Write("Số nhập vào không hợp lệ. Hãy nhập vào số khác: ");
                    checkinput = Console.ReadLine();
                }

                intList[i] = input;
            }


            List<int> negativeList = new List<int>();
            List<int> positiveList = new List<int>();
            int sumNegativeNumber = 0;
            int sumPositiveNumber = 0;
            foreach (int i in intList)
            {
                if (i < 0)
                {
                    negativeList.Add(i);
                    sumNegativeNumber += i;
                }
                else if (i > 0)
                {
                    positiveList.Add(i);
                    sumNegativeNumber += i;
                }
            }
            Console.WriteLine("Danh sách có {0} số âm", negativeList.Count);
            Console.WriteLine("Tổng các số âm là {0}", sumNegativeNumber);

            Console.WriteLine("Danh sách có {0} số dương", positiveList.Count);
            Console.WriteLine("Tổng các số âm là {0}", sumPositiveNumber);

            Console.ReadKey();  
        }  
    }
}
