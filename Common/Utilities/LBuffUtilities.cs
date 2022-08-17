﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBuffMod.Common.Utilities
{
    public static class LBuffUtilities
    {
        //所有要加强的debuff：着火了！、狱火、霜火、霜噬、诅咒焰、暗影焰、日耀、中毒、毒液、带电
        public static int[] damagingDebuffsToBuff =
        {
            BuffID.OnFire, BuffID.OnFire3, BuffID.Frostburn, BuffID.Frostburn2, BuffID.CursedInferno,
            BuffID.ShadowFlame, BuffID.Daybreak, BuffID.Poisoned, BuffID.Venom, BuffID.Electrified
        };
        //热能debuff：着火了！、狱火、霜火、霜噬、诅咒焰、暗影焰、日耀、灼烧
        public static int[] thermalDebuffs =
        {
            BuffID.OnFire, BuffID.OnFire3, BuffID.Frostburn, BuffID.Frostburn2, BuffID.CursedInferno,
            BuffID.ShadowFlame, BuffID.Daybreak, BuffID.Burning
        };
        //毒性debuff：中毒、毒液
        public static int[] poisonousDebuffs =
        {
            BuffID.Poisoned, BuffID.Venom
        };
        public static int GetAllElements(int[] intArray)
        {
            int element = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                element = intArray[i];
            }
            return element;
        }
        public static int BuffIDToLifeRegen(int buffID)
        {
            switch (buffID)
            {
                default: 
                    return 0;
                case BuffID.OnFire:
                    return -8;
                case BuffID.OnFire3:
                    return -30;
                case BuffID.Frostburn:
                    return -16;
                case BuffID.Frostburn2:
                    return -50;
                case BuffID.CursedInferno:
                    return -48;
                case BuffID.ShadowFlame:
                    return -30;
                case BuffID.Daybreak:
                    return -50;
                case BuffID.Burning:
                    return -100;
                case BuffID.Poisoned:
                    return -4;
                case BuffID.Venom:
                    return -60;
                case BuffID.BoneJavelin:
                    return -6;
                case BuffID.Electrified:
                    return -8;
                case BuffID.DryadsWardDebuff:
                    return -14;
                case BuffID.Suffocation:
                    return -40;
                case BuffID.Bleeding:
                    return -6;//Does not give negative lifeRegen in vanilla code
                case BuffID.TheTongue:
                    return -100;
            }
        }
    }
}