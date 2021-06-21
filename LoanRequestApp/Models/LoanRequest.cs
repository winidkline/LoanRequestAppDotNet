using LoanRequestApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanRequestApp.Models
{
    public class LoanRequest
    {
        public int LoanRequestId { get; set; }
        public int Status { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal Amount { get; set; }
        public int TermValue { get; set; }
        public TermUnit TermUnit { get; set; }
        public DateTime? Requested { get; set; }
        public DateTime Submitted { get; set; }
        public DateTime? Approved { get; set; }
        public bool HasProcessed { get; set; }
        public string P080APath { get; set; }
        public string Notes { get; set; }
        public List<LoanRequestAsset> LoanRequestAssets { get; set; }
    }
}
