using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace automationUserHubCXOne
{
    public class Item : ITableItem
    {
        private IWebElement tableName;
        private IWebElement tableTrash;

        public IWebElement getTableName()
        {
            return tableName;
        }

        public IWebElement getTableTrash()
        {
            return tableTrash;
        }

        public void setTableName(IWebElement ItemName)
        {
            tableName = ItemName;
        }

        public void setTableTrash(IWebElement ItemTrash)
        {
            tableName = ItemTrash;
        }
    }
}
