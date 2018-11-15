<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication6/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication6/Form1.vb))
* [MyCustomizationForm.cs](./CS/WindowsFormsApplication6/MyCustomizationForm.cs) (VB: [MyCustomizationForm.vb](./VB/WindowsFormsApplication6/MyCustomizationForm.vb))
* [Program.cs](./CS/WindowsFormsApplication6/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication6/Program.vb))
<!-- default file list end -->
# How to override (handle) the customization form button click


<p>It is applied only to versions prior to 15.1. If you are using version 15.1 and higher, please refer to the <a href="https://www.devexpress.com/Support/Center/p/T243928">How to override (handle) the customization form button click starting with the 15.1 version</a> example. Starting with the 15.1 version, the <strong>LayoutControl.RegisterUserCustomizatonForm</strong> method was replaced with <strong>LayoutControl.RegisterUserCustomizationForm</strong>.</p>
<p>It is possible to accomplish this task by creating your custom Customization Form descendant. In this descendant create a custom ButtonPanel control and override its internal methods:</p>
<p><strong>OnSaveLayoutButtonClick</strong> <br /> <strong>OnLoadLayoutButtonClick</strong> <br /> <strong>OnRedoButtonClick</strong> <br /> <strong>OnUndoButtonClick</strong></p>
<p>Note that inside ButtonPanels methods you can access a parent LayoutControl via the code snippet shown below:</p>


```cs
        protected override void OnSaveLayoutButtonClick(object sender, EventArgs e) {
            //((LayoutControl)OwnerControl) - LayoutControl that shows your own Customization form
            Form form =  ((LayoutControl)OwnerControl).FindForm(); //the form that contains a layout control (Form1 in this sample)
             base.OnSaveLayoutButtonClick(sender, e);
        }

```



<br/>


