FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

WORKDIR /app

COPY *.sln ./
COPY StoreBL/*.csproj StoreBL/
COPY StoreDL/*.csproj StoreDL/
COPY StoreModels/*.csproj StoreModels/
COPY StoreMVC/*.csproj StoreMVC/

RUN dotnet restore

COPY . ./

RUN dotnet publish ToHMVC -c Release -o publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime
WORKDIR /app

COPY --from=build /app/publish ./
CMD ["dotnet", "ToHMVC.dll"]