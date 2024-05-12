namespace ATMMachine_Group3
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnStartTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartTransaction
            // 
            this.btnStartTransaction.BackColor = System.Drawing.Color.Black;
            this.btnStartTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTransaction.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTransaction.ForeColor = System.Drawing.Color.White;
            this.btnStartTransaction.Location = new System.Drawing.Point(502, 340);
            this.btnStartTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartTransaction.Name = "btnStartTransaction";
            this.btnStartTransaction.Size = new System.Drawing.Size(250, 50);
            this.btnStartTransaction.TabIndex = 1;
            this.btnStartTransaction.Text = "Start Transaction";
            this.btnStartTransaction.UseVisualStyleBackColor = false;
            this.btnStartTransaction.Click += new System.EventHandler(this.btnStartTransaction_Click_1);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ATMMachine_Group3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnStartTransaction);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Machine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartTransaction;
    }
}

