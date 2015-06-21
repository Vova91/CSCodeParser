namespace ParserCSharp
{
    partial class CSParser
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
            this.NodeTB = new System.Windows.Forms.TextBox();
            this.Expbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.Shrinkbtn = new System.Windows.Forms.Button();
            this.moduleTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineTb = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.methodTb = new System.Windows.Forms.TextBox();
            this.passBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.startTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NodeTB
            // 
            this.NodeTB.Location = new System.Drawing.Point(12, 12);
            this.NodeTB.Multiline = true;
            this.NodeTB.Name = "NodeTB";
            this.NodeTB.Size = new System.Drawing.Size(403, 202);
            this.NodeTB.TabIndex = 25;
            // 
            // Expbtn
            // 
            this.Expbtn.Enabled = false;
            this.Expbtn.Location = new System.Drawing.Point(433, 12);
            this.Expbtn.Name = "Expbtn";
            this.Expbtn.Size = new System.Drawing.Size(75, 23);
            this.Expbtn.TabIndex = 1;
            this.Expbtn.Text = "Expand";
            this.Expbtn.UseVisualStyleBackColor = true;
            this.Expbtn.Click += new System.EventHandler(this.Expbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(433, 54);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(433, 107);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Enabled = false;
            this.Nextbtn.Location = new System.Drawing.Point(433, 158);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 4;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Shrinkbtn
            // 
            this.Shrinkbtn.Enabled = false;
            this.Shrinkbtn.Location = new System.Drawing.Point(433, 213);
            this.Shrinkbtn.Name = "Shrinkbtn";
            this.Shrinkbtn.Size = new System.Drawing.Size(75, 23);
            this.Shrinkbtn.TabIndex = 5;
            this.Shrinkbtn.Text = "Shrink";
            this.Shrinkbtn.UseVisualStyleBackColor = true;
            this.Shrinkbtn.Click += new System.EventHandler(this.Shrinkbtn_Click);
            // 
            // moduleTb
            // 
            this.moduleTb.Location = new System.Drawing.Point(115, 220);
            this.moduleTb.Name = "moduleTb";
            this.moduleTb.Size = new System.Drawing.Size(300, 20);
            this.moduleTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Module";
            // 
            // fileTb
            // 
            this.fileTb.Location = new System.Drawing.Point(114, 251);
            this.fileTb.Name = "fileTb";
            this.fileTb.Size = new System.Drawing.Size(301, 20);
            this.fileTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File";
            // 
            // lineTb
            // 
            this.lineTb.Location = new System.Drawing.Point(114, 287);
            this.lineTb.Name = "lineTb";
            this.lineTb.Size = new System.Drawing.Size(301, 20);
            this.lineTb.TabIndex = 10;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(67, 294);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(27, 13);
            this.Line.TabIndex = 11;
            this.Line.Text = "Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Method";
            // 
            // methodTb
            // 
            this.methodTb.Location = new System.Drawing.Point(114, 325);
            this.methodTb.Name = "methodTb";
            this.methodTb.Size = new System.Drawing.Size(301, 20);
            this.methodTb.TabIndex = 12;
            // 
            // passBtn
            // 
            this.passBtn.Enabled = false;
            this.passBtn.Location = new System.Drawing.Point(433, 267);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(75, 23);
            this.passBtn.TabIndex = 14;
            this.passBtn.Text = "Pass";
            this.passBtn.UseVisualStyleBackColor = true;
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(433, 315);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close File";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start From CS";
            // 
            // startTb
            // 
            this.startTb.Location = new System.Drawing.Point(114, 357);
            this.startTb.Name = "startTb";
            this.startTb.Size = new System.Drawing.Size(301, 20);
            this.startTb.TabIndex = 16;
            // 
            // CSParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTb);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.methodTb);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.lineTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleTb);
            this.Controls.Add(this.Shrinkbtn);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Expbtn);
            this.Controls.Add(this.NodeTB);
            this.KeyPreview = true;
            this.Name = "CSParser";
            this.Text = "CSParser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CSParser_FormClosed);
            this.Load += new System.EventHandler(this.CSParser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CSParser_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NodeTB;
        private System.Windows.Forms.Button Expbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button Shrinkbtn;
        private System.Windows.Forms.TextBox moduleTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lineTb;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox methodTb;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startTb;
    }
}

