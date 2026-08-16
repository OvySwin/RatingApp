namespace RatingApp
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnStar1 = new Button();
            btnStar2 = new Button();
            btnStar3 = new Button();
            btnStar4 = new Button();
            btnStar5 = new Button();
            label4 = new Label();
            lblResult = new Label();

            SuspendLayout();

            // 
            // label4 - Title
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(440, 30);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 0;
            label4.Text = "Rate My App";

            // 
            // label1 - Name question
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 130);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 1;
            label1.Text = "What's your name?";

            // 
            // txtName
            // 
            txtName.Location = new Point(410, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 39);
            txtName.TabIndex = 2;

            // 
            // label2 - Rating question
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 257);
            label2.Name = "label2";
            label2.Size = new Size(399, 32);
            label2.TabIndex = 3;
            label2.Text = "How much would you rate this app?";

            // 
            // btnStar1
            // 
            btnStar1.Location = new Point(79, 328);
            btnStar1.Name = "btnStar1";
            btnStar1.Size = new Size(150, 46);
            btnStar1.TabIndex = 4;
            btnStar1.Text = "★";
            btnStar1.UseVisualStyleBackColor = true;
            btnStar1.Click += btnStar1_Click;

            // 
            // btnStar2
            // 
            btnStar2.Location = new Point(251, 328);
            btnStar2.Name = "btnStar2";
            btnStar2.Size = new Size(150, 46);
            btnStar2.TabIndex = 5;
            btnStar2.Text = "★★";
            btnStar2.UseVisualStyleBackColor = true;
            btnStar2.Click += btnStar2_Click;

            // 
            // btnStar3
            // 
            btnStar3.Location = new Point(423, 328);
            btnStar3.Name = "btnStar3";
            btnStar3.Size = new Size(150, 46);
            btnStar3.TabIndex = 6;
            btnStar3.Text = "★★★";
            btnStar3.UseVisualStyleBackColor = true;
            btnStar3.Click += btnStar3_Click;

            // 
            // btnStar4
            // 
            btnStar4.Location = new Point(596, 328);
            btnStar4.Name = "btnStar4";
            btnStar4.Size = new Size(150, 46);
            btnStar4.TabIndex = 7;
            btnStar4.Text = "★★★★";
            btnStar4.UseVisualStyleBackColor = true;
            btnStar4.Click += btnStar4_Click;

            // 
            // btnStar5
            // 
            btnStar5.Location = new Point(766, 328);
            btnStar5.Name = "btnStar5";
            btnStar5.Size = new Size(150, 46);
            btnStar5.TabIndex = 8;
            btnStar5.Text = "★★★★★";
            btnStar5.UseVisualStyleBackColor = true;
            btnStar5.Click += btnStar5_Click;

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResult.Location = new Point(330, 445);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 9;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 573);

            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnStar1);
            Controls.Add(btnStar2);
            Controls.Add(btnStar3);
            Controls.Add(btnStar4);
            Controls.Add(btnStar5);
            Controls.Add(lblResult);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RatingApp";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button btnStar1;
        private Button btnStar2;
        private Button btnStar3;
        private Button btnStar4;
        private Button btnStar5;
        private Label label4;
        private Label lblResult;
    }
}