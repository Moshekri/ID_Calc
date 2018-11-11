namespace ID_Calc
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBikoret = new System.Windows.Forms.TextBox();
            this.txt8DigitId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "חישוב ספרת ביקורת";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "8 Digit ID Number";
            // 
            // txtFullId
            // 
            this.txtFullId.Location = new System.Drawing.Point(111, 29);
            this.txtFullId.Name = "txtFullId";
            this.txtFullId.Size = new System.Drawing.Size(100, 20);
            this.txtFullId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "סיפרת ביקורת";
            // 
            // txtBikoret
            // 
            this.txtBikoret.Location = new System.Drawing.Point(111, 100);
            this.txtBikoret.Name = "txtBikoret";
            this.txtBikoret.Size = new System.Drawing.Size(100, 20);
            this.txtBikoret.TabIndex = 4;
            // 
            // txt8DigitId
            // 
            this.txt8DigitId.Location = new System.Drawing.Point(111, 76);
            this.txt8DigitId.Name = "txt8DigitId";
            this.txt8DigitId.Size = new System.Drawing.Size(100, 20);
            this.txt8DigitId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "הקלד תעודת זהות";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt8DigitId);
            this.Controls.Add(this.txtBikoret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBikoret;
        private System.Windows.Forms.TextBox txt8DigitId;
        private System.Windows.Forms.Label label3;
    }
}

