using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.CustomAttributes;

namespace TestAutomationFramework.Enums
{
    public enum DriverTypeEnum
    {
        [Text("Chrome")]
        Chrome,
        [Text("Firefox")]
        Firefox,
        [Text("InternetExplorer")]
        InternetExplorer,
        [Text("Edge")]
        Edge
    }
}
