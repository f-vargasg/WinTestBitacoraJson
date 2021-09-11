using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class GeneralParamsBE
    {
        private bool useProxy;

        public bool UseProxy
        {
            get { return useProxy; }
        }

        private string urlProxy;

        public string UrlProxy
        {
            get { return urlProxy; }
        }

        private string domainProxy;

        public string DomainProxy
        {
            get { return domainProxy; }
        }

        private string userProxy;

        public string UserProxy
        {
            get { return userProxy; }
        }

        private string passProxy;

        public string PassProxy
        {
            get { return passProxy; }
        }


        private string urlWApiSrv;

        public string UrlWApiSrv
        {
            get { return urlWApiSrv; }
        }

        private string uriWApiSrv;

        public string UriWApiSrv
        {
            get { return uriWApiSrv; }
        }


        private string ptoUsernameCyl;

        public string PtoUsernameCyl
        {
            get { return ptoUsernameCyl; }
        }

        private string ptoPasswordCyl;

        public string PtoPasswordCyl
        {
            get { return ptoPasswordCyl; }
        }

        private string cusUsernameCyl;

        public string CusUsernameCyl
        {
            get { return cusUsernameCyl; }
        }

        private string cusPasswordCyl;

        public string CusPasswordCyl
        {
            get { return cusPasswordCyl; }
            set { cusPasswordCyl = value; }
        }



        private GeneralParamsBE()
        {
            this.useProxy = Convert.ToBoolean(ConfigurationManager.AppSettings["useProxy"]);
            this.urlProxy = ConfigurationManager.AppSettings["urlProxy"];
            this.domainProxy = ConfigurationManager.AppSettings["domainProxy"];
            this.userProxy = ConfigurationManager.AppSettings["userProxy"];
            this.passProxy = ConfigurationManager.AppSettings["passProxy"];
            this.urlWApiSrv = ConfigurationManager.AppSettings["urlWApiSrv"];
            this.uriWApiSrv = ConfigurationManager.AppSettings["uriWApiSrv"];
            this.ptoUsernameCyl = ConfigurationManager.AppSettings["ptoUsernameCyl"];
            this.ptoPasswordCyl = ConfigurationManager.AppSettings["ptoPasswordCyl"];
            this.cusUsernameCyl = ConfigurationManager.AppSettings["cusUsernameCyl"];
            this.cusPasswordCyl = ConfigurationManager.AppSettings["cusPasswordCyl"];
        }

        // implementing singleton class
        private static GeneralParamsBE instance;

        public static GeneralParamsBE Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GeneralParamsBE();
                }
                return instance;
            }
        }

        public override string ToString()
        {
            string res  = "(" + this.useProxy     +  ", " +  Environment.NewLine +
             this.urlProxy     +  ", " +  Environment.NewLine +
             this.domainProxy  +  ", " +  Environment.NewLine +
             this.userProxy    +  ", " +  Environment.NewLine +
             this.passProxy    +  ", " +  Environment.NewLine +
             this.urlWApiSrv   +  ", " +  Environment.NewLine +
             this.uriWApiSrv   +  ", " +  Environment.NewLine +
             this.ptoUsernameCyl + ", " + Environment.NewLine +
             this.ptoPasswordCyl  +  ")";

            return res;
        }
    }
}
