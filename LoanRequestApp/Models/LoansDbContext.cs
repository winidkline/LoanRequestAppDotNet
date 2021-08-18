using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanRequestApp.Models
{
    public class LoansDbContext : DbContext
    {
        public LoansDbContext(DbContextOptions options) : base (options) { }

        public DbSet<LoanRequest> LoanRequests { get; set; }
        public DbSet<LoanRequestAsset> LoanRequestAssets { get; set; }
        public DbSet<LoanRequestComment> LoanRequestComments { get; set; }
        public DbSet<LoanRequestFile> LoanRequestFiles { get; set; }
        public DbSet<LoanRequestAssetType> LoanRequestAssetTypes { get; set; }
    }
}
