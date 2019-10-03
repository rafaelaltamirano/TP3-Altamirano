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

<br/>
<div class="card">
    <div class="card-body" style="text-align:center">
      
        <h2>Ingrese el Código de su Voucher</h2>
        <p class="card-text" style="text-align:center" height: 400px; overflow-y: scroll;>
           
            <div class="abs-center">
                <div class="col-md-4 center-block" style="text-align">
                    <div class="form-group mx-sm-3 mb-2" >
                        <asp:Label ID="Label1" for="inputCodigo" runat="server" Text="Label" class="sr-only">Codigo</asp:Label>
                     
                        <asp:TextBox ID="inputCodigo" runat="server" class="form-control"  placeholder="Codigo" required></asp:TextBox>
                    </div>
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary mb-2"   Text="Validar" OnClick="Button1_Click" />
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
