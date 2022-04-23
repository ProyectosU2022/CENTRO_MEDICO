<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina Maestra/MasterPersonalizado.Master" AutoEventWireup="true" CodeBehind="wfHorario.aspx.cs" Inherits="CENTRO_MEDICO.Formularios.wfHorario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Identificador_Horario " Font-Names="Arial Black" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txIdentificador_Horario" runat="server" Height="27px" TextMode="Number" Width="87px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />&nbsp;&nbsp;
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Descripcion" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txDescripcion" runat="server" Height="170px" TextMode="MultiLine" Width="428px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />&nbsp;&nbsp;&nbsp;
        <br />
        <br />&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Hora_Inicio" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txHora_Inicio" runat="server" Height="27px" TextMode="Time" Width="83px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Hora_Fin" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txHora_Fin" runat="server" Height="27px" TextMode="Time" Width="83px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Receso_1" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtReceso_1" runat="server" Height="27px" TextMode="Time" Width="83px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Receso_2" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txReceso_2" runat="server" Height="27px" TextMode="Time" Width="83px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Receso_3" Font-Names="Arial Black" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txReceso_3" runat="server" Height="27px" TextMode="Time" Width="83px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Font-Names="Arial Black" ForeColor="Black" Text="Guardar" Width="90px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Font-Names="Arial Black" ForeColor="Black" Text="Eliminar" Width="90px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />&nbsp;
        </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
