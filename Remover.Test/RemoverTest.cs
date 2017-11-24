﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//using NUnit.Framework;

namespace Remover.Test
{
    [TestClass]
    public class RemoverTest
    {
        private static Random rand = new Random();
        private static void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, Remover.Library.Remover.RemoveSmallest(argument));
        }
        [TestMethod]
        public void Test_Remove()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int>(), new List<int>());
        }
        
        [TestMethod]
        public static void RandomTests()
        {
            for (int i = 0; i < 100; i++)
            {
                List<int> l = RandomList();
                Tester(l, Answer(l));
            }
        }
        private static List<int> RandomList()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < rand.Next(15); i++)
            {
                list.Add(rand.Next(400));
            }
            return list;
        }
        private static List<int> Answer(List<int> numbers)
        {
            List<int> answer = numbers.ToList();
            if (answer.Count > 0)
            {
                answer.Remove(answer.Min());
            }
            return answer;
        }
    }
}
