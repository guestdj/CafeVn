﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<CafeVN.Models.CoffeeBag>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CafeVN
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <!-- Main hero unit for a primary marketing message or call to action -->
      <div class="hero-unit">
        <h1>Cafe Vietnam</h1>
        <p>This is a brief into ...</p>
        <p><a class="btn btn-primary btn-large">Products &raquo;</a></p>
      </div>

      <!-- Example row of columns -->
      <div class="row">
      <% foreach (var coffeeBag in Model)
        {%>
        <div class="span4">
          <h2><%=coffeeBag.Name %></h2>
           <p><%=coffeeBag.Description %></p>
           <p><%=coffeeBag.Price %></p>
          <p><a class="btn" href="#">View details &raquo;</a></p>
        </div>   
        <% } %>
      </div>
</asp:Content>
