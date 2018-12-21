using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationUserHubCXOne
{
    interface ITableItem
    {
        IWebElement getTableName();
        IWebElement getTableTrash();

        void setTableName(IWebElement ItemName);
        void setTableTrash(IWebElement ItemTrash);

    }
}
