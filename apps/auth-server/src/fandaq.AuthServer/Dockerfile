FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS=http://+:80;https://+:443

FROM mycompanyname/fandaq-base:1.0 AS build
WORKDIR /src

COPY . .
WORKDIR "/src/apps/auth-server/src/fandaq.AuthServer"
RUN dotnet publish -c Release -o /app
RUN dotnet dev-certs https -v -ep /app/openiddict.pfx -p f44e2d59-f140-4d03-a30c-b8d12047149a

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "fandaq.AuthServer.dll"]