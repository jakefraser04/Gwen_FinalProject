<%--
*File Name: Index.aspx

*Name: Jake Fraser
*email:  fraserjk@mail.uc.edu
*Assignment Number: Final Project
*Due Date: 4/29/2025
*Course #/Section:   IS 3050 Section 002
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Connect all 4 solutions to main html page.

*Brief Description of what this module does. Using asp.net collaboratively to build a functional website 
*Citations: https://stackoverflow.com/questions/18836102/commenting-in-aspx/18836194
*Anything else that's relevant:    
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Gwen_FinalProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TheSweetEscape</title>
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container text-center">
            <h1 class="text-info">We are the Hollaback Girls!</h1>
            <h4>Team Members: Jenna Liette, Nariah Edwards, Taylor Johnson, Jake Fraser</h4>
            <asp:Button ID="cmdJL" runat="server" class="btn btn-primary" Text="Solution 312" OnClick="cmdJL_Click" />
            <asp:Button ID="cmdNE" runat="server" class="btn btn-success" Text="Solution 37" OnClick="cmdNE_Click" />
            <asp:Button ID="cmdTJ" runat="server" class="btn btn-warning" Text="Solution 85" OnClick="cmdTJ_Click" />
            <asp:Button ID="cmdJF" runat="server" class="btn btn-danger" Text="Solution 42" OnClick="cmdJF_Click" />
            <br/>
            <asp:Label ID="lblExplanation" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
