using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll_FIO
{
    public class MonthlySchedule : PaymentSchedule
    {
        public override string ToString()
        {
            return "monthly";
        }
    }
}
