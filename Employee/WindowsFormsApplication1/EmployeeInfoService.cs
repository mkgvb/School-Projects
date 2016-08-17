﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="EmployeeInfoServiceSoap", Namespace="http://www.radford.edu/fds")]
public partial class EmployeeInfoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback getEmployeeOperationCompleted;
    
    private System.Threading.SendOrPostCallback saveEmployeeOperationCompleted;
    
    private System.Threading.SendOrPostCallback getDepartmentListOperationCompleted;
    
    private System.Threading.SendOrPostCallback getEmployeeListOperationCompleted;
    
    /// <remarks/>
    public EmployeeInfoService() {
        this.Url = "http://itec-web-dev02/fds/EmployeeInfoService.asmx";
    }
    
    /// <remarks/>
    public event getEmployeeCompletedEventHandler getEmployeeCompleted;
    
    /// <remarks/>
    public event saveEmployeeCompletedEventHandler saveEmployeeCompleted;
    
    /// <remarks/>
    public event getDepartmentListCompletedEventHandler getDepartmentListCompleted;
    
    /// <remarks/>
    public event getEmployeeListCompletedEventHandler getEmployeeListCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.radford.edu/fds/getEmployee", RequestNamespace="http://www.radford.edu/fds", ResponseNamespace="http://www.radford.edu/fds", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public Employee getEmployee(string empid) {
        object[] results = this.Invoke("getEmployee", new object[] {
                    empid});
        return ((Employee)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetEmployee(string empid, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getEmployee", new object[] {
                    empid}, callback, asyncState);
    }
    
    /// <remarks/>
    public Employee EndgetEmployee(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Employee)(results[0]));
    }
    
    /// <remarks/>
    public void getEmployeeAsync(string empid) {
        this.getEmployeeAsync(empid, null);
    }
    
    /// <remarks/>
    public void getEmployeeAsync(string empid, object userState) {
        if ((this.getEmployeeOperationCompleted == null)) {
            this.getEmployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEmployeeOperationCompleted);
        }
        this.InvokeAsync("getEmployee", new object[] {
                    empid}, this.getEmployeeOperationCompleted, userState);
    }
    
    private void OngetEmployeeOperationCompleted(object arg) {
        if ((this.getEmployeeCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getEmployeeCompleted(this, new getEmployeeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.radford.edu/fds/saveEmployee", RequestNamespace="http://www.radford.edu/fds", ResponseNamespace="http://www.radford.edu/fds", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string saveEmployee(Employee myEmp) {
        object[] results = this.Invoke("saveEmployee", new object[] {
                    myEmp});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginsaveEmployee(Employee myEmp, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("saveEmployee", new object[] {
                    myEmp}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndsaveEmployee(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void saveEmployeeAsync(Employee myEmp) {
        this.saveEmployeeAsync(myEmp, null);
    }
    
    /// <remarks/>
    public void saveEmployeeAsync(Employee myEmp, object userState) {
        if ((this.saveEmployeeOperationCompleted == null)) {
            this.saveEmployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsaveEmployeeOperationCompleted);
        }
        this.InvokeAsync("saveEmployee", new object[] {
                    myEmp}, this.saveEmployeeOperationCompleted, userState);
    }
    
    private void OnsaveEmployeeOperationCompleted(object arg) {
        if ((this.saveEmployeeCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.saveEmployeeCompleted(this, new saveEmployeeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.radford.edu/fds/getDepartmentList", RequestNamespace="http://www.radford.edu/fds", ResponseNamespace="http://www.radford.edu/fds", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable getDepartmentList() {
        object[] results = this.Invoke("getDepartmentList", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetDepartmentList(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getDepartmentList", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public System.Data.DataTable EndgetDepartmentList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }
    
    /// <remarks/>
    public void getDepartmentListAsync() {
        this.getDepartmentListAsync(null);
    }
    
    /// <remarks/>
    public void getDepartmentListAsync(object userState) {
        if ((this.getDepartmentListOperationCompleted == null)) {
            this.getDepartmentListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDepartmentListOperationCompleted);
        }
        this.InvokeAsync("getDepartmentList", new object[0], this.getDepartmentListOperationCompleted, userState);
    }
    
    private void OngetDepartmentListOperationCompleted(object arg) {
        if ((this.getDepartmentListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getDepartmentListCompleted(this, new getDepartmentListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.radford.edu/fds/getEmployeeList", RequestNamespace="http://www.radford.edu/fds", ResponseNamespace="http://www.radford.edu/fds", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Data.DataTable getEmployeeList() {
        object[] results = this.Invoke("getEmployeeList", new object[0]);
        return ((System.Data.DataTable)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetEmployeeList(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getEmployeeList", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public System.Data.DataTable EndgetEmployeeList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataTable)(results[0]));
    }
    
    /// <remarks/>
    public void getEmployeeListAsync() {
        this.getEmployeeListAsync(null);
    }
    
    /// <remarks/>
    public void getEmployeeListAsync(object userState) {
        if ((this.getEmployeeListOperationCompleted == null)) {
            this.getEmployeeListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEmployeeListOperationCompleted);
        }
        this.InvokeAsync("getEmployeeList", new object[0], this.getEmployeeListOperationCompleted, userState);
    }
    
    private void OngetEmployeeListOperationCompleted(object arg) {
        if ((this.getEmployeeListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getEmployeeListCompleted(this, new getEmployeeListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.radford.edu/fds")]
public partial class Employee {
    
    private string eMPIDField;
    
    private string lnameField;
    
    private string fnameField;
    
    private string sexField;
    
    private string deptField;
    
    private string phoneField;
    
    private decimal salaryField;
    
    private string oldEMPIDField;
    
    /// <remarks/>
    public string EMPID {
        get {
            return this.eMPIDField;
        }
        set {
            this.eMPIDField = value;
        }
    }
    
    /// <remarks/>
    public string lname {
        get {
            return this.lnameField;
        }
        set {
            this.lnameField = value;
        }
    }
    
    /// <remarks/>
    public string fname {
        get {
            return this.fnameField;
        }
        set {
            this.fnameField = value;
        }
    }
    
    /// <remarks/>
    public string sex {
        get {
            return this.sexField;
        }
        set {
            this.sexField = value;
        }
    }
    
    /// <remarks/>
    public string dept {
        get {
            return this.deptField;
        }
        set {
            this.deptField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public decimal salary {
        get {
            return this.salaryField;
        }
        set {
            this.salaryField = value;
        }
    }
    
    /// <remarks/>
    public string oldEMPID {
        get {
            return this.oldEMPIDField;
        }
        set {
            this.oldEMPIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getEmployeeCompletedEventHandler(object sender, getEmployeeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getEmployeeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getEmployeeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public Employee Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Employee)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void saveEmployeeCompletedEventHandler(object sender, saveEmployeeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class saveEmployeeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal saveEmployeeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getDepartmentListCompletedEventHandler(object sender, getDepartmentListCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getDepartmentListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getDepartmentListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Data.DataTable Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getEmployeeListCompletedEventHandler(object sender, getEmployeeListCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getEmployeeListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getEmployeeListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Data.DataTable Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataTable)(this.results[0]));
        }
    }
}