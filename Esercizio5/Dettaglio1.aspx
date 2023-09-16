<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettaglio1.aspx.cs" Inherits="Esercizio5.Dettaglio1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <section>
     <div class="row justify-content-center">
         <div class="col-6">
             <div class="card">
                 <asp:Image ID="photo" runat="server" CssClass="card-img-top" />
                 <div class="card-body d-flex align-content-center flex-column">
                     <h5 class="card-title text-center" runat="server" id="description"></h5>
                     <div class="d-flex align-content-center flex-column">
                         <p class="card-text" runat="server" id="name"></p>
                         <p runat="server" id="price" calss="card-text text-center"></p>
                     </div>
                   

    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="Add" OnClick="ButtonAdd" />
                 </div>
             </div>
         </div>
     </div>
 </section>

</asp:Content>
