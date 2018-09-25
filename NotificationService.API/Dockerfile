FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52355
EXPOSE 44398

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY NotificationService.API/NotificationService.API.csproj NotificationService.API/
RUN dotnet restore NotificationService.API/NotificationService.API.csproj
COPY . .
WORKDIR /src/NotificationService.API
RUN dotnet build NotificationService.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish NotificationService.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NotificationService.API.dll"]
