using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        private Dictionary<XtraTabPage, bool> _CheckedPages = new Dictionary<XtraTabPage, bool>();
        public Form1()
        {
            InitializeComponent();
            PaintStyleCollection.DefaultPaintStyles.Add(new MyRegistrator());
            xtraTabControl1.PaintStyleName = "MyStyle";
            xtraTabControl1.Tag = _CheckedPages;
        }

        private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.XtraTabHitInfo hi = xtraTabControl1.CalcHitInfo(e.Location);
            if (hi.Page == null)
                return;
            bool inCheck = ((Rectangle)hi.Page.Tag).Contains(e.Location);
            if (inCheck)
            {
                bool value = false;
                _CheckedPages.TryGetValue(hi.Page, out value);
                _CheckedPages[hi.Page] = !value;
            }
            xtraTabControl1.Refresh();
        }
    }
}