# Pula Corda - Jogo

<img src="banner.jpg" style='height: 100%; width: 100%; object-fit: contain'/>

Jogo feito em Unity e tapete de dança para crianças do primeiro ano da Escola Educare - São Roque


### Motivação
O tema da escola deste semestre é sobre brinquedos e tivemos uma reunião com a coordenação pedagógica da escola para uma parceria na criação de um jogo que trouxesse uma discussão entre o analógico e o digital. A maioria dos alunos têm interesse pro video-games, e este é um assunto que deve ser tratato de maneira acadêmica, por problemas de má informação ou excesso por parte da sociedade.

Com isto, chegamos na idea de criarmos um jogo de pular corda digital (já que esta foi uma das brincadeiras mais importantes do sementre) de maneira que os alunos pudessem participar na construção, criando avatares e participando de jogadas coletivas. Este projeto tem objetivo de criar um canal de comunicação do uso de jogos e sua qualidade real no udo pedagógico, problemática atual, mas que possui deficiência de formação e informação da comunidade.

O mapeamento do impacto educativo, ou de discussão deste tipo de jogo ainda será anotado, precisando de ser pensando uma metodologia de apoio para tal. Porém, o que já foi previamente aqui pensando, foi abrir o entendimento para que as crianças possam construir seus jogos, futuramente, além de entender o impacto de uma produção híbrida, no sentido cognitivo e formação dos mesmos, passando de consumidores para investigadores.

### Desenvolvimento
O jogo foi criado em Unity e possui interface simples, com o game loop rodando sem precisar de outra funcionalidade além de utilizar o mesmo botão. Durante o desenvolvimento, algns acertos foram necessários, apesar da idea e implementação relativamente simples. A checagem dos colisores, a corda 3D, a funcionalidade de soltar o botão, balanço da dificuldade, entre outras, foram possíveis através do teste com uma criança de 7 anos.

<img src="tapete.jpg" style='height: 100%; width: 100%; object-fit: contain'/>
O jogo possui a proposta de fazer um teste de usabilidade com hardwares alternativos, saindo do circuito óbvio de joysticks e valorizando a locomoção. Nos testes de gameplay, foi interessante notar que a funcionalidade do botão precisava ser alterada para pular quando o mesmo fosse solto, e não apertado, simulando o pulo. Isto pode abrir um experimento para testes de conflito de informação e diversão entre o que seria correto e uma nova mecânica digital

### Como jogar

Espaço para pular. É recomendado um tapete de dança ou interface similar para utilizar os pés.

### Recursos

- Sistema de importação de images aleatórias de uma pasta. A cada jogada, um novo avatar (criado pelas crianças) é importado para jogar;
-  Game loop simples contendo: contador de início, sistema de pulo e checagem de indicativo de tropeço na corda;
-  Restart com mesmo botão, o qual fará uma escolha nova de avatar e nova partida;

### Observações

- O jogo foi programado em uma tarde;
- Utilizei o chatGPT para criar funções. Resultado bem satisfatório;
- O gameplay pareceu funcionar bem, com engajamento. Porém, após multiplas jogadas e insistência em jogar, a crinaça pareceu irritada. Isto pode ser balanceado ao ser jogado em turma, sem excesso de maestria de habilidade;
- Optei por retirar o contador de pulos, favorecendo a contagem por voz da turma;
- O mesmo com o score: inicialmente tinha pensando em utilizar um score para cada avatar, favorecendo a competição. Mas o jogo pareceu funcionar como está e assim ficará mais leve;
- A dificuldade já está balanceada. Nara conseguiu, com muito esforço, em torno de 10 pulos. Pode-se adicionar mais dificuldade como aumento da velocidade da corda ou apertar outros botões do tapete durante os pulos da corda, mas não parece ser necessário no momento;
