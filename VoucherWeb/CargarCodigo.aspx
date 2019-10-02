<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargarCodigo.aspx.cs" Inherits="VoucherWeb.CargarCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<style type="text/css">
    .abs-center {
        display: flex;
        align-items: center;
        justify-content: center;
    }
    /*despues esto pasarlo a miEstilo xq no lo toma desde ahi*/
</style>

</br>
<div class="card">
    <div class="card-body" style="text-align:center">
        <h2>Cargar Codigo</h2>
        <p class="card-text" style="text-align:center" height: 400px; overflow-y: scroll;>

            <div class="abs-center">
                <div class="col-md-4 center-block" style="text-align">
                    <div class="form-group mx-sm-3 mb-2" >
                        <label for="inputCodigo" class="sr-only">Codigo</label>
                        <asp:TextBox ID="inputCodigo" runat="server"></asp:TextBox>
<%--                        <input type="text" class="form-control" id="inputCodigo" placeholder="Codigo" required runat="server">--%>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
<%--                    <button type="submit" class="btn btn-primary mb-2"   style="background-color:black"  >Validar</button>--%>
                </div>
            </div>
        </p>
    </div>


</div>

    <script type="text/javascript">
            function ShowPopup() {
                $("#btnShowPopup").click();
            }
        </script>

</asp:Content>
