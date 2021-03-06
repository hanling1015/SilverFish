﻿using System;
using NUnit.Framework;

namespace MonoTest.EnumTest
{
    [TestFixture]
    public class OptionTest
    {
        [Test]
        public void Test()
        {
            Option option1 = (Option)Enum.Parse(typeof(Option), "IN_WILD_MODE");
            Console.WriteLine((int)option1);//new version is 216


            Option option2 = (Option)Enum.Parse(typeof(Option), "IN_RANKED_PLAY_MODE");
            Console.WriteLine((int)option2);//new version is 177
        }
    }
}
