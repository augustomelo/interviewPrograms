package br.marsrover.tstmodel;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import br.marsrover.model.Erro;
import br.marsrover.model.Rover;

public class RoverTest {
	@Test
	public void testaMovimentaEquerda() throws Erro {
		Rover rover = new Rover(0, 0, "N");
		rover.movimenta('L');
		assertEquals("Movimenta de N para W:", "W",  rover.getApontando().name());
		rover.movimenta('l');
		assertEquals("Movimenta de W para S:", "S",  rover.getApontando().name());
		rover.movimenta('L');
		assertEquals("Movimenta de S para E:", "E",  rover.getApontando().name());
		rover.movimenta('l');
		assertEquals("Movimenta de E para N:", "N",  rover.getApontando().name());
	}

	@Test
	public void testaMovimentaDireita() throws Erro {
		Rover rover = new Rover(0, 0, "n");
		rover.movimenta('r');
		assertEquals("Movimenta de N para E:", "E",  rover.getApontando().name());
		rover.movimenta('R');
		assertEquals("Movimenta de E para S:", "S",  rover.getApontando().name());
		rover.movimenta('r');
		assertEquals("Movimenta de S para W:", "W",  rover.getApontando().name());
		rover.movimenta('R');
		assertEquals("Movimenta de W para N:", "N",  rover.getApontando().name());
	}

	@Test
	public void testaMovimentaAvancaNorte() throws Erro {
		Rover rover = new Rover(0, 0, "N");
		rover.movimenta('m');
		assertEquals("Avanca de N 0,0 para N 0,1:", 1,  rover.getPosY());
	}
	
	@Test
	public void testaMovimentaAvancaOeste() throws Erro {
		Rover rover = new Rover(1, 0, "w");
		rover.movimenta('M');
		assertEquals("Avanca de W 1,0 para W 0,0:", 0,  rover.getPosX());
	}

	@Test
	public void testaMovimentaAvancaSul() throws Erro {
		Rover rover = new Rover(0, 1, "S");
		rover.movimenta('m');
		assertEquals("Avanca de S 0,1 para S 0,0:", 0,  rover.getPosY());
	}

	@Test
	public void testaMovimentaAvancaLeste() throws Erro {
		Rover rover = new Rover(0, 0, "e");
		rover.movimenta('M');
		assertEquals("Avanca de E 0,0 para E 1,0:", 1,  rover.getPosX());
	}

	@Test (expected = IllegalArgumentException.class)
	public void testaMovimentaAvancaNaoExistente() throws Erro {
		Rover rover = new Rover(0, 0, "c");
		rover.movimenta('M');
	}
	
	@Test (expected = Erro.class)
	public void testaMovimentoNaoExistente() throws Erro {
		Rover rover = new Rover(0, 0, "N");
		rover.movimenta('X');
	}
}
