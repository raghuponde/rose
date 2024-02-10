using System;
using System.Collections.Generic;

namespace CMSApplication
{


  public class Program
  {
    static List<Student> studlist = new List<Student>();
    public static void Main(string[] args)
    {
      studlist.Add(new Student { Id = 101, Name = "Kirankumar"});
      studlist.Add(new Student { Id = 102, Name = "Suresh" });
      studlist.Add(new Student { Id = 101, Name = "Mohan" });


      foreach (Student st in studlist)
      {
        Console.WriteLine("{0}--{1}", st.Id, st.Name);
      }


    }



  }
}


