
namespace WindowsFormsApp1
{
    partial class loginForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.authofication = new System.Windows.Forms.Label();
            this.userLbn = new System.Windows.Forms.Label();
            this.pswdLbn = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(327, 145);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(210, 38);
            this.nameBox.TabIndex = 0;
            // 
            // pswBox
            // 
            this.pswBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswBox.Location = new System.Drawing.Point(327, 189);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(210, 38);
            this.pswBox.TabIndex = 1;
            this.pswBox.UseSystemPasswordChar = true;
            // 
            // authofication
            // 
            this.authofication.AutoSize = true;
            this.authofication.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authofication.Location = new System.Drawing.Point(260, 30);
            this.authofication.Name = "authofication";
            this.authofication.Size = new System.Drawing.Size(304, 55);
            this.authofication.TabIndex = 2;
            this.authofication.Text = "Authorization";
            this.authofication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLbn
            // 
            this.userLbn.AutoSize = true;
            this.userLbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLbn.Location = new System.Drawing.Point(78, 135);
            this.userLbn.Name = "userLbn";
            this.userLbn.Size = new System.Drawing.Size(157, 32);
            this.userLbn.TabIndex = 5;
            this.userLbn.Text = "Your Name";
            // 
            // pswdLbn
            // 
            this.pswdLbn.AutoSize = true;
            this.pswdLbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswdLbn.Location = new System.Drawing.Point(78, 179);
            this.pswdLbn.Name = "pswdLbn";
            this.pswdLbn.Size = new System.Drawing.Size(206, 32);
            this.pswdLbn.TabIndex = 6;
            this.pswdLbn.Text = "Your Password";
            // 
            // authBtn
            // 
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBtn.Location = new System.Drawing.Point(305, 299);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(182, 54);
            this.authBtn.TabIndex = 7;
            this.authBtn.Text = "OK";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.pswdLbn);
            this.Controls.Add(this.userLbn);
            this.Controls.Add(this.authofication);
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.nameBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox pswBox;
        private System.Windows.Forms.Label authofication;
        private System.Windows.Forms.Label userLbn;
        private System.Windows.Forms.Label pswdLbn;
        private System.Windows.Forms.Button authBtn;
    }
}

