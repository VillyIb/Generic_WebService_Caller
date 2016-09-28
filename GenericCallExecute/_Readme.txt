File: GenericCallExecute

This application is able to be configured to call a webservice with a standard metod of Execute() or Execute(String).


Settings:

* LogHeadline
	First line of text in logfile.

* HostList
	A list of Hostnames must be provided, minimum one host must be specified
	If more hosts are provide are they called one by one.
	Eg.: "http://77.66.63.25"

* LocalPath
	The path to the Web-Service
	Eg.: Services/Automation/V2/ShipmentEventPoll.asmx

* ParmeterCount
	0: calls method Execute()
	1: calls method Execute(string) with the parameter setting.

* Parameter
	A string parameter

* ReceiveTimeout
	Default value is 10 minutes

* SendTimeout
	Default value is 1 minute
	Extend this value if the remote Web-Service takes long time to execue.
	30 minutes or more can be required.

