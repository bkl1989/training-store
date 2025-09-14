var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.TrainingStore_ApiService>("apiservice");

builder.AddProject<Projects.TrainingStore_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
