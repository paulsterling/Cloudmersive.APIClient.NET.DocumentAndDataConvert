﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/convert -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client

# Cleanup





$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.DocumentAndDataConvert/Cloudmersive.APIClient.NET.DocumentAndDataConvert.csproj
$csprojtestpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.DocumentAndDataConvert.Test/Cloudmersive.APIClient.NET.DocumentAndDataConvert.Test.csproj
$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.DocumentAndDataConvert/Cloudmersive.APIClient.NET.DocumentAndDataConvert.nuspec
$slnpath = Resolve-Path ./client/Cloudmersive.APIClient.NET.DocumentAndDataConvert.sln


(Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Cloudmersive Convert API Client</title>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>Convert files and data effortlessly. Convert DOCX to PDF. Convert CSV to JSON. And much more.</description>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath







./nuget.exe restore $csprojpath -SolutionDirectory ./client

./nuget.exe restore $csprojtestpath -SolutionDirectory ./client

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe $slnpath /t:rebuild 

./nuget.exe pack $csprojpath