@echo off
cd /d "%~dp0SmartCrossing\publish"
dotnet SmartCrossing.dll --urls "http://localhost:5050"
pause