App.controller('LoginController', function($rootScope, $scope, $http, md5, $state, $cookies) {

	$scope.logar = function () {
		var params = {
			servico: 'verificaUsuario',
			tabela: 'usuario',
			param : {
				usuario: $scope.login.usuario,
				senha: md5.createHash($scope.login.senha) 
			}
		};


		$http.post('php/Login.php', params).then(function (response){
			if (response.data.request) {
				$rootScope.usuario = $scope.login.usuario;
				$cookies.put('usuario', $scope.login.usuario);
				$state.go("loja");
			}
		});

		
	};

});
