﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.18010
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.Service2Soap")>  _
    Public Interface Service2Soap
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 sjfzz 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Calculate", ReplyAction:="*")>  _
        Function Calculate(ByVal request As ServiceReference1.CalculateRequest) As ServiceReference1.CalculateResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CalculateRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Calculate", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.CalculateRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.CalculateRequestBody)
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
        Public sjfzz As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public pdsj As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public gaodu2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>  _
        Public gaodu3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=4)>  _
        Public youwen2 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=5)>  _
        Public youwen3 As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public yp As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public wlbm As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=8)>  _
        Public pandianren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=9)>  _
        Public jianpanren As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=10)>  _
        Public guanqu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=11)>  _
        Public beizhu As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=12)>  _
        Public guanhao_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=13)>  _
        Public gaodu_w As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=14)>  _
        Public youwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=15)>  _
        Public qiwen_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=16)>  _
        Public bzmd_w As Single
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=17)>  _
        Public bzwd_w As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=18)>  _
        Public bhxs_w As Single
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New( _
                    ByVal sjfzz As String,  _
                    ByVal pdsj As String,  _
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
                    ByVal gaodu_w As String,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single)
            MyBase.New
            Me.sjfzz = sjfzz
            Me.pdsj = pdsj
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
        Public Body As ServiceReference1.CalculateResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.CalculateResponseBody)
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
    Public Interface Service2SoapChannel
        Inherits ServiceReference1.Service2Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service2SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.Service2Soap)
        Implements ServiceReference1.Service2Soap
        
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
        Function ServiceReference1_Service2Soap_Calculate(ByVal request As ServiceReference1.CalculateRequest) As ServiceReference1.CalculateResponse Implements ServiceReference1.Service2Soap.Calculate
            Return MyBase.Channel.Calculate(request)
        End Function
        
        Public Function Calculate( _
                    ByVal sjfzz As String,  _
                    ByVal pdsj As String,  _
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
                    ByVal gaodu_w As String,  _
                    ByVal youwen_w As Single,  _
                    ByVal qiwen_w As Single,  _
                    ByVal bzmd_w As Single,  _
                    ByVal bzwd_w As Integer,  _
                    ByVal bhxs_w As Single) As Single
            Dim inValue As ServiceReference1.CalculateRequest = New ServiceReference1.CalculateRequest()
            inValue.Body = New ServiceReference1.CalculateRequestBody()
            inValue.Body.sjfzz = sjfzz
            inValue.Body.pdsj = pdsj
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
            Dim retVal As ServiceReference1.CalculateResponse = CType(Me,ServiceReference1.Service2Soap).Calculate(inValue)
            Return retVal.Body.CalculateResult
        End Function
    End Class
End Namespace
