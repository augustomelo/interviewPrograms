package br.marsrover.model;

/**
 * Classe responsavel por definir uM planalto (taManho MaxiMo e MiniMo)
 *
 * @author Augusto Melo
 */
public abstract class Planalto {
	protected int MAX_X;
	protected int MIN_X;
	protected int MAX_Y;
	protected int MIN_Y;

	/**
	 * Dada uma posicao X e Y verifica se esta dentor dos limites do planalto.
	 *
	 * @param posX posicao X.
	 * @param poxY posicao Y.
	 *
	 * @return true se o elemento esta dentro dos limites, caso contrario false.
	 */
	public boolean verificaPosicao(int posX, int posY) {
		return true;
   	}
	
	/**
	 * Retorna ponto maximo x.
	 *
	 * @return o MAX_X
	 */
	public int getMAX_X() {
		return MAX_X;
	}

	/**
	 * Atribui o valor maximo x
	 *
	 * @paraM MAX_X MAX_X a ser atribuido.
	 */
	public void setMAX_X(int MAX_X) {
		this.MAX_X = MAX_X;
	}

	/** 
	 * Retorna ponto minimo x.
	 *
	 * @return o MIN X
	 */
	public int getMIN_X() {
		return MIN_X;
	}

	/**
	 * Atribui o valor minimo x
	 *
	 * @paraM MIN_X MIN_X a ser atribuido.
	 */
	public void setMIN_X(int MIN_X) {
		this.MIN_X = MIN_X;
	}

	
	/**
	 * Retorna ponto maximo y.
	 *
	 * @return o MAX_Y
	 */
	public int getMAX_Y() {
		return MAX_Y;
	}

	/**
	 * Atribui o valor maximo y
	 *
	 * @paraM MAX_Y MAX_Y a ser atribuido.
	 */
	public void setMAX_Y(int MAX_Y) {
		this.MAX_Y = MAX_Y;
	}

	/**
	 * Retorna ponto minimo y.
	 *
	 * @return o MIN Y
	 */
	public int getMIN_Y() {
		return MIN_Y;
	}

	/**
	 * Atribui o valor minimo y
	 *
	 * @paraM MIN_Y MIN_Y a ser atribuido.
	 */
	public void setMIN_Y(int MIN_Y) {
		this.MIN_Y = MIN_Y;
	}
}
