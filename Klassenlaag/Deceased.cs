//-----------------------------------------------------------------------
// <copyright file="Deceased.cs" company="FHICT">
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
    /// This class is used to store information about a deceased person.
    /// </summary>
    public class Deceased
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Deceased"/> class.
        /// </summary>
        /// <param name="id">The ID of the deceased person.</param>
        /// <param name="name">The name of the deceased person.</param>
        /// <param name="firstNames">The first names of the deceased person.</param>
        /// <param name="partnerOf">The name of the partner of the deceased person.</param>
        /// <param name="dateOfBirth">The date of birth of the deceased person.</param>
        /// <param name="deceaseDate">The decease date of the deceased person.</param>
        public Deceased(int id, string name, string firstNames, string partnerOf, DateTime dateOfBirth, DateTime deceaseDate)
        {
            this.ID = id;
            this.Name = name;
            this.FirstNames = firstNames;
            this.PartnerOf = partnerOf;
            this.DateOfBirth = dateOfBirth;
            this.DeceaseDate = deceaseDate;

            this.SurvivingRelatives = new List<SurvivingRelative>();
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this deceased person.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// Gets or sets the name of this deceased person.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the first names of this deceased person.
        /// </summary>
        public string FirstNames { get; protected set; }

        /// <summary>
        /// Gets or sets the name of the partner of this deceased person.
        /// </summary>
        public string PartnerOf { get; protected set; }

        /// <summary>
        /// Gets or sets the date of birth of this deceased person.
        /// </summary>
        public DateTime DateOfBirth { get; protected set; }

        /// <summary>
        /// Gets or sets the decease date of this deceased person.
        /// </summary>
        public DateTime DeceaseDate { get; protected set; }

        /// <summary>
        /// Gets or sets the list of surviving relatives of this deceased person.
        /// </summary>
        public List<SurvivingRelative> SurvivingRelatives { get; protected set; }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a surviving relative to the list of surviving relatives.
        /// </summary>
        /// <param name="survivingRelative">The surviving relative to be added.</param>
        /// <returns>Returns true when the surviving relative has been successfully added, and false when it has failed to add the surviving relative.</returns>
        public bool AddSurvivingRelative(SurvivingRelative survivingRelative)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a surviving relative from the list of surviving relatives.
        /// </summary>
        /// <param name="survivingRelative">The surviving relative to be removed.</param>
        /// <returns>Returns true when the surviving relative has been successfully removed, and false when it has failed to remove the surviving relative.</returns>
        public bool RemoveSurvivingRelative(SurvivingRelative survivingRelative)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Modifies a surviving relative.
        /// To modify, keep the original surviving relative object. Next, modify this surviving relative. Lastly, call this method with both the unmodified and modified surviving relative objects.
        /// </summary>
        /// <param name="oldSurvivingRelative">The old surviving relative object.</param>
        /// <param name="newSurvivingRelative">The new surviving relative object.</param>
        /// <returns>Returns true when the surviving relative has been successfully modified, and false when it has failed to modify the surviving relative.</returns>
        public bool ModifySurvivingRelative(SurvivingRelative oldSurvivingRelative, SurvivingRelative newSurvivingRelative)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
