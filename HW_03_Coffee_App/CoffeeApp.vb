' Author: Keith Smith
' Date: 1 November 2018
' Description: This application reads from a text file and populates a combo box with items.
' The User can add or remove items from this list and save their changes as well. Selecting
' an item from the combo box and an item from the list box allows the User to click the
' purchase button, which displays a modal window describing the coffee flavor and coffee
' syrup that they selected. The application checks the combo box items against the file
' coffee_flavors.txt and prompts the user to save if changes have been detected.

Option Explicit On
Option Strict On

' For using stream readers/writers -> File I/O
Imports System.IO

Public Class CoffeeApp
    ' Create Stream Writer variable for use in methods
    Dim CoffeeStreamWriter As StreamWriter

    ' Create Array to store initial combo box items to compare at application exit
    Dim CoffeeFlavorsArray(0) As String

    ' Here is application load method

    ' Populate combo box with flavors from coffee_flavors.txt on form load
    Private Sub CoffeeApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create StreamReader within method
        Dim CoffeeFlavorStreamReader As StreamReader

        ' Create flag to prevent error message in Finally block from displaying
        ' when the application cannot find the coffee flavors text file and the
        ' user creates a new one
        Dim FlagBoolean As Boolean = False

        ' Try to read the coffee flavors text file and populate the combo box
        Try
            ' Instantiate the stream reader object
            CoffeeFlavorStreamReader = New StreamReader("coffee_flavors.txt", True)

            ' Loop through contents of file and add each line as an item in the combo box
            Do Until CoffeeFlavorStreamReader.EndOfStream
                ' Create a temporary string to hold the value of each line read from the file...
                Dim TempString As String = CoffeeFlavorStreamReader.ReadLine
                ' ...add that string to the combo box
                CoffeeFlavorComboBox.Items.Add(TempString)

                ' Redimension the array by one item...
                ReDim Preserve CoffeeFlavorsArray(CoffeeFlavorsArray.GetUpperBound(0) + 1)
                ' ...then copy the line read from the file into that new location
                CoffeeFlavorsArray(CoffeeFlavorsArray.GetUpperBound(0)) = TempString
            Loop
        Catch ex As IOException
            ' Here we prompt the user to create a file if there was an error opening
            ' the existing coffee_flavors.txt
            Dim FileCreateDialogResult As DialogResult

            ' Prompt user for dialog result
            FileCreateDialogResult = MessageBox.Show("Would you like to create a new file?",
                                                     "File Creation",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Question)

            ' If the selected OK...
            If FileCreateDialogResult <> DialogResult.Cancel Then
                ' Instantiate a new stream writer with default file name
                CoffeeStreamWriter = New StreamWriter("coffee_flavors.txt", True)

                ' Close the stream writer
                CloseStreamWriter()

                ' Set the flag to indicate a new file has been created
                ' and that there is no stream reader to close
                FlagBoolean = True
            ElseIf FileCreateDialogResult = DialogResult.Cancel Then
                ' If the user selects cancel, then the stream reader was never created, so
                ' we can't close it
                FlagBoolean = True
            End If
        Finally
            ' Check if flag has been set
            If FlagBoolean <> True Then
                ' Try to close the file
                Try
                    CoffeeFlavorStreamReader.Close()
                Catch ex As Exception
                    MessageBox.Show("There was an error closing the coffee flavors file",
                                    "File I/O Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                End Try
            End If
        End Try
    End Sub

    ' Here are dropdown menu methods

    Private Sub SaveFlavorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFlavorListToolStripMenuItem.Click
        ' Save the file
        SaveFile()
    End Sub

    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        ' Create flag for logic check
        Dim FlagBooleanA As Boolean = False
        Dim FlagBooleanB As Boolean = False

        ' Check that flavor is not blank
        If CoffeeFlavorComboBox.Text = "" Then
            MessageBox.Show("Please enter a flavor name to add to the list",
                            "User Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            ' Set the flag to indicate bad data was provided
            FlagBooleanA = True
        End If

        ' If flavor is not blank, then check to see if it already exists in the combo box
        If FlagBooleanA <> True Then
            For CounterInteger As Integer = 0 To (CoffeeFlavorComboBox.Items.Count - 1)
                If CoffeeFlavorComboBox.Items(CounterInteger).ToString = CoffeeFlavorComboBox.Text Then
                    ' If duplicate detected, then set the flag...
                    FlagBooleanB = True
                    ' ...and alert the User
                    MessageBox.Show("Please enter a unique flavor to add to the list",
                                    "Duplicate Flavor Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                End If
            Next
        End If

        ' If both flags are still false, then text was entered and a duplicate was not found 
        If FlagBooleanA <> True And FlagBooleanB <> True Then
            CoffeeFlavorComboBox.Items.Add(CoffeeFlavorComboBox.Text)
        End If

        ' Clear the text in the combo box
        ClearSelections()
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        ' Perform logic check, if something is selected then add it to
        ' the combo box's items list, otherwise nothing is selected
        ' and display a message to the User prompting them to select
        ' an item to remove
        If CoffeeFlavorComboBox.SelectedIndex <> -1 Then
            ' Remove the selected item from the combobox
            CoffeeFlavorComboBox.Items.RemoveAt(CoffeeFlavorComboBox.SelectedIndex)
        Else
            MessageBox.Show("Please select a coffee flavor to remove",
                            "Menu Selection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ClearCoffeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        ' Create dialog result
        Dim ClearListDialogResult As DialogResult

        ' Ask the User if they want to clear the list
        ClearListDialogResult = MessageBox.Show("Are you sure you want to clear the flavor list?",
                                                "Are you sure?",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Question)

        ' Check dialog result, if they selected OK, then clear the list
        If ClearListDialogResult <> DialogResult.Cancel Then
            ' Loop through entire combo box an remove the first item until
            ' all items have been removed
            For CounterInteger As Integer = 0 To (CoffeeFlavorComboBox.Items.Count - 1)
                CoffeeFlavorComboBox.Items.RemoveAt(0)
            Next

            ' Clear Selections
            ClearSelections()
        End If
    End Sub

    Private Sub DisplayCoffeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCoffeeCountToolStripMenuItem.Click
        ' Display a message to the User that details how many coffee flavors
        ' are in the combo box item's list
        Dim MessageString As String

        ' Format a string to include the current count of the coffee flavors
        ' combo box
        MessageString = String.Format("{0}{1}",
                                      "The number of coffee flavors listed is: ",
                                      CoffeeFlavorComboBox.Items.Count)

        ' Display formatted string to the User
        MessageBox.Show(MessageString,
                        "Coffee Flavor Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the about box
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Create flag
        Dim FlagBoolean As Boolean = False

        ' Check if array of items created at beginning of application load and the number
        ' of items in the combo box are not the same, if not, then skip straight
        ' to asking if they want to save
        If CoffeeFlavorsArray.GetUpperBound(0) = CoffeeFlavorComboBox.Items.Count Then
            ' Loop through the arrays and check each value, if a mismatch is detected,
            ' set the flag and break out of the loop
            For CounterInteger As Integer = 0 To (CoffeeFlavorsArray.GetUpperBound(0))
                If CoffeeFlavorsArray(CounterInteger) <> CoffeeFlavorComboBox.Items(CounterInteger).ToString Then
                    ' Set the flag
                    FlagBoolean = True
                    ' Exit the loop
                    Exit For
                End If
            Next

            ' Check if flag was set
            If FlagBoolean = True Then
                PromptSaveDialog()
            End If
        ElseIf CoffeeFlavorsArray.GetUpperBound(0) <> CoffeeFlavorComboBox.Items.Count Then
            ' If the count and upper bound (I don't know where the extra array item is coming from)
            ' do not match, automatically prompt User with save dialog
            PromptSaveDialog()
        End If

        Me.Close()
    End Sub

    ' Here are button methods

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        ' Create string variable to hold formatted string
        Dim CoffeeString As String

        ' Logic to display what was selected to the user
        If CoffeeFlavorComboBox.SelectedIndex <> -1 And CoffeeSyrupListBox.SelectedIndex <> -1 Then
            ' 1. If the selected a flavor and a syrup, display this message
            CoffeeString = String.Format("{0}{1}{2}{3}{4}",
                                         "You selected ",
                                         CoffeeFlavorComboBox.Items(CoffeeFlavorComboBox.SelectedIndex).ToString,
                                         " coffee flavoring with ",
                                         CoffeeSyrupListBox.Items(CoffeeSyrupListBox.SelectedIndex).ToString,
                                         " syrup.")
            MessageBox.Show(CoffeeString,
                            "Coffee Purchase Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        ElseIf CoffeeFlavorComboBox.SelectedIndex = -1 Then
            ' 2. If they did not select a flavor, prompt the user to select a flavor
            MessageBox.Show("Please select a coffee flavor from the drop down menu",
                            "Coffee Flavor Selection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        ElseIf CoffeeFlavorComboBox.SelectedIndex <> -1 And CoffeeSyrupListBox.SelectedIndex = -1 Then
            ' 3. If they just selected a flavor, display the custom message
            CoffeeString = String.Format("{0}{1}{2}",
                                         "You selected ",
                                         CoffeeFlavorComboBox.Items(CoffeeFlavorComboBox.SelectedIndex).ToString,
                                         " coffee flavoring with no syrup.")
            MessageBox.Show(CoffeeString,
                            "Coffee Purchase Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

        ' Clear selections
        ClearSelections()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear selections
        ClearSelections()
    End Sub

    ' Custom methods
    Private Sub ClearSelections()
        ' Clear selections
        CoffeeFlavorComboBox.Text = ""
        CoffeeSyrupListBox.SelectedIndex = -1
    End Sub

    ' Used in several method calls
    Private Sub CloseStreamWriter()
        ' Close the file
        If CoffeeStreamWriter IsNot Nothing Then
            ' Try to close the file if CoffeeStreamWriter is something
            Try
                ' Close the streamwriter
                CoffeeStreamWriter.Close()
            Catch ex As IOException
                MessageBox.Show("Error closing the file",
                                "File I/O Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    ' Used in several method calls
    Private Sub SaveFile()
        ' Try to write to the file
        Try
            ' Instantiate a  new stream writer object with the coffee_flavors.txt file,
            ' Option: False indicates that the writer will overwrite, not append to the file
            CoffeeStreamWriter = New StreamWriter("coffee_flavors.txt", False)

            ' Reset the combo box index to -1 to clear the combo box's selected item
            CoffeeFlavorComboBox.SelectedIndex = -1

            ' Loop through combo box and write each item to the file as its own line
            For CounterInteger As Integer = 0 To (CoffeeFlavorComboBox.Items.Count - 1)
                CoffeeStreamWriter.WriteLine(CoffeeFlavorComboBox.Items(CounterInteger))
            Next

            ' Close the stream writer
            CloseStreamWriter()
        Catch ex As IOException
            MessageBox.Show("There was an error writing to the file",
                            "File I/O Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' Used on application exit in two different logic branches
    Private Sub PromptSaveDialog()
        Dim FileCreateDialogResult As DialogResult

        FileCreateDialogResult = MessageBox.Show("Would you like to save your changes?",
                                                 "File Save",
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Question)

        If FileCreateDialogResult <> DialogResult.Cancel Then
            ' Save the file
            SaveFile()
        End If
    End Sub
End Class
