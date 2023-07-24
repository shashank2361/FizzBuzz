// See https://aka.ms/new-console-template for more information
using FizzBuzz;
using FizzBuzz.Service;
using Microsoft.Extensions.DependencyInjection;


var services = ConfigureServices();
var serviceProvider = services.BuildServiceProvider();
serviceProvider.GetService<FizzBuzzConsole>().Run();


static IServiceCollection ConfigureServices()
{
    IServiceCollection services = new ServiceCollection();

     services.AddScoped<IFizzBuzzService, FizzBuzzService>();
    services.AddTransient<FizzBuzzConsole>();

    var serviceProvider = services.BuildServiceProvider();
    return services;
    // calls the Run method in App, which is replacing Main


}

 
 
 


 

 