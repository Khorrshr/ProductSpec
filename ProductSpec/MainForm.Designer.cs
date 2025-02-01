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
            btn_button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 113);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "Test";
            label1.Click += label1_Click;
            // 
            // btn_button1
            // 
            btn_button1.Location = new Point(282, 301);
            btn_button1.Name = "btn_button1";
            btn_button1.Size = new Size(244, 34);
            btn_button1.TabIndex = 1;
            btn_button1.Text = "Do something";
            btn_button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_button1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_button1;
    }
}