<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtRadius = New TextBox()
        txtHeight = New TextBox()
        txtVolume = New TextBox()
        btnClearall = New Button()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' txtRadius
        ' 
        resources.ApplyResources(txtRadius, "txtRadius")
        txtRadius.Name = "txtRadius"
        ' 
        ' txtHeight
        ' 
        resources.ApplyResources(txtHeight, "txtHeight")
        txtHeight.Name = "txtHeight"
        ' 
        ' txtVolume
        ' 
        resources.ApplyResources(txtVolume, "txtVolume")
        txtVolume.Name = "txtVolume"
        ' 
        ' btnClearall
        ' 
        btnClearall.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        resources.ApplyResources(btnClearall, "btnClearall")
        btnClearall.Name = "btnClearall"
        btnClearall.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        resources.ApplyResources(btnCalculate, "btnCalculate")
        btnCalculate.Name = "btnCalculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Controls.Add(btnCalculate)
        Controls.Add(btnClearall)
        Controls.Add(txtVolume)
        Controls.Add(txtHeight)
        Controls.Add(txtRadius)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents btnClearall As Button
    Friend WithEvents btnCalculate As Button

End Class
