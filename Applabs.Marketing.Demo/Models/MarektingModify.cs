using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applabs.Marketing.Demo.Models
{
   [MetadataType(typeof(MarektingModify))]
    public partial class C_Marketing_List
    {

    }
    public  partial class MarektingModify
    {
        [DataType(DataType.Date)]
        public System.DateTime Marketing_Start_Date { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime Marketing_End_Date { get; set; }
    }

}