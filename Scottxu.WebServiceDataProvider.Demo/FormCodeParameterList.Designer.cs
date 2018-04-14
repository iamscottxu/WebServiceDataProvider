namespace Scottxu.WebServiceDataProvider.Demo
{
    partial class FormCodeParameterList
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
            this.dataGridViewParameterList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameterList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParameterList
            // 
            this.dataGridViewParameterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParameterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParameterList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewParameterList.Name = "dataGridViewParameterList";
            this.dataGridViewParameterList.RowTemplate.Height = 30;
            this.dataGridViewParameterList.Size = new System.Drawing.Size(378, 544);
            this.dataGridViewParameterList.TabIndex = 0;
            this.dataGridViewParameterList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParameterList_CellValueChanged);
            this.dataGridViewParameterList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewParameterList_DataError);
            // 
            // FormParameterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 544);
            this.Controls.Add(this.dataGridViewParameterList);
            this.Name = "FormParameterList";
            this.Text = "参数列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParameterList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParameterList;
    }
}