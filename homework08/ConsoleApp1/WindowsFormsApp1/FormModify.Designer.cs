namespace WindowsFormsApp1
{
    partial class ModifyForm
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
            this.groupBoxModify = new System.Windows.Forms.GroupBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxModify = new System.Windows.Forms.ComboBox();
            this.labelModify = new System.Windows.Forms.Label();
            this.labelNeedModify = new System.Windows.Forms.Label();
            this.textBoxNeedModify = new System.Windows.Forms.TextBox();
            this.groupBoxModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModify
            // 
            this.groupBoxModify.Controls.Add(this.textBoxNeedModify);
            this.groupBoxModify.Controls.Add(this.labelNeedModify);
            this.groupBoxModify.Controls.Add(this.buttonModify);
            this.groupBoxModify.Controls.Add(this.textBoxResult);
            this.groupBoxModify.Controls.Add(this.labelResult);
            this.groupBoxModify.Controls.Add(this.comboBoxModify);
            this.groupBoxModify.Controls.Add(this.labelModify);
            this.groupBoxModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxModify.Location = new System.Drawing.Point(0, 0);
            this.groupBoxModify.Name = "groupBoxModify";
            this.groupBoxModify.Size = new System.Drawing.Size(800, 450);
            this.groupBoxModify.TabIndex = 0;
            this.groupBoxModify.TabStop = false;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(516, 316);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(99, 40);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "确定";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(313, 248);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(121, 25);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(211, 251);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(67, 15);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "修改结果";
            // 
            // comboBoxModify
            // 
            this.comboBoxModify.FormattingEnabled = true;
            this.comboBoxModify.Items.AddRange(new object[] {
            "客户",
            "客户电话",
            "客户地址"});
            this.comboBoxModify.Location = new System.Drawing.Point(313, 99);
            this.comboBoxModify.Name = "comboBoxModify";
            this.comboBoxModify.Size = new System.Drawing.Size(121, 23);
            this.comboBoxModify.TabIndex = 1;
            // 
            // labelModify
            // 
            this.labelModify.AutoSize = true;
            this.labelModify.Location = new System.Drawing.Point(211, 102);
            this.labelModify.Name = "labelModify";
            this.labelModify.Size = new System.Drawing.Size(52, 15);
            this.labelModify.TabIndex = 0;
            this.labelModify.Text = "修改项";
            // 
            // labelNeedModify
            // 
            this.labelNeedModify.AutoSize = true;
            this.labelNeedModify.Location = new System.Drawing.Point(211, 179);
            this.labelNeedModify.Name = "labelNeedModify";
            this.labelNeedModify.Size = new System.Drawing.Size(82, 15);
            this.labelNeedModify.TabIndex = 5;
            this.labelNeedModify.Text = "待修改内容";
            // 
            // textBoxNeedModify
            // 
            this.textBoxNeedModify.Location = new System.Drawing.Point(313, 176);
            this.textBoxNeedModify.Name = "textBoxNeedModify";
            this.textBoxNeedModify.Size = new System.Drawing.Size(121, 25);
            this.textBoxNeedModify.TabIndex = 6;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxModify);
            this.Name = "ModifyForm";
            this.Text = "订单修改";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.groupBoxModify.ResumeLayout(false);
            this.groupBoxModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModify;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxModify;
        private System.Windows.Forms.Label labelModify;
        private System.Windows.Forms.TextBox textBoxNeedModify;
        private System.Windows.Forms.Label labelNeedModify;
    }
}