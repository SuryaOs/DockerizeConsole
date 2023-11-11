# Dockerization
This is a Console Application with container orchestration support and retry mechanism.

# Containerization
1) Runs the SQL Server image in the container on the same network after downloading it from the Hub.
2) Used Docker to containerize the Console App and run it in a container with the same network.

# Few Docker Commands to Remember
1) Docker ps - lists all the running container
2) Docker ps -a - lists all the container ( including stopped ones )
3) Docker images - lists all the available images
4) Docker compose up -d - runs the docker-compose file and downloads all the images and kick starts the container in detached mode.
5) Docker compose down - stops the container and removes the container from docker desktop.
6) Docker rm containername or id - removes the container
7) Docker rmi imagename or id - removes the image

# 231110 
# Container Image 
1) It is like read only harddisk ready to be installed on computer where OS is already installed.
2) Similarly, container is computer with Harddisk installed. It can be powered on or off.

# Container Image Software Term
1) Package with all code, dependency, run time to create a container.
2) Image is derived from multiple base images (runtime, codeapp etc.)

# Container
1) Containers are just like a ship container that holds/executes all the artifacts of an app.
2) Container is an running instance of container image
3) They are isolated and easy to ship/run anywhere ( Windows OS or Linux OS ) inside a Docker Host

# Docker File
1) A text file that contains instruction to build a docker image

# Docker
1) It is host for container. containers run on a host inside an OS or VM
2) Docker can host multiple containers (app)

# Docker Desktop
1) To host container in dev environment we can use Docker Desktop that runs inside our Laptop ( Window OS )

# Scale Up
1) you can creae multiple containers from a docker image

