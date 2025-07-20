# Colorable Flag

**ColorableFlag** is a minimal project built to demonstrate the core functionality of the `ColorSystem` library, developed by TheUnishark.

This repository contains a simple script that allows in-game objects to have their color changed via hexadecimal input. The system provides a basic UI where users can enter a hex code, which is then parsed and applied to the object's material in real time.

## Contents

- `FlagManager.cs` – Main script handling user input and color conversion
- `Core.cs` – Main script that defines the plugin

## How it works

1. The user interacts with the flag.
2. A input menu opens, requesting a hex color code.
3. The input is passed to the `ColorSystem`, which validates and converts the string into a usable color.
4. The color is applied to the flag's material renderer.

The code is modular and can be reused or extended for any game object requiring runtime color customization.

## Installation

It is recommended to check out TheUnishark's guide, which will likely explain how to use the plugin more clearly (as it can honestly be quite complicated at first).

## License

This project is licensed under the MIT License.

You are allowed to:
- Use this code in personal or commercial projects
- Modify or extend the functionality
- Distribute it freely, with or without changes

Attribution is not mandatory but encouraged.
