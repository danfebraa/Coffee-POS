using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Models
{
    public class ErrorsBase
    {
        private string statusCode = null;

        public string StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }

    }
}
