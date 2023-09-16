<%@ Page  Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Esercizio5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="d-flex justify-content-between flex-wrap ">

        <asp:Repeater ID="Repeater1" runat="server" ItemType="Esercizio5.Product">
            <ItemTemplate>
                <div class="card m-3" style="width: 18rem;">
                <img src="<%# Item.Photo %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%# Item.Name %></h5>
                    <p class="card-text"><%# Item.Description %></p>
                    <h5><%# Item.Price %></h5>
                    <a href="Dettaglio1?IdProduct=<%# Item.Id %>" class="btn btn-dark">Dettagli</a>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>

        </div>
    </form>

</body>
</html>
