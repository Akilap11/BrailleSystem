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
           border-radius:4px;
           text-align:center;
           margin-left: 0px;
           margin-top: 0px;
           margin-bottom: 0px;
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
           margin-left: 8px;
           margin-right: 636px;
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
            margin-left: 509px;
           margin-right: 118px;
           margin-top: 0px;
       }
        .Label4{
            
            font-weight:300;
            
        }
        .panel5{
            background-color:#c6c6c6b6;
            border-radius:4px 4px 4px 4px;
        }
        .Label8{
            font-size:medium;
            color:aliceblue;
        }
        
   </style>

</head>
<body>
    <form runat="server" >
        <div class="form"> 
                <asp:Panel ID="Panel1" runat="server"  CssClass="panel1" Height="659px" Width="1130px" >
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel2" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" CssClass="Sname" Font-Overline="False" Text="Braille System"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:Panel ID="Panel3" runat="server" CssClass="panel3" Height="335px" Width="497px">
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Select a Shape"></asp:Label>
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
                    <asp:Panel ID="Panel4" runat="server" CssClass="panel4" Height="335px" Width="611px">
                        <asp:Label ID="Label8" runat="server" Text="" ></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server" Font-Size="Large"></asp:Label>
                        <br />
                        <br />
                        <asp:Image ID="Image2" runat="server" Height="268px" style="margin-top: 0px" Width="483px" />
                    </asp:Panel>
                    <asp:Panel ID="Panel5" runat="server" Height="224px" style="margin-left: 8px; margin-top: 2px" Width="1112px" CssClass="panel5">
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    </asp:Panel>
                    <br />
                </asp:Panel>
                </div>
    </form>
</body>
</html>
