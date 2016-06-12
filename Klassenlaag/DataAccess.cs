using Database;
using Klassenlaag;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenlaag
{
    public static class DataAccess
    {

        /// <summary>
        /// Gets a cemetery object containing the information of the cemetary including its map, grave locations and grave spreads. The information received is based on a given cemetary ID and a date.
        /// </summary>
        /// <param name="cemetaryID"></param>
        /// <param name="date"></param>
        /// <returns></returns>

        public static Cemetery GetCemeteryInformation(int cemetaryID, DateTime date)
        {
            // Query voor de begraafplaats met plattegrond en diens graflocaties en diens grafspreidingen voor een bepaalde datum
            string query = "SELECT b.ID AS BEG_ID, b.naam AS BEG_NAAM, b.adres AS BEG_ADRES, b.postcode AS BEG_POSTCODE, b.plaats AS BEG_PLAATS, gl.ID AS GL_ID, gl.nummer AS GL_NUMMER, gl.vak AS GL_VAK, gl.rij AS GL_RIJ, gl.status AS GL_STATUS, gl.coordinatenX AS GL_COORDINATENX, gl.coordinatenY AS GL_COORDINATENY, gl.startdatum AS GL_STARTDATUM, gl.einddatum AS GL_EINDDATUM, gs.ID AS GS_ID, gs.startdatum AS GS_STARTDATUM, gs.einddatum AS GS_EINDDATUM FROM BEGRAAFPLAATS b, GRAFLOCATIE gl LEFT JOIN GRAFLOCATIE_GRAFSPREIDING glgs ON glgs.graflocatieID = gl.ID LEFT JOIN GRAFSPREIDING gs ON glgs.grafspreidingID = gs.ID WHERE gl.begraafplaatsID = b.ID AND b.id = @cemetaryID AND (gl.einddatum >= @date || gl.einddatum IS NULL) AND gl.startdatum <= @date AND (gs.einddatum >= @date OR gs.einddatum IS NULL) AND gs.startdatum <= @date;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("cemetaryID", 1);
            parameters.Add("date", DateTime.Now);
            DataTable dataTable = DatabaseHandler.ExecuteSelectQuery(query, parameters);

            return ParseCemetery(dataTable);
        }

        /// <summary>
        /// Gets 
        /// </summary>
        /// <param name="cemetaryID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Photo> GetPhotos(int graveLocationID)
        {
            // Query voor het verkrijgen van alle foto's voor een bepaalde grafspreidingID en datum
            string query = "SELECT gl.ID AS GL_ID, f.ID AS FOTO_ID, f.titel AS FOTO_TITEL, f.bestandsnaam AS FOTO_BESTANDSNAAM, f.beschrijving AS FOTO_BESCHRIJVING, f.plaatsingsdatum AS FOTO_PLAATSINGSDATUM FROM FOTO f, GRAFLOCATIE gl, GRAFLOCATIE_GRAFSPREIDING glgs WHERE glgs.graflocatieID = gl.ID AND glgs.grafspreidingID = @graveSpreadID AND f.graflocatieID = gl.ID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("graveSpreadID", graveLocationID);
            DataTable dataTable = DatabaseHandler.ExecuteSelectQuery(query, parameters);

            return ParsePhotos(dataTable);
        }

        private static Cemetery ParseCemetery(DataTable dataTable)
        {

            DataRow firstRow = dataTable.Rows[0];
            int cemeteryID = (int)firstRow["BEG_ID"];
            string name = firstRow["BEG_NAAM"].ToString();
            string address = firstRow["BEG_ADRES"].ToString();
            string postalCode = firstRow["BEG_POSTCODE"].ToString();
            string residence = firstRow["BEG_PLAATS"].ToString();

            Cemetery cemetery = new Cemetery(cemeteryID, name, address, postalCode, residence);
        }

        private static List<Photo> ParsePhotos(DataTable dataTable)
        {
            List<Photo> photos = new List<Photo>();
            
            foreach (DataRow row in dataTable.Rows)
            {
                int photoID = (int) row["FOTO_ID"];
                string title = row["FOTO_TITEL"].ToString();
                string filePath = row["FOTO_BESTANDSNAAM"].ToString();
                string description = row["FOTO_BESCHRIJVING"].ToString();
                DateTime uploadDate = DateTime.Parse(row["FOTO_PLAATSINGSDATUM"].ToString());

                Photo photo = new Photo(photoID, title, filePath, description, uploadDate);

                photos.Add(photo);
            }

            return photos;
        }
    }
}
