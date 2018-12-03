using System;
using System.Reflection;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string tgtAssemblyName = "System.Runtime.dll";
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
            Console.WriteLine("usage: ApiDump [AssemblyName]");
            return;
        }
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            Console.WriteLine($"Assembly: {assembly.FullName}");
            foreach (var module in assembly.GetModules())
            {
                Console.WriteLine($"Module: {module.Name}");
                foreach (var type in module.GetTypes())
                {
                    Console.WriteLine($"Type: {type.FullName}");
                    string lastname = null;
                    foreach (var member in type.GetMembers(BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public|BindingFlags.DeclaredOnly|BindingFlags.GetField|BindingFlags.GetProperty|BindingFlags.SetField|BindingFlags.SetProperty))
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
                }
            }
            Console.WriteLine();
        }
    }
}
