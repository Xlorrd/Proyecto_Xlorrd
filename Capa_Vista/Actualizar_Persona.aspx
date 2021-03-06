﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeBehind="Actualizar_Persona.aspx.cs" Inherits="Capa_Vista.Actualizar_Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cp_Contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager> <asp:UpdatePanel ID="UpdatePanel1" runat="server">   
          <ContentTemplate>
          

              <div class="row">
          <div class="col-md-8">
            <div class="card">
              <div class="card-header">
                <h5 class="title">Actualizar</h5>
              </div>
              <div class="card-body">
                
                 
                  <div class="row">
                    <div class="col-md-6 pr-md-1">
                      <div class="form-group">
                        <label>Nombres</label>
                          <asp:TextBox ID="txt_nombre" class="form-control" placeholder="Nombres" runat="server"></asp:TextBox>
                      </div>
                    </div>
                    <div class="col-md-6 pl-md-1">
                      <div class="form-group">
                        <label>Apellidos</label>
                         <asp:TextBox ID="txt_apellido" class="form-control" placeholder="Apellidos" runat="server"></asp:TextBox>
                      </div>
                    </div>
                  </div>
                      <div class="row">
                    <div class="col-md-6 pr-md-1">
                      <div class="form-group">
                        <label>Cédula</label>
                          <asp:TextBox ID="txt_cedula" class="form-control"  placeholder="Cédula" runat="server"></asp:TextBox>
                      </div>
                    </div>

                    <div class="col-md-6 pl-md-1">
                      <div class="form-group">
                        <label>Correo</label>
                         <asp:TextBox ID="txt_correo" class="form-control"  placeholder="Correo" runat="server"></asp:TextBox>
                      </div>
                    </div>
                  </div>
                     <div class="row">
                    <div class="col-md-6 pr-md-1">
                      <div class="form-group">
                        <label>Fecha Nacimiento</label>
                          <asp:TextBox ID="txt_fch_nacimiento" class="form-control"  placeholder="Fecha Nacimiento" runat="server"></asp:TextBox>
                      </div>
                    </div>

                    
                  </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                        <label>Dirección</label>
                         <asp:TextBox ID="txt_direccion" class="form-control" placeholder="Dirección" runat="server"></asp:TextBox>
                      </div>
                    </div>
                  </div>
                
                
              </div>
              <div class="card-footer">
                  <asp:Button ID="btn_guardar" class="btn btn-fill btn-primary"  runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
                  <asp:Button ID="Button1" class="btn btn-fill btn-primary"  runat="server" OnClick="Button1_Click" Text="Guardar nuevo Usuario" />
                  &nbsp;
                  </div>
            </div>
          </div>
          <div class="col-md-4">
            <div class="card card-user">
              <div class="card-body">
                <p class="card-text">
                  <div class="author">
                    <div class="block block-one"></div>
                    <div class="block block-two"></div>
                    <div class="block block-three"></div>
                    <div class="block block-four"></div>
                    <a href="javascript:void(0)">
                     <img class="avatar" src="../assets/img/emilyz.jpg" alt="...">
                           <asp:Image class="avatar" ID="img_persona" runat="server" />
                      <h5 class="title">Mike Andrew</h5>
                    </a>              
                          &nbsp;Do not be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...&nbsp;Do not be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
                  </div>                  
                      </div>
                         </div>                     
                              </div>                     
                                </div>                     
                                  </div>                  
                 </ContentTemplate>
              </asp:UpdatePanel>              
</asp:Content>
