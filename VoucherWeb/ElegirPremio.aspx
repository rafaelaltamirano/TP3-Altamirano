<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="VoucherWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
 <div class="card">
                <div class="card-body" style="text-align:center">
                    </br>
                    <h2 style="text-align:center">En hora buena! Há salido ganador!, Elija su Premio </h2>
                    </br>
                    <div class="container">
                    <div class="row justify-content-center">
    <% 
    foreach (var producto in producto.ListarProducto())
    {%>
        <div class="col-md-4">
            <div class="card shadow" style="width: 21rem;">
                <img src="<% =producto.Imagen%>" class="card-img-top" alt="...">
                   <div class="card-body text-center">
                    <h5 class="card-title"><% =producto.Titulo%> </h5>
                    <p class="card-text"><% =producto.Descripcion%></p>
                       <asp:Button ID="BtnPremio" runat="server" Text="Elegir"  class="btn btn-primary" OnClick="BtnPremio_Click"/>
  
                </div>
            </div>
        </div>
    <%} 
    %>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>