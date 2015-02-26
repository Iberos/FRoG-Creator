Imports System.Runtime.Serialization
Imports System.Reflection

Public NotInheritable Class GameMapDeserializationBinder
    Inherits SerializationBinder

    Public Overrides Function BindToType(ByVal assemblyName As String, ByVal typeName As String) As Type
        assemblyName = Assembly.GetExecutingAssembly.FullName
        typeName = typeName.Replace("Editeur", "Client")
        Return Type.GetType(String.Format("{0}, {1}", typeName, assemblyName))
    End Function
End Class

