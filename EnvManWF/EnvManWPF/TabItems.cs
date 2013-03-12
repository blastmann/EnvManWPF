using System;
using System.Collections.Generic;

namespace EnvManWPF
{
    public class TabItems
    {
        private List<Item> tabItems;

        public List<Item> getTabItems()
        {
            tabItems = new List<Item>()
                {
                    new Item(EnvironmentVariableTarget.Machine),
                    new Item(EnvironmentVariableTarget.User),
                };

            return tabItems;
        }
    }
}