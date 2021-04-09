#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CurrencyConverter.Parameters.API/CurrencyConverter.Parameters.API.csproj", "CurrencyConverter.Parameters.API/"]
RUN dotnet restore "CurrencyConverter.Parameters.API/CurrencyConverter.Parameters.API.csproj"
COPY . .
WORKDIR "/src/CurrencyConverter.Parameters.API"
RUN dotnet build "CurrencyConverter.Parameters.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CurrencyConverter.Parameters.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CurrencyConverter.Parameters.API.dll"]