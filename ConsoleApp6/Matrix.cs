using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix
{
    int[,] mas;
    int rows;
    int columns; 
    public Matrix (int[,] mas)
    {
        this.mas = mas;
    }
    public Matrix()
    {

    }
    public Matrix(int rows,int columns)
    {
        this.rows = rows;
        this.columns = columns;
        mas = new int[rows,columns];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                mas[i, j] = rnd.Next(-1001, 1001);
            }           
        }
    }
    public int GetRows()
    {
        return rows;
    }
    public int GetColumns()
    {
        return columns;
    }


    public void Input(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        mas = new int [rows, columns];
        Console.WriteLine("enter matrix");
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {            
                int a = Convert.ToInt32(Console.ReadLine());
                mas[i, j] = a;
            }
        }

    }
    public double Middle()
    {
        Console.WriteLine("Average value in matrix ");
        double s = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                s += mas[i, j];
            }
        }
        double result = s / (columns * rows);
        return result;

    }
    public void Show()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine(mas[i, j]);
            }
        }
    }
    public void ShowReverse()
    {
        for (int i = 0; i< rows; i++)
        {
            if (i % 2 == 0)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
            }
            else
            {
                for(int j = columns - 1; j >= 0; j--)
                {
                    Console.Write(mas[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    public double GetDet(int k)
    {
        double det = 0;
        // c и k это индексы рассматримаего элемента
        for(int c = 0; c < columns ;c++)
        {
            // рассматриваем каждый квадрат
            List<int> square = new List<int>();
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(k!=i && c != j)
                    {
                        square.Add(mas[i, j]);
                    }

                }

            }
            int minor = square[0] * square[3] - square[1] * square[2];
            double additional = Math.Pow(-1, c + k) * minor;
            double value = additional * mas[c, k];
            det += value;

        }
        return det;

        



    }


}

