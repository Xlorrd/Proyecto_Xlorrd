<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeBehind="Pruebas_Menu.aspx.cs" Inherits="Capa_Vista.Pruebas_Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cp_Contenido" runat="server">


    <div>

       <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <asp:GridView ID="GridView1" runat="server" Width="264px"></asp:GridView>

           <asp:Repeater ID="Repeater1" runat="server" DataSourceID="proyectox">
           </asp:Repeater>
           <asp:SqlDataSource ID="proyectox" runat="server" ConnectionString="<%$ ConnectionStrings:Proyecto_XlorrdConnectionString %>" SelectCommand="SELECT * FROM [Tbl_Persona]"></asp:SqlDataSource>

        <asp:Timer ID="Timer1" runat="server" EnableViewState="False" Interval="100" OnTick="Timer1_Tick">
        </asp:Timer>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />


           <asp:Button ID="Button1" runat="server" BackColor="#3366FF" BorderColor="#6666FF" CssClass="btn-success active" OnClick="Button1_Click" Text="Clonar Base" />


     <center> </center> 
        <br/>
            </ContentTemplate></asp:UpdatePanel>
    </div>
</asp:Content>