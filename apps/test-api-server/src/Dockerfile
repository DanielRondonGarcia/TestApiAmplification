FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy project files
COPY *.csproj .config ./

# Restore as distinct layers
RUN dotnet restore
RUN dotnet tool restore 

# Copy everything
COPY . ./
RUN dotnet csharpier .


# Build and publish a release
RUN dotnet publish -c Release -o out

RUN dotnet csharpier .
RUN dotnet ef migrations bundle -o DbMigrationsBundle

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
COPY --from=build-env /App/DbMigrationsBundle ./DbMigrationsBundle

ENTRYPOINT ["dotnet", "test-api.dll"]