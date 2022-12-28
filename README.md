# REST, RESTApi, RESTFul Web Service

WWW and internet are different.
Hypertext - Visible Text of an URI 
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

### API URI/URL :
- API should provide service to anything(from computer to smart watch and IOT devices...), anywhere, anytime.
- API should be easy to understand.
- Authentication and Authorization support for security.
- Consistency in designing API. (Once decided should be followed througout in designing API?)

API Design Rules:

From RFC 3986(Request For Comment)Document, Generic URI Sequence, should have 5 elements in Order:
![Gerneric URI Sequence](https://user-images.githubusercontent.com/21195523/209769349-177b695c-ae3f-41ad-ad0e-a240583b472d.png)
       1. Scheme - mandatory and case sensitive ex: http, https, ftp, mailto etc.. 
       Rest uses only HTTP and HTTPS.
       2. Authority - optional - 3 info
               User Info: username and passwords
               Host : Ip address
               Port : server port
               ex: 1. https://username:password@host:port - with authority
                   2. https://www.youtube.com
                   3. https://localhost:8080 or https://127.0.0.1:8080
                   localhost == 127.0.0.1
                   
       3. Path - Path of resource, hierarchial and resemble file system.
              Ex: https://github.com/devi-priyadharshini/restAPI
              
       4. Query - Optional - fine tune the result
       5. Fragment - starts with #sign. to jump to part of the application. This info is not used by REST?
       
       URI elements reserved special characters - :, ?, #, [] and @ 

RULE 1: Proper hierarchy
RULE 2: Avoid Trailing "/" - no value cause confusion(assumes something is missing)
RULE 3: Use hypen instead of underscore or space - increases readability
RULE 4: User only lowercase (may skip for query parameters) 
RULE 5: Do not include file extension in URI. This tightly couples service to single user.
         Specify the file/resource format in request header. Content-type
         Ex: ![URI with Format and Without Format](https://user-images.githubusercontent.com/21195523/209782496-4048a9dc-03af-4c6a-8227-0e7cadc9b779.png)

### Resource Modelling

URI should represent Individual Resource.
Resource type can be one among the following four:
1. Document - Single entity. Resource representation includes Fields and Values.
2. Collection - Collection of entity, managed by server. Client request manipulation of resource to the server. Server decides to do the operation against the resource.
3. Store - Collection of entity, managed by client. Client can update/modify anything to the store.
Difference between collection and store?
4. Controller - executable function takes some input and returns output.
                Actions cannot be mapped with std CRUD methods - i.e, it will not get, create, update or delete entity. Rather, it performs an action. 
                Controller name appears at very last. Example API with Controller Resource Type?      
                
Resources should be aligned with one of above 4 types.

Before designing URI, resource should be modelled first. Then resource URI is designed.

How to Design URI that models Resources(above type):

 Forward slash - represents relationship between resources.
 Naming Convention:
       Rule 6: Document Resource type - Singular Noun; Ex - https://www.yautube.com/users/user1
       Rule 7: Collection - Plural Noun or Plural phrase? Ex - https://www.yautube.com/users
       Rule 8: Store - Plural Noun or Plural phrase Ex -  https://www.yautube.com/users
       Rule 9: Controller - Verb or Verb phrase Ex - https://www.yautube.com/users/user1/DeleteVideos

Rules Related to Variable segments of path.

       Rule 10: Ex URI: http://www.youtube.com/users/user123/videos/vid123
       Static Segments - do  not change Ex: scheme, host, port, users and videos
       dynamic segments - user123 and vid123 - changes based on resource. naming convention: should be alpha numeric
 
       Rule 11: Do not use CRUD function name in URL. Same URI, HTTP method defines the operation.
                should be GET: https://www.yautube.com/users/user1

#### REST Projects done in this repo:

1. RestAPI using .Net Core
   Created a REST API endpoints using .Net core by following the tutorial -"https://www.youtube.com/watch?v=fmvcAzHpsk8".
   
   
### References:

1. What is REST? 
       https://www.restapitutorial.com/lessons/whatisrest.html#
       https://www.youtube.com/watch?v=rZnutXrml_U&list=PLqwmiTs6Z6PG9-0JT_Zt_gKCxyshjCwEA&index=1

2. API Guide
       https://www.moesif.com/blog/api-guide/
       
   
  
