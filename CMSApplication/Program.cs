using System;
using System.Collections.Generic;
using CMSModel;
namespace CMSApplication
{


  public class Program
  {
    static List<Student> studlist = new List<Student>();

    
    public   static void Main(string[] args)
    {

      Console.WriteLine("adding new line")
      studlist.Add(new Student { Id = 101, Name = "Kirankumar"});
      studlist.Add(new Student { Id = 102, Name = "Sureshraine" });
      

      foreach (Student st in studlist)
      {
        Console.WriteLine("{0}--{1}", st.Id, st.Name);
      }


    }



  }
}


