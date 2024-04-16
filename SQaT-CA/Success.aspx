<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="SQaT_CA.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="container-fluid" style="width: 24rem">
            <div class="card">
                <div class="card-header text-bg-success p-3">
                    <h2>Success!</h2>
                </div>
                <div class="card-text p-3">
                    <p>Your premium has just been successfully calculated!</p>
                    <asp:Label runat="server">Your premium is €<%=_premium %></asp:Label>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
