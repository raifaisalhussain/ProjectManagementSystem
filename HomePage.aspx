<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
				<div class="collapse navbar-collapse">
					<ul class="nav navbar-nav navbar-right">
						<li><a href="#top">HOME</a></li>
						<li><a href="#admin">ADMIN</a></li>
						<li><a href="#student">STUDENT</a></li>
					</ul>
				</div>
			</div>
		</nav>

		<section id="home">
			<div class="container">
				<div class="row">
					<div class="col-md-offset-2 col-md-8">
						<h1 class="wow fadeIn" data-wow-offset="50" data-wow-delay="0.6s"><span>WELCOME</span></h1>
						<div class="element">
							<div class="sub-element">Hello, Click Admin for Management.</div>
							<div class="sub-element">Click, Student for Project Registration</div>
						</div>
						<a href="#admin" class="btn btn-default wow fadeInUp" data-wow-offset="50" data-wow-delay="0.9s">ADMIN</a>
						<a href="#student" class="btn btn-default wow fadeInUp" data-wow-offset="50" data-wow-delay="0.9s">STUDENT</a>
					</div>
				</div>
			</div>
		</section>

		<section id="admin">
			<div class="container">
				<div class="row">
					<div class="col-md-12">
						 <br />
						 <br />
						 <br />
						<h2 class="wow bounceIn" data-wow-offset="50" data-wow-delay="0.3s"><span>ADMIN</span></h2>
					</div>
					<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInLeft" data-wow-offset="50" data-wow-delay="0.6s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Manage Projects</h3>
							</div>
							<div class="media-body">
								<p>Here You can Add new projects.provious projects can also be deleted from here</p>
								<br />
								<asp:Button ID="btnAddProject" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Add Project" OnClick="btnAddProject_Click" />
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInUp" data-wow-offset="50" data-wow-delay="0.9s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Manage Students</h3>
							</div>
							<div class="media-body">
								<p>New Students added from here and the studends whose project is completed can be removed from the system from here </p>
								<br />
								<asp:Button ID="btnAddStudent" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Add Student" OnClick="btnAddStudent_Click1" />
							</div>
						</div>
					</div>
					<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInRight" data-wow-offset="50" data-wow-delay="0.6s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Manage Advisors</h3>
							</div>
							<div class="media-body">
								<p>Three type of advisors are selected for each project at its begining. Types are main advisor, co-advisor, and industry advisor.</p>
								<br />
								<asp:Button ID="btnAddAdvisor" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Add Advisor" OnClick="btnAddAdvisor_Click" />
							</div>
						</div>
					</div>
				</div>
				<br />
				<br />

				<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInLeft" data-wow-offset="50" data-wow-delay="0.6s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Manage Student Groups</h3>
							</div>
							<div class="media-body">
								<p>Student make their groups from student section and they select their project from the list given. From here you can assign each group advisors.</p>
								<br />
								<asp:Button ID="btnManageGroup" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Manage Group" OnClick="btnManageGroup_Click" />
							</div>
						</div>
					</div>
					
					<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInRight" data-wow-offset="50" data-wow-delay="0.6s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Create Reports</h3>
							</div>
							<div class="media-body">
								<p>Reports of List of projects along with advisory board and list of students.Marks sheet of projects that shows the marks in each evaluation against each student and project.</p>
								<br />
								<asp:Button ID="btnCreateReport" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Reports" OnClick="btnCreateReport_Click" />
							</div>
						</div>
					</div>
				   <div class="col-md-4 col-sm-4 col-xs-12 wow fadeInUp" data-wow-offset="50" data-wow-delay="0.9s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Manage Evaluations</h3>
							</div>
							<div class="media-body">
								<p>Evaluations against a group is done here for each task given to group.</p>
								<br />
								<asp:Button ID="btnManageEvaluation" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Evaluate" OnClick="btnManageEvaluation_Click" />
							</div>
						</div>
					</div>

			</div>
		</section>
			 <br />
						 <br />
						 <br />
						 <br />
						 <br />
						 <br />
			 <br />
						 <br />
						 <br />
						 <br />
						 <br />
						 <br />
	
		
		<section id="student">
			<div class="container">
				<div class="row">
					<div class="col-md-12">
						<h2 class="wow bounceIn" data-wow-offset="50" data-wow-delay="0.3s"><span>STUDENT</span></h2>
					</div>
					<div class="col-md-4 col-sm-4 col-xs-12 wow fadeInLeft" data-wow-offset="50" data-wow-delay="0.6s">
						<div class="media">
							<div class="media-heading-wrapper">
								<h3 class="media-heading">Group Creation</h3>
							</div>
							<div class="media-body">
								<p>Click below button to make group of student of 4 and select your project and submit for approval.</p>
								<br />
								<asp:Button ID="btnCreateGroup" runat="server" class="btn btn-default wow fadeInUp" data-wow-offset="50" Text="Make Group" OnClick="btnCreateGroup_Click" />
							</div>
						</div>
					</div>
				</div>
			</div>
		</section>
	 <br />
						 <br />
						 <br />
						 <br />
						 <br />
						 <br />
			 <br />
						 <br />
						 <br />
						 <br />
						 <br />
						 <br />
	
		
		<footer id="copyright">
			<div class="container">
				<div class="row">
					<div class="col-md-12 text-center">
						<p class="wow bounceIn" data-wow-offset="50" data-wow-delay="0.3s">
						THANKS</p>
					</div>
				</div>
			</div>
		</footer>
	</form>

	</body>
</html>
