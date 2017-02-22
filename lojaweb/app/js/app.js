var App = angular.module('App', [
	'ui.router',
	'angular-md5',
	'ngCookies'
]);

App.run(function($rootScope, $state, $http, $location, $cookies) {
	$rootScope.$on('$stateChangeStart', function(event, toState, toStateParams) {
		//Se a rota não for de login, então verifica se o usuario esta logado.
		if(toState.url != "/login" ) {
			if (!$rootScope.usuario) {
				var usuario = $cookies.get('usuario');
				if(usuario != undefined) {
					$http.post('php/Login.php', {'usuario': usuario}).then(function (response){
						$rootScope.usuario = usuario;
					});
				} else {
					event.preventDefault(); 
					$state.go("login");
				}
			}

		}   
	});
			
});
