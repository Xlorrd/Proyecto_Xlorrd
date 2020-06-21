<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Capa_Vista.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cp_Contenido" runat="server">
    <div>

       <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <asp:GridView ID="GridView1" runat="server" Width="264px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>

           <asp:SqlDataSource ID="proyectox" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_XlorrdConnectionString %>" SelectCommand="SELECT * FROM [Tbl_Persona]"></asp:SqlDataSource>

       
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />


           <asp:Button ID="Button1" runat="server" BackColor="#3366FF" BorderColor="#6666FF" CssClass="btn-success active" OnClick="Button1_Click" Text="Clonar Base" />


     <center> </center> 
        <br/>
            </ContentTemplate></asp:UpdatePanel>
    </div>
</asp:Content>
