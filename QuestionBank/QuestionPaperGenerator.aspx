<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionPaperGenerator.aspx.cs" Inherits="QuestionBank.QuestionPaperGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <center>
                <h1>---- Generate Question Paper ----</h1>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
                </center>
            <asp:Panel ID="pnlQuestions" runat="server" Visible="false">
                <asp:Repeater ID="rptQuestions" runat="server">
                    <ItemTemplate>
                        <b><p>Q. <%# Eval("question") %></p></b>
                        <p>A. <%# Eval("optionA") %></p>
                        <p>B. <%# Eval("optionB") %></p>
                        <p>C. <%# Eval("optionC") %></p>
                        <p>D. <%# Eval("optionD") %></p><br />
                    </ItemTemplate>
                </asp:Repeater>
                <center>
                <asp:Button ID="btnPreview" runat="server" Text="Preview" OnClick="btnPreview_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </center>
            </asp:Panel>
          
        </div>
    </form>
</body>
</html>
