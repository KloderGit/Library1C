using System;
using System.Collections.Generic;
using System.Text;

namespace Library1C.DTO
{
    public class AddLeadDTO
    {
        public string ProgramGuid { get; set; }
        public string UserGuid { get; set; }
        public string ContractTitle { get; set; }
        public int ContractPrice { get; set; }
        public string ContractGroup { get; set; }
        public string ContractSubGroup { get; set; }
        public DateTime ContractExpire { get; set; }
        public DateTime ContractEducationStart { get; set; }
        public DateTime ContractEducationEnd { get; set; }
        public string DecreeTitle { get; set; }
    }
}
