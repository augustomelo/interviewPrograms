<?php
include('Database.php');

$response = array();
$postData = file_get_contents("php://input");
$request = json_decode($postData);
$servico = $request->servico;

switch($servico) {
	case 'salvar':
		$data[request] = salvarLoja($request->tabela, $request->param);
		echo json_encode($data);
		break;
	
	case 'carregar':
		$data[request] = carregaLojas($request->tabela);
		echo json_encode($data);
		break;
	
	case 'deletar':
		$data[request] = deletarLoja($request->tabela, $request->param);
		echo json_encode($data);
		break;

	case 'logout':
		$data[request] = logout();
		echo json_encode($data);
		break;
}

/**
 * Funcao responsavel por salvar a loja no banco de dados.
 *
 * @param $tabela String Nome da tabela a ser inserida.
 * @param $valores Array Valores a serem inseridos no banco.
 *
 * @return  Id com o campo inserido ou false ou true.
 */
function salvarLoja($tabela, $valores) {
	if ($valores->id != '?') {
		$query = 'UPDATE ' . $tabela . ' SET nome = "' 
			 . $valores->nome . '" WHERE id = ' . $valores->id . ';';
	} else {
		$query = 'INSERT INTO ' . $tabela . '(nome) VALUES ("' 
			 . $valores->nome . '");';
	}

	$db = Database::getInstancia();
	$mysqli = $db->getConnection(); 
	$resultado = $mysqli->query($query);

	if($resultado && $valores->id == '?') {
		return array('id' =>  $mysqli->insert_id);
	} else if ($resultado) {
		return true;	
	} else {
		return false;
	}

}

/**
 * Funcao que retorna todos os valores da tabela lojas.
 *
 * @param $tabela String com a tabela a ser consultada.
 *
 * @return Array com o resultado da consulta.
 */
function carregaLojas($tabela) {
	$query = 'SELECT id, nome FROM ' . $tabela . ';';

	$db = Database::getInstancia();
	$mysqli = $db->getConnection(); 
	$resultado = $mysqli->query($query);


	while($row = $resultado->fetch_array(MYSQLI_ASSOC)) {
		$retorno[] = $row;
	}

	return $retorno;
}


/**
 * Funcao que deleta uma loja.
 *
 * @param $tabela String com a tabela onde ocorrera a delcao.
 * @param $valores Array Valores a ser deletado do banco.
 *
 * @return Bool true caso tenho sido deletado false caso o contrario.
 */
function deletarLoja($tabela, $valores) {
	$query = 'DELETE FROM ' . $tabela
	   	. ' WHERE id = ' . $valores->id . ';';

	$db = Database::getInstancia();
	$mysqli = $db->getConnection(); 
	$resultado = $mysqli->query($query);


	if ($resultado) {
		return true;
	}

	return false;
}

/**
 * Funcao responsavel por destruir a sessao.
 *
 * @param $usuario String com o usuario a ser removido da sessao.
 *
 * @return Bool true se usuario esta logado false caso o contrario.
 */
function logout() {
	return session_destroy ();
}

?>
