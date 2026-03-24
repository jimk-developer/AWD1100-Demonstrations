// ============================================================
//  PizzaOrderApp — Guide #10 Demo
//  Covers: ComboBox, ListBox, RadioButton, CheckBox, GroupBox,
//          Tab Order, Modal Dialogs, DialogResult, Tag property,
//          MessageBox, FormClosing, ShowDialog vs Show,
//          Program class, Global Using Directives
// ============================================================

namespace PizzaOrderApp
{
    public partial class OrderForm : Form
    {
        // ── price constants ──────────────────────────────────────
        private const decimal PRICE_SMALL  = 8.99m;
        private const decimal PRICE_MEDIUM = 11.99m;
        private const decimal PRICE_LARGE  = 14.99m;
        private const decimal PRICE_XL     = 17.99m;

        private const decimal PRICE_CHEESE  = 0.00m;
        private const decimal PRICE_PEPPERONI = 1.50m;
        private const decimal PRICE_VEGGIE  = 1.75m;
        private const decimal PRICE_DELUXE  = 2.50m;

        private const decimal ADD_EXTRA_CHEESE = 1.00m;
        private const decimal ADD_STUFFED_CRUST = 1.50m;
        private const decimal ADD_GLUTEN_FREE   = 2.00m;

        // ── customer info (passed back via Tag from dialog) ──────
        private string _customerName  = "";
        private string _customerPhone = "";
        private string _deliveryNotes = "";

        public OrderForm()
        {
            InitializeComponent();
        }

        // ────────────────────────────────────────────────────────
        //  FORM LOAD  — best place to populate combo/list boxes
        // ────────────────────────────────────────────────────────
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // ── ComboBox: size list ──────────────────────────────
            cboSize.Items.Clear();               // Clear() BEFORE the loop (common mistake)
            cboSize.Items.Add("Small  (+$8.99)");
            cboSize.Items.Add("Medium (+$11.99)");
            cboSize.Items.Add("Large  (+$14.99)");
            cboSize.Items.Add("X-Large(+$17.99)");
            cboSize.SelectedIndex = 1;           // default to Medium

            // ── ComboBox: fill with a loop (years example) ──────
            cboQuantity.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cboQuantity.Items.Add(i);
            cboQuantity.SelectedIndex = 0;       // default to 1

            // ── ListBox: specialty items ─────────────────────────
            lstSpecials.Items.Clear();
            lstSpecials.Items.Add("Cheese          $0.00");
            lstSpecials.Items.Add("Pepperoni       $1.50");
            lstSpecials.Items.Add("Veggie          $1.75");
            lstSpecials.Items.Add("Deluxe          $2.50");
            lstSpecials.SelectedIndex = 0;

            // ── initial summary ──────────────────────────────────
            UpdateOrderSummary();
        }

        // ────────────────────────────────────────────────────────
        //  ComboBox — SelectedIndexChanged event
        // ────────────────────────────────────────────────────────
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void cboQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        // ────────────────────────────────────────────────────────
        //  ListBox — SelectedIndexChanged event
        // ────────────────────────────────────────────────────────
        private void lstSpecials_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Read the selected item from a ListBox
            if (lstSpecials.SelectedItem != null)
            {
                string selection = lstSpecials.SelectedItem.ToString()!;
                lblSpecialStatus.Text = $"Selected: {selection.Trim()}";
                UpdateOrderSummary();
            }
        }

        // ────────────────────────────────────────────────────────
        //  RadioButtons — crust type (inside GroupBox = independent group)
        // ────────────────────────────────────────────────────────
        private void rdoCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        // ────────────────────────────────────────────────────────
        //  CheckBoxes — toppings / add-ons
        // ────────────────────────────────────────────────────────
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        // ────────────────────────────────────────────────────────
        //  CALCULATE ORDER  — reads all controls, builds summary
        // ────────────────────────────────────────────────────────
        private void UpdateOrderSummary()
        {
            // ── RadioButton: read Checked (bool) ─────────────────
            decimal crustExtra = 0m;
            string crustName = "Thin";
            if (rdoThin.Checked)       { crustName = "Thin";         crustExtra = 0.00m; }
            else if (rdoHand.Checked)  { crustName = "Hand-Tossed";  crustExtra = 0.00m; }
            else if (rdoPan.Checked)   { crustName = "Pan";          crustExtra = 0.50m; }

            // ── ComboBox: size price ──────────────────────────────
            decimal sizePrice = cboSize.SelectedIndex switch
            {
                0 => PRICE_SMALL,
                1 => PRICE_MEDIUM,
                2 => PRICE_LARGE,
                3 => PRICE_XL,
                _ => PRICE_MEDIUM
            };

            // ── ListBox: specialty price ──────────────────────────
            decimal specialPrice = lstSpecials.SelectedIndex switch
            {
                0 => PRICE_CHEESE,
                1 => PRICE_PEPPERONI,
                2 => PRICE_VEGGIE,
                3 => PRICE_DELUXE,
                _ => PRICE_CHEESE
            };

            // ── CheckBoxes: read Checked property (bool) ─────────
            decimal extras = 0m;
            if (chkExtraCheese.Checked)   extras += ADD_EXTRA_CHEESE;
            if (chkStuffedCrust.Checked)  extras += ADD_STUFFED_CRUST;
            if (chkGlutenFree.Checked)    extras += ADD_GLUTEN_FREE;

            // ── ComboBox: quantity ────────────────────────────────
            int qty = (cboQuantity.SelectedIndex >= 0)
                      ? (int)cboQuantity.Items[cboQuantity.SelectedIndex]!
                      : 1;

            decimal unitPrice = sizePrice + specialPrice + crustExtra + extras;
            decimal total     = unitPrice * qty;

            // ── Build summary text ────────────────────────────────
            string specialName = lstSpecials.SelectedItem?.ToString()?.Split(' ')[0] ?? "Cheese";
            string sizeName    = cboSize.SelectedItem?.ToString()?.Split('(')[0].Trim() ?? "Medium";

            txtSummary.Lines = new[]
            {
                $"===  ORDER SUMMARY  ===",
                $"Size:       {sizeName}",
                $"Specialty:  {specialName}",
                $"Crust:      {crustName}",
                $"",
                $"Base Price: {sizePrice:C}",
                $"Specialty:  {specialPrice:C}",
                $"Crust:      {crustExtra:C}",
                $"Extra Chz:  {(chkExtraCheese.Checked ? ADD_EXTRA_CHEESE.ToString("C") : "--")}",
                $"Stfd Crust: {(chkStuffedCrust.Checked ? ADD_STUFFED_CRUST.ToString("C") : "--")}",
                $"G-Free:     {(chkGlutenFree.Checked ? ADD_GLUTEN_FREE.ToString("C") : "--")}",
                $"",
                $"Unit Price: {unitPrice:C}",
                $"Quantity:   {qty}",
                $"─────────────────────",
                $"TOTAL:      {total:C}",
                $"",
                _customerName.Length > 0
                    ? $"Customer:   {_customerName}" : "(no customer info)"
            };

            lblTotal.Text = $"Order Total: {total:C}";
        }

        // ────────────────────────────────────────────────────────
        //  CUSTOMER INFO BUTTON — opens a MODAL dialog
        //  Demonstrates: ShowDialog(), DialogResult, Tag property
        // ────────────────────────────────────────────────────────
        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            // Create an instance of the dialog
            var dlg = new CustomerInfoDialog();

            // Pass data TO the dialog via Tag (Tag is typed as object)
            dlg.Tag = new CustomerData
            {
                Name  = _customerName,
                Phone = _customerPhone,
                Notes = _deliveryNotes
            };

            // ShowDialog() is MODAL — blocks until the dialog closes
            DialogResult result = dlg.ShowDialog();

            // Check how the user dismissed the dialog
            if (result == DialogResult.OK)
            {
                // Retrieve data FROM the dialog via Tag; cast back to correct type
                var data = (CustomerData)dlg.Tag;
                _customerName  = data.Name;
                _customerPhone = data.Phone;
                _deliveryNotes = data.Notes;

                lblCustomerStatus.Text = $"Customer: {_customerName}  |  {_customerPhone}";
                UpdateOrderSummary();
            }
            else // DialogResult.Cancel
            {
                lblCustomerStatus.Text = "Customer info entry cancelled.";
            }
        }

        // ────────────────────────────────────────────────────────
        //  PLACE ORDER — demonstrates MessageBox.Show()
        // ────────────────────────────────────────────────────────
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (_customerName.Length == 0)
            {
                // Simple informational MessageBox
                MessageBox.Show(
                    "Please enter customer information before placing the order.",
                    "Missing Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Full MessageBox with all parameters including default button
            DialogResult answer = MessageBox.Show(
                $"Confirm order for {_customerName}?\n\n{lblTotal.Text}",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);   // default to Yes

            if (answer == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Order placed!\n\nThank you, {_customerName}!\n{lblTotal.Text}",
                    "Order Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            // No → do nothing, return to form
        }

        // ────────────────────────────────────────────────────────
        //  RESET BUTTON
        // ────────────────────────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Reset the entire order?",
                "Reset Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.OK)
            {
                cboSize.SelectedIndex     = 1;
                cboQuantity.SelectedIndex = 0;
                lstSpecials.SelectedIndex = 0;
                rdoThin.Checked           = true;
                chkExtraCheese.Checked    = false;
                chkStuffedCrust.Checked   = false;
                chkGlutenFree.Checked     = false;
                _customerName             = "";
                _customerPhone            = "";
                _deliveryNotes            = "";
                lblCustomerStatus.Text    = "(no customer info)";
                UpdateOrderSummary();
            }
        }

        // ────────────────────────────────────────────────────────
        //  FORM CLOSING — cancel close with confirmation
        //  Demonstrates: FormClosing event, e.Cancel = true
        // ────────────────────────────────────────────────────────
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);  // default to No

            if (answer == DialogResult.No)
            {
                e.Cancel = true;   // prevent the form from closing
            }
        }
    }

    // ── Simple data transfer class for Tag property ─────────────
    // (No lab/test answers here — just a transfer object)
    public class CustomerData
    {
        public string Name  { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Notes { get; set; } = "";
    }
}
