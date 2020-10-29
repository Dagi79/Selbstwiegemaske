namespace Selbstwiegemaske
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblHallo = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(323, 43);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 48);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Klick mich";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblHallo
            // 
            this.lblHallo.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblHallo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblHallo.Appearance.Options.UseFont = true;
            this.lblHallo.Appearance.Options.UseForeColor = true;
            this.lblHallo.Location = new System.Drawing.Point(305, 114);
            this.lblHallo.Name = "lblHallo";
            this.lblHallo.Size = new System.Drawing.Size(124, 33);
            this.lblHallo.TabIndex = 1;
            this.lblHallo.Text = "Moin moin";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(325, 182);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(221, 39);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "NICHT DRÜCKEN";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lblHallo);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblHallo;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

