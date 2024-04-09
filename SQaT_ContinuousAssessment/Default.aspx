<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQaT_ContinuousAssessment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid card p-3" style="width:24rem">
    <h1>Insurance Service</h1>
    <div class="container-fluid">
        <div class="mb-3">
            <label class="form-label" for="age">Age</label>
            <input class="form-control" name="age" type="number"/>
        </div>

        <div class="mb-3">
            <label class="form-label" for="location">Location</label>
            <div class="form-check">
                <input class="form-check-input" id="rural-radio" name="location" type="radio" value="rural"/>
                <label class="form-check-label" name="rural-radio">Rural</label>
            </div>

            <div class="form-check">
                <input class="form-check-input" id="urban-radio" name="location" type="radio" value="urban" />
                <label class="form-check-label" name="urban-radio">Urban</label>
            </div>
        </div>
        <div class="text-center">
            <button class="btn btn-primary" id="submitFormButton">Submit</button>
        </div>
    </div>
</div>

</asp:Content>
