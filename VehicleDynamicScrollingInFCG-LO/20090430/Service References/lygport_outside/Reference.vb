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


Namespace lygport_outside
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="lygport_outside.Service1Soap")>  _
    Public Interface Service1Soap
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorld(ByVal request As lygport_outside.HelloWorldRequest) As lygport_outside.HelloWorldResponse
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 cryptogram 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetInRecord", ReplyAction:="*")>  _
        Function GetInRecord(ByVal request As lygport_outside.GetInRecordRequest) As lygport_outside.GetInRecordResponse
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 cryptogram 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/InsertConsignVehicle", ReplyAction:="*")>  _
        Function InsertConsignVehicle(ByVal request As lygport_outside.InsertConsignVehicleRequest) As lygport_outside.InsertConsignVehicleResponse
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 cryptogram 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UpdateConsignVehicle", ReplyAction:="*")>  _
        Function UpdateConsignVehicle(ByVal request As lygport_outside.UpdateConsignVehicleRequest) As lygport_outside.UpdateConsignVehicleResponse
        
        'CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 cryptogram 以后生成的消息协定未标记为 nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/VehicleInPark", ReplyAction:="*")>  _
        Function VehicleInPark(ByVal request As lygport_outside.VehicleInParkRequest) As lygport_outside.VehicleInParkResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorld", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.HelloWorldRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorldResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.HelloWorldResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.HelloWorldResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HelloWorldResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public HelloWorldResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal HelloWorldResult As String)
            MyBase.New
            Me.HelloWorldResult = HelloWorldResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetInRecordRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetInRecord", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.GetInRecordRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.GetInRecordRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GetInRecordRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public cryptogram As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public vehicle As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public externo As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal cryptogram As String, ByVal vehicle As String, ByVal externo As String)
            MyBase.New
            Me.cryptogram = cryptogram
            Me.vehicle = vehicle
            Me.externo = externo
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetInRecordResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetInRecordResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.GetInRecordResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.GetInRecordResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GetInRecordResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public veh_return As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public in_date As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public PictureGate() As Byte
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public PictureVehicle() As Byte
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public strErr As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public phone_no As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal veh_return As String, ByVal in_date As String, ByVal PictureGate() As Byte, ByVal PictureVehicle() As Byte, ByVal strErr As String, ByVal phone_no As String)
            MyBase.New
            Me.veh_return = veh_return
            Me.in_date = in_date
            Me.PictureGate = PictureGate
            Me.PictureVehicle = PictureVehicle
            Me.strErr = strErr
            Me.phone_no = phone_no
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class InsertConsignVehicleRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="InsertConsignVehicle", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.InsertConsignVehicleRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.InsertConsignVehicleRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class InsertConsignVehicleRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public cryptogram As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public vehicle As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public phone_no As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal cryptogram As String, ByVal vehicle As String, ByVal phone_no As String)
            MyBase.New
            Me.cryptogram = cryptogram
            Me.vehicle = vehicle
            Me.phone_no = phone_no
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class InsertConsignVehicleResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="InsertConsignVehicleResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.InsertConsignVehicleResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.InsertConsignVehicleResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class InsertConsignVehicleResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public InsertConsignVehicleResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal InsertConsignVehicleResult As String)
            MyBase.New
            Me.InsertConsignVehicleResult = InsertConsignVehicleResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UpdateConsignVehicleRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UpdateConsignVehicle", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.UpdateConsignVehicleRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.UpdateConsignVehicleRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdateConsignVehicleRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public cryptogram As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public vehicle As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal cryptogram As String, ByVal vehicle As String)
            MyBase.New
            Me.cryptogram = cryptogram
            Me.vehicle = vehicle
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UpdateConsignVehicleResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UpdateConsignVehicleResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.UpdateConsignVehicleResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.UpdateConsignVehicleResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdateConsignVehicleResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public UpdateConsignVehicleResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal UpdateConsignVehicleResult As String)
            MyBase.New
            Me.UpdateConsignVehicleResult = UpdateConsignVehicleResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class VehicleInParkRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="VehicleInPark", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.VehicleInParkRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.VehicleInParkRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class VehicleInParkRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public cryptogram As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public vehicle As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal cryptogram As String, ByVal vehicle As String)
            MyBase.New
            Me.cryptogram = cryptogram
            Me.vehicle = vehicle
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class VehicleInParkResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="VehicleInParkResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As lygport_outside.VehicleInParkResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As lygport_outside.VehicleInParkResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class VehicleInParkResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public VehicleInParkResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal VehicleInParkResult As String)
            MyBase.New
            Me.VehicleInParkResult = VehicleInParkResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface Service1SoapChannel
        Inherits lygport_outside.Service1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1SoapClient
        Inherits System.ServiceModel.ClientBase(Of lygport_outside.Service1Soap)
        Implements lygport_outside.Service1Soap
        
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
        Function lygport_outside_Service1Soap_HelloWorld(ByVal request As lygport_outside.HelloWorldRequest) As lygport_outside.HelloWorldResponse Implements lygport_outside.Service1Soap.HelloWorld
            Return MyBase.Channel.HelloWorld(request)
        End Function
        
        Public Function HelloWorld() As String
            Dim inValue As lygport_outside.HelloWorldRequest = New lygport_outside.HelloWorldRequest()
            inValue.Body = New lygport_outside.HelloWorldRequestBody()
            Dim retVal As lygport_outside.HelloWorldResponse = CType(Me,lygport_outside.Service1Soap).HelloWorld(inValue)
            Return retVal.Body.HelloWorldResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function lygport_outside_Service1Soap_GetInRecord(ByVal request As lygport_outside.GetInRecordRequest) As lygport_outside.GetInRecordResponse Implements lygport_outside.Service1Soap.GetInRecord
            Return MyBase.Channel.GetInRecord(request)
        End Function
        
        Public Function GetInRecord(ByVal cryptogram As String, ByVal vehicle As String, ByVal externo As String, <System.Runtime.InteropServices.OutAttribute()> ByRef in_date As String, <System.Runtime.InteropServices.OutAttribute()> ByRef PictureGate() As Byte, <System.Runtime.InteropServices.OutAttribute()> ByRef PictureVehicle() As Byte, <System.Runtime.InteropServices.OutAttribute()> ByRef strErr As String, <System.Runtime.InteropServices.OutAttribute()> ByRef phone_no As String) As String
            Dim inValue As lygport_outside.GetInRecordRequest = New lygport_outside.GetInRecordRequest()
            inValue.Body = New lygport_outside.GetInRecordRequestBody()
            inValue.Body.cryptogram = cryptogram
            inValue.Body.vehicle = vehicle
            inValue.Body.externo = externo
            Dim retVal As lygport_outside.GetInRecordResponse = CType(Me,lygport_outside.Service1Soap).GetInRecord(inValue)
            in_date = retVal.Body.in_date
            PictureGate = retVal.Body.PictureGate
            PictureVehicle = retVal.Body.PictureVehicle
            strErr = retVal.Body.strErr
            phone_no = retVal.Body.phone_no
            Return retVal.Body.veh_return
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function lygport_outside_Service1Soap_InsertConsignVehicle(ByVal request As lygport_outside.InsertConsignVehicleRequest) As lygport_outside.InsertConsignVehicleResponse Implements lygport_outside.Service1Soap.InsertConsignVehicle
            Return MyBase.Channel.InsertConsignVehicle(request)
        End Function
        
        Public Function InsertConsignVehicle(ByVal cryptogram As String, ByVal vehicle As String, ByVal phone_no As String) As String
            Dim inValue As lygport_outside.InsertConsignVehicleRequest = New lygport_outside.InsertConsignVehicleRequest()
            inValue.Body = New lygport_outside.InsertConsignVehicleRequestBody()
            inValue.Body.cryptogram = cryptogram
            inValue.Body.vehicle = vehicle
            inValue.Body.phone_no = phone_no
            Dim retVal As lygport_outside.InsertConsignVehicleResponse = CType(Me,lygport_outside.Service1Soap).InsertConsignVehicle(inValue)
            Return retVal.Body.InsertConsignVehicleResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function lygport_outside_Service1Soap_UpdateConsignVehicle(ByVal request As lygport_outside.UpdateConsignVehicleRequest) As lygport_outside.UpdateConsignVehicleResponse Implements lygport_outside.Service1Soap.UpdateConsignVehicle
            Return MyBase.Channel.UpdateConsignVehicle(request)
        End Function
        
        Public Function UpdateConsignVehicle(ByVal cryptogram As String, ByVal vehicle As String) As String
            Dim inValue As lygport_outside.UpdateConsignVehicleRequest = New lygport_outside.UpdateConsignVehicleRequest()
            inValue.Body = New lygport_outside.UpdateConsignVehicleRequestBody()
            inValue.Body.cryptogram = cryptogram
            inValue.Body.vehicle = vehicle
            Dim retVal As lygport_outside.UpdateConsignVehicleResponse = CType(Me,lygport_outside.Service1Soap).UpdateConsignVehicle(inValue)
            Return retVal.Body.UpdateConsignVehicleResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function lygport_outside_Service1Soap_VehicleInPark(ByVal request As lygport_outside.VehicleInParkRequest) As lygport_outside.VehicleInParkResponse Implements lygport_outside.Service1Soap.VehicleInPark
            Return MyBase.Channel.VehicleInPark(request)
        End Function
        
        Public Function VehicleInPark(ByVal cryptogram As String, ByVal vehicle As String) As String
            Dim inValue As lygport_outside.VehicleInParkRequest = New lygport_outside.VehicleInParkRequest()
            inValue.Body = New lygport_outside.VehicleInParkRequestBody()
            inValue.Body.cryptogram = cryptogram
            inValue.Body.vehicle = vehicle
            Dim retVal As lygport_outside.VehicleInParkResponse = CType(Me,lygport_outside.Service1Soap).VehicleInPark(inValue)
            Return retVal.Body.VehicleInParkResult
        End Function
    End Class
End Namespace