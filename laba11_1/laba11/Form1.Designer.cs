namespace laba11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 369);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(360, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(44, 27);
            label1.TabIndex = 1;
            label1.Text = "n =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold);
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(224, 27);
            label2.TabIndex = 2;
            label2.Text = "Сумма по формуле:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rubik", 15.7499981F, FontStyle.Bold);
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(182, 27);
            label3.TabIndex = 3;
            label3.Text = "Сумма в цикле: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Cond", 11.2499981F, FontStyle.Bold);
            label4.Location = new Point(33, 35);
            label4.Name = "label4";
            label4.Size = new Size(328, 20);
            label4.TabIndex = 4;
            label4.Text = "1^2 + 3^2 + 5^2 + ⋯ + (2𝑛 − 1)^2 = 𝑛(4𝑛^2 − 1)/3";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            checkBox1.Location = new Point(33, 322);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 26);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "По формуле";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(239, 322);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 26);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "В цикле";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(384, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Sum";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
