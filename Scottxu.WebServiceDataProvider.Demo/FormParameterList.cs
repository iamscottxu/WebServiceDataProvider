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
    internal partial class FormParameterList : Form
    {
        public FormParameterList(ParameterDictionary parameterDictionary)
        {
            InitializeComponent();
            parameterDictionaryBindingSource.DataSource = parameterDictionary;
        }
    }
}
