namespace Hammingova_vzdalenost
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(119, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(119, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(119, 192);
            button1.Name = "button1";
            button1.Size = new Size(288, 43);
            button1.TabIndex = 2;
            button1.Text = "Vypočítej Hammingovu vzdálenost";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "1. Hodnota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "2. Hodnota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 23);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 5;
            label3.Text = "Zadejte hodnoty v celých číslech";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 247);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Hammingova vzdálenost";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
