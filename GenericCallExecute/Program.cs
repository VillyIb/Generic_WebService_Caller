using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using GenericCallExecute.GenericCallP0;
using GenericCallExecute.GenericCallP1;

namespace GenericCallExecute
{
    /// <summary>
    /// Generic program for calling webservices.
    /// Webservice method must be named "Execute" and without parameters.
    /// Configuration settings: (substitute X)
    /// - HostList: http://77.66.63.XXX
    /// - Path: Services/Automation/VX/XXXXXX.asmx
    /// - ReceiveTimeout: 00:10:00
    /// - SendTimeout: 00:10:00
    /// </summary>
    class Program
    {

        private static void LogEndpoint(ServiceEndpoint ep)
        {
            Trace.TraceInformation("    Calling {0}, Namespace {1}", ep.Address, ep.Binding.Namespace);
            Trace.TraceInformation("    ReceiveTimeout {0}", ep.Binding.ReceiveTimeout);
            Trace.TraceInformation("    SendTimeout    {0}", ep.Binding.SendTimeout);
        }


        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            var stopwatch = new EasyStopwatch();

            try
            {
                var settings = new Application();
                Trace.TraceInformation("+Enter {0:yyyy-MM-dd HH:mm} UTC, {1}", DateTime.UtcNow, settings.LogHeadline);

                // ReSharper disable once LoopCanBePartlyConvertedToQuery
                foreach (var host in settings.HostList)
                {
                    var stopwatch2 = new EasyStopwatch();

                    try
                    {
                        var ub = new UriBuilder(host);
                        ub.Path += settings.LocalPath;

                        switch (settings.ParmeterCount)
                        {
                            case 0:
                                using (var remote = new ShipmentEventPollSoapClient("ShipmentEventPollSoap12"))
                                {                                   
                                    remote.Endpoint.Address = new EndpointAddress(ub.Uri);
                                    remote.Endpoint.Binding.ReceiveTimeout = settings.ReceiveTimeout;
                                    remote.Endpoint.Binding.SendTimeout = settings.SendTimeout;

                                    LogEndpoint(remote.Endpoint);

                                    var t1 = remote.Ping();
                                    Trace.TraceInformation("    Ping: {0}", t1);

                                    var status = remote.Execute();
                                    Trace.TraceInformation("    {0}", status);
                                }
                                break;

                            case 1:
                                using (
                                    var remote =
                                        new ShipmentEventPollSpecificSoapClient("ShipmentEventPollSoap12"))
                                {
                                    remote.Endpoint.Address = new EndpointAddress(ub.Uri);
                                    remote.Endpoint.Binding.ReceiveTimeout = settings.ReceiveTimeout;
                                    remote.Endpoint.Binding.SendTimeout = settings.SendTimeout;

                                    LogEndpoint(remote.Endpoint);
                                    Trace.TraceInformation("    Parameter    '{0}'", settings.Parameter);

                                    var status = remote.Execute(settings.Parameter);
                                    Trace.TraceInformation("    {0}", status);
                                }
                                break;

                            default:
                                Trace.TraceInformation("Unsupported settings.ParmeterCount > 1");
                                break;
                        }

                    }

                    catch (Exception ex)
                    {
                        // Notice it is required that the web-serwice classes refer to the same namespace
                        // 


                        Trace.TraceInformation("    Exception: {0}", ex.Message);
                    }

                    finally
                    {
                        var t1 = String.Format("    finished, duration: {0,8:#,##0} ms", stopwatch2.Stop());
                        Trace.TraceInformation(t1);
                    }

                } // loop

            }

            catch (Exception ex)
            {
                Trace.TraceInformation("    Exception: {0}", ex.Message);
                Environment.Exit(1);
            }

            finally
            {
                var t1 = String.Format("-Exit, duration: {0,8:#,##0} ms\r\n", stopwatch.Stop());
                Trace.TraceInformation(t1);
            }
        }
    }
}
