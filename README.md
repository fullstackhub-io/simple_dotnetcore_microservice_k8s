# Simple .NET Core 6 API/Angular Front End on Kubernetes

 - Install the [Docker Desktop](https://docs.docker.com/desktop/windows/install/) ![image](https://user-images.githubusercontent.com/35650464/149685343-5d16185e-95df-4c04-8033-51f1145430b0.png)

 - Enable the Kubernetes.
 -  Create the docker images by command & visual studio. e.g. **docker build -t simpleappclient .** in **simple_dotnetcore_microservice_k8s\clientApp** folder and right click on **Dockerfile** in **simple_dotnetcore_microservice_k8s\SimpleApp.API\SimpleApp.API** folder and select "Build Docker Image".
 - Browse the K8s folder and run the following commands:
	   - kubectl apply -f ./simpleappapi.yaml  
	   - kubectl apply -f ./simpleappclient.yaml
 - Brose the following URL: http://localhost:4200/ 
 
 ![image](https://user-images.githubusercontent.com/35650464/149685377-361e35d9-52f4-4565-8439-23c8a5b05357.png)

