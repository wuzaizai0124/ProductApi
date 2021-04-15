#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
#WORKDIR /src
#COPY ["MicDapr.ProductApi/MicDapr.ProductApi.csproj", "MicDapr.ProductApi/"]
#RUN dotnet restore "MicDapr.ProductApi/MicDapr.ProductApi.csproj"
#COPY . .
#WORKDIR "/src/MicDapr.ProductApi"
#RUN dotnet build "MicDapr.ProductApi.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "MicDapr.ProductApi.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "MicDapr.ProductApi.dll"]
 FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
 WORKDIR /app

 COPY . .

 EXPOSE 80

 ENTRYPOINT ["dotnet", "MicDapr.ProductApi.dll"]