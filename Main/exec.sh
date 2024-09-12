#!/bin/bash

dotnet build Main.csproj
clear
dotnet exec /var/www/html/lenguajes/cPlus/eCommerce/Main/bin/Debug/net8.0/Main.dll