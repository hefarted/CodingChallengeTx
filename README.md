# CodingChallengexTx

## Overview

Coding Challenge for XTX - (Confidential)

## Features

- **Hello World Endpoint**: A quick test endpoint to ensure the API is running.
- `POST /InterfaceAP`: An endpoint to submit expense data with validations on mandatory fields, currency codes, and date ranges.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- .NET 8.0 SDK
- Visual Studio 2022 or a similar IDE that supports .NET development
- Postman for testing API endpoints (optional)

### Installing

A step by step series of examples that tell you how to get a development environment running:

1. Clone the repository to your local machine using `git clone`.
2. Open the solution file (`.sln`) in Visual Studio or your preferred IDE.
3. Restore NuGet packages by running `dotnet restore`.
4. Build the solution by running `dotnet build`.
5. Start the API by running `dotnet run` or using the IDE's run functionality.

## Running the Application with Visual Studio

Follow these steps to get the application up and running with Visual Studio:

1. **Open the Project**:
   - Launch Visual Studio.
   - Select 'Open a project or solution'.
   - Navigate to the directory where you cloned the repository and select the solution file (`.sln`).

2. **Restore NuGet Packages**:
   - Right-click on the solution in Solution Explorer.
   - Select 'Restore NuGet Packages' to ensure all dependencies are properly installed.

3. **Build the Solution**:
   - Right-click on the solution in Solution Explorer.
   - Select 'Build Solution' to compile the project.

4. **Run the Application**:
   - Set the API project as the startup project by right-clicking on it in Solution Explorer and selecting 'Set as StartUp Project'.
   - Press `F5` or click on the 'IIS Express' button to start debugging and run the application.
   - Visual Studio will start the IIS Express server and run your application. The Swagger UI will typically open automatically in your default browser, allowing you to interact with the API endpoints.

## Usage

After running the application, you can:

- Access the Swagger UI at `https://localhost:<port>/swagger` to interact with the API if you are in the development environment.
- Use Postman or any other HTTP client to make requests to the available endpoints.

## Built With

- [.NET 8.0](https://dotnet.microsoft.com/) - The framework used

## Contributing

Please read [CONTRIBUTING.md](/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

- Elvin Inapan

See also the list of [contributors](https://github.com/your_project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

