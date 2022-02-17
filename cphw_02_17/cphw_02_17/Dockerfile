FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["cphw_02_17/cphw_02_17.csproj", "cphw_02_17/"]
RUN dotnet restore "cphw_02_17/cphw_02_17.csproj"
COPY . .
WORKDIR "/src/cphw_02_17"
RUN dotnet build "cphw_02_17.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cphw_02_17.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cphw_02_17.dll"]
