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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(691, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Cost";
            label1.Click += label1_Click;
            // 
            // productDropdown
            // 
            productDropdown.FormattingEnabled = true;
            productDropdown.Location = new Point(27, 15);
            productDropdown.Name = "productDropdown";
            productDropdown.Size = new Size(444, 33);
            productDropdown.TabIndex = 2;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(359, 75);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(112, 34);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.ForeColor = Color.DimGray;
            textBox.Location = new Point(27, 115);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(733, 323);
            textBox.TabIndex = 4;
            textBox.Text = "Console output";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(btn_confirm);
            Controls.Add(productDropdown);
            Controls.Add(label1);
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
    }
}