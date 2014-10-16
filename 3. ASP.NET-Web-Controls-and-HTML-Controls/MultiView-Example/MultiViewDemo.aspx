<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewDemo.aspx.cs" Inherits="MultiView_Example.MultiViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>MultiView and View Controls</h2>
            <asp:DropDownList ID="DropDownList1"
                runat="server"
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <hr />
            <asp:MultiView ID="MultiView1"
                runat="server"
                ActiveViewIndex="2"
                OnActiveViewChanged="MultiView1_ActiveViewChanged">
                <asp:View ID="View1" runat="server">

                    <h3>This is view 1</h3>
                    <br />
                    <asp:Button CommandName="NextView" ID="btnnext1"
                        runat="server" Text="Go To Next" />

                    <asp:Button CommandArgument="View3"
                        CommandName="SwitchViewByID" ID="btnlast"
                        runat="server" Text="Go To Last" />
                </asp:View>
                <asp:View ID="View2" runat="server">

                    <h3>This is view 2</h3>
                    <asp:Button CommandName="NextView" ID="btnnext2"
                        runat="server" Text="Go To Next" />
                    <asp:Button CommandName="PrevView" ID="btnprevious2"
                        runat="server" Text="Go To Previous View" />
                </asp:View>
                <asp:View ID="View3" runat="server">

                    <h3>This is view 3</h3>
                    <br />
                    <asp:Calendar ID="Calender1" runat="server"></asp:Calendar>
                    <br />
                    <asp:Button CommandArgument="0"
                        CommandName="SwitchViewByIndex" ID="btnfirst"
                        runat="server" Text="Go To Next" />
                    <asp:Button CommandName="PrevView" ID="btnprevious"
                        runat="server" Text="Go To Previous View" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
