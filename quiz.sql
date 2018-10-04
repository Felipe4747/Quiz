create database Quiz;
use Quiz;
create table perguntas(
	id int not null auto_increment,
    pergunta text not null,
    resp1 text not null,
    resp2 text not null,
    resp3 text not null,
    resp4 text not null,
    resp_certa enum('a', 'b', 'c', 'd') not null,
    primary key(id)
);
create table usuario(
	id int not null auto_increment,
    nome varchar(15) not null,
    pontuacao int,
    primary key(id)
);
drop table perguntas;
drop table usuario;
insert into perguntas values
	(null, 'Qual dos gases abaixo não foi utilizado como arma de destruição em massa durante a 1º Guerra?', 'Gás cloro', 'Gás mostarda', 'Gás fosfogênio', 'Gás lacrimogênio', 'd'),
	(null, 'As máscaras de gás eram inúteis contra o gás mostarda. Quais alternativas abaixo descrevem os efeitos do gás?
I - Causava erupções na pele
II - Cegava instantaneamente
III - Causava a ruptura dos vasos sanguíneos
IV - Derretia as máscaras', 'I - II - III, estão corretas', 'II - III - IV, estão corretas', 'I - III - IV, estão corretas', 'Todas estão corretas', 'a'),
	(null, 'Quantos anos durou a guerra?', '6 anos', '3 anos', '8 anos', '4 anos', 'd'),
	(null, 'Quais foram os países que compuseram a tríplice entente (no inicio da 1º Guerra Mundial)?', 'Estados Unidos, Alemanha e Itália', 'Reino Unido, França e Alemanha', 'Reino Unido, Império Russo e França', 'Império Russo, Alemanha e Itália', 'c'),
	(null, 'A Primeira Guerra Mundial foi centrada em qual continente?', 'África', 'Oeste asiático', 'Europa', 'Polônia', 'c'),
	(null, 'A Primeira Guerra Mundial termina:', 'Criada a Liga das Nações. Alemanha se torna a culpada da guerra.', 'Criada a Organização das Nações Unidas. Itália se torna a culpada da guerra.', 'Criada a Liga das Nações. Império Otomano se torna o culpado da guerra.', 'Criada a Organização das Nações Unidas. Império Austro-Húngaro se torna culpado da guerra.', 'a'),
	(null, 'Qual foi a operação que manchou a imagem de Winston Churchill por ter sido desastrosa?', 'Operação Dynamo', 'Batalha de Varsóvia', 'Campanha de Galipoli', 'Ofensiva Brusilov', 'c'),
	(null, 'Qual dos itens abaixo NÃO está ligado à 1ª Guerra Mundial enquanto causa?', 'O Tratado de Frankfurt', 'A crescente procura de mercados e matérias-primas', 'A política agressiva de Bismarck', 'A disputa colonial', 'a'),
	(null, 'Como forma de defesa, foram criadas alianças entre alguns países. Qual o nome da aliança feita entre a Inglaterra, França e Rússia? E qual o nome da aliança formada pela Alemanha, o Império Austro-Húngaro e a Itália? Respectivamente.', 'Tríplice dos Vencedores e Tríplice de Hitler.', 'Tríplice Entente e Tríplice Aliança.', 'Tríplice Aliança e Tríplice Entente.', 'Tríplice dos Unidos e Tríplice Cardial.', 'b'),
	(null, 'O que é um estado totalitário?', 'Estado comandado pelo povo por meio de voto popular.', 'Estado comandado por um líder visando o bem estar do seu povo, dando a eles o poder de escolher o que pensar,no que acreditar.', 'Onde tudo é controlado pelo Estado, que é encabeçado pelo líder único e supremo.Sem dar liberdade de expressão ao povo, impondo a eles o que quisessem.', 'Comandado pelo Estado,porém, o poder se concentrava nas mãos da Igreja.', 'c'),
	(null, 'Qual foi o estopim da guerra?', 'O neocolonialismo no continente africano', 'Histórico de guerras não resolvidas entre os países', 'Assassinato de Francisco Ferdinando', 'Corrida armamentista', 'c'),
	(null, 'Quantos mortos, aproximadamente, a guerra deixou?', '10 milhões', '20 milhões', '15 milhões', '5 milhões', 'b'),
	(null, 'Em qual ano os EUA entraram na guerra?', '1914', '1915', '1916', '1917', 'd'),
	(null, 'O que causou a rivalidade entre Império russo e Alemanha?', 'Predomínio do comércio na fronteira russo-germânica', 'Ataque terrorista russo contra a Alemanha', 'Disputa por qual país era mais desenvolvido', 'Construção uma estrada de ferro que interferia em território russo', 'd'),
	(null, 'Por que ocorria o antigermanismo inglês?', 'Disputa econômica entre os dois países', 'Ataque terrorista alemão contra a Inglaterra', 'Disputa por qual país era mais desenvolvido', 'A ideia inglesa de rotas de comércio entre países, sendo rejeitada pela Alemanha', 'a'),
	(null, 'Por que ocorria o antigermanismo francês?', 'Disputa econômica', ' Guerra Franco-Prussiana', ' Guerra Franco-Prussiana', 'Disputa por potência bélica', 'b'),
	(null, 'I.A construção da estrada de ferro Berlin-Bagdá: sua construção colocaria à disposição da Alemanha os lençóis petrolíferos do Golfo Pérsico e os mercados orientais, além de ameaçar as rotas de comunicação entre a Inglaterra e seu Império.

II.Pan-Eslavismo Russo (união de todos os povos eslavos sob a proteção da Rússia): o Pan-Eslavismo servia de justificativa para os interesses imperialistas da Rússia de dominar regiões da Europa Oriental habitadas por outros povos eslavos (poloneses, ucranianos, tchecos, eslovacos, sérvios, búlgaros, croatas...)

III. Alemanha e a Itália eram imperialistas, queriam e precisavam de colônias, para isso precisariam tomar as colônias de outros países, já que não havia mais quase locais para serem dominados

Quais desses fatores contribuíram para o advento da guerra?', 'I', 'I, II', 'II, III', 'Todas estão corretas.', 'd'),
	(null, 'I.Nacionalismo da Sérvia
II.Conflitos originários da decadência do Império Turco
III.Crises no Marrocos: alemães, ingleses e franceses disputavam essa área.
IV.Primeira e segunda Guerra Balcânica

Quais desses fatores contribuíram para o advento da guerra?', 'I, II e IV', 'I, II, II', 'II, III e IV', 'Todas estão corretas', 'd'),
	(null, 'A primeira guerra dividiu-se em 3 fases. Coloque essas fases na ordem correta:', 'Guerra de movimento, Guerra de Trincheiras e Ofensivas.', 'Guerra de Trincheiras, Ofensivas e Guerra de movimento.', 'Ofensivas, Guerra de movimento e Guerra de Trincheiras.', 'Guerra de Trincheiras, Guerra de movimento e Ofensivas.', 'a'),
	(null, 'O Tratado de Versalhes colocou de lado o “Programa dos 14 Pontos” e os “vencedores” impuseram duras penalidades à Alemanha:

I. A Alemanha perdeu suas colônias
II. Ficou proibida de ter forças armadas
III. Foi considerada culpada pela guerra
IV. Teve que pagar uma indenização aos “vencedores”', 'Estão corretas as opções I, III e IV.', 'Todas as opções estão corretas. CORRETA', 'Estão incorretas as opções III e II.', 'Estão corretas as opções I, II, IV.', 'b'),
	(null, 'Quais foram as consequências da guerra?

I. Famílias destruídas e crianças órfãs
II. Os EUA tornaram-se o país mais rico do mundo
III. O império Austro-Húngaro se fragmentou
IV. O desemprego diminuiu na Europa.', 'I, II e IV.', ' I, III e IV.', 'I, II, III.', 'Todas alternativas estão corretas', 'c'),
	(null, 'Quatro anos após a Guerra, a Europa já não era mais a mesma. Dentre as principais mudanças estão:

I. Presidentes no lugar de príncipes, automóveis circulando pelas ruas, submarinos nos mares e aviões nos céus
II. O cinema e o rádio também começaram a se expandir
III. As mulheres tomaram consciência dos seus direitos e tornaram-se mais livres
IV. Foram criadas as cotas para Negros.', ' I, II e IV.', 'II, III e IV.', 'I, II e III', 'Todas estão corretas', 'c'),
	(null, 'I. Crise de desemprego
II. Ascensão Alemã no pós guerra
III. Nazismo

Dos fatos que a 1ª Guerra causou, estão corretas:', ' I, II e III', 'I e II', 'I e III', ' II e III', 'c'),
	(null, 'Qual desses países conseguiu expandir sua economia e se tornar potência mundial:', 'Império Russo', 'Estados Unidos', 'Inglaterra', 'Alemanha', 'b'),
	(null, 'O choque da nova fase do capitalismo mundial, chamado de Imperialismo pelos economistas alemães e ingleses, provocou o surgimento da Primeira Guerra Mundial. Quais eram os fenômenos que estavam ligados ao Imperialismo?', 'Expansão econômica dos países capitalistas', 'Investimento de capital no estrangeiro e domínio econômico de um país sobre o outro', 'Política de expansão e domínio territorial, cultural e econômico de uma nação dominante sobre outras.', 'Expansão européia após 1870', 'c'),
	(null, 'Quais foram as batalhas que ocorreram envolvendo Franceses, Ingleses e Alemães?', 'Batalha do Somme e Batalha de Verdun', ' Batalha de Dogger Bank e Batalha de Bolimov', 'Batalha de Krasnik e Batalha de Bitlis', 'Batalha de Sharqat e Batalha de Megido

', 'a'),
	(null, '"Com a revolução russa de 1917 e consequentemente a ruína de sua economia, os bolcheviques (grupo político russo) optam por assinar um tratado com os alemães para o fim do conflito entre ambos os países. [...]"

Qual era o nome deste tratado?', 'Tratado de Saint-Germain-en-Laye', 'Tratado de Brest-Litovsk', 'Tratado de Trianon', 'Tratado de Versalhes', 'b'),
	(null, '(FGV-RJ 2015) Sobre a participação brasileira na Primeira Guerra Mundial, é correto afirmar:', 'O governo brasileiro declarou guerra à Alemanha, em 1914, após o torpedeamento de um navio, carregado de café, que acabara de deixar o porto de Santos.', 'O governo brasileiro declarou guerra à Alemanha, em 1914, após o torpedeamento de um navio, carregado de café, que acabara de deixar o porto de Santos.', 'A partir de 1916, o Exército brasileiro participou de batalhas na Bélgica e no norte da França com milhares de soldados desembarcados na região.', 'O Brasil enviou uma missão médica, um pequeno contingente de oficiais do Exército e uma esquadra naval, que se envolveu em alguns confrontos com submarinos alemães.', 'd'),
	(null, 'A Primeira Guerra Mundial deixou profundas consequências para todo o mundo. Analise as afirmações abaixo:

I - redesenhou o mapa político da Europa e do Oriente Médio;
II - marcou a queda do capitalismo liberal;
III - motivou a criação da Liga das Nações;
IV - permitiu a ascensão econômica e política dos Estados Unidos.

Quais afirmações estão corretas?', 'apenas I', 'I e III', 'I, II e III', 'Todas estão corretas', 'd'),
	(null, '(Fatec) Segundo as teorias desenvolvimentistas, a guerra era concebida como:', ' uma necessidade de ampliar o mercado interno substituindo as importações.', 'uma política econômica tendendo a desvalorizar a produção agrícola.', 'uma forma de criar condições para a importação de tecnologia estrangeira.', 'um recurso complementar e necessário à importação de produtos primários.', 'a');