namespace CircumferenceThomasA
{
    partial class frmCircumference
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
            this.lblRadiusPrompt = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblCircumferenePrompt = new System.Windows.Forms.Label();
            this.lblCircumferenceAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadiusPrompt
            // 
            this.lblRadiusPrompt.AutoSize = true;
            this.lblRadiusPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusPrompt.Location = new System.Drawing.Point(12, 63);
            this.lblRadiusPrompt.Name = "lblRadiusPrompt";
            this.lblRadiusPrompt.Size = new System.Drawing.Size(262, 20);
            this.lblRadiusPrompt.TabIndex = 0;
            this.lblRadiusPrompt.Text = "Enter the radius of the circle (in cm):";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(326, 65);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // lblCircumferenePrompt
            // 
            this.lblCircumferenePrompt.AutoSize = true;
            this.lblCircumferenePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumferenePrompt.Location = new System.Drawing.Point(25, 209);
            this.lblCircumferenePrompt.Name = "lblCircumferenePrompt";
            this.lblCircumferenePrompt.Size = new System.Drawing.Size(159, 20);
            this.lblCircumferenePrompt.TabIndex = 2;
            this.lblCircumferenePrompt.Text = "The circumference is:";
            // 
            // lblCircumferenceAnswer
            // 
            this.lblCircumferenceAnswer.AutoSize = true;
            this.lblCircumferenceAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumferenceAnswer.Location = new System.Drawing.Point(202, 209);
            this.lblCircumferenceAnswer.Name = "lblCircumferenceAnswer";
            this.lblCircumferenceAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblCircumferenceAnswer.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(284, 139);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 259);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCircumferenceAnswer);
            this.Controls.Add(this.lblCircumferenePrompt);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadiusPrompt);
            this.Name = "frmCircumference";
            this.Text = "Circumference By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadiusPrompt;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblCircumferenePrompt;
        private System.Windows.Forms.Label lblCircumferenceAnswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}

