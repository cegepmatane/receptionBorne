using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Sockets;
using System.Web.Script.Serialization;

namespace ReceptionDesBornesModele
{
    public class BoueeDAO
    {
        private static BoueeDAO instance = null;

        public static BoueeDAO getInstance()
        {
            if (instance == null) instance = new BoueeDAO();
            return instance;
        }

        public static List<Bouee> recevoirLesBouees()
        {
            TcpClient tcpClient = new TcpClient();
            NetworkStream serverStream = default(NetworkStream);

            //ADDRESSE DU SERVEUR NODEJS
            tcpClient.Connect("10.1.51.57", 3000);
            
            while (true)
            {
                serverStream = tcpClient.GetStream();
                byte[] message = new byte[4096];
                int bytesRead;
                bytesRead = 0;

                try
                {
                    
                    bytesRead = serverStream.Read(message, 0, 4096);
                }
                catch
                {
                    
                }

                ASCIIEncoding encoder = new ASCIIEncoding();

                String json = encoder.GetString(message, 0, bytesRead);

                tcpClient.Close();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Bouee[] tableauListeBouees = js.Deserialize<Bouee[]>(json);
                List<Bouee> listeBouees = new List<Bouee>(tableauListeBouees);
                return listeBouees;
            }
        }
    }
}
