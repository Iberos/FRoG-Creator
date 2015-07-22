Public Class NativeMethods
    Declare Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
End Class
