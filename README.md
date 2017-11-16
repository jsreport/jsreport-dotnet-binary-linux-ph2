# jsreport.Binary.Linux.Ph2
[![Build status](https://ci.appveyor.com/api/projects/status/u9gpo8myynsx174b?svg=true)](https://ci.appveyor.com/project/pofider/jsreport-dotnet-binary-linux-ph2)
[![Build Status](https://travis-ci.org/jsreport/jsreport-dotnet-binary-linux.png?branch=master)](https://travis-ci.org/jsreport/jsreport-dotnet-binary-linux-ph2)
[![NuGet](https://img.shields.io/nuget/v/jsreport.Binary.Linux.Ph2.svg)](https://nuget.org/packages/jsreport.Binary.Linux.Ph2)

This package includes the raw [jsreport.exe binary for linux](https://jsreport.net/learn/single-file-executable) embedded in the manifest stream. See more info in the similar windows based package [jsreport.Binary](https://github.com/jsreport/jsreport-dotnet-binary).

**The linux binary can be used the same way as windows one. Just make sure your linux hosting server includes `libfontconfig`. You can do this using the following snipped if you use the default VS generated dockerfile.**

```docker
RUN apt-get update && \   
    apt-get install -y libfontconfig1
```