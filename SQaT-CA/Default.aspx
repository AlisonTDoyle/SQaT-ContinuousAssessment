<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQaT_CA._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid card p-3" style="width: 24rem">
        <h1>Insurance Service</h1>
        <div class="container-fluid">
            <div class="mb-3">
                <label class="form-label" for="age">Age</label>
                <asp:TextBox runat="server" CssClass="form-control" Text="test" ID="tbxAge"/>
            </div>

            <div class="mb-3">
                <label class="form-label" for="location">Location</label>
                <div class="mb-1">
                    <asp:RadioButton ID="rbUrban" runat="server" Text="Urban" GroupName="locationGroup" />
                </div>


                <div class="mb-3">
                    <asp:RadioButton ID="rbRural" runat="server" Text="Rural" GroupName="locationGroup" />
                </div>
            </div>
            <div class="text-center">
                <asp:Button runat="server" Text="Submit" ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" OnClientClick="return false;"/>
            </div>
        </div>
    </div>

</asp:Content>
