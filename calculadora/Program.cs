var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");
var app = builder.Build();

app.MapGet("/", () => {
    return new { mensagem = "api em execução...." };
});

app.MapGet("/saudacao", () => new { mensagem = "Olá, mundo!" });

app.MapGet("/calcula/{opcao}/{valor1}/{valor2}", (int opcao, int valor1, int valor2) => {
    switch(opcao) {
        case 1:
            return new { mensagem = "Soma.....", resultado = valor1 + valor2 };
        case 2:
            return new { mensagem = "Subtração.....", resultado = valor1 - valor2 };
        case 3: 
            return new { mensagem = "Multiplicação.....", resultado = valor1 * valor2 };
        case 4:
            if (valor2 == 0) {
                return new { mensagem = "Deu ruim favela, não pode dividir por zero!", resultado = 0 };
            }
            return new { mensagem = "Dividindo papi.....", resultado = valor1 / valor2 };
        default:
            return new { mensagem = "deu ruim tropa.....", resultado = 0 };
    }
});

app.Run();