using System;


namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int quantity = 0;
                Console.Write("Введите количество элементов в массиве: "); quantity = Convert.ToInt32(Console.ReadLine());
                Auto[] Autos = new Auto[quantity];
                Auto.Read(Autos);
                Auto.Sort(Autos);
                Auto.Write_rezult(Autos);
            }
          catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
