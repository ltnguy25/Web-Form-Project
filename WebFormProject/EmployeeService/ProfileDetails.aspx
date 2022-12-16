<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProfileDetails.aspx.cs" Inherits="WebFormProject.EmployeeService.ProfileDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table cellpadding="2" class="w-100">
        <tr>
            <td style="width: 147px">&nbsp;</td>
            <td style="width: 38%">&nbsp;</td>
            <td style="width: 49%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 147px; height: 34px;">
            </td>
            <td style="width: 38%; height: 34px;">
                </td>
            <td style="width: 49%; height: 34px"></td>
        </tr>
        <tr>
            <td style="width: 147px">
                <b>First Name: </b>
            </td>
            <td style="width: 38%">
                <asp:TextBox ID="txtFirstName" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width: 49%">
                    <asp:RegularExpressionValidator ID="FirstNameLengthValidator" runat="server" ControlToValidate="txtFirstName" Display="None" ErrorMessage="First Name needs to be 2-100 characters" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px; height: 34px;">
                <b>Last Name: </b>
            </td>
            <td style="height: 34px; width: 38%">
                <asp:TextBox ID="txtLastName" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="height: 34px; width: 49%;">
                    <asp:RegularExpressionValidator ID="LastNameLengthValidator" runat="server" ControlToValidate="txtLastName" Display="None" ErrorMessage="Last Name needs to be 2-100 characters" ValidationExpression="^.{2,100}$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px">
                <b>Date of Birth: </b>
            </td>
            <td style="width: 38%">
                <asp:TextBox ID="txtDOB" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width: 49%">
                    <asp:RegularExpressionValidator ID="DOBRegularExpressionValidator" runat="server" ControlToValidate="txtDOB" Display="None" ErrorMessage="Please use mm-dd-yyyy format" ValidationExpression="^(?=\d)(?:(?:(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\1|(?:(?:0?[1,3-9]|1[0-2])(\/|-|\.)(?:29|30)\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})|(?:0?2(\/|-|\.)29\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))|(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4(?:(?:1[6-9]|[2-9]\d)?\d{2}))($|\ (?=\d)))?(((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px">
                <b>Email: </b>
            </td>
            <td style="width: 38%">
                <asp:TextBox ID="txtEmail" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width: 49%">
                    <asp:RegularExpressionValidator ID="EmailFormatValidator" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="Enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px">
                <b>Phone Number: </b>
            </td>
            <td style="width: 38%">
                <asp:TextBox ID="txtPhoneNumber" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width: 49%">
                    <asp:RegularExpressionValidator ID="PhoneFormatValidator" runat="server" ControlToValidate="txtPhoneNumber" Display="None" ErrorMessage="Enter 10 digit phone number without dashes" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px">
                <b>Start Date: </b>
            </td>
            <td style="width: 38%">
                <asp:TextBox ID="txtStartDate" runat="server" Width="250px" AutoPostBack="True" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width: 49%">
                    <asp:RegularExpressionValidator ID="StartDateRegularExpressionValidator" runat="server" ControlToValidate="txtDOB" Display="None" ErrorMessage="Please use mm-dd-yyyy format" ValidationExpression="^(?=\d)(?:(?:(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\1|(?:(?:0?[1,3-9]|1[0-2])(\/|-|\.)(?:29|30)\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})|(?:0?2(\/|-|\.)29\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))|(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4(?:(?:1[6-9]|[2-9]\d)?\d{2}))($|\ (?=\d)))?(((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$"></asp:RegularExpressionValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 147px; height: 46px;">
                <asp:Button ID="btnEdit" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="btnEdit_Click" Text="Edit" />
            </td>
            <td style="width: 38%; height: 46px;">
                <asp:Button ID="btnSave" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="btnSave_Click" Text="Save" Visible="False" Width="100px" />
                <asp:Button ID="btnDelete" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="btnDelete_Click" Text="Delete" Visible="False" BackColor="Red" ForeColor="White" OnClientClick="return confirm('Are you sure you want to delete?')" Width="100px" />
            </td>
            <td style="height: 46px; width: 49%;"></td>
        </tr>
        <tr>
            <td style="width: 147px">
                &nbsp;</td>
            <td colspan="2">
                    <asp:ValidationSummary ID="ValidationErrors" runat="server" BackColor="#F2F2F2" Font-Italic="True" ForeColor="Red" />
            </td>
        </tr>
    </table>

</asp:Content>
