using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            double ketQua = 0;
            
            // Input: Không thay đổi phần này
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            // Xử lý phép toán
            switch (phepToan)
            {
                case '+':
                    ketQua = a + b;
                    break;
                case '-':
                    ketQua = a - b;
                    break;
                case '*':
                    ketQua = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    ketQua = (double)a / b;
                    break;
                default:
                    Console.WriteLine("Phép toán không hợp lệ!");
                    return;
            }

            // Output: In kết quả lên màn hình
            Console.WriteLine($"Ket qua: {a} {phepToan} {b} = {ketQua}");
        }
    }
}
