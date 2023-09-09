# Dockerization
This is a Console Application with container orchestration support.

# Containerization
1) Runs the SQL Server image in the container on the same network after downloading it from the Hub.
2) Use Docker to containerize the Console App and run it in a container with the same network.

# Few Docker Commands to Remember
Docker ps - lists all the running container
Docker ps -a - lists all the container ( including stopped ones )
Docker images - lists all the available images
Docker compose up -d - runs the docker-compose file and downloads all the images and kick starts the container in detached mode.
Docker compose down - stops the container and removes the container from docker desktop.
Docker rm <containername> or <id> - removes the container
Docker rmi <imagename> or <id> - removes the image
