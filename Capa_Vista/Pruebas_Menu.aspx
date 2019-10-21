<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeBehind="Pruebas_Menu.aspx.cs" Inherits="Capa_Vista.Pruebas_Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cp_Contenido" runat="server">


    <div>

        <asp:GridView ID="GridView1" runat="server" Width="264px"></asp:GridView>

     <center> <asp:Button ID="Button1" runat="server" BackColor="#3366FF" BorderColor="#6666FF" CssClass="btn-success active" OnClick="Button1_Click" Text="Clonar Base" /> </center> 
        <br/>

    </div>
</asp:Content>