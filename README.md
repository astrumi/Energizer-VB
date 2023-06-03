# ENERGIZER: an Excel Plugin
This is a work-in-progress, and this repository is made to show the progress of the application's development. 
Looking forward to your feedback and reviews!

## Description
This project is about developing a VB.NET plug-in for Excel (and other popular spreadsheet platforms tentatively: Office 365 and Google Sheets). The plug-in facilitates a sequential multi-criteria decision analysis (MCDA), aiding users to move through a predefined process flow and assist in calculating the most preferable alternatives out of a set, covering 4-5 steps.
Currently, I've developed up to step 2, and plan to finish the basic design for the rest of the steps next, as well as integrate with the C library for calculations.

## Setting up
To open the project, clone the repository, and open it in your preferred IDE that supports VB.NET (preferably Visual Studio).
1. Clone the repository: `git clone https://github.com/astrumi/Energizer-VB.git`
2. Open the project in your IDE.
3. Build the project to verify everything is correctly set up.

## Current Tasks
Actively looking for suggestions to expand the functionality and robustness of the plug-in. You are welcome to contribute by proposing new features or reporting bugs by creating a new issue.

Our [current focus](https://github.com/astrumi/Energizer-VB/issues/1) is:
- Implementing remaining steps of the decision analysis process (Steps 3-4,5).
- Integrating with the C calculation library for complex calculations.

And more on [refining codebase](https://github.com/astrumi/Energizer-VB/issues/2) such as:
- Refactoring `ProgramState.vb` to use properties instead of public variables.
- Implementing exception handling in `FStep1.vb` and `FStep2.vb`.
- Adding null or empty input checks in `UCStep2Input.vb`.
- Implementing `IDisposable` interface in `FStep1.vb`, `FStep2.vb`, `UCStep2Input.vb`.
- and more
