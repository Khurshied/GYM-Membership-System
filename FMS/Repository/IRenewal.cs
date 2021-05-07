using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FMS.Models;

namespace FMS.Repository
{
    interface IRenewal
    {
        RenewalDATA GetDataofMember(string MemberID);
        string Get_PeriodID_byPlan(string PlanID);
    }
}
