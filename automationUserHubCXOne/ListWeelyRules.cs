using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class ListWeelyRules
    {
        public static WeeklyRuleCommand CreateWeelyRule(String weeklyRuleName)
        {
            return new WeeklyRuleCommand(weeklyRuleName);
        }
    }
}
