using System;
using System.Linq;
using DLG.Framework.Contract;
using System.Collections.Generic;
using DLG.Framework.Utility;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLG.Account.Contract
{
    [Serializable]
    [Table("VerifyCode")]
    public class VerifyCode : ModelBase
    {
        public Guid Guid { get; set; }
        public string VerifyText { get; set; }
    }

}



