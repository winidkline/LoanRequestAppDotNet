namespace LoanRequestApp.Models
{
    public class LoanRequestAsset
    {
        public int LoanRequestAssetId { get; set; }
        public int LoanRequestId { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public LoanRequestAssetType loanRequestAssetType { get; set; }
    }
}
