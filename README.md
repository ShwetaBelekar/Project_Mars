# Project_Mars
Automate test cases for Project_Mars.
Project Mars is a .Net-based test automation framework using Visual Studio,ReqnRoll,Selenium WebDriver,NUnit and C# language. This framework is designed
to test wed application with a clean, maintainable structure.

Overview

This framework provides automated functional testing for web applications with the following features:

•Reqnroll: Implements Cucumber's Gherkin syntax for readable tests

•Selenium WebDriver: Handles browser interactions

•NUnit: Manages test execution and assertions

•Page Object Model (POM): Separates test logic from page interactions


Prerequisites

• .NET SDK: Version 8.0 or higher (install from dotnet.microsoft.com)

• IDE: Visual Studio Code or Visual Studio (recommended)

• Chrome Browser: Required for Selenium WebDriver (ChromeDriver version must match your browser version via
WebDriverManager)


Project Structure

•Features         # Gherkin feature files
•Steps            # C# step implementations
•Pages            # Page Object Model classes
•Utilities        # For the process on inheritance
•Hooks            # Before and After logic
