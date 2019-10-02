<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosGanador.aspx.cs" Inherits="VoucherWeb.DatosGanador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</br>





<div class="card">
    <div class="card-body" style="text-align:center" >
        <h5 class="card-title">Ingrese sus Datos</h5>
        <p class="card-text" style="text-align:center" height: 400px; overflow-y: scroll;>
            <form>
              <div class="form-row">
                <div class="form-group col-md-6">
                  <label for="inputApellido">Apellido</label>
                  <input type="text" class="form-control" id="inputApellido" placeholder="Apellidos">
                </div>
                <div class="form-group col-md-6">
                  <label for="inputNombre">Nombre</label>
                  <input type="text" class="form-control" id="inputNombre" placeholder="Nombres">
                </div>
              </div>
                 <div class="form-row">
                <div class="form-group col-md-6">
                  <label for="inputDni">DNI</label>
                  <input type="text" class="form-control" id="inputDni" placeholder="Sin Guiones ni Espacios">
                </div>
                <div class="form-group col-md-6">
                  <label for="inputEmail">Email</label>
                  <input type="text" class="form-control" id="inputEmail" placeholder="Ejemplo@mail.com">
                </div>
              </div>
              <div class="form-group">
                <label for="inputAddress">Direccion</label>
                <input type="text" class="form-control" id="inputDireccion" placeholder="1234 Main St">
              </div>                       
               <div class="form-row">
                <div class="form-group col-md-6">
                  <label for="inputApellido">Ciudad</label>
                  <input type="text" class="form-control" id="inputCiudad" placeholder="Buenos Aires">
                </div>
                <div class="form-group col-md-6">
                  <label for="inputNombre">Codigo Postal</label>
                  <input type="text" class="form-control" id="inputCodPostal" placeholder="1821">
                </div>
              </div>
                <asp:Button ID="Registrar" runat="server" Text="Button" OnClick="Registrar_Click" />
            </form>
        </p>
    </div>
</div>

</asp:Content>
