using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtComposer
{
    class Fake21_CsFakeDb
    {
        [EnumSqlCnn("#ODBC", @"Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=;Extensions=asc,csv,tab,txt;Persist Security Info=False")]
        [EnumSqlSelect("SELECT * FROM [data.csv]")]
        public enum ColorEnum
        {
        }
    }
}
