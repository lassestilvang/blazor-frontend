using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventManager.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();
