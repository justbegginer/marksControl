using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников");
            int numbersOfStudents = Convert.ToInt32(Console.ReadLine());
            Students[] students = new Students[numbersOfStudents];
            for (int counter = 0 ; counter<numbersOfStudents ; counter++)
            {
                 students[counter]= new Students(); 
            }
            float max = 0;
            int counterGlobal = 0;
            float intermidiate;
            for (int counter = 0 ; counter<students.Length ; counter++)
            {
                if (students[counter].middleMark>max)
                {
                    max = students[counter].middleMark;
                    counterGlobal = counter;
                }
            }
            //for (int counter = 0; counter < students.Length ; counter++)
            //{
            //    intermidiate = 0;
            //    for (int count = 0 ; count < students[counterGlobal].Marks.Length ; count++)
            //    {
            //        intermidiate += students[counterGlobal].Marks[count];
            //    }
            //    intermidiate /= students[counterGlobal].Marks.Length;
            //    if (intermidiate > max)
            //    {
            //        max = intermidiate;
            //        counterGlobal = counter;
            //    }
            //}
            Console.WriteLine("Самый лучший ученик -"+students[counterGlobal].name+" со средним баллом "+Math.Round(max,2));
            Console.ReadKey();
        }
    }
    class Students
    {
        public string name;
        public int[] Marks;
        public float middleMark = 0;
        public Students()
        {
            Console.WriteLine("Введите имя ученика");
            name = Console.ReadLine();
            MarksGenerate();
        }
        private void MarksGenerate()
        {
            Random random = new Random();
            int count = random.Next(2, 10);
            Marks = new int[count];
            Console.WriteLine("Введите метод проставления оценок \n 0-автоматически \n 1-вручную");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            switch (choice)
            {
                case 0:
                    Auto_Generate(random);
                    break;
                case 1:
                    Self_Generate();
                    break;
            }
            MiddleMarkGenerate();
        }
        private void Auto_Generate(Random random)
        {          
           
            for (int counter = 0 ; counter<Marks.Length ; counter++)
            {
                Marks[counter] = random.Next(2,5);
                Console.Write(Marks[counter]+"  ");
            }
            Console.WriteLine();

        }
        private void Self_Generate()
        {
            for (int counter = 0 ; counter<Marks.Length ; counter++)
            {
                Marks[counter] = Convert.ToInt32(Console.ReadLine());
                //Console.Write(Marks[counter] + "  ");
            }
        }
        private void MiddleMarkGenerate()
        {
            
            for (int counter = 0 ; counter<Marks.Length ; counter++)
            {
                middleMark += Marks[counter];
            }
            middleMark /= Marks.Length;
        }
    }

}
