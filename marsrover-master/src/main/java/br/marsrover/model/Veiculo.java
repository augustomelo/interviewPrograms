package br.marsrover.model;

/**
 * Classe responsavel por definir os atributos e metodos  basicos do veiculo.
 *
 * @author Augusto Melo <augustomelo92@gmail.com>
 */
public abstract class Veiculo {
	protected int posX;
	protected int posY;
	protected PontosCardinais apontando;

	/**
	 * Metodo responsavel por realizar o moviemento do Rover.
	 *
	 * @param Instrucao movimento a ser realizado pelo Rover.
	 * @throws Erro 
	 */
	public void movimenta(char instrucao) throws Erro {}

	/**
	 * Retorna posicao inicial X.
	 *
	 * @return posicao X.
	 */
	public int getPosX() {
		return this.posX;
	}

	/**
	 * Atribui valor da posicao X.
	 *
	 * @param posX posX a ser atribuido.
	 */
	public void setPosX(int posX) {
		this.posX = posX;
	}

	/**
	 * Retorna posicao inicial Y.
	 *
	 * @return posicao Y.
	 */
	public int getPosY() {
		return this.posY;
	}

	/**
	 * Atribui valor da posicao Y.
	 *
	 * @param posY posY a ser atribuido.
	 */
	public void setPosY(int posY) {
		this.posY = posY;
	}

	/**
	 * Retorna para onde o veiculo esta apontando.
	 *
	 * @return apontado.
	 */
	public PontosCardinais getApontando() {
		return this.apontando;
	}

	/**
	 * Atribui o valor para onde o veiculo esta apontando.
	 * 
	 * @param apontando apontando a ser atribuido.
	 */
	public void setApontando(PontosCardinais apontando) {
		this.apontando = apontando;
	}
}
