namespace ProductSpec
{
    partial class MainForm
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
            label1 = new Label();
            productDropdown = new ComboBox();
            btn_confirm = new Button();
            textBox = new TextBox();
            textBoxPlus = new TextBox();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Cost";
            label1.Click += label1_Click;
            // 
            // productDropdown
            // 
            productDropdown.FormattingEnabled = true;
            productDropdown.Location = new Point(11, 6);
            productDropdown.Margin = new Padding(2);
            productDropdown.Name = "productDropdown";
            productDropdown.Size = new Size(312, 23);
            productDropdown.TabIndex = 2;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(258, 143);
            btn_confirm.Margin = new Padding(2);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(95, 31);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Write to file";
            btn_confirm.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.ForeColor = SystemColors.ControlDarkDark;
            textBox.Location = new Point(14, 51);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(240, 124);
            textBox.TabIndex = 4;
            textBox.Text = "Product description";
            // 
            // textBoxPlus
            // 
            textBoxPlus.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPlus.ForeColor = SystemColors.WindowText;
            textBoxPlus.Location = new Point(258, 50);
            textBoxPlus.Multiline = true;
            textBoxPlus.Name = "textBoxPlus";
            textBoxPlus.ReadOnly = true;
            textBoxPlus.Size = new Size(138, 89);
            textBoxPlus.TabIndex = 5;
            textBoxPlus.Text = "Plus text here";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(358, 143);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(38, 31);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 186);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxPlus);
            Controls.Add(textBox);
            Controls.Add(btn_confirm);
            Controls.Add(productDropdown);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox productDropdown;
        private Button btn_confirm;
        private TextBox textBox;
        private TextBox textBoxPlus;
        private Button buttonHelp;
    }
}