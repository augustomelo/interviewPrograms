package br.marsrover.view;

import br.marsrover.controller.ControlaEntrada;
import br.marsrover.model.Erro;
import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class Main extends Application implements EventHandler<ActionEvent> {
	private Stage janela;
    private Button botao;
    private Label entradaL;
    private TextArea entradaT;
    private Label saidaL;
    private TextArea saidaT;
    
	public static final void main(String[] args){
		launch(args);
	}
	
	 @Override
	    public void start(Stage primaryStage) throws Exception {
	        janela	= primaryStage;
	        janela.setResizable(false);
	        janela.setTitle("Mars Rover");
	        
	        //Entrada
	        entradaL = new Label("Entrada");
	        entradaT = new TextArea();
	        entradaT.setWrapText(true);
	        botao = new Button("Controlar");
	        botao.setOnAction(this);
	        
	        saidaL = new Label("Saida");
	        saidaT = new TextArea();
	        saidaT.setWrapText(true);
	        saidaT.setEditable(false);
	        
	        VBox entradaVbox = new VBox(20);
	        entradaVbox.setPadding(new Insets(20, 20, 20, 20));
	        entradaVbox.getChildren().addAll(entradaL, entradaT, botao);
	        
	        VBox saidaVbox = new VBox(20);
	        saidaVbox.setPadding(new Insets(20, 20, 20, 20));
	        saidaVbox.getChildren().addAll(saidaL, saidaT);
	        
	        HBox hbox = new HBox(20);
	        hbox.getChildren().addAll(entradaVbox, saidaVbox);

	        Scene scene = new Scene(hbox, 800, 300);
	        janela.setScene(scene);
	        janela.show();
	    }

	@Override
	public void handle(ActionEvent event) {
		if (event.getSource() == botao) {
			ControlaEntrada controlaEntrada = new ControlaEntrada(entradaT.getText());
			try {
				saidaT.setText(controlaEntrada.processa());
			} catch (Erro e) {
				saidaT.setText(e.getMessage());
				e.printStackTrace();
			}
		}
		
	}
}


