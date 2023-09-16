<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bogie.aspx.cs" Inherits="Esercizio5.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" CssClass="table table-bordered" AutoGenerateColumns="false" runat="server" ItemType="Esercizio5.Product" RowStyle-BackColor="Wheat" HeaderStyle-BackColor="WhiteSmoke" BorderColor="DarkBlue"/>
               <section class="mt-5 pb-4">
     <div>
         <div class="container">
             <div class="row">
                 <div class="col-8">
                     <section class="p-4 text-center w-100">
                         <div class="row row-cols-1 row-cols-md-2 row-cols-lg-3 row-cols-xl-4">
                             <asp:Repeater ID="Repeater2" runat="server" ItemType="Esercizio5.Product">
                                 <ItemTemplate>
                                     <div class="col my-3">
                                         <div class="card">
                                             <div class="">
                                                 <img src="<%#Item.Photo%>" class="card-img-top h-100">
                                             </div>
                                             <div class="card-body">
                                                 <h5 class="card-title"><%#Item.Description%> </h5>
                                                 <p class="card-text">Prezzo: <%# Item.Price %></p>
                                                 <div class="w-100">
                                                     <a class="btn btn-primary w-100" href="dettaglio1.aspx?idProduct=<%#Item.Id %>">Dettagli</a>
                                                     <asp:Button ID="rimuovi" runat="server" CssClass="btn btn-danger w-100"
                                                         Text="Elimina dal carello" CommandArgument="<%# Item.Id %>" OnClick="rimuovi_Click" />
                                                 </div>
                                             </div>
                                         </div>
                                     </div>
                                 </ItemTemplate>
                             </asp:Repeater>
                         </div>
                     </section>
                 </div>
                <div class="col-4">
                    <asp:Repeater ID="Repeater3" runat="server" ItemType="Esercizio5.Product">
                        <ItemTemplate>
                            <div class="d-flex">
                                <p><%#Item.Description%></p>
                                <span>Prezzo: € <%#Item.Price%></span>
                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
                    <div id="totCart">
                        <p>Resoconto</p>
                        <span runat="server" id="totale"></span>

                    </div>
                    <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Text="Svuota bogie" OnClick="Button1_Click" />

                </div>
            </div>
        </div>
    </div>
</section>
</asp:Content>
