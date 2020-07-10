# Projeto Entra21

### Escrevendo e lendo do console
    // Escrever
    Console.WriteLine("Qual é a sua idade?");
    
    // Ler e salvar o resultado
    var result = Console.ReadLine();

### Tipos básicos
    // Tipo numérico/int
    var number = 1

    // Tipo texto/string
    var text = "meu texto"
    
    // Tipo booleano/bool
    var boolean = true

    // Tipo numérico com ponto flutuante/double
    var price = 4.099

### Parsers / Transformadores
    // Transformar um texto/string em um número/int
    var userAge = Int32.Parse(result);

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

