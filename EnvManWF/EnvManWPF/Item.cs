using System;
using System.Collections;
using System.Collections.Generic;
using SFC.EnvMan;

namespace EnvManWPF
{
    public class Item
    {
        public string Header
        {
            get { return _header; }
        }

        public IDictionary Data
        {
            get { return _data; }
        }

        private string _header { get; set; }
        private IDictionary _data { get; set; }
        private EnvVarManager varManager;

        public Item(EnvironmentVariableTarget target)
        {
            varManager = new EnvVarManager();
            _header = target.ToString();
            _data = varManager.GetEnvVariables(target);
        }
    }
}