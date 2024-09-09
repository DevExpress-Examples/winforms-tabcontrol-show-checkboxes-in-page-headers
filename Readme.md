<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622400/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3039)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms TabControl - Display checkboxes in tab headers

This example displays checkboxes in tab page headers. The page's `Tag` property is used to store page state.

![WinForms TabControl - Display checkboxes in tab headers](https://raw.githubusercontent.com/DevExpress-Examples/how-to-show-checkboxes-in-xtratabcontrols-pages-headers-e3039/17.2.6%2B/media/winforms-tabcontrol-checkbox-in-tab-header.png)

```csharp
public partial class Form1 : XtraForm {
    private Dictionary<XtraTabPage, bool> _CheckedPages = new Dictionary<XtraTabPage, bool>();
    public Form1() {
        InitializeComponent();
        PaintStyleCollection.DefaultPaintStyles.Add(new MyRegistrator());
        xtraTabControl1.PaintStyleName = "MyStyle";
        xtraTabControl1.Tag = _CheckedPages;
    }
    private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e) {
        DevExpress.XtraTab.ViewInfo.XtraTabHitInfo hi = xtraTabControl1.CalcHitInfo(e.Location);
        if (hi.Page == null)
            return;
        bool inCheck = ((Rectangle)hi.Page.Tag).Contains(e.Location);
        if (inCheck) {
            bool value = false;
            _CheckedPages.TryGetValue(hi.Page, out value);
            _CheckedPages[hi.Page] = !value;
        }
        xtraTabControl1.Refresh();
    }
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-tabcontrol-show-checkboxes-in-page-headers&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-tabcontrol-show-checkboxes-in-page-headers&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
