<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="VoucherWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 </br>
    <% 
        foreach (var producto in producto.ListarProducto())
        {%>
<div class="card">
    <div class="card-body" style="text-align:center">
        </br>
        <h2 style="text-align:center">Elija su Premio </h2>
        </br>
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4">
                    <div class="card shadow" style="width: 21rem;">
                        <%--<asp:Image ID="Imagen1" runat="server" class="card-img-top" alt="..." src="<% =producto.Imagen%>" />--%>
                        <img src="<% =producto.Imagen%>" class="card-img-top" alt="...">
                       
                        
                        <%--<img src="https://image-cdn.hypb.st/https%3A%2F%2Fhypebeast.com%2Fimage%2F2019%2F03%2Fnike-spring-summer-earth-day-pack-info-0101.jpg?q=75&w=800&cbr=1&fit=max" class="card-img-top" alt="...">--%>
                        <div class="card-body text-center">
                            <h5 class="card-title">Nike AF1 </h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="#" class="btn btn-primary">Elegir</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card shadow" style="width: 20rem;" >
                        <img src="<% =producto.Imagen%>" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title"><%--<asp:Lebel ID="lbl_descripcion" runat="server"> </asp:Lebel>--%></h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="#" class="btn btn-primary">Elegir</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card shadow" style="width: 20rem;">
                        <img src="<% =producto[0].Imagen %>" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title">Nike Air Max 95 Plant </h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button class="btn btn-primary" ID="ElegirPremio3" runat="server" Text="Button" value="3" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
    <%} %>
</asp:Content>
