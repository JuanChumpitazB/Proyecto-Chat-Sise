//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appWEB.ServiceReferenceLoguear {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLoguear.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usu del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoguearUsuario", ReplyAction="*")]
        appWEB.ServiceReferenceLoguear.LoguearUsuarioResponse LoguearUsuario(appWEB.ServiceReferenceLoguear.LoguearUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usu del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExisteUsuario", ReplyAction="*")]
        appWEB.ServiceReferenceLoguear.ExisteUsuarioResponse ExisteUsuario(appWEB.ServiceReferenceLoguear.ExisteUsuarioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usu del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DesencriptarContraseña", ReplyAction="*")]
        appWEB.ServiceReferenceLoguear.DesencriptarContraseñaResponse DesencriptarContraseña(appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usu del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DevuelveCodUsuLogueado", ReplyAction="*")]
        appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoResponse DevuelveCodUsuLogueado(appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DevuelveCodUsu", ReplyAction="*")]
        int DevuelveCodUsu(int codEmpleado);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoguearUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoguearUsuario", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.LoguearUsuarioRequestBody Body;
        
        public LoguearUsuarioRequest() {
        }
        
        public LoguearUsuarioRequest(appWEB.ServiceReferenceLoguear.LoguearUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoguearUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usu;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contra;
        
        public LoguearUsuarioRequestBody() {
        }
        
        public LoguearUsuarioRequestBody(string usu, string contra) {
            this.usu = usu;
            this.contra = contra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoguearUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoguearUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.LoguearUsuarioResponseBody Body;
        
        public LoguearUsuarioResponse() {
        }
        
        public LoguearUsuarioResponse(appWEB.ServiceReferenceLoguear.LoguearUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoguearUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoguearUsuarioResult;
        
        public LoguearUsuarioResponseBody() {
        }
        
        public LoguearUsuarioResponseBody(bool LoguearUsuarioResult) {
            this.LoguearUsuarioResult = LoguearUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExisteUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExisteUsuario", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.ExisteUsuarioRequestBody Body;
        
        public ExisteUsuarioRequest() {
        }
        
        public ExisteUsuarioRequest(appWEB.ServiceReferenceLoguear.ExisteUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExisteUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usu;
        
        public ExisteUsuarioRequestBody() {
        }
        
        public ExisteUsuarioRequestBody(string usu) {
            this.usu = usu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExisteUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExisteUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.ExisteUsuarioResponseBody Body;
        
        public ExisteUsuarioResponse() {
        }
        
        public ExisteUsuarioResponse(appWEB.ServiceReferenceLoguear.ExisteUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExisteUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ExisteUsuarioResult;
        
        public ExisteUsuarioResponseBody() {
        }
        
        public ExisteUsuarioResponseBody(bool ExisteUsuarioResult) {
            this.ExisteUsuarioResult = ExisteUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesencriptarContraseñaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesencriptarContraseña", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequestBody Body;
        
        public DesencriptarContraseñaRequest() {
        }
        
        public DesencriptarContraseñaRequest(appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesencriptarContraseñaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int codUsu;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string usu;
        
        public DesencriptarContraseñaRequestBody() {
        }
        
        public DesencriptarContraseñaRequestBody(int codUsu, string usu) {
            this.codUsu = codUsu;
            this.usu = usu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesencriptarContraseñaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesencriptarContraseñaResponse", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.DesencriptarContraseñaResponseBody Body;
        
        public DesencriptarContraseñaResponse() {
        }
        
        public DesencriptarContraseñaResponse(appWEB.ServiceReferenceLoguear.DesencriptarContraseñaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesencriptarContraseñaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DesencriptarContraseñaResult;
        
        public DesencriptarContraseñaResponseBody() {
        }
        
        public DesencriptarContraseñaResponseBody(string DesencriptarContraseñaResult) {
            this.DesencriptarContraseñaResult = DesencriptarContraseñaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevuelveCodUsuLogueadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DevuelveCodUsuLogueado", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequestBody Body;
        
        public DevuelveCodUsuLogueadoRequest() {
        }
        
        public DevuelveCodUsuLogueadoRequest(appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DevuelveCodUsuLogueadoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usu;
        
        public DevuelveCodUsuLogueadoRequestBody() {
        }
        
        public DevuelveCodUsuLogueadoRequestBody(string usu) {
            this.usu = usu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevuelveCodUsuLogueadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DevuelveCodUsuLogueadoResponse", Namespace="http://tempuri.org/", Order=0)]
        public appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoResponseBody Body;
        
        public DevuelveCodUsuLogueadoResponse() {
        }
        
        public DevuelveCodUsuLogueadoResponse(appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DevuelveCodUsuLogueadoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DevuelveCodUsuLogueadoResult;
        
        public DevuelveCodUsuLogueadoResponseBody() {
        }
        
        public DevuelveCodUsuLogueadoResponseBody(int DevuelveCodUsuLogueadoResult) {
            this.DevuelveCodUsuLogueadoResult = DevuelveCodUsuLogueadoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : appWEB.ServiceReferenceLoguear.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<appWEB.ServiceReferenceLoguear.WebServiceSoap>, appWEB.ServiceReferenceLoguear.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        appWEB.ServiceReferenceLoguear.LoguearUsuarioResponse appWEB.ServiceReferenceLoguear.WebServiceSoap.LoguearUsuario(appWEB.ServiceReferenceLoguear.LoguearUsuarioRequest request) {
            return base.Channel.LoguearUsuario(request);
        }
        
        public bool LoguearUsuario(string usu, string contra) {
            appWEB.ServiceReferenceLoguear.LoguearUsuarioRequest inValue = new appWEB.ServiceReferenceLoguear.LoguearUsuarioRequest();
            inValue.Body = new appWEB.ServiceReferenceLoguear.LoguearUsuarioRequestBody();
            inValue.Body.usu = usu;
            inValue.Body.contra = contra;
            appWEB.ServiceReferenceLoguear.LoguearUsuarioResponse retVal = ((appWEB.ServiceReferenceLoguear.WebServiceSoap)(this)).LoguearUsuario(inValue);
            return retVal.Body.LoguearUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        appWEB.ServiceReferenceLoguear.ExisteUsuarioResponse appWEB.ServiceReferenceLoguear.WebServiceSoap.ExisteUsuario(appWEB.ServiceReferenceLoguear.ExisteUsuarioRequest request) {
            return base.Channel.ExisteUsuario(request);
        }
        
        public bool ExisteUsuario(string usu) {
            appWEB.ServiceReferenceLoguear.ExisteUsuarioRequest inValue = new appWEB.ServiceReferenceLoguear.ExisteUsuarioRequest();
            inValue.Body = new appWEB.ServiceReferenceLoguear.ExisteUsuarioRequestBody();
            inValue.Body.usu = usu;
            appWEB.ServiceReferenceLoguear.ExisteUsuarioResponse retVal = ((appWEB.ServiceReferenceLoguear.WebServiceSoap)(this)).ExisteUsuario(inValue);
            return retVal.Body.ExisteUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        appWEB.ServiceReferenceLoguear.DesencriptarContraseñaResponse appWEB.ServiceReferenceLoguear.WebServiceSoap.DesencriptarContraseña(appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequest request) {
            return base.Channel.DesencriptarContraseña(request);
        }
        
        public string DesencriptarContraseña(int codUsu, string usu) {
            appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequest inValue = new appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequest();
            inValue.Body = new appWEB.ServiceReferenceLoguear.DesencriptarContraseñaRequestBody();
            inValue.Body.codUsu = codUsu;
            inValue.Body.usu = usu;
            appWEB.ServiceReferenceLoguear.DesencriptarContraseñaResponse retVal = ((appWEB.ServiceReferenceLoguear.WebServiceSoap)(this)).DesencriptarContraseña(inValue);
            return retVal.Body.DesencriptarContraseñaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoResponse appWEB.ServiceReferenceLoguear.WebServiceSoap.DevuelveCodUsuLogueado(appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequest request) {
            return base.Channel.DevuelveCodUsuLogueado(request);
        }
        
        public int DevuelveCodUsuLogueado(string usu) {
            appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequest inValue = new appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequest();
            inValue.Body = new appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoRequestBody();
            inValue.Body.usu = usu;
            appWEB.ServiceReferenceLoguear.DevuelveCodUsuLogueadoResponse retVal = ((appWEB.ServiceReferenceLoguear.WebServiceSoap)(this)).DevuelveCodUsuLogueado(inValue);
            return retVal.Body.DevuelveCodUsuLogueadoResult;
        }
        
        public int DevuelveCodUsu(int codEmpleado) {
            return base.Channel.DevuelveCodUsu(codEmpleado);
        }
    }
}
