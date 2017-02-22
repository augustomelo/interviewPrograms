package br.marsrover.tstcontroller;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import br.marsrover.controller.ControlaVeiculo;
import br.marsrover.model.Erro;
import br.marsrover.model.Planalto;
import br.marsrover.model.PlanaltoRetangular;
import br.marsrover.model.Veiculo;
import br.marsrover.model.Rover;

public class ControlaVeiculoTeste {
	@Test
	public void testaExecutaIstrucaoValido() {
		Planalto planalto = new PlanaltoRetangular(5, 5);
		Veiculo  veiculo = new Rover(1, 2, "N");
		ControlaVeiculo controle = new ControlaVeiculo(planalto, veiculo);

		try {
			controle.executaInstrucao('L');
			assertEquals("Posicao deveria ser 1 2 W", "1 2 W", controle.getPosicaoVeiculo());
			controle.executaInstrucao('m');
			assertEquals("Posicao deveria ser 0 2 W", "0 2 W", controle.getPosicaoVeiculo());
		} catch (Erro e) {
			e.printStackTrace();
		}
	}

	@Test (expected = Erro.class)
	public void testaExecutaIstrucaoInvalido() throws Erro {
		Planalto planalto = new PlanaltoRetangular(5, 5);
		Veiculo  veiculo = new Rover(0, 0, "N");
		ControlaVeiculo controle = new ControlaVeiculo(planalto, veiculo);

		controle.executaInstrucao('L');
		assertEquals("Posicao deveria ser 0 0 W", "0 0 W", controle.getPosicaoVeiculo());
		controle.executaInstrucao('m');
	}

}
