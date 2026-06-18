using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Testing
{
    class Program
    {
        static bool maskpassword = true;

    
        static void Main(string[] args)
        {

            // variables
            
           const string username = "dr. binarydinary";
           const string password = "DrBinaryis6yearsold";
           const string commandenable = "//hash on";
           const string commanddisable = "//hash off";
           int attempts = 0;
           int totalattempts = 0;
           int systemattempts = 0;
           bool isvalidboolean = false;
           bool signed = false;
           // loop
           while (!isvalidboolean)
            {
                
                
                if (systemattempts <= 14)
                {
                if (totalattempts <= 9)
                {

                if (attempts <= 4)
                {
                // I/O Stream
                
                Console.Write("if you have already signed in just press enter otherwise please type in username, Sign in: ");
             string usernameinput = Console.ReadLine();
             
            // Ensures that the output if it is empty then it doesnt crash
             if (string.IsNullOrEmpty(usernameinput))
                {
                    Console.WriteLine("You didnt put an input!");
                }
                // username if statement
                 if (usernameinput == username || signed)
                 {

                    if (Console.KeyAvailable)
                                {
                                    var key = Console.ReadKey(true);
                                    if (key.Key == ConsoleKey.Spacebar)
                                    {
                                        maskpassword = !maskpassword;
                                    }
                                }
                    signed = true;
                   

                    if (attempts == 1)
                        {
                            Console.WriteLine(attempts + " attempt");
                        }
                        else
                        {
                            Console.WriteLine(attempts + " attempts");
                        }

                    // Writes the line, and ensures whitespaces are accounted for
                    Console.Write("Sign into " + username + ": ");
                    string passwordinput = maskpassword ? ReadPassword() : Console.ReadLine();

                    if (string.IsNullOrEmpty(passwordinput))
                    {
                        Console.WriteLine("You didnt put an input");
                    }
                 // Checks for input = var
                if (passwordinput == password)
                {
                    Console.WriteLine("Welcome " + username);
                    isvalidboolean = true;
                    if (attempts == 1)
                        {
                            Console.WriteLine(attempts + " attempt used in total");
                        }
                        
                        else
                        {
                            Console.WriteLine(attempts + " attempts");
                        }
                }
                else if (passwordinput == commandenable)
            {
                maskpassword = true;
                Console.WriteLine("Command Executed you successfully enabled hashes");
            }
            else if (passwordinput == commanddisable)
            {
                maskpassword = false;
                Console.WriteLine("Command Executed you have successfully disabled hashes");
            }
                else
                {
                    Console.WriteLine("Incorrect Passoword, try again");
                    attempts += 1;
                    totalattempts += 1;
                    systemattempts += 1;
                    if (attempts == 1)
                        {
                            Console.WriteLine(attempts + " attempt");
                        }
                        else
                        {
                            Console.WriteLine(attempts + " attempts");
                        }
                }
                 }
                 else if (usernameinput == commandenable)
            {
                maskpassword = true;
                Console.WriteLine("Command Executed you successfully enabled hashes");
            }
            else if (usernameinput == commanddisable)
            {
                maskpassword = false;
                Console.WriteLine("Command Executed you have successfully disabled hashes");
            }
                            

                 // username if statement else
                 else 
                {
                    Console.WriteLine("Non-Existant Username");
                    attempts += 1;
                    totalattempts += 1;
                    systemattempts += 1;
                    if (attempts == 1)
                        {
                            Console.WriteLine(attempts + " attempt");
                        }
                        else
                        {
                            Console.WriteLine(attempts + " attempts");
                        }
                    
                }

            }
            else
                {
                    Console.WriteLine("Your out of attempts you have now been timed out for 30 seconds");
                    Thread.Sleep(30000);
                    attempts = 0;
                    Console.WriteLine("You may now try again");
                }
                }
                else if (totalattempts >= 9)
                {
                    Console.WriteLine("Your out of attempts you have now been timed out for 1 minute");
                    Thread.Sleep(60000);
                    totalattempts = 0;
                    Console.WriteLine("You may now try again");
                }
                }
                else if (systemattempts >14)
                {
                    Console.WriteLine("You have been Blocked please restart the game to try again fully");
                    break;
                }
            }
            
                }
                static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

       while(true)
            {

                
                key = Console.ReadKey(true);
                 
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }


                if (key.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password = password.Substring(0, password.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }

                
            }
            return password;

        }
                

            }
        }

