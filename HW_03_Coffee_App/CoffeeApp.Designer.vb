<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.CoffeeSyrupListBox = New System.Windows.Forms.ListBox()
        Me.CoffeeSyrupLabel = New System.Windows.Forms.Label()
        Me.CoffeeFlavorComboBox = New System.Windows.Forms.ComboBox()
        Me.CoffeeFlavorLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFlavorListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCoffeeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCoffeeCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainGroupBox.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainGroupBox
        '
        Me.MainGroupBox.Controls.Add(Me.ClearButton)
        Me.MainGroupBox.Controls.Add(Me.PurchaseButton)
        Me.MainGroupBox.Controls.Add(Me.CoffeeSyrupListBox)
        Me.MainGroupBox.Controls.Add(Me.CoffeeSyrupLabel)
        Me.MainGroupBox.Controls.Add(Me.CoffeeFlavorComboBox)
        Me.MainGroupBox.Controls.Add(Me.CoffeeFlavorLabel)
        Me.MainGroupBox.Location = New System.Drawing.Point(69, 91)
        Me.MainGroupBox.Name = "MainGroupBox"
        Me.MainGroupBox.Size = New System.Drawing.Size(871, 362)
        Me.MainGroupBox.TabIndex = 0
        Me.MainGroupBox.TabStop = False
        Me.MainGroupBox.Text = "Select Coffee and Syrup"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(268, 199)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(162, 50)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(64, 199)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(162, 50)
        Me.PurchaseButton.TabIndex = 4
        Me.PurchaseButton.Text = "Purchase"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'CoffeeSyrupListBox
        '
        Me.CoffeeSyrupListBox.FormattingEnabled = True
        Me.CoffeeSyrupListBox.ItemHeight = 29
        Me.CoffeeSyrupListBox.Items.AddRange(New Object() {"Chocolate", "Hazelnut", "Irish Creme", "Orange"})
        Me.CoffeeSyrupListBox.Location = New System.Drawing.Point(515, 106)
        Me.CoffeeSyrupListBox.Name = "CoffeeSyrupListBox"
        Me.CoffeeSyrupListBox.Size = New System.Drawing.Size(235, 178)
        Me.CoffeeSyrupListBox.TabIndex = 3
        '
        'CoffeeSyrupLabel
        '
        Me.CoffeeSyrupLabel.AutoSize = True
        Me.CoffeeSyrupLabel.Location = New System.Drawing.Point(510, 60)
        Me.CoffeeSyrupLabel.Name = "CoffeeSyrupLabel"
        Me.CoffeeSyrupLabel.Size = New System.Drawing.Size(148, 29)
        Me.CoffeeSyrupLabel.TabIndex = 2
        Me.CoffeeSyrupLabel.Text = "S&yrup Flavor"
        '
        'CoffeeFlavorComboBox
        '
        Me.CoffeeFlavorComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CoffeeFlavorComboBox.FormattingEnabled = True
        Me.CoffeeFlavorComboBox.Location = New System.Drawing.Point(43, 106)
        Me.CoffeeFlavorComboBox.Name = "CoffeeFlavorComboBox"
        Me.CoffeeFlavorComboBox.Size = New System.Drawing.Size(421, 37)
        Me.CoffeeFlavorComboBox.TabIndex = 1
        '
        'CoffeeFlavorLabel
        '
        Me.CoffeeFlavorLabel.AutoSize = True
        Me.CoffeeFlavorLabel.Location = New System.Drawing.Point(49, 60)
        Me.CoffeeFlavorLabel.Name = "CoffeeFlavorLabel"
        Me.CoffeeFlavorLabel.Size = New System.Drawing.Size(157, 29)
        Me.CoffeeFlavorLabel.TabIndex = 0
        Me.CoffeeFlavorLabel.Text = "&Coffee Flavor"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 47)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1053, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ItemToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1053, 47)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveFlavorListToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(70, 43)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveFlavorListToolStripMenuItem
        '
        Me.SaveFlavorListToolStripMenuItem.Name = "SaveFlavorListToolStripMenuItem"
        Me.SaveFlavorListToolStripMenuItem.Size = New System.Drawing.Size(305, 42)
        Me.SaveFlavorListToolStripMenuItem.Text = "&Save Flavor List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(302, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(305, 42)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCoffeeFlavorToolStripMenuItem, Me.RemoveCoffeeFlavorToolStripMenuItem, Me.ClearCoffeeListToolStripMenuItem, Me.DisplayCoffeeCountToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(75, 43)
        Me.ItemToolStripMenuItem.Text = "&Edit"
        '
        'AddCoffeeFlavorToolStripMenuItem
        '
        Me.AddCoffeeFlavorToolStripMenuItem.Name = "AddCoffeeFlavorToolStripMenuItem"
        Me.AddCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(382, 42)
        Me.AddCoffeeFlavorToolStripMenuItem.Text = "Add Coffee Flavor"
        '
        'RemoveCoffeeFlavorToolStripMenuItem
        '
        Me.RemoveCoffeeFlavorToolStripMenuItem.Name = "RemoveCoffeeFlavorToolStripMenuItem"
        Me.RemoveCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(382, 42)
        Me.RemoveCoffeeFlavorToolStripMenuItem.Text = "Remove Coffee Flavor"
        '
        'ClearCoffeeListToolStripMenuItem
        '
        Me.ClearCoffeeListToolStripMenuItem.Name = "ClearCoffeeListToolStripMenuItem"
        Me.ClearCoffeeListToolStripMenuItem.Size = New System.Drawing.Size(382, 42)
        Me.ClearCoffeeListToolStripMenuItem.Text = "Clear Coffee List"
        '
        'DisplayCoffeeCountToolStripMenuItem
        '
        Me.DisplayCoffeeCountToolStripMenuItem.Name = "DisplayCoffeeCountToolStripMenuItem"
        Me.DisplayCoffeeCountToolStripMenuItem.Size = New System.Drawing.Size(382, 42)
        Me.DisplayCoffeeCountToolStripMenuItem.Text = "Display Coffee Count"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 43)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(297, 42)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CoffeeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 507)
        Me.Controls.Add(Me.MainGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CoffeeApp"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.MainGroupBox.ResumeLayout(False)
        Me.MainGroupBox.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainGroupBox As GroupBox
    Friend WithEvents CoffeeFlavorComboBox As ComboBox
    Friend WithEvents CoffeeFlavorLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents CoffeeSyrupListBox As ListBox
    Friend WithEvents CoffeeSyrupLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFlavorListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearCoffeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCoffeeCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
