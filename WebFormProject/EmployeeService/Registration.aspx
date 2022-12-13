<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebFormProject.EmployeeService.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup>
        <h2><%: Page.Title %></h2>
    </hgroup>
    <div>

        <table class="w-100">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTitle" runat="server" Font-Size="Large" Text="Enter new employee info below" Font-Bold="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 36px; width: 200px">
                    <asp:Label ID="lblEmployeeFirstName" runat="server" Font-Size="Medium" Text="First Name" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%; height: 36px">
                    <asp:TextBox ID="txtFirstName" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="FirstNameRequiredValidator" runat="server" ControlToValidate="txtFirstName" Display="None" ErrorMessage="First Name Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="FirstNameLengthValidator" runat="server" ControlToValidate="txtFirstName" Display="None" ErrorMessage="First Name needs to be 2-100 characters" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 200px">
                    <asp:Label ID="lblEmployeeLastName" runat="server" Font-Size="Medium" Text="Last Name" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%">
                    <asp:TextBox ID="txtLastName" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="LastNameRequiredValidator" runat="server" ControlToValidate="txtLastName" Display="None" ErrorMessage="Last Name Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="LastNameLengthValidator" runat="server" ControlToValidate="txtLastName" Display="None" ErrorMessage="Last Name needs to be 2-100 characters" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 200px">
                    <asp:Label ID="lblEmployeeDOB" runat="server" Font-Size="Medium" Text="Date of Birth" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%">
                    <asp:TextBox ID="txtDOB" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DOBRequiredValidator" runat="server" ControlToValidate="txtDOB" Display="None" ErrorMessage="Date of Birth Required"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="DOBTypeValidator" runat="server" ControlToValidate="txtDOB" Display="None" ErrorMessage="Use mm/dd/yyyy format" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 36px; width: 200px">
                    <asp:Label ID="lblEmployeeEmail" runat="server" Font-Size="Medium" Text="Email" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%; height: 36px">
                    <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequiredValidator" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailFormatValidator" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="Enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 200px">
                    <asp:Label ID="lblEmployeePhone" runat="server" Font-Size="Medium" Text="Phone Number" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%">
                    <asp:TextBox ID="txtPhone" runat="server" Width="250px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="PhoneFormatValidator" runat="server" ControlToValidate="txtPhone" Display="None" ErrorMessage="Enter 10 digit phone number without dashes" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 200px">
                    <asp:Label ID="lblEmployeeStartDate" runat="server" Font-Size="Medium" Text="Start Date" Width="200px"></asp:Label>
                </td>
                <td style="width: 83%">
                    <asp:TextBox ID="txtStartDate" runat="server" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="StartDateRequiredValidator" runat="server" ControlToValidate="txtStartDate" Display="None" ErrorMessage="Start Date Required"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="StartDateTypeValidator" runat="server" ControlToValidate="txtStartDate" Display="None" ErrorMessage="Use mm/dd/yyyy format" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 200px">&nbsp;</td>
                <td style="width: 83%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 200px">&nbsp;</td>
                <td style="width: 83%">
                    <asp:Button ID="btnSave" runat="server" Font-Bold="True" Font-Size="Medium" Text="Save" OnClick="btnSave_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationErrors" runat="server" BackColor="#F2F2F2" Font-Italic="True" ForeColor="Red" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
