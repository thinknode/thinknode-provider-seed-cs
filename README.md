# thinknode-provider-seed-cs

A starting point for writing C# calculation providers for Thinknode.

## Introduction

This repository serves as a starting place for writing Thinknode calculation providers in C#. This repository comes comes complete with a fully functioning app called `math` with various functions that demonstrate how you may integrate your C# classes and algorithms into the provider. This document will provide information on how to clone, modify, and build the app for local debugging purposes and how to Dockerize your app as an image that can be pushed up to the Thinknode repository.

## Prerequisites

### Windows:

* .NET 4.5 framework
* NuGet available on your PATH
* git
* Docker

### Other:

* mono with .NET 4.5 framework
* NuGet executable
* git
* Docker

Once these have been obtained, clone the repository with the following command: `git clone https://github.com/thinknode/thinknode-provider-seed-cs.git`

## Building

To build in a tool like Visual Studio, Xamarin Studio, or MonoDevelop, navigate to the App directory within the cloned `thinknode-provider-seed-cs` repository and open the solution `App.sln`.

To build via the command line, follow the instructions below (*nix operating systems with mono installed only).

1. Navigate to the App directory.
2. Run `/path/to/executable/nuget.exe restore -NonInteractive`
2. Run `xbuild /p:Configuration=Release`

## Dockerizing

Run the command below, replacing `account`, `app`, and `tag` with the correct values:

```
docker build -t registry.thinknode.com/account/app:tag .
```