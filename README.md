# Projeto Entra21

### Escrevendo e lendo do console
    // Escrever
    Console.WriteLine("Qual é a sua idade?");
    
    // Ler e salvar o resultado
    var result = Console.ReadLine();

    // Juntar textos
    string text = $"Olá, {result}";

### Declarando variáveis e constantes
    var text = "meu texto"
    string text = "meu texto"
    const string text = "meu texto"

### Tipos de variáveis
    // Tipo numérico/int
    var number = 1

    // Tipo texto/string
    var text = "meu texto"
    
    // Tipo booleano/bool
    var boolean = true

    // Tipo numérico com ponto flutuante/double
    var price = 4.099

    // Tipo Data/DateTime
    var currentDate = DateTime.Now;

    // Lista/Array de 3 posições
    var names = new string[3];
    names[0] = "Lucas";
    // names terá o valor Lucas na posição de número 0

### Parsers / Transformadores
    // Transformar um texto/string em um número/int
    var userAge = Int32.Parse(result);

    // Transformar um texto/string em um número com ponto flutuante/double
    double price = Double.Parse(result);

### Operadores de comparação
#### (toda comparação retorna um booleano/bool)
    // É igual?
    1 == 1;
    // vai retornar true

    // É diferente?
    1 != 1;
    // vai retornar false
    
    // É diferente?
    !(1 == 1);
    // vai retornar false

    // Booleano da esquerda é true e o da direita também?
    true && true && false;
    // vai retornar false

    // Booleano da esquerda ou o da direita é true?
    false || false || true;
    // vai retornar true

### Operadores de comparação para números/matemática
    // É maior?
    1 > 1;
    // vai retornar false

    // É menor?
    1 < 1;
    // vai retornar false
    
    // É maior OU igual?
    1 >= 1;
    // vai retornar true
    
    // É menor OU igual?
    1 <= 1;
    // vai retornar true

### Operadores de matemática
    // Somar
    1 + 1;

    // Subtrair
    1 - 1;
    
    // Dividir
    2 / 1;
    
    // Multiplicar
    1 * 2;

    // Resto
    3 % 2;
    // vai retornar 1
    
    // Incrementando uma variável (2 vezes)
    var counter = 0;
    var counter++;
    var counter += 1;
    // counter terá o valor 2

### Blocos condicionais
    // Escrevendo olá SOMENTE quando 1 > 0
    if (1 > 0)
    {
       Console.WriteLine("Olá")
    }
    // Caso 1 NÃO for maior que 0, e 2 > 1, escreva Boa tarde!
    else if (2 > 1)
    {
       Console.WriteLine("Boa tarde!")
    }
    // Caso NENHUMA das condições anteriores forem verdadeiras, escreva Xau!
    else
    {
       Console.WriteLine("Xau!")
    }

### Laços de repetição
    // while
    while (true)
    {
        Console.WriteLine("Olá!");
    }
    // Dirá olá repetidamente
    

### Comandos do editor
Selecionando o texto:
Segurar a tecla shift e utilizar as setas

Comando para comentar:
CTRL + K + C

Comando para descomentar:
CTRL + K + U

Comando para desfazer:
CTRL + Z

Comando para refazer:
CTRL + Y

Comando para abrir o terminal:
CTRL + '

### Depurando a aplicação

1. Clicar na baratinha e depois no botao de engrenagem;
2. Selecionar o texto '.Net Core'
3. Alterar a opção "console" para "integratedTerminal"
4. Adicionar quantos breakpoints quiser (clicar na esquerda do número da linha)
5. Clicar na baratinha e no botão Start (verdinho)
6. Selecionar o Terminal (Sair na tab "Debug Console")
7. F10 vai para a próxima linha
8. F5 para o próximo breakpoint
9. Shift + F5 para "matar" a aplicação
10. CTRL + Shift + F5 para reiniciar o debug
