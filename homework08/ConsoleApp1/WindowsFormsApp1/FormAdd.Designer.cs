namespace WindowsFormsApp1
{
    partial class FormAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelpho = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxnum1 = new System.Windows.Forms.TextBox();
            this.labelnum1 = new System.Windows.Forms.Label();
            this.textBoxpri = new System.Windows.Forms.TextBox();
            this.labelpri = new System.Windows.Forms.Label();
            this.textBoxcar = new System.Windows.Forms.TextBox();
            this.textBoxadd = new System.Windows.Forms.TextBox();
            this.textBoxcus = new System.Windows.Forms.TextBox();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.labeladd = new System.Windows.Forms.Label();
            this.labelcar = new System.Windows.Forms.Label();
            this.labelcus = new System.Windows.Forms.Label();
            this.labelnum = new System.Windows.Forms.Label();
            this.textBoxpho = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxpho);
            this.groupBox1.Controls.Add(this.labelpho);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxnum1);
            this.groupBox1.Controls.Add(this.labelnum1);
            this.groupBox1.Controls.Add(this.textBoxpri);
            this.groupBox1.Controls.Add(this.labelpri);
            this.groupBox1.Controls.Add(this.textBoxcar);
            this.groupBox1.Controls.Add(this.textBoxadd);
            this.groupBox1.Controls.Add(this.textBoxcus);
            this.groupBox1.Controls.Add(this.textBoxnum);
            this.groupBox1.Controls.Add(this.labeladd);
            this.groupBox1.Controls.Add(this.labelcar);
            this.groupBox1.Controls.Add(this.labelcus);
            this.groupBox1.Controls.Add(this.labelnum);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelpho
            // 
            this.labelpho.AutoSize = true;
            this.labelpho.Location = new System.Drawing.Point(231, 215);
            this.labelpho.Name = "labelpho";
            this.labelpho.Size = new System.Drawing.Size(67, 15);
            this.labelpho.TabIndex = 13;
            this.labelpho.Text = "客户电话";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(606, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 42);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "添加订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxnum1
            // 
            this.textBoxnum1.Location = new System.Drawing.Point(364, 312);
            this.textBoxnum1.Name = "textBoxnum1";
            this.textBoxnum1.Size = new System.Drawing.Size(100, 25);
            this.textBoxnum1.TabIndex = 11;
            // 
            // labelnum1
            // 
            this.labelnum1.AutoSize = true;
            this.labelnum1.Location = new System.Drawing.Point(231, 315);
            this.labelnum1.Name = "labelnum1";
            this.labelnum1.Size = new System.Drawing.Size(37, 15);
            this.labelnum1.TabIndex = 10;
            this.labelnum1.Text = "数量";
            // 
            // textBoxpri
            // 
            this.textBoxpri.Location = new System.Drawing.Point(364, 368);
            this.textBoxpri.Name = "textBoxpri";
            this.textBoxpri.Size = new System.Drawing.Size(100, 25);
            this.textBoxpri.TabIndex = 9;
            // 
            // labelpri
            // 
            this.labelpri.AutoSize = true;
            this.labelpri.Location = new System.Drawing.Point(231, 371);
            this.labelpri.Name = "labelpri";
            this.labelpri.Size = new System.Drawing.Size(37, 15);
            this.labelpri.TabIndex = 8;
            this.labelpri.Text = "价格";
            // 
            // textBoxcar
            // 
            this.textBoxcar.Location = new System.Drawing.Point(364, 259);
            this.textBoxcar.Name = "textBoxcar";
            this.textBoxcar.Size = new System.Drawing.Size(100, 25);
            this.textBoxcar.TabIndex = 7;
            // 
            // textBoxadd
            // 
            this.textBoxadd.Location = new System.Drawing.Point(364, 170);
            this.textBoxadd.Name = "textBoxadd";
            this.textBoxadd.Size = new System.Drawing.Size(100, 25);
            this.textBoxadd.TabIndex = 6;
            // 
            // textBoxcus
            // 
            this.textBoxcus.Location = new System.Drawing.Point(364, 119);
            this.textBoxcus.Name = "textBoxcus";
            this.textBoxcus.Size = new System.Drawing.Size(100, 25);
            this.textBoxcus.TabIndex = 5;
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(364, 70);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(100, 25);
            this.textBoxnum.TabIndex = 4;
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.Location = new System.Drawing.Point(231, 173);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(37, 15);
            this.labeladd.TabIndex = 3;
            this.labeladd.Text = "地址";
            // 
            // labelcar
            // 
            this.labelcar.AutoSize = true;
            this.labelcar.Location = new System.Drawing.Point(231, 262);
            this.labelcar.Name = "labelcar";
            this.labelcar.Size = new System.Drawing.Size(37, 15);
            this.labelcar.TabIndex = 2;
            this.labelcar.Text = "货物";
            // 
            // labelcus
            // 
            this.labelcus.AutoSize = true;
            this.labelcus.Location = new System.Drawing.Point(231, 122);
            this.labelcus.Name = "labelcus";
            this.labelcus.Size = new System.Drawing.Size(52, 15);
            this.labelcus.TabIndex = 1;
            this.labelcus.Text = "客户名";
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Location = new System.Drawing.Point(231, 73);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(52, 15);
            this.labelnum.TabIndex = 0;
            this.labelnum.Text = "订单号";
            // 
            // textBoxpho
            // 
            this.textBoxpho.Location = new System.Drawing.Point(364, 212);
            this.textBoxpho.Name = "textBoxpho";
            this.textBoxpho.Size = new System.Drawing.Size(100, 25);
            this.textBoxpho.TabIndex = 14;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdd";
            this.Text = "订单添加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelcar;
        private System.Windows.Forms.Label labelcus;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxnum1;
        private System.Windows.Forms.Label labelnum1;
        private System.Windows.Forms.TextBox textBoxpri;
        private System.Windows.Forms.Label labelpri;
        private System.Windows.Forms.TextBox textBoxcar;
        private System.Windows.Forms.TextBox textBoxadd;
        private System.Windows.Forms.TextBox textBoxcus;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Label labeladd;
        private System.Windows.Forms.Label labelpho;
        private System.Windows.Forms.TextBox textBoxpho;
    }
}