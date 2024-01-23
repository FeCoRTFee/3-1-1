using System;

namespace ConsoleApp6
{
    class Program
    {
        public static void WorkWithArray()
        {
            Console.WriteLine("если хотите ввести массив с клавиатуры введите 1 если рандомом то 0");
            int mod = Convert.ToInt32(Console.ReadLine());
            Array array;
            if (mod == 1)
            {
                array = new Array();
                array.Input();
            }
            else
            {
                Console.WriteLine("Введите кол-во элементов в массиве");
                int n = Convert.ToInt32(Console.ReadLine());
                array = new Array(n);
            }

            Console.WriteLine(array.Middle());
            int[] mas1 = array.Modul();
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();
            int[] mas = array.GetUniqueMas();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();


        }
        public static void WorkWithMatrix()
        {
            Console.WriteLine("если хотите ввести матрицу с клавиатуры введите 1 если рандомом то 0");
            int mod = Convert.ToInt32(Console.ReadLine());
            Matrix matrix;
            Console.WriteLine("Введите кол-во строк в массиве");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столцов в массиве");
            int n = Convert.ToInt32(Console.ReadLine());           
            if (mod == 1)
            {
                matrix = new Matrix();
                matrix.Input(s,n);
            }
            else
            {
                
                matrix = new Matrix(s,n);
            }
            Console.WriteLine(matrix.Middle());
            Console.WriteLine("Reverse matrix");
            matrix.ShowReverse();
            if(matrix.GetColumns() == 3 && matrix.GetRows() == 3)
            {               
                Console.WriteLine("matrix determinant \n" + matrix.GetDet(0));
            }

            
            

        }     
        public static void WorkWithStepArray()
        {
            StepArray stepArray;
            Console.WriteLine("если хотите ввести массив с клавиатуры введите 1 если рандомом то 0");
            int mod = Convert.ToInt32(Console.ReadLine());
            if (mod == 1)
            {
                stepArray = new StepArray();
                stepArray.Input();               
            }
            else
            {
                int rows = Convert.ToInt32(Console.ReadLine());
                stepArray = new StepArray(rows);
            }

            Console.WriteLine("Middle count \n" + stepArray.Middle());
            stepArray.MiddleInArray();
            Console.WriteLine("Change array");
            stepArray.Change();

        }
        static void Main(string[] args)
        {
            WorkWithArray();
            WorkWithMatrix();
            WorkWithStepArray();


        }
    }
}
