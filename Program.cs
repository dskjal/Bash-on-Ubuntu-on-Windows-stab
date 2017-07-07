// BEGIN MIT LICENSE BLOCK //
//
// Copyright (c) 2016 dskjal
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//
// END MIT LICENSE BLOCK   //
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace buw_stab_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("引数にパスを指定してください．");
                Environment.Exit(1);
            }

            var lPath = args[0].Replace('\\', '/');
            lPath = "/mnt/" + lPath[0].ToString().ToLower() + lPath.Substring(2, lPath.Length - 2);
            Process.Start(@"C:\Windows\System32\bash.exe", lPath);
        }
    }
}
