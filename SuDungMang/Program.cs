using System;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {

            KhaiBaoMang();
            XuatMangRaManHinh();
            XuatSoChanTrongMang();
        }

        private static void XuatSoChanTrongMang()
        {
            int[] a = { 2342, 23, 42342, 34, 234, 23 };
            for (int i = 0; i < a.Length; i++)
            {

            }
        }

        private static void XuatMangRaManHinh()
        {
            int[] a = { 23, 423, 2, 2, 3, 23, 23, 421, 3413, 42 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void KhaiBaoMang()
        {
            int[] a = { 23, 23, 2, 2, 32, 2, 32, 12};
            int[] b= new int[4];
        }
    }
}
