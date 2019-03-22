using Syncfusion.Calculate;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculateSample
{
    public partial class MainPage : ContentPage
    {
        PaymentInfo paymentInfo;
        CalcQuickBase calcQuick;
        CalcEngine engine;    
        public MainPage()
        {
            InitializeComponent();

            paymentInfo = new PaymentInfo();
            calcQuick = new CalcQuickBase();
            engine = new CalcEngine(calcQuick);

            dataForm.DataObject = paymentInfo;                   
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string formula = "=-PMT(" + paymentInfo.InterestRate.ToString() + "/" + paymentInfo.NumberOfPaymentPerYear.ToString() + "," + paymentInfo.LoanYears.ToString() + "*" + paymentInfo.NumberOfPaymentPerYear.ToString() + "," + paymentInfo.LoanAmount.ToString() + ")";
            displayButton.Text = engine.ParseAndComputeFormula(formula);
        }
    }
}
