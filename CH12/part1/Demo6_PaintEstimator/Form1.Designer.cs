namespace Demo6_PaintEstimator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblRoomPrompt = new Label();
            txtRoomName = new TextBox();
            lblHeightPrompt = new Label();
            txtHeight = new TextBox();
            lblHeightUnit = new Label();
            lblWidthPrompt = new Label();
            txtWidth = new TextBox();
            lblWidthUnit = new Label();
            btnAdd = new Button();
            btnClearAll = new Button();
            lblError = new Label();
            lblResult = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Paint Estimator";
            // 
            // lblRoomPrompt
            // 
            lblRoomPrompt.AutoSize = true;
            lblRoomPrompt.Font = new Font("Segoe UI", 10F);
            lblRoomPrompt.Location = new Point(20, 55);
            lblRoomPrompt.Name = "lblRoomPrompt";
            lblRoomPrompt.Size = new Size(88, 19);
            lblRoomPrompt.TabIndex = 1;
            lblRoomPrompt.Text = "Room Name:";
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Segoe UI", 10F);
            txtRoomName.Location = new Point(20, 77);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(200, 25);
            txtRoomName.TabIndex = 2;
            // 
            // lblHeightPrompt
            // 
            lblHeightPrompt.AutoSize = true;
            lblHeightPrompt.Font = new Font("Segoe UI", 10F);
            lblHeightPrompt.Location = new Point(20, 115);
            lblHeightPrompt.Name = "lblHeightPrompt";
            lblHeightPrompt.Size = new Size(53, 19);
            lblHeightPrompt.TabIndex = 3;
            lblHeightPrompt.Text = "Height:";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 10F);
            txtHeight.Location = new Point(20, 137);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(80, 25);
            txtHeight.TabIndex = 4;
            // 
            // lblHeightUnit
            // 
            lblHeightUnit.AutoSize = true;
            lblHeightUnit.Font = new Font("Segoe UI", 10F);
            lblHeightUnit.Location = new Point(105, 140);
            lblHeightUnit.Name = "lblHeightUnit";
            lblHeightUnit.Size = new Size(18, 19);
            lblHeightUnit.TabIndex = 5;
            lblHeightUnit.Text = "ft";
            // 
            // lblWidthPrompt
            // 
            lblWidthPrompt.AutoSize = true;
            lblWidthPrompt.Font = new Font("Segoe UI", 10F);
            lblWidthPrompt.Location = new Point(20, 175);
            lblWidthPrompt.Name = "lblWidthPrompt";
            lblWidthPrompt.Size = new Size(49, 19);
            lblWidthPrompt.TabIndex = 6;
            lblWidthPrompt.Text = "Width:";
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Segoe UI", 10F);
            txtWidth.Location = new Point(20, 197);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(80, 25);
            txtWidth.TabIndex = 7;
            // 
            // lblWidthUnit
            // 
            lblWidthUnit.AutoSize = true;
            lblWidthUnit.Font = new Font("Segoe UI", 10F);
            lblWidthUnit.Location = new Point(105, 200);
            lblWidthUnit.Name = "lblWidthUnit";
            lblWidthUnit.Size = new Size(18, 19);
            lblWidthUnit.TabIndex = 8;
            lblWidthUnit.Text = "ft";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.Location = new Point(20, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Wall";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 10F);
            btnClearAll.Location = new Point(120, 240);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 32);
            btnClearAll.TabIndex = 10;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(20, 280);
            lblError.Name = "lblError";
            lblError.Size = new Size(200, 40);
            lblError.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 10F);
            lblResult.Location = new Point(250, 55);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(10);
            lblResult.Size = new Size(320, 220);
            lblResult.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.LightGreen;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(250, 280);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(10);
            lblTotal.Size = new Size(320, 81);
            lblTotal.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 370);
            Controls.Add(lblTitle);
            Controls.Add(lblRoomPrompt);
            Controls.Add(txtRoomName);
            Controls.Add(lblHeightPrompt);
            Controls.Add(txtHeight);
            Controls.Add(lblHeightUnit);
            Controls.Add(lblWidthPrompt);
            Controls.Add(txtWidth);
            Controls.Add(lblWidthUnit);
            Controls.Add(btnAdd);
            Controls.Add(btnClearAll);
            Controls.Add(lblError);
            Controls.Add(lblResult);
            Controls.Add(lblTotal);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demo 6: Paint Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoomPrompt;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lblHeightPrompt;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.Label lblWidthPrompt;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidthUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTotal;
    }
}
