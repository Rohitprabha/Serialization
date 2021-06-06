using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Deserialization_Example
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("test.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
}
