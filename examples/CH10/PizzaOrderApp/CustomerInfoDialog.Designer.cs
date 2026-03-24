namespace PizzaOrderApp
{
    partial class CustomerInfoDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblHeader    = new System.Windows.Forms.Label();
            this.lblNameCap   = new System.Windows.Forms.Label();
            this.txtName      = new System.Windows.Forms.TextBox();
            this.lblPhoneCap  = new System.Windows.Forms.Label();
            this.txtPhone     = new System.Windows.Forms.TextBox();
            this.lblNotesCap  = new System.Windows.Forms.Label();
            this.txtNotes     = new System.Windows.Forms.TextBox();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── lblHeader ────────────────────────────────────────────────────────
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location  = new System.Drawing.Point(0, 0);
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.Size      = new System.Drawing.Size(374, 36);
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Enter Customer Information";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblNameCap ───────────────────────────────────────────────────────
            this.lblNameCap.AutoSize = true;
            this.lblNameCap.Location = new System.Drawing.Point(20, 50);
            this.lblNameCap.Name     = "lblNameCap";
            this.lblNameCap.TabIndex = 1;
            this.lblNameCap.Text     = "Customer Name:";

            // ── txtName ──────────────────────────────────────────────────────────
            this.txtName.Location  = new System.Drawing.Point(20, 68);
            this.txtName.MaxLength = 60;
            this.txtName.Name      = "txtName";
            this.txtName.Size      = new System.Drawing.Size(320, 23);
            this.txtName.TabIndex  = 2;

            // ── lblPhoneCap ──────────────────────────────────────────────────────
            this.lblPhoneCap.AutoSize = true;
            this.lblPhoneCap.Location = new System.Drawing.Point(20, 102);
            this.lblPhoneCap.Name     = "lblPhoneCap";
            this.lblPhoneCap.TabIndex = 3;
            this.lblPhoneCap.Text     = "Phone Number:";

            // ── txtPhone ─────────────────────────────────────────────────────────
            this.txtPhone.Location  = new System.Drawing.Point(20, 120);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name      = "txtPhone";
            this.txtPhone.Size      = new System.Drawing.Size(320, 23);
            this.txtPhone.TabIndex  = 4;

            // ── lblNotesCap ──────────────────────────────────────────────────────
            this.lblNotesCap.AutoSize = true;
            this.lblNotesCap.Location = new System.Drawing.Point(20, 154);
            this.lblNotesCap.Name     = "lblNotesCap";
            this.lblNotesCap.TabIndex = 5;
            this.lblNotesCap.Text     = "Delivery Notes (optional):";

            // ── txtNotes ─────────────────────────────────────────────────────────
            this.txtNotes.Location  = new System.Drawing.Point(20, 172);
            this.txtNotes.MaxLength = 200;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name      = "txtNotes";
            this.txtNotes.Size      = new System.Drawing.Size(320, 56);
            this.txtNotes.TabIndex  = 6;

            // ── btnSave  (code sets DialogResult.OK) ─────────────────────────────
            this.btnSave.BackColor            = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSave.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor            = System.Drawing.Color.White;
            this.btnSave.Location             = new System.Drawing.Point(20, 242);
            this.btnSave.Name                 = "btnSave";
            this.btnSave.Size                 = new System.Drawing.Size(190, 30);
            this.btnSave.TabIndex             = 7;
            this.btnSave.Text                 = "Save  (DialogResult.OK)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click               += new System.EventHandler(this.btnSave_Click);

            // ── btnCancel  (DialogResult set via property — no code needed) ───────
            this.btnCancel.BackColor            = System.Drawing.Color.FromArgb(200, 60, 40);
            this.btnCancel.DialogResult         = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor            = System.Drawing.Color.White;
            this.btnCancel.Location             = new System.Drawing.Point(220, 242);
            this.btnCancel.Name                 = "btnCancel";
            this.btnCancel.Size                 = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex             = 8;
            this.btnCancel.Text                 = "Cancel  (auto)";
            this.btnCancel.UseVisualStyleBackColor = false;

            // ── Form ─────────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(248, 248, 248);
            this.CancelButton        = this.btnCancel;
            this.ClientSize          = new System.Drawing.Size(374, 290);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.Name                = "CustomerInfoDialog";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text                = "Customer Information";
            this.Load               += new System.EventHandler(this.CustomerInfoDialog_Load);

            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNameCap);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhoneCap);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblNotesCap);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── control field declarations ───────────────────────────────────────
        private System.Windows.Forms.Label   lblHeader;
        private System.Windows.Forms.Label   lblNameCap;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label   lblPhoneCap;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label   lblNotesCap;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button  btnSave;
        private System.Windows.Forms.Button  btnCancel;
    }
}
