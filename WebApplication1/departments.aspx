<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="departments.aspx.cs" Inherits="WebApplication1.departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h1>Departments</h1>
    <a href="department.aspx" >Add a new department</a>
    <asp:GridView ID="ListDepartments" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover"  OnRowDeleting="Departments_RowDeleting" DataKeyNames="DepartmentID">
        <Columns>

             <asp:BoundField DataField="DepartmentID" HeaderText="Departments ID" />
             <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="Budget" HeaderText="Budget" DataFormatString="{0:C}"/>
            <asp:CommandField HeaderText="Delete" DeleteText="Delete" ShowDeleteButton="true" />
            <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/department.aspx" DataNavigateUrlFields="DepartmentID"
                 DataNavigateUrlFormatString="department.aspx?DepartmentID={0}"/>
            </Columns>
                </asp:GridView>

</asp:Content>
