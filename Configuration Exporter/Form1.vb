Imports SolidWorks.Interop.sldworks

Public Class Form1

    Dim swApp As SolidWorks.Interop.sldworks.SldWorks = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"))
    Dim swDraw As DrawingDoc
    Dim SWSheet As SolidWorks.Interop.sldworks.Sheet
    Dim swDoc As ModelDoc2

    Dim fileerror As Integer
    Dim filewarning As Integer
    Dim config As Configuration
    Dim CusProperties As CustomPropertyManager
    Dim swModelDocExt As ModelDocExtension
    Dim Ofso As New Scripting.FileSystemObject
    Dim StopExporting As Boolean = False

    'Forms and New Windows
    Dim Generic_Error As New Error_Message


    Private Sub SaveAsNewFiletypeClick(sender As Object, e As EventArgs) Handles SaveAs.Click

        Dim swApp As SldWorks = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"))
        swDoc = swApp.ActiveDoc

        Dim config_numbers As Integer
        Dim Config_Array As Array

        Dim Original_Model_NO_Extension As String
        Dim Filename As String
        Dim Export_Extension As String

        Dim Open_Config As Boolean
        Dim SaveAsNew As Boolean = False


        If swDoc Is Nothing Then
            'use the following to pass an error message to the Error Message Form
            'Generic_Error.PassedText = "Hello"
            Generic_Error.StartPosition = FormStartPosition.CenterParent
            Generic_Error.ShowDialog()
            Form1_Load(sender, e)
        Else

            Dim Original_Model = String.Empty
            Dim Original_Path = String.Empty
            Original_Model = swDoc.GetPathName()

            swDoc.ClearSelection2(True)

            config = swDoc.GetActiveConfiguration
            config_numbers = swDoc.GetConfigurationCount()
            Config_Array = swDoc.GetConfigurationNames

            For i = 0 To config_numbers - 1

                Open_Config = swDoc.ShowConfiguration2(Config_Array(i))

                Filename = SW_FileName(Original_Model)
                Original_Model_NO_Extension = SW_FilePath(Original_Model)


                Select Case Export_File_Type.SelectedIndex
                    Case 0
                        Export_Extension = ".sldprt"
                        For j = 0 To config_numbers - 1

                            'Debug.Print(Config_Array(i)) 'active config
                            'Debug.Print(Config_Array(j)) 'matching config

                            If Config_Array(i) <> Config_Array(j) Then 'if active config doesn't match matching config delete matching config
                                swDoc.DeleteConfiguration2(Config_Array(j))
                                SaveAsNew = True
                            End If
                        Next

                    Case 1
                        Export_Extension = ".igs"

                    Case 2
                        Export_Extension = ".step"

                    Case 3
                        Export_Extension = ".eprt"

                    Case 4
                        Export_Extension = ".dxf"

                    Case 5
                        Export_Extension = ".dwg"

                    Case 6
                        Export_Extension = ".stl"

                    Case 7
                        Export_Extension = ".jpg"

                    Case 8
                        Export_Extension = ".pdf"

                    Case Else
                        Generic_Error.StartPosition = FormStartPosition.CenterParent
                        Generic_Error.PassedText = "File type not supported."
                        Generic_Error.ShowDialog()
                        Form1_Load(sender, e)
                        Exit Sub
                End Select

                swDoc.SaveAs(Original_Model_NO_Extension + Filename + " - " + Config_Array(i) + Export_Extension)

                If SaveAsNew Then
                    swApp.QuitDoc(swDoc.GetTitle)
                    swDoc = swApp.OpenDoc6(Original_Model, 1, 0, "", fileerror, filewarning)
                End If

            Next
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveAsPartWarning.Visible = False
        Export_File_Type.Text = "Export File Type..."
    End Sub

    Shared Function SW_Extension(path As String, Optional ByVal Remove_Period As Boolean = False)
        Dim Extension As String = path

        Extension = Extension.Remove(0, Extension.LastIndexOf("."))

        If Remove_Period Then
            Extension = Extension.Substring(Extension.IndexOf(".") + 1)
        End If

        Return Extension
    End Function

    Shared Function SW_FileName(path As String)
        Dim FileName As String = path

        FileName = FileName.Remove(0, FileName.LastIndexOf("\") + 1)
        FileName = FileName.Remove(FileName.LastIndexOf("."))

        Return FileName
    End Function

    Shared Function SW_FilePath(path As String)
        Dim FileName As String = path

        FileName = FileName.Remove(FileName.LastIndexOf("\") + 1)

        Return FileName
    End Function

    Private Sub Export_File_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Export_File_Type.SelectedIndexChanged
        If Export_File_Type.SelectedIndex = 0 Then
            SaveAsPartWarning.Text = "If you are saving as part files this may take time"
            SaveAsPartWarning.Visible = True
        Else
            SaveAsPartWarning.Visible = False
        End If
    End Sub


End Class
