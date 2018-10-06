Imports System.Management
Imports System
Imports System.Text
Imports System.Security.Cryptography
Public Class GetHWID

    Dim hw As New ClsComputerInfo
    Public hwid As String = Strings.UCase(hw.getMD5Hash(hw.GetProcessorId() & hw.GetVolumeSerial("C") & hw.GetMotherBoardID() & hw.GetMACAddress()))

End Class