﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.1008
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace for_oil_store
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="for_oil_store.For_Oil_StoreSoap")>  _
    Public Interface For_Oil_StoreSoap
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 guanhao_w 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Calculate", ReplyAction:="*")>  _
        Function Calculate(ByVal request As for_oil_store.CalculateRequest) As for_oil_store.CalculateResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CalculateRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Calculate", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As for_oil_store.CalculateRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As for_oil_store.CalculateRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class CalculateRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public guanhao_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public gaodu_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public youwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>  _
        Public qiwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=4)>  _
        Public bzmd_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=5)>  _
        Public bzwd_w As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=6)>  _
        Public bhxs_w As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal guanhao_w As String, ByVal gaodu_w As String, ByVal youwen_w As Single, ByVal qiwen_w As Single, ByVal bzmd_w As Single, ByVal bzwd_w As Integer, ByVal bhxs_w As Single)
            MyBase.New
            Me.guanhao_w = guanhao_w
            Me.gaodu_w = gaodu_w
            Me.youwen_w = youwen_w
            Me.qiwen_w = qiwen_w
            Me.bzmd_w = bzmd_w
            Me.bzwd_w = bzwd_w
            Me.bhxs_w = bhxs_w
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CalculateResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="CalculateResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As for_oil_store.CalculateResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As for_oil_store.CalculateResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class CalculateResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public CalculateResult As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal CalculateResult As Single)
            MyBase.New
            Me.CalculateResult = CalculateResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface For_Oil_StoreSoapChannel
        Inherits for_oil_store.For_Oil_StoreSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class For_Oil_StoreSoapClient
        Inherits System.ServiceModel.ClientBase(Of for_oil_store.For_Oil_StoreSoap)
        Implements for_oil_store.For_Oil_StoreSoap
        
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
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function for_oil_store_For_Oil_StoreSoap_Calculate(ByVal request As for_oil_store.CalculateRequest) As for_oil_store.CalculateResponse Implements for_oil_store.For_Oil_StoreSoap.Calculate
            Return MyBase.Channel.Calculate(request)
        End Function
        
        Public Function Calculate(ByVal guanhao_w As String, ByVal gaodu_w As String, ByVal youwen_w As Single, ByVal qiwen_w As Single, ByVal bzmd_w As Single, ByVal bzwd_w As Integer, ByVal bhxs_w As Single) As Single
            Dim inValue As for_oil_store.CalculateRequest = New for_oil_store.CalculateRequest()
            inValue.Body = New for_oil_store.CalculateRequestBody()
            inValue.Body.guanhao_w = guanhao_w
            inValue.Body.gaodu_w = gaodu_w
            inValue.Body.youwen_w = youwen_w
            inValue.Body.qiwen_w = qiwen_w
            inValue.Body.bzmd_w = bzmd_w
            inValue.Body.bzwd_w = bzwd_w
            inValue.Body.bhxs_w = bhxs_w
            Dim retVal As for_oil_store.CalculateResponse = CType(Me,for_oil_store.For_Oil_StoreSoap).Calculate(inValue)
            Return retVal.Body.CalculateResult
        End Function
    End Class
End Namespace
