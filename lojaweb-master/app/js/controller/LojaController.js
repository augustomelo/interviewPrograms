App.controller('LojaController', function($rootScope, $scope, $http, md5, $cookies, $state) {
	$scope.lojas = []; 
	$scope.edicao = {};  

	$scope.modifica = function(campo, index) {
		if($scope.edicao[campo.index]) {
			$scope.salva(index);
		}

		$scope.edicao[campo.index] = !$scope.edicao[campo.index];
	};


	$scope.adicionarVal = function() {
		$scope.inserido = {
			index: ($scope.lojas.length + 1),
			id: '?',
			nome: 'Nova Loja',
		};

		$scope.edicao[$scope.inserido.index] = true;
		$scope.lojas.push($scope.inserido);
	};


	$scope.logout = function() {
		
		var params = {
			servico: 'logout',
		};

		$http.post('php/Loja.php', params).then(function(response) {
			$cookies.remove('usuario');
			delete $rootScope.usuario;

			$state.go("login");
		});
	}

	$scope.deleta = function(loja, index) {
		var params = {
			servico: 'deletar',
			tabela: 'loja',
			param: {
				id: loja.id
			}
		};

		$http.post('php/Loja.php', params).then(function(response) {
			if (response.data.request) {
				$scope.lojas.splice(index, 1);
				delete $scope.edicao[loja.index];
				
				alert("Registro deletado com sucesso!");
			} else {
				alert("Houve algum problema na deleção do registro!");
			}
		}, function() {
			alert("Houve algum problema na deleção do registro!");
		});
	};

	$scope.salva = function(index) {
		var params = {
			servico: 'salvar',
			tabela: 'loja',
			param: {
				id: $scope.lojas[index].id,
				nome: $scope.lojas[index].nome
			}
		};
		
		$http.post('php/Loja.php', params).then(function(response) {
			if(response.data.request.id) {
				alert('Loja cadastrada com sucesso!');
				$scope.lojas[index].id = response.data.request.id;
			} else if (response.data.request) {
				alert('Loja atualizada com sucesso!');
			} else {
				alert('Houve algum problema na inserção');
			}
		}, function(){
			alert('Houve algum problema na inserção!');

		});
	};


	$scope.carregaRegistros = function() {
		var params = {
			servico: 'carregar',
			tabela: 'loja',
		};

		$http.post('php/Loja.php', params).then(function(response) {
			$scope.lojas = response.data.request;

			// Faz com que os campos da tabela seja editaveis
			for (var i = 0; i < $scope.lojas.length; i++) {
				$scope.lojas[i].index = i;
				$scope.edicao[i] = false;
			}

		});
	};


	$scope.carregaRegistros();
});

