<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="GUI.Trangchu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="ftco-section">
			<div class="container">
				<div class="row no-gutters ftco-services">
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate fadeInUp ftco-animated">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-1 active d-flex justify-content-center align-items-center mb-2">
            		<asp:Label runat="server" class="flaticon-shipped"></asp:Label>
              </div>
              <div class="media-body">
                <h3 class="heading">Free Shipping</h3>
                <asp:Label runat="server">On order over $100</asp:Label>
              </div>
            </div>      
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate fadeInUp ftco-animated">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-2 d-flex justify-content-center align-items-center mb-2">
            		<asp:Label runat="server" class="flaticon-diet"></asp:Label>
              </div>
              <div class="media-body">
                <h3 class="heading">Always Fresh</h3>
                <asp:Label runat="server">Product well package</asp:Label>
              </div>
            </div>    
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate fadeInUp ftco-animated">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-3 d-flex justify-content-center align-items-center mb-2">
            		<asp:Label runat="server" class="flaticon-award"></asp:Label>
              </div>
              <div class="media-body">
                <h3 class="heading">Superior Quality</h3>
                <asp:Label runat="server">Quality Products</asp:Label>
              </div>
            </div>      
          </div>
          <div class="col-md-3 text-center d-flex align-self-stretch ftco-animate fadeInUp ftco-animated">
            <div class="media block-6 services mb-md-0 mb-4">
              <div class="icon bg-color-4 d-flex justify-content-center align-items-center mb-2">
            		<asp:Label runat="server" class="flaticon-customer-service"></asp:Label>
              </div>
              <div class="media-body">
                <h3 class="heading">Support</h3>
                <asp:Label runat="server">24/7 Support</asp:Label>
              </div>
            </div>      
          </div>
        </div>
			</div>
		</section>
    <!--Hien thi anh san pham-->
    <div class="row">
					<div class="col-md-8">
						<div class="row">
							<div class="col-md-6 order-md-last align-items-stretch d-flex">
								<div class="category-wrap-2 ftco-animate img align-self-stretch d-flex fadeInUp ftco-animated" style="background-image: url(images/category.jpg);">
									<div class="text text-center">
										<h2>Vegetables</h2>
										<p>Protect the health of every home</p>
										<p><asp:Hyperlink runat="server" href="#" class="btn btn-primary">Shop now</asp:Hyperlink></p>
									</div>
								</div>
							</div>
							<div class="col-md-6">
								<div class="category-wrap ftco-animate img mb-4 d-flex align-items-end fadeInUp ftco-animated" style="background-image: url(images/category-1.jpg);">
									<div class="text px-3 py-1">
										<h2 class="mb-0"><asp:Hyperlink runat="server" href="#">Fruits</asp:Hyperlink></h2>
									</div>
								</div>
								<div class="category-wrap ftco-animate img d-flex align-items-end fadeInUp ftco-animated" style="background-image: url(images/category-2.jpg);">
									<div class="text px-3 py-1">
										<h2 class="mb-0"><asp:Hyperlink runat="server" href="#">Vegetables</asp:Hyperlink></h2>
									</div>
								</div>
							</div>
						</div>
					</div>

					<div class="col-md-4">
						<div class="category-wrap ftco-animate img mb-4 d-flex align-items-end fadeInUp ftco-animated" style="background-image: url(images/category-3.jpg);">
							<div class="text px-3 py-1">
								<h2 class="mb-0"><asp:Hyperlink runat="server" href="#">Juices</asp:Hyperlink></h2>
							</div>		
						</div>
						<div class="category-wrap ftco-animate img d-flex align-items-end fadeInUp ftco-animated" style="background-image: url(images/category-4.jpg);">
							<div class="text px-3 py-1">
								<h2 class="mb-0"><asp:Hyperlink runat="server" href="#">Dried</asp:Hyperlink></h2>
							</div>
						</div>
					</div>
				</div>
    <!--Ket thuc hien thi anh san pham-->
</asp:Content>
