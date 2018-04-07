namespace Scottxu.WebServiceDataProvider.Demo
{
    partial class FormParameterList
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
            this.dataGridViewParameterList = new System.Windows.Forms.DataGridView();
            this.parameterDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParameterList
            // 
            this.dataGridViewParameterList.AutoGenerateColumns = false;
            this.dataGridViewParameterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParameterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keysDataGridViewTextBoxColumn,
            this.valuesDataGridViewTextBoxColumn});
            this.dataGridViewParameterList.DataSource = this.parameterDictionaryBindingSource;
            this.dataGridViewParameterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParameterList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewParameterList.Name = "dataGridViewParameterList";
            this.dataGridViewParameterList.RowTemplate.Height = 30;
            this.dataGridViewParameterList.Size = new System.Drawing.Size(378, 544);
            this.dataGridViewParameterList.TabIndex = 0;
            // 
            // parameterDictionaryBindingSource
            // 
            this.parameterDictionaryBindingSource.DataSource = typeof(Scottxu.WebServiceDataProvider.Demo.ParameterDictionary);
            // 
            // keysDataGridViewTextBoxColumn
            // 
            this.keysDataGridViewTextBoxColumn.DataPropertyName = "Keys";
            this.keysDataGridViewTextBoxColumn.HeaderText = "键";
            this.keysDataGridViewTextBoxColumn.Name = "keysDataGridViewTextBoxColumn";
            this.keysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valuesDataGridViewTextBoxColumn
            // 
            this.valuesDataGridViewTextBoxColumn.DataPropertyName = "Values";
            this.valuesDataGridViewTextBoxColumn.HeaderText = "值";
            this.valuesDataGridViewTextBoxColumn.Name = "valuesDataGridViewTextBoxColumn";
            this.valuesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormParameterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 544);
            this.Controls.Add(this.dataGridViewParameterList);
            this.Name = "FormParameterList";
            this.Text = "参数列表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterDictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParameterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn keysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parameterDictionaryBindingSource;
    }
}