// ============================================================
//  ExceptionsValidationDemo — MainForm.cs
//  Demonstrates all concepts from Guide #7:
//    • Try-Catch (single and multiple catch blocks)
//    • Finally block
//    • Throw / re-throw statements
//    • Exception properties (Message, StackTrace, GetType)
//    • MessageBox with DialogResult
//    • Data validation: presence, type, range checks
//    • TryParse vs Convert
//    • Generic reusable validation methods (IsPresent, IsDecimal,
//      IsInt, IsWithinRange)
//    • IsValidData() — two approaches (sequential / AND-chain)
//    • Two-layer defense: validation + exception handling together
// ============================================================

namespace ExceptionsValidationDemo;

public partial class MainForm : Form
{
    // ----------------------------------------------------------------
    //  Constructor
    // ----------------------------------------------------------------
    public MainForm()
    {
        InitializeComponent();
    }

    // ================================================================
    //  TAB 1 — Basic Try-Catch: Temperature Converter
    //  Demonstrates: single catch (FormatException), ex.Message
    // ================================================================
    private void btnConvert_Click(object sender, EventArgs e)
    {
        try
        {
            // Convert.ToDecimal throws FormatException if input is non-numeric
            decimal fahrenheit = Convert.ToDecimal(txtFahrenheit.Text);
            decimal celsius = (fahrenheit - 32) * 5 / 9;
            lblCelsiusResult.Text = celsius.ToString("f1") + " °C";
            throw new Exception("Different exception");
        }
        catch (FormatException)
        {
            // Specific catch — only fires for format problems
            MessageBox.Show("Please enter a valid number for Fahrenheit.",
                            "Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            txtFahrenheit.Focus();
        }
        
    }

    private void btnClearConvert_Click(object sender, EventArgs e)
    {
        txtFahrenheit.Clear();
        lblCelsiusResult.Text = "—";
        txtFahrenheit.Focus();
    }

    // ================================================================
    //  TAB 2 — Multiple Catch Blocks: Rate Calculator
    //  Demonstrates: FormatException → OverflowException → Exception
    //  (most specific → most general ordering)
    // ================================================================
    private void btnCalcRate_Click(object sender, EventArgs e)
    {
        try
        {
            // FormatException if non-numeric text
            decimal rate = Convert.ToDecimal(txtRate.Text);

            // DivideByZeroException for decimal is NOT thrown — it yields Infinity.
            // We demonstrate OverflowException with a very large number instead.
            // Use checked arithmetic to force OverflowException:
            decimal result = checked(1_000_000_000_000m / rate);

            lblRateResult.Text = result.ToString("c");
        }
        catch (FormatException)
        {
            // Fires when the user types non-numeric text
            MessageBox.Show("Rate must be a valid number.",
                            "Format Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            txtRate.Focus();
        }
        catch (OverflowException)
        {
            // Fires when a value exceeds the decimal range
            MessageBox.Show("Rate produced a value that is too large or too small.",
                            "Overflow Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            txtRate.Focus();
        }
        catch (Exception ex)
        {
            // General safety net — catches anything else
            // Demonstrates: ex.Message, ex.GetType(), ex.StackTrace
            string details =
                $"Type:    {ex.GetType()}\n" +
                $"Message: {ex.Message}\n\n" +
                $"Stack Trace:\n{ex.StackTrace}";

            MessageBox.Show(details,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    private void btnClearRate_Click(object sender, EventArgs e)
    {
        txtRate.Clear();
        lblRateResult.Text = "—";
        txtRate.Focus();
    }

    // ================================================================
    //  TAB 3 — Finally Block: Resource Cleanup Simulator
    //  Demonstrates: finally always runs; status label always updated
    // ================================================================
    private void btnRunOperation_Click(object sender, EventArgs e)
    {
        lblFinallyStatus.Text = "Running…";
        lblFinallyStatus.ForeColor = Color.DarkOrange;
        Application.DoEvents(); // let the label paint before we block

        try
        {
            // Simulate work — may throw if user asked for it
            if (chkForceError.Checked)
                throw new InvalidOperationException(
                    "Simulated error thrown to demonstrate finally.");

            lblFinallyResult.Text = "✅ Operation completed successfully.";
            lblFinallyResult.ForeColor = Color.DarkGreen;
        }
        catch (Exception ex)
        {
            lblFinallyResult.Text = $"❌ Error caught: {ex.Message}";
            lblFinallyResult.ForeColor = Color.DarkRed;

            MessageBox.Show(ex.Message, "Caught Exception",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // This ALWAYS executes — success or failure
            // Typical use: close files, release connections, reset UI
            lblFinallyStatus.Text = "Cleanup done (finally block ran)";
            lblFinallyStatus.ForeColor = Color.DarkBlue;
        }
    }

    private void btnClearFinally_Click(object sender, EventArgs e)
    {
        lblFinallyResult.Text = "—";
        lblFinallyResult.ForeColor = Color.Black;
        lblFinallyStatus.Text = "—";
        lblFinallyStatus.ForeColor = Color.Black;
        chkForceError.Checked = false;
    }

    // ================================================================
    //  TAB 4 — Throw Statements & Discount Calculator
    //  Demonstrates: throw new ArgumentException(...), re-throw
    // ================================================================
    private void btnCalcDiscount_Click(object sender, EventArgs e)
    {
        try
        {
            decimal price    = Convert.ToDecimal(txtDiscountPrice.Text);
            decimal pct      = Convert.ToDecimal(txtDiscountPct.Text);

            // CalculateDiscount throws ArgumentException for bad values
            decimal discount = CalculateDiscount(price, pct);
            decimal finalPrice = price - discount;

            lblDiscountResult.Text =
                $"Discount: {discount:c}   →   Final Price: {finalPrice:c}";
        }
        catch (FormatException)
        {
            MessageBox.Show("Price and Discount % must be valid numbers.",
                            "Format Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
        catch (ArgumentException ex)
        {
            // Thrown by CalculateDiscount when values are out of range
            MessageBox.Show(ex.Message,
                            "Argument Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Unexpected Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Demonstrates a method that throws its own ArgumentException
    /// when the caller passes an invalid argument.
    /// </summary>
    public static decimal CalculateDiscount(decimal price, decimal discountPercent)
    {
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        if (discountPercent < 0 || discountPercent > 100)
            throw new ArgumentException("Discount must be between 0 and 100.");

        return price * discountPercent / 100;
    }

    private void btnTestRethrow_Click(object sender, EventArgs e)
    {
        // Demonstrates catch → log → re-throw pattern
        try
        {
            ProcessWithLogging();
        }
        catch (Exception ex)
        {
            // The re-throw in ProcessWithLogging preserved the stack trace
            MessageBox.Show(
                $"Caught after re-throw.\n\nMessage: {ex.Message}\n\nGetType: {ex.GetType()}",
                "Re-Throw Demo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private static void ProcessWithLogging()
    {
        try
        {
            // Intentionally cause an exception
            _ = Convert.ToInt32("not a number");
        }
        catch (Exception ex)
        {
            // Log (simulated) — then re-throw with 'throw;' to preserve stack trace
            System.Diagnostics.Debug.WriteLine($"[LOG] {ex.GetType()}: {ex.Message}");
            throw;   // ← correct: preserves original stack trace
                     // throw ex;  would RESET the stack trace — avoid this!
        }
    }

    private void btnClearDiscount_Click(object sender, EventArgs e)
    {
        txtDiscountPrice.Clear();
        txtDiscountPct.Clear();
        lblDiscountResult.Text = "—";
        txtDiscountPrice.Focus();
    }

    // ================================================================
    //  TAB 5 — MessageBox & DialogResult Demo
    // ================================================================
    private void btnShowSimple_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Operation completed successfully.");
        lblDialogResult.Text = "Result: (no return value)";
    }

    private void btnShowTitled_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Please enter a valid number.", "Entry Error");
        lblDialogResult.Text = "Result: (no return value)";
    }

    private void btnShowYesNo_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Are you sure you want to continue?",
            "Confirm Action",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        // DialogResult tells us which button the user clicked
        lblDialogResult.Text = result == DialogResult.Yes
            ? "Result: User clicked YES"
            : "Result: User clicked NO";
    }

    private void btnShowWarning_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "This action cannot be undone!",
            "Warning",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);
        lblDialogResult.Text = "Result: Warning shown";
    }

    private void btnShowError_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "A critical error has occurred. The application will close.",
            "Critical Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        lblDialogResult.Text = "Result: Error icon shown";
    }

    // ================================================================
    //  TAB 6 — Data Validation (inline approach)
    //  Demonstrates: presence check, TryParse type check, range check
    // ================================================================
    private void btnCalcOrder_Click(object sender, EventArgs e)
    {
        // ---- 1. Presence check ----
        if (txtInlineQty.Text == "")
        {
            MessageBox.Show("Quantity is required.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInlineQty.Focus();
            return;
        }

        // ---- 2. Numeric type check (TryParse — no exception thrown) ----
        if (!int.TryParse(txtInlineQty.Text, out int quantity))
        {
            MessageBox.Show("Quantity must be a valid integer.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInlineQty.Focus();
            return;
        }

        // ---- 3. Range check ----
        if (quantity <= 0 || quantity > 100)
        {
            MessageBox.Show("Quantity must be between 1 and 100.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInlineQty.Focus();
            return;
        }

        // All validation passed — safe to calculate
        const decimal UnitPrice = 19.99m;
        decimal total = quantity * UnitPrice;
        lblOrderTotal.Text = $"{quantity} × {UnitPrice:c} = {total:c}";
    }

    private void btnClearOrder_Click(object sender, EventArgs e)
    {
        txtInlineQty.Clear();
        lblOrderTotal.Text = "—";
        txtInlineQty.Focus();
    }

    // ================================================================
    //  TAB 7 — Generic Validation Methods + IsValidData()
    //  Demonstrates: IsPresent, IsDecimal, IsInt, IsWithinRange,
    //                IsValidData (sequential AND chain), two-layer defense
    // ================================================================
    private void btnCalcGeneric_Click(object sender, EventArgs e)
    {
        try
        {
            // Two-layer defense: validation first, exception handling as safety net
            if (IsValidData())
            {
                // Convert is safe here — validation already confirmed the values
                decimal price = Convert.ToDecimal(txtGenericPrice.Text);
                int     qty   = Convert.ToInt32(txtGenericQty.Text);
                decimal total = price * qty;
                lblGenericTotal.Text = total.ToString("c");
            }
        }
        catch (Exception ex)
        {
            // Safety net for anything unexpected
            MessageBox.Show(ex.Message, "Unexpected Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ---- IsValidData: Sequential approach with early return ----
    private bool IsValidData()
    {
        // Presence checks first, then type checks, then range checks
        if (!IsPresent(txtGenericPrice, "Price"))       return false;
        if (!IsDecimal(txtGenericPrice, "Price"))       return false;
        if (!IsWithinRange(txtGenericPrice, "Price", 0.01m, 9999.99m)) return false;

        if (!IsPresent(txtGenericQty, "Quantity"))      return false;
        if (!IsInt(txtGenericQty, "Quantity"))          return false;
        if (!IsWithinRange(txtGenericQty, "Quantity", 1, 100)) return false;

        return true;
    }

    // ---- Alternative: Boolean AND chain (short-circuit evaluation) ----
    // Shown for comparison — both approaches behave identically
    // private bool IsValidData() =>
    //     IsPresent(txtGenericPrice, "Price")  &&
    //     IsDecimal(txtGenericPrice, "Price")  &&
    //     IsWithinRange(txtGenericPrice, "Price", 0.01m, 9999.99m) &&
    //     IsPresent(txtGenericQty,   "Quantity") &&
    //     IsInt(txtGenericQty,       "Quantity") &&
    //     IsWithinRange(txtGenericQty, "Quantity", 1, 100);

    private void btnClearGeneric_Click(object sender, EventArgs e)
    {
        txtGenericPrice.Clear();
        txtGenericQty.Clear();
        lblGenericTotal.Text = "—";
        txtGenericPrice.Focus();
    }

    // ================================================================
    //  GENERIC VALIDATION METHODS — reusable across the form
    //  (could also live in a separate Validator class)
    // ================================================================

    /// <summary>Returns true if the text box is not empty.</summary>
    public bool IsPresent(TextBox textBox, string name)
    {
        if (textBox.Text.Trim() == "")
        {
            MessageBox.Show($"{name} is a required field.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            return false;
        }
        return true;
    }

    /// <summary>Returns true if the text box contains a valid decimal.</summary>
    public bool IsDecimal(TextBox textBox, string name)
    {
        if (!decimal.TryParse(textBox.Text, out _))
        {
            MessageBox.Show($"{name} must be a valid decimal number.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            return false;
        }
        return true;
    }

    /// <summary>Returns true if the text box contains a valid integer.</summary>
    public bool IsInt(TextBox textBox, string name)
    {
        if (!int.TryParse(textBox.Text, out _))
        {
            MessageBox.Show($"{name} must be a valid whole number (integer).", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            return false;
        }
        return true;
    }

    /// <summary>Returns true if the parsed decimal value falls within [min, max].</summary>
    /// <remarks>Call IsDecimal (or IsInt) before calling this method.</remarks>
    public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
    {
        decimal value = Convert.ToDecimal(textBox.Text);
        if (value < min || value > max)
        {
            MessageBox.Show($"{name} must be between {min} and {max}.", "Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            return false;
        }
        return true;
    }

    // ================================================================
    //  TAB 8 — TryParse vs Convert side-by-side comparison
    // ================================================================
    private void btnTryParseDemo_Click(object sender, EventArgs e)
    {
        string input = txtTryParseInput.Text;

        // ---- TryParse approach ----
        if (decimal.TryParse(input, out decimal parsedValue))
        {
            lblTryParseResult.Text = $"TryParse ✅  →  {parsedValue:n2}";
            lblTryParseResult.ForeColor = Color.DarkGreen;
        }
        else
        {
            lblTryParseResult.Text = "TryParse ❌  →  returned false (no exception)";
            lblTryParseResult.ForeColor = Color.DarkRed;
        }

        // ---- Convert approach ----
        try
        {
            decimal convertValue = Convert.ToDecimal(input);
            lblConvertResult.Text = $"Convert ✅  →  {convertValue:n2}";
            lblConvertResult.ForeColor = Color.DarkGreen;
        }
        catch (FormatException ex)
        {
            lblConvertResult.Text = $"Convert ❌  →  FormatException thrown\n\"{ex.Message}\"";
            lblConvertResult.ForeColor = Color.DarkRed;
        }
    }

    private void btnClearTryParse_Click(object sender, EventArgs e)
    {
        txtTryParseInput.Clear();
        lblTryParseResult.Text  = "—";
        lblConvertResult.Text   = "—";
        lblTryParseResult.ForeColor = Color.Black;
        lblConvertResult.ForeColor  = Color.Black;
        txtTryParseInput.Focus();
    }
}
