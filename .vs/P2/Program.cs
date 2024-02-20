using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace P2
{
   class Program
    {
        static void Main(string[] args)
        {
            //          string filePath = @"C:\Users\David\Desktop\UNI 2023-2024\PGTA\P2\230502-est-080001_BCN_60MN_08_09.ast";
            string filePath = @"C:\Users\polro\Desktop\PGTA\230502-est-080001_BCN_60MN_08_09.ast";
            Console.WriteLine("Hello World!");

            // Abre el archivo para lectura utilizando StreamReader
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Lee todo el contenido del StreamReader y conviértelo a bytes
                string fileContent = sr.ReadToEnd();
                byte[] bytes = Encoding.UTF8.GetBytes(fileContent);

                // Imprime el contenido del archivo
                Console.WriteLine(bytes[47]);
            }
        }
    }
}
