<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<CafeVN.Models.CoffeeBag>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CafeVN
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <!-- Main hero unit for a primary marketing message or call to action -->
      <div class="hero-unit">
        <h1>Cafe Vietnam</h1>
        <p>All the best coffee from Vietnam</p>
        <p><a class="btn btn-primary btn-large">Products &raquo;</a></p>
      </div>

      <div class="container">Welcome to the site!<br />
      <p>If you are looking for good quaity Vietnamese coffee then look no further. We have a selection of featured coffee's below or you can see our whole range in the Products section in the menu above.</p></div>
      <hr/>
      <!-- Example row of columns -->
      <div class="row">
      <% foreach (var coffeeBag in Model)
        {%>
        <div class="span4">
          <h2><%=coffeeBag.Name %></h2>
           <p><%=coffeeBag.Description %></p>
           <p>£<%=coffeeBag.Price %></p>
          <p><a class="btn" href="#">View details &raquo;</a></p>
        </div>   
        <% } %>
      </div>
</asp:Content>
