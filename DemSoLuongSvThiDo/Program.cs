using System;

namespace DemSoLuongSvThiDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bước 1: Khai báo các biến, nhập và kiểm tra kích thước mảng

            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Size should not exceed 30");

            } while (size > 30);
            //Thực thi chương trình

            //Bước 2: Nhập giá trị cho các phần tử của mảng

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                do {
                    Console.WriteLine("Enter a mark for student " + (i + 1) + ": ");
                    array[i] = Int32.Parse(Console.ReadLine());
                } while (array[i] > 10);  // NHẬP ĐIỂM QUÁ 10 BẮT NHẬP LẠI 
                i++;
            }
            //Thực thi chương trình

            //Bước 3: Sử dụng vòng lặp for để in ra danh sách điểm vừa nhập, đồng thời đếm số lượng sinh viên thi đỗ

            int count = 0;
            Console.WriteLine("List of mark: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10) //PASSING KHI CÓ ĐIỂM TRÊN 5 DƯỚI 10 
                    count++;
            }
            Console.WriteLine("\n The number of students passing the exam is " + count);
        }
    }
}
