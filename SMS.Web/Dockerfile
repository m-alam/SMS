FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SMS.Web/*.csproj", "SMS.Web/"]
COPY ["SMS.Framework/*.csproj", "SMS.Framework/"]
COPY ["SMS.Data/*.csproj", "SMS.Data/"]
RUN dotnet restore "SMS.Web/SMS.Web.csproj"
COPY . .
WORKDIR "/src/SMS.Web"
RUN dotnet build "SMS.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet build "SMS.Web.csproj" -c Release -o /app

FROM build AS final 
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet","SMS.Web.dll"]
