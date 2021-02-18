using Dictionary;
using System;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> studentList = new MyDictionary<int, string>();

            studentList.Add(1 , "Yaren Alasan");
            studentList.Add(2, "Kunt Korali");
            studentList.Add(3,"Kartal Sonmez");
            studentList.Add(4, "Yasemin Karaduman");

            studentList.List();
        }
    }
}
