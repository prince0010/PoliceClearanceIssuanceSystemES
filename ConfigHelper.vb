Imports System.Reflection
Imports Microsoft.Extensions.Configuration

Public Class ConfigHelper
    Public ReadOnly Property ConnectionString() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()

            Dim sections = configuration.GetSection("Database").GetChildren().ToList()

            Return $"Data Source={sections(1).Value};Initial Catalog={sections(0).Value};Integrated Security={sections(2).Value}"
        End Get
    End Property
    Public ReadOnly Property GetPoliceSignatureImgPath() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()
            Dim projectName As String = Assembly.GetExecutingAssembly().GetName().Name
            Dim appDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim policeSigFolderName As String = configuration.GetSection("AppSettings")("ImgPoliceSignaturePath")
            Return appDataFolder + "\" + projectName + "\" + policeSigFolderName + "\"
        End Get
    End Property
    Public ReadOnly Property GetApplicantSignatureImgPath() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()
            Dim projectName As String = Assembly.GetExecutingAssembly().GetName().Name
            Dim appDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim policeSigFolderName As String = configuration.GetSection("AppSettings")("ImgApplicantSignaturePath")
            Return appDataFolder + "\" + projectName + "\" + policeSigFolderName + "\"
        End Get
    End Property
    Public ReadOnly Property GetApplicantFingerprintImgPath() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()
            Dim projectName As String = Assembly.GetExecutingAssembly().GetName().Name
            Dim appDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim policeSigFolderName As String = configuration.GetSection("AppSettings")("ImgApplicantFingerprintPath")
            Return appDataFolder + "\" + projectName + "\" + policeSigFolderName + "\"
        End Get
    End Property
    Public ReadOnly Property GetApplicantPictureImgPath() As String
        Get
            Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()
            Dim projectName As String = Assembly.GetExecutingAssembly().GetName().Name
            Dim appDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim policeSigFolderName As String = configuration.GetSection("AppSettings")("ImgApplicantPicturePath")
            Return appDataFolder + "\" + projectName + "\" + policeSigFolderName + "\"
        End Get
    End Property
End Class
