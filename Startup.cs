public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<MyContext>(options =>
    options.UseSqlServer("Server=localhost;Database=UserDB;Trusted_Connection=True;"));


    public void ConfigureServices(IServiceCollection services)
    {
     
        // Enregistrement de l'implémentation IUserRepository
        services.AddTransient<IUserRepository, UserRepository>();

        // Enregistrement de UserService
        services.AddScoped<IUserService, UserService>();
    }


    services.AddControllers();

    // Swagger
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "User API", Version = "v1" });
    });
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "User API v1");
    });

    app.UseRouting();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}