namespace WindowsFormsExampleUserControl
{
    partial class Form1
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
            this.myUserControl2 = new WindowsFormsExampleUserControl.MyUserControl();
            this.myUserControl1 = new WindowsFormsExampleUserControl.MyUserControl();
            this.SuspendLayout();
            // 
            // myUserControl2
            // 
            this.myUserControl2.AutoSize = true;
            this.myUserControl2.GetCustom = true;
            this.myUserControl2.Location = new System.Drawing.Point(86, 67);
            this.myUserControl2.Name = "myUserControl2";
            this.myUserControl2.Size = new System.Drawing.Size(418, 360);
            this.myUserControl2.TabIndex = 1;
            // 
            // myUserControl1
            // 
            this.myUserControl1.AutoSize = true;
            this.myUserControl1.GetCustom = false;
            this.myUserControl1.Location = new System.Drawing.Point(31, 154);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(418, 360);
            this.myUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myUserControl2);
            this.Controls.Add(this.myUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyUserControl myUserControl1;
        private MyUserControl myUserControl2;
    }
}

