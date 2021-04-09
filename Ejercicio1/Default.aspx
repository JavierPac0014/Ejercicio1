<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Control de Alumnos</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                Nombre
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </p>
            <p>
                Apellido
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;Direccion
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </p>
            <p>
                Fecha de nacimiento<asp:Calendar ID="FechaNac" runat="server"></asp:Calendar>
            </p>
            <p>
                <strong>NOTAS:</strong></p>
            <p>
                <strong>CURSO
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Matematicas</asp:ListItem>
                    <asp:ListItem>Programacion</asp:ListItem>
                    <asp:ListItem>Electronica</asp:ListItem>
                </asp:DropDownList>
                </strong>
            </p>
            <p>
                Nota
                <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btmIngresar" runat="server" OnClick="btmIngresar_Click" Text="Ingresar notas" />
                <asp:Button ID="btmGuardar" runat="server" OnClick="btmGuardar_Click" Text="Guardar datos" />
            </p>
        </div>
    </div>

</asp:Content>
