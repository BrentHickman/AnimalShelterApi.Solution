# AnimalShelterApi.Solution
# AnimalShelterApi
#### An API for Cats and Dogs available for adoption.

#### By Brent Hickman

## Technologies Used

* C#
* Dotnet 6
* Entity Framework Core
* MySQL
* Html
* Css
* Swagger UI


## AnimalShelterApi is an API for Cats and Dogs available for adoption. Users can filter by species in V1. In V2 you can also narrow results to only puppies or kittens. 

## Setup/Installation Requirements

* Open a terminal window and clone this repository by entering into the command line:
> git clone https://github.com/BrentHickman/AnimalShelterApi.Solution.git
* In the terminal, navigate to the console application with the command:
> cd AnimalShelterApi.Solution/AnimalShelterApi
* Once in the "AnimalShelterApi" directory, create a new file called appsettings.json
* Within appsettings.json, put in the following code, replacing the [YOURUSERNAME] and [YOURPASSWORD] values with your own username and password for MySQL.
>{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5001;database=shelter_api;uid=[YOURUSERNAME];pwd=[YOURPASSWORD];"
  }
}
* Next, enter the following into the command line:
> dotnet ef database update
* To launch the application in development mode, enter the following lines into the command line:
> dotnet restore
* then:
> dotnet watch run
* The API should now be accessable through Swagger UI here:
> https://localhost:5001/swagger/index.html
* Please note there are two versions of this API available through Swagger UI.
* You can change between versions using the 'Select a definition' dropdown in the top right of Swagger UI.
* Endpoints for AnimalShelterAPI V1 :
>GET https://localhost:5001/v1/animals

>GET https://localhost:5001/v1/animals/{id}

>GET https://localhost:5001/v1/Animals?species={species}

>POST https://localhost:5001/v1/animals

>PUT https://localhost:5001/v1/animals/{id}

>DELETE https://localhost:5001/v1/animals/{id}

* Endpoints for AnimalShelterAPI V2 :
>GET https://localhost:5001/v2/animals

>GET https://localhost:5001/v2/animals/{id}

>GET https://localhost:5001/v2/Animals?species={species}

>GET https://localhost:5001/v2/Animals?young=true

>GET https://localhost:5001/v2/Animals?species={species}&young=true

>POST https://localhost:5001/v2/animals

>PUT https://localhost:5001/v2/animals/{id}

>DELETE https://localhost:5001/v2/animals/{id}

* The difference between V1 and V2 lies in the GET query paramaters available.
* V1 supports filtering the API by {species} with:
>GET https://localhost:5001/v1/Animals?species={species}
* V2 adds support for the additional 'young' boolean paramater. 
* users can use this pathway to return all puppies and kittens:
>GET https://localhost:5001/v2/Animals?young=true
* or this pathway to return only puppies:
>GET https://localhost:5001/v2/Animals?species=dog&young=true
* or this pathway to return only kittens:
>GET https://localhost:5001/v2/Animals?species=cat&young=true

## Known Bugs

* If you are experiencing any bugs, please contact me at brenthickman@ymail.com

## License

* [MIT](https://opensource.org/licenses/MIT)
* Brent Hickman 3/24/23