<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preview.aspx.cs" Inherits="QuestionBank.Preview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>---- Question Paper Preview ----</h1>
            </center>
            <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
            <br />
            <asp:Repeater ID="rptPreviewQuestions" runat="server" >
                <ItemTemplate>
                    <b><p>Q. <%# Eval("Question") %></p></b>
                    <p>A. <%# Eval("OptionA") %></p>
                    <p>B. <%# Eval("OptionB") %></p>
                    <p>C. <%# Eval("OptionC") %></p>
                    <p>D. <%# Eval("OptionD") %></p><br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
