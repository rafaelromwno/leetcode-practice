using System;

class Quine
{
    static void Main()
    {
        string[] lines = {
            "using System;",
            "",
            "class Quine",
            "{",
            "    static void Main()",
            "    {",
            "        string[] lines = {"
        };

        string[] source = {
            "            \"using System;\",",
            "            \"\",",
            "            \"class Quine\",",
            "            \"{\",",
            "            \"    static void Main()\",",
            "            \"    {\",",
            "            \"        string[] lines = {\""
        };

        foreach (string line in source)
            Console.WriteLine(line);

        foreach (string line in source)
            Console.WriteLine("            " + "\"" + line.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\",");

        Console.WriteLine("        };");
        Console.WriteLine();
        Console.WriteLine("        foreach (string line in lines)");
        Console.WriteLine("            Console.WriteLine(line);");
        Console.WriteLine();
        Console.WriteLine("        foreach (string line in source)");
        Console.WriteLine("            Console.WriteLine(\"            \" + \\\"\\\"\\\"\" + line.Replace(\"\\\\\", \"\\\\\\\\\").Replace(\"\\\"\", \"\\\\\\\"\") + \"\\\"\\\",\");");
        Console.WriteLine("    }");
        Console.WriteLine("}");
    }
}
