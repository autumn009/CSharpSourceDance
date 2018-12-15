using System;
using System.Text;

class Program
{
    static void Main()
    {
        object[] array = { 123, "123", new StringBuilder("123") };
        foreach (var item in array)
        {
            var val = item as string;
            if (val == null)
                Console.WriteLine($"{item.GetType().Name}型は'as string'でstring型に変換できません。");
            else
                Console.WriteLine($"{item}は長さ{val.Length}のstring型文字列です。");
        }
    }
}
