package br.marsrover.tstmodel;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import br.marsrover.model.PlanaltoRetangular;

public class PlanaltoRetangularTest {
	@Test
	public void testaVerificaPosicaoRetornoFalso() {
		PlanaltoRetangular planalto = new PlanaltoRetangular(10, 10);
		assertEquals("Deveria ser falso: ", false, planalto.verificaPosicao(11, 11));
		assertEquals("Deveria ser falso: ", false, planalto.verificaPosicao(-1, -1));
	}


	@Test
	public void testaVerificaPosicaoRetornoVerdadeiro() {
		PlanaltoRetangular planalto = new PlanaltoRetangular(10, 10);
		assertEquals("Deveria ser verdadeiro: ", true, planalto.verificaPosicao(0, 0));
		assertEquals("Deveria ser verdadeiro: ", true, planalto.verificaPosicao(1, 1));
		assertEquals("Deveria ser verdadeiro: ", true, planalto.verificaPosicao(10, 10));
		assertEquals("Deveria ser verdadeiro: ", true, planalto.verificaPosicao(9, 9));
	}
}

