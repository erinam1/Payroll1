﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_FIO
{
    public class AddCommissionedEmployee : AddEmployeeTransaction
    {
        private readonly double salary;
        private readonly double commissionRate;

        public AddCommissionedEmployee(int id, string name, string address, double salary, double commissionRate)
            : base(id, name, address)
        {
            this.salary = salary;
            this.commissionRate = commissionRate;
        }
        protected override PaymentClassification MakeClassification()
        {
            return new CommissionedClassification(salary, commissionRate);
        }
        protected override PaymentSchedule MakeSchedule()
        {
            return new BiWeeklySchedule();
        }
    }
}
