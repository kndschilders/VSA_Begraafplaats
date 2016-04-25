//-----------------------------------------------------------------------
// <copyright file="Photo.cs" company="FHICT">
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
    /// This class is used to store information about a photo.
    /// </summary>
    public class Photo
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Photo"/> class.
        /// </summary>
        /// <param name="id">The ID of the photo.</param>
        /// <param name="title">The title of the photo.</param>
        /// <param name="filePath">The file path of the photo.</param>
        /// <param name="description">The description of the photo.</param>
        /// <param name="uploadDate">The upload date of the photo.</param>
        public Photo(int id, string title, string filePath, string description, DateTime uploadDate)
        {
            this.ID = id;
            this.Title = title;
            this.FilePath = filePath;
            this.Description = description;
            this.UploadDate = uploadDate;
        }
        #endregion

        #region Variables & Properties
        /// <summary>
        /// Gets or sets the ID of this photo.
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// Gets or sets the title of this photo.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Gets or sets the file path of this photo.
        /// </summary>
        public string FilePath { get; protected set; }

        /// <summary>
        /// Gets or sets the description of this photo.
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// Gets or sets the upload date of this photo.
        /// </summary>
        public DateTime UploadDate { get; protected set; }
        #endregion
    }
}
