#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN apt-get update && apt-get install -y apt-utils
RUN apt-get install -y libfontconfig1
RUN apt-get install -y libgdiplus

#Install ms fonts.
RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

WORKDIR /app
EXPOSE 80
EXPOSE 443

#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["WebApplication4/WebApplication4.csproj", "WebApplication4/"]
#RUN dotnet restore "WebApplication4/WebApplication4.csproj"
#COPY . .
#WORKDIR "/src/WebApplication4"
#RUN dotnet build "WebApplication4.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "WebApplication4.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wisej.CodeProject.dll"]