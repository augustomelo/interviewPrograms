package br.marsrover.controller;

import br.marsrover.model.Erro;
import br.marsrover.model.Planalto;
import br.marsrover.model.Veiculo;

public class ControlaVeiculo {
	private Planalto planalto;
	private Veiculo veiculo;

	/**
	 * Cria um controlador com um planalto e um veiculo
	 *
	 * @param planalto planalto onde sera realizado os movimentos.
	 * @param veiculo veiculo o qual realizara a movimentacao.
	 */
	public ControlaVeiculo(Planalto planalto, Veiculo veiculo) {
		this.planalto = planalto;
		this.veiculo  = veiculo;
	}

	/**
	 * Faz com que o Rover realize a instrucao.
	 *
	 * @param instrucao instrucao.
	 * @throws Erro 
	 */
	public void executaInstrucao(char instrucao) throws Erro {
		veiculo.movimenta(instrucao);

		if(!planalto.verificaPosicao(veiculo.getPosX(), veiculo.getPosY())) {
			throw new Erro("Movimento não pertmitido!");
		}
	}

	/**
	 * Retorna a posicao do veiculo
	 *
	 * @return Uma string no seguinte formato: posX posY apotando\n.
	 */
	public String getPosicaoVeiculo() {
		return new String(
				this.veiculo.getPosX() + " " +
				this.veiculo.getPosY() + " " +
				this.veiculo.getApontando() 
			);
	}

	/**
	 * Retorna o planalto.
	 *
	 * @return planalto.
	 */
	public Planalto getPlanalto() {
		return planalto;
	}

	/**
	 * Atribui planalto
	 *
	 * @param planalto planalto a ser atribuido.
	 */
	public void setPlanalto(Planalto planalto) {
		this.planalto = planalto;
	}

	/**
	 * Retorna veiculo.
	 *
	 * @return veiculo.
	 */
	public Veiculo getVeiculo() {
		return veiculo;
	}

	/**
	 * Atribui veiculo.
	 *
	 * @param veiculo veiculo a ser atribuido.
	 */
	public void setVeiculo(Veiculo veiculo) {
		this.veiculo = veiculo;
	}
}
