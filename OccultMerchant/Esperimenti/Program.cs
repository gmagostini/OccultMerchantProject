﻿using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Warehouse.items;
using CasterClass = Warehouse.items.CasterClass;
using CoinType = Warehouse.items.CoinType;
using Price = Warehouse.items.Price;


namespace Esperimenti
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            guidTest();

        }

        public static void guidTest()
        {
            GuidTest test =new ();
            Console.WriteLine(test.test.ToString());
            GuidTest test2 = new GuidTest(test.test.ToString());
            Console.WriteLine(test2.test.ToString());
            GuidTest test3 = new GuidTest();
            Console.WriteLine(test3.test.ToString());
        }
        public void test1()
        {
            Price pr = new Price(20,CoinType.SilverCoin);
            string str = pr.ToString();

            string[] lista = str.Split( ':');
            Price tmp = new Price(int.Parse(lista[0].Substring(1)), (CoinType) int.Parse(lista[1].Remove(lista[1].Length-1)));
        }

        public static void test2()
        {
            string str = "[0:none]|[0:none]|[0:none]";
            string[] strListraw = str.Split('|');
            List<CasterClass> result = new List<CasterClass>();
            foreach (string s in strListraw)
            {
                var tmp = s.Split(":");
                result.Add(new CasterClass(int.Parse(tmp[0].Substring(1)),tmp[1].Remove(tmp[1].Length-1)));
            }

            foreach (CasterClass casterClass in result)
            {
                Console.WriteLine(casterClass.ToString());
            }
        }

        public static void test3()
        {
            string str = "[]";
            List<Component> result = new List<Component>();
            string tmp = str.Remove(str.Length - 1);
            tmp = tmp.Substring(1);
            string[] strList = tmp.Split(',');
            Console.WriteLine(tmp);
            if (tmp != "")
            {
                foreach (string s in strList)
                {
                    result.Add((Component) int.Parse(s));
                }
            }

            foreach (Component component in result)
            {
                 Console.WriteLine(component.ToString());
            }
        }
    }
}