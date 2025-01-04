using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable
{
    public interface IVoucherSupplier
    {
        public string? Name1 { get; set; }

        public string? Country { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? Address4 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PostalCode { get; set; }

        // Intentionally skipping the filler fields to avoid unwanted side-effects in PALM
        //public string? Filler1 { get; set; }
        //public string? Filler2 { get; set; }
        //public string? Filler3 { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
        //public string? Filler6 { get; set; }
        //public string? Filler7 { get; set; }
        //public string? Filler8 { get; set; }
        //public string? Filler9 { get; set; }
        //public string? Filler10 { get; set; }
    }
}
