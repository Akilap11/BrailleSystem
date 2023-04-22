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
           margin-left: 6px;
           margin-right: 0px;
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
            margin-left: 518px;
           margin-bottom: 0px;
           text-align: left;
       }
        .Label4{
            
            font-weight:300;
            margin-left:30px;
        }
        
       .panel5{
           background-color:#c6c6c6b6;
           border-radius:4px 4px 4px 4px;
       }
       .Label8{
           margin-left:30px;
       }
       .dropdowns{
           display: flex;
       }
      
   </style>

</head>
<body>
    <form runat="server" >
        <div class="form"> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Panel ID="Panel1" runat="server"  CssClass="panel1" Height="721px" Width="1450px" >
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel2" >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" CssClass="Sname" Font-Overline="False" Text="Braille System"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:Panel ID="Panel3" runat="server" CssClass="panel3" Height="427px" Width="508px">
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Select a Shape" Font-Size="X-Large"></asp:Label> 
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                            <asp:Label ID="Label10" runat="server" Font-Size="X-Large" Text="Select a Caracter"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<br />
                            <br />
                            <div cssclass="dropdowns">
                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" BackColor="White" CssClass="dropdown" Font-Size="12pt" Height="39px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-bottom: 7px; margin-left: 0px; margin-top: 0px;" Width="196px">
                                    <asp:ListItem>Shape</asp:ListItem>
                                    <asp:ListItem>Circle</asp:ListItem>
                                    <asp:ListItem>Triangle</asp:ListItem>
                                    <asp:ListItem>Rectangle</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" CssClass="dropdown" Font-Size="12pt" Height="39px" style="margin-top: 0px" Width="196px">
                                    <asp:ListItem>Characters</asp:ListItem>
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                    <asp:ListItem>D</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                    <asp:ListItem>H</asp:ListItem>
                                    <asp:ListItem>I</asp:ListItem>
                                    <asp:ListItem>J</asp:ListItem>
                                    <asp:ListItem>K</asp:ListItem>
                                    <asp:ListItem>L</asp:ListItem>
                                    <asp:ListItem>M</asp:ListItem>
                                    <asp:ListItem>N</asp:ListItem>
                                    <asp:ListItem>O</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>Q</asp:ListItem>
                                    <asp:ListItem>R</asp:ListItem>
                                    <asp:ListItem>S</asp:ListItem>
                                    <asp:ListItem>T</asp:ListItem>
                                    <asp:ListItem>U</asp:ListItem>
                                    <asp:ListItem>V</asp:ListItem>
                                    <asp:ListItem>W</asp:ListItem>
                                    <asp:ListItem>X</asp:ListItem>
                                    <asp:ListItem>Y</asp:ListItem>
                                    <asp:ListItem>Z</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Hight" Visible="False" Font-Size="Large"></asp:Label>
                            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="26px" style="margin-top: 0px" Visible="False" Width="66px"></asp:TextBox>
                            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropdown" Visible="False" Width="64px">
                                <asp:ListItem>px</asp:ListItem>
                                <asp:ListItem>cm</asp:ListItem>
                                <asp:ListItem>inch</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Width" Visible="False" Font-Size="Large"></asp:Label>
                            &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="26px" Visible="False" Width="66px"></asp:TextBox>
                            &nbsp;<asp:DropDownList ID="DropDownList3" runat="server" CssClass="dropdown" Visible="False" Width="64px">
                                <asp:ListItem>px</asp:ListItem>
                                <asp:ListItem>cm</asp:ListItem>
                                <asp:ListItem>inch</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                            
                            <asp:Button ID="Button1" runat="server" CssClass="button" Font-Bold="False" Font-Overline="False" OnClick="Button1_Click" Text="Submit" Width="113px" />
                            
                        </asp:Panel>
                    </asp:Panel>
                    <asp:Panel ID="Panel4" runat="server" CssClass="panel4" Height="428px" Width="928px">
                        
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server" Font-Size="Large" style="text-align: left"></asp:Label>
                            &nbsp;<br /> 
                         <br />
                        <br />
                        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                       
                      <asp:Image ID="Image2" runat="server" Height="200px" style="margin-top: 0px" Width="200px" />
                    </asp:Panel>
                    
                    <asp:Panel ID="Panel5" runat="server" Height="201px" style="margin-left: 7px; margin-top: 6px" Width="1438px" CssClass="panel5">
                        <br />
                        <asp:Label ID="Label9" runat="server" Text="History"></asp:Label>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </asp:Panel>
                </asp:Panel>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
    </form>
</body>
</html>