<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateGroup.aspx.cs" Inherits="CreateGroup" %>

<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<title>Project Management Syetem</title>
		<meta name="keywords" content="">
		<meta name="description" content="">
		<meta http-equiv="X-UA-Compatible" content="IE=Edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		
		<link rel="stylesheet" href="css/animate.min.css">
		<link rel="stylesheet" href="css/bootstrap.min.css">
		<link rel="stylesheet" href="css/font-awesome.min.css">
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700' rel='stylesheet' type='text/css'>
		<link rel="stylesheet" href="css/templatemo-style.css">
		<script src="js/jquery.js"></script>
		<script src="js/bootstrap.min.js"></script>
		<script src="js/jquery.singlePageNav.min.js"></script>
		<script src="js/typed.js"></script>
		<script src="js/wow.min.js"></script>
		<script src="js/custom.js"></script>
	</head>
	<body id="top">
		<form runat="server">
		<div class="preloader">
			<div class="sk-spinner sk-spinner-wave">
				<div class="sk-rect1"></div>
				<div class="sk-rect2"></div>
				<div class="sk-rect3"></div>
				<div class="sk-rect4"></div>
				<div class="sk-rect5"></div>
			</div>
		</div>
 
		<nav class="navbar navbar-default templatemo-nav" role="navigation">
			<div class="container">
				<div class="navbar-header">
					<button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
						<span class="icon icon-bar"></span>
						<span class="icon icon-bar"></span>
						<span class="icon icon-bar"></span>
					</button>
					<a href="#top" class="navbar-brand">Project Management Syetem</a>
				</div>
			</div>
		</nav>

	<div>
		
		<asp:Label ID="Label7" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 140px" Text="Student 1" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListStudent1" runat="server" Style="z-index: 115; left: 410px; position: absolute;
			top: 140px" BackColor="Black" >   
		</asp:DropDownList>

		<asp:Label ID="Label4" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 190px" Text="Student 2" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListStudent2" runat="server" Style="z-index: 115; left: 410px; position: absolute;
			top: 190px" BackColor="Black" >   
		</asp:DropDownList>
		
		<asp:Label ID="Label1" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 240px" Text="Student 3" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListStudent3" runat="server" Style="z-index: 115; left: 410px; position: absolute;
			top: 240px" BackColor="Black" >   
		</asp:DropDownList>

		<asp:Label ID="Label2" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 290px" Text="Student 4" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListStudent4" runat="server" Style="z-index: 115; left: 410px; position: absolute;
			top: 290px" BackColor="Black" >   
		</asp:DropDownList>

		<h4 Style="color:silver;  z-index: 114; left: 224px; position: absolute; top: 360px">Select Project</h4>


		<asp:Label ID="Label3" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 420px" Text="Project" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListProject" runat="server" Style="z-index: 115; left: 410px; position: absolute;
			top: 420px" BackColor="Black" >   
		</asp:DropDownList>
		 
		<asp:Button ID="btnManageGroup" runat="server" Style="z-index: 102;
			left: 294px; background-color:black; position: absolute; top: 550px" Text="Apply" Width="121px" OnClick="btnManageGroup_Click1"  />
	
	</div>

	<div>
		<asp:Button ID="Button2" runat="server" Style="z-index: 102;
			left: 1100px; background-color:black; position: absolute; top: 600px" Text="Go to Home Page" Width="151px" OnClick="Button2_Click" />
	
	</div>
	</form> 
	</body>
</html>


