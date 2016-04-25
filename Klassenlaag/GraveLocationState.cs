//-----------------------------------------------------------------------
// <copyright file="GraveLocationState.cs" company="FHICT">
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
    /// This enumeration specifies the state of a grave location.
    /// </summary>
    public enum GraveLocationState
    {
        /// <summary>
        /// The reserved state.
        /// This state indicates a grave that has a reservation. This grave cannot have any more reservations.
        /// </summary>
        Reserved,
        
        /// <summary>
        /// The occupied state.
        /// This state indicates a grave that has already been occupied. This grave cannot have reservations.
        /// </summary>
        Occupied,
        
        /// <summary>
        /// The available state.
        /// This state indicates a grave that is available, and thus doesn't have any reservations and is not occupied.
        /// </summary>
        Available,
        
        /// <summary>
        /// The expired state.
        /// This state indicates a grave that is expired. The grave cannot have any more reservations.
        /// </summary>
        Expired,
        
        /// <summary>
        /// The potential state.
        /// This state indicates a grave that MIGHT be available in the future, but does not exist yet. This grave cannot have any reservations, and is only used to indicate the potential of a grave.
        /// </summary>
        Potential
    }
}
