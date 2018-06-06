using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using NetworkCommsDotNet;

namespace ServerClient
{
    class Program
    {

    


        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the server IP and port in the format 192.168.0.1:10000 and press return:");
        
            string serverIP = "127.0.0.1";
            int serverPort = 5245;

            int loopCounter = 1;
            while (true)
            {
              
                string messageToSend = "This is message #" + loopCounter;
                Console.WriteLine("Sending message to server saying '" + messageToSend + "'");

            
                Console.WriteLine("\nPress q to quit or any other key to send another message.");
                if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
                else
                {

                    Console.Read();

                  
                 NetworkComms.SendObject("Welcome", serverIP, serverPort, "Witam");
                

                }
            }
            
            NetworkComms.Shutdown();

        }
 


    }
    }