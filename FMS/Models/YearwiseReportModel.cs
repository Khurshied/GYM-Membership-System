using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMS.Models
{
    public class YearwiseReportModel
    {
        public string YearID { get; set; }
        public IEnumerable<SelectListItem> YearNameList { get; set; }
    }
}