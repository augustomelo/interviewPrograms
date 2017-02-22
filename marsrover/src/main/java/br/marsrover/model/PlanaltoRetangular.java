package br.marsrover.model;

public class PlanaltoRetangular extends Planalto {

	/**
	 * Cria o planalto retangular coma posicao maxima X e Y e minima X e Y.
	 *
	 * @param maxX maximo valor X.
	 * @param maxY maximo valor Y.
	 */
	public PlanaltoRetangular (int maxX, int maxY) {
		this.MAX_X = maxX;
		this.MAX_Y = maxY;
		this.MIN_X = 0;
		this.MIN_Y = 0;
		
	}

	/**
	 * Dada uma posicao X e Y verifica se esta dentor dos limites do planalto.
	 *
	 * @param posX posicao X.
	 * @param poxY posicao Y.
	 *
	 * @return true se o elemento esta dentro dos limites, caso contrario false.
	 */
	@Override
	public boolean verificaPosicao(int posX, int posY) {
		if ((posX <= MAX_X && posX >= MIN_X) && 
			(posY <= MAX_Y && posY >= MIN_Y)) {
			return true;
		}
		
		return false;
	}
}
