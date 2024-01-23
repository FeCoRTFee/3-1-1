using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Array
{
    int[] mas;
    public Array(int[] mas)
    {
        this.mas = mas;
    }
    public Array(int len)
    {
        mas = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < len; i++)
        {

            mas[i] = rnd.Next(-1001, 1001);
        }
    }
    public Array()
    {

    }
    public void Input()
    {
        Console.WriteLine("Enter count of elements");
        int len = Convert.ToInt32(Console.ReadLine());
        mas = new int[len];
        Console.WriteLine("Enter mas");
        for (int i = 0; i < len; i++)
        {
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    public void Show()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
    public double Middle()
    {
        Console.WriteLine("Middle number ");
        double sum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            sum += mas[i];

        }
        return sum / mas.Length;
    }
    public int[] Modul()
    {
        Console.WriteLine("mas<100");
        int count = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] <= 100 && mas[i] >= -100)
            {

                count++;
            }
        }
        int[] newmas = new int[count];
        int index = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] <= 100 && mas[i] >= -100)
            {
                newmas[index] = mas[i];
                index++;
            }
        }
        return newmas;

    }
    public bool CanAdd(int[] masbuffer, int n)
    {
        for (int i = 0; i < masbuffer.Length; i++)
        {
            if (n == masbuffer[i])
            {
                return false;
            }
        }
        return true;
    }
    public int GetUniqueCount()
    {
        int count = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[i] == mas[j] && i < j)
                {
                    count++;

                }
            }
        }
        return mas.Length - count;


    }
    public int[] GetUniqueMas()
    {
        Console.WriteLine("Unique mas");
        int new_len = GetUniqueCount();
        int[] new_mas = new int[new_len];
        int j = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (CanAdd(new_mas, mas[i]))
            {
                new_mas[j] = mas[i];
                j++;
            }

        }
        return new_mas;
    }


}

