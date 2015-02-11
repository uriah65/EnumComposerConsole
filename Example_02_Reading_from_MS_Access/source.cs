using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtComposer
{
    class Fake21_CsFakeDb
    {
        [EnumSqlCnn("#OleDb", @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =database.accdb;Persist Security Info=False")]
        [EnumSqlSelect("SELECT id, name, notes FROM T_Colors")]
        public enum ColorEnum
        {
        }
    }
}
