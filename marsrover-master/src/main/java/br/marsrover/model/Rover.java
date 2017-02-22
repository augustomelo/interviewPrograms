package br.marsrover.model;

import br.marsrover.model.Erro;

/**
 * Classe responsavel por definir um Rover e seus movimentos.
 *
 * @author Augusto Melo
 */
public class Rover extends Veiculo {
	/**
	 * Cria um rover com uma posicao inicial e paraonde esta apontando
	 *
	 * @param posX posicao inicial X.
	 * @param posY posicao inicial Y.
	 * @param apontando para onde o rover esta apontando.
	 */
	public Rover(int posX, int posY, String apontando) {
		this.posX      = posX;
		this.posY      = posY;
		this.apontando = PontosCardinais.valueOf(apontando.toUpperCase());
	}

	/**
	 * Metodo responsavel por realizar o moviemento do Rover.
	 *
	 * @param Instrucao movimento a ser realizado pelo Rover.
	 * @throws Erro 
	 */
	@Override
	public void movimenta(char instrucao) throws Erro {
		switch (Character.toLowerCase(instrucao)) {
			case 'l':
				this.movEsq();
				break;
			case 'r':
				this.movDir();
				break;
			case 'm':
				try {
					this.movAvanca();
				} catch (Erro e) {
					e.printStackTrace();
				}
				break;
			default:
				throw new Erro("Movimento nao existente");
		}
	}

	/**
	 * Realiza o movimento para esquerda do Rover.
	 */
	private void movEsq() {
		this.apontando = this.apontando.anterior();
	}

	/**
	 * Realiza o movimento para direita do Rover.
	 */
	private void movDir() {
		this.apontando = this.apontando.proximo();
	}

	/**
	 * Avanca o Rover para onde esta apontando.
	 * @throws Erro 
	 */
	private void movAvanca() throws Erro {
		switch(this.apontando.name()){
			case "W":
				this.posX -= 1;
				break;
			case "N":
				this.posY += 1;
				break;
			case "E":
				this.posX += 1;
				break;
			case "S":	
				this.posY -= 1;
				break;
			default:
				throw new Erro("Movimento nao existente");
		}
	}
}
