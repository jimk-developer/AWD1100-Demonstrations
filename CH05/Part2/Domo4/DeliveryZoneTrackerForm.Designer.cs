namespace Domo4
{
    partial class DeliveryZoneTrackerForm
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
            lblPrompt = new Label();
            btnNorth = new Button();
            txtMiles = new TextBox();
            label1 = new Label();
            btnSouth = new Button();
            btnWest = new Button();
            lblNorth = new Label();
            lblSouth = new Label();
            lblWest = new Label();
            lblTotal = new Label();
            lblHighest = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(23, 26);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(236, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "How many miles was the delivery?";
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(25, 110);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 35);
            btnNorth.TabIndex = 1;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(260, 25);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(100, 27);
            txtMiles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 75);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 3;
            label1.Text = "Which zone was the delivery?";
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(125, 110);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 35);
            btnSouth.TabIndex = 4;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(222, 110);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 35);
            btnWest.TabIndex = 5;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // lblNorth
            // 
            lblNorth.AutoSize = true;
            lblNorth.Location = new Point(25, 184);
            lblNorth.Name = "lblNorth";
            lblNorth.Size = new Size(50, 20);
            lblNorth.TabIndex = 6;
            lblNorth.Text = "label2";
            // 
            // lblSouth
            // 
            lblSouth.AutoSize = true;
            lblSouth.Location = new Point(25, 227);
            lblSouth.Name = "lblSouth";
            lblSouth.Size = new Size(50, 20);
            lblSouth.TabIndex = 7;
            lblSouth.Text = "label2";
            // 
            // lblWest
            // 
            lblWest.AutoSize = true;
            lblWest.Location = new Point(25, 276);
            lblWest.Name = "lblWest";
            lblWest.Size = new Size(50, 20);
            lblWest.TabIndex = 8;
            lblWest.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(25, 315);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "label2";
            // 
            // lblHighest
            // 
            lblHighest.AutoSize = true;
            lblHighest.Location = new Point(25, 353);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(50, 20);
            lblHighest.TabIndex = 10;
            lblHighest.Text = "label2";
            // 
            // DeliveryZoneTrackerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHighest);
            Controls.Add(lblTotal);
            Controls.Add(lblWest);
            Controls.Add(lblSouth);
            Controls.Add(lblNorth);
            Controls.Add(btnWest);
            Controls.Add(btnSouth);
            Controls.Add(label1);
            Controls.Add(txtMiles);
            Controls.Add(btnNorth);
            Controls.Add(lblPrompt);
            Name = "DeliveryZoneTrackerForm";
            Text = "Delivery Zone Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private Button btnNorth;
        private TextBox txtMiles;
        private Label label1;
        private Button btnSouth;
        private Button btnWest;
        private Label lblNorth;
        private Label lblSouth;
        private Label lblWest;
        private Label lblTotal;
        private Label lblHighest;
    }
}
