namespace Sortering
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
            this.txtTalindput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnBubble = new System.Windows.Forms.RadioButton();
            this.rbnMerge = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstSorteretTal = new System.Windows.Forms.ListBox();
            this.lstGeneretTal = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbnGenerettal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTalindput
            // 
            this.txtTalindput.Location = new System.Drawing.Point(12, 69);
            this.txtTalindput.Name = "txtTalindput";
            this.txtTalindput.Size = new System.Drawing.Size(194, 22);
            this.txtTalindput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hvor mange tal vil du gerne genere?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hvilken algoritme vil du bruge?";
            // 
            // rbnBubble
            // 
            this.rbnBubble.AutoSize = true;
            this.rbnBubble.Location = new System.Drawing.Point(15, 160);
            this.rbnBubble.Name = "rbnBubble";
            this.rbnBubble.Size = new System.Drawing.Size(97, 21);
            this.rbnBubble.TabIndex = 3;
            this.rbnBubble.TabStop = true;
            this.rbnBubble.Text = "Bubblesort";
            this.rbnBubble.UseVisualStyleBackColor = true;
            this.rbnBubble.CheckedChanged += new System.EventHandler(this.RbnBubble_CheckedChanged);
            // 
            // rbnMerge
            // 
            this.rbnMerge.AutoSize = true;
            this.rbnMerge.Location = new System.Drawing.Point(15, 187);
            this.rbnMerge.Name = "rbnMerge";
            this.rbnMerge.Size = new System.Drawing.Size(93, 21);
            this.rbnMerge.TabIndex = 4;
            this.rbnMerge.TabStop = true;
            this.rbnMerge.Text = "Mergesort";
            this.rbnMerge.UseVisualStyleBackColor = true;
            this.rbnMerge.CheckedChanged += new System.EventHandler(this.RbnMerge_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 94);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstSorteretTal
            // 
            this.lstSorteretTal.FormattingEnabled = true;
            this.lstSorteretTal.ItemHeight = 16;
            this.lstSorteretTal.Location = new System.Drawing.Point(493, 12);
            this.lstSorteretTal.Name = "lstSorteretTal";
            this.lstSorteretTal.Size = new System.Drawing.Size(193, 516);
            this.lstSorteretTal.TabIndex = 8;
            // 
            // lstGeneretTal
            // 
            this.lstGeneretTal.FormattingEnabled = true;
            this.lstGeneretTal.ItemHeight = 16;
            this.lstGeneretTal.Location = new System.Drawing.Point(257, 12);
            this.lstGeneretTal.Name = "lstGeneretTal";
            this.lstGeneretTal.Size = new System.Drawing.Size(193, 516);
            this.lstGeneretTal.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 491);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "cycles";
            // 
            // cbnGenerettal
            // 
            this.cbnGenerettal.AutoSize = true;
            this.cbnGenerettal.Location = new System.Drawing.Point(12, 97);
            this.cbnGenerettal.Name = "cbnGenerettal";
            this.cbnGenerettal.Size = new System.Drawing.Size(220, 21);
            this.cbnGenerettal.TabIndex = 16;
            this.cbnGenerettal.Text = "Vil du beholde de generet tal?";
            this.cbnGenerettal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.cbnGenerettal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstGeneretTal);
            this.Controls.Add(this.lstSorteretTal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbnMerge);
            this.Controls.Add(this.rbnBubble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTalindput);
            this.Name = "Form1";
            this.Text = "Shaker Shaker, Hey Partymaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTalindput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnBubble;
        private System.Windows.Forms.RadioButton rbnMerge;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstSorteretTal;
        private System.Windows.Forms.ListBox lstGeneretTal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbnGenerettal;
    }
}

