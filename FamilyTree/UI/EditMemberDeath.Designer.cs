namespace FamilyTree.UI
{
    partial class EditMemberDeath
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
            this.cbPlaces = new System.Windows.Forms.ComboBox();
            this.cbCauses = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPlaces
            // 
            this.cbPlaces.FormattingEnabled = true;
            this.cbPlaces.Location = new System.Drawing.Point(146, 177);
            this.cbPlaces.Name = "cbPlaces";
            this.cbPlaces.Size = new System.Drawing.Size(197, 24);
            this.cbPlaces.TabIndex = 20;
            // 
            // cbCauses
            // 
            this.cbCauses.FormattingEnabled = true;
            this.cbCauses.Location = new System.Drawing.Point(146, 127);
            this.cbCauses.Name = "cbCauses";
            this.cbCauses.Size = new System.Drawing.Size(197, 24);
            this.cbCauses.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(143, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 16);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "FullName";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nơi mai táng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nguyên nhân chết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Họ tên";
            // 
            // EditMemberDeath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.cbPlaces);
            this.Controls.Add(this.cbCauses);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EditMemberDeath";
            this.Text = "EditMemberDeath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlaces;
        private System.Windows.Forms.ComboBox cbCauses;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}