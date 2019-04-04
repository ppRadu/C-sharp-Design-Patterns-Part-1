using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Policy
    {

        private static readonly Policy _instance = new Policy();

        public static Policy Instance
        {
            get
            {
                return _instance;
            }
        }

        //////This works as a true Singleton but it is not thread safe

        //private static Policy _instance;
        //public static Policy Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new Policy();
        //        }
        //        return _instance;
        //    }
        //}

        public Policy()
        {

        }

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }
}
