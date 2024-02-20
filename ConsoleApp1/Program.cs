using System;

using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\David\Desktop\UNI 2023-2024\PGTA\P2\230502-est-080001_BCN_60MN_08_09.ast";
            Console.WriteLine("Hello World!");
            using (StreamReader sr = new StreamReader(filePath))
            {
                string linea;
                // Lee y muestra cada línea del archivo
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
    }
}
