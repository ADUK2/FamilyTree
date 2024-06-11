namespace FamilyTree.UI
{
    partial class PasswordUpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordUpdateDialog));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(129, 55);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(132, 20);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(129, 93);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(132, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xác Nhận Mật Khẩu:";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.ActiveBorderThickness = 1;
            this.btnUpdatePassword.ActiveCornerRadius = 20;
            this.btnUpdatePassword.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnUpdatePassword.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdatePassword.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnUpdatePassword.BackColor = System.Drawing.Color.White;
            this.btnUpdatePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePassword.BackgroundImage")));
            this.btnUpdatePassword.ButtonText = "Cập nhật mật khẩu";
            this.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.IdleBorderThickness = 1;
            this.btnUpdatePassword.IdleCornerRadius = 20;
            this.btnUpdatePassword.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatePassword.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdatePassword.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnUpdatePassword.Location = new System.Drawing.Point(68, 143);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(135, 39);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click_1);
            // 
            // PasswordUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 223);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PasswordUpdateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordUpdateDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdatePassword;
    }
}