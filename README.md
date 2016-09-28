# Generic_WebService_Caller
Generic .exe program to call simple webservice from a scheduler.

This program can call a web-service with a method called Execute() or Execute(string)

The purpose is to reuse copies of this program and configuration to call different web-services dooing certain task from a scheduler.

It is possible to configure:

1) URL
2) Server list (The same webservice can be called on multiple servers).

Notice: the Web-Service MUST have a namespace of 
* "http://gtx.nu/Services/Automation/V2/ExecuteP0" for the parameterles version 
* "http://gtx.nu/Services/Automation/V2/ExecuteP1" for the version with 1 parameter
