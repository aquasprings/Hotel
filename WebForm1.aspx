<%@ Page Title="" Language="C#" MasterPageFile="~/Booking.Master" AutoEventWireup="true" CodeBehind="WebBookingForm1.aspx.cs" Inherits="Hotel_Managment_System.WebBookingForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 306px;
    }
    .auto-style3 {
        width: 138px;
    }
    .auto-style4 {
        width: 306px;
        height: 26px;
    }
    .auto-style5 {
        width: 138px;
        height: 26px;
    }
    .auto-style6 {
        height: 26px;
    }
    .auto-style7 {
        margin-left: 326px;
    }
    .auto-style9 {
        width: 256px;
    }
    .auto-style10 {
        width: 256px;
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style2">Name</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]+$" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style2">Age</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style4">Contact Number</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style6">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="5000000000" MinimumValue="100000" ControlToValidate="TextBox4" Type="Double"></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style2">Email Id</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style2">Address</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style4">Room Category</td>
        <td class="auto-style5">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="123px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                 <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Single</asp:ListItem>
                <asp:ListItem>Double</asp:ListItem>
                <asp:ListItem>Deluxe</asp:ListItem>
            </asp:DropDownList>

              </td>
        <td class="auto-style6">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style2">Number Of Days</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
        </td>
    </tr>
</table>
<asp:Button ID="Submit" runat="server" CssClass="auto-style7" Text="Submit" Width="134px" OnClick="Button1_Click" />
</asp:Content>
