#download the verified SDK image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base 
# create a working directory
WORKDIR /app
# expose a http port
EXPOSE 80		
# expose a https port (the secure one)
EXPOSE 443		

#download the verified SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build 

# create a work directory
WORKDIR /src		

# copy .csproj file in to the current working directory
COPY ["HaikuWriterApi.csproj", ""] 
# restore the project
RUN dotnet restore "./HaikuWriterApi.csproj" 
# copy thre reset of the files from the current file into the containers working dir.
COPY . .	
# set yet a new working directory 
WORKDIR "/src/."

#build the app and place .exe into /app/build
RUN dotnet build "HaikuWriterApi.csproj" -c Release -o /app/build 

# using the same SDK as above
FROM build AS publish 
# publish into /app/publish
RUN dotnet publish "HaikuWriterApi.csproj" -c Release -o /app/publish 


FROM base AS final 
WORKDIR /app 

COPY --from=publish /app/publish . 
ENTRYPOINT ["dotnet", "HaikuWriterApi.dll"] 