# TAL UI Automation

This project automates the UI using Selenium C# and Specflow.

## Prerequisites
.Net 6 SDK or higher

## Structure
- Features
- Hooks
- Pages
- Step Definitions
- Utils
## Running the Tests
### Command line
From the command line, type `dotnet run`
### Visual Studio
From Test Explorer, run the feature file

## Reports
### Install LivingDoc CLI
Install LivingDoc CLI using `dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`
### Generate Report using
Generate the report using `livingdoc test-assembly <repo root>\TAL\TAL\bin\Debug\net6.0\TAL.dll -t <repo root>\TAL\TAL\bin\Debug\net6.0\TestExecution.json`

Ex. `livingdoc test-assembly D:\Dev\TAL\TAL\bin\Debug\net6.0\TAL.dll -t D:\Dev\TAL\TAL\bin\Debug\net6.0\TestExecution.json`