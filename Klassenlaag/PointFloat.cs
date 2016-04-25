//-----------------------------------------------------------------------
// <copyright file="PointFloat.cs" company="FHICT">
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

    /// <summary>
    /// This class is used to store an x and y coordinate as a float.
    /// </summary>
    public class PointFloat
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PointFloat"/> class.
        /// </summary>
        /// <param name="x">The x coordinate of this point.</param>
        /// <param name="y">The y coordinate of this point.</param>
        public PointFloat(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the x coordinate of this point.
        /// </summary>
        public float X { get; set; }
        
        /// <summary>
        /// Gets or sets the y coordinate of this point.
        /// </summary>
        public float Y { get; set; }
        #endregion
    }
}
