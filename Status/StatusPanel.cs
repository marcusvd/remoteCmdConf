namespace remoteCmdConf;
using System.ServiceProcess;

public class StatusPanel
{
    string serviceName = "remoteCmd";

    public string CheckServiceStatus()
    {
        try
        {
            var sc = new ServiceController(serviceName);

            var currentStatus = sc.Status;

            switch (currentStatus)
            {
                case ServiceControllerStatus.Running:
                    return "running";
                case ServiceControllerStatus.Stopped:
                    return "stopped";
                case ServiceControllerStatus.Paused:
                    return "paused";
                case ServiceControllerStatus.StartPending:
                    return "starting";
                case ServiceControllerStatus.StopPending:
                    return "stopping";
                default:
                    return "Unknown or intermediate status.";
            }
        }
        catch (InvalidOperationException ex)
        {
            return $"Error: The service '{serviceName}' was not found.";
        }
        catch (System.ComponentModel.Win32Exception ex)
        {
            return $"Permission error: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Unexpected error: {ex.Message}";
        }


    }

    public string StartStopServices(string serviceAction)
    {
        try
        {
            var sc = new ServiceController(serviceName);
            if (serviceAction == "start")
            {
                sc.Start();
                return "Service started.";
            }

            if (serviceAction == "stop")
            {
                sc.Stop();
                return "Service stoped.";
            }

        }
        catch (Exception ex)
        {
            return ex.Message;
        }

        return "Unknown error...";

    }
}