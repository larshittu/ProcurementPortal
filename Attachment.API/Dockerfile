FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52355
EXPOSE 44398

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Attachment.API/Attachment.API.csproj Attachment.API/
RUN dotnet restore Attachment.API/Attachment.API.csproj
COPY . .
WORKDIR /src/Attachment.API
RUN dotnet build Attachment.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Attachment.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Attachment.API.dll"]
