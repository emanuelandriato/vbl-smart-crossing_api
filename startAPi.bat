@echo off
cd /d "%~dp0SmartCrossingAPI\SmartCrossing\publish"
dotnet SmartCrossing.dll --urls "http://localhost:5050"
pause