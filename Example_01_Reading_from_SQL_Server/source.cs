using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtComposer
{ 
    class Test
    {
        [EnumSqlCnn("(local)", "AdventureWorks2014")]
        [EnumSqlSelect("SELECT ContactTypeID, Name FROM Person.ContactType")]
        public enum ContactTypeEmun
        {
        }

        [EnumSqlSelect("SELECT AddressTypeId, Name FROM Person.AddressType")]
        public enum AddressTypeEmun
        {
        }

    }
}
