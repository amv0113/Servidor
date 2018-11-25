using System;

namespace Servidor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SocketServidor svr = new SocketServidor("127.0.0.1",6969);
            svr.Escuchar();
        }
    }
}
