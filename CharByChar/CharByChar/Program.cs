using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;


namespace CharByChar
{
    class Program
    {
        static void Main(String[] arg)
        {
            string filename = "filename.csv";

            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine("Name, Last Name, Edad, Ahorro, Contraseña");

                Console.WriteLine("Enter your name");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your Last Name");
                string LastName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your money");
                int money = Convert.ToInt32(Console.ReadLine());

                SecureString pass = PASSWORD();
                string Password = new System.Net.NetworkCredential (string.Empty, pass). Password;
                Console.WriteLine(Password);
                Console.ReadKey();

                SecureString pass2 = CONFIRMPASSWORD();
                string Password2 = new System.Net.NetworkCredential(string.Empty, pass ).Password;
                Console.WriteLine(Password2);
                Console.ReadKey();

                sw.WriteLine(name +" , "+ LastName +" , "+ age +" , "+ money);

            }
        
        }

        public static SecureString PASSWORD()
        {
            Console.WriteLine("Enter your password");
            SecureString pass = new SecureString();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if(!char.IsControl(keyInfo.KeyChar))
                {
                    pass.AppendChar(keyInfo.KeyChar);
                    Console.WriteLine("*");
                }
                else if(keyInfo.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass.RemoveAt(pass.Length -1);
                    Console.WriteLine("\b \b");
                }

            }
            while (keyInfo.Key != ConsoleKey.Enter);
            {
                return pass;
            }
        }

        public static SecureString CONFIRMPASSWORD ()
        {
            Console.WriteLine("Confirm your password");
            SecureString pass = new SecureString();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if(!char.IsControl(keyInfo.KeyChar))
                {
                    pass.AppendChar(keyInfo.KeyChar);
                    Console.WriteLine("*");
                }
                else if(keyInfo.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass.RemoveAt(pass.Length -1);
                    Console.WriteLine("\b \b");
                }

            }
            while (keyInfo.Key != ConsoleKey.Enter);
            {
                return pass;
            }

        }


    }
}
