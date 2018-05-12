# DevOps.Code.DataAccess.Interfaces.CacheService

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-interfaces-cacheservice.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-interfaces-cacheservice)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Interfaces.CacheService.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Interfaces.CacheService)

## Description

Interface for a generic data-access cache

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Code.DataAccess.Services.CacheService](https://github.com/CDorst/DevOps.Code.DataAccess.Services.CacheService) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-services-cacheservice.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-services-cacheservice) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Services.CacheService.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Services.CacheService)
[DevOps.Code.DataAccess.Services.CachedDataRepository](https://github.com/CDorst/DevOps.Code.DataAccess.Services.CachedDataRepository) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-services-cacheddatareposito.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-services-cacheddatareposito) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Services.CachedDataRepository.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Services.CachedDataRepository)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Interfaces.CacheService](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Interfaces.CacheService)

## Version

1.0.2

## Metaproject

DevOps.Code.DataAccess.Interfaces.CacheService is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

