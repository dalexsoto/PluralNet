﻿/*
 * Huyn.PluralNet
 * Author  Rudy Huyn (6Studio)
 * License MIT / http://bit.ly/mit-license
 * 
 * Version 1.00
 */

using Huyn.PluralNet.Utils;
using Huyn.PluralNet.Interfaces;


namespace Huyn.PluralNet.Providers
{
    public class WelshProvider : IPluralProvider
    {
        public PluralTypeEnum ComputePlural(decimal n)
        {
            var isInt = n.IsInt();
            if (isInt)
            {
                var i = (int)n;
                switch (i)
                {
                    case 0:
                        return PluralTypeEnum.ZERO;
                    case 1:
                        return PluralTypeEnum.ONE;
                    case 2:
                        return PluralTypeEnum.TWO;
                    case 3:
                        return PluralTypeEnum.FEW;
                    case 6:
                        return PluralTypeEnum.MANY;
                }
            }
            return PluralTypeEnum.OTHER;
        }
    }
}
