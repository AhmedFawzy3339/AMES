
namespace ReservationApplication
{
    partial class Register
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
            this.RegOk = new System.Windows.Forms.Button();
            this.RegCancel = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.TextBox();
            this.RegisterName = new System.Windows.Forms.TextBox();
            this.CPass = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegOk
            // 
            this.RegOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.RegOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegOk.Location = new System.Drawing.Point(173, 291);
            this.RegOk.Name = "RegOk";
            this.RegOk.Size = new System.Drawing.Size(78, 31);
            this.RegOk.TabIndex = 6;
            this.RegOk.Text = "Submit";
            this.RegOk.UseVisualStyleBackColor = false;
            this.RegOk.Click += new System.EventHandler(this.RegOk_Click);
            // 
            // RegCancel
            // 
            this.RegCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.RegCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegCancel.Location = new System.Drawing.Point(282, 291);
            this.RegCancel.Name = "RegCancel";
            this.RegCancel.Size = new System.Drawing.Size(75, 31);
            this.RegCancel.TabIndex = 7;
            this.RegCancel.Text = "Cancel";
            this.RegCancel.UseVisualStyleBackColor = false;
            this.RegCancel.Click += new System.EventHandler(this.RegCancel_Click);
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.AliceBlue;
            this.Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phone.Location = new System.Drawing.Point(182, 95);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(164, 20);
            this.Phone.TabIndex = 2;
            // 
            // RegisterName
            // 
            this.RegisterName.BackColor = System.Drawing.Color.AliceBlue;
            this.RegisterName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterName.Location = new System.Drawing.Point(182, 50);
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.Size = new System.Drawing.Size(164, 20);
            this.RegisterName.TabIndex = 1;
            // 
            // CPass
            // 
            this.CPass.BackColor = System.Drawing.Color.AliceBlue;
            this.CPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPass.Location = new System.Drawing.Point(182, 232);
            this.CPass.Name = "CPass";
            this.CPass.PasswordChar = '*';
            this.CPass.Size = new System.Drawing.Size(164, 20);
            this.CPass.TabIndex = 5;
            this.CPass.UseSystemPasswordChar = true;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.AliceBlue;
            this.Pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pass.Location = new System.Drawing.Point(182, 188);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(164, 20);
            this.Pass.TabIndex = 4;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.AliceBlue;
            this.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email.Location = new System.Drawing.Point(182, 142);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(164, 20);
            this.Email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(95, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label4.Location = new System.Drawing.Point(79, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label5.Location = new System.Drawing.Point(57, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(58)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(191, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "All Fields Are Required";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(508, 373);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.CPass);
            this.Controls.Add(this.RegisterName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.RegCancel);
            this.Controls.Add(this.RegOk);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegOk;
        private System.Windows.Forms.Button RegCancel;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox RegisterName;
        private System.Windows.Forms.TextBox CPass;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}