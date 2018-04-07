namespace Scottxu.WebServiceDataProvider.Demo
{
    partial class FromErrorList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewErrorList = new System.Windows.Forms.DataGridView();
            this.compilerErrorCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isWarningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilerErrorCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewErrorList
            // 
            this.dataGridViewErrorList.AllowUserToAddRows = false;
            this.dataGridViewErrorList.AllowUserToDeleteRows = false;
            this.dataGridViewErrorList.AutoGenerateColumns = false;
            this.dataGridViewErrorList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isWarningDataGridViewCheckBoxColumn,
            this.errorNumberDataGridViewTextBoxColumn,
            this.errorTextDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.columnDataGridViewTextBoxColumn});
            this.dataGridViewErrorList.DataSource = this.compilerErrorCollectionBindingSource;
            this.dataGridViewErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErrorList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewErrorList.Name = "dataGridViewErrorList";
            this.dataGridViewErrorList.ReadOnly = true;
            this.dataGridViewErrorList.RowTemplate.Height = 30;
            this.dataGridViewErrorList.Size = new System.Drawing.Size(978, 744);
            this.dataGridViewErrorList.TabIndex = 0;
            // 
            // compilerErrorCollectionBindingSource
            // 
            this.compilerErrorCollectionBindingSource.DataSource = typeof(System.CodeDom.Compiler.CompilerErrorCollection);
            // 
            // isWarningDataGridViewCheckBoxColumn
            // 
            this.isWarningDataGridViewCheckBoxColumn.DataPropertyName = "IsWarning";
            this.isWarningDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.isWarningDataGridViewCheckBoxColumn.HeaderText = "";
            this.isWarningDataGridViewCheckBoxColumn.Name = "isWarningDataGridViewCheckBoxColumn";
            this.isWarningDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isWarningDataGridViewCheckBoxColumn.Width = 50;
            // 
            // errorNumberDataGridViewTextBoxColumn
            // 
            this.errorNumberDataGridViewTextBoxColumn.DataPropertyName = "ErrorNumber";
            this.errorNumberDataGridViewTextBoxColumn.FillWeight = 80F;
            this.errorNumberDataGridViewTextBoxColumn.HeaderText = "代码";
            this.errorNumberDataGridViewTextBoxColumn.Name = "errorNumberDataGridViewTextBoxColumn";
            this.errorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // errorTextDataGridViewTextBoxColumn
            // 
            this.errorTextDataGridViewTextBoxColumn.DataPropertyName = "ErrorText";
            this.errorTextDataGridViewTextBoxColumn.FillWeight = 300F;
            this.errorTextDataGridViewTextBoxColumn.HeaderText = "说明";
            this.errorTextDataGridViewTextBoxColumn.Name = "errorTextDataGridViewTextBoxColumn";
            this.errorTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorTextDataGridViewTextBoxColumn.Width = 300;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.FillWeight = 50F;
            this.lineDataGridViewTextBoxColumn.HeaderText = "行";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineDataGridViewTextBoxColumn.Width = 50;
            // 
            // columnDataGridViewTextBoxColumn
            // 
            this.columnDataGridViewTextBoxColumn.DataPropertyName = "Column";
            this.columnDataGridViewTextBoxColumn.FillWeight = 50F;
            this.columnDataGridViewTextBoxColumn.HeaderText = "列";
            this.columnDataGridViewTextBoxColumn.Name = "columnDataGridViewTextBoxColumn";
            this.columnDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnDataGridViewTextBoxColumn.Width = 50;
            // 
            // FromErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.dataGridViewErrorList);
            this.Name = "FromErrorList";
            this.Text = "错误列表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilerErrorCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewErrorList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isWarningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compilerErrorCollectionBindingSource;
    }
}