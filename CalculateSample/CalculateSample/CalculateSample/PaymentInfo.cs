using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalculateSample
{
    public class PaymentInfo : INotifyPropertyChanged
    {
        private double interestRate;
        [Display(Name = "Interest Rate")]
        public double InterestRate
        {
            get { return interestRate; }
            set
            {
                interestRate = value;
                OnPropertyChanged("InterestRate");
            }
        }

        private int numberOfPaymentPerYear;
        [Display(Name = "Number of payments per year")]
        public int NumberOfPaymentPerYear
        {
            get { return numberOfPaymentPerYear; }
            set
            {
                numberOfPaymentPerYear = value;
                OnPropertyChanged("NumberOfPaymentPerYear");

            }
        }

        private int loanYears;
        [Display(Name = "Loan Years")]
        public int LoanYears
        {
            get { return loanYears; }
            set
            {
                loanYears = value;

                OnPropertyChanged("LoanYears");

            }
        }

        private int loanAmount;
        [Display(Name = "Loan Amount")]
        public int LoanAmount
        {
            get { return loanAmount; }
            set
            {
                loanAmount = value;
                OnPropertyChanged("LoanAmount");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
