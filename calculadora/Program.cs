var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");
var app = builder.Build();

app.MapGet("/", () => {
    return new { mensagem = "api em execução...." };
});

app.MapGet("/saudacao", () => new { mensagem = "Olá, mundo!" });


app.MapGet("/calcula/soma/{a:double}/{b:double}", (double a, double b) => {
    return Results.Ok(new { mensagem = "valor da soma...", resultado = a + b });
});

app.MapGet("/calcula/subtracao/{a:double}/{b:double}", (double a, double b) => {
    return Results.Ok(new { mensagem = "valor da subtracao...", resultado = a - b });
});

app.MapGet("/calcula/multiplicacao/{a:double}/{b:double}", (double a, double b) => {
    return Results.Ok(new { mensagem = "valor da multiplicacao...", resultado = a * b });
});

app.MapGet("/calcula/divisao/{a:double}/{b:double}", (double a, double b) => {
    return Results.Ok(new { mensagem = "valor da divisao...", resultado = a / b });
});

app.Run();