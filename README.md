# Noel's Bakery

### By Noel Kirkland, 7/24/2020

## Description

This is a web application that will allow a bakery owner to keep track of their vendors and keep track of which order is from which vendor.

## Specifications

1. The application will create an object instance of Order with an argument of _order title,_ _order date,_ _order description,_ and _order price_

    | Input | Output |
    | :--- | :--- |
    | Order("scones", "7/24/2020", "we ordered 50 scones but we might need more soon", 110.00); | Order { Title="scones", Date="7/24/2020", Description="we ordered 50 scones but we might need more soon", Price=110.00 } |
    |||

2. The application will compile all instances of the Order class into a list.

    | Input | Output |
    | :--- | :--- |
    | Order("scones", "7/24/2020", "we ordered 50 scones but we might need more soon", 110.00); | List<Order>(1){ Order { Title="scones", Date="7/24/2020", Description="we ordered 50 scones but we might need more soon", Price=110.00} } |
    |||

3. The application will assign every instance of the Order class with a unique ID

    | Input | Output |
    | :--- | :--- |
    | Order("scones", "7/24/2020", "we ordered 50 scones but we might need more soon", 110.00); | Order { Title="scones", Date="7/24/2020", Description="we ordered 50 scones but we might need more soon", Price=110.00, Id=1 } |
    |||

4. The application will return a specific instance object with an argument of ID number

    | Input | Output |
    | :--- | :--- |
    | Order.Find(1); | Order { Title="scones", Date="7/24/2020", Description="we ordered 50 scones but we might need more soon", Price=110.00, Id=1 } |
    |||

5. The application will create an object instance of Vendor with an argument of _vendor name,_ and _vendor description_

    | Input | Output |
    | :--- | :--- |
    | Vendor("Grand Central", "best source of scones and danishes in Portland"); | Vendor { Name="Grand Central", Description="best source of scones and danishes in Portland" } |
    |||

6. The application will compile all instances of the Vendor class into a list.

    | Input | Output |
    | :--- | :--- |
    | Vendor("Grand Central", "best source of scones and danishes in Portland"); | List<Vendor>(1){ Vendor { Name="Grand Central", Description="best source of scones and danishes in Portland"} } |
    |||

7. The application will assign every instance of the Vendor class with a unique ID

    | Input | Output |
    | :--- | :--- |
    | Vendor("Grand Central", "best source of scones and danishes in Portland"); | Vendor { Name="Grand Central", Description="best source of scones and danishes in Portland" Id=1 } |
    |||

8. The application will return a specific instance object with an argument of ID number

    | Input | Output |
    | :--- | :--- |
    | Vendor.Find(1); | Vendor { Name="Grand Central", Description="best source of scones and danishes in Portland" Id=1 } |
    |||

9. The application will add a list of orders into an instance of Vendor

    | Input | Output |
    | :--- | :--- |
    | Vendor("Grand Central", "best source of scones and danishes in Portland"); | Vendor { Name="Grand Central", Description="best source of scones and danishes in Portland" Id=1 Orders=List<Order>(1){ Order { Title="scones", Date="7/24/2020", Description="we ordered 50 scones but we might need more soon", Price=110.00, Id=1 } } } |
    |||

## Setup/Installation Requirements

* _Install the framework_
  1. This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)

* _Download this application from HitHub_
  1. _Open the following web address in your browser: `https://github.com/NoelKirkland`_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the `noel-s-bakery` repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Open and run the application_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command **`> cd Bakery`**_
  3. _Now that we are in the Bakery directory you will run the command **`> dotnet restore`**_
  4. _Once the "obj" folder has initialized you can now run **`> dotnet run`** to use the application in your terminal_

* _Optional testing_
  1. _To run the test suite included with this project you will first need to navigate back to the root directory by running **`> cd ..`** in your terminal._
  2. _Move to the to the Bakery.Tests directory by running the command **`> cd Bakery.Tests`**_
  3. _Now that we are in the Bakery.Tests directory you will run the command **`> dotnet restore`**_
  4. _Once the "obj" folder has initialized you can now run **`> dotnet test`** to run all of the tests written in that directory_


## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used

*  Visual Studio Code
*  Markdown
*  C#/.NET


### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Noel Kirkland LLC_**