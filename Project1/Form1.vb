﻿Imports Microsoft.VisualBasic

Public Class Form1
    Dim ob As New data
    Dim query As String

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showdata()
        showdata2()
    End Sub

    Sub showdata()
        query = "select * from Sales"
        DataGridView1.DataSource = ob.getdata(query)
    End Sub

    Sub showdata2()
        query = "select * from HoD"
        DataGridView2.DataSource = ob.getdata(query)
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> "/" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = Month(Format(Date.Now())) + Year(Format(Date.Now())) + Day(Format(Date.Now())) * Second(Format(Date.Now())) + 13 * (4 + Second(Format(Date.Now()))) * 324 + Hour(Format(Date.Now())) * Minute(Format(Date.Now())) * Month(Format(Date.Now())) * Year(Format(Date.Now()))
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.Text = 0
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            TextBox5.Text = 0
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            TextBox6.Text = 0
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then
            TextBox7.Text = 0
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            TextBox8.Text = 0
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then
            TextBox9.Text = 0
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "" Then
            TextBox10.Text = 0
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If TextBox11.Text = "" Then
            TextBox11.Text = 0
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If TextBox12.Text = "" Then
            TextBox12.Text = 0
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If TextBox13.Text = "" Then
            TextBox13.Text = 0
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        If TextBox14.Text = "" Then
            TextBox14.Text = 0
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If TextBox15.Text = "" Then
            TextBox15.Text = 0
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        If TextBox16.Text = "" Then
            TextBox16.Text = 0
        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If TextBox17.Text = "" Then
            TextBox17.Text = 0
        End If
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        If TextBox18.Text = "" Then
            TextBox18.Text = 0
        End If
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        If TextBox19.Text = "" Then
            TextBox19.Text = "N/A"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox2.Text = "N/A"
        End If
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        If TextBox20.Text = "" Then
            TextBox20.Text = "N/A"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = "N/A"
        TextBox20.Text = "N/A"
        TextBox2.Text = "N/A"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox26.Text = ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) + ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05)
        TextBox45.Text = DateTimePicker1.Text

        RichTextBox1.Text = vbCrLf &
                            " ---------------------------------------------- Zahid Group -----------------------------------------------" & vbCrLf & vbCrLf &
                             DateTimePicker1.Text & vbCrLf & vbCrLf &
                            " Order Number:   " & TextBox1.Text & vbCrLf &
                            " Customer Name:  " & TextBox2.Text & vbCrLf &
                            " Phone Number:   " & TextBox19.Text & vbCrLf &
                            " Customer Email: " & TextBox20.Text & vbCrLf &
                            "________________________________________________________" & vbCrLf & vbCrLf &
                            "    ITEM                PRICE                  WEEKS                    TOTAL   " &
                            "________________________________________________________" & vbCrLf & vbCrLf

        If TextBox3.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox3.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    JD5085          " + "900 SAR                   " & TextBox3.Text + 0 & "                        " & TextBox3.Text * 900 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox4.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox4.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    JD244I           " + "750 SAR                   " & TextBox4.Text + 0 & "                        " & TextBox4.Text * 750 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox5.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox5.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    JD5086          " + "950 SAR                   " & TextBox5.Text + 0 & "                        " & TextBox5.Text * 950 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox6.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox6.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    L5740            " + "920 SAR                   " & TextBox6.Text + 0 & "                        " & TextBox6.Text * 920 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox7.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox7.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    FTX128L       " + "600 SAR                   " & TextBox7.Text + 0 & "                        " & TextBox7.Text * 600 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox8.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox8.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    RTF230         " + "450 SAR                    " & TextBox8.Text + 0 & "                        " & TextBox8.Text * 450 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox9.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox9.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    575DI             " + "650 SAR                   " & TextBox9.Text + 0 & "                        " & TextBox9.Text * 650 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox17.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox17.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    785L7            " + "1700 SAR                  " & TextBox17.Text + 0 & "                        " & TextBox17.Text * 1700 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox18.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox18.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    HD325           " + "1350 SAR                  " & TextBox18.Text + 0 & "                        " & TextBox18.Text * 1350 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox10.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox10.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    WB935           " + "600 SAR                   " & TextBox10.Text + 0 & "                        " & TextBox10.Text * 600 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox11.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox11.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    M5111            " + "700 SAR                   " & TextBox11.Text + 0 & "                        " & TextBox11.Text * 700 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox12.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox12.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    5065E             " + "730 SAR                   " & TextBox12.Text + 0 & "                        " & TextBox12.Text * 730 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox13.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox13.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    L45                 " + "550 SAR                   " & TextBox13.Text + 0 & "                        " & TextBox13.Text * 550 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox14.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox14.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    210LEP          " + "940 SAR                   " & TextBox14.Text + 0 & "                        " & TextBox14.Text * 940 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox15.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox15.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    210L               " + "850 SAR                   " & TextBox15.Text + 0 & "                        " & TextBox15.Text * 850 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        If TextBox16.Text = 0 Then
            RichTextBox1.Text = RichTextBox1.Text + ""
        ElseIf TextBox16.Text > 0 Then
            RichTextBox1.Text = RichTextBox1.Text + "    710K              " + "800 SAR                   " & TextBox16.Text + 0 & "                        " & TextBox16.Text * 800 & " SAR" & vbCrLf & "    ---------------------------------------------------------------------------------------------------------" & vbCrLf
        End If

        RichTextBox1.Text = RichTextBox1.Text + vbCrLf & "                                                  SUBTOTAL                  " & (TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800) & " SAR" & vbCrLf &
                                                         "                                                  VAT                              " & ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05) & " SAR" & vbCrLf & vbCrLf &
                                                         "                                                  TOTAL AMOUNT         " & ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) + ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05) & " SAR" & vbCrLf & "________________________________________________________" & vbCrLf & vbCrLf

        Button3.Visible = True
        Button25.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        query = String.Format("insert into sales(orderNO,orderd,customername,CustomerEmail,JD5085,JD244I,JD5086,L5740,FTX128L,RTF230,575DI,785L7,HD325,WB935,M5111,5065E,L45,210LEP,210L,710K,customerpn,ordertotal) values('" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox2.Text & "','" & TextBox20.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox19.Text & "','" & TextBox26.Text & "')")
        ob.RunQuery(query)
        query = "select * from sales "
        DataGridView1.DataSource = ob.getdata(query)

        TextBox43.Text = Val(TextBox43.Text) + Val(TextBox3.Text)
        TextBox42.Text = Val(TextBox42.Text) + Val(TextBox4.Text)
        TextBox41.Text = Val(TextBox41.Text) + Val(TextBox5.Text)
        TextBox40.Text = Val(TextBox40.Text) + Val(TextBox6.Text)
        TextBox39.Text = Val(TextBox39.Text) + Val(TextBox7.Text)
        TextBox38.Text = Val(TextBox38.Text) + Val(TextBox8.Text)
        TextBox37.Text = Val(TextBox37.Text) + Val(TextBox9.Text)
        TextBox36.Text = Val(TextBox36.Text) + Val(TextBox17.Text)
        TextBox35.Text = Val(TextBox35.Text) + Val(TextBox18.Text)
        TextBox34.Text = Val(TextBox34.Text) + Val(TextBox10.Text)
        TextBox33.Text = Val(TextBox33.Text) + Val(TextBox11.Text)
        TextBox32.Text = Val(TextBox32.Text) + Val(TextBox12.Text)
        TextBox31.Text = Val(TextBox31.Text) + Val(TextBox13.Text)
        TextBox30.Text = Val(TextBox30.Text) + Val(TextBox14.Text)
        TextBox29.Text = Val(TextBox29.Text) + Val(TextBox15.Text)
        TextBox28.Text = Val(TextBox28.Text) + Val(TextBox16.Text)

        RichTextBox2.Text = RichTextBox2.Text + RichTextBox1.Text
        RichTextBox1.Text = ""
        TextBox1.Text = Month(Format(Date.Now())) + Year(Format(Date.Now())) + Day(Format(Date.Now())) * Second(Format(Date.Now())) + 13 * (4 + Second(Format(Date.Now()))) * 324 + Hour(Format(Date.Now())) * Minute(Format(Date.Now())) * Month(Format(Date.Now())) * Year(Format(Date.Now()))
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = "N/A"
        TextBox20.Text = "N/A"
        TextBox2.Text = "N/A"
        Button3.Visible = False
        Button25.Visible = True

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HoDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub Button6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Text = TimeOfDay
    End Sub

    Private Sub Button6_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_3(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub



    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox38_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub TextBox37_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox21_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub Button6_Click_4(sender As Object, e As EventArgs) Handles Button6.Click

        If RadioButton1.Checked = True Then
            query = "SELECT * from sales where orderd Between #" & DateTimePicker4.Text & "# And #" & DateTimePicker5.Text & "#"
        ElseIf RadioButton2.Checked = True Then
            query = "select * from Sales where orderno=" & TextBox25.Text & ""
        ElseIf RadioButton3.Checked = True Then
            query = "select * from Sales where customername='" & Trim(TextBox24.Text) & "'"
        ElseIf RadioButton4.Checked = True Then
            query = "select * from Sales where customerpn='" & Trim(TextBox23.Text) & "'"
        End If

        DataGridView1.DataSource = ob.getdata(query)

        Button8.Visible = True
        Button9.Visible = True

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        query = "select * from Sales"
        DataGridView1.DataSource = ob.getdata(query)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        query = String.Format("insert into hod(recordno,recordd,JD5085,JD244I,JD5086,L5740,FTX128L,RTF230,575DI,785L7,HD325,WB935,M5111,5065E,L45,210LEP,210L,710K) values('" & TextBox44.Text & "','" & TextBox45.Text & "','" & TextBox43.Text & "','" & TextBox42.Text & "','" & TextBox41.Text & "','" & TextBox40.Text & "','" & TextBox39.Text & "','" & TextBox38.Text & "','" & TextBox37.Text & "','" & TextBox36.Text & "','" & TextBox35.Text & "','" & TextBox34.Text & "','" & TextBox33.Text & "','" & TextBox32.Text & "','" & TextBox31.Text & "','" & TextBox30.Text & "','" & TextBox29.Text & "','" & TextBox28.Text & "')")
        ob.RunQuery(query)
        query = "select * from HoD "
        DataGridView2.DataSource = ob.getdata(query)

        TextBox43.Text = 0
        TextBox42.Text = 0
        TextBox41.Text = 0
        TextBox40.Text = 0
        TextBox39.Text = 0
        TextBox38.Text = 0
        TextBox37.Text = 0
        TextBox36.Text = 0
        TextBox35.Text = 0
        TextBox34.Text = 0
        TextBox33.Text = 0
        TextBox32.Text = 0
        TextBox31.Text = 0
        TextBox30.Text = 0
        TextBox29.Text = 0
        TextBox28.Text = 0
        TextBox44.Text = Year(Format(Date.Now())) + Year(Format(Date.Now())) + Day(Format(Date.Now())) * Second(Format(Date.Now())) + 3 * (9 + Second(Format(Date.Now()))) * 355 + Hour(Format(Date.Now())) * Second(Format(Date.Now())) * Day(Format(Date.Now())) * Year(Format(Date.Now()))

        RichTextBox2.Text = ""

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        GroupBox16.Visible = False
        Button10.Visible = True
        Button11.Visible = True
        GroupBox13.Visible = True
        GroupBox7.Enabled = False
        Button7.Enabled = False
        Button6.Enabled = False

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        GroupBox13.Visible = False
        GroupBox7.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True

    End Sub

    '    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try

            TextBox64.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox63.Text = DataGridView1.CurrentRow.Cells(1).Value
            TextBox46.Text = DataGridView1.CurrentRow.Cells(2).Value
            TextBox22.Text = DataGridView1.CurrentRow.Cells(3).Value
            TextBox65.Text = DataGridView1.CurrentRow.Cells(4).Value
            TextBox53.Text = DataGridView1.CurrentRow.Cells(5).Value
            TextBox52.Text = DataGridView1.CurrentRow.Cells(6).Value
            TextBox51.Text = DataGridView1.CurrentRow.Cells(7).Value
            TextBox50.Text = DataGridView1.CurrentRow.Cells(8).Value
            TextBox49.Text = DataGridView1.CurrentRow.Cells(9).Value
            TextBox48.Text = DataGridView1.CurrentRow.Cells(10).Value
            TextBox47.Text = DataGridView1.CurrentRow.Cells(11).Value
            TextBox54.Text = DataGridView1.CurrentRow.Cells(12).Value
            TextBox55.Text = DataGridView1.CurrentRow.Cells(13).Value
            TextBox62.Text = DataGridView1.CurrentRow.Cells(14).Value
            TextBox61.Text = DataGridView1.CurrentRow.Cells(15).Value
            TextBox60.Text = DataGridView1.CurrentRow.Cells(16).Value
            TextBox59.Text = DataGridView1.CurrentRow.Cells(17).Value
            TextBox58.Text = DataGridView1.CurrentRow.Cells(18).Value
            TextBox57.Text = DataGridView1.CurrentRow.Cells(19).Value
            TextBox56.Text = DataGridView1.CurrentRow.Cells(20).Value
            TextBox27.Text = ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) + ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox27.Text = (TextBox53.Text * 60) + (TextBox52.Text * 15) + (TextBox51.Text * 5) + (TextBox50.Text * 7) + (TextBox49.Text * 4) + (TextBox48.Text * 6) + (TextBox47.Text * 5) + (TextBox54.Text * 1) + (TextBox55.Text * 3) + (TextBox62.Text * 3) + (TextBox61.Text * 5) + (TextBox60.Text * 4) + (TextBox59.Text * 6) + (TextBox58.Text * 5) + (TextBox57.Text * 6) + (TextBox56.Text * 7)

        query = String.Format("update sales set customername ='" & TextBox46.Text & "', orderd='" & TextBox63.Text & "', customerpn='" & TextBox22.Text & "', customeremail='" & TextBox65.Text & "', JD5085='" & TextBox53.Text & "', JD244I='" & TextBox52.Text & "', JD5086='" & TextBox51.Text & "', L5740='" & TextBox50.Text & "', FTX128L='" & TextBox49.Text & "', RTF230='" & TextBox48.Text & "', 575DI='" & TextBox47.Text & "', 785L7='" & TextBox54.Text & "', HD325='" & TextBox55.Text & "', WB935='" & TextBox62.Text & "', M5111='" & TextBox61.Text & "', 5065E='" & TextBox60.Text & "', L45='" & TextBox59.Text & "', 210LEP='" & TextBox58.Text & "', 210L='" & TextBox57.Text & "', 710K='" & TextBox56.Text & "', ordertotal='" & TextBox27.Text & "' WHERE orderno=" & TextBox64.Text)
        ob.RunQuery(query)
        showdata()


        GroupBox13.Visible = False
        GroupBox7.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        query = "select * from hod"
        DataGridView2.DataSource = ob.getdata(query)


    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Try

            TextBox72.Text = DataGridView2.CurrentRow.Cells(0).Value
            TextBox67.Text = DataGridView2.CurrentRow.Cells(1).Value
            TextBox68.Text = DataGridView2.CurrentRow.Cells(2).Value
            TextBox69.Text = DataGridView2.CurrentRow.Cells(3).Value
            TextBox70.Text = DataGridView2.CurrentRow.Cells(4).Value
            TextBox71.Text = DataGridView2.CurrentRow.Cells(5).Value
            TextBox73.Text = DataGridView2.CurrentRow.Cells(6).Value
            TextBox74.Text = DataGridView2.CurrentRow.Cells(7).Value
            TextBox75.Text = DataGridView2.CurrentRow.Cells(8).Value
            TextBox76.Text = DataGridView2.CurrentRow.Cells(9).Value
            TextBox77.Text = DataGridView2.CurrentRow.Cells(10).Value
            TextBox78.Text = DataGridView2.CurrentRow.Cells(11).Value
            TextBox79.Text = DataGridView2.CurrentRow.Cells(12).Value
            TextBox80.Text = DataGridView2.CurrentRow.Cells(13).Value
            TextBox81.Text = DataGridView2.CurrentRow.Cells(14).Value
            TextBox82.Text = DataGridView2.CurrentRow.Cells(15).Value
            TextBox83.Text = DataGridView2.CurrentRow.Cells(16).Value
            TextBox84.Text = DataGridView2.CurrentRow.Cells(17).Value
            TextBox66.Text = ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) + ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If RadioButton5.Checked = True Then
            query = "SELECT * from hod where recordd Between #" & DateTimePicker2.Text & "# And #" & DateTimePicker3.Text & "#"
        ElseIf RadioButton7.Checked = True Then
            query = "select * from hod where recordno=" & TextBox90.Text & ""
        ElseIf RadioButton6.Checked = True Then
            query = "select * from hod where totalsales=" & TextBox85.Text & ""
        End If


        DataGridView2.DataSource = ob.getdata(query)


    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        query = "delete from sales where orderno=" + TextBox64.Text
        ob.RunQuery(query)

        query = "select * from sales"
        DataGridView1.DataSource = ob.getdata(query)

        GroupBox16.Visible = False
        GroupBox7.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        GroupBox16.Visible = False
        GroupBox7.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click

        GroupBox13.Visible = False
        GroupBox16.Visible = True
        GroupBox7.Enabled = False
        Button7.Enabled = False
        Button6.Enabled = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        TextBox66.Text = ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) + ((TextBox3.Text * 900) + (TextBox4.Text * 750) + (TextBox5.Text * 950) + (TextBox6.Text * 920) + (TextBox7.Text * 600) + (TextBox8.Text * 450) + (TextBox9.Text * 650) + (TextBox17.Text * 1700) + (TextBox18.Text * 1350) + (TextBox10.Text * 600) + (TextBox11.Text * 700) + (TextBox12.Text * 730) + (TextBox13.Text * 550) + (TextBox14.Text * 940) + (TextBox16.Text * 850) + (TextBox15.Text * 800)) * (0.05)

        query = String.Format("update hod set recordd ='" & TextBox67.Text & "', JD5085='" & TextBox68.Text & "', JD244I='" & TextBox69.Text & "', JD5086='" & TextBox70.Text & "', L5740='" & TextBox71.Text & "', FTX128L='" & TextBox73.Text & "', RTF230='" & TextBox74.Text & "', 575DI='" & TextBox75.Text & "', 785L7='" & TextBox76.Text & "', HD325='" & TextBox77.Text & "', WB935='" & TextBox78.Text & "', M5111='" & TextBox79.Text & "', 5065E='" & TextBox80.Text & "', L45='" & TextBox81.Text & "', 210LEP='" & TextBox82.Text & "', 210L='" & TextBox83.Text & "', 710K='" & TextBox84.Text & "', totalsales='" & TextBox66.Text & "' WHERE recordno=" & TextBox72.Text)
        ob.RunQuery(query)
        showdata2()

        GroupBox14.Visible = False
        GroupBox15.Enabled = True
        Button17.Enabled = True
        Button16.Enabled = True

    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        GroupBox14.Visible = False
        GroupBox17.Visible = True
        GroupBox15.Enabled = False
        Button17.Enabled = False
        Button16.Enabled = False

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        query = "delete from hod where recordno=" + TextBox72.Text
        ob.RunQuery(query)

        query = "select * from hod"
        DataGridView2.DataSource = ob.getdata(query)

        GroupBox17.Visible = False
        GroupBox15.Enabled = True
        Button17.Enabled = True
        Button16.Enabled = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        GroupBox17.Visible = False

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        GroupBox16.Visible = False
        Button10.Visible = True
        Button11.Visible = True
        GroupBox14.Visible = True
        GroupBox7.Enabled = False
        GroupBox15.Enabled = False
        Button17.Enabled = False
        Button16.Enabled = False
        GroupBox17.Visible = False

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        GroupBox14.Visible = False
        GroupBox15.Enabled = True
        Button17.Enabled = True
        Button16.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateTimePicker4.Enabled = True
            DateTimePicker5.Enabled = True

        ElseIf RadioButton1.Checked = False Then
            DateTimePicker4.Enabled = False
            DateTimePicker5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            TextBox25.Enabled = True

        ElseIf RadioButton2.Checked = False Then
            TextBox25.Enabled = False

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            TextBox24.Enabled = True

        ElseIf RadioButton3.Checked = False Then
            TextBox24.Enabled = False

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        If RadioButton4.Checked = True Then
            TextBox23.Enabled = True

        ElseIf RadioButton4.Checked = False Then
            TextBox23.Enabled = False

        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            DateTimePicker2.Enabled = True
            DateTimePicker3.Enabled = True

        ElseIf RadioButton5.Checked = False Then
            DateTimePicker2.Enabled = False
            DateTimePicker3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then

            TextBox85.Enabled = True

        ElseIf RadioButton6.Checked = False Then

            TextBox85.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            TextBox90.Enabled = True

        ElseIf RadioButton7.Checked = False Then
            TextBox90.Enabled = False

        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        invoive.Visible = False
        salesd.Visible = False
        invoiceg.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        invoiceg.Visible = False
        salesd.Visible = False
        invoive.Visible = True
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        invoiceg.Visible = False
        invoive.Visible = False
        salesd.Visible = True
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox44_TextChanged(sender As Object, e As EventArgs) Handles TextBox44.TextChanged
        TextBox44.Text = Year(Format(Date.Now())) + Year(Format(Date.Now())) + Day(Format(Date.Now())) * Second(Format(Date.Now())) + 3 * (9 + Second(Format(Date.Now()))) * 355 + Hour(Format(Date.Now())) * Second(Format(Date.Now())) * Day(Format(Date.Now())) * Year(Format(Date.Now()))
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub TextBox45_TextChanged(sender As Object, e As EventArgs) Handles TextBox45.TextChanged

    End Sub

    Private Sub GroupBox2_Enter_1(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    '	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    'End Sub
End Class
