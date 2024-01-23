using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StepArray
{
    int[][] mas;
    int rows;
    public StepArray(int[][] mas)
    {
        this.mas = mas;
    }
    public StepArray()
    {

    }
    public StepArray(int rows)
    {
        this.rows = rows;
        int[][] mas = new int[rows][];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            int columns = rnd.Next(1, 10);
            int[] smas = new int[columns];
            for(int j = 0; j < smas.Length; j++)
            {
                smas[j] = rnd.Next(-1001, 1001);
            }
            mas[i] = smas;
        }


    }
    public void Input()
    {
        Console.WriteLine("enter count of lines");
        rows = Convert.ToInt32(Console.ReadLine());
        mas = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Enter the line");
            string line = Console.ReadLine();
            string[] elements = line.Split(' ');
            int[] mas1 = new int[elements.Length];
            for (int j = 0; j < mas1.Length; j++)
            {
                mas1[j] = Int32.Parse(elements[j]);

            }
            mas[i] = mas1;

        }
        
    }
    public void Show()
    {
        foreach (int[] row in mas)
        {
            foreach(int number in row)
            {
                Console.WriteLine(number);

            }
            Console.WriteLine();
        }
    }
    public double Middle()
    {
        double s = 0;
        int c = 0;
        foreach (int[] row in mas)
        {
            foreach (int number in row)
            {
                s += number;
                c++;

            }
           
        }
        return s /= c;

    }
    public void MiddleInArray()
    {
        
        foreach (int[] row in mas)
        {
            int c = 0;
            double s = 0;
            foreach (int number in row)
            {
                s += number;
                c++;

            }
            Console.WriteLine("Middle count in small array " + s/c);

        }
    }
    public void Change()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < mas[i].Length; j++)
            {
                if (mas[i][j] % 2 == 0)
                {
                    mas[i][j] = i * j;
                }
                Console.Write(mas[i][j]);
            }
            Console.WriteLine();
        }
    }
}

