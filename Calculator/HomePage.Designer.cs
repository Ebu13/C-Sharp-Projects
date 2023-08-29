namespace Calculator
{
    partial class HomePage
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
            panelbtns = new Panel();
            btndel = new Button();
            btnminus = new Button();
            btnclear = new Button();
            btn0 = new Button();
            btnequals = new Button();
            btnplus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btntimes = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btndividedby = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            panelanswer = new Panel();
            lblanswer = new Label();
            panelbtns.SuspendLayout();
            panelanswer.SuspendLayout();
            SuspendLayout();
            // 
            // panelbtns
            // 
            panelbtns.Controls.Add(btndel);
            panelbtns.Controls.Add(btnminus);
            panelbtns.Controls.Add(btnclear);
            panelbtns.Controls.Add(btn0);
            panelbtns.Controls.Add(btnequals);
            panelbtns.Controls.Add(btnplus);
            panelbtns.Controls.Add(btn3);
            panelbtns.Controls.Add(btn2);
            panelbtns.Controls.Add(btn1);
            panelbtns.Controls.Add(btntimes);
            panelbtns.Controls.Add(btn6);
            panelbtns.Controls.Add(btn5);
            panelbtns.Controls.Add(btn4);
            panelbtns.Controls.Add(btndividedby);
            panelbtns.Controls.Add(btn9);
            panelbtns.Controls.Add(btn8);
            panelbtns.Controls.Add(btn7);
            panelbtns.Location = new Point(13, 97);
            panelbtns.Name = "panelbtns";
            panelbtns.Size = new Size(323, 424);
            panelbtns.TabIndex = 0;
            // 
            // btndel
            // 
            btndel.BackColor = SystemColors.GradientInactiveCaption;
            btndel.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btndel.Location = new Point(12, 261);
            btndel.Name = "btndel";
            btndel.Size = new Size(70, 70);
            btndel.TabIndex = 16;
            btndel.Text = "DEL";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = SystemColors.InactiveBorder;
            btnminus.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnminus.Location = new Point(240, 261);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(70, 70);
            btnminus.TabIndex = 15;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnOperator_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.GradientInactiveCaption;
            btnclear.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(164, 261);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(70, 70);
            btnclear.TabIndex = 14;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlLightLight;
            btn0.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(88, 261);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumber_Click;
            // 
            // btnequals
            // 
            btnequals.BackColor = SystemColors.Highlight;
            btnequals.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnequals.Location = new Point(12, 344);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(298, 70);
            btnequals.TabIndex = 12;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = false;
            btnequals.Click += btnequals_Click;
            // 
            // btnplus
            // 
            btnplus.BackColor = SystemColors.InactiveBorder;
            btnplus.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnplus.Location = new Point(240, 179);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(70, 70);
            btnplus.TabIndex = 11;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btnOperator_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlLightLight;
            btn3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(164, 179);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlLightLight;
            btn2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(88, 179);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLightLight;
            btn1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 179);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumber_Click;
            // 
            // btntimes
            // 
            btntimes.BackColor = SystemColors.InactiveBorder;
            btntimes.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btntimes.Location = new Point(240, 97);
            btntimes.Name = "btntimes";
            btntimes.Size = new Size(70, 70);
            btntimes.TabIndex = 7;
            btntimes.Text = "*";
            btntimes.UseVisualStyleBackColor = false;
            btntimes.Click += btnOperator_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlLightLight;
            btn6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(164, 97);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlLightLight;
            btn5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(88, 97);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlLightLight;
            btn4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 97);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumber_Click;
            // 
            // btndividedby
            // 
            btndividedby.BackColor = SystemColors.InactiveBorder;
            btndividedby.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btndividedby.Location = new Point(240, 15);
            btndividedby.Name = "btndividedby";
            btndividedby.Size = new Size(70, 70);
            btndividedby.TabIndex = 3;
            btndividedby.Text = "/";
            btndividedby.UseVisualStyleBackColor = false;
            btndividedby.Click += btnOperator_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlLightLight;
            btn9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(164, 15);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlLightLight;
            btn8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(88, 15);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlLightLight;
            btn7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 15);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumber_Click;
            // 
            // panelanswer
            // 
            panelanswer.Controls.Add(lblanswer);
            panelanswer.Location = new Point(11, 10);
            panelanswer.Name = "panelanswer";
            panelanswer.Size = new Size(327, 81);
            panelanswer.TabIndex = 1;
            // 
            // lblanswer
            // 
            lblanswer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblanswer.Location = new Point(14, 26);
            lblanswer.Name = "lblanswer";
            lblanswer.Size = new Size(298, 28);
            lblanswer.TabIndex = 0;
            lblanswer.Text = "0";
            lblanswer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 533);
            Controls.Add(panelanswer);
            Controls.Add(panelbtns);
            Name = "HomePage";
            Text = "HomePage";
            panelbtns.ResumeLayout(false);
            panelanswer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelbtns;
        private Button btnminus;
        private Button btnclear;
        private Button btn0;
        private Button btnequals;
        private Button btnplus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btntimes;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btndividedby;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Panel panelanswer;
        private Label lblanswer;
        private Button btndel;
    }
}