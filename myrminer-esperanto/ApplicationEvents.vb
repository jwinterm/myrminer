Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown

        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If My.Computer.FileSystem.FileExists("myrminer.conf") Then
                Try
                    ' Open the file using a stream reader.
                    Using sr As New StreamReader("myrminer.conf")
                        Dim line As String
                        ' Read the stream to a string and write the string to the console.
                        line = sr.ReadToEnd()
                        Form1.TextBoxPoolAddress.Text = line.Split(New Char() {"=", vbCrLf})(1)
                        Form1.TextBoxMyrAddress.Text = line.Split(New Char() {"=", vbCrLf})(3)
                        Form1.TextBoxThreads.Text = line.Split(New Char() {"=", vbCrLf})(5)
                        Console.WriteLine(line)
                    End Using
                Catch e1 As Exception
                    Console.WriteLine("The file could not be read:")
                    Console.WriteLine(e1.Message)
                End Try

            Else
                MsgBox("Ŝajnas ke vi unuafoje uzas myrminilon (aŭ vi forigis vian dosieron myrminer.conf). Nepre agordu vian propran Myriadan adreson. Post kiam vi unufoje uzis myrminilon, aŭtomate kreiĝos dosiero myrminer.conf kiu savos vian ministaron, adreson, kaj nombron de fadenoj; vi ankaŭ povas forviŝi ajnatempe la dosieron por reiri al la originalaj agordecoj.")
            End If
        End Sub
    End Class
End Namespace
