namespace FamilyTree.UI
{
    partial class ResetPasswordRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordRequest));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.btnSendCode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCheckCode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 58);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(76, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code:";
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(93, 118);
            this.txtVerificationCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(76, 20);
            this.txtVerificationCode.TabIndex = 3;
            // 
            // btnSendCode
            // 
            this.btnSendCode.ActiveBorderThickness = 1;
            this.btnSendCode.ActiveCornerRadius = 20;
            this.btnSendCode.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnSendCode.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendCode.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnSendCode.BackColor = System.Drawing.Color.White;
            this.btnSendCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendCode.BackgroundImage")));
            this.btnSendCode.ButtonText = "Send";
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.IdleBorderThickness = 1;
            this.btnSendCode.IdleCornerRadius = 20;
            this.btnSendCode.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSendCode.IdleForecolor = System.Drawing.Color.White;
            this.btnSendCode.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnSendCode.Location = new System.Drawing.Point(222, 49);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(63, 38);
            this.btnSendCode.TabIndex = 5;
            this.btnSendCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.ActiveBorderThickness = 1;
            this.btnCheckCode.ActiveCornerRadius = 20;
            this.btnCheckCode.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnCheckCode.ActiveForecolor = System.Drawing.Color.White;
            this.btnCheckCode.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnCheckCode.BackColor = System.Drawing.Color.White;
            this.btnCheckCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckCode.BackgroundImage")));
            this.btnCheckCode.ButtonText = "Send";
            this.btnCheckCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCode.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCode.ForeColor = System.Drawing.Color.White;
            this.btnCheckCode.IdleBorderThickness = 1;
            this.btnCheckCode.IdleCornerRadius = 20;
            this.btnCheckCode.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckCode.IdleForecolor = System.Drawing.Color.White;
            this.btnCheckCode.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnCheckCode.Location = new System.Drawing.Point(222, 106);
            this.btnCheckCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(63, 38);
            this.btnCheckCode.TabIndex = 6;
            this.btnCheckCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // ResetPasswordRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 202);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResetPasswordRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendCode;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCheckCode;
    }
}