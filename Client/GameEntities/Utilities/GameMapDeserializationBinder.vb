Imports System.Runtime.Serialization
Imports System.Reflection

Public NotInheritable Class GameMapDeserializationBinder
    Inherits SerializationBinder

    Public Overrides Function BindToType(ByVal assemblyName As String, ByVal typeName As String) As Type
        Return Type.GetType(String.Format("{0}, {1}", typeName, Assembly.GetExecutingAssembly.FullName))
    End Function
End Class

