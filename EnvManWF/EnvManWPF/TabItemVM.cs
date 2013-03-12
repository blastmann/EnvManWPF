using System.Collections.Generic;

namespace EnvManWPF
{
    public class TabItemVM
    {
        public List<Item> tabs { get; set; }
        public TabItemVM()
        {
            tabs = new TabItems().getTabItems();
        } 
    }
}