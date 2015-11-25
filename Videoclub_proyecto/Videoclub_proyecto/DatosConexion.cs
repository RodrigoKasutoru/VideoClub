using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videoclub_proyecto
{
   public class DatosConexion
    {
        private string server;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        private string db;

        public string Db
        {
            get { return db; }
            set { db = value; }
        }
        private bool security;

        public bool Security
        {
            get { return security; }
            set { security = value; }
        }
        public DatosConexion(string db, string server = "localhost", bool security = true)
        {
            Db = db;
            Server = server;
            Security = security;
        }
        public string RetornarCadenaConexion()
        {
            return " Data Source = " + server + "; " + "Initial Catalog = " + db + "; Integrated Security = " + security + ";";
        }
    }
}
