
namespace ATMProject
{
    partial class frmDashBoard
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
            this.BtnBalance = new System.Windows.Forms.Button();
            this.bntWithdraw = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBalance
            // 
            this.BtnBalance.Location = new System.Drawing.Point(550, 116);
            this.BtnBalance.Name = "BtnBalance";
            this.BtnBalance.Size = new System.Drawing.Size(146, 57);
            this.BtnBalance.TabIndex = 0;
            this.BtnBalance.Text = "Check Balance";
            this.BtnBalance.UseVisualStyleBackColor = true;
            this.BtnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
            // 
            // bntWithdraw
            // 
            this.bntWithdraw.Location = new System.Drawing.Point(36, 116);
            this.bntWithdraw.Name = "bntWithdraw";
            this.bntWithdraw.Size = new System.Drawing.Size(146, 57);
            this.bntWithdraw.TabIndex = 1;
            this.bntWithdraw.Text = "Withdraw";
            this.bntWithdraw.UseVisualStyleBackColor = true;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(550, 281);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(146, 57);
            this.BtnLogOut.TabIndex = 2;
            this.BtnLogOut.Text = "LogOut";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(36, 281);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(146, 57);
            this.BtnDeposit.TabIndex = 3;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.bntWithdraw);
            this.Controls.Add(this.BtnBalance);
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBalance;
        private System.Windows.Forms.Button bntWithdraw;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnDeposit;
    }
}

