namespace FractionCalculator
{
    public partial class frmFractionCalculator : Form {
        public frmFractionCalculator() {
            InitializeComponent();
        } // end event handler

        private void btnCalculate_Click(object sender, EventArgs e) {
            // initialize member variables
            int numeratorX;
            int denominatorX;
            int numeratorY;
            int denominatorY;

            // try catch statement to validate the numerators and denominators
            try {
                // set the variables from the respective textboxes
                numeratorX = int.Parse(txtNumeratorX.Text);
                denominatorX = int.Parse(txtDenominatorX.Text);
                numeratorY = int.Parse(txtNumeratorY.Text);
                denominatorY = int.Parse(txtDenominatorY.Text);

                // if a denominator = 0, throw exception
                if (denominatorY == 0 || denominatorX == 0) {
                    throw new DivideByZeroException();
                } // end if
            } catch (DivideByZeroException){
                // clear the textboxes and inform the user of the error
                tstDecimal.Text = "Please enter a number other than 0 for the denominators.";
                txtNumeratorX.Clear();
                txtDenominatorX.Clear();
                txtNumeratorY.Clear();
                txtDenominatorY.Clear();
                txtNumeratorX.Focus();
                return;
            } catch (FormatException) {
                // clear the textboxes and inform the user of the error
                tstDecimal.Text = "You must entert valid integers. Please try again.";
                txtNumeratorX.Clear();
                txtDenominatorX.Clear();
                txtNumeratorY.Clear();
                txtDenominatorY.Clear();
                txtNumeratorX.Focus();
                return;
            } // end try catch
            
            // create the fractions with the respective variables
            Fraction fraction1 = new Fraction(numeratorX, denominatorX);
            Fraction fraction2 = new Fraction(numeratorY, denominatorY);


            // if else to determine which operations will occur
            if (cmbSelection.Text == "+") { 
                // create a new fraction by overloading the addition operator
                Fraction result = new Fraction(fraction1 + fraction2);
                lblResults.Text = result.ToString();
                //double decResult = result.ToDecimal();
                tstDecimal.Text = $"Decimal Equivalent: {result.ToDecimal():N2}";
            } else if (cmbSelection.Text == "-") {
                // create a new fraction by overloading the subtraction operator
                Fraction result = new Fraction(fraction1 - fraction2);
                lblResults.Text = result.ToString();
                tstDecimal.Text = $"Decimal Equivalent: {result.ToDecimal():N2}";
            } else if (cmbSelection.Text == "*") {
                // create a new fraction by overloading the multiplication operator
                Fraction result = new Fraction(fraction1 * fraction2);
                lblResults.Text = result.ToString();
                tstDecimal.Text = $"Decimal Equivalent: {result.ToDecimal():N2}";
            } else if (cmbSelection.Text == "/") {
                // create a new fraction by overloading the division operator
                Fraction result = new Fraction(fraction1 / fraction2);
                lblResults.Text = result.ToString();
                tstDecimal.Text = $"Decimal Equivalent: {result.ToDecimal():N2}";
            } // end else if
        } // end event handler        

        // event handler for clear button click
        private void btnExit_Click(object sender, EventArgs e){
            // clear textboxes and set the operator to addition
            txtDenominatorX.Clear();
            txtNumeratorX.Clear();
            txtDenominatorY.Clear();
            txtNumeratorY.Clear();
            cmbSelection.SelectedIndex = 0;
            txtNumeratorX.Focus();
        } // end event handler

        private void frmFractionCalculator_Load(object sender, EventArgs e) {
            cmbSelection.SelectedIndex = 0;
        } // end event handler
    } // end class
} // end namespace