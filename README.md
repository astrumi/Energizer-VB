# Energizer-VB
This is a work-in-progress, and this repo serves to show the progress of the application's development. Looking forward to your input and review!

## Description
This project is about developing a VB.NET plug-in for Excel (and other popular spreadsheet platforms tentatively: Office 365 and Google Sheets). The plug-in facilitates a sequential multi-criteria decision analysis (MCDA), aiding users to move through a predefined process flow and assist in calculating the most preferable alternatives out of a set, covering 4-5 steps.
Currently, I've developed up to step 2, and plan to finish the basic design for the rest of the steps next, as well as integrate with the C library for calculations.

## Getting Started
To get started with the project, clone the repository, and open it in your preferred IDE that supports VB.NET.

## Installation
1. Clone the repository: `git clone https://github.com/astrumi/Energizer-VB.git`
2. Open the project in your IDE.
3. Build the project to verify everything is correctly set up.

## Contribution
Actively looking for suggestions to expand the functionality and robustness of the plug-in. You can contribute by proposing new features or reporting bugs by creating a new issue with as much detail as possible.

## Current Tasks
Our current focus is:
1. Implementing remaining steps of the decision analysis process (Steps 3-4, and Phase 2 Step 5).
2. Integrating with the C calculation library for complex calculations.
   Refining codebase:
4. Refactoring `ProgramState.vb` to use properties instead of public variables.
5. Implementing exception handling in `FStep1.vb` and `FStep2.vb`.
6. Adding null or empty input checks in `UCStep2Input.vb`.
7. Implementing `IDisposable` interface in `FStep1.vb`, `FStep2.vb`, `UCStep2Input.vb`.
