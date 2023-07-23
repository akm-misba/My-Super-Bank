using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class Transaction
    {
        public decimal ammount { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }
        public Transaction(decimal _ammount , DateTime _date,string _note)
        {
            ammount = _ammount;
            date = _date;
            note = _note;
        }
    }
}
