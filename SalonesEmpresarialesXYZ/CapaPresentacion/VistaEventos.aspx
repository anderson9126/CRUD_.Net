<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="VistaEventos.aspx.cs" Inherits="CapaPresentacion.VistaEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="js/VistaEventos.js" type="text/javascript"></script>
    

    <section class="content-header">
        <h1 align="center">Eventos Confirmados</h1>
    </section>
    
    <section class="content">
        <div class="row">
            <div class="row box box-danger">
                <div class="col-md-12">
                    <asp:PlaceHolder ID="panel1" runat="server"></asp:PlaceHolder>                   
                </div>
               
            </div>
        </div>
    </section>

</asp:Content>
