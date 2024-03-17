namespace GuiApp
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
            ilosc_text = new TextBox();
            ziarno_text = new TextBox();
            pojemnosc_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            result_text = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(170, 93);
            button1.Name = "button1";
            button1.Size = new Size(98, 50);
            button1.TabIndex = 0;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ilosc_text
            // 
            ilosc_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ilosc_text.Location = new Point(22, 47);
            ilosc_text.Name = "ilosc_text";
            ilosc_text.Size = new Size(125, 27);
            ilosc_text.TabIndex = 1;
            ilosc_text.TextChanged += ilosc_text_TextChanged;
            // 
            // ziarno_text
            // 
            ziarno_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ziarno_text.Location = new Point(22, 105);
            ziarno_text.Name = "ziarno_text";
            ziarno_text.Size = new Size(125, 27);
            ziarno_text.TabIndex = 2;
            ziarno_text.TextChanged += ziarno_text_TextChanged;
            // 
            // pojemnosc_text
            // 
            pojemnosc_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pojemnosc_text.Location = new Point(22, 169);
            pojemnosc_text.Name = "pojemnosc_text";
            pojemnosc_text.Size = new Size(125, 27);
            pojemnosc_text.TabIndex = 3;
            pojemnosc_text.TextChanged += pojemnosc_text_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Ilosc przedmiotow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 221);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Result";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(458, 23);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Instancja";
            // 
            // result_text
            // 
            result_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            result_text.BorderStyle = BorderStyle.FixedSingle;
            result_text.Location = new Point(22, 244);
            result_text.Multiline = true;
            result_text.Name = "result_text";
            result_text.ReadOnly = true;
            result_text.Size = new Size(246, 195);
            result_text.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(292, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(233, 393);
            textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 457);
            Controls.Add(textBox1);
            Controls.Add(result_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pojemnosc_text);
            Controls.Add(ziarno_text);
            Controls.Add(ilosc_text);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ilosc_text;
        private TextBox ziarno_text;
        private TextBox pojemnosc_text;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox result_text;
        private TextBox textBox1;
    }
}
