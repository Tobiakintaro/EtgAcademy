using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EtgAcademy2026
{
    internal static class Weeks2
    {

        //Conditional Statements

        static void CheckNumberWithIf(int number)
        {
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is positive and even.");
                }
                else
                {
                    Console.WriteLine("The number is positive and odd.");
                }

                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            if ((number > 0) && (number % 2 == 0))
            {
                Console.WriteLine("The number is positive and even.");
            }
            else if ((number > 0) && (number % 2 != 0))
            {
                Console.WriteLine("The number is positive and odd.");
            }
            else if ((number < 0) && (number % 2 == 0))
            {
                Console.WriteLine("The number is negative and even.");
            }
            else if ((number < 0) && (number % 2 != 0))
            {
                Console.WriteLine("The number is negative and odd.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }


            if (number > 0)
            {


            }

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }



        }

        //Switch Statement
        static void CheckNumberWithSwitch(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero.");
                    break;
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                default:
                    Console.WriteLine("The number is greater than two or less than zero.");
                    break;
            }

        }

        //other ways of switch statement

        static void CheckNumberWithSwitchExpression(int number)
        {
            string result = number switch
            {
                0 => "The number is zero.",
                1 => "The number is one.",
                2 => "The number is two.",
                _ => "The number is greater than two or less than zero."
            };
            Console.WriteLine(result);
        }

        static ResponseHeader GetResponseHeader(int responseCode)
        {
            return responseCode switch
            {
                200 => new ResponseHeader { ResponseCode = "200", ResponseMessage = "OK" },
                400 => new ResponseHeader { ResponseCode = "400", ResponseMessage = "Bad Request" },
                404 => new ResponseHeader { ResponseCode = "404", ResponseMessage = "Not Found" },
                500 => new ResponseHeader { ResponseCode = "500", ResponseMessage = "Internal Server Error" },
                _ => new ResponseHeader { ResponseCode = responseCode.ToString(), ResponseMessage = "Unknown" }
            };
        }


        //Ternary Operator
        static void CheckNumberWithTernaryOperator(int number)
        {
            string result = (number > 0) ? "The number is positive." : (number < 0) ? "The number is negative." : "The number is zero.";
            Console.WriteLine(result);

            CheckNumberWithNullCoalescingOperator();

        }



        //Null Coalescing Operator
        static void CheckNumberWithNullCoalescingOperator(int? number = null)
        {
            int result = number ?? 0;
            Console.WriteLine($"The number is {result}.");
        }

        //Null Coalescing Assignment Operator
        static void CheckNumberWithNullCoalescingAssignmentOperator(int? number = null)
        {
            number ??= 0;
            Console.WriteLine($"The number is {number}.");
        }

        //Pattern Matching
        static void CheckNumberWithPatternMatching(object obj)
        {
            if (obj is int number)
            {
                Console.WriteLine($"The number is {number}.");
            }
            else if (obj is string str)
            {
                Console.WriteLine($"The string is {str}.");
            }
            else
            {
                Console.WriteLine("The object is neither an integer nor a string.");
            }
        }

        //Loops
        static void CheckNumberWithForLoop(int number)
        {
            var R = new MyClaas();

            var T = R.ResponseHeader!.ResponseCode;

            var Y = R.ResponseHeader.ResponseCode;


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"The number is {i}.");
            }


            var responseHeader = new ResponseHeader
            {
                ResponseCode = "200",
                ResponseMessage = "OK"
            };

            var response = responseHeader.ResponseCode;
        }

        //foreach
        static void ForeachLoop()
        {
            string[] arr = { "e", "r", "t" };
            foreach (var i in arr)
            {
                if (i == "e")
                {

                    break;
                    // continue;


                }


            }
        }
        //while loop
        static void WhileMethod()
        {
            int i = 0;
            while (true)
            {
                i++;



                if (i == 3) break;
            }


            while (i <= 3)
            {



            }

            var Resiltt = DoSomething2(null);
            var tt = Resiltt.num;
            var ttt = Resiltt.ResponseHeader;
        }

        static private ResponseHeader DoSomething(int num, DosomethingRequest request)
        {
            return GetResponseHeader(200);
        }

        static private ResponseHeader DoSomething(DosomethingRequest request)
          => GetResponseHeader(400);


        static private (int num, ResponseHeader ResponseHeader) DoSomething2(DosomethingRequest request)
        {
            return (2, GetResponseHeader(200));

        }


        //string manipulation
        static private void StringWorks()
        {
            string str = "1234567890";

            var t = str.Replace("12", "xy");
            var tt = str.Insert(5, "abc");
            var ttr = str.Remove(3,2);


        }




    }

    class ResponseHeader
    {
        public string? ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
    }


    class DosomethingRequest
    {
        public decimal Amount { get; set; }

        public RequestHeader? RequestHeader { get; set; }
    }

    class RequestHeader
    {
        public required string Signature { get; set; }
        public long Timestamp { get; set; }

    }

    //While loop






    class MyClaas
    {
        public ResponseHeader? ResponseHeader { get; set; }
    }
}
