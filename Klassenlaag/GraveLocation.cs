//-----------------------------------------------------------------------
// <copyright file="GraveLocation.cs" company="FHICT">
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
    /// This class is used to store information about a grave location.
    /// </summary>
    public class GraveLocation
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GraveLocation"/> class.
        /// </summary>
        /// <param name="id">The ID of the grave location.</param>
        /// <param name="number">The number of the grave location.</param>
        /// <param name="sectionNumber">The section number of the grave location.</param>
        /// <param name="rowNumber">The row number of the grave location.</param>
        /// <param name="numberInRow">The number in row of the grave location.</param>
        /// <param name="state">The state of the grave location.</param>
        /// <param name="location">The location of the grave location.</param>
        public GraveLocation(int id, int number, int sectionNumber, int rowNumber, int numberInRow, GraveLocationState state, PointFloat location)
        {
            this.ID = id;
            this.Number = number;
            this.SectionNumber = sectionNumber;
            this.RowNumber = rowNumber;
            this.NumberInRow = numberInRow;
            this.State = state;
            this.Location = location;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this grave location.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// Gets or sets the number of this grave location.
        /// </summary>
        public int Number { get; protected set; }

        /// <summary>
        /// Gets or sets the section number of this grave location.
        /// </summary>
        public int SectionNumber { get; protected set; }

        /// <summary>
        /// Gets or sets the row number of this grave location.
        /// </summary>
        public int RowNumber { get; protected set; }

        /// <summary>
        /// Gets or sets the number in row of this grave location.
        /// </summary>
        public int NumberInRow { get; protected set; }

        /// <summary>
        /// Gets or sets the state of this grave location.
        /// </summary>
        public GraveLocationState State { get; protected set; }

        /// <summary>
        /// Gets or sets the location of this grave location.
        /// </summary>
        public PointFloat Location { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether this grave is a double grave.
        /// </summary>
        public bool IsDoubleGrave { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether this grave is a family grave.
        /// </summary>
        public bool IsFamilyGrave { get; protected set; }

        /// <summary>
        /// Gets or sets a list of reservations of this grave location.
        /// </summary>
        public List<Reservation> Reservations { get; protected set; }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a reservation to the list of reservations of this grave locations.
        /// </summary>
        /// <param name="reservation">The reservation to be added.</param>
        /// <returns>Returns true when the reservation has been successfully added, and false when it has failed to add the reservation.</returns>
        public bool AddReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a reservation of this grave location.
        /// To modify, keep the original reservation. Next, modify this reservation. Lastly, call this method with both the unmodified and modified reservation objects.
        /// </summary>
        /// <param name="oldReservation">The old reservation.</param>
        /// <param name="newReservation">The new reservation.</param>
        /// <returns>Returns true when the reservation has been successfully modified, and false when it has failed to modify the reservation.</returns>
        public bool ModifyReservation(Reservation oldReservation, Reservation newReservation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a reservation from the list of reservations of this grave location.
        /// </summary>
        /// <param name="reservation">The reservation to be removed.</param>
        /// <returns>Returns true when the reservation has been successfully removed, and false when it has failed to remove the reservation.</returns>
        public bool RemoveReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
