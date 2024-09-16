using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Buoi6_03
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int[] quaCan = { 1, 2, 4, 8, 16, 32, 64, 128 };
            Array.Reverse(quaCan);


            Console.Write("Nhập vào trọng lương M: ");
            string m = Console.ReadLine();
            int weightM;

            while (!int.TryParse(m, out weightM)||weightM<=0)
            {
                Console.Write("Số nhập vào không hợp lệ. Hãy nhập số khác: ");
                m = Console.ReadLine();
            }

            List<int> usedNumbers = new List<int>();
            while (weightM > 0)
            {
                foreach (int i in quaCan)
                {
                    if (weightM < i)
                    {
                        continue;

                    }
                    Console.Write("{0} - {1} = ", weightM, i);
                    weightM = weightM - i;
                    usedNumbers.Add(i);

                    Console.WriteLine(weightM);



                }
            }
            Console.Write("Các quả cân được sử dụng: ");
            foreach (int i in usedNumbers)
            {
                if (i == usedNumbers.Min())
                {
                    Console.Write("{0}kg ", i);

                }
                else
                {
                    Console.Write("{0}kg, ", i);
                }

            }
                

            
            Console.ReadKey();
                


        }
    }
}
