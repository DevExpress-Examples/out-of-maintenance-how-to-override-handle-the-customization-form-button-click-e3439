using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Customization.Controls;
using DevExpress.XtraLayout;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public class MyCustomizationForm : CustomizationForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LayoutControlItem lci = layoutControl1.GetItemByControl(buttonsPanel1);
            ButtonsPanel oldPanel = lci.Control as ButtonsPanel;
            MyButtonsPanel newPanel = new MyButtonsPanel();
            oldPanel.UnRegister();
            lci.BeginInit();
            lci.Control = newPanel;
            newPanel.Parent = oldPanel.Parent;
            oldPanel.Parent = null;
            lci.EndInit();
            newPanel.Register();
            lci.Update();
        }
    }
    public class MyButtonsPanel : ButtonsPanel
    {
        protected override void OnSaveLayoutButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Save Layout Button");
            base.OnSaveLayoutButtonClick(sender, e);

        }
        protected override void OnLoadLayoutButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Load Layout Button");
            base.OnLoadLayoutButtonClick(sender, e);

        }

        protected override void OnRedoButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Redo Button");
            base.OnRedoButtonClick(sender, e);
        }

        protected override void OnUndoButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Undo Button");
            base.OnUndoButtonClick(sender, e);
        }

    }
}
