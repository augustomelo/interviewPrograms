package br.marsrover.controller;

import br.marsrover.model.Erro;
import br.marsrover.model.PlanaltoRetangular;
import br.marsrover.model.Rover;

/**
 * Classe responsavel por controlar a entrada do programa.
 * 
 * @author Augusto Melo
 */
public class ControlaEntrada {
	private String entrada;
	private StringBuilder saida;
	
	/**
	 * Cria um controlador entrada com uma string.
	 * 
	 * @param entrada Entrada fornecida pelo usuario.
	 */
	public ControlaEntrada (String entrada) {
		this.entrada = entrada;
		this.saida   = new StringBuilder("");
	}
	
	
	/**
	 * Metodo reponsavel por processar a entrada, gerando a saida do programa.
	 * 
	 * @return saida String com o resultado do programa
	 * @throws Erro
	 */
	public String processa() throws Erro {
		Rover rover;
		PlanaltoRetangular planalto;
		ControlaVeiculo controle;
		String[] linhas     = entrada.split("\\n");
		String[] planaltoXY = linhas[0].split("\\s");
		String[] posIniRov;
		
		if (planaltoXY.length != 2) {
			throw new Erro("Argumentos invalidos para o planalto!");
		} else {
			try {
				planalto = new PlanaltoRetangular(
						Integer.valueOf(planaltoXY[0]),
						Integer.valueOf(planaltoXY[1])
					);
			} catch (NumberFormatException e) {
				throw new Erro("Argumentos invalidos para o planalto!");
			}
			
			for (int i = 1; i < linhas.length; i += 2) {
				posIniRov = linhas[i].split("\\s");

				if (posIniRov.length != 3) {
					throw new Erro("Argumentos invalidos para o Rover!");
				}

				try {
					
					rover = new Rover(
								Integer.valueOf(posIniRov[0]),
								Integer.valueOf(posIniRov[1]),
								posIniRov[2]
							);
					
					controle = new ControlaVeiculo(planalto, rover);
					
					for (String comando : linhas[i+1].split("")) {
						controle.executaInstrucao(comando.charAt(0));
					}
					
					saida.append(controle.getPosicaoVeiculo());
					saida.append("\n");
				} catch (NumberFormatException e){
					throw new Erro("Argumentos invalidos para o Rover!");
				} catch (IllegalArgumentException e) {
					throw new Erro("Posicao inicial invalida!");
				}
			}
		}
		
		saida.setLength(saida.length() - 1);
		
		
		return saida.toString();
	}
}
