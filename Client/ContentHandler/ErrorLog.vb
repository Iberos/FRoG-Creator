Imports System.IO

Public Class ErrorLog
    Private Const ERROR_LOG_FILE As String = "logs.txt"

    Public Shared Sub Write(ByRef ex As Exception)
        File.AppendAllText(ERROR_LOG_FILE, String.Format("{0}{5}{0}Erreur {1} {2}{0}{3}{0}{4}", Environment.NewLine, ex.HResult, ex.Source, ex.Message, ex.ToString, DateTime.Now.ToString()))
    End Sub
End Class
