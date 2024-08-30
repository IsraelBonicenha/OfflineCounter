<div align="center">
  <img src="https://github.com/user-attachments/assets/fed99059-1d03-491d-8f5d-be8733836961" width="400px">
</div>


![Project Status](https://img.shields.io/badge/Status-Concluído-success?style=for-the-badge&color=003F6C)

<br>

## Descrição do projeto 
<p align="justify">
Este programa foi desenvolvido com o intuito de praticar lógica e organização. A ideia surgiu durante uma queda de internet na empresa onde trabalho. Diante dessa situação, pensei em criar um programa que, além de me proporcionar conhecimento, pudesse também me alertar quando a internet voltasse. O projeto foi desenvolvido em um único dia; a parte que exigiu mais tempo foi a organização do código em classes, para que ele ficasse legível para todos que desejarem consultá-lo. Afinal, eu não poderia subir o projeto todo bagunçado, concorda?
</p>

<br>

<br>

## "Termos técnicos"
<p align="justify">
A classe DisplayManager é responsável por exibir os layouts pré-definidos na tela. O arquivo Program instancia essa classe para exibir a tela inicial do console. Em seguida, um loop do tipo while é criado para gerenciar a execução do programa. Esse loop executa a validação de teclas, onde o usuário deve pressionar teclas específicas para continuar a execução do programa. É nesse ponto que a classe DisplayValidator entra em cena. Existem três possibilidades a serem seguidas a partir daí:
</p>
1 - O usuário pressionar qualquer outra tecla. <br>
2 - O usuário pressionar Enter. <br>
3 - O usuário pressionar ESC. <br>

#
<br>

- 1
<p align="justify">
Diferente do que você possa estar pensando, o primeiro caminho não é validado por uma estrutura condicional básica. Na verdade, é um loop do tipo while que é executado até que o usuário pressione uma tecla válida para as outras condições. Decidi fazer desse jeito para não ter que spawnar um erro de tecla inválida na cara do usuário.
</p>

#
<br>

- 2
<p align="justify">
O segundo caminho é o mais complexo dos três, pois envolve uma série de processos fundamentais para o funcionamento da ideia. Após a validação, o sistema cria um loop que será executado enquanto o status code da requisição for igual a 0. Dentro desse loop, o sistema envia uma requisição para o site do Google utilizando o método RequestInternet, localizado na classe Util, com o objetivo de obter um status code, que pode ser qualquer um dos existentes ou 0. Nesse contexto, é importante destacar que o valor 0 é uma tratativa de erro utilizando try-catch para o caso de não haver retorno de um status code, o que pode indicar que a internet não está funcionando. Com o status code em mãos, é realizada outra validação através do método Validate_Request, que recebe o status code como parâmetro. Resumindo essa validação, se o status code for 200, o sistema exibe o Display_Code200 e retorna ao loop inicial, que gerencia a execução do programa e solicita novamente uma tecla para validar, voltando a estaca zero. Se o status code for diferente de 200 e diferente de 0, o sistema exibe o Display_CodeDiff e executa a mesma ação anterior. Por fim, mesmo que fora da ordem do código, se o status code for igual a 0, o sistema aguarda cinco segundos e inicia um loop que conta até um milhão, através do método LoopSystem, gerenciado pela classe ManagerLoops. Ao final desse loop, ele refaz a requisição devido ao loop mencionado anteriormente, repetindo o processo conforme necessário. Se não entendeu, readme de novo. 😅 
</p>

#
<br>

- 3
<p align="justify">
O terceiro caminho não tem nada de mágico, só altera a variável encerrar_program para verdadeiro afim de encerrar o loop de execução, o que gera saída zero no console, ou seja, em outras palavras, fim do processo.
</p>

<br>

## Ferramentas utilizadas
![C# Badge](https://img.shields.io/badge/C%23-8A2BE2.svg?style=for-the-badge&logo=c-sharp&logoColor=white)

<br>

