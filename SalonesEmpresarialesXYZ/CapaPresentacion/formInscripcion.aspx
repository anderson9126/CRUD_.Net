<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="formInscripcion.aspx.cs" Inherits="CapaPresentacion.PanelCentro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="js/FormInscripcion.js" type="text/javascript"></script>
    
    <section class="content-header">
        <h1 align="center">INGRESO CLIENTE</h1>
    </section>
    <section class="content">
        <asp:TextBox ID="idCliente" runat="server" Text="" required="required" CssClass="form-control id_cliente" type="hidden"></asp:TextBox>
        <div class="row">
            <div class="row box box-danger">
                <div class="col-md-6 form-group">
                    <label>Cedula:</label>
                    <asp:TextBox ID="txtCedula" runat="server" Text="" required="required" CssClass="form-control cedula"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Nombre y Apellido:</label>
                    <asp:TextBox ID="txtNombreApellido" runat="server" Text="" required="required" CssClass="form-control nombre"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Telefono:</label>
                    <asp:TextBox ID="txtTelefono" runat="server" Text="" required="required" CssClass="form-control telefono"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Correo:</label>
                    <asp:TextBox ID="txtEmail" runat="server" Text="" required="required" CssClass="form-control email"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Departamento:</label>
                    <asp:TextBox ID="txtDepartamento" runat="server" Text="" required="required" CssClass="form-control depa"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Ciudad:</label>
                    <asp:TextBox ID="txtCiudad" runat="server" Text="" required="required" CssClass="form-control ciudad"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Edad:</label>
                    <asp:DropDownList ID="ddlEdad" runat="server" required="required" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
        </div>
        
        <div align="center">
            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />
            <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-danger" Text="Editar" OnClick="btnEditar_Click"  />
        </div>
    </section>

   

</asp:Content>
