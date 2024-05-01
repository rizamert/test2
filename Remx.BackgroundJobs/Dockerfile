FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Remx.BackgroundJobs/Remx.BackgroundJobs.csproj", "Remx.BackgroundJobs/"]
RUN dotnet restore "Remx.BackgroundJobs/Remx.BackgroundJobs.csproj"
COPY . .
WORKDIR "/src/Remx.BackgroundJobs"
RUN dotnet build "Remx.BackgroundJobs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Remx.BackgroundJobs.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Remx.BackgroundJobs.dll"]
