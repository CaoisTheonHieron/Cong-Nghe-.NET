using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_ex3
{
    internal class Lab01_ex3
    {
        //lớp cơ sở 
        class Person
        {
            private string FullName;
            private int BirthYear;
            private string Degree;

            public string FullName1 { get => FullName; set => FullName = value; }
            public int BirthYear1 { get => BirthYear; set => BirthYear = value; }
            public string Degree1 { get => Degree; set => Degree = value; }

            public Person()
            {
                FullName = "Nguyen Van A";
                BirthYear = 1990;
                Degree = "Dai hoc";
            }
            public Person(string fullName, int birthYear, string degree)
            {
                FullName = fullName;
                BirthYear = birthYear;
                Degree = degree;
            }
            public virtual void Display()
            {
                Console.WriteLine($"Họ tên: " + FullName);
                Console.WriteLine($"Năm sinh: " + BirthYear);
                Console.WriteLine($"Bằng cấp: " + Degree);
            }
            public override string ToString()
            {
                return $"Họ tên: {FullName}, Năm sinh: {BirthYear}, Bằng cấp: {Degree}";
            }

            //lớp student kế thừa từ lớp Person
            class Student : Person
            {
                private int studentID;
                private string faculty;
                private float mark;

                public int StudentID { get => studentID; set => studentID = value; }
                public string Faculty { get => faculty; set => faculty = value; }
                public float Mark { get => mark; set => mark = value; }

                public Student() : base()
                {
                    studentID = 1;
                    faculty = "A";
                    mark = 7.0f;
                }
                public Student(int id, string fullName, int birthYear, string degree, string faculty, float mark)
                    : base(fullName, birthYear, degree)
                {
                    StudentID = id;
                    Faculty = faculty;
                    Mark = mark;
                }
                public override void Display()
                {
                    Console.WriteLine("================================");
                    Console.WriteLine($"MSSV: {StudentID}");
                    base.Display();
                    Console.WriteLine($"Khoa: {Faculty}");
                    Console.WriteLine($"Điểm TB: {Mark}");
                    Console.WriteLine("================================");
                }
                public override string ToString()
                {
                    return $"MSSV: {StudentID}, Khoa: {Faculty}, Điểm TB: {Mark}";
                }

                public void InputData()
                {
                    Console.Write("Nhập MSSV: ");
                    StudentID = int.Parse(Console.ReadLine());
                    Console.Write("Nhập Họ tên: ");
                    FullName1 = Console.ReadLine();
                    Console.Write("Nhập Năm sinh: ");
                    BirthYear1 = int.Parse(Console.ReadLine());
                    Console.Write("Nhập Bằng cấp: ");
                    Degree1 = Console.ReadLine();
                    Console.Write("Nhập Khoa: ");
                    Faculty = Console.ReadLine();
                    Console.Write("Nhập Điểm TB: ");
                    Mark = float.Parse(Console.ReadLine());
                }

                class Tester
                {
                    // Phuong thuc nhap mot sinh vien
                    private static Student InputOneStudent(int index)
                    {
                        Console.WriteLine($"Nhap thong tin sinh vien thu {index + 1}");
                        Student st = new Student();
                        st.InputData();
                        return st;
                    }

                    // Phương thức nhập danh sách sinh viên
                    private static ArrayList InputStudentList(int n)
                    {
                        ArrayList students = new ArrayList();
                        for (int i = 0; i < n; i++)
                        {
                            students.Add(Tester.InputOneStudent(i));
                            Console.WriteLine();
                        }
                        return students;
                    }

                    // Phương thức xuất danh sách sinh viên
                    private static void DisplayStudentList(ArrayList students)
                    {
                        Console.WriteLine("\n\n====== DANH SÁCH SINH VIÊN ======");
                        int i = 1;
                        foreach (Student student in students)
                        {
                            Console.WriteLine($"\n--- Sinh viên thứ {i++} ---");
                            student.Display();
                        }
                    }

                    //CalculateAverageMark of All Students

                    private static float CalculateAverageMark(ArrayList students)
                    {
                        float totalMark = 0;
                        foreach (Student student in students)
                        {
                            totalMark += student.Mark;
                        }
                        return totalMark / students.Count;
                    }

                    //Find Student by name (student / null)
                    private static Student FindStudentByName(ArrayList students, string name)
                    {
                        foreach (Student student in students)
                        {
                            if (student.FullName1.Equals(name, StringComparison.OrdinalIgnoreCase))
                            {
                                return student;
                            }
                        }
                        return null; // Trả về null nếu không tìm thấy
                    }


                    public static void Main(string[] args)
                    {
                        Console.OutputEncoding = Encoding.UTF8; // Hiển thị tiếng Việt có dấu

                        Console.Write("Nhập vào số lượng SV: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        // 1. Nhập và xuất danh sách
                        ArrayList DSSV = InputStudentList(n);
                        DisplayStudentList(DSSV);

                        // 2. Tính điểm trung bình cộng của cả lớp
                        float avg = CalculateAverageMark(DSSV);
                        Console.WriteLine($"\n==> Điểm trung bình của tất cả SV: {avg:F2}");

                        // 3. Tìm kiếm sinh viên
                        Console.Write("\nNhập tên sinh viên cần tìm: ");
                        string findName = Console.ReadLine();
                        Student found = FindStudentByName(DSSV, findName);

                        if (found != null)
                        {
                            Console.WriteLine("\n--- Kết quả tìm thấy ---");
                            found.Display();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên có tên này.");
                        }
                    }
                }
            }
        }
    }
}
