#region C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
#endregion

namespace GetClassesFromDll
{
    class TestExecute
    {
        public void runTest(string name, string argument, bool flag = true)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = name;
                p.StartInfo.Arguments = argument;
                p.Start();
                if (flag)
                    p.WaitForExit();
            }
        }
    }
}
