using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;
using System.Text.RegularExpressions;

namespace GetClassesFromDll
{
    class TestReplaceText
    {
        public void replaceTextTest(ref string input, string pattern, string replacement)
        {
            try
            {
                Regex rgx = new Regex(pattern);
                input = rgx.Replace(input, replacement);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
