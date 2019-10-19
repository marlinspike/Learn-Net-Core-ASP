## Purpose
This **ASP Dotnet Core 3** project is meant to illustrate a basic CRUD application, which can then be Dockerized and run as a container.

## Requirements
All you'll need is a SQL DB, even the free [Express Edition](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express). Add your config string to the
**appsettings.json** or **appsettings.Development.json** (depending on where/how you're running the app), then run Entity Framework **Update-Database** to have the
tables automatically created for you. That's it.

To use Docker, you'll obviously need to have the right version of it installed on your machine.

## Dockerizing the app
A Dockerfile is already included in the source. Just create an image and run it as a container like so:

### Creating a Docker image
Navigate to the project root directory, and enter the following command:
~~~
docker build -t coreasp -f Dockerfile .
~~~
This creates an image called **coreasp**, based on the Dockerfile in the root of the project

Once the image is created, to see it type the following command:
~~~
docker image list
~~~
You should see your Docker image there

### Running a container
To a run a container based on the image created above, enter the following command:
~~~
docker container run -p 8080:80 coreasp
~~~

Then on your browser, navigate to **localhost:8080**. The **-p** section of the command maps local port 8080 to the container port 80

