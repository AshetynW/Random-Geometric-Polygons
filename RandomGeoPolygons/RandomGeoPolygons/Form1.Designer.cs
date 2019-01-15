namespace RandomGeoPolygons
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SidesTxt = new System.Windows.Forms.TextBox();
            this.VertecesTxt = new System.Windows.Forms.TextBox();
            this.AreaTxt = new System.Windows.Forms.TextBox();
            this.MakeBtn = new System.Windows.Forms.Button();
            this.RndmColorChkBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polygon: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sides:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verteces:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area: ";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(459, 23);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 4;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // SidesTxt
            // 
            this.SidesTxt.Location = new System.Drawing.Point(459, 57);
            this.SidesTxt.Name = "SidesTxt";
            this.SidesTxt.Size = new System.Drawing.Size(100, 20);
            this.SidesTxt.TabIndex = 5;
            this.SidesTxt.TextChanged += new System.EventHandler(this.SidesTxt_TextChanged);
            // 
            // VertecesTxt
            // 
            this.VertecesTxt.Location = new System.Drawing.Point(459, 92);
            this.VertecesTxt.Name = "VertecesTxt";
            this.VertecesTxt.Size = new System.Drawing.Size(100, 20);
            this.VertecesTxt.TabIndex = 6;
            this.VertecesTxt.TextChanged += new System.EventHandler(this.VertecesTxt_TextChanged);
            // 
            // AreaTxt
            // 
            this.AreaTxt.Location = new System.Drawing.Point(459, 128);
            this.AreaTxt.Name = "AreaTxt";
            this.AreaTxt.Size = new System.Drawing.Size(100, 20);
            this.AreaTxt.TabIndex = 7;
            this.AreaTxt.TextChanged += new System.EventHandler(this.AreaTxt_TextChanged);
            // 
            // MakeBtn
            // 
            this.MakeBtn.Location = new System.Drawing.Point(405, 200);
            this.MakeBtn.Name = "MakeBtn";
            this.MakeBtn.Size = new System.Drawing.Size(154, 23);
            this.MakeBtn.TabIndex = 8;
            this.MakeBtn.Text = "Make A Shape";
            this.MakeBtn.UseVisualStyleBackColor = true;
            this.MakeBtn.Click += new System.EventHandler(this.MakeBtn_Click);
            // 
            // RndmColorChkBx
            // 
            this.RndmColorChkBx.AutoSize = true;
            this.RndmColorChkBx.Location = new System.Drawing.Point(459, 164);
            this.RndmColorChkBx.Name = "RndmColorChkBx";
            this.RndmColorChkBx.Size = new System.Drawing.Size(111, 17);
            this.RndmColorChkBx.TabIndex = 9;
            this.RndmColorChkBx.Text = "Randomize Colors";
            this.RndmColorChkBx.UseVisualStyleBackColor = true;
            this.RndmColorChkBx.CheckedChanged += new System.EventHandler(this.RndmColorChkBx_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 396);
            this.Controls.Add(this.RndmColorChkBx);
            this.Controls.Add(this.MakeBtn);
            this.Controls.Add(this.AreaTxt);
            this.Controls.Add(this.VertecesTxt);
            this.Controls.Add(this.SidesTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Polygons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SidesTxt;
        private System.Windows.Forms.TextBox VertecesTxt;
        private System.Windows.Forms.TextBox AreaTxt;
        private System.Windows.Forms.Button MakeBtn;
        private System.Windows.Forms.CheckBox RndmColorChkBx;
    }
}

