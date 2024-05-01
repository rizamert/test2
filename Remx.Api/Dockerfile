FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Remx.Api/Remx.Api.csproj", "Remx.Api/"]
RUN dotnet restore "Remx.Api/Remx.Api.csproj"
COPY . .
WORKDIR "/src/Remx.Api"
RUN dotnet build "Remx.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Remx.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Remx.Api.dll"]
