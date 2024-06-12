using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShapeshifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Create random data to write to the stream.
            //byte[] dataArray = new byte[300];
            //new Random().NextBytes(dataArray);
            //using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\repository\\ConsoleShapeshifter\\ConsoleShapeshifter\\publish\\Application Files\\" + InputFile, FileMode.Truncate)))
            //{
            //    writer.Write(dataArray);
            //}

            if (args.Length != 2)
            {
                Console.WriteLine("Введите имена входного и выходного файлов");
                Console.ReadKey();
            }
            else
            {
                string InputFile = args[0];//"input.dat";
                string OutputFile = args[1];//"output.dat"
                try
                {
                    byte[] fileBytes = File.ReadAllBytes("..\\" + InputFile);
                    Console.WriteLine("Копирование начато...");
                    using (BinaryWriter writer = new BinaryWriter(File.Open("..\\" + OutputFile, FileMode.Create)))
                    {
                        int i = fileBytes.Length - 1;
                        for (; i != 0; i--)
                        {
                            writer.Write(fileBytes[i]);
                        }
                        Console.WriteLine("Копирование завершено.");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }   
            }
        }
    }
}
