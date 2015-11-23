using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_FIO
{
    class MailMethod : PaymentMethod
    {
        public override string ToString()
        {
            return "mail";
        }
    }
}
