using eBankingApp.Models;

namespace eBankingApp.Services
{
    public class LoanService : ILoanService
    {
        public int GetLoanHashCode(LoanDetails loanDetails)
        {
            return loanDetails.firstName.GetHashCode() +
                loanDetails.lastName.GetHashCode() +
                loanDetails.email.GetHashCode() +
                loanDetails.loanDuration.GetHashCode() +
                loanDetails.loanDuration.GetHashCode();
        }

        public string GetLoanStringValue(LoanDetails loanDetails)
        {
            return "LoanDetails{" +
               "firstName='" + loanDetails.firstName + '\'' +
               ", lastName='" + loanDetails.lastName + '\'' +
               ", email='" + loanDetails.email + '\'' +
               ", loanType='" + loanDetails.loanType + '\'' +
               ", loanDuration=" + loanDetails.loanDuration +
               '}';
        }
    }
}
