using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using System.Linq;

class Program
{
    static Assembly GetAssemblyByName(string name)
    {
        var r =  AppDomain.CurrentDomain.GetAssemblies().
               SingleOrDefault(assembly => assembly.GetName().Name == name);
        if (r == null) Console.WriteLine($"Warning: {name} not found");
        return r;
    }

    static void Main(string[] args)
    {
        string tgtAssemblyName = "System.Runtime";
        if( args.Length == 0)
        {
            // use default value
        }
        else if (args.Length == 1)
        {
            tgtAssemblyName = args[0];
        }
        else
        {
            Console.WriteLine("usage: ApiDump [AssemblyName|-all]");
            return;
        }
        var assemblies = new List<Assembly>();

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            //Console.WriteLine(assembly.GetName().Name);
            if (tgtAssemblyName != assembly.GetName().Name && tgtAssemblyName != "-all") continue;
            assemblies.Add(assembly);
            assemblies.AddRange(assembly.GetReferencedAssemblies().Select(c => GetAssemblyByName(c.Name)).Where(c=>c!=null));
        }

        foreach (var assembly in assemblies)
        {
            Console.WriteLine($"Assembly: {assembly.FullName}");
            foreach (var module in assembly.GetModules())
            {
                var doneTypes = new Dictionary<string, int>();
                Console.WriteLine($"Module: {module.Name}");
                //Console.WriteLine($"DEBUG:{module.GetTypes().Length}");

                foreach (var type in module.GetTypes())
                {
                    var allTyps = type.GetMembers(BindingFlags.Instance 
                        | BindingFlags.Static | BindingFlags.Public 
                        | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.SetField 
                        | BindingFlags.SetProperty);
                    if (allTyps.Length == 0) continue;
                    var name = type.FullName;
                    var index = name.IndexOf('`');
                    if (index >= 0) name = name.Substring(0, index);
                    if (doneTypes.ContainsKey(name)) continue;
                    doneTypes.Add(name, 1);
                    Console.WriteLine($"Type: {name}");
#if false
                    string lastname = null;
                    foreach (var member in allTyps)
                    {
                        if (lastname == member.Name) continue;
                        switch (member.MemberType)
                        {
                            case MemberTypes.Method:
                                if (member.Name.StartsWith("get_")) continue;
                                if (member.Name.StartsWith("set_")) continue;
                                Console.WriteLine($"\t{member.Name} メソッド");
                                break;
                            case MemberTypes.Constructor:
                                Console.WriteLine($"\t{type.FullName} コンストラクタ");
                                break;
                            case MemberTypes.Field:
                                Console.WriteLine($"\t{member.Name} フィールド");
                                break;
                            case MemberTypes.Property:
                                Console.WriteLine($"\t{member.Name} プロパティ");
                                break;
                        }
                        lastname = member.Name;
                    }
#endif
                }
            }
            Console.WriteLine();
        }
    }
}
