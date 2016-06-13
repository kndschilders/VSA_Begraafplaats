using Klassenlaag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSA_Begraafplaats
{
    public partial class Graf : Form
    {
        public Graf(GraveSpread graveSpread)
        {
            InitializeComponent();

            this.GraveSpread = graveSpread;
            FindReservation(graveSpread);
            FindGraveLocations(graveSpread);

            BindGUIControls();
        }

        public Graf()
        {
            InitializeComponent();
        }

        private GraveSpread GraveSpread { get; set; }

        private Reservation Reservation { get; set; }

        private List<GraveLocation> GraveLocations { get; set; }

        private void btnContract_Click(object sender, EventArgs e)
        {
            Form contractForm = new Contract();
            contractForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindGraveLocations(GraveSpread graveSpread)
        {
            throw new NotImplementedException();
        }

        private void BindGUIControls()
        {
            cbxGraveNumber.DataSource = null;
            cbxGraveNumber.DataSource = GraveLocations;
            cbxGraveNumber.DisplayMember = "Number";
            cbxGraveNumber.SelectedIndex = 0;

            cbxGraveState.DataSource = null;
            cbxGraveState.DataSource = Enum.GetValues(typeof(GraveLocationState));
            cbxGraveState.Enabled = false;
            cbxGraveState.SelectedIndex = 0;


            cbxPeople.DataSource = null;
            cbxPeople.DataSource = Reservation.Deceased;
            cbxPeople.DisplayMember = "Name";
            cbxPeople.SelectedIndex = 0;

        }

        private void FindReservation(GraveSpread graveSpread)
        {
            throw new NotImplementedException();
        }

        private void cbxGraveNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            GraveLocation CurrentGraveLocation;

            CurrentGraveLocation = GraveLocations.Find(x => x.Number.ToString() == cbxGraveNumber.SelectedText);

            tbxGraveSection.Text = CurrentGraveLocation.SectionNumber.ToString();
            tbxGraveRow.Text = CurrentGraveLocation.RowNumber.ToString();
            cbxGraveState.SelectedText = CurrentGraveLocation.State.ToString();
        }

        private void cbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deceased CurrentDeceased;

            CurrentDeceased = Reservation.Deceased.Find(x => x.Name == cbxPeople.SelectedText);

            tbxPersonName.Text
        }
    }
}
