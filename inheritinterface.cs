using System;
using System.Collections;

namespace interinherit
{
    interface lang { 
    void languages(); 
} 
  
class sub1 : lang { 
  
    
    public void languages() 
    { 
  
        
        ArrayList My_list = new ArrayList(); 
  

        My_list.Add("C"); 
        My_list.Add("C++"); 
        My_list.Add("C#"); 
        My_list.Add("Java"); 
  
        Console.WriteLine("Languages provided by GeeksforGeeks:"); 
        foreach(var elements in My_list) 
        { 
            Console.WriteLine(elements); 
        } 
    } 
} 
  

interface course { 
    void courses(); 
} 

class sub2 : course { 
  
    
    public void courses() 
    { 
  
        ArrayList My_list = new ArrayList(); 
  
       
        My_list.Add("System Design"); 
        My_list.Add("Fork Python"); 
        My_list.Add("Classes DSA"); 
        My_list.Add("Fork Java"); 
  
        Console.WriteLine("\nCourses provided are:"); 
        foreach(var elements in My_list) 
        { 
            Console.WriteLine(elements); 
        } 
    } 
} 
  

class subject: lang, course { 
  
   
    sub1 obj1 = new sub1(); 
    sub2 obj2 = new sub2(); 
  
    public void languages() 
    { 
        obj1.languages(); 
    } 
  
    public void courses() 
    { 
        obj2.courses(); 
    } 
}  
    class Program:subject
    {
        static void Main(string[] args)
        {
           Program obj = new Program(); 
        obj.languages(); 
        obj.courses(); 
        }
    }
}


