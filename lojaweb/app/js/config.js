App.config(function($stateProvider, $urlRouterProvider){
	$urlRouterProvider.otherwise("/login");


	$stateProvider
		.state("login", {
			url: "/login",
			templateUrl: "app/view/login.html",
			controller: "LoginController"
		})
		.state("loja", {
			url: "/loja", 
			templateUrl: "app/view/loja.html",
			controller: "LojaController"
		});


});
