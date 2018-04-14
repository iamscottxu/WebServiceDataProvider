using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

namespace Scottxu.WebServiceDataProvider.Demo
{
    internal partial class FormDemo : Form
    {
        private readonly Connection _connection;
        private CompilerErrorCollection _compilerErrors;
        private readonly Dictionary<string, object> _parameterDictionary;
        private object _queryResult;
        public FormDemo()
        {
            InitializeComponent();
            textEditorControlCodeCode.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            textEditorControlCodeCode.Encoding = Encoding.UTF8;
            _connection = new Connection("http://", false);
            connectionBindingSource.DataSource = _connection;
            _parameterDictionary = new Dictionary<string, object>();
        }

        private void buttonCodeQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var cSharpCommand = _connection.GetCSharpCommand(textEditorControlCodeCode.Text);
                cSharpCommand.Parameters = _parameterDictionary;
                cSharpCommand.Query();
            }
            catch (CompilerException exception)
            {
                _compilerErrors = exception.CompilerErrors;
                MessageBox.Show("编译错误，请打开错误列表查看。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"错误信息：{exception.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonErrorList_Click(object sender, EventArgs e)
        {
            var fromErrorList = new FromErrorList(_compilerErrors);
            fromErrorList.ShowDialog();
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonCodeParameters_Click(object sender, EventArgs e)
        {
            var formParameterList = new FormCodeParameterList(_parameterDictionary);
            formParameterList.ShowDialog();
        }

    }
}
