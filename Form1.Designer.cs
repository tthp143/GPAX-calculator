namespace GPAX
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
            button1 = new Button();
            label1 = new Label();
            score_TB = new TextBox();
            MaxSC_TB = new TextBox();
            label2 = new Label();
            Gpax_TB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            MinSC_TB = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(274, 75);
            button1.Name = "button1";
            button1.Size = new Size(115, 72);
            button1.TabIndex = 0;
            button1.Text = "Add Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Yourscore";
            // 
            // score_TB
            // 
            score_TB.Location = new Point(114, 29);
            score_TB.Name = "score_TB";
            score_TB.Size = new Size(125, 27);
            score_TB.TabIndex = 2;
            // 
            // MaxSC_TB
            // 
            MaxSC_TB.Location = new Point(114, 72);
            MaxSC_TB.Name = "MaxSC_TB";
            MaxSC_TB.Size = new Size(125, 27);
            MaxSC_TB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "High Score";
            // 
            // Gpax_TB
            // 
            Gpax_TB.Location = new Point(114, 159);
            Gpax_TB.Name = "Gpax_TB";
            Gpax_TB.Size = new Size(125, 27);
            Gpax_TB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "GPAX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 120);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Low Score";
            // 
            // MinSC_TB
            // 
            MinSC_TB.Location = new Point(114, 117);
            MinSC_TB.Name = "MinSC_TB";
            MinSC_TB.Size = new Size(125, 27);
            MinSC_TB.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(MinSC_TB);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(score_TB);
            groupBox1.Controls.Add(Gpax_TB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MaxSC_TB);
            groupBox1.Location = new Point(49, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 205);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "GPAX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 306);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox score_TB;
        private TextBox MaxSC_TB;
        private Label label2;
        private TextBox Gpax_TB;
        private Label label3;
        private Label label4;
        private TextBox MinSC_TB;
        private GroupBox groupBox1;
    }
}
