<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="formEvento.aspx.cs" Inherits="CapaPresentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="content-header">
        <h1 align="center">INGRESO EVENTO</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="row box box-danger">
                <div class="col-md-6 form-group">
                    <label>Cliente:</label>
                    <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                
                <div class="col-md-6 form-group">
                    <label>Cantidad de Personas:</label>
                    <asp:TextBox ID="txtpersonas" runat="server" Text="" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Motivo:</label>
                    <asp:DropDownList runat="server" ID="ddlMotivo" required="required" CssClass="form-control">
                        <asp:ListItem Text="Evento empresarial" Value="Evento empresarial"></asp:ListItem>
                        <asp:ListItem Text="Despedida empresa" Value="Despedida empresa"></asp:ListItem>
                        <asp:ListItem Text="Desayuno Comercial" Value="Desayuno Comercial"></asp:ListItem>
                        <asp:ListItem Text="Almuerzo" Value="Almuerzo"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                
                <div class="col-md-6 form-group">
                    <label>Estado:</label>
                  <asp:DropDownList runat="server" ID="Estado" required="required" CssClass="form-control">
                        <asp:ListItem Text="Confirmado" Value="Confirmado"></asp:ListItem>
                        <asp:ListItem Text="No Confirmado" Value="No Confirmado"></asp:ListItem>
                    </asp:DropDownList>  
                </div>
                
                <div class="col-md-6  form-group">
                    <label>fecha evento:</label>
                    <asp:TextBox ID="fechaEvento" required="required" runat="server" TextMode="Date"  CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-6 form-group">
                    <label>Observaciones:</label>
                    <asp:TextBox ID="observacion" TextMode="multiline" Columns="30" Rows="5" runat="server" required="required" CssClass="form-control" />
                </div>
            </div>
        </div>
        
           <div align="center">
            <asp:Button ID="btnRegistrarEvento" runat="server" CssClass="btn btn-primary" Text="Registrar Evento" OnClick="btnRegistrarEvento_Click" />
        </div>    
    </section>

</asp:Content>
