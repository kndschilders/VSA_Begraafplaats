//-----------------------------------------------------------------------
// <copyright file="Controller.cs" company="FHICT">
//     Copyright (c) FHICT. All rights reserved.
// </copyright>
// <author>Jeroen Janssen, Koen Schilders, Pim Janissen</author>
//-----------------------------------------------------------------------
namespace Klassenlaag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is used to ...
    /// </summary>
    public static class Controller
    {
        public static Cemetery Cemetery { get; private set; }

        public static void GetCemetery(int id, DateTime date)
        {
            Cemetery = DataAccess.GetCemeteryInformation(id, date);
        }
    }
}
