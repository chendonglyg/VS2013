﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace QUANZHOU_Loaddata
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap")>  _
    Public Interface QUANZHOU_LoadDataSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Validate", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Validate(ByVal username As String, ByVal password As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetParameters", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetParameters(ByVal TankNo As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SetDelFlag", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SetDelFlag(ByVal gqbh As String) As Boolean
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface QUANZHOU_LoadDataSoapChannel
        Inherits QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class QUANZHOU_LoadDataSoapClient
        Inherits System.ServiceModel.ClientBase(Of QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap)
        Implements QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Validate(ByVal username As String, ByVal password As String) As Boolean Implements QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap.Validate
            Return MyBase.Channel.Validate(username, password)
        End Function
        
        Public Function GetParameters(ByVal TankNo As String) As System.Data.DataSet Implements QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap.GetParameters
            Return MyBase.Channel.GetParameters(TankNo)
        End Function
        
        Public Function SetDelFlag(ByVal gqbh As String) As Boolean Implements QUANZHOU_Loaddata.QUANZHOU_LoadDataSoap.SetDelFlag
            Return MyBase.Channel.SetDelFlag(gqbh)
        End Function
    End Class
End Namespace
