<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<CafeVN.Models.CoffeeBag>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Our Coffee</h2>
    <ul>
        <% foreach (var coffeeBag in Model) {%>
               <li><%= coffeeBag.Name %> (<%=coffeeBag.Price %>), Quantity=<%=coffeeBag.Quantity %></li>
        <%}%>
    </ul>
</asp:Content>
