using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Lab01_ex1
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        // Constructor mac dinh
        public Lab01_ex1()
        {
            SID = 1;
            TenSV = "Nguyen Van A";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        // Constructor sao chep
        public Lab01_ex1(Lab01_ex1 stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        // Constructor co tham so
        public Lab01_ex1(int id, string tenSV, string khoa, float diemTB)
        {
            SID = id;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }
        //Cac property cho tung thuoc tinh
        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }
        public string Name
        {
            get { return TenSV; }
            set { TenSV = value.ToUpper(); }
        }
        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        // Phuong thuc hien thi du lieu
        public void show()
        {
            Console.WriteLine("Ma SV:{0} ", this.SID);
            Console.WriteLine("Ten SV:{0} ", this.TenSV);
            Console.WriteLine("Khoa:{0} ", this.Khoa);
            Console.WriteLine("Diem TB:{0} ", this.DiemTB);
        }

    }

    class Tester
    {
        //public static void Main(string[] args)
        //{
        //    Student[] DSSV;
        //    int n;
        //    Console.Write("Nhap so luong sinh vien: ");
        //    n = int.Parse(Console.ReadLine());
        //    DSSV = new Student[n];
        //    Console.WriteLine("\n ==== NHAP DS SINH VIEN ==== ");
        //    for (int i = 0; i < n; i++)
        //    {
        //        DSSV[i] = new Student();
        //        Console.Write("Nhap MaSV thu {0}: ", i + 1);
        //        DSSV[i].StudentID = int.Parse((string)Console.ReadLine());
        //        Console.Write("Nhap TenSV: ");
        //        DSSV[i].Name = Console.ReadLine();
        //        Console.Write("Nhap Khoa: ");
        //        DSSV[i].Faculty = Console.ReadLine();
        //        Console.Write("Nhap DiemTB: ");
        //        DSSV[i].Mark = float.Parse(Console.ReadLine());
        //        Console.WriteLine();
        //    }
        //    Xuat DS SInh Vien
        //    Console.WriteLine("\n ==== XUAT DS SINH VIEN ==== ");
        //    foreach (Student sv in DSSV)
        //    {
        //        sv.show();
        //        Console.WriteLine();
        //    }
        //}
    }
}
