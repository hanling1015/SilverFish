﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Chuck.SilverFish;
using Chuck.SilverFish.Helpers;
using SilverFish.Enums;

namespace SilverFish.Helpers
{
    public class CardHelper
    {
        private static readonly Type[] AssemblyTypes;

        static CardHelper()
        {
            var assembly = Assembly.GetExecutingAssembly();
            AssemblyTypes = assembly.GetTypes();
            
            InitMinionWithManaCost();
        }

        public static SimTemplate GetCardSimulation(CardIdEnum tempCardIdEnum)
        {
            SimTemplate result = new SimTemplate();

            var className = $"Sim_{tempCardIdEnum}";
            var list = GetTypeByName(className);
            if (list.Count != 1)
            {
                if (list.Count >= 2)
                {
                    var content = string.Join(",", list.Select(x => x.FullName));
                    throw new Exception($"Find multiple card simulation class for {tempCardIdEnum} : {content}");
                }
            }
            else
            {
                var type = list[0];
                var simTemplateInstance = Activator.CreateInstance(type);
                if (simTemplateInstance is SimTemplate temp)
                {
                    result = temp;
                }
                else
                {
                    throw new Exception($"class {className} should inherit from {typeof(SimTemplate)}");
                }
            }

            return result;
        }

        /// <summary>
        /// Gets a all Type instances matching the specified class name with just non-namespace qualified class name.
        /// </summary>
        /// <param name="className">Name of the class sought.</param>
        /// <returns>Types that have the class name specified. They may not be in the same namespace.</returns>
        public static List<Type> GetTypeByName(string className)
        {
            var collection = AssemblyTypes.Where(t => t.Name.Equals(className));
            return collection.ToList();
        }

        public static bool IsCardSimulationImplemented(SimTemplate cardSimulation)
        {
            var type = cardSimulation.GetType();
            var baseType = typeof(SimTemplate);
            bool implemented = type.IsSubclassOf(baseType);
            return implemented;
        }

        /// <summary>
        /// key is mana cost
        /// </summary>
        public static Dictionary<SpecialCard, CardIdEnum> SpecialCards { get; } = new Dictionary<SpecialCard, CardIdEnum>();

        private static void InitMinionWithManaCost()
        {
            SpecialCards.Add(SpecialCard.RandomMinionManaCostOne, CardIdEnum.NEW1_026t);//紫罗兰学徒(Violet Apprentice)
            SpecialCards.Add(SpecialCard.RandomMurloc, CardIdEnum.EX1_506a);//鱼人斥候(Murloc Scout)
        }
    }
}
