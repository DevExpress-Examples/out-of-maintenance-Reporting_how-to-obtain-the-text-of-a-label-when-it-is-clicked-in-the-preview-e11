using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace PreviewLabelClick {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            MessageBox.Show(e.Brick.Text);
        }

        private void xrLabel2_PreviewDoubleClick(object sender, PreviewMouseEventArgs e) {
            MessageBox.Show(e.Brick.Text);
        }

    }
}
