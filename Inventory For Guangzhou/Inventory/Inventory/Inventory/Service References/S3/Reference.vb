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

Namespace S3
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="S3.Service3Soap")>  _
    Public Interface Service3Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/validate", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function validate(ByVal username As String, ByVal password As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addpinming", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addpinming(ByVal ssgq As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addcanshu", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addcanshu(ByVal gqbh As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/delygbh", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function delygbh(ByVal gqbh As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addkcload", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addkcload() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addkcwz", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addkcwz() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/adddw", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function adddw(ByVal kc As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addguige", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addguige() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/mohuscan", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function mohuscan(ByVal inputsel As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/wlxx", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function wlxx(ByVal inputsel As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/insertkcpd", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function insertkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal kc As String, ByVal dw As String, ByVal gg As String, ByVal danwei As String, ByVal tsk As String, ByVal js As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String, ByVal zl As Single) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/analyze", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function analyze(ByVal gg As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addfl_wlms", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addfl_wlms() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addfl_kcd", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addfl_kcd() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addfl_wlh", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function addfl_wlh(ByVal wlms As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/insertflpd", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function insertflpd(ByVal wlbm As String, ByVal pz As String, ByVal kc As String, ByVal gg As String, ByVal gc As String, ByVal bz As String, ByVal username As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ddwl", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ddwl() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ddwlh", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ddwlh(ByVal wlms As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/insertddkcpd", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function insertddkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal ch As String, ByVal h1 As Single, ByVal h2 As Single, ByVal h3 As Single, ByVal h4 As Single, ByVal h5 As Single, ByVal h6 As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/adddd_cdcg", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function adddd_cdcg(ByVal ch As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/insertxbz", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function insertxbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/findwlbm", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function findwlbm(ByVal wlms As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/adddp_wlms", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function adddp_wlms() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/adddp_wlbm", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function adddp_wlbm(ByVal wlms As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/insertdp", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function insertdp(ByVal wlbm As String, ByVal wlms As String, ByVal gg As String, ByVal ch As String, ByVal dc1 As Single, ByVal dc2 As Single, ByVal dc3 As Single, ByVal dc4 As Single, ByVal dc5 As Single, ByVal dc6 As Single, ByVal bz As String, ByVal pdry As String, ByVal jpry As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/xbz_cangqu", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function xbz_cangqu() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/xbz_kuwei", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function xbz_kuwei(ByVal cangqu As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/xbz_huoming", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function xbz_huoming(ByVal mohu As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/xbz_panduan", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function xbz_panduan(ByVal pinming As String, ByVal cangqu As String, ByVal huowei As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/updatexbz", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function updatexbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface Service3SoapChannel
        Inherits S3.Service3Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service3SoapClient
        Inherits System.ServiceModel.ClientBase(Of S3.Service3Soap)
        Implements S3.Service3Soap
        
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
        
        Public Function HelloWorld() As String Implements S3.Service3Soap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Function validate(ByVal username As String, ByVal password As String) As Boolean Implements S3.Service3Soap.validate
            Return MyBase.Channel.validate(username, password)
        End Function
        
        Public Function addpinming(ByVal ssgq As String) As System.Data.DataSet Implements S3.Service3Soap.addpinming
            Return MyBase.Channel.addpinming(ssgq)
        End Function
        
        Public Function addcanshu(ByVal gqbh As String) As System.Data.DataSet Implements S3.Service3Soap.addcanshu
            Return MyBase.Channel.addcanshu(gqbh)
        End Function
        
        Public Function delygbh(ByVal gqbh As String) As Boolean Implements S3.Service3Soap.delygbh
            Return MyBase.Channel.delygbh(gqbh)
        End Function
        
        Public Function addkcload() As System.Data.DataSet Implements S3.Service3Soap.addkcload
            Return MyBase.Channel.addkcload
        End Function
        
        Public Function addkcwz() As System.Data.DataSet Implements S3.Service3Soap.addkcwz
            Return MyBase.Channel.addkcwz
        End Function
        
        Public Function adddw(ByVal kc As String) As System.Data.DataSet Implements S3.Service3Soap.adddw
            Return MyBase.Channel.adddw(kc)
        End Function
        
        Public Function addguige() As System.Data.DataSet Implements S3.Service3Soap.addguige
            Return MyBase.Channel.addguige
        End Function
        
        Public Function mohuscan(ByVal inputsel As String) As System.Data.DataSet Implements S3.Service3Soap.mohuscan
            Return MyBase.Channel.mohuscan(inputsel)
        End Function
        
        Public Function wlxx(ByVal inputsel As String) As System.Data.DataSet Implements S3.Service3Soap.wlxx
            Return MyBase.Channel.wlxx(inputsel)
        End Function
        
        Public Function insertkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal kc As String, ByVal dw As String, ByVal gg As String, ByVal danwei As String, ByVal tsk As String, ByVal js As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String, ByVal zl As Single) As Boolean Implements S3.Service3Soap.insertkcpd
            Return MyBase.Channel.insertkcpd(wlbm, wlms, kc, dw, gg, danwei, tsk, js, pdry, jpry, bz, zl)
        End Function
        
        Public Function analyze(ByVal gg As String) As System.Data.DataSet Implements S3.Service3Soap.analyze
            Return MyBase.Channel.analyze(gg)
        End Function
        
        Public Function addfl_wlms() As System.Data.DataSet Implements S3.Service3Soap.addfl_wlms
            Return MyBase.Channel.addfl_wlms
        End Function
        
        Public Function addfl_kcd() As System.Data.DataSet Implements S3.Service3Soap.addfl_kcd
            Return MyBase.Channel.addfl_kcd
        End Function
        
        Public Function addfl_wlh(ByVal wlms As String) As System.Data.DataSet Implements S3.Service3Soap.addfl_wlh
            Return MyBase.Channel.addfl_wlh(wlms)
        End Function
        
        Public Function insertflpd(ByVal wlbm As String, ByVal pz As String, ByVal kc As String, ByVal gg As String, ByVal gc As String, ByVal bz As String, ByVal username As String) As Boolean Implements S3.Service3Soap.insertflpd
            Return MyBase.Channel.insertflpd(wlbm, pz, kc, gg, gc, bz, username)
        End Function
        
        Public Function ddwl() As System.Data.DataSet Implements S3.Service3Soap.ddwl
            Return MyBase.Channel.ddwl
        End Function
        
        Public Function ddwlh(ByVal wlms As String) As System.Data.DataSet Implements S3.Service3Soap.ddwlh
            Return MyBase.Channel.ddwlh(wlms)
        End Function
        
        Public Function insertddkcpd(ByVal wlbm As String, ByVal wlms As String, ByVal ch As String, ByVal h1 As Single, ByVal h2 As Single, ByVal h3 As Single, ByVal h4 As Single, ByVal h5 As Single, ByVal h6 As Single, ByVal pdry As String, ByVal jpry As String, ByVal bz As String) As Boolean Implements S3.Service3Soap.insertddkcpd
            Return MyBase.Channel.insertddkcpd(wlbm, wlms, ch, h1, h2, h3, h4, h5, h6, pdry, jpry, bz)
        End Function
        
        Public Function adddd_cdcg(ByVal ch As String) As System.Data.DataSet Implements S3.Service3Soap.adddd_cdcg
            Return MyBase.Channel.adddd_cdcg(ch)
        End Function
        
        Public Function insertxbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean Implements S3.Service3Soap.insertxbz
            Return MyBase.Channel.insertxbz(pinming, dw, kcd, cangqu, huowei, pdry, jpry, spsl, bz, ph)
        End Function
        
        Public Function findwlbm(ByVal wlms As String) As System.Data.DataSet Implements S3.Service3Soap.findwlbm
            Return MyBase.Channel.findwlbm(wlms)
        End Function
        
        Public Function adddp_wlms() As System.Data.DataSet Implements S3.Service3Soap.adddp_wlms
            Return MyBase.Channel.adddp_wlms
        End Function
        
        Public Function adddp_wlbm(ByVal wlms As String) As System.Data.DataSet Implements S3.Service3Soap.adddp_wlbm
            Return MyBase.Channel.adddp_wlbm(wlms)
        End Function
        
        Public Function insertdp(ByVal wlbm As String, ByVal wlms As String, ByVal gg As String, ByVal ch As String, ByVal dc1 As Single, ByVal dc2 As Single, ByVal dc3 As Single, ByVal dc4 As Single, ByVal dc5 As Single, ByVal dc6 As Single, ByVal bz As String, ByVal pdry As String, ByVal jpry As String) As Boolean Implements S3.Service3Soap.insertdp
            Return MyBase.Channel.insertdp(wlbm, wlms, gg, ch, dc1, dc2, dc3, dc4, dc5, dc6, bz, pdry, jpry)
        End Function
        
        Public Function xbz_cangqu() As System.Data.DataTable Implements S3.Service3Soap.xbz_cangqu
            Return MyBase.Channel.xbz_cangqu
        End Function
        
        Public Function xbz_kuwei(ByVal cangqu As String) As System.Data.DataSet Implements S3.Service3Soap.xbz_kuwei
            Return MyBase.Channel.xbz_kuwei(cangqu)
        End Function
        
        Public Function xbz_huoming(ByVal mohu As String) As System.Data.DataSet Implements S3.Service3Soap.xbz_huoming
            Return MyBase.Channel.xbz_huoming(mohu)
        End Function
        
        Public Function xbz_panduan(ByVal pinming As String, ByVal cangqu As String, ByVal huowei As String) As Boolean Implements S3.Service3Soap.xbz_panduan
            Return MyBase.Channel.xbz_panduan(pinming, cangqu, huowei)
        End Function
        
        Public Function updatexbz(ByVal pinming As String, ByVal dw As String, ByVal kcd As String, ByVal cangqu As String, ByVal huowei As String, ByVal pdry As String, ByVal jpry As String, ByVal spsl As Single, ByVal bz As String, ByVal ph As String) As Boolean Implements S3.Service3Soap.updatexbz
            Return MyBase.Channel.updatexbz(pinming, dw, kcd, cangqu, huowei, pdry, jpry, spsl, bz, ph)
        End Function
    End Class
End Namespace