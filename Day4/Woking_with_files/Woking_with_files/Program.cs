using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woking_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string write_text = "hello world";
            //File.WriteAllText("filename.text",write_text);

            //string read_text = File.ReadAllText("filename.text");
            //Console.WriteLine(read_text);

            //Directory.CreateDirectory(@"c:\temp\folder1");
            //var files = Directory.GetFiles(@"C:\Users\Nimap\Desktop\c# Basics\Day2", "*.sln", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var a = Directory.GetDirectories(@"C:\Users\Nimap\Desktop\c# Basics\Day2", "*.*", SearchOption.AllDirectories);
            foreach(var file in a)
            {
                Console.WriteLine(file);

            }

        }
    }
}
