namespace multiply
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(190, 29);
            label1.Name = "label1";
            label1.Size = new Size(385, 49);
            label1.TabIndex = 0;
            label1.Text = "QUIZ GAME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(53, 150);
            label2.Name = "label2";
            label2.Size = new Size(353, 49);
            label2.TabIndex = 1;
            label2.Text = "LEVEL1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(392, 150);
            label3.Name = "label3";
            label3.Size = new Size(342, 49);
            label3.TabIndex = 2;
            label3.Text = "LEVEL2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(53, 278);
            label4.Name = "label4";
            label4.Size = new Size(342, 49);
            label4.TabIndex = 3;
            label4.Text = "LEVEL3";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(404, 278);
            label5.Name = "label5";
            label5.Size = new Size(339, 49);
            label5.TabIndex = 4;
            label5.Text = "LEVEL4";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
