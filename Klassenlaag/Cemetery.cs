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
    /// This class is used to store the information about a cemetery.
    /// </summary>
    public class Cemetery
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Cemetery"/> class.
        /// </summary>
        /// <param name="id">The ID of the cemetery, used for identification.</param>
        /// <param name="name">The name of the cemetery.</param>
        /// <param name="address">The address of the cemetery.</param>
        /// <param name="postalCode">The postal code of the cemetery.</param>
        /// <param name="residence">The residence of the cemetery.</param>
        /// <param name="map">The map of the cemetery.</param>
        public Cemetery(int id, string name, string address, string postalCode, string residence, Map map)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.PostalCode = postalCode;

            this.GraveLocations = new List<GraveLocation>();
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this cemetery.
        /// </summary>
        public int ID { get; protected set; }
        
        /// <summary>
        /// Gets or sets the name of this cemetery.
        /// </summary>
        public string Name { get; protected set; }
        
        /// <summary>
        /// Gets or sets the address of this cemetery.
        /// </summary>
        public string Address { get; protected set; }
        
        /// <summary>
        /// Gets or sets the postal code of this cemetery.
        /// </summary>
        public string PostalCode { get; protected set; }
        
        /// <summary>
        /// Gets or sets the domicile of this cemetery.
        /// </summary>
        public string Domicile { get; protected set; }

        /// <summary>
        /// Gets or sets the <see cref="GraveLocation"/> object of this cemetery.
        /// </summary>
        public List<GraveLocation> GraveLocations { get; protected set; }

        /// <summary>
        /// Gets or sets a list of <see cref="Map"/> objects of this cemetery.
        /// </summary>
        public List<Map> Maps { get; protected set; }

        public List<GraveSpread> GraveSpreads { get; protected set; }
        #endregion

        #region Methods
        /// <summary>
        /// Remove a <see cref="GraveLocation"/> objection from this cemetery.
        /// </summary>
        /// <param name="graveLocation">The <see cref="GraveLocation"/> object to be removed.</param>
        public void RemoveGraveLocation(GraveLocation graveLocation)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
