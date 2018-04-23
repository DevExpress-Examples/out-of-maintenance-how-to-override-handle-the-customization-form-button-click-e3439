Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Customization.Controls

Namespace WindowsFormsApplication6
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			layoutControl1.RegisterUserCustomizatonForm(GetType(MyCustomizationForm))
		End Sub
	End Class

End Namespace
