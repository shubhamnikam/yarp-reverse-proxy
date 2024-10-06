var builder = WebApplication.CreateBuilder(args);

// setup proxy service 
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// add proxy in pipeline
app.MapReverseProxy();

app.Run();
