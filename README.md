<br />
<br />
<div align="center">
    <a href="https://github.com/D3W10/Multiplication-Championship">
        <img src="https://raw.githubusercontent.com/D3W10/Multiplication-Championship/master/logo.png" alt="Logo" width="60" height="60">
    </a>
    <br />
    <br />
    <h2 align="center">Multiplication Championship</h2>
    <h3 align="center">The real challenge begins now!</h3>
    <br />
    <p align="center">
        <a href="https://github.com/D3W10/Multiplication-Championship/releases">Download App</a>
        ·
        <a href="https://github.com/D3W10/Multiplication-Championship/issues">Report Bug</a>
        ·
        <a href="https://github.com/D3W10/Multiplication-Championship/issues">Request Feature</a>
    </p>
</div>
<br />

### Table of Contents
1. [About](#about)
    - [Built With](#built-with)
2. [Getting Started](#getting-started)
    - [System Requirements](#system-requirements)
    - [Installation](#installation)
3. [Game Description](#game-description)
    - [Apprentice Dashboard](#apprentice-dashboard)
    - [Master Control](#master-control)
4. [Development](#development)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation-1)
5. [License](#license)
6. [Credits](#credits)

<br />
<br />

## About

Multiplication Championship is a desktop application that let's you test your knowledge and speed on doing quick multiplications. It is built to be used mainly by kids to help them learn and have fun at the same time. It contains an award system, an integrated calculator, a notebook to study multiplications and also a parental control panel.

<br />

### Built With

- [C#](https://learn.microsoft.com/dotnet/csharp/)
- [.NET Core](https://dotnet.microsoft.com/)

<br />
<br />

## Getting Started

In order to play the game go to the [releases page](https://github.com/D3W10/Multiplication-Championship/releases) and download the latest version.

<br />

### System Requirements

To run the game you need:

- A computer running Windows:
    - Windows 10 or superior;
- At least 50 MB of free space.

<br />

### Installation

After downloading the game from the [releases page](https://github.com/D3W10/Multiplication-Championship/releases), run the main `.exe` file and start using it. Multiplication Championship is a portable application, so it can be saved in a portable drive (like a pen USB) and be used in any windows machine.

<br />
<br />

## App Description

The welcome screen is the first window you get presented with when launching the app. From here you can select one of two options, "Apprentice" and "Master".

<br />

### Apprentice Dashboard

The apprentice dashboard is the home of most of the features that the application has to offer. Here you will find the calculator, the multiplication notebook and the awards list.

On the left side of the window you can setup the settings and start a new game. You can select from the available options, use a custom number or do all of them mixed together. It is also possible to select the minimum and maximum values, number of questions and if the order should be randomized and commutative.

When a game is about to start the count down starts and the time will begin counting up, on the top left is possible to check on which question we're currently at and on the bottom left the amount of correct and wrong answers.

When the game ends it will consider a win if there were more correct than wrong answers and award the medals that were conquered.

<br />

### Master Control

The master control is where parents can setup and control specific rules for the game, it is protected by a password that you can check below.

Parents can reset the correct/wrong answer counters, force random and/or commutative, remove all medals or delete all data created by the application.

**Password**
- English - *multiplicationmaster*
- Portuguese - *mestredastabuadas*

<br />
<br />

## Development

If you want to deploy a copy of Multiplication Championship on your device to develop a feature or fix a bug, follow the steps below to get started.

<br />

### Prerequisites

In order to run the game, you will need the following tools:
- Visual Studio 2022
- C# 11.0
- .NET Core 7
- git (*opcional*)

<br />

### Installation

1. Clone the repository
    ```sh
    git clone https://github.com/D3W10/Multiplication-Championship.git
    ```
2. Open the project solution (`.sln` file) using Visual Studio
3. Compile and run by pressing `F5`

<br />
<br />

## License

Distributed under the Mozilla Public License 2.0. Check `LICENSE` for more details.

<br />
<br />

## Credits

- Made by [Daniel Nunes](https://d3w10.netlify.app/)