<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        </p>
        <h1 class="auto-style1">Spy New Assignment Form</h1>
        <p>
            Spy Code Name:
            <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<asp:Calendar ID="endPreviousCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="startNewCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:<asp:Calendar ID="endNewCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
    </body>
</html>
