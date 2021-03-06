﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;

namespace SeleniumFixture.xUnit
{
    public abstract class InternetExplorerOptionsAttribute : Attribute
    {
        public abstract InternetExplorerOptions ProvideOptions(MethodInfo methodInfo);
    }
}
