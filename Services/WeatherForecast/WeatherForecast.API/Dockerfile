FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ./Services/WeatherForecast/WeatherForecast.API/WeatherForecast.API.csproj ./Services/WeatherForecast/WeatherForecast.API/
COPY ./Services/WeatherForecast/WeatherForecast.Domain/WeatherForecast.Domain.csproj ./Services/WeatherForecast/WeatherForecast.Domain/

RUN dotnet restore ./Services/WeatherForecast/WeatherForecast.API/WeatherForecast.API.csproj

COPY ./Services/WeatherForecast ./Services/WeatherForecast
WORKDIR /src/Services/WeatherForecast/WeatherForecast.API
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WeatherForecast.API.dll"]