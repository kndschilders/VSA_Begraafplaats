//-----------------------------------------------------------------------
// <copyright file="SurvivingRelative.cs" company="FHICT">
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
    /// This class is used to store information about a surviving relative.
    /// </summary>
    public class SurvivingRelative
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SurvivingRelative"/> class.
        /// </summary>
        /// <param name="id">The ID of the surviving relative.</param>
        /// <param name="name">The name of the surviving relative.</param>
        /// <param name="address">The address of the surviving relative.</param>
        /// <param name="postalCode">The postal code of the surviving relative.</param>
        /// <param name="domicile">The domicile of the surviving relative.</param>
        /// <param name="note">The note of the surviving relative.</param>
        public SurvivingRelative(int id, string name, string address, string postalCode, string domicile, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PostalCode = postalCode;
            this.Domicile = domicile;
            this.Note = note;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this surviving relative.
        /// </summary>
        public int ID { get; protected set; }
        
        /// <summary>
        /// Gets or sets the name of this surviving relative.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the address of this surviving relative.
        /// </summary>
        public string Address { get; protected set; }

        /// <summary>
        /// Gets or sets the postal code of this surviving relative.
        /// </summary>
        public string PostalCode { get; protected set; }

        /// <summary>
        /// Gets or sets the domicile of this surviving relative.
        /// </summary>
        public string Domicile { get; protected set; }

        /// <summary>
        /// Gets or sets the note of this surviving relative.
        /// </summary>
        public string Note { get; protected set; }
        #endregion
    }
}
