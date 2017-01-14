<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="a2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 2</title>
    <link rel="stylesheet" href="css.css">
    
</head>
<body>
   
    <h1>Your Calendar</h1>
    <form id="form1" runat="server">

        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="DateChanged"></asp:Calendar>
        <asp:Label ID="MessageLabel" runat="server" Text="Select A Date To View Events" ></asp:Label><br/>
       
    </form>
       
</body>
</html>
