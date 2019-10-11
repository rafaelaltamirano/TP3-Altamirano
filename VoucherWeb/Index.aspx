<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="VoucherWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <STYLE> a:link {text-decoration: none;} </STYLE>
</br>
             ;
           <% int cargadoOk = Convert.ToInt32(Session["cargadoOk"]);
               if(cargadoOk== 1)
                  { %> 
                 <p class="text-success" style="text-align:center">Datos Cargador Correctamente! Gracias por Participar</p>
                 <% }%>
<div class="card">
    <div class="card-body" style="text-align:center" >
        <h5 class="card-title">Bases y condiciones</h5>
        <p class="card-text" style="text-align:center" height: 400px; overflow-y: scroll;>
            1.- La participación en la promoción  organizada por Nike Argentina S.A, con domicilio en Av. Marcelino Bernardi 18, Arroyito, Provincia de Córdoba, Argentina, en adelante “El organizador”, implica el total conocimiento y aceptación de las bases de la misma, como así también los procedimientos o sistemas establecidos por el organizador.

            2.- La vigencia y validez en el territorio de la República Argentina, excepto la provincia de Neuquén será desde el día 15/07/19 a las 12:00 hs hasta el 15/09/19 a las 18:00 hs. Solo podrán participar quienes residan en el territorio de validez de la promoción.

            3.-Productos participantes: Participan los productos que estén identificados con la promoción de las marcas:Jordar,Skeateboarding .
        </p>
    </div>


</div>
</br>
    <center>
 <asp:Button ID="BtnIndex" runat="server" Text="Participar"  class="btn btn-primary mb-2" OnClick="BtnIndex_Click" />
</center>
</asp:Content>


    