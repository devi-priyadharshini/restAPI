# REST, RESTApi, RESTFul Web Service

WWW and internet are different.
Hypertext - linking text with other document. Ex: Contact Us (Link) - text with links to Contact Us page. 
HyperMedia - linking text with any format of document, - audio, video etc

Service: A piece of code/software which is executed on request. Service runs in a single machine
Web Service: Service available on the internet and are avaialble for clients to request this service.
API:  API is an operation that service exposes for clients can use/run. This reduces the reinventing of wheels of doing the same operation by clients.
Web API: API available on the web.

Difference Between Web API and Web Service:

       Web API       Web Service
1. Interface               facilitates interaction of 2 machines over internet? 

All Web Services are APIs, But All APIs are not Web Service - Find?

Web API can follow any of the 3 web architecture style - SOA(service oriented?), OOA(Object Oriented?), and ROA(Resource Oriented)
ROA:
Resource: Anything that is stored in computer.
Resource Provider: Server that provides resource.
Resource Representation: Information/state of a resource in a specific format.
Resource link and connectedness: Links to the resource or other resources. How closedly the suggested links are connected(related) with each other.
Statelessness: Server will not store any data.
Uniform interface: All services should be managed and implemented in same way

Web API with 6 Constraints of Scalability implemented is a REST API.

#### REST - REpresentational State Transfer.

       Transfer of state of a resource through a representation.
       Representation is not the resoure itself. Representation - format how resources data/information are transferred between server and clients.
       Representation format - .csv, html document, XML, JSON etc...
       Resource based(Nouns) and not Action based(SOAP API - Verbs).
       
       An architecture style or one of the way for communication of 2 or more services/systems to manipulate a resource available over the internet.
       REST is based on HTTP.
       REST enforces constraints on Server and Client interaction.
       
       Key Points:
       REST Uses,
              - HTTP
              - ROA
              - Client Server
              - Stateless
              
       REST Communication Flow:
       
       HTTP Request - URI, HTTP Method, Header, Request Body
       HTTP Response - Response Body, HTTP Response Code
       
#### HTTP : Hyper Text Transfer Protocol(Communication Protocol). 
              Protocol for 2 applications(Client - Server architecture) to talk to one another(Request/Response model) over web through HTTP Methods.
              HTTP Methods - GET, POST, PUT, DELETE (PATCH And UPDATE ? )
              HTTP is Stateless
              HTTP Request/ Http Response : Header(Request/Response/General) and Body(Request/Response)
              ![image](https://user-images.githubusercontent.com/21195523/209651247-cb6b92db-c403-4490-af1c-b9330ea8abbf.png)

HTTP Status Codes:
![image](https://user-images.githubusercontent.com/21195523/209651892-e99b7302-ae6d-4339-bdf4-20bd35c36ddb.png)

### RESTApi - API which meets the 6 architetural constraints.
1. Uniform Interface -  Communication between client and servers should follow uniformity. i.e, way by which a resource is identified, added, updated or removed should be uniform for any resources. This is achieved by using HTTP Methods(GET, PUT, POST, DELETE). 
      **Guidelines :** 
            1. Identification of resources - Every resources in the internet should be identified by unique Identifier - URI(Unique Resource Identifier)
            2. Resource Manipulation - Client has the baility to manipulate the representation of resource. **Content Negotiation** - Client can specify the request's response format in header using **Accept:** field.
            3. Self-Descriptive messages:  Stateless communication. If state has to be maintained, then the client should do the same and pass the required info for the server to process. Ex: Authorization and Authentication.
            4. HATEOAS - Hypermedia As The Engine Of Application State : Response of API or state of resource should include links to other related resources.
            
2. Client-Server - 
3. Stateless
4. Cacheable
5. Layered system
6. Code on Demand(Optional)

RESTFul Web Service - Web Services which has REST constraints implemented. 

Design URI/URL API:
- API should provide service to anything(from computer to smart watch and IOT devices...), anywhere, anytime.
- API should be easy to understand.
- Authentication and Authorization support
- Consistency in designing API. (Once decided should be followed througout in designing API?)
-  
Design Rules:

RFC 3986 Document says Generic URI Sequence should have 5 elements in Order:


#### REST Projects included in this repo:

1. Rest API using .Net Core
   Created a REST API endpoints using .Net core by following the tutorial -"https://www.youtube.com/watch?v=fmvcAzHpsk8".
