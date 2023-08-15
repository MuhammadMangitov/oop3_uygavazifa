
// TASK - 1;

/*namespace oop3_uyishi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(11.1,10.1);
            r.CalculateArea();
            r.CalculatePerimetr();
            Console.WriteLine();

            Rectangle r1 = new Rectangle();
            r1.CalculateArea();
            r1.CalculatePerimetr();
            Console.WriteLine();

            Circle c = new Circle(2.1);
            c.DisplayInfo();
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
            Width = 1.13;
            Height = 1.12;
        }
        public void CalculateArea()
        {
            Console.WriteLine("Yuza = " + (Width * Height));
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("Perimetr = " + (2 * (Width + Height)));
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double  CalculateArea()
        {
            return (3.14 * Radius * Radius); 
        }

        public double CalculatePerimetr()
        {
            return (2 * CalculateArea());
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Aylana yuza = " + CalculateArea() + "\n" +  "Aylana perimetr = " + CalculatePerimetr());
        }
    }

}*/





//          task - 2;

/*
using System.Collections.Generic;

namespace oop3_uyishi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studen = new Student();
            studen.DisplayInfo();
            Console.WriteLine("Ortacha baho : " + studen.AverageGrade());
            Console.WriteLine();

            Employee xodim = new Employee(1_300_000);
            xodim.DisplayInfo();
            Console.WriteLine("Xodimning oygigini 13 % = " + xodim.CalculateTax());
            Console.WriteLine();

            Teacher teacher = new Teacher(66_666);
            teacher.DisplayInfo();
            Console.WriteLine("Oqituvchining ou=ylik maoshi = " + teacher.CalculateMontlyIncome());

        }
    }

    class School
    {
        public string FullName { get; set;}
        public string Id { get; set;}
        public string PhoneNumber { get; set;}

        public void DisplayInfo()
        {
            Console.WriteLine($"ism familya : {FullName}\nId : {Id} \nPhonenumber : {PhoneNumber}");
        }
    }
    class Student : School
    {

        public Student()
        {
            FullName = "Javlonjon Alimov";
            Id = "A01";
            PhoneNumber = "91 16622 34";
        }
        public double AverageGrade()
        {
            double[] a = {3, 4, 5, 5, 4};
            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum / a.Length;
        }
    }

    class Employee : School
    {
        public double Oylik { get; set; }
        public Employee(double oylik)
        {
            Oylik = oylik;
            FullName = "Qodirali";
            Id = "01ak";
            PhoneNumber = "90 111 11 11";
        }

        public double CalculateTax()
        {
            return Oylik * 0.13;
        }
    }

    class Teacher : School
    {
        public double HourlyRate { get; set; }

        public Teacher(double hourlyRate)
        {
            HourlyRate = hourlyRate;
            FullName = "Tursunxon Asadov";
            Id = "09wq";
            PhoneNumber = "99 123 45 67";
        }

        public double CalculateMontlyIncome()
        {
            return HourlyRate * 120;
        }
    }
}
*/