using eBankingApp.Models;

namespace eBankingApp.Services
{
    public interface ILoanService
    {
        string GetLoanStringValue(LoanDetails loanDetails);
        int GetLoanHashCode(LoanDetails loanDetails);
    }
}
