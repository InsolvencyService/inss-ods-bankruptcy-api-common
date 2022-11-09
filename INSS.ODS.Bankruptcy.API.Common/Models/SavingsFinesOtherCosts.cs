using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using INSS.ODS.Bankruptcy.API.Common.Models.Interfaces;
using System.Runtime.Serialization;
using INSS.ODS.Bankruptcy.API.Common.Models.Helpers;

namespace INSS.ODS.Bankruptcy.API.Common.Models
{
    public class SavingsFinesOtherCosts : ITableBase, ISavingsFinesOtherCosts
    {

        public int Id
        { 
            get; 
            set; 
        }


        public decimal? Savings
        {
            get;
            set;
        }


        public string Savings_Frequency
        {
            get;
            set;
        }


        public List<Fine> CourtFines
        {
            get;
            set;
        }

        public List<Expense> Expenses { get; set; }

        [NotMapped]
        public decimal? Total
        {
            get
            {
                if (IsNotStarted) { return null; }

                var result = ValueFrequencyNormalisation.Normalise(Savings, Savings_Frequency);

                if (CourtFines != null)
                {
                    foreach (var fine in CourtFines)
                    {
                        result += ValueFrequencyNormalisation.Normalise(fine.Value, fine.Frequency);
                    }
                }

                if (Expenses!=null)
                {
                    foreach (var expense in Expenses)
                    {
                        result += ValueFrequencyNormalisation.Normalise(expense.Value, expense.Frequency);
                    }
                }

                return result;
            }
        }

        [NotMapped]
        public bool IsNotStarted
        {
            get
            {
                return Savings == null
                       && (CourtFines==null || !CourtFines.Any())
                       && (Expenses == null || !Expenses.Any());
            }
        }
    }
}