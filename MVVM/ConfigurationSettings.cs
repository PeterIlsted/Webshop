﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.MVVM
{
    public static class ConfigurationSettings
    {
        public static string ConnectionString { get; private set; }

        public static void Initialize(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
