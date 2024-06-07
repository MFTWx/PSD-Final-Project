<%@ Page Title="User Profile" Language="C#" MasterPageFile="~/Views/partial/BaseUser.Master" AutoEventWireup="true" CodeBehind="CustomerProfile.aspx.cs" Inherits="ProjectPSD.Views.Customer.customer_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .full-height {
        height: 100vh;
    }
</style>

<div class="container full-height d-flex align-items-center justify-content-center">
    <div class="row w-100">
        <div class="col-md-8 offset-md-2">
            <div class="card mb-3">
                <div class="card-body">
                    <h6 class="mb-2 text-primary">Personal Information</h6>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="username">Username</label>
                                <input type="text" class="form-control" id="username" placeholder="Enter username">
                            </div>
                            <div class="form-group mb-3">
                                <label for="email">Email</label>
                                <input type="email" class="form-control" id="email" placeholder="Enter email">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="gender">Gender</label>
                                <select class="form-select" id="gender">
                                    <option value="">Select Gender</option>
                                    <option value="female">Female</option>
                                    <option value="male">Male</option>
                                    <option value="other">Other</option>
                                </select>
                            </div>
                            <div class="form-group mb-3">
                                <label for="dob">Date of Birth</label>
                                <input type="date" class="form-control" id="dob">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="card mb-3">
                <div class="card-body">
                    <h6 class="mb-2 text-primary">Update Information</h6>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="username">Username</label>
                                <input type="text" class="form-control" id="username" placeholder="Enter username">
                            </div>
                            <div class="form-group mb-3">
                                <label for="email">Email</label>
                                <input type="email" class="form-control" id="email" placeholder="Enter email">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group mb-3">
                                <label for="gender">Gender</label>
                                <select class="form-select" id="gender">
                                    <option value="">Select Gender</option>
                                    <option value="female">Female</option>
                                    <option value="male">Male</option>
                                    <option value="other">Other</option>
                                </select>
                            </div>
                            <div class="form-group mb-3">
                                <label for="dob">Date of Birth</label>
                                <input type="date" class="form-control" id="dob">
                            </div>
                        </div>
                    </div>
                    <div class="text-center">
                        <button type="button" id="submit" name="submit" class="btn btn-secondary me-2">Cancel</button>
                        <button type="button" id="submit" name="submit" class="btn btn-primary">Update</button>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-body">
                    <h6 class="mb-2 text-primary">Reset Password</h6>
                    <div class="form-group mb-3">
                        <label for="old_password">Old Password</label>
                        <asp:TextBox ID="old_password" class="form-control" TextMode="Password" placeholder="Enter old password" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label for="new_password">New Password</label>
                        <asp:TextBox ID="new_password" class="form-control" TextMode="Password" placeholder="Enter new password" runat="server"></asp:TextBox>
                    </div>
                    <div class="text-center">
                        <asp:Button ID="password_reset"  class="btn btn-outline-danger" runat="server" Text="Reset" OnClick="password_reset_Click"/>
                    </div>
                    <div class="text-danger mt-3">
                        <asp:Label ID="error_lbl" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



</asp:Content>
