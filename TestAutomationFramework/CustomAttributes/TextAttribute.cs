using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.CustomAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class TextAttribute : Attribute
    {
        public TextAttribute(string uiText)
        {
            Text = uiText;
        }
        public string Text { get; set; }
    }
}
