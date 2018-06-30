<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAPI.aspx.cs" Inherits="EquinitiUI.InsertAPI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2>Equiniti India Web Api</h2>
        </div>
        <div>
            <div align="center">
                <asp:Button id="btnsave" runat="server" Text="Add" OnClick="btnsave_Click" />
                <asp:Button id="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button id="btnRecord" runat="server" Text="Clear" OnClick="btnRecord_Click" />
            </div>
            <div id="DivGrid" runat="server">
                <asp:GridView ID="Grdview" runat="server" CssClass="table table-responsive">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" Text="Edit" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="UserID" />
                        <asp:BoundField DataField="ApplicationID" />
                        <asp:BoundField DataField="TypeSummary" />
                        <asp:BoundField DataField="Amount" />
                        <asp:BoundField DataField="PostingDate" />
                        <asp:BoundField DataField="Iscleared" />
                        <asp:BoundField DataField="clearedDate" />                      
                        
                    </Columns>
                </asp:GridView>
            </div>
            <div class="row" id="DivAdd" style="display:none;" runat="server" align="center">
                <asp:Label runat="server" Text="Header"></asp:Label>
                <div class="col-4">
                </div>
                <div class="col-4" style="background-color: #808080">
                    <div class="row">
                        <asp:Label ID="lblUserID" runat="server" Text="UserID"></asp:Label>
                        <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="lblApplicationID" runat="server" Text="ApplicationID"></asp:Label>
                        <asp:TextBox ID="txtApplicationID" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="type" runat="server" Text="type"></asp:Label>
                        <asp:TextBox ID="txttype" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="summary" runat="server" Text="Summary"></asp:Label>
                        <asp:TextBox ID="txtsummary" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Amount" runat="server" Text="Amount"></asp:Label>
                        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="PostingDate" runat="server" Text="PastingData"></asp:Label>
                        <asp:TextBox ID="txtPostingDate" runat="server"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Iscleared" runat="server" Text="Cleared"></asp:Label>
                        <asp:TextBox ID="txtIscleared" runat="server"></asp:TextBox>
                    </div>                
                    
                </div>
                <div class="col-lg-4">
                </div>
            </div>
        </div>
    </form>
</body>
</html>
