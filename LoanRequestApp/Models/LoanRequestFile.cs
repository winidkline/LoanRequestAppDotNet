namespace LoanRequestApp.Models
{
    public class LoanRequestFile
    {
        public int LoanRequestFileId { get; set; }
        public int LoanRequestId { get; set; }
        public string Filename { get; set; }
        public bool Approved { get; set; }
        public bool IsP080A { get; set; }
    }
}
