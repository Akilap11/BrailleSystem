<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Interface.aspx.cs" Inherits="BrailleSystem.Interface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style type="text/css">
       .form{
           left:50%;
       }
       .panel1{
           background-color:#7d7d7d;
           Height:423px;
           Width:750px;
           border-radius:4px;
           text-align:center;

           style="margin-left: 21px; margin-top: 0px; margin-bottom: 21px"  Wrap="False"
       }
       .Sname{
           font-weight:300;
           font-size:36px;
           color:#ffffff;
           
       }
       .panel2{
            background-color:#323232;
            text-align: center;
            border-radius:4px 4px 0px 0px;
            Height:80px;
       }
       .panel3{
           text-align:left;
           background-color:#c6c6c6b6;
           margin-bottom: 0px;
           font-size:20px;
           border-radius:0px 0px 4px 4px;
           margin-left: 10px;
           margin-right: 427px;
           margin-top: 20px;
       }
       .button{
           color:black;
           background-color:#25c12c;
           Height:38px;
           Width:113px;
           border-radius:5px 5px;
           border:none;
           cursor: pointer;
           box-shadow: 0 6px 8px 0 rgb(0, 0, 0, 0.20),0 8px 25px 0 rgba(0,0,0,0.15);
       }
           .button:hover {
               box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
               background-color:#29d630;
           }
        .textbox{
            border-radius:5px;
            border:none;
            box-shadow:inset 0px 0px 10px 0px #dbdbdb;
        }
        .dropdown{
             box-shadow:inset 0px 0px 15px 0px #dbdbdb;
             border-radius:4px;
        }
        .lable2{
            font-weight: 300;
        }
        .panel4{
            background-color:#c6c6c6b6;
            border-radius:0px 0px 4px 4px;
            Height:330px;
            Width:411px;
            margin-left: 329px; 
        }
   </style>
    <script>
        function drawShapeInBraille() {
            // Get the selected shape from the dropdown list
            var shape = document.getElementById("shape").value;

            // Create a new XMLHttpRequest object to invoke the web service
            var xmlhttp = new XMLHttpRequest();

            // Define the URL for the web service
            var url = "http://localhost:12345/BrailleService.asmx/DrawShapeInBraille?shape=" + shape;

            // Define the callback function to handle the web service response
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    // Update the label control with the Braille dots
                    document.getElementById("brailleLabel").innerHTML = xmlhttp.responseText;
                }
            }

            // Send the web service request
            xmlhttp.open("GET", url, true);
            xmlhttp.send();
        }

    </script>
</head>
<body>
    <form runat="server" >
        <div class="form"> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Panel ID="Panel1" runat="server"  CssClass="panel1" >
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel2" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" CssClass="Sname" Font-Overline="False" Text="Braille System"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:Panel ID="Panel3" runat="server" CssClass="panel3" Height="330px">
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Select a Shaph"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" BackColor="White" CssClass="dropdown" Font-Size="12pt" Height="25px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-bottom: 7px" Width="210px">
                                <asp:ListItem>Select</asp:ListItem>
                                <asp:ListItem>Circle</asp:ListItem>
                                <asp:ListItem>Triangle</asp:ListItem>
                                <asp:ListItem>Rectangle</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text="Hight" Visible="False"></asp:Label>
                            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="26px" style="margin-top: 0px" Visible="False" Width="66px"></asp:TextBox>
                            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropdown" Visible="False" Width="64px">
                                <asp:ListItem>px</asp:ListItem>
                                <asp:ListItem>cm</asp:ListItem>
                                <asp:ListItem>inch</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Width" Visible="False"></asp:Label>
                            &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="26px" Visible="False" Width="66px"></asp:TextBox>
                            &nbsp;<asp:DropDownList ID="DropDownList3" runat="server" CssClass="dropdown" Visible="False" Width="64px">
                                <asp:ListItem>px</asp:ListItem>
                                <asp:ListItem>cm</asp:ListItem>
                                <asp:ListItem>inch</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" CssClass="button" Font-Bold="False" Font-Overline="False" OnClick="Button1_Click" Text="Submit" Width="113px" />
                        </asp:Panel>
                    </asp:Panel>
                    <asp:Panel ID="Panel4" runat="server" CssClass="panel4">
                    </asp:Panel>
                    <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:Panel>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
    </form>
</body>
</html>
