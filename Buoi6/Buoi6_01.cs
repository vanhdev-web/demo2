using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Buoi6_01
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
            
            // danh sách Checklist để lưu các số nguyên tố
            List<int> checkList= new List<int>();
            

            foreach (int j in intList)
            {
                int b = 2;
                int count = 0;
                while (b < j)
                {
                    if (j % b == 0)
                    {
                        count++;
                    }
                    b++;
                    
                }
                if (count == 0)
                {
                  checkList.Add(j);  

                }
            }
            if (checkList.Any())
            {
                Console.WriteLine("Số nguyên tố lớn nhất là {0}",checkList.Max());
            }
            else
            {
                Console.WriteLine("Không có số nguyên tố nào hợp lệ");
            }

            // Tạo biến maxcount= 0 để so sánh với sô lần xuất hiện của số nguyên tố, nếu số nguyên tố lớn hơn thì gán giá trị vào maxcount
            int maxcount = 0;
            foreach (int checkCount  in checkList)
            {
                int count = checkList.Where(n=>n==checkCount).Count();
                

                if (count > maxcount)
                {
                    maxcount = count;

                }
 
            }


            // danh sách checklistExist để lưu lại các biến đã sử dụng rồi sau khi kiểm tra số lần xuất hiện
            List<int> CheckExist = new List<int>();
            foreach (int checkPresent in checkList)
            {
                if (checkList.Where(n=> n==checkPresent).Count()== maxcount)
                {
                    if (!CheckExist.Contains(checkPresent))
                    {
                        Console.WriteLine("Số nguyên tố xuất hiện nhiều nhất là {0} với {1} lần xuất hiện ", checkPresent, maxcount);
                        CheckExist.Add(checkPresent);
                    }

                }
            }

            // danh sách dansachnguyento để lưu lại các biến đã sử dụng rồi sau khi kiểm tra đã là số nguyên tố
            List<int> danhSachsoNguyeTo= new List<int>();
            if (checkList.Any())
            {
                Console.Write("Sô nguyên tố trong dang sách là: ");
                foreach (int soNguyenTo in checkList)
                {
                    if (!danhSachsoNguyeTo.Contains(soNguyenTo))
                    {
                        Console.Write("{0} ", soNguyenTo);
                        danhSachsoNguyeTo.Add(soNguyenTo);
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có số nguyên tố");
            }



            Console.ReadKey();
        }
    }
}
