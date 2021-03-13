using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleAppProject.App03
{
    public static class FileConfig
    {

        public static string directory1 = @"C:\ConsoleApps15\ConsoleAppProject\App03";

        public static void WriteToBinaryFile(string directory1, List<Student>Students)

        //public static void FileSave(List<Student> Students)
        {
            string serializationFile = Path.Combine(directory1, "student.bin");

            //serialize
            using Stream stream = File.Open(serializationFile, FileMode.OpenOrCreate);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            bformatter.Serialize(stream, Students);
        }

        public static List<Student> ReadFromBinaryFile(string directory1)

        //public static List<Student> ReadFile()
        {
            //deserialize
            using Stream stream = File.Open(directory1, FileMode.OpenOrCreate);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            return (List<Student>)bformatter.Deserialize(stream);

        }
    }
} 