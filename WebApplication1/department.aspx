<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="WebApplication1.department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5>All Fields Required</h5>
    <fieldset>
        <label for="txtDepName" class="col-sm-2">Department:</label><asp:TextBox ID="txtDepartmentName" runat="server" required MaxLength="50" />
        </fieldset>
        <fieldset>

        <label for="txtBudget"class="col-sm-2">Budget:</label><asp:TextBox ID="txtBudget" runat="server" required MaxLength="50" />
        </fieldset>
            <fieldset>
           <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Must be a value" ControlToValidate="txtBudget" 
               CssClass="alert alert-danger" Type="Currency" MinimumValue="0.01" MaximumValue="9999999999.99"></asp:RangeValidator>
        
            </fieldset>
    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click"/>
</asp:Content>
