﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestConsoleApp1/TestConsoleApp1.csproj", "TestConsoleApp1/"]
RUN dotnet restore "TestConsoleApp1/TestConsoleApp1.csproj"
COPY . .
WORKDIR "/src/TestConsoleApp1"
RUN dotnet build "TestConsoleApp1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestConsoleApp1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestConsoleApp1.dll"]
