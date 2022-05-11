using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal interface IExpireDate
    {
        string ExpiryDate { get; set; }
        void CalcExpireDate();
    }
}
