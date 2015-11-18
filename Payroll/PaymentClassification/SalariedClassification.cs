using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll_FIO
{
    public class SalariedClassification : PaymentClassification
    {
        private readonly double salary;
        private Hashtable salesReceipts = new Hashtable();
        public SalariedClassification(double salary)
        {
            this.salary = salary;
        }
        public SalesReceipt GetSalesReceipt(DateTime date)
        {
            return salesReceipts[date] as SalesReceipt;
        }
        public double Salary
        {
            get { return salary; }
        }
        public override string ToString()
        {
            return String.Format("${0}", salary);
        }
    }
}
