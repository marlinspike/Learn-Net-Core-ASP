FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Learn-Net-Core-ASP.csproj", ""]
RUN dotnet restore "./Learn-Net-Core-ASP.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Learn-Net-Core-ASP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Learn-Net-Core-ASP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Learn-Net-Core-ASP.dll"]