using System;
namespace T1806E_CSharp
{
    public class SinhVien
    {
        public string name;
        public int age;
        public int mark;

        public SinhVien()
        {
            this.NhapThongTin();
            this.InThongTin();
            this.BaoKetQua();
        }

        public SinhVien(int x)
        {
            Console.WriteLine("day la constructor co tham so");
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem thi:");
            mark = Convert.ToInt32(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Diem thi: " + mark);
        }

        public void BaoKetQua()
        {
            if (mark >= 4)
            {
                Console.WriteLine("Sinh vien da qua mon");
                return;
            }
            Console.WriteLine("Sinh vien khong qua mon");
        }

        public static void Main(String[] args)
        {
            SinhVien sv = new SinhVien();
            sv.BaoKetQua();
          
        }
    }

}
