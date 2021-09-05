<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alg1.aspx.cs" Inherits="TryAlg.Alg1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="Literal1" runat="server">[User參數]</asp:Literal><br />
            <asp:Label ID="Label1" runat="server" Text="歲數"></asp:Label>
            <asp:TextBox ID="txtUerAge" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="職業"></asp:Label>
            <asp:TextBox ID="txtUserJob" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label8" runat="server" Text="特殊狀態"></asp:Label>
            <asp:TextBox ID="txtUserState" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label9" runat="server" Text="要打第n劑"></asp:Label>
            <asp:TextBox ID="txtUerDoseCount" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label11" runat="server" Text="地區"></asp:Label>
            <asp:TextBox ID="txtUerArea" runat="server"></asp:TextBox><br />


            <br />
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="====================="></asp:Label><br />
            <asp:Literal ID="Literal2" runat="server">[演算法參數]</asp:Literal><br />
            <asp:Label ID="Label2" runat="server" Text="目標年齡-底" TextMode="Number"></asp:Label>
            <asp:TextBox ID="txt_age_targetAgeButtom" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="目標年齡-頂" TextMode="Number"></asp:Label>
            <asp:TextBox ID="txt_age_targetAgeTop" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="小的先/老的先(0/1)" ></asp:Label>
            <asp:TextBox ID="txt_age_direction" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label10" runat="server" Text="讓要打第n劑的先" TextMode="Number"></asp:Label>
            <asp:TextBox ID="txt_ordinal" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="Label13" runat="server" Text="地區"></asp:Label>
            <asp:TextBox ID="txt_area" runat="server"></asp:TextBox><br />



            <br /><asp:Label ID="Label6" runat="server" Text="====================="></asp:Label><br />
        </div>
        <asp:Button ID="btnCoculate" runat="server" Text="演算" OnClick="btnCoculate_Click" />
        <br />
        <asp:Literal ID="ltShow" runat="server"></asp:Literal>
    </form>
</body>
</html>
