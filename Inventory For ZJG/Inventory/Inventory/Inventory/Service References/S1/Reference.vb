﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.18444
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace S1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="S1.Service1Soap")>  _
    Public Interface Service1Soap
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 yp 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Just_Calculate", ReplyAction:="*")>  _
        Function Just_Calculate(ByVal request As S1.Just_CalculateRequest) As S1.Just_CalculateResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Ver201405121018", ReplyAction:="*")>  _
        Function Ver201405121018() As Integer
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 yp 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Calculate", ReplyAction:="*")>  _
        Function Calculate(ByVal request As S1.CalculateRequest) As S1.CalculateResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class Just_CalculateRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Just_Calculate", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As S1.Just_CalculateRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As S1.Just_CalculateRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Just_CalculateRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public gaodu2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=1)>  _
        Public gaodu3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public youwen2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>  _
        Public youwen3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public yp As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public wlbm As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public pandianren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public jianpanren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=8)>  _
        Public guanqu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=9)>  _
        Public beizhu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=10)>  _
        Public guanhao_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=11)>  _
        Public gaodu_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=12)>  _
        Public youwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=13)>  _
        Public qiwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=14)>  _
        Public bzmd_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=15)>  _
        Public bzwd_w As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=16)>  _
        Public bhxs_w As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New( _
                    ByVal gaodu2 As Single,  _
                    ByVal gaodu3 As Single,  _
                    ByVal youwen2 As Single,  _
                    ByVal youwen3 As Single,  _
                    ByVal yp As String,  _
                    ByVal wlbm As String,  _
                    ByVal pandianren As String,  _
                    ByVal jianpanren As String,  _
                    ByVal guanqu As String,  _
                    ByVal beizhu As String,  _
                    ByVal guanhao_w As String,  _
                    ByVal gaodu_w As Single,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single)
            MyBase.New
            Me.gaodu2 = gaodu2
            Me.gaodu3 = gaodu3
            Me.youwen2 = youwen2
            Me.youwen3 = youwen3
            Me.yp = yp
            Me.wlbm = wlbm
            Me.pandianren = pandianren
            Me.jianpanren = jianpanren
            Me.guanqu = guanqu
            Me.beizhu = beizhu
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
    Partial Public Class Just_CalculateResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Just_CalculateResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As S1.Just_CalculateResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As S1.Just_CalculateResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Just_CalculateResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public Just_CalculateResult As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Just_CalculateResult As Single)
            MyBase.New
            Me.Just_CalculateResult = Just_CalculateResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CalculateRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Calculate", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As S1.CalculateRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As S1.CalculateRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class CalculateRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public gaodu2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=1)>  _
        Public gaodu3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public youwen2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>  _
        Public youwen3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public yp As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public wlbm As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public pandianren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public jianpanren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=8)>  _
        Public guanqu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=9)>  _
        Public beizhu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=10)>  _
        Public guanhao_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=11)>  _
        Public gaodu_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=12)>  _
        Public youwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=13)>  _
        Public qiwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=14)>  _
        Public bzmd_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=15)>  _
        Public bzwd_w As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=16)>  _
        Public bhxs_w As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New( _
                    ByVal gaodu2 As Single,  _
                    ByVal gaodu3 As Single,  _
                    ByVal youwen2 As Single,  _
                    ByVal youwen3 As Single,  _
                    ByVal yp As String,  _
                    ByVal wlbm As String,  _
                    ByVal pandianren As String,  _
                    ByVal jianpanren As String,  _
                    ByVal guanqu As String,  _
                    ByVal beizhu As String,  _
                    ByVal guanhao_w As String,  _
                    ByVal gaodu_w As Single,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single)
            MyBase.New
            Me.gaodu2 = gaodu2
            Me.gaodu3 = gaodu3
            Me.youwen2 = youwen2
            Me.youwen3 = youwen3
            Me.yp = yp
            Me.wlbm = wlbm
            Me.pandianren = pandianren
            Me.jianpanren = jianpanren
            Me.guanqu = guanqu
            Me.beizhu = beizhu
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
        Public Body As S1.CalculateResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As S1.CalculateResponseBody)
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
    Public Interface Service1SoapChannel
        Inherits S1.Service1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1SoapClient
        Inherits System.ServiceModel.ClientBase(Of S1.Service1Soap)
        Implements S1.Service1Soap
        
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
        Function S1_Service1Soap_Just_Calculate(ByVal request As S1.Just_CalculateRequest) As S1.Just_CalculateResponse Implements S1.Service1Soap.Just_Calculate
            Return MyBase.Channel.Just_Calculate(request)
        End Function
        
        Public Function Just_Calculate( _
                    ByVal gaodu2 As Single,  _
                    ByVal gaodu3 As Single,  _
                    ByVal youwen2 As Single,  _
                    ByVal youwen3 As Single,  _
                    ByVal yp As String,  _
                    ByVal wlbm As String,  _
                    ByVal pandianren As String,  _
                    ByVal jianpanren As String,  _
                    ByVal guanqu As String,  _
                    ByVal beizhu As String,  _
                    ByVal guanhao_w As String,  _
                    ByVal gaodu_w As Single,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single) As Single
            Dim inValue As S1.Just_CalculateRequest = New S1.Just_CalculateRequest()
            inValue.Body = New S1.Just_CalculateRequestBody()
            inValue.Body.gaodu2 = gaodu2
            inValue.Body.gaodu3 = gaodu3
            inValue.Body.youwen2 = youwen2
            inValue.Body.youwen3 = youwen3
            inValue.Body.yp = yp
            inValue.Body.wlbm = wlbm
            inValue.Body.pandianren = pandianren
            inValue.Body.jianpanren = jianpanren
            inValue.Body.guanqu = guanqu
            inValue.Body.beizhu = beizhu
            inValue.Body.guanhao_w = guanhao_w
            inValue.Body.gaodu_w = gaodu_w
            inValue.Body.youwen_w = youwen_w
            inValue.Body.qiwen_w = qiwen_w
            inValue.Body.bzmd_w = bzmd_w
            inValue.Body.bzwd_w = bzwd_w
            inValue.Body.bhxs_w = bhxs_w
            Dim retVal As S1.Just_CalculateResponse = CType(Me,S1.Service1Soap).Just_Calculate(inValue)
            Return retVal.Body.Just_CalculateResult
        End Function
        
        Public Function Ver201405121018() As Integer Implements S1.Service1Soap.Ver201405121018
            Return MyBase.Channel.Ver201405121018
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function S1_Service1Soap_Calculate(ByVal request As S1.CalculateRequest) As S1.CalculateResponse Implements S1.Service1Soap.Calculate
            Return MyBase.Channel.Calculate(request)
        End Function
        
        Public Function Calculate( _
                    ByVal gaodu2 As Single,  _
                    ByVal gaodu3 As Single,  _
                    ByVal youwen2 As Single,  _
                    ByVal youwen3 As Single,  _
                    ByVal yp As String,  _
                    ByVal wlbm As String,  _
                    ByVal pandianren As String,  _
                    ByVal jianpanren As String,  _
                    ByVal guanqu As String,  _
                    ByVal beizhu As String,  _
                    ByVal guanhao_w As String,  _
                    ByVal gaodu_w As Single,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single) As Single
            Dim inValue As S1.CalculateRequest = New S1.CalculateRequest()
            inValue.Body = New S1.CalculateRequestBody()
            inValue.Body.gaodu2 = gaodu2
            inValue.Body.gaodu3 = gaodu3
            inValue.Body.youwen2 = youwen2
            inValue.Body.youwen3 = youwen3
            inValue.Body.yp = yp
            inValue.Body.wlbm = wlbm
            inValue.Body.pandianren = pandianren
            inValue.Body.jianpanren = jianpanren
            inValue.Body.guanqu = guanqu
            inValue.Body.beizhu = beizhu
            inValue.Body.guanhao_w = guanhao_w
            inValue.Body.gaodu_w = gaodu_w
            inValue.Body.youwen_w = youwen_w
            inValue.Body.qiwen_w = qiwen_w
            inValue.Body.bzmd_w = bzmd_w
            inValue.Body.bzwd_w = bzwd_w
            inValue.Body.bhxs_w = bhxs_w
            Dim retVal As S1.CalculateResponse = CType(Me,S1.Service1Soap).Calculate(inValue)
            Return retVal.Body.CalculateResult
        End Function
    End Class
End Namespace
