using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_and_Deserialization
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
    }
    class Serialization
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("test.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student();
            s.rollno = 10;
            s.name = "Rohit";
            formatter.Serialize(stream, s);

            stream.Close();
        }
    }
}
