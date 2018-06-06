using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;

namespace ServerClient
{
    class Program
    {
    
        static void Main(string[] args)
        {
           

            NetworkComms.AppendGlobalIncomingPacketHandler<String>("Welcome", welcome);
   
          
            String ipAddress = "127.0.0.1";
            IPAddress address = IPAddress.Parse(ipAddress);
            IPEndPoint endpoint = new IPEndPoint(address, 5245);
          
            Connection.StartListening(ConnectionType.TCP, endpoint);
           
        
            Console.WriteLine("Server listening for TCP connection on:");
         
           
            foreach (System.Net.IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
            {
                Console.WriteLine("{0}:{1}", localEndPoint.Address, localEndPoint.Port);
               
                System.Console.WriteLine("lol3");
            }
        
            Console.WriteLine("\nPress any key to close server.");
       
            Console.ReadKey(true);
            
          
            NetworkComms.Shutdown();
        }

        private static void welcome(PacketHeader packetHeader, Connection connection, String incomingObject)
        {
            Console.WriteLine(incomingObject);
        }
    }
}