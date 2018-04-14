using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scottxu.WebServiceDataProvider.Demo
{
    internal class CodeParameterKeyValuePairTable : DataTable
    {
        private readonly DataColumn _key;
        private readonly DataColumn _value;
        private readonly Dictionary<string, object> _parameterDictionary;
        public CodeParameterKeyValuePairTable(Dictionary<string, object> parameterDictionary)
        {
            _parameterDictionary = parameterDictionary;
            _key = new DataColumn("键")
            {
                DataType = typeof(string),
                AllowDBNull = false,
                Unique = true,
            };
            _value = new DataColumn("值")
            {
                DataType = typeof(object),
                AllowDBNull = false
            };
            Columns.Add(_key);
            Columns.Add(_value);
            parameterDictionary.ToList().ForEach(keyValue => Rows.Add(keyValue.Key, keyValue.Value));
        }

        public new void AcceptChanges()
        {
            base.AcceptChanges();
            _parameterDictionary.Clear();
            foreach (DataRow row in Rows) _parameterDictionary.Add((string)row[_key], row[_value]);
        }
    }
}
