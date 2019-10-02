<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="VoucherWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 </br>

<div class="card">
    <div class="card-body" style="text-align:center">
        </br>
        <h2 style="text-align:center">Elija su Premio </h2>
        </br>
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4">
                    <div class="card shadow" style="width: 21rem;">
                        <img src="https://image-cdn.hypb.st/https%3A%2F%2Fhypebeast.com%2Fimage%2F2019%2F03%2Fnike-spring-summer-earth-day-pack-info-0101.jpg?q=75&w=800&cbr=1&fit=max" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title">Nike AF1 </h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="#" class="btn btn-primary">Elegir</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card shadow" style="width: 20rem;" >
                        <img src="http://www.pictoupresbytery.ca/images/Shoes/Wholesale-Mens-Nike-SpringSummer-2019-Nike-Air-Max-1-Blue.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title"><%--<asp:Lebel ID="lbl_descripcion" runat="server"> </asp:Lebel>--%></h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="#" class="btn btn-primary">Elegir</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card shadow" style="width: 20rem;">
                        <img src="https://sneakernews.com/wp-content/uploads/2019/04/nike-air-max-95-plant-color-sustainability-CD7142-700-2.jpg" class="card-img-top" alt="...">
                        <div class="card-body text-center">
                            <h5 class="card-title">Nike Air Max 95 Plant </h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button ID="ElegirPremio3" runat="server" Text="Button" value="3" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
