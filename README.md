# Flappy Bird with Arduino Button Controller

## Overview
This project is a Flappy Bird style game developed in Unity that uses a custom Arduino button controller as an alternative input device. Instead of pressing the keyboard spacebar, players press a physical button connected to an Arduino, which communicates with Unity via serial communication to control the bird’s flap.

The goal is to demonstrate a simple yet effective integration of physical hardware with a digital game, fulfilling the COMP102 assignment requirements.

## Features
- Classic Flappy Bird gameplay with smooth sprite animations.
- Physical button input via Arduino replaces keyboard input.
- Real-time serial communication between Arduino and Unity.
- Easy to test with keyboard fallback (spacebar).
- Simple, modular scripts for game and hardware integration.

## Project Structure
/COMP 102
├── Assets/ # Unity project assets
├── ProjectSettings/ # Unity project settings
├── Packages/ # Unity package manager files
├── Arduino/ # Arduino code and wiring diagrams
│ └── FlapButton.ino # Arduino sketch for button input
├── poster.png # Project poster for assignment
├── README.md # This file
├── MIT LICENSE
├── .gitignore # Unity gitignore file

## Hardware Setup
- Arduino Uno (or compatible)
- Pushbutton connected to digital pin A0 and GND
- USB connection to PC for serial communication

### Wiring Diagram
See `poser.png` for details.

## Arduino Code
The Arduino sketch reads the button press and sends the string `"JUMP"` over serial when pressed.

## Unity Setup
- The `SerialReader` script listens for serial input and triggers the `Player.Flap()` method when receiving `"JUMP"`.
- The `Player` script controls the bird’s movement and animations.
- Keyboard spacebar still works as a fallback control.

## How to Use
1. Upload the Arduino sketch to your Arduino board.
2. Connect the Arduino via USB to your computer.
3. Open the Unity project.
4. Set the serial port in `SerialReader.cs` to your Arduino's COM port.
5. Run the Unity scene and press the button to make the bird flap.

## Dependencies
- Unity 2023.3.20f1 (or compatible)
- Arduino IDE

## Credits
- Flappy Bird original concept by Dong Nguyen
- Arduino integration adapted by James Thornburgh
- Flappy Bird Sprites https://www.spriters-resource.com/mobile/flappybird/sheet/59894/
