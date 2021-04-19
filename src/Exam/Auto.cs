using System;
using System.IO;

namespace Exam
{
    class Auto
    {
       private string mark;
       private string model;
       private double price;

        public string Mark
        {
            get => this.mark;
            set
            {
                this.mark = value;
            }
        }
        public string Model
        {
            get => this.model;
            set
            {
                this.model = value;
            }
        }
        public double Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }
        public static bool operator >(Auto a, Auto b)
        {
            if (string.Compare(a.Mark, b.Mark) == -1) return true;
            else if (string.Compare(a.Mark, b.Mark) == 1) return false;
            else if (a.Price > b.Price) return true;
            else return false;
        }
        public static bool operator <(Auto a, Auto b)
        {
            if (string.Compare(a.Mark, b.Mark) == 1) return true;
            else if (string.Compare(a.Mark, b.Mark) == -1) return false;
            else if (a.Price < b.Price) return true;
            else return false;
        }
        public static Auto[] Read( Auto[] Autos)
        {           
            for (int i = 0; i < Autos.Length; i++)
            {
                Autos[i] = new Auto();
                Console.Write("Введите марку автомобиля: ");
                Autos[i].Mark = Console.ReadLine();
                Console.Write("Введите можель автомобиля: ");
                Autos[i].Model = Console.ReadLine();
                Console.Write("Введите цену автомобиля: ");
                Autos[i].Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            return Autos;
        }
        public static Auto[] Sort(Auto[] Autos)
        {
            for (int i = 0; i < Autos.Length; i++)
            {
                for (int j = 0; j < Autos.Length; j++)
                    if (Autos[i] > Autos[j])
                    {
                        Auto temp = Autos[i];
                        Autos[i] = Autos[j];
                        Autos[j] = temp;
                    }
            }
            return Autos;
        }
        public static void Write_rezult(Auto[] Autos)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Users\stu-pksp117\Desktop\rezults.txt"/*, false, System.Text.Encoding.Default*/))
            {
                foreach (Auto a in Autos)
                {
                    sw.WriteLine($"Марка: {a.Mark}\nМодель:{a.Model}\nЦена:{a.Price}\n\n\n");
                }
            }
          //  System.Diagnostics.Process.Start(@"D:\Users\stu-pksp117\Desktop\rezults.txt");
        }
    }
}
