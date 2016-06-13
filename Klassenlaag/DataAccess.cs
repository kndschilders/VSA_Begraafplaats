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
            string query = "SELECT b.ID AS BEG_ID, b.naam AS BEG_NAAM, b.adres AS BEG_ADRES, b.postcode AS BEG_POSTCODE, b.plaats AS BEG_PLAATS, pl.ID AS PL_ID, pl.bestandsnaam AS PL_BESTANDSNAAM, pl.startdatum AS PL_STARTDATUM, pl.einddatum AS PL_EINDDATUM, pl.linksbovenx AS PL_LINKSBOVENX, pl.linksbovenY AS PL_LINKSBOVENY, pl.rechtsonderX AS PL_RECHTSONDERX, pl.rechtsonderY AS PL_RECHTSONDERY, gl.ID AS GL_ID, gl.nummer AS GL_NUMMER, gl.vak AS GL_VAK, gl.rij AS GL_RIJ, gl.status AS GL_STATUS, gl.coordinatenX AS GL_COORDINATENX, gl.coordinatenY AS GL_COORDINATENY, gl.startdatum AS GL_STARTDATUM, gl.einddatum AS GL_EINDDATUM, gs.ID AS GS_ID, gs.startdatum AS GS_STARTDATUM, gs.einddatum AS GS_EINDDATUM FROM BEGRAAFPLAATS b, PLATTEGROND pl, GRAFLOCATIE gl LEFT JOIN GRAFLOCATIE_GRAFSPREIDING glgs ON glgs.graflocatieID = gl.ID LEFT JOIN GRAFSPREIDING gs ON glgs.grafspreidingID = gs.ID WHERE gl.begraafplaatsID = b.ID AND b.ID = @cemeteryID AND pl.id = (SELECT ID FROM PLATTEGROND p2 WHERE p2.begraafplaatsID = b.ID AND p2.startdatum = (SELECT MAX(startdatum) FROM PLATTEGROND p3 WHERE p3.begraafplaatsID = b.ID) LIMIT 1) AND (gl.einddatum >= @date || gl.einddatum IS NULL) AND gl.startdatum <= @date AND (gs.einddatum >= @date OR gs.einddatum IS NULL) AND gs.startdatum <= @date;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("cemeteryID", 1);
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

        public static Reservation GetReservation(int graveSpreadID, DateTime date)
        {
            // Query voor gegevens van één grafspreiding voor een bepaalde datum
            // - Reserveringsgegevens
            // - Overledene
            // - Nabestaanden
            // - Contracten
            string query = "SELECT r.ID AS RES_ID, r.rechtenVan AS RES_RECHTENVAN, r.rechtenTot AS RES_RECHTENTOT, r.looptijd AS RES_LOOPTIJD, r.isVerlengd AS RES_ISVERLENGD, r.ruimkostenGefactureerd AS RES_RUIMKOSTENGEFACTUREERD, ol.ID AS OL_ID, ol.naam AS OL_NAAM, ol.voornamen AS OL_VOORNAMEN, ol.echtgenootvan AS OL_ECHTGENOOTVAN, ol.geboortedatum AS OL_GEBOORTEDATUM, ol.overlijdensdatum AS OL_OVERLIJDENSDATUM, ol.laag AS OL_LAAG, nb.ID AS NAB_ID, nb.naam AS NAB_NAAM, nb.adres AS NAB_ADRES, nb.postcode AS NAB_POSTCODE, nb.woonplaats AS NAB_WOONPLAATS, nb.aantekening AS NAB_AANTEKENING, c.ID AS CON_ID, c.bestandsnaam AS CON_BESTANDSNAAM, c.plaatsingsdatum AS CON_PLAATSINGSDATUM FROM RESERVERING r LEFT JOIN OVERLEDENE ol ON ol.reserveringID = r.ID LEFT JOIN OVERLEDENE_NABESTAANDE olnb ON olnb.overledeneID = ol.ID LEFT JOIN NABESTAANDE nb ON olnb.ID LEFT JOIN CONTRACT c ON c.reserveringID = r.ID WHERE r.grafspreidingID = @graveSpreadID AND c.plaatsingsdatum <= @date AND ol.overlijdensdatum <= @date;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("graveSpreadID", 1);
            parameters.Add("date", DateTime.Now);

            DataTable dataTable = DatabaseHandler.ExecuteSelectQuery(query, parameters);

            return ParseReservation(dataTable, graveSpreadID);
        }

        private static Cemetery ParseCemetery(DataTable dataTable)
        {

            DataRow firstRow = dataTable.Rows[0];
            int cemeteryID = (int)firstRow["BEG_ID"];
            string name = firstRow["BEG_NAAM"].ToString();
            string address = firstRow["BEG_ADRES"].ToString();
            string postalCode = firstRow["BEG_POSTCODE"].ToString();
            string residence = firstRow["BEG_PLAATS"].ToString();

            int mapID = (int)firstRow["PL_ID"];
            string mapFilePath = firstRow["PL_BESTANDSNAAM"].ToString();
            DateTime mapStartDate = DateTime.Parse(firstRow["PL_STARTDATUM"].ToString());
            DateTime mapEndDate = DateTime.Parse(firstRow["PL_EINDDATUM"].ToString());

            float locationLeftTopX = (float)firstRow["PL_LINKSBOVENX"];
            float locationLeftTopY = (float)firstRow["PL_LINKSBOVENY"];
            float locationRightBottomX = (float)firstRow["PL_RECHTSONDERX"];
            float locationRightBottomY = (float)firstRow["PL_RECHTSONDERY"];

            PointFloat locationLeftTop = new PointFloat(locationLeftTopX, locationLeftTopY);
            PointFloat locationRightBottom = new PointFloat(locationRightBottomX, locationRightBottomY);
            Map map = new Map(mapID, mapFilePath, mapStartDate, mapEndDate, locationLeftTop, locationRightBottom);

            Cemetery cemetery = new Cemetery(cemeteryID, name, address, postalCode, residence, map);

            foreach (DataRow row in dataTable.Rows)
            {
                int graveLocationID = (int)row["GL_ID"];

                GraveLocation graveLocation = cemetery.GraveLocations.Find(gl => gl.ID == graveLocationID);

                if (graveLocation == null)
                {
                    int graveLocationNumber = (int)row["GL_NUMMER"];
                    int graveLocationSectionNumber = (int)row["GL_VAK"];
                    int graveLocationRowNumber = (int)row["GL_RIJ"];

                    GraveLocationState graveLocationState = (GraveLocationState)Enum.Parse(typeof(GraveLocationState), row["GL_STATUS"].ToString());

                    float graveLocationLocationX = (float)row["GL_COORDINATENX"];
                    float graveLocationLocationY = (float)row["GL_COORDINATENY"];

                    PointFloat graveLocationLocation = new PointFloat(graveLocationLocationX, graveLocationLocationY);

                    graveLocation = new GraveLocation(graveLocationID, graveLocationNumber, graveLocationRowNumber, graveLocationSectionNumber, graveLocationState, graveLocationLocation);

                    cemetery.AddGraveLocation(graveLocation);
                }

                Object gravesSpreadIDUnparsed = row["gs_ID"];

                if (gravesSpreadIDUnparsed != null)
                {
                    int graveSpreadID = (int)row["GS_ID"];

                    GraveSpread graveSpread = cemetery.GraveSpreads.Find(gs => gs.ID == graveSpreadID);

                    if (graveSpread == null)
                    {
                        DateTime startTime = DateTime.Parse(row["GS_STARTDATUM"].ToString());
                        DateTime endTime = DateTime.Parse(row["GS_EINDDATUM"].ToString());
                        graveSpread = new GraveSpread(graveSpreadID, startTime, endTime);
                    }

                    graveSpread.AddGraveLocation(graveLocation);
                }
            }

            return cemetery;
        }

        private static List<Photo> ParsePhotos(DataTable dataTable)
        {
            List<Photo> photos = new List<Photo>();

            foreach (DataRow row in dataTable.Rows)
            {
                int photoID = (int)row["FOTO_ID"];
                string title = row["FOTO_TITEL"].ToString();
                string filePath = row["FOTO_BESTANDSNAAM"].ToString();
                string description = row["FOTO_BESCHRIJVING"].ToString();
                DateTime uploadDate = DateTime.Parse(row["FOTO_PLAATSINGSDATUM"].ToString());

                Photo photo = new Photo(photoID, title, filePath, description, uploadDate);

                photos.Add(photo);
            }

            return photos;
        }

        private static Reservation ParseReservation(DataTable dataTable, int graveSpreadID)
        {
            //nb.ID AS NAB_ID, nb.naam AS NAB_NAAM, nb.adres AS NAB_ADRES, nb.postcode AS NAB_POSTCODE, nb.woonplaats AS NAB_WOONPLAATS, nb.aantekening AS NAB_AANTEKENING, c.ID AS CON_ID, c.bestandsnaam AS CON_BESTANDSNAAM, c.plaatsingsdatum AS CON_PLAATSINGSDATUM
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            GraveSpread graveSpread = Controller.Cemetery.GraveSpreads.Find(gs => gs.ID == graveSpreadID);

            DataRow firstRow = dataTable.Rows[0];

            int reservationID = (int)firstRow["RES_ID"];
            DateTime reservationstartDate = DateTime.Parse(firstRow["RES_RECHTENVAN"].ToString());
            DateTime reservationEndDate = DateTime.Parse(firstRow["RES_RECHTENTOT"].ToString());
            int durationInYears = (int)firstRow["RES_LOOPTIJD"];
            bool isProlonged = (int)firstRow["RES_ISVERLENGD"] == 1;
            bool areClearingCostsInvoiced = (int)firstRow["RES_RUIMKOSTENGEFACTUREERD"] == 1;

            Reservation reservation = new Reservation(reservationID, graveSpread, reservationstartDate, reservationEndDate, durationInYears, isProlonged, areClearingCostsInvoiced);

            foreach (DataRow row in dataTable.Rows)
            {
                int deceasedID = (int)row["OL_ID"];

                Deceased deceased = reservation.Deceased.Find(d => d.ID == deceasedID);

                if (deceased == null)
                {
                    string deceasedName = row["OL_NAAM"].ToString();
                    string firstNames = row["OL_VOORNAMEN"].ToString();
                    string partnerOf = row["OL_ECHTGENOOTVAN"].ToString();
                    DateTime dateOfBirth = DateTime.Parse(row["OL_GEBOORTEDATUM"].ToString());
                    DateTime deceaseDate = DateTime.Parse(row["OL_OVERLIJDENSDATUM"].ToString());

                    deceased = new Deceased(deceasedID, deceasedName, firstNames, partnerOf, dateOfBirth, deceaseDate);

                    Object survivingRelativeIDUnparsed = row["NAB_ID"];

                    if (survivingRelativeIDUnparsed != null)
                    {
                        int survivingRelativeID = (int)survivingRelativeIDUnparsed;
                    }

                    reservation.AddDeceased(deceased);
                }
            }
        }
    }
}
