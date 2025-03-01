/*
Viết chương trình tính tiền điện phải trả dựa vào số kWh tiêu thụ và bảng giá.

Bảng giá:
Số kWh <= 100: 2000 đ/kWh
Từ kWh thứ 101 đến 150: 2500 đ/kWh
Từ kWh thứ 151 trở đi 3000 đ/kWh
Nếu số kWh tiêu thụ vượt quá 300 thì cộng thêm 10% tiền phải trả.

Input: Số kWh tiêu thụ
Output: Số tiền phải thanh toán (VND)
*/

using System;

namespace TinhTienDien
{
    class Program
    {
        // Khai báo các hằng 
        const int Muc1=100, Muc2=150, Muc3=300;
        const int Gia1=2000, Gia2=2500, Gia3=3000;

        static void Main()
        {
            int sokWh=0;
            double sotien=0;
            sokwh=int.parse(console.readline());
            if (sokwh<=Muc1){
                sotien=sokwh*Gia1;
            }
            else if (sokwh>Muc1 && sokwh<=Muc2){
                sotien = sokwh *Gia2;
            }
            else if (sokwh>Muc2 && sokwh <=Muc3){
                sotien=sokwh*Gia3;
            }
            else {
                sotien=(sokwh* Gia3)+((sokwh*Gia3)*(10.0/100));
            }
            console.writeline("So tien :{0}",sotien);

            // Input
            // Viết code của bạn để xử lý nhập số kWh tiêu thụ 
            
            // Process
            // Viết code của bạn để tính số tiền vào biến sotien
            // Chỉ tính số tiền, không in ra kết quả ở phần này

            // Output
            
        }
    }
}