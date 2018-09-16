namespace MontyHall
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
            this.doorButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doorButton2 = new System.Windows.Forms.RadioButton();
            this.doorButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.informationText = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doorButton1
            // 
            this.doorButton1.AutoSize = true;
            this.doorButton1.Location = new System.Drawing.Point(3, 3);
            this.doorButton1.Name = "doorButton1";
            this.doorButton1.Size = new System.Drawing.Size(57, 17);
            this.doorButton1.TabIndex = 3;
            this.doorButton1.TabStop = true;
            this.doorButton1.Text = "Door 1";
            this.doorButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.doorButton3);
            this.panel1.Controls.Add(this.doorButton2);
            this.panel1.Controls.Add(this.doorButton1);
            this.panel1.Location = new System.Drawing.Point(26, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // doorButton2
            // 
            this.doorButton2.AutoSize = true;
            this.doorButton2.Location = new System.Drawing.Point(4, 44);
            this.doorButton2.Name = "doorButton2";
            this.doorButton2.Size = new System.Drawing.Size(57, 17);
            this.doorButton2.TabIndex = 4;
            this.doorButton2.TabStop = true;
            this.doorButton2.Text = "Door 2";
            this.doorButton2.UseVisualStyleBackColor = true;
            // 
            // doorButton3
            // 
            this.doorButton3.AutoSize = true;
            this.doorButton3.Location = new System.Drawing.Point(4, 80);
            this.doorButton3.Name = "doorButton3";
            this.doorButton3.Size = new System.Drawing.Size(57, 17);
            this.doorButton3.TabIndex = 5;
            this.doorButton3.TabStop = true;
            this.doorButton3.Text = "Door 3";
            this.doorButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monty Hall Simulator";
            // 
            // informationText
            // 
            this.informationText.Location = new System.Drawing.Point(233, 107);
            this.informationText.Multiline = true;
            this.informationText.Name = "informationText";
            this.informationText.ReadOnly = true;
            this.informationText.Size = new System.Drawing.Size(245, 100);
            this.informationText.TabIndex = 6;
            this.informationText.TextChanged += new System.EventHandler(this.informationText_TextChanged);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(30, 214);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(196, 31);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(233, 214);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(245, 31);
            this.RestartButton.TabIndex = 8;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 426);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.informationText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Monty Hall Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton doorButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton doorButton3;
        private System.Windows.Forms.RadioButton doorButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox informationText;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button RestartButton;
    }
}

