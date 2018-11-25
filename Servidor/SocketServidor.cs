using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidor
{
    internal class SocketServidor
    {
        string v1;
        int v2;

        public SocketServidor(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;

            Console.WriteLine(@"Servidor iniciado en {0}\{1}", Dns.Resolve(Dns.GetHostName()).AddressList[0].ToString(), v2);
        }

        internal void Escuchar()
        {
            TcpListener svr = new TcpListener(v2);
            svr.Start();
            while(true)
            {
                //ESperar que se conecten
                Console.WriteLine("Esperando...");

                TcpClient cte = svr.AcceptTcpClient();
                Console.WriteLine("Vale verga, llego un cliente");


                //Obtener el medio de comunicacion
                NetworkStream stm = cte.GetStream();

                //Preparamos mensaje
                byte[] buffer = Encoding.ASCII.GetBytes("Bienvenido");

                stm.Write(buffer, 0, buffer.Length);
            }
        }
    }
}