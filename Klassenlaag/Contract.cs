//-----------------------------------------------------------------------
// <copyright file="Contract.cs" company="FHICT">
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
    /// This class is used to store information about a contract.
    /// </summary>
    public class Contract
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class.
        /// </summary>
        /// <param name="id">The ID of the contract.</param>
        /// <param name="filePath">The file path of the contract.</param>
        /// <param name="uploadDate">The upload date of the contract.</param>
        public Contract(int id, string filePath, DateTime uploadDate)
        {
            this.ID = id;
            this.FilePath = filePath;
            this.UploadDate = uploadDate;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this contract.
        /// </summary>
        public int ID { get; protected set; }
        
        /// <summary>
        /// Gets or sets the file path of this contract.
        /// </summary>
        public string FilePath { get; protected set; }

        /// <summary>
        /// Gets or sets the upload date of this contract.
        /// </summary>
        public DateTime UploadDate { get; protected set; }
        #endregion
    }
}
