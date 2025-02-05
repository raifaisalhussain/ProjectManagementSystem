<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Evaluation.aspx.cs" Inherits="Evaluation" %>

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
			top: 140px" Text="Group" Width="121px"></asp:Label>
		 <asp:DropDownList ID="DropDownListGroup" runat="server" Style="z-index: 115; background-color:black; left: 410px; position: absolute;
			top: 140px" BackColor="Black" >   
		</asp:DropDownList>

		<asp:Label ID="Label1" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 190px" Text="Total Marks" Width="121px"></asp:Label>
		<asp:TextBox ID="txtTotalMarks" runat="server" Style="z-index: 115; background-color:black; left: 410px; position: absolute;
			top: 190px"></asp:TextBox>
		
		<asp:Label ID="Label2" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 240px" Text="Obtained Marks" Width="121px"></asp:Label>
		<asp:TextBox ID="txtObtainedMarks" runat="server" Style="z-index: 115; background-color:black; left: 410px; position: absolute;
			top: 240px"></asp:TextBox>
		
		<asp:Label ID="Label3" runat="server" Style="z-index: 114; left: 224px; position: absolute;
			top: 290px" Text="Date" Width="121px" ></asp:Label>
		<asp:TextBox ID="txtDate" runat="server" Style="z-index: 115; background-color:black; left: 410px; position: absolute;
			top: 290px"></asp:TextBox>
	
		 
		<asp:Button ID="btnManageGroup" runat="server" Style="z-index: 102;
			left: 294px; background-color:black; position: absolute; top: 400px" Text="Save" Width="121px" OnClick="btnManageGroup_Click" />
		
	
	</div>

	<div>
		<asp:Button ID="Button2" runat="server" Style="z-index: 102;
			left: 1100px; background-color:black; position: absolute; top: 600px" Text="Go to Home Page" Width="151px" OnClick="Button2_Click" />
	
	</div>
	<div>
		<asp:GridView ID="GridViewEvaluation" runat="server" Style="z-index: 102;
			left: 224px; background-color:black; position: absolute; top: 450px"></asp:GridView>
	</div>
	</form> 
	</body>
</html>



