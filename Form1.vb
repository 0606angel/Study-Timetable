Public Class Form1

    Private Sub study_timetable(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grd_timetable.Row = r
        grd_timetable.Col = c
        grd_timetable.Text = t
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        study_timetable(0, 0, "Time")
        study_timetable(0, 1, "Monday")
        study_timetable(0, 2, "Tuesday")
        study_timetable(0, 3, "Wednesday")
        study_timetable(0, 4, "Thursday")
        study_timetable(0, 5, "Friday")
        study_timetable(0, 6, "Saturday")
        study_timetable(0, 7, "Sunday")

        study_timetable(2, 0, "08:00-09:00")
        study_timetable(4, 0, "09:00-10:00")
        study_timetable(6, 0, "10:00-11:00")
        study_timetable(8, 0, "11:00-12:00")
        study_timetable(10, 0, "12:00-13:00")
        study_timetable(12, 0, "13:00-14:00")
        study_timetable(14, 0, "14:00-15:00")
        study_timetable(16, 0, "15:00-16:00")
        study_timetable(18, 0, "16:00-17:00")
        study_timetable(20, 0, "17:00-18:00")
        study_timetable(22, 0, "18:00-19:00")
        study_timetable(24, 0, "19:00-20:00")
        study_timetable(26, 0, "20:00-21:00")
        study_timetable(28, 0, "21:00-22:00")
        study_timetable(30, 0, "22:00-23:00")

        study_timetable(2, 1, "MATHS")
        study_timetable(4, 1, "LFS")
        study_timetable(8, 1, "INFOMATICS")
        study_timetable(22, 1, "MATHS")
        study_timetable(24, 1, "MATHS")
        study_timetable(28, 1, "LFS")
        study_timetable(30, 1, "INFOMATICS")


        study_timetable(2, 2, "LFS")
        study_timetable(4, 2, "INFOMATICS")
        study_timetable(6, 2, "INFOMATICS")
        study_timetable(8, 2, "MATHS")
        study_timetable(22, 2, "MATHS")
        study_timetable(30, 2, "INFOMATICS")


        study_timetable(10, 3, "LFS")
        study_timetable(18, 3, "INFOMATICS")
        study_timetable(20, 3, "INFOMATICS")
        study_timetable(24, 3, "MATHS")
        study_timetable(26, 3, "MATHS")
        study_timetable(30, 3, "INFOMATICS")

        study_timetable(8, 4, "MATHS")
        study_timetable(10, 4, "MATHS")
        study_timetable(22, 4, "LFS")
        study_timetable(26, 4, "INFOMATICS")

        study_timetable(8, 5, "MATHS")
        study_timetable(10, 5, "MATHS")
        study_timetable(14, 5, "INFOMATICS")
        study_timetable(26, 5, "LFS")

        study_timetable(4, 6, "INFOMATIC")
        study_timetable(6, 6, "INFOMATICS")
        study_timetable(8, 6, "INFOMATICS")
        study_timetable(14, 6, "MATHS")
        study_timetable(16, 6, "MATHS")
        study_timetable(18, 6, "MATHS")
        study_timetable(26, 6, "LFS")

        study_timetable(4, 7, "INFOMATICS")
        study_timetable(6, 7, "INFOMATICS")
        study_timetable(8, 7, "INFOMATICS")
        study_timetable(12, 7, "LFS")
        study_timetable(20, 7, "MATHS")























    End Sub
End Class
