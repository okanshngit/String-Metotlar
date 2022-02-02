using System;
namespace readymethodsofstring
{
    class Program
    {   
        static void Main (string[] args)
        {   

        string variable = "Lesson Csharp, Welcome" ;
        string varibale2 = "Csharp" ;
        //Length ;
        Console.WriteLine(variable.Length) ;

        //ToUpper and ToLower
        Console.WriteLine(variable.ToUpper());
        Console.WriteLine(variable.ToLower());

        //Concat
        Console.WriteLine(String.Concat(variable, "Merhaba"));

        //Compare, CompareTo

        Console.WriteLine(variable.CompareTo(varibale2)); //0,1, -1
        Console.WriteLine(String.Compare(variable, varibale2 , true)) ;
        Console.WriteLine(String.Compare(variable, varibale2 , false)) ;

        //Contains
        Console.WriteLine(variable.Contains(varibale2));
        Console.WriteLine(variable.EndsWith("Welcome"));
        Console.WriteLine(variable.StartsWith("Hello"));

        //IndexOf

        Console.WriteLine(variable.IndexOf("CS"));
        Console.WriteLine(variable.IndexOf("Baris"));
        Console.WriteLine(variable.LastIndexOf("i"));

        // Insert

        Console.WriteLine(variable.Insert(0, "Hello"));
        
        //PadLeft , PadRight

        Console.WriteLine(variable + varibale2.PadLeft(30)) ;
        Console.WriteLine(variable + varibale2.PadLeft(30,'*')) ;
        Console.WriteLine(variable.PadRight(50) + varibale2) ;
        Console.WriteLine(variable.PadRight(50, '-') + varibale2) ;

        //Remove

        Console.WriteLine(variable.Remove(10)) ;
        Console.WriteLine(variable.Remove(5,3)) ;
        Console.WriteLine(variable.Remove(0,1)) ;

        //Replace 

        Console.WriteLine(variable.Replace("CSharp" , "C#") ) ;
        Console.WriteLine(variable.Replace(" " , "+") ) ;

        //Split

        Console.WriteLine(variable.Split(' ')[1]) ;

        //Substring
        Console.WriteLine(variable.Substring(4)) ;
        Console.WriteLine(variable.Substring(4,6)) ;
        
    
            }
    }
}