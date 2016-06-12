//-----------------------------------------------------------------------
// <copyright file="Map.cs" company="FHICT">
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
    /// This class is used to store information about a map object.
    /// </summary>
    public class Map
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        /// <param name="id">The ID of the map.</param>
        /// <param name="filePath">The file path of the image of the map.</param>
        /// <param name="startDate">The start date of the map.</param>
        /// <param name="endDate">The end date of the map.</param>
        /// <param name="location">The location of the map.</param>
        public Map(int id, string filePath, DateTime startDate, DateTime endDate, PointFloat location)
        {
            this.ID = id;
            this.FilePath = filePath;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Location = Location;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this map.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// Gets or sets the file path of this map.
        /// </summary>
        public string FilePath { get; protected set; }

        /// <summary>
        /// Gets or sets the start date of this map.
        /// </summary>
        public DateTime StartDate { get; protected set; }

        /// <summary>
        /// Gets or sets the end date of this map.
        /// </summary>
        public DateTime EndDate { get; protected set; }

        /// <summary>
        /// Gets or Sets the location of the map.
        /// </summary>
        public PointFloat Location { get; protected set; }
        #endregion
    }
}
