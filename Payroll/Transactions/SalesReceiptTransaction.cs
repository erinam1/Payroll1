using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_FIO
{
    public class SalesReceiptTransaction: Transaction
    {
        private readonly DateTime date;
        private readonly double amount;
        private readonly int empId;
        public SalesReceiptTransaction(DateTime date, double amount, int empId)
        {
            this.date = date;
            this.amount = amount;
            this.empId = empId;
        }
        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                CommissionedClassification sc = e.Classification as CommissionedClassification;
                if (sc != null)
                    sc.AddSalesReceipt(new SalesReceipt(date, amount));
                else
                    throw new InvalidOperationException(
                        "Попытка добавить справку о продажах " +
                        "для работника не на оплате с комиссионными");
            }
            else
                throw new InvalidOperationException(
                    "Работник не найден.");
        }
    }
}
