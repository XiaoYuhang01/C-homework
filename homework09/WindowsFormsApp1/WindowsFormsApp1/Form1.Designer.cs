namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.trueUrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.falseUrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absolutePathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absoluteUriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostNameTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDefaultPortDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isFileDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLoopbackDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pathAndQueryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUncDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fragmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnsSafeHostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnHostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAbsoluteUriDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userEscapedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userInfoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.absoluteUriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueUrlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseUrlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBoxUrl);
            this.groupBox1.Controls.Add(this.button);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(186, 76);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(165, 25);
            this.textBoxUrl.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(405, 66);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 41);
            this.button.TabIndex = 0;
            this.button.Text = "爬取";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 287);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.absoluteUriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trueUrlBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(393, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.absolutePathDataGridViewTextBoxColumn1,
            this.absoluteUriDataGridViewTextBoxColumn1,
            this.localPathDataGridViewTextBoxColumn1,
            this.authorityDataGridViewTextBoxColumn1,
            this.hostNameTypeDataGridViewTextBoxColumn1,
            this.isDefaultPortDataGridViewCheckBoxColumn1,
            this.isFileDataGridViewCheckBoxColumn1,
            this.isLoopbackDataGridViewCheckBoxColumn1,
            this.pathAndQueryDataGridViewTextBoxColumn1,
            this.isUncDataGridViewCheckBoxColumn1,
            this.hostDataGridViewTextBoxColumn1,
            this.portDataGridViewTextBoxColumn1,
            this.queryDataGridViewTextBoxColumn1,
            this.fragmentDataGridViewTextBoxColumn1,
            this.schemeDataGridViewTextBoxColumn1,
            this.originalStringDataGridViewTextBoxColumn1,
            this.dnsSafeHostDataGridViewTextBoxColumn1,
            this.idnHostDataGridViewTextBoxColumn1,
            this.isAbsoluteUriDataGridViewCheckBoxColumn1,
            this.userEscapedDataGridViewCheckBoxColumn1,
            this.userInfoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.falseUrlBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(393, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(401, 287);
            this.dataGridView2.TabIndex = 1;
            // 
            // trueUrlBindingSource
            // 
            this.trueUrlBindingSource.DataMember = "TrueUrl";
            this.trueUrlBindingSource.DataSource = this.bindingSource1;
            // 
            // falseUrlBindingSource
            // 
            this.falseUrlBindingSource.DataMember = "FalseUrl";
            this.falseUrlBindingSource.DataSource = this.bindingSource1;
            // 
            // absolutePathDataGridViewTextBoxColumn1
            // 
            this.absolutePathDataGridViewTextBoxColumn1.DataPropertyName = "AbsolutePath";
            this.absolutePathDataGridViewTextBoxColumn1.HeaderText = "AbsolutePath";
            this.absolutePathDataGridViewTextBoxColumn1.Name = "absolutePathDataGridViewTextBoxColumn1";
            this.absolutePathDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // absoluteUriDataGridViewTextBoxColumn1
            // 
            this.absoluteUriDataGridViewTextBoxColumn1.DataPropertyName = "AbsoluteUri";
            this.absoluteUriDataGridViewTextBoxColumn1.HeaderText = "AbsoluteUri";
            this.absoluteUriDataGridViewTextBoxColumn1.Name = "absoluteUriDataGridViewTextBoxColumn1";
            this.absoluteUriDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // localPathDataGridViewTextBoxColumn1
            // 
            this.localPathDataGridViewTextBoxColumn1.DataPropertyName = "LocalPath";
            this.localPathDataGridViewTextBoxColumn1.HeaderText = "LocalPath";
            this.localPathDataGridViewTextBoxColumn1.Name = "localPathDataGridViewTextBoxColumn1";
            this.localPathDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorityDataGridViewTextBoxColumn1
            // 
            this.authorityDataGridViewTextBoxColumn1.DataPropertyName = "Authority";
            this.authorityDataGridViewTextBoxColumn1.HeaderText = "Authority";
            this.authorityDataGridViewTextBoxColumn1.Name = "authorityDataGridViewTextBoxColumn1";
            this.authorityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hostNameTypeDataGridViewTextBoxColumn1
            // 
            this.hostNameTypeDataGridViewTextBoxColumn1.DataPropertyName = "HostNameType";
            this.hostNameTypeDataGridViewTextBoxColumn1.HeaderText = "HostNameType";
            this.hostNameTypeDataGridViewTextBoxColumn1.Name = "hostNameTypeDataGridViewTextBoxColumn1";
            this.hostNameTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isDefaultPortDataGridViewCheckBoxColumn1
            // 
            this.isDefaultPortDataGridViewCheckBoxColumn1.DataPropertyName = "IsDefaultPort";
            this.isDefaultPortDataGridViewCheckBoxColumn1.HeaderText = "IsDefaultPort";
            this.isDefaultPortDataGridViewCheckBoxColumn1.Name = "isDefaultPortDataGridViewCheckBoxColumn1";
            this.isDefaultPortDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // isFileDataGridViewCheckBoxColumn1
            // 
            this.isFileDataGridViewCheckBoxColumn1.DataPropertyName = "IsFile";
            this.isFileDataGridViewCheckBoxColumn1.HeaderText = "IsFile";
            this.isFileDataGridViewCheckBoxColumn1.Name = "isFileDataGridViewCheckBoxColumn1";
            this.isFileDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // isLoopbackDataGridViewCheckBoxColumn1
            // 
            this.isLoopbackDataGridViewCheckBoxColumn1.DataPropertyName = "IsLoopback";
            this.isLoopbackDataGridViewCheckBoxColumn1.HeaderText = "IsLoopback";
            this.isLoopbackDataGridViewCheckBoxColumn1.Name = "isLoopbackDataGridViewCheckBoxColumn1";
            this.isLoopbackDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // pathAndQueryDataGridViewTextBoxColumn1
            // 
            this.pathAndQueryDataGridViewTextBoxColumn1.DataPropertyName = "PathAndQuery";
            this.pathAndQueryDataGridViewTextBoxColumn1.HeaderText = "PathAndQuery";
            this.pathAndQueryDataGridViewTextBoxColumn1.Name = "pathAndQueryDataGridViewTextBoxColumn1";
            this.pathAndQueryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isUncDataGridViewCheckBoxColumn1
            // 
            this.isUncDataGridViewCheckBoxColumn1.DataPropertyName = "IsUnc";
            this.isUncDataGridViewCheckBoxColumn1.HeaderText = "IsUnc";
            this.isUncDataGridViewCheckBoxColumn1.Name = "isUncDataGridViewCheckBoxColumn1";
            this.isUncDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn1
            // 
            this.hostDataGridViewTextBoxColumn1.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn1.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn1.Name = "hostDataGridViewTextBoxColumn1";
            this.hostDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // portDataGridViewTextBoxColumn1
            // 
            this.portDataGridViewTextBoxColumn1.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn1.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn1.Name = "portDataGridViewTextBoxColumn1";
            this.portDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // queryDataGridViewTextBoxColumn1
            // 
            this.queryDataGridViewTextBoxColumn1.DataPropertyName = "Query";
            this.queryDataGridViewTextBoxColumn1.HeaderText = "Query";
            this.queryDataGridViewTextBoxColumn1.Name = "queryDataGridViewTextBoxColumn1";
            this.queryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fragmentDataGridViewTextBoxColumn1
            // 
            this.fragmentDataGridViewTextBoxColumn1.DataPropertyName = "Fragment";
            this.fragmentDataGridViewTextBoxColumn1.HeaderText = "Fragment";
            this.fragmentDataGridViewTextBoxColumn1.Name = "fragmentDataGridViewTextBoxColumn1";
            this.fragmentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // schemeDataGridViewTextBoxColumn1
            // 
            this.schemeDataGridViewTextBoxColumn1.DataPropertyName = "Scheme";
            this.schemeDataGridViewTextBoxColumn1.HeaderText = "Scheme";
            this.schemeDataGridViewTextBoxColumn1.Name = "schemeDataGridViewTextBoxColumn1";
            this.schemeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // originalStringDataGridViewTextBoxColumn1
            // 
            this.originalStringDataGridViewTextBoxColumn1.DataPropertyName = "OriginalString";
            this.originalStringDataGridViewTextBoxColumn1.HeaderText = "OriginalString";
            this.originalStringDataGridViewTextBoxColumn1.Name = "originalStringDataGridViewTextBoxColumn1";
            this.originalStringDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dnsSafeHostDataGridViewTextBoxColumn1
            // 
            this.dnsSafeHostDataGridViewTextBoxColumn1.DataPropertyName = "DnsSafeHost";
            this.dnsSafeHostDataGridViewTextBoxColumn1.HeaderText = "DnsSafeHost";
            this.dnsSafeHostDataGridViewTextBoxColumn1.Name = "dnsSafeHostDataGridViewTextBoxColumn1";
            this.dnsSafeHostDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idnHostDataGridViewTextBoxColumn1
            // 
            this.idnHostDataGridViewTextBoxColumn1.DataPropertyName = "IdnHost";
            this.idnHostDataGridViewTextBoxColumn1.HeaderText = "IdnHost";
            this.idnHostDataGridViewTextBoxColumn1.Name = "idnHostDataGridViewTextBoxColumn1";
            this.idnHostDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isAbsoluteUriDataGridViewCheckBoxColumn1
            // 
            this.isAbsoluteUriDataGridViewCheckBoxColumn1.DataPropertyName = "IsAbsoluteUri";
            this.isAbsoluteUriDataGridViewCheckBoxColumn1.HeaderText = "IsAbsoluteUri";
            this.isAbsoluteUriDataGridViewCheckBoxColumn1.Name = "isAbsoluteUriDataGridViewCheckBoxColumn1";
            this.isAbsoluteUriDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // userEscapedDataGridViewCheckBoxColumn1
            // 
            this.userEscapedDataGridViewCheckBoxColumn1.DataPropertyName = "UserEscaped";
            this.userEscapedDataGridViewCheckBoxColumn1.HeaderText = "UserEscaped";
            this.userEscapedDataGridViewCheckBoxColumn1.Name = "userEscapedDataGridViewCheckBoxColumn1";
            this.userEscapedDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // userInfoDataGridViewTextBoxColumn1
            // 
            this.userInfoDataGridViewTextBoxColumn1.DataPropertyName = "UserInfo";
            this.userInfoDataGridViewTextBoxColumn1.HeaderText = "UserInfo";
            this.userInfoDataGridViewTextBoxColumn1.Name = "userInfoDataGridViewTextBoxColumn1";
            this.userInfoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.SimpleCrawler);
            // 
            // absoluteUriDataGridViewTextBoxColumn
            // 
            this.absoluteUriDataGridViewTextBoxColumn.DataPropertyName = "AbsoluteUri";
            this.absoluteUriDataGridViewTextBoxColumn.HeaderText = "正确网页信息";
            this.absoluteUriDataGridViewTextBoxColumn.Name = "absoluteUriDataGridViewTextBoxColumn";
            this.absoluteUriDataGridViewTextBoxColumn.ReadOnly = true;
            this.absoluteUriDataGridViewTextBoxColumn.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueUrlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseUrlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn absolutePathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn absoluteUriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostNameTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDefaultPortDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFileDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLoopbackDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathAndQueryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUncDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fragmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnsSafeHostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnHostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAbsoluteUriDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userEscapedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInfoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource falseUrlBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trueUrlBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn absoluteUriDataGridViewTextBoxColumn;
    }
}

