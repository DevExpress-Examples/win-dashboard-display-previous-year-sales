using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace Dashboard_PrevYearData {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\Data\PrevYearData.xml");
        }
    }
}
