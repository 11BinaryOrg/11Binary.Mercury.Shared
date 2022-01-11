# 11Binary.Mercury.Shared
This is the message library for the 11Binar Lightweight Messaging Architecture
The Message Classes 
It should now be apparent that all calls to the services are communicated with a universal message format. This format is encapsulated within the ReceivedMessage class. The ReceivedMessage class is an entity that exposes only properties. These property settings are used in determining the route of the message, the company or tenant in a multi-tenant application, the user that called the message originally, and many other properties as described below:
ReceivedMessage Properties:
Property Name	Property Type	Description
Tenant	String	Identifies the company or department within the MythSuite that has an account with 11Binary Technologies. This is the company or department to be billed for the service.
Application	String	The name of the application of the  Tenant that is responsible for the message
Caller	String	The user  name of the caller for the message. This can be an actual user or a account to be used for authentication.
Namespace	String	This is the namespace within the application that will subscribe to the message and act upon it. 
Version	String	The version of the namespace that will be responsible for the action requested. This allows multiple versions of a method to operate in the same Application Domain while still maintaining legacy versions.
Direction	String	This determines whether a message is to be published or is being received from the Observer. The allowable values are “in” and “out”.
ConnectionId	String	The ConnectionId property specifically identified the user in SignalR that is requesting the action and will receive any responses from the request.
CorelationId	String	This is a grouping item for the messages. Using the CorelationId you can see all events within a specific request. This aids DevOps in tracking and replaying events in an Event Source system.This property should resolve to a Guid.
SessionId	String	This is the specific session being utilized between two components of the system. It helps to correctly identify messages as the subscriber returns a result of a publish action. 
Originator	String	This is the specific namespace or channel being listened to by the original caller of the message. When all process managers or state machines are completed this is the namespace to send the final message back and close the CorelationId or Event Source session.
Action	String	The method to call or the filter used  within a class subscriber. This must match the actual method exactly.
Entity	String	This is the type of class that is listening to the message and has a filter to react only to this method, entity and namespace. 
CreatedDt	String	This is the origination date of the message. It is used to determine latency in the application and to uniquely identify records in an immutable system.
To	String	The Namespace or channel that the message should go to. 
ReplyTo	String	The Namespace or channel that should get the reply back after the process or method is complete. This maybe different than the originator at times when processes are calling subprocess listeners. 
WorkflowId	Guid	The actual identifier of a workflow. This is an accessor property  that makes it easier for ProcessManagers and StateMachines to act upon the message. 
WorkflowName	String	The name of the workflow that will be instantiated in the ProcessManager or StateMachine.
WorkflowInstanceId	Guid	A previous instance of a StateMachine or ProcessManager that will be able to continue its work.
Messge	String	This may either be a ActionREquest or an ActionResponse  type. 

The ActionRequest Class Properties

Property Name	Property Type	Description
machineName	String	The name of the device communicating to the service
PageNumber	Integer	The number of the page of data requested. 
PageSize	Integer	The number of the objects per page
SortDirection	String	The direction for the sort requested. This may be either “asc” or “desc”. 
SortColumn	String	The property or column used for the sort
SearchProperty	String	Single property name value pair to search on. 
Search 	String 	SQL Where clause without the where keyord.
Projection	String	Delimited string of properties to return. Usually delimited with a pipe but depends on the service.
ContentType	String	MIME type of the message. Generally this is application Json but may be any type
Message	Dynamic	This is generally a string message but may be any of the MIME types. For instance, a image/jpeg would be in the form of a byte[]
OrderNo	Integer	The order number of the message. This may be used to reassemble the byte[] type into a compleed array for persistence. It is also used as the record number in a single object that can be assembled into an array. This is used to preserve the sort order. 
TotalRecords	Integer	The total number of items to be included within the request. Basically the total number of chunks in a byte[]
		

The ActionResponse Class
Property Name	Property Type	Description
Response	String	This is the received response. It may only include Success, Failure, Error or Completed text strings.
ResponseMessage	String	This is the message returned by the process when it  is operating. This will generally return either a success message such as an object, a failure message that  includes the reason for the failure or an error message that returns the error information. 
Id	String	The Guid as a string that represents the unique identifier of the message being returned. 
ContentType	String	The MIME type of the content being returned in the ResponseMessage field. This is used  fordeserialization of the message.
OrderNo	Int	This si the order number as it was  returned  from the server. It is used for recreating a sort  order from the server or as the order number of a possible byte[] from a binary file. This aids in deserializing the object back to its original state. 
TotalMessages	Integer	The total number of messages expected from the server to satisfy the request. This aids in determining when all messages are received for a specific request.

Failure Message Class
Property Name	Property Type	Description
Id	String	The unique identifier of the failure message. This is generally a Guid converted to string. 
FailureReason	String	This is the reason for the failure. 

Error Message Class
Property Name	Property Type	Description
Id	String	The unique identifier of the failure message. This is generally a Guid converted to string.
ErrorCode	Integer	The .Net Error Code
ErrorReason	String	The .Net exception message
StackTrace	String	The .Net stack trace included in the exception returned. 

