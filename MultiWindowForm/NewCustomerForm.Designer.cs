namespace MultiWindowForm
{
    partial class NewCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gbCustomer = new GroupBox();
            btnSave = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneHeading = new Label();
            txtEmail = new TextBox();
            lblEmailHeading = new Label();
            txtName = new TextBox();
            lblHeading = new Label();
            btnClear = new Button();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomer.AutoSize = true;
            gbCustomer.Controls.Add(btnClear);
            gbCustomer.Controls.Add(btnSave);
            gbCustomer.Controls.Add(txtPhoneNumber);
            gbCustomer.Controls.Add(lblPhoneHeading);
            gbCustomer.Controls.Add(txtEmail);
            gbCustomer.Controls.Add(lblEmailHeading);
            gbCustomer.Controls.Add(txtName);
            gbCustomer.Controls.Add(lblHeading);
            gbCustomer.Controls.Add(label1);
            gbCustomer.Location = new Point(12, 12);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(505, 196);
            gbCustomer.TabIndex = 1;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "New Customer";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(123, 93);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(370, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneHeading
            // 
            lblPhoneHeading.AutoSize = true;
            lblPhoneHeading.Location = new Point(6, 95);
            lblPhoneHeading.Name = "lblPhoneHeading";
            lblPhoneHeading.Size = new Size(111, 20);
            lblPhoneHeading.TabIndex = 5;
            lblPhoneHeading.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(123, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblEmailHeading
            // 
            lblEmailHeading.AutoSize = true;
            lblEmailHeading.Location = new Point(6, 62);
            lblEmailHeading.Name = "lblEmailHeading";
            lblEmailHeading.Size = new Size(49, 20);
            lblEmailHeading.TabIndex = 3;
            lblEmailHeading.Text = "Email:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(123, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(370, 27);
            txtName.TabIndex = 2;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(6, 29);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(52, 20);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Name:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(389, 137);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 220);
            Controls.Add(gbCustomer);
            Name = "NewCustomerForm";
            Text = "New Customer Form";
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbCustomer;
        private Label lblHeading;
        private TextBox txtName;
        private TextBox txtPhoneNumber;
        private Label lblPhoneHeading;
        private TextBox txtEmail;
        private Label lblEmailHeading;
        private Button btnSave;
        private Button btnClear;
    }
}