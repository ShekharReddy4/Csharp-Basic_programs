using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    class FileIo
    {
        static void Main(string[] args)
        {
            //string path = @"next.txt";
            //string msg = "some msf";
            //Console.WriteLine("file has been written into");

            //using (StreamWriter file = File.AppendText(path))
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        file.WriteLine(DateTime.Now.ToString() + " " + msg);
            //        Console.WriteLine("written line {0}", i + 1);

            //    }
            //}
            //Console.WriteLine("file has been written into");

            // Donno why .txt files are throwing the access denied exception

            FileStream F = new FileStream("test2.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }

            F.Close();
        }
    }
}
