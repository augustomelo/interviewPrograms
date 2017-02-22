package br.marsrover.tstcontroller;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import br.marsrover.controller.ControlaEntrada;
import br.marsrover.model.Erro;

public class ControlaEntradaTest {
	@Test
	public void testaExecutaInstrucaoValida() {
		ControlaEntrada controla = new ControlaEntrada (
					"5 5\n1 2 N\nLMLMLMLMM"
				);
		try {	
		assertEquals("Resultado final deveria ser 1 3 N:", "1 3 N", controla.processa());
		} catch (Erro e) {
			e.printStackTrace();
		}
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoPlanaltoIvalido() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"X X\n1 2 N\nLMLMLMLMM"
				);
		controla.processa();
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoPlanaltoArgumentosMenores() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"5 \n1 2 N\nLMLMLMLMM"
				);
		controla.processa();
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoRoverIvalido() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"5 5\nX X N\nLMLMLMLMM"
				);
		controla.processa();
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoRoverArgumentosMenores() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"5 5\n1 2 \nLMLMLMLMM"
				);
		controla.processa();
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoRoverPosicaoInicialInvalida() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"5 5\n1 2 P\nLMLMLMLMM"
				);
		controla.processa();
	}

	@Test (expected = Erro.class)
	public void testaExecutaInstrucaoInvalida() throws Erro {
		ControlaEntrada controla = new ControlaEntrada (
					"5 5\n1 2 N\nLMLXLMLMM"
				);
		controla.processa();
	}

}
