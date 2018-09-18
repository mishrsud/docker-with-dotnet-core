# Summary
This sample demonstrates using a docker multi-stage build to build a containerised dotnet core console app

## Prerequisites
- Docker for the platform you run this on (Windows, Mac, Linux)
- If you want to debug locally, you'll need dotnet core SDK

## How to use
To build the image:
- Open a terminal/command prompt with the path set to the directory that contains the dockerfile
- Run the following from a terminal/command prompt
```bash
docker build -t simple-daemon .
```
- This will produce an image called simple-daemon. You can spin up a container from the image as follows
```bash
docker run simple-daemon
# should print Hello World
```