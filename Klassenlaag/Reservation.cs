//-----------------------------------------------------------------------
// <copyright file="Reservation.cs" company="FHICT">
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
    /// This class is used to store information about a reservation.
    /// </summary>
    public class Reservation
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation"/> class.
        /// </summary>
        /// <param name="id">The ID of the reservation.</param>
        /// <param name="graveSpreads">The grave spreads of the reservation.</param>
        /// <param name="graveLayer">The graf layer of the reservation.</param>
        /// <param name="deceased">The deceased person of the reservation.</param>
        /// <param name="startDate">The start date of the reservation.</param>
        /// <param name="endDate">The end date of the reservation.</param>
        /// <param name="durationInYears">The duration in years of the reservation.</param>
        /// <param name="isProlonged">A boolean indicating whether the reservation is prolonged.</param>
        /// <param name="areClearingCostsInvoiced">A boolean indicating whether the reservation has invoiced clearing costs.</param>
        public Reservation(int id, GraveSpread graveSpread, int graveLayer, Deceased deceased, DateTime startDate, DateTime endDate, int durationInYears, bool isProlonged, bool areClearingCostsInvoiced)
        {
            this.ID = id;
            this.GraveSpread = graveSpread;
            this.Deceased = deceased;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DurationInYears = durationInYears;
            this.IsProlonged = isProlonged;
            this.AreClearingCostsInvoiced = areClearingCostsInvoiced;

            this.Contracts = new List<Contract>();
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this reservation.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// The graveSpread the reservation belongs to.
        /// </summary>
        public GraveSpread GraveSpread { get; protected set; }

        /// <summary>
        /// Gets or sets the start date of this reservation.
        /// </summary>
        public DateTime StartDate { get; protected set; }

        /// <summary>
        /// Gets or sets the end date of this reservation.
        /// </summary>
        public DateTime EndDate { get; protected set; }

        /// <summary>
        /// Gets or sets the duration in years of this reservation.
        /// </summary>
        public int DurationInYears { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether this reservation is prolonged.
        /// </summary>
        public bool IsProlonged { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether this reservation has invoiced clearing costs.
        /// </summary>
        public bool AreClearingCostsInvoiced { get; protected set; }

        /// <summary>
        /// Gets or sets a list of contracts.
        /// </summary>
        public List<Contract> Contracts { get; protected set; }

        /// <summary>
        /// Gets or sets the deceased person.
        /// </summary>
        public Deceased Deceased { get; protected set; }
        #endregion

        #region Methods
        /// <summary>
        /// Uploads a contract of this reservation.
        /// </summary>
        /// <param name="contract">The contract to be uploaded.</param>
        /// <returns>Returns true when the contract has been successfully uploaded, and false when it has failed to upload the contract.</returns>
        public bool UploadContract(Contract contract)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a contract of this reservation.
        /// </summary>
        /// <param name="contract">The contract to be removed.</param>
        /// <returns>Returns true when the contract has been successfully removed, and false when it has failed to remove the contract.</returns>
        public bool RemoveContract(Contract contract)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
