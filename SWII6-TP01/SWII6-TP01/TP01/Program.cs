using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel;
using TP01;
using TP01.Controller;

// Lucas Vieira dos Santos Martins
// Miguel da Silva Pataro

var controller = new BookController();

controller.DesmostrarMetodos();

Console.WriteLine("\n\n\n\n");

IWebHost host = new WebHostBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();

host.Run();