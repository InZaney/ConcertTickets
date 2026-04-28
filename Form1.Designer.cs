namespace ConcertTickets
{
    partial class Form1
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
            lblType = new Label();
            lblAmount = new Label();
            lblTotal = new Label();
            btnCheckout = new Button();
            cboxType = new ComboBox();
            numAmount = new NumericUpDown();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(4, 80);
            lblType.Name = "lblType";
            lblType.Size = new Size(67, 15);
            lblType.TabIndex = 0;
            lblType.Text = "Ticket Type";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 154);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(33, 230);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(66, 295);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(149, 72);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // cboxType
            // 
            cboxType.FormattingEnabled = true;
            cboxType.Location = new Point(78, 77);
            cboxType.MaxDropDownItems = 3;
            cboxType.Name = "cboxType";
            cboxType.Size = new Size(137, 23);
            cboxType.TabIndex = 4;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(78, 152);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(45, 23);
            numAmount.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(78, 227);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(81, 23);
            txtTotal.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 450);
            Controls.Add(txtTotal);
            Controls.Add(numAmount);
            Controls.Add(cboxType);
            Controls.Add(btnCheckout);
            Controls.Add(lblTotal);
            Controls.Add(lblAmount);
            Controls.Add(lblType);
            Name = "Form1";
            Text = "Concert Ticket Purchase";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private Label lblAmount;
        private Label lblTotal;
        private Button btnCheckout;
        private ComboBox cboxType;
        private NumericUpDown numAmount;
        private TextBox txtTotal;
    }
}
