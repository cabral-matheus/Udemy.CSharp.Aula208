﻿using System.Globalization;

namespace Udemy.CSharp.Aula208.Entities
{
    internal class Installment
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Installment(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy")
            + " - "
            + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
