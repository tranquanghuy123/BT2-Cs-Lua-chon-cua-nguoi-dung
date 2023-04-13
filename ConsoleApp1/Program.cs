using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void hamnhap(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu["+i+"]");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void hamxuat(int[] arr, int n)
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //ham tinh tong các phan tu trong mang
        static void sum(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum: " + sum);
        }
        //In ra màn hình tất cả các số >= 0 và <= 10 trong mảng
        static void So(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 0 && arr[i] <= 10)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        //Sắp xếp tăng
        static void SapXepTang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Mang sau khi sap xep tang : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //In ra màn hình số lớn nhất
        static void Max(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max: " + max);
        }
        // In ra màn hình số nhỏ nhất trong mảng
        static void Min(int[] arr, int n)
        {
            int min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min: " + min);
        }
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[10];
            Console.Write("Nhap so phan tu cho mang: ");
            n = Int32.Parse(Console.ReadLine());
            hamnhap(a, n);
            hamxuat(a, n);

            Console.WriteLine("============    Cac phep tinh   ============");
            Console.WriteLine("1. Tinh tong cac phan tu trong mang");
            Console.WriteLine("2. In ra man hinh cac so >=0 & <=10");
            Console.WriteLine("3. In ra man hinh day sap xep tang");
            Console.WriteLine("4. MAX, MIN cua mang");
            Console.WriteLine("=========================");

            Console.Write("Moi ban chon: ");
           int choice = Int32.Parse(Console.ReadLine());

            switch(choice) 
            {
                case 1:
                    Console.WriteLine("Tong cac phan tu trong mang: ");
                        sum (a, n);
                       break;
                case 2:
                    Console.WriteLine("Cac so >=0 & <=10: ");
                    So (a, n);
                    break;
                case 3:
                    Console.WriteLine("Day sap xep tang cua mang ");
                    SapXepTang(a, n);
                    break;
                case 4:
                    Console.WriteLine("MAX, MIN cua mang ");
                    Min(a, n);
                    Max (a, n);
                    break;
                default:
                    Console.WriteLine("Xin moi nhap lai tu 1 den 4");
                    break;
            }

        }
    }
}
