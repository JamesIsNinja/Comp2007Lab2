<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="WebApplication1.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5>All Fields Required</h5>
    <fieldset>
        <label for="txtLastName" class="col-sm-2">Last Name:</label><asp:TextBox ID="txtLastName" runat="server" required MaxLength="50" />
        </fieldset>

        <fieldset>
        <label for="txtFirstMidName"class="col-sm-2">First Name:</label><asp:TextBox ID="txtFirstMidName" runat="server" required MaxLength="50" />
        </fieldset>
            <fieldset>
        <label for="txtEnrollmentDate"class="col-sm-2">Enrollment Date:</label><asp:TextBox ID="txtEnrollmentDate" runat="server" />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Must be a d8" ControlToValidate="txtEnrollmentDate" CssClass="alert alert-danger" Type="Date" MinimumValue="01/01/2000" MaximumValue="10/23/2077"></asp:RangeValidator>
        </fieldset>
    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click"/>
</asp:Content>
