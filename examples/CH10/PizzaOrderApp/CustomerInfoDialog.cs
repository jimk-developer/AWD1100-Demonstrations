// ============================================================
//  CustomerInfoDialog — Guide #10 Custom Modal Dialog
//  Demonstrates: ShowDialog(), DialogResult, Tag property
// ============================================================

namespace PizzaOrderApp
{
    public partial class CustomerInfoDialog : Form
    {
        public CustomerInfoDialog()
        {
            InitializeComponent();
        }

        // ── LOAD: read incoming data from Tag (cast from object) ─
        private void CustomerInfoDialog_Load(object sender, EventArgs e)
        {
            if (this.Tag is CustomerData incoming)
            {
                txtName.Text  = incoming.Name;
                txtPhone.Text = incoming.Phone;
                txtNotes.Text = incoming.Notes;
            }
        }

        // ── OK: validate, store result in Tag, close with OK ─────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter a customer name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Store updated data back in Tag before closing
            // Tag is typed as object — caller casts it back to CustomerData
            this.Tag = new CustomerData
            {
                Name  = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Notes = txtNotes.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;   // closes the dialog
        }

        // ── CANCEL: DialogResult.Cancel set via button property ──
        //    (btnCancel.DialogResult = DialogResult.Cancel in designer)
        //    No extra code needed — the form closes automatically.
    }
}
