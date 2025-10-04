using EtgAcademy2025.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    public class ErrorHandling
    {
        static StreamReader sr;



        static private string ReverseString(string str)
        {

            var strArr = str.ToCharArray();
            var revStrArr = strArr.Reverse();
            return string.Concat(revStrArr);

        }



        static public string FormatPhone(string phone)
        {
            var length = phone.Length;
            if (length < 10)
                throw new Exception("Phone number can not be less than 10 char");

            phone = phone.Replace(" ", "");
            var revPhone = ReverseString(phone);
            revPhone = revPhone.Substring(0, 10);

            phone = "234" + ReverseString(revPhone);

            return phone;


            //var PhoneArr = phone.ToCharArray();



            //var revPhoneArr = PhoneArr.Reverse();
            //phone = new string(PhoneArr);
            //phone = string.Join("", revPhoneArr);
            //phone = string.Concat(revPhoneArr);
            //


        }




        static public ResponseHeader CheckFile()
        {

            try
            {

                string firstName = "Peter";
                string lastName = "Akintaro";

                string phone1 = "7026261698";

                string phone2 = "0702 626 1698";

                string phone3 = "2347026261698";

                string phone4 = "23407026261698";

                string phone5 = "2340-70262-61698";


                FormatPhone(phone3);

                //"07036261689"







                var dirPath = "c:/logs/ETGClass";

                Directory.CreateDirectory(dirPath);

                var exist = Directory.Exists(dirPath);

                var firFiles = Directory.GetFiles(dirPath);


                var filePath = $"{dirPath}/peter.txt";

                var sw = new StreamWriter(filePath, true);
                sw.WriteLine("THis is ETG Class1");
                sw.Close();


                sr = new StreamReader(filePath);
                var fileContent = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(fileContent);








                return new ResponseHeader
                {
                    ResponseCode = "00",
                    ResponseMessage = "Success"
                };

            }
            catch (FileNotFoundException eEx)
            {
                Console.WriteLine(eEx.Message);

                return new ResponseHeader
                {
                    ResponseCode = "01",
                    ResponseMessage = "Unable to get path"
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return new ResponseHeader
                {
                    ResponseCode = "01",
                    ResponseMessage = "Unable to get path"
                };
            }

        }





    }
}
