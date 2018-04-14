using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scottxu.WebServiceDataProvider.Demo
{
    internal partial class FormCodeParameterList : Form
    {
        public FormCodeParameterList(Dictionary<string, object> parameterDictionary)
        {
            InitializeComponent();
            dataGridViewParameterList.DataSource = new CodeParameterKeyValuePairTable(parameterDictionary);
        }

        private void FormParameterList_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((CodeParameterKeyValuePairTable)dataGridViewParameterList.DataSource).AcceptChanges();
        }

        private void dataGridViewParameterList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ((DataGridView) sender).Rows[e.RowIndex].ErrorText = e.Exception.Message;
            e.Cancel = true;
        }

        private void dataGridViewParameterList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ((DataGridView) sender).Rows[e.RowIndex].ErrorText = string.Empty;
        }
    }
}
