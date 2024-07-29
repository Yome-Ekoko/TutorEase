##See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
#WORKDIR /src
#COPY ["TutorEase/TutorEase.csproj", "TutorEase/"]
#COPY ["TutorEase.Infrastructure/TutorEase.Infrastructure.csproj", "TutorEase.Infrastructure/"]
#COPY ["TutorEase.Core/TutorEase.Core.csproj", "TutorEase.Core/"]
#COPY ["TutorEase.Persistence/TutorEase.Persistence.csproj", "TutorEase.Persistence/"]
#COPY ["TutorEase.Domain/TutorEase.Domain.csproj", "TutorEase.Domain/"]
#RUN dotnet restore "TutorEase/TutorEase.csproj"
#COPY . .
#WORKDIR "/src/TutorEase"
#RUN dotnet build "TutorEase.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "TutorEase.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "TutorEase.dll"]