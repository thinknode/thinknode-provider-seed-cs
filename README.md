# thinknode-provider-seed-cs

A starting point for writing C# calculation providers for Thinknode.

# Use

## Prerequisites

- You have created a Thinknode account.
- You have set up a bucket and development realm in your Thinknode account.
- You have created the app under which this calculation provider will be run.

### Windows:

* .NET 4.5 framework
* NuGet
* Docker

### Other:

* mono with .NET 4.5 framework
* NuGet
* Docker

## Step-by-step Instructions

1. Download this repository.
2. Open the file `App/Apps.cs` and add the functions for your app under the `App` class as `public static` methods.
3. Build the image with `docker build -t registry.thinknode.io/your_account_here/your_app_name_here:your_tag_here .`.
4. Push the image with `docker push registry.thinknode.io/your_account_here/your_app_name_here:your_tag_here`.
5. Update the `manifest.json` file with the functions and the provider for your app.
6. Update the app branch using the current commit id. See the route [PATCH /apm/apps/:account/:app/branches/:branch](https://developers.thinknode.com/api/v1.0/services/apm/apps).

Once you install this branch (or release a branch as a version and install the version), you can get a context and start using the app. To test the app seed as provided in this project, use the following sample calculation request.

```
{
  "function": {
    "account": "your_account_here",
    "app": "your_app_name_here",
    "name": "Add",
    "args": [{
      "value": 1
    }, {
      "value": 2
    }]
  }
}
```

Obviously, the result should be `3`.

## Building Manually

The Dockerfile provided in this repository handles building you C# app for you. You can build manually, however, in your local development environment. To build using a tool like Visual Studio, Xamarin Studio, or MonoDevelop, navigate to the App directory within the cloned `thinknode-provider-seed-cs` repository and open the solution `App.sln`. The required packages should begin to download via NuGet. Once the downloads are complete and the packages are installed, use the build button in your IDE to build the App.

To build via the command line, follow the instructions below (*nix operating systems with mono installed only).

1. Navigate to the App directory.
2. Run `/path/to/executable/nuget.exe restore -NonInteractive`
2. Run `xbuild /p:Configuration=Release`

# Contributing

Please consult the [Contributing](CONTRIBUTING.md) guide.