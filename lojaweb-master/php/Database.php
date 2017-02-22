<?php
class Database {
	private $conn;
	private static $instancia; 
	private $host = "localhost";
	private $usuario = "root";
	private $psw = "123";
	private $database = "lojaweb";

	/**
	 * Faz com que exista somente uma instancia do banco de dados
 	 */
	public static function getInstancia() {
		if(!self::$instancia) { 
			self::$instancia = new self();
		}

		return self::$instancia;
	}

	/**
	 * Construtor
	 */
	private function __construct() {
		$this->connection = new mysqli($this->host, $this->usuario, $this->psw, $this->database);
	
		if(mysqli_connect_error()) {
			trigger_error("Falha ao conectar, erro: " . mysql_connect_error(), E_USER_ERROR);
		}
	}

	/**
	 * Devolve conexao
	 */
	public function getConnection() {
		return $this->connection;
	}
}
?>
