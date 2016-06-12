//-----------------------------------------------------------------------
// <copyright file="Cemetery.cs" company="FHICT">
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
    /// This class is used to store information about grave spreads.
    /// </summary>
    public class GraveSpread
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraveSpread"/> class.
        /// </summary>
        /// <param name="id">the ID of the grave spread.</param>
        /// <param name="graveLocations">the location of the grave spread.</param>
        /// <param name="startTime">the starting time of the grave spread.</param>
        /// <param name="endTime"> the end time of the grave spread.</param>
        public GraveSpread(int id, List<GraveLocation> graveLocations, DateTime startTime, DateTime endTime)
        {
            this.ID = id;
            this.GraveLocations = graveLocations;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// The ID of the grave spread.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// A list of the grave locations the grave spread consists of.
        /// </summary>
        public List<GraveLocation> GraveLocations { get; private set; }

        /// <summary>
        /// The starting time of the grave spread.
        /// </summary>
        public DateTime StartTime { get; protected set; }

        /// <summary>
        /// The end time of the grave spread.
        /// </summary>
        public DateTime EndTime { get; protected set; }

        /// <summary>
        /// A list of all reservations that belong to the grave spread.
        /// </summary>
        public List<Reservation> Reservations { get; protected set; }
    }
}