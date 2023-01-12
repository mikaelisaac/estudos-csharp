// Impressão de dados em tela
    // Imprime o dado inserido, na linha intera
    Console.WriteLine("Hello World!");

    // Imprime o dado inserido, concatenará na mesma linha caso haja vários
    Console.Write("Hello World!");
    Console.Write("My name is Mikael");

// Definição de variáveis
    // Char é um único caracter e String é um conjunto de caracteres
    string wteste = "ABC";
    char wteste2;
    wteste2 = 'D';
    // ou 
    var wteste3 = 1;

    Console.Write(wteste);
    Console.Write(wteste2);
    Console.Write(wteste3);

// Formatação de caracteres
    Console.WriteLine("Hello\nWorld!"); // Quebra linha
    Console.WriteLine("Hello\tWorld!"); // Da um tab
    Console.WriteLine("Hello \"World\"!"); // Mostrar " dentro da impressão
    Console.WriteLine("c:\\source\\repos"); // Mostrar \ dentro da impressão
    Console.WriteLine("________________________________________________");
// Exemplo 2
        Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
    // Quando colocar @ no Console.Write, ele irá entender como um texto não mais como apenas caracteres
        Console.Write(@"c:\invoices");
        Console.WriteLine("________________________________________________");
    // Caracteres Unicode, para utilizá-los se faz necessário adicionar o prefixo \u e o código de 4 caracteres
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

    // To generate Japanese invoices:
    // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        Console.WriteLine(@"c:\invoices\app.exe -j");
// Exercício
    Console.WriteLine("________________________________________________");
    // Concatenação
        string firstName = "Bob";
        string greeting = "Hello";
        string message = greeting + " " + firstName + "!";
        Console.WriteLine(message);
    // Interpolação
        // Os exemplos abaixo fazem a mesma coisa
        string message2 = greeting + " " + firstName + "!";
        string message3 = $"{greeting} {firstName}!";
        // Exemplo 1
        string firstName4 = "Bob";
        string message4 = $"Hello {firstName4}!";
        Console.WriteLine(message4);
        // Exemplo 2
        string firstName5 = "Bob";
        string greeting5 = "Hello";
        Console.WriteLine($"{greeting5} {firstName5}!");
        // Podemos combinar literais textuais e interpolação de cadeia de caracteres
        string projectName6 = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName6}\Data");
// Desafio
    Console.WriteLine("________________________________________________");
    string englishMessage = "View English output:\n";
    string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
    string projectName = "ACME";
    string projectPath = $@"c:\Exercise\{projectName}";

    Console.Write(englishMessage + "\t\t" + projectPath + "\\data.txt\n\n");
    Console.Write(russianMessage + "\n\t\t" + projectPath + "\\ru-RU\\data.txt");

// Operações
    // Neste exemplo irá somar
    int firstNumber = 12;
    int secondNumber = 7;
    Console.WriteLine(firstNumber + secondNumber);

    // Neste irá aceitar que a variável widgetsSold seja mostrada
    string firstName = "Bob";
    int widgetsSold = 7;
    Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

    // Adendo, desta forma irá mostrar em tela a variável widgetsSold como string, logo irá ficar 77
    string firstName2 = "Bob";
    int widgetsSold2 = 7;
    Console.WriteLine(firstName2 + " sold " + widgetsSold2 + 7 + " widgets.");

    // Para somarmos, teria que ser feito deste forma
    Console.WriteLine(firstName2 + " sold " + (widgetsSold2 + 7) + " widgets.");

    // Operações básicas
    int sum = 7 + 5;
    int difference = 7 - 5;
    int product = 7 * 5;
    int quotient = 7 / 5;

    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Difference: " + difference);
    Console.WriteLine("Product: " + product);
    Console.WriteLine("Quotient: " + quotient);

    // Para fazer operações com resultado decimal, deve-se seguir a seguinte sintaxe
    decimal decimalQuotient;
    decimal decimalQuotient = 7.0m / 5;
    decimal decimalQuotient = 7 / 5.0m;
    decimal decimalQuotient = 7.0m / 5.0m;

    // As 3 formas acima fazem a mesma coisa, já as abaixo, estão erradas
    int decimalQuotient = 7 / 5.0m;
    int decimalQuotient = 7.0m / 5;
    int decimalQuotient = 7.0m / 5.0m;
    decimal decimalQuotient = 7 / 5;
    Console.WriteLine("Decimal quotient: " + decimalQuotient);

    // Quando se fizer necessário a conversão do tipo da variável se utiliza-se o método abaixo
    int first = 7;
    int second = 5;
    decimal quotient = (decimal)first / (decimal)second;
    Console.WriteLine(quotient);

    // Para pegar o resto da divisão utiliza-se %
    Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
    Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

    // Ordem nas operações, respeitará o "escopo" dos parênteses
    int value1 = 3 + 4 * 5;
    int value2 = (3 + 4) * 5;
    Console.WriteLine(value1);
    Console.WriteLine(value2);

    // Incrementar valor a variável
    int value = 0;
    value = value + 5; // ou 
    value += 5;

    // Quando for para apenas 1
    value = value + 1; // ou 
    value++;

    // Mais exemplos
    value = 1;
    value = value + 1;
    Console.WriteLine("First increment: " + value);

    value += 1;
    Console.WriteLine("Second increment: " + value);

    value++;
    Console.WriteLine("Third increment: " + value);

    value = value - 1;
    Console.WriteLine("First decrement: " + value);

    value -= 1;
    Console.WriteLine("Second decrement: " + value);

    value--;
    Console.WriteLine("Third decrement: " + value);

    //Usar o operador de incremento antesee depois do valor
    value = 1;
    value++;
    Console.WriteLine("First: " + value);
    Console.WriteLine("Second: " + value++);
    Console.WriteLine("Third: " + value);
    Console.WriteLine("Fourth: " + (++value));

//Desafio
    int fahrenheit = 94;
    decimal celsius = (fahrenheit - 32m) * (5m / 9m);
    Console.WriteLine("The temperature is " + celsius + " Celsius.");

// 