using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Buoi6_04
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;  
            string[] Quizzes =
            {
                "Câu 1:\r\nHãy cho biết ý tưởng nào sau đây nói về phương pháp sắp xếp chọn tăng dần (select sort)?\nA. Phân đoạn dãy thành nhiều dãy con và lần lượt trộn hai dãy con thành dãy lớn hơn, cho đến khi thu được dãy ban đầu đã được sắp xếp\nB. Lần lượt lấy phần tử của danh sách chèn vị trí thích hợp của nó trong dãy\nC. Chọn phần tử bé nhất xếp vào vị trí thứ nhất bằng cách đổi chổ phần tử bé nhất với phần tử thứ nhất; Tương tự đối với phần tử nhỏ thứ hai cho đến phần tử cuối cùng\nD.Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếp nhau, nếu phần tử nào bé hơn được cho lên vị trí trên",
                "Câu 2:\r\nHãy cho biết ý tưởng nào sau đây nói về phương pháp sắp xếp nổi bọt (bubble sort)?\r\nA. Phân đoạn dãy thành nhiều dãy con và lần lượt trộn hai dãy con thành dãy lớn hơn, cho đến khi thu được dãy ban đầu đã được sắp xếp\r\n\r\nB. Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếp nhau, nếu phần tử nào nhỏ hơn được đứng vị trí trên\r\n\r\nC. Lần lượt lấy phần tử của danh sách chèn vị trí thích hợp của nó trong dãy bằng cách đẩy các phần tử lớn hơn xuống\r\n\r\nD. Chọn phần tử bé nhất xếp vào vị trí thứ nhất bằng cách đổi chổ phần tử bé nhất với phần tử thứ nhất; Tương tự đối với phần tử nhỏ thứ hai cho đến phần tử cuối cùng",
                "Câu 3:\r\nHãy cho biết ý tưởng nào sau đây nói về phương pháp sắp xếp chèn (insertion sort)?\r\nA. Phân đoạn dãy thành nhiều dãy con và lần lượt trộn hai dãy con thành dãy lớn hơn, cho đến khi thu được dãy ban đầu đã được sắp xếp\r\n\r\nB. Lần lượt lấy phần tử của danh sách chèn vị trí thích hợp của nó trong dãy bằng cách đẩy các phần tử lớn hơn xuống\r\n\r\nC. Chọn phần tử bé nhất xếp vào vị trí thứ nhất bằng cách đổi chổ phần tử bé nhất với phần tử thứ nhất; Tương tự đối với phần tử nhỏ thứ hai cho đến phần tử cuối cùng\r\n\r\nD. Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếp nhau, nếu phần tử nào nhỏ hơn được đứng vị trí trên",
                "Câu 4:\r\nHãy cho biết ý tưởng nào sau đây nói về phương pháp sắp xếp nhanh (Quick sort)?\r\nA. Chọn phần tử bé nhất xếp vào vị trí thứ nhất bằng cách đổi chổ phần tử bé nhất với phần tử thứ nhất; Tương tự đối với phần tử nhỏ thứ hai cho đến phần tử cuối cùng\r\n\r\nB. Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếpnh u, nếu phần tử nào nhỏ hơn được đứng vị trí trên\r\n\r\nC. Phân đoạn dãy thành nhiều dãy con và lần lượt trộn hai dãy con thành dãy lớn hơn, cho đến khi thu được dãy ban đầu đã được sắp xếp\r\n\r\nD. Lần lượt chia dãy phần tử thành hai dãy con bởi một phần tử khoá (dãy con trước khoá gồm các phần tử nhỏ hơn khoá và dãy còn lại gồm các phần tử lớn hơn khoá)",
                "Câu 5:\r\nPhương pháp nào sau đây chính là phương pháp sắp xếp nhanh (Quick sort)?\r\nA. Phương phap trộn\r\n\r\nB. Phương pháp vun đống\r\n\r\nC. Phương pháp chèn\r\n\r\nD. Phương pháp phân đoạn",
                "Câu 6:\r\nHãy cho biết ý tưởng nào sau đây nói về tưởng phương pháp sắp xếp Trộn (Merge sort)?\r\nA. Lần lượt chia dãy phần tử thành hai dãy con bởi một phần tử khoá (dãy con trước khoá gồm các phần tử nhỏ hơn khoá và dãy còn lại gồm các phần tử lớn hơn khoá)\r\n\r\nB. Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếp nhau, nếu phần tử nào nhỏ hơn được đứng vị trí trên\r\n\r\nC. Chọn phần tử bé nhất xếp vào vị trí thứ nhất bằng cách đổi chổ phần tử bé nhất với phần tử thứ nhất; Tương tự đối với phần tử nhỏ thứ hai cho đến phần tử cuối cùng\r\n\r\nD. Phân đoạn dãy thành nhiều dãy con và lần lượt trộn hai dãy con thành dãy lớn hơn, cho đến khi thu được dãy ban đầu đã được sắp xếp",
                "Câu 7:\r\nHãy cho biết ý tưởng nào sau đây nói về phương pháp sắp xếp vun đống (Heap sort)?\r\nA. Tạo đống cho cây nhị phân (cây nhị phân đã được sắp xếp giảm dần)\r\n\r\nB. Lần lượt chia dãy phần tử thành hai dãy con bởi một phần tử khoá (dãy con trước khoá gồm các phần tử nhỏ hơn khoá và dãy còn lại gồm các phần tử lớn hơn khoá)\r\n\r\nC. Bắt đầu từ cuối dãy đến đầu dãy, ta lần lượt so sánh hai phần tử kế tiếp nhau, nếu phần tử nào nhỏ hơn được đứng vị trí trên\r\n\r\nD. Lần lượt tạo đống cho cây nhị phân (phần tử gốc có giá trị lớn nhất) và loại phần tử gốc ra khỏi cây đưa vào dãy sắp xếp\r\n",
                "Câu 8:\r\nTrong giải thuật sắp xếp vun đống, ta có 4 thủ tục con (Insert - thêm 1 phần tử vào cây; Downheap - vun đống lại sau khi loại một phần tử khỏi Heap, Upheap- vun đống sau khi thêm một phần tử vào cây; Remove - loại 1 phần tử khỏi cây nhị phân). Để sắp xếp các phần tử trong dãy theo phương pháp vun đống, ta thực hiện 4 thủ tục trên theo thứ tự như thế nào sau đây?\r\nA. Remove – Downheap – Insert – Upheap\r\n\r\nB. Insert – Upheap – Downheap – Remove\r\n\r\nC. Upheap – Downheap – Remove – Insert\r\n\r\nD. Insert – Upheap – Remove – Downheap",
                "Câu 9:\r\nHãy cho biết tư tưởng nào sau đây nói về của giải thuật tìm kiếm nhị phân?\r\nA. Lần lượt chia dãy thành hai dãy con dựa vào phần tử khoá, sau đó thực hiện việc tìm kiếm trên hai đoạn đã chia\r\n\r\nB. So sánh X lần lượt với các phần tử thứ nhất, thứ hai,... của dãy cho đến khi gặp phần tử có khoá cần tìm\r\n\r\nC. Tìm kiếm dựa vào cây nhị tìm kiếm\r\n\r\nD. Tại mỗi bước tiến hành so sánh X với phần tử ở giữa của dãy, dựa vào bước so sánh này quyết định giới hạn dãy tìm kiếm nằm ở nửa trên, hay nửa dưới của dãy hiện hành",
                "Câu 10:\r\nHãy cho biết tư tưởng nào sau đây nói về của giải thuật tìm kiếm tuần tự?\r\nA. So sánh X lần lượt với các phần tử thứ nhất, thứ hai,... của dãy cho đến khi gặp phần tử có khoá cần tìm\r\n\r\nB. Tìm kiếm dựa vào cây nhị tìm kiếm: Nếu giá trị cần tìm nhỏ hơn gốc thì thực hiện tìm kiếm trên cây con trái, ngược lại ta việc tìm kiếm được thực hiện trên cây con phải\r\n\r\nC. Lần lượt chia dãy thành hai dãy con dựa vào phần tử khoá, sau đó thực hiện việc tìm kiếm trên hai đoạn đã chia\r\n\r\nD. Tại mỗi bước tiến hành so sánh X với phần tử ở giữa của dãy, dựa vào bước so sánh này quyết định giới hạn dãy tìm kiếm nằm ở nửa trên, hay nửa dưới của dãy hiện hành",
                "Câu 11:\r\nHãy cho biết tư tưởng nào sau đây nói về của giải thuật tìm kiếm trên cây nhị phân tìm kiếm?\r\nA. Lần lượt chia dãy thành hai dãy con dựa vào phần tử khoá, sau đó thực hiện việc tìm kiếm trên hai đoạn đã chi\r\n\r\nB. So sánh X lần lượt với các phần tử thứ nhất, thứ hai,... của dãy cho đến khi gặp phần tử có khoá cần tìm\r\n\r\nC. Tìm kiếm dựa vào cây nhị tìm kiếm: Nếu giá trị cần tìm nhỏ hơn gốc thì thực hiện tìm kiếm trên cây con trái, ngược lại ta việc tìm kiếm được thực hiện trên cây con phải\r\n\r\nD. Tại mỗi bước tiến hành so sánh X với phần tử ở giữa của dãy, dựa vào bước so sánh này quyết định giới hạn dãy tìm kiếm nằm ở nửa trên, hay nửa dưới của dãy hiện hành",
                "Câu 12:\r\nHãy cho biết tính chất nào sau đây là của cây nhị phân tìm kiếm?\r\nA. Cây nhị phân mà mỗi nút trong cây đều thoả tính chất: giá trị của nút cha lớn hơn giá trị của hai nút con\r\n\r\nB. Là cây nhị phân đầy đủ\r\n\r\nC. Cây nhị phân thoả tính chất heap\r\n\r\nD. Cây nhị phân mà mỗi nút trong cây đều thoả tính chất: giá trị của nút cha nhỏ hơn mọi nút trên cây con trái và lớn hơn mọi nút trên cây con phải của nó",
                "Câu 13:\r\nCho cây nhị phân: A B C D E F. Cho biết thứ tự các phần tử được duyệt nào sau đây là đúng khi sử dụng phép duyệt cây theo thứ tự trước?\r\nA. A, B, D, C, F, E\r\n\r\nB. A, B, C, D, E, F\r\n\r\nC. A, B, D, E, C, F\r\n\r\nD. D, B, A, C, E, F",
                "Câu 14:\r\nCho cây nhị phân: A B C D E F. Cho biết thứ tự các phần tử được duyệt nào sau đây là đúng khi sử dụng phép duyệt cây theo thứ tự giữa?\r\nA. D, B, E, C, F, A\r\n\r\nB. A, B, D, C, E, F\r\n\r\nC. D, B, E, F, C, A\r\n\r\nD. D, B, E, A, C, F",
                "Câu 15:\r\nCho cây nhị phân: A B C D E F. Cho biết thứ tự các phần tử được duyệt nào sau đây là đúng khi sử dụng phép duyệt cây theo thứ tự sau?\r\nA. A, B, D, C, E, F\r\n\r\nB. D, B, E, F, A, C\r\n\r\nC. D, B, A, E, C, F\r\n\r\nD. D, E, B, F, C, A"
            };

            Questions question1 = new Questions(Quizzes[0], "C");
            Questions question2 = new Questions(Quizzes[1], "B");
            Questions question3 = new Questions(Quizzes[2], "B");
            Questions question4 = new Questions(Quizzes[3], "D");
            Questions question5 = new Questions(Quizzes[4], "D");
            Questions question6 = new Questions(Quizzes[5], "D");
            Questions question7 = new Questions(Quizzes[6], "D");
            Questions question8 = new Questions(Quizzes[7], "D");
            Questions question9 = new Questions(Quizzes[8], "D");
            Questions question10 = new Questions(Quizzes[9], "A");
            Questions question11 = new Questions(Quizzes[10], "B");
            Questions question12 = new Questions(Quizzes[11], "D");
            Questions question13 = new Questions(Quizzes[12], "C");
            Questions question14 = new Questions(Quizzes[13], "D");
            Questions question15 = new Questions(Quizzes[14], "D");

            Questions[] quizzes = { question1, question2, question3, question4, question5, question6, question7, question8, question9, question10, question11, question12, question13, question14, question15 };


            int rightAnswer = 0;
            int[] moneyAward =
            {
                200000,
                400000,
                600000,
                1000000,
                2000000,

                3000000,
                6000000,
                10000000,
                14000000,
                22000000,

                30000000,
                40000000,
                80000000,
                150000000,
                250000000

            };

            foreach (Questions i in quizzes)
            {
               

                Console.WriteLine(i.Question);
                Console.WriteLine("----------------------");
                if (rightAnswer > 0)
                {
                    Console.WriteLine("Nhấn nút X để dừng cuộc chơi và nhận ngay giải thưởng là {0}", moneyAward[rightAnswer - 1]);
                }

               
                Console.Write("Nhập câu trả lời: ");
                string input = Console.ReadLine();
                input = input.ToUpper();

                while (input != "A" && input != "B" && input != "C" && input != "D"&& input != "X"&&input!= "Q" && input != "W" && input != "E")
                {
                    Console.Write("Đáp án không hợp lệ. Hãy nhập lại đáp án khác: ");
                    input= Console.ReadLine();
                    input = input.ToUpper();
                }



                if(input == i.Answer)
                {
                    Console.WriteLine("CHÚC MỪNG !!! Bạn đã trả lời chính xác");
                    rightAnswer += 1;
                    Console.WriteLine("Bạn nhận được {0}", moneyAward[rightAnswer-1]);
                    Console.WriteLine("----------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (input == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Bạn nhận được số tiền thưởng là {0}", moneyAward[rightAnswer - 1]);
                    break;
                }
                else 
                {
                    Console.WriteLine("TIẾC QUÁ !!! Câu trả lời chính xác là{0}",i.Answer);
                    Console.WriteLine("Bạn nhận được {0}", moneyAward[rightAnswer - 1]);
                    break;
                }
                Console.Clear();    



            }
            Console.ReadKey();

            
            
        }
    }
            

    


        internal class Questions
        {
            private string question;
            private string answer;

            public string Question { get { return question; } }
            public string Answer { get { return answer; } }

            public Questions(string question, string answer)
            {
                this.question = question;
                this.answer = answer;
            }
        }
    }


