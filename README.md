# Azure Communication Services Job Router Visualization Tool
This is an unofficial tool to test the [Azure Communication Services Job Router](https://learn.microsoft.com/en-us/azure/communication-services/concepts/router/concepts). It will help you visualize the job router compoents, including distribution policieis, queues, workers, and jobs.


## Prerequisites
To run this tool, you need to have the following:
+ An [Azure Communication Services](https://learn.microsoft.com/en-us/azure/communication-services/overview) resource. You can create the resource by following the steps mentioned here [Job Router Prerequesets](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/router/get-started-router?pivots=programming-language-csharp#prerequisites).
+ An [Azure Service Bus](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview) resource with a namespace and queue. You can create the resource by following the public documentation on how to [Use Azure portal to create a Service Bus namespace and a queue](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quickstart-portal).
+ .Net 8.0 or later. You can download it from [.Net download page](https://dotnet.microsoft.com/en-us/download/dotnet).


## Before You Run
After downloading the project and building it using Visual Studio, you need to prepare your environment as follows:
+ Configure your Azure Communication Services resource events to send all Job Router-related events to the Azure Service Bus queue created in the prerequisites. For more information on setting up the events, refer to the [Subscribe to Azure Communication Services events](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/events/subscribe-to-events?pivots=platform-azp) documentation.
+ Modify the `app.config` file inside your project with the following details:
    + `AcsConnectionString`: Your Azure Communication Services resource connection string.
    + `ServiceBusConnectionString`: Your Azure Service Bus resource connection string.
    + `ServiceBusQueueName`: Your Azure Service Bus created queue name.

 
## Notes
+ **This is an unofficial tool that you can use to test the Azure Communication Services Job Router. Use it at your own risk, as there are no guarantees that it is bug-free.**
+ The tool includes several shortcuts for your convenience. For example:
    + You can click on `Options` and then `Refresh` (`CTRL + R`) to manually refresh the lists.
    + You can click on `Options` and then `Legend` (`CTRL + L`) to display the legend window.
+ Some features, such as `Job Matching` Mode and `Classification Policies`, are currently missing but will be added later. However, this will not affect the tool's usability, as these features are optional.


## Key Features
This tool will help you test the Azure Communication Services Job Router by providing the following key features:
+ It visualizes the Job Router components for you, allowing you to see them in tables and understand the relationships between them.
+ You can create and update Distribution Policies, Queues, Workers, and Jobs.
+ It colors the row backgrounds with different colors to make it easier to track changes in component states.
+ It displays different Job Router events based on actions, giving you a better understanding of when events are fired and what information each one contains.
+ You can use it as a proof of concept (POC) to build your distribution policy and workers, and test how jobs will be distributed in different scenarios.
+ The `JobRouterEventParser` project contains a parser for most of the Job Router events (remaining events will be added later), which can be useful if you need a parser.
+ The `ServiceBusReceiver` project is a Service Bus consumer that you can use as a starting point for any other project or service where you need to consume Service Bus events.
+ It helps you test moving components between different states, and provides descriptive error messages if you try to move between unsupported states.


## Screenshots
Below, you can find some screenshots of the tool:
### Policies & Queues
Here, you will be able to manage the Distribution Policies and Queues as follows:
+ Distribution Policies: Create, update, and delete Distribution Policies.
+ Queues: Create, update, and delete Queues.
![image](https://github.com/user-attachments/assets/b7dce367-dee1-4369-8be3-6b180247876c)

### Workers & Jobs
Here, you will be able to manage the Workers and Jobs as follows
+ Workers: Create, update, delete, respond to offers, register, and deregister workers.
+ Jobs: Create, update, delete, cancel job, complete jobs, and close jobs.
From the screenshot, you can notice the coloring scheme that helps identify the states of jobs and workers, as well as the events received from the Azure Service Bus
![image](https://github.com/user-attachments/assets/1b015184-e5bc-47b7-b2ed-bb9e1da57467)

### Legend
You can open this window by navigating to Options and selecting Legend (CTRL + L). This will allow you to see the possible colors for each component

![image](https://github.com/user-attachments/assets/793cc0f1-739c-4b46-973d-270d284744b2)

### Describtive errors
If you attempt to make an unsupported move in a component state, you will receive a descriptive error message, as shown below, which will help you understand the issue

![image](https://github.com/user-attachments/assets/c79bf7e4-1d74-4a28-9b3a-7f07387700c8)


## Reporting Bugs and Suggesting Feature Requests
If you encounter any bugs while using the tool or have any feature requests, please open a [new issue](https://github.com/ealmuneyeer/AzureCommunicationServicesJobRouter/issues/new) on GitHub.
