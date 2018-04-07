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

namespace Scottxu.WebServiceDataProvider.Demo
{
    internal partial class FromErrorList : Form
    {
        public FromErrorList(CompilerErrorCollection compilerErrors)
        {
            InitializeComponent();
            compilerErrorCollectionBindingSource.DataSource = compilerErrors;
        }
    }
}
