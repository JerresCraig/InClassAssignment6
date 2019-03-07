namespace InClassAssignment6
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblNumRolls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(112, 291);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(262, 61);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD1.Location = new System.Drawing.Point(112, 97);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(125, 135);
            this.lblD1.TabIndex = 1;
            this.lblD1.Text = "#";
            this.lblD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD2.Location = new System.Drawing.Point(249, 97);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(125, 135);
            this.lblD2.TabIndex = 2;
            this.lblD2.Text = "#";
            this.lblD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumRolls
            // 
            this.lblNumRolls.AutoSize = true;
            this.lblNumRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRolls.Location = new System.Drawing.Point(222, 355);
            this.lblNumRolls.Name = "lblNumRolls";
            this.lblNumRolls.Size = new System.Drawing.Size(51, 55);
            this.lblNumRolls.TabIndex = 3;
            this.lblNumRolls.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.lblNumRolls);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblNumRolls;
    }
}

