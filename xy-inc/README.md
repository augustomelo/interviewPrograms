# Desafio back-end XY INC

## Tecnologias utilizadas:
    - body-parser
    - express
    - mongoose
O banco de dados utilizado foi o mongoDB utilizando o serviço do mongolab

## Serviços
- Cadastrar pontos de interesse, para utilizar esse serviço é necessário fazer
  uma chamada POST para a url ```/pointIntererest``` passando o seguinte JSON
  no body:
    ```
    {
        "name": "Lanchonete",
        "loc": [27, 12]
    }
    ```
- Listar todos os pontos de interese, basta fazer uma chamada GET na seguinte
  URL ```/pointIntererest```
- Listar serviços por proximidade, basta fazer uma chamada GET na seguinte URL
  passando os parâmetros na URL
  ```/pointInterest/:xCoordinate/:yCoordinate/:distance```
