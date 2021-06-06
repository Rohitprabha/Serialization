using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_and_Deserialization
{
    class Deserialization

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
