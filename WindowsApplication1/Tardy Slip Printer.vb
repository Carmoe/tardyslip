Imports System.Net
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel

Public Class Form1
    Dim dt As New DataTable
    Dim dtview As New DataGridView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Choose a Printer")
        ChoosePrinter.Select()
        PeriodBox.Enabled = False
        CodeBox.Enabled = False
        IDBox.Enabled = False
        SchoolNum.Text = My.Settings.school

        dtview.DataSource = dt
        dtview.AutoResizeColumns()
        dtview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtview.BorderStyle = BorderStyle.Fixed3D
        dtview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtview.ReadOnly = True

        dt.Columns.Add("PermID", GetType(String))
        dt.Columns.Add("LastName", GetType(String))
        dt.Columns.Add("FirstName", GetType(String))
        dt.Columns.Add("Period", GetType(String))
        dt.Columns.Add("AbsenceCode", GetType(String))
        dt.Columns.Add("Date", GetType(String))
        dt.Columns.Add("Time", GetType(String))

    End Sub
    Private Sub PeriodBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles PeriodBox.SelectedValueChanged
        CodeBox.Enabled = True
        CodeBox.Select()
    End Sub
    Private Sub CodeBox_TextChanged(sender As Object, e As EventArgs) Handles CodeBox.TextChanged
        IDBox.Enabled = True
        IDBox.Select()
    End Sub
    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click

        Dim stu As String = Me.Controls("IDBox").Text
        Dim stuNum As Integer = CInt(stu)
        Dim stuClear As String = ""
        Dim d As String = DateTime.Now.ToString()
        Dim AttPer As String = Me.Controls("PeriodBox").Text
        Dim Code As String = Me.Controls("CodeBox").Text
        GetStuInfo(stu, AttPer, Code, d)
        '   getPic(stu)
        ' PrintDocument1.Print()
        IDBox.Text = stuClear
    End Sub
    Public Function GetStuInfo(ByVal stu As String, ByRef AttPer As String, ByRef Code As String, ByRef d As String) As String
        Try
            'Dim cert As String = My.Settings.cert
            'Dim school As String = My.Settings.school
            Dim cookieJar As New CookieContainer()
            Dim url As String = "https://" & My.Settings.url & "/api/v3/schools/" & My.Settings.school & "/students/" & stu
            Dim hwrequest As HttpWebRequest = Net.WebRequest.Create(url)


            hwrequest.PreAuthenticate = True
            'hwrequest.Headers.Add("AERIES-CERT", "fe308b8f5d42404784008209076f515b")
            hwrequest.Headers.Add("AERIES-CERT", My.Settings.cert)
            hwrequest.CookieContainer = cookieJar
            hwrequest.Accept = "text/xml,*/*"
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = "GET"


            Dim hwresponse As HttpWebResponse = hwrequest.GetResponse()

            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then

                Dim s As System.IO.Stream = hwresponse.GetResponseStream()

                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(s)

                Dim responseText As String = sr.ReadToEnd()

                Dim xmlDoc As New XmlDocument()

                xmlDoc.LoadXml(responseText)
                Dim output As StringBuilder = New StringBuilder()
                Dim school As String = "Fallbrook Union High School"
                Dim title As String = "READMIT SLIP"
                Dim LName As String
                Dim FName As String
                Dim attDate As String = Today.ToShortDateString
                Dim attTime As String = TimeOfDay.ToShortTimeString

                Using reader As XmlReader = XmlReader.Create(New StringReader(responseText))
                    Dim ws As XmlWriterSettings = New XmlWriterSettings()
                    ws.Indent = True
                    Using writer As XmlWriter = XmlWriter.Create(output, ws)

                        output.AppendLine(school)
                        output.AppendLine("")
                        'output.AppendLine(title)
                        output.AppendLine(d)
                        output.AppendLine("")
                        reader.ReadToFollowing("FirstName")
                        FName = reader.ReadElementContentAsString
                        reader.ReadToFollowing("Grade")
                        Dim gr As String = reader.ReadElementContentAsString
                        reader.ReadToFollowing("LastName")
                        LName = reader.ReadElementContentAsString
                        output.AppendLine("Student Name: " + Fname + " " + Lname)
                        output.AppendLine("Grade: " + gr)
                        reader.ReadToFollowing("PermanentID")
                        Dim ID As String = reader.ReadElementContentAsString
                        output.AppendLine("Student ID: " + ID)


                    End Using
                End Using

                Me.Response.Text = output.ToString()
                Me.Response.AppendText(vbCrLf & "Absence Code: " + Code)
                Me.Response.AppendText(vbCrLf & "Period   Room   Teacher")

                GetClass(stu, AttPer, Code)
                hwresponse.Close()

                dt.Rows.Add(stu, LName, FName, AttPer, Code, attDate, attTime)
            End If

        Catch ex As Exception
            MsgBox("Student not found. Check your school code and make sure you're using the PERM ID")
            Exit Function
            Return False

        End Try



    End Function

    Public Function GetClass(ByRef stu As String, ByRef AttPer As String, ByRef Code As String) As String
        Try

            Dim per As String
            Dim sec As String
            Dim Edate As Date
            Dim Tday As Date = Today
            'Dim cert As String = My.Settings.cert
            'Dim school As String = My.Settings.school

            Dim cookieJar As New Net.CookieContainer()
            Dim url As String = "https://" & My.Settings.url & "/api/schools/" & My.Settings.school & "/classes/" & stu

            Dim hwrequest As HttpWebRequest = Net.WebRequest.Create(url)
            Dim output As StringBuilder = New StringBuilder()
            hwrequest.PreAuthenticate = True
            'hwrequest.Headers.Add("AERIES-CERT", "fe308b8f5d42404784008209076f515b")
            hwrequest.Headers.Add("AERIES-CERT", My.Settings.cert)
            hwrequest.CookieContainer = cookieJar
            hwrequest.Accept = "text/xml,*/*"
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = "GET"

            Dim hwresponse As HttpWebResponse = hwrequest.GetResponse()

            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then

                Dim s As System.IO.Stream = hwresponse.GetResponseStream()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(s)
                Dim responseText As String = sr.ReadToEnd()
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml(responseText)


                Using reader As XmlReader = XmlReader.Create(New StringReader(responseText))

                    Dim ws As XmlWriterSettings = New XmlWriterSettings()
                    ws.Indent = True
                    Using writer As XmlWriter = XmlWriter.Create(output, ws)

                        For i As Integer = 1 To 20
                            reader.ReadToFollowing("DateEnded")
                            Edate = reader.ReadElementContentAsDateTime()

                            reader.ReadToFollowing("Period")
                            per = reader.ReadElementContentAsString()

                            reader.ReadToFollowing("SectionNumber")
                            sec = reader.ReadElementContentAsString

                            If per = AttPer And Edate > Tday Then
                                Me.Response.AppendText(vbCrLf & "  " + per)
                                GetRoom(sec, Code, stu)
                                Exit For
                            End If
                        Next

                    End Using
                End Using


                hwresponse.Close()

            End If

        Catch ex As Exception
            MsgBox("Student has no classes")
            Exit Function
            Return False
        End Try

    End Function

    Public Function GetRoom(ByRef sec As String, ByRef Code As String, ByVal stu As String)
        Try
            Dim Room As String
            Dim tch As String
            'Dim cert As String = My.Settings.cert
            'Dim school As String = My.Settings.school
            Dim cookieJar As New Net.CookieContainer()
            Dim url As String = "https://" & My.Settings.url & "/api/v3/schools/" & My.Settings.school & "/sections/" & sec
            Dim hwrequest As HttpWebRequest = Net.WebRequest.Create(url)

            hwrequest.PreAuthenticate = True
            'hwrequest.Headers.Add("AERIES-CERT", "fe308b8f5d42404784008209076f515b")
            hwrequest.Headers.Add("AERIES-CERT", My.Settings.cert)
            hwrequest.CookieContainer = cookieJar
            hwrequest.Accept = "text/xml,*/*"
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = "GET"


            Dim hwresponse As HttpWebResponse = hwrequest.GetResponse()

            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then


                Dim s As System.IO.Stream = hwresponse.GetResponseStream()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(s)
                Dim responseText As String = sr.ReadToEnd()

                Dim xmlDoc As New XmlDocument()

                xmlDoc.LoadXml(responseText)
                Dim output As StringBuilder = New StringBuilder()

                Using reader As XmlReader = XmlReader.Create(New StringReader(responseText))
                    Dim ws As XmlWriterSettings = New XmlWriterSettings()
                    ws.Indent = True
                    Using writer As XmlWriter = XmlWriter.Create(output, ws)
                        'Using reader
                        reader.ReadToFollowing("Room")
                        Room = reader.ReadElementContentAsString()
                        reader.ReadToFollowing("TeacherNumber1")
                        tch = reader.ReadElementContentAsString()
                        Me.Response.AppendText("         " + Room)

                    End Using
                End Using
                GetTeach(tch, Code, stu)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function GetTeach(ByRef tch As String, ByRef Code As String, ByVal stu As String)
        Try
            Dim Tname As String
            Dim cert As String = My.Settings.cert
            'Dim school As String = My.Settings.school
            Dim cookieJar As New Net.CookieContainer()
            Dim url As String = "https://" & My.Settings.url & "/api/schools/" & My.Settings.school & "/teachers/" & tch
            Dim hwrequest As HttpWebRequest = Net.WebRequest.Create(url)

            hwrequest.PreAuthenticate = True
            'hwrequest.Headers.Add("AERIES-CERT", "fe308b8f5d42404784008209076f515b")
            hwrequest.Headers.Add("AERIES-CERT", My.Settings.cert)
            hwrequest.CookieContainer = cookieJar
            hwrequest.Accept = "text/xml,*/*"
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = "GET"


            Dim hwresponse As HttpWebResponse = hwrequest.GetResponse()

            If hwresponse.StatusCode = Net.HttpStatusCode.OK Then



                Dim s As System.IO.Stream = hwresponse.GetResponseStream()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(s)
                Dim responseText As String = sr.ReadToEnd()

                Dim xmlDoc As New XmlDocument()

                xmlDoc.LoadXml(responseText)
                Dim output As StringBuilder = New StringBuilder()

                Using reader As XmlReader = XmlReader.Create(New StringReader(responseText))
                    Dim ws As XmlWriterSettings = New XmlWriterSettings()
                    ws.Indent = True
                    Using writer As XmlWriter = XmlWriter.Create(output, ws)
                        'Using reader
                        reader.ReadToFollowing("DisplayName")
                        Dim tchname As String = reader.ReadElementContentAsString()
                        Dim newName As Array = tchname.Split(" ")
                        Dim TchFn As String = newName(1)
                        Dim TchLn As String = newName(0)
                        Tname = TchFn + " " + TchLn
                        Me.Response.AppendText("      " + Tname)
                    End Using
                End Using

            End If
            getPic(stu)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function
    Public Function getPic(ByRef stu As String) As Image
        Try
            'Dim cert As String = My.Settings.cert
            'Dim school As String = My.Settings.school
            Dim url As String = "https://" & My.Settings.url & "/api/v3/schools/" & My.Settings.school & "/StudentPictures/" & stu
            Dim hwrequest As HttpWebRequest = Net.WebRequest.Create(url)
            hwrequest.PreAuthenticate = True
            'hwrequest.Headers.Add("AERIES-CERT", "fe308b8f5d42404784008209076f515b")
            hwrequest.Headers.Add("AERIES-CERT", My.Settings.cert)
            hwrequest.AllowAutoRedirect = True
            hwrequest.UserAgent = "http_requester/0.1"
            hwrequest.Timeout = 60000
            hwrequest.Method = "Get"

            Dim response As WebResponse = hwrequest.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim jsonResponse As String = reader.ReadToEnd()

            Dim nstring As String = jsonResponse.Trim("[", "]")
            Dim jo As JObject = JObject.Parse(nstring)
            Dim pic = jo("Pictures")(0)("RawBinary")

            Using memStream As New MemoryStream(Convert.FromBase64String(pic))
                Dim img As Image = Image.FromStream(memStream)
                Me.StuPic.Image = img
            End Using

            PrintDocument1().Print()

        Catch ex As Exception
            MsgBox("No picture!")
            PrintDocument1().Print()
        End Try

    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim rect1 As New Rectangle(10, 125, 250, 225)
        If StuPic.Image Is Nothing Then
            e.Graphics.DrawString(Response.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, rect1)
        Else
            e.Graphics.DrawImage(Me.StuPic.Image, 10, 10, 80, 100)
            e.Graphics.DrawString(Response.Text, New Font("Arial", 11, FontStyle.Regular), Brushes.Black, rect1)
            e.HasMorePages = False
        End If
    End Sub
    Private Sub SaveData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
        Try
            SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv | Text Files (*.txt) | *.txt "
            SaveFileDialog1.ShowDialog()


            Dim filePath As String = SaveFileDialog1.FileName
            Dim delimiter As String = ","
            Dim sb As New StringBuilder
            For i As Integer = 0 To dtview.Rows.Count - 1
                Dim array As String() = New String(dtview.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dtview.Columns.Count - 1
                        array(j) = dtview.Columns(j).HeaderText
                    Next
                    sb.AppendLine(String.Join(delimiter, array))
                End If
                For j As Integer = 0 To dtview.Columns.Count - 1
                    If Not dtview.Rows(i).IsNewRow Then
                        array(j) = dtview(j, i).Value.ToString
                    End If
                Next
                If Not dtview.Rows(i).IsNewRow Then
                    sb.AppendLine(String.Join(delimiter, array))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString)
            'Opens the file immediately after writing
            ' Process.Start(filePath)

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    'Private Sub PrntData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
    ' PrintDocument2.Print()

    ' End Sub

    ' Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
    'Dim bm As New Bitmap(Me.dtview.Width, Me.dtview.Height)
    '   dtview.DrawToBitmap(bm, New Rectangle(0, 0, Me.dtview.Width, Me.dtview.Height))
    '   e.Graphics.DrawImage(bm, 0, 0)
    '  End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChoosePrinter.Click
        Form2.Show()
        PeriodBox.Enabled = True
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Printer = " "
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Certificate_Key.Show()
    End Sub

    Private Sub SchoolNum_TextChanged(sender As Object, e As EventArgs) Handles SchoolNum.TextChanged
        My.Settings.school = Me.SchoolNum.Text
    End Sub

End Class

