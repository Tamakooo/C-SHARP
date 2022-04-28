namespace homework10
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUrlTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dgvResultDataGridView = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtUrlTextBox);
            this.flowLayoutPanel1.Controls.Add(this.startButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1069, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtUrlTextBox
            // 
            this.txtUrlTextBox.Location = new System.Drawing.Point(40, 20);
            this.txtUrlTextBox.Margin = new System.Windows.Forms.Padding(40, 20, 4, 4);
            this.txtUrlTextBox.Name = "txtUrlTextBox";
            this.txtUrlTextBox.Size = new System.Drawing.Size(478, 25);
            this.txtUrlTextBox.TabIndex = 0;
            this.txtUrlTextBox.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(562, 20);
            this.startButton.Margin = new System.Windows.Forms.Padding(40, 20, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dgvResultDataGridView
            // 
            this.dgvResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.URL,
            this.status});
            this.dgvResultDataGridView.Location = new System.Drawing.Point(7, 113);
            this.dgvResultDataGridView.Name = "dgvResultDataGridView";
            this.dgvResultDataGridView.RowTemplate.Height = 27;
            this.dgvResultDataGridView.Size = new System.Drawing.Size(986, 459);
            this.dgvResultDataGridView.TabIndex = 2;
            // 
            // index
            // 
            this.index.DataPropertyName = "Index";
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Width = 500;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            // 
            // lblInfoLabel
            // 
            this.lblInfoLabel.AutoSize = true;
            this.lblInfoLabel.Location = new System.Drawing.Point(37, 85);
            this.lblInfoLabel.Name = "lblInfoLabel";
            this.lblInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.lblInfoLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 622);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblInfoLabel);
            this.Controls.Add(this.dgvResultDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtUrlTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView dgvResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblInfoLabel;
    }
}