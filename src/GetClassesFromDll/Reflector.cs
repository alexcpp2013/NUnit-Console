using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Security.Permissions;
using System.Reflection;

namespace GetClassesFromDll
{
    class Reflector
    {
        public bool GetMethods(string filename, List<string> list, ref string className)
        {
            try
            {
                list.Clear();
                
                Assembly asm = Assembly.LoadFrom(filename);

                var allTypes =
                    asm.GetTypes().Where(type => Attribute.IsDefined(type, typeof(System.Attribute)));

                foreach (var t in allTypes)
                {
                    /*if (t.Name != "TestStatus")
                        className = t.FullName;
                    else
                        continue;*/

                    if (t.Name != className)
                        continue;
                    className = t.FullName;

                    var methods = 
                        t.GetMethods().
                        Where(m => (m.ReflectedType.IsPublic && m.DeclaringType.ToString() != "System.Object")).
                        Select(m => m.Name);
                    list.AddRange(methods);

                    #region old_code
                    /*if (t.Name.ToString() != "TestStatus")
                        if (list.Count > 0)
                        {
                            className = t.FullName.ToString();
                            return true;
                    }
                     
                    var allTypes = from type in asm.GetTypes()
                                       where Attribute.IsDefined(type, typeof(System.Attribute))
                                   select type;
                     
                    MemberInfo[] methodName = t.GetMethods();
                    foreach (var method in methodName)
                    {
                        if (method.ReflectedType.IsPublic && method.DeclaringType.ToString() !=
                            "System.Object")
                            list.Add(method.Name);
                    }*/
                    #endregion
                }
                return true;
            } //try
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
