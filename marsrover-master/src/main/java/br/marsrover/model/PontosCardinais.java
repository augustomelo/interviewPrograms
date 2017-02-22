package br.marsrover.model;

/**
 * Classe responsavel por controlar em qual direcao o Veiculo esta indo.
 *
 * @author Augusto Melo
 */
public enum PontosCardinais {
	W, N, E, S;

	/**
	 * Metodo que pega o ponto cardinal a direita.
	 */
	public PontosCardinais proximo() { 
		return values()[modulo(ordinal() + 1, values().length)];
	}

	/**
	 * Metodo que pega o ponto cardinal a esquerda.
	 */
	public PontosCardinais anterior() {
		return values()[modulo(ordinal() - 1, values().length)];
	}

	/**
	 * Realiza o modulo, de numeros positivos e negativos.
	 *
	 * @param numero Numero o qual sera feito o modulo.
	 * @param modulo Divisor.
	 *
	 * @return Inteiro com o resultado da operacao.
	 */
	private int modulo(int numero, int modulo) {
		return ((numero % modulo) + modulo)  % modulo;
	}
}
