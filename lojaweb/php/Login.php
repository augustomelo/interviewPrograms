<?php
include('Database.php');

$response = array();
$postData = file_get_contents("php://input");
$request = json_decode($postData);
$servico = $request->servico;

switch($servico) {
	case 'verificaUsuario':
		$data[request] = verificaUsuario($request->param);
		echo json_encode($data);
		break;
	
	case 'verificaLogin':
		$data[request] = verificaLogin($usuario->usuario);
		echo json_encode($data);
		break;
}

/**
 * Funcao responsavel por verificar se o usuario esta cadastrado no banco.
 *
 * @param $where Array com a informacao do usuario.
 *
 * @return Bool true se castrado false caso o contrario.
 */
function verificaUsuario($where) {
	$query = 'SELECT usuario FROM usuario WHERE usuario = "'
		. $where->usuario . '" AND senha = "' . $where->senha . '"';

	$db = Database::getInstancia();
	$mysqli = $db->getConnection(); 
	$resultado = $mysqli->query($query);

	if($resultado->num_rows == 1) {
		session_start();
		$_SESSION['usuario'] = $valor->usuario;
		return true;
	}

	return false;

}

/**
 * Funcao responsavel por verifica se o usuario esta logado.
 *
 * @param $usuario String com o usuario a ser verificado.
 *
 * @return Bool true se usuario esta logado false caso o contrario.
 */
function verificaLogin($usuario) {
	if($_SESSION['usuario'] == $usuario)	 {
		return true;
	} else {
		return false;
	}
}

?>
