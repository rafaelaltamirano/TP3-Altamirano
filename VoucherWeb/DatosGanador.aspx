<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosGanador.aspx.cs" Inherits="VoucherWeb.DatosGanador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</br>


<div class="card">
    <div class="card-body" style="text-align:center" >
        <h5 class="card-title">Ingrese sus Datos</h5>
        <p class="card-text" style="text-align:center" height: 400px; overflow-y: scroll;>
           <%--<form>--%>
              <div class="form-row">
                <div class="form-group col-md-6">
                  <label for="inputApellido">Apellido</label>
                    <asp:TextBox ID="tbApellido" runat="server" class="form-control" placeholder="Apellidos" required></asp:TextBox>
                  <%--<input type="text" class="form-control" id="inputApellido" placeholder="Apellidos">--%>
                </div>
                <div class="form-group col-md-6">
                  <label for="inputNombre">Nombre</label>
                    <asp:TextBox ID="tbNombre" runat="server" class="form-control" placeholder="Nombres" required></asp:TextBox>
                  
                </div>
              </div>
                 <div class="form-row">
                <div class="form-group col-md-6">
                  <label for="inputDni">DNI</label>
                    <asp:TextBox ID="tbDni" runat="server" class="form-control" placeholder="Sin Guiones ni Espacios" ReadOnly="true" required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                  <label for="inputEmail">Email</label>
                    <asp:TextBox ID="tbEmail" runat="server" class="form-control" placeholder="Ejemplo@mail.com" required></asp:TextBox>
                </div>
              </div>
              <div class="form-group">
                <label for="inputDireccion">Direccion</label>
                  <asp:TextBox ID="tbDireccion" runat="server" class="form-control" placeholder="1234 Main St" required></asp:TextBox>
              </div>                       
               <div class="form-row">
                <div class="form-group col-mdlong id = Convert.ToInt64(Session["idTeclado"]-6">
                  <label for="inputCiudad">Ciudad</label>
                    <asp:TextBox ID="tbCiudad" runat="server" class="form-control" placeholder="Buenso Aires" required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                  <label for="inputCodPostal">Codigo Postal</label>
                    <asp:TextBox ID="tbCodPostal" runat="server" class="form-control" placeholder="1821" required></asp:TextBox>
                </div>
              </div>
           
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptar_Click"/>
        </p>
    </div>
</div>

</asp:Content>
