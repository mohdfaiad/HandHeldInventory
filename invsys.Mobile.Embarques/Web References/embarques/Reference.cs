﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5485.
// 
namespace invsys.Mobile.Embarques.embarques {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSPedidosSoap", Namespace="http://localhost/")]
    public partial class WSPedidos : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public WSPedidos() {
            this.Url = "http://10.10.3.5:81/WSPedidos.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/Test", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Test() {
            object[] results = this.Invoke("Test", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginTest(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Test", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndTest(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/GetParameter", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetParameter(string sFiltro, int IdCon) {
            object[] results = this.Invoke("GetParameter", new object[] {
                        sFiltro,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetParameter(string sFiltro, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetParameter", new object[] {
                        sFiltro,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetParameter(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/GetValues", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetValues(int MinValue, int MaxValue, int IdCon) {
            object[] results = this.Invoke("GetValues", new object[] {
                        MinValue,
                        MaxValue,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetValues(int MinValue, int MaxValue, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetValues", new object[] {
                        MinValue,
                        MaxValue,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetValues(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/GetFiltro", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetFiltro(int IdCon) {
            object[] results = this.Invoke("GetFiltro", new object[] {
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFiltro(int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFiltro", new object[] {
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetFiltro(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/GetInventory", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetInventory(string sFiltro, int IdCon) {
            object[] results = this.Invoke("GetInventory", new object[] {
                        sFiltro,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetInventory(string sFiltro, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetInventory", new object[] {
                        sFiltro,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/InsertEmbarque", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet InsertEmbarque(EmbarqueEntity parametro, int IdCon) {
            object[] results = this.Invoke("InsertEmbarque", new object[] {
                        parametro,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginInsertEmbarque(EmbarqueEntity parametro, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("InsertEmbarque", new object[] {
                        parametro,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndInsertEmbarque(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/InsertEmbarque_Detalle", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet InsertEmbarque_Detalle(Embarque_DetalleEntity parametro, int IdCon) {
            object[] results = this.Invoke("InsertEmbarque_Detalle", new object[] {
                        parametro,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginInsertEmbarque_Detalle(Embarque_DetalleEntity parametro, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("InsertEmbarque_Detalle", new object[] {
                        parametro,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndInsertEmbarque_Detalle(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/InsertInventory", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet InsertInventory(InventarioEntity parametro, int IdCon) {
            object[] results = this.Invoke("InsertInventory", new object[] {
                        parametro,
                        IdCon});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginInsertInventory(InventarioEntity parametro, int IdCon, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("InsertInventory", new object[] {
                        parametro,
                        IdCon}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndInsertInventory(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/GetEmpresas", RequestNamespace="http://localhost/", ResponseNamespace="http://localhost/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetEmpresas() {
            object[] results = this.Invoke("GetEmpresas", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetEmpresas(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetEmpresas", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetEmpresas(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/")]
    public partial class EmbarqueEntity {
        
        private int idEmbarqueField;
        
        private string descripcionField;
        
        private string cbField;
        
        private System.DateTime fechaAltaField;
        
        private decimal pesoField;
        
        private int idUsuarioField;
        
        /// <remarks/>
        public int IdEmbarque {
            get {
                return this.idEmbarqueField;
            }
            set {
                this.idEmbarqueField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        public string CB {
            get {
                return this.cbField;
            }
            set {
                this.cbField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime FechaAlta {
            get {
                return this.fechaAltaField;
            }
            set {
                this.fechaAltaField = value;
            }
        }
        
        /// <remarks/>
        public decimal Peso {
            get {
                return this.pesoField;
            }
            set {
                this.pesoField = value;
            }
        }
        
        /// <remarks/>
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/")]
    public partial class InventarioEntity {
        
        private int idInventarioServerField;
        
        private string codigoArticuloField;
        
        private int cantidadField;
        
        private string medidaField;
        
        private string almacenField;
        
        private string loteField;
        
        private string longitudField;
        
        private string normaField;
        
        private string espesorField;
        
        private string descripcionField;
        
        private string ubicacionField;
        
        private int idUsuarioField;
        
        /// <remarks/>
        public int IdInventarioServer {
            get {
                return this.idInventarioServerField;
            }
            set {
                this.idInventarioServerField = value;
            }
        }
        
        /// <remarks/>
        public string CodigoArticulo {
            get {
                return this.codigoArticuloField;
            }
            set {
                this.codigoArticuloField = value;
            }
        }
        
        /// <remarks/>
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }
        
        /// <remarks/>
        public string Medida {
            get {
                return this.medidaField;
            }
            set {
                this.medidaField = value;
            }
        }
        
        /// <remarks/>
        public string Almacen {
            get {
                return this.almacenField;
            }
            set {
                this.almacenField = value;
            }
        }
        
        /// <remarks/>
        public string Lote {
            get {
                return this.loteField;
            }
            set {
                this.loteField = value;
            }
        }
        
        /// <remarks/>
        public string Longitud {
            get {
                return this.longitudField;
            }
            set {
                this.longitudField = value;
            }
        }
        
        /// <remarks/>
        public string Norma {
            get {
                return this.normaField;
            }
            set {
                this.normaField = value;
            }
        }
        
        /// <remarks/>
        public string Espesor {
            get {
                return this.espesorField;
            }
            set {
                this.espesorField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        public string Ubicacion {
            get {
                return this.ubicacionField;
            }
            set {
                this.ubicacionField = value;
            }
        }
        
        /// <remarks/>
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/")]
    public partial class Embarque_DetalleEntity {
        
        private int idEmbarqueField;
        
        private int idSalidaDatosAllField;
        
        private decimal pesoField;
        
        private System.DateTime fechaAltaField;
        
        /// <remarks/>
        public int IdEmbarque {
            get {
                return this.idEmbarqueField;
            }
            set {
                this.idEmbarqueField = value;
            }
        }
        
        /// <remarks/>
        public int IdSalidaDatosAll {
            get {
                return this.idSalidaDatosAllField;
            }
            set {
                this.idSalidaDatosAllField = value;
            }
        }
        
        /// <remarks/>
        public decimal Peso {
            get {
                return this.pesoField;
            }
            set {
                this.pesoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime FechaAlta {
            get {
                return this.fechaAltaField;
            }
            set {
                this.fechaAltaField = value;
            }
        }
    }
}
