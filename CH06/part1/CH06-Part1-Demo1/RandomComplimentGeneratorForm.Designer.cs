namespace CH06_Part1_Demo1
{
    partial class RandomComplimentGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerate = new Button();
            lblCompliment1 = new Label();
            lblCompliment2 = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.LightBlue;
            btnGenerate.FlatAppearance.BorderSize = 2;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = SystemColors.ControlText;
            btnGenerate.Location = new Point(146, 66);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(139, 37);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Get Compliments";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblCompliment1
            // 
            lblCompliment1.ForeColor = SystemColors.HotTrack;
            lblCompliment1.Location = new Point(27, 142);
            lblCompliment1.Name = "lblCompliment1";
            lblCompliment1.Size = new Size(335, 23);
            lblCompliment1.TabIndex = 1;
            // 
            // lblCompliment2
            // 
            lblCompliment2.ForeColor = SystemColors.HotTrack;
            lblCompliment2.Location = new Point(27, 180);
            lblCompliment2.Name = "lblCompliment2";
            lblCompliment2.Size = new Size(335, 23);
            lblCompliment2.TabIndex = 2;
            // 
            // RandomComplimentGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 279);
            Controls.Add(lblCompliment2);
            Controls.Add(lblCompliment1);
            Controls.Add(btnGenerate);
            Name = "RandomComplimentGeneratorForm";
            Text = "Random Compliment Generator";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private Label lblCompliment1;
        private Label lblCompliment2;
    }
}
