using System;
using System.Collections;
using System.Collections.Generic;
using SFC.EnvMan;

namespace EnvManWPF
{
    public class EnvVarViewItem
    {
        private string _enVarType;
        public string EnvVarType
        {
            get { return _enVarType; }
        }

        private IDictionary _varDict;
        public IDictionary VarDict
        {
            get { return _varDict; }
        }

        private EnvVarManager _envVarManager;
        public EnvVarManager EnvVarManager
        {
            get { return _envVarManager; }
        }

        public EnvVarViewItem(EnvironmentVariableTarget target)
        {
            _enVarType = target.ToString();
            _envVarManager = new EnvVarManager();
            _varDict = _envVarManager.GetEnvVariables(target);
        }
    }
}