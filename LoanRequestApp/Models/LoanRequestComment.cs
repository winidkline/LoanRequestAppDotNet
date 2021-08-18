using System;

namespace LoanRequestApp.Models
{
    public class LoanRequestComment
    {
        public int LoanRequestCommentId { get; set; }
        public int LoanRequestId { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
