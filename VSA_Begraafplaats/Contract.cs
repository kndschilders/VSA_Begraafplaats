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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();

            this.webBrowser1.Navigate(@"C:\Users\Koen\documents\visual studio 2013\Projects\VSA_Begraafplaats\VSA_Begraafplaats\Contracts\Contract1.pdf");
        }
    }
}
