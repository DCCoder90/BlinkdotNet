
# BlinkdotNet

BlinkdotNet is the unofficial .NET implementation of the Blink Monitor Protocol as originally documented by MattTW [here](https://github.com/MattTW/BlinkMonitorProtocol).  
BlinkdotNet allows developers to interact with Blink networks and cameras easily without the need for complicated REST calls.
 
## Build Status

[![Build Status](https://dev.azure.com/dccoder/DCCoders/_apis/build/status/BlinkdotNet-CI?branchName=master)](https://dev.azure.com/dccoder/DCCoders/_build/latest?definitionId=3?branchName=master)

## Release Notes

Currently BlinkdotNet is in an alpha release state, and is availible through Nuget.org.  To download via Nuget Package Manager ensure that you have "Include Prerelease" checked.

## Documentation

Documentation can be found on the [wiki](https://github.com/DCCoder90/BlinkdotNet/wiki)

## Usage

### Getting Started
In order to get started using BlinkdotNet you must first create a new instance of the IBlinkApiClient passing it the login credentials to your [Blink account](https://blinkforhome.com/)

```C#
IBlinkApiClient client = new BlinkApiClient("exampleeamil@example.com", "mys3cretp@ssword");
```

Once you have your IBlinkApiClient implementation you simply call it like so:

```C#
var networks = await client.GetNetworksAsync();
foreach (var network in networks)
{
    Console.WriteLine(network.Name);
}
```

It is important to note that all methods implmented by IBlinkApiClient are asynchronous.