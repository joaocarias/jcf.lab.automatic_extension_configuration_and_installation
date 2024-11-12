using Jcf.Lab.Api.DTO;
using Jcf.Lab.Api.Model;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.MapGet("/api/urlextractor/chrome", () =>
{
    return Results.Ok(UrlExtractor.Url);
});

app.MapPost("/api/urlextractor/chrome", ([FromBody] UrlDto url) =>
{
    UrlExtractor.Update(url.Url);
    Results.Created("/api/urlextractor/chrome", UrlExtractor.Url);
});

app.Run();

