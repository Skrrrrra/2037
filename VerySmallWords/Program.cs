using System;
using System.Collections.Generic;
using System.IO;

namespace VerySmallWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2037\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2037\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();


            //запись в строку содержимого 1 строки файла
           
            string secondline;
            using (var readersecond = new StreamReader(inputpath))
            {
                secondline = readersecond.ReadLine();  // записываем в переменную
            }

            string[] forstlineforint = secondline.Split(',');

            int Asize = forstlineforint.Length;

            string[] A;
            A = new string[Asize];

            string[] B;
            B = new string[Asize];


            int size;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine();
                size = Convert.ToInt32(readersecond.ReadLine());  // записываем в переменную
            }



            //запись элементов в А
            int count = 0;
            foreach (var s in forstlineforint)
            {
                if (count <= Asize)
                {
                    A[count] = s;
                    count++;
                }
            }
            //проверка на соответствие строке 2 из инпут файла
            int sizeofone = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sizeofone = A[i].Length;
                if(sizeofone >= size)
                {
                    B[i] = A[i];
                }
            }
            //запись в строку вывода
            count = 0;
            string outputstring = "";
            foreach (var s in B)
            {
                if (count <= B.Length)
                {
                    outputstring = outputstring + B[count] + ',';
                    count++;
                }
            }


            //удаление ненужных запятых из строки вывода
            char[] MyChar = {','};
            for (int i = 0; i < size; i++)
            {
                outputstring = outputstring.TrimStart(MyChar);
                outputstring = outputstring.TrimEnd(MyChar);

            }
            File.WriteAllText(outputpath, outputstring);
        }
    }
}
