using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

  
namespace EtgLibrary
{
    public class SwitchAuth 
    {
    const    int r = 0;
      static void checklength(string str)
        {
       
            if (str.Contains('A'))
            {
                Console.WriteLine("String contains uppercase A");
            }
         
         
            switch (str.Length)
            {
                case 0:
                    Console.WriteLine("String is empty");
                    break;
                case 1:
                    Console.WriteLine("String has one character");
                    break;
                case 2:
                    Console.WriteLine("String has two characters");
                    break;
                default:
                    Console.WriteLine("String has more than two characters");
                    break;
            }
        }

    }
}
