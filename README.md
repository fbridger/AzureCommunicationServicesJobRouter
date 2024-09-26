# AzureCommunicationServicesJobRouter
This is an unofficial tool to test the [Azure Communication Services Job Router](https://learn.microsoft.com/en-us/azure/communication-services/concepts/router/concepts). It will help you in visualizing the job router compoents including Distribution policieis, queues, workers, and jobs.


## Prerequesets
To run this tool you need to have:
+ An [Azure Communication Services](https://learn.microsoft.com/en-us/azure/communication-services/overview) resource. To create the resource you can follow the prerequests mentioned here [Job Router Prerequesets](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/router/get-started-router?pivots=programming-language-csharp#prerequisites)  
+ An [Azure Service Bus](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview) resource with a namespace and queue. To create the resource you can follow the public documentation [Use Azure portal to create a Service Bus namespace and a queue](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quickstart-portal)
+ You need to have .Net 8.0 or later. You can download it from [Download .Net](https://dotnet.microsoft.com/en-us/download/dotnet)


## Before you run
Once you download the project and build it using Visual Studio, you need to prepare your environment as following:
+ Configure your Azure Communication Services resource Events to send all the Job Router related events to the Azure Service Bus created queue from the Prerequests above. For more information about how to setup the Events, you can check [Subscribe to Azure Communication Services events](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp).
+ Modify app.config file inside your project as following:
    + AcsConnectionString: Your Azure Communication Services resource connection string
    + ServiceBusConnectionString: Your Azure Service Bus resource connection string
    + ServiceBusQueueName: Your Azure Service Bus created queue name

 
## Notes
+ This is an unofficial tool that you can use to test the Azure Communication Services Job Router.
+ You have multiple shortcuts in the tool. For example:
    + You can click Options --> Refresh (CTRL + R) to refresh the lists manually
    + You can click Options --> Legend (CTRL + L) to display the legend window


## Key features:
This tool will help you in testing the Azure Communication Services Job Router by providing the following key features
+ It will vizualize the Job Router compoents for you, so you will be able to see them in tables and understand the relations between them
+ You will be able to create and update Distribution Policies, Queues, Workers, and Jobs
+ It will be coloring the rows backgrounds with different colors to ease tracking the changes of compoensts state
+ It will display the different Job Router events depending on the actions, so you will have a better understanding of events, when they will be fired, and what information each one will have
+ You can use it as a POC to check how you can build your distribution policy and workers and test how the jobs will be distributed under different scnearios
+ JobRouterEventParser project contains a parser for most of the Job router events (Remaing events will be added later) so it can be useful in case you want a parser
+ ServiceBusReciver project is a Service Bus consumer which you can use as a starting point with any other project or service where you need to consume Service Bus events.
+ Help you in testing moving components between different state, and a describtive error message will be displayed if you tried to move between unsupported states


## Screenshots:
Following you can see some screenshots for the tool
### Policies & Queues
Here you will be able to control the Distribution Policies and Queues as following:
+ Distribution Policies: create, update and delete Distribution Policy
+ Queues:  create, update and delete a Queue
![image](https://github.com/user-attachments/assets/b7dce367-dee1-4369-8be3-6b180247876c)

### Workers & Jobs
Here you will be able to control Workers as Jobs as follows:
+ Workers: create, update, delete respond to offer, register, and deregister
+ Jobs: Create, update, delete, cancel job, complete job, and close job
From the screensho, you can notice the coloring scheme that will help you in identifying the jobs and workers state, also, the events recived from the Azure Service Bus
![image](https://github.com/user-attachments/assets/1b015184-e5bc-47b7-b2ed-bb9e1da57467)

### Legend
You can open this window from Options -> Legend (CTRL + L) where you will be able to see the possible colors for each compoenent
![image](https://github.com/user-attachments/assets/793cc0f1-739c-4b46-973d-270d284744b2)

### Describite errors
If you try to make an unsupported move in a compoent state, you will have a descirbtive error message as following which will help you in understanding what is the issue
![image](https://github.com/user-attachments/assets/c79bf7e4-1d74-4a28-9b3a-7f07387700c8)

### Other windows
Create distribution policy

  ![image](https://github.com/user-attachments/assets/2957fb3d-fc07-4a8a-9963-e6c37a1af1a9)

Create Queue

![image](https://github.com/user-attachments/assets/85eb7ee5-9959-4a63-ab33-42acd0cf2204)

Create worker

![image](https://github.com/user-attachments/assets/0ca40aba-4ffb-4c49-9209-622c96875f06)

Respond to job offer

![image](https://github.com/user-attachments/assets/0c3f96aa-2d2b-434c-a635-d5563a94d60c)


Create Job

![image](https://github.com/user-attachments/assets/3cd8fc7a-7538-4d0f-a9fd-e4633c0c7565)


