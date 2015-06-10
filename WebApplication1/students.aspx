<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="WebApplication1.students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Students</h1>
    <a href="student.aspx" >Add new student</a>
    <asp:GridView ID="Liststudents" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover"  OnRowDeleting="Liststudents_RowDeleting" DataKeyNames="StudentID">
        <Columns>
            <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="Fist Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrolled" DataFormatString="{0:MM-dd-yyyy}"/>
            <asp:CommandField HeaderText="Delete" DeleteText="Delete" ShowDeleteButton="true" />
            <asp:HyperLinkField HeaderText="Edit" Text="Edit" NavigateUrl="~/student.aspx" DataNavigateUrlFields="StudentID"
                 DataNavigateUrlFormatString="student.aspx?StudentID={0}"/>


        </Columns>

        </asp:GridView>
</asp:Content>
