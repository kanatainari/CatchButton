namespace CatchButton
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
            Button_true = new Button();
            SuspendLayout();
            // 
            // Button_true
            // 
            Button_true.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button_true.Location = new Point(368, 313);
            Button_true.Name = "Button_true";
            Button_true.Size = new Size(729, 218);
            Button_true.TabIndex = 1;
            Button_true.Text = "나를 잡아봐";
            Button_true.UseVisualStyleBackColor = true;
            Button_true.Click += Button_true_Click;
            Button_true.MouseEnter += Button_true_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 859);
            Controls.Add(Button_true);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Button_true;
    }
}
