Imports SFML.Graphics

Public Class ContentManager
    Private Shared resources As New Dictionary(Of String, Object)

    ''' <summary>
    ''' Charge la ressource depuis le dictionnaire de données
    ''' </summary>
    ''' <typeparam name="T">Le type de la ressource à charger</typeparam>
    ''' <param name="key">La clé référente à la ressource</param>
    ''' <returns>La ressource si elle existe, 'Nothing' dans le cas contraire</returns>
    ''' <remarks></remarks>
    Public Shared Function Load(Of T)(key As String)
        If (resources.Keys.Contains(key)) Then
            Return DirectCast(resources(key), T)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Ajoute la ressource dans le dictionnaire de données
    ''' </summary>
    ''' <typeparam name="T">Le type de la ressource à ajouter</typeparam>
    ''' <param name="key">La clé permettant de référencer la ressource</param>
    ''' <param name="obj">L'instance d'objet définissant la ressource</param>
    ''' <returns>Vrai si la ressource a été ajouté, Faux dans le cas contraire</returns>
    ''' <remarks></remarks>
    Public Shared Function Add(Of T)(key As String, obj As T)
        If (Not resources.Keys.Contains(key)) Then
            resources.Add(key, obj)
            Return True
        End If
        Return False
    End Function
End Class
