August 2025

This project contains a standalone Unity testing project for validating Counter Button application using AltTester SDK and NUnit.
It uses AltTester Desktop and AltTester SDK to interact with the running application exe file. It simulates user input and verifies expected behaviour.
This repo has all necessary Unity packages and libraries to run the tests as they are all defined in the manifest.json file.

Test secenarios:

- SubmitButton_IsInteractable - checks if the submit button can be pressed-
- Count_Increases_WhenSubmitPressed - checks that pressing Submit button increments the counter by exactly 1
- Count_IsTen_AfterTenSubmits - check whether the counter is exactly 10 after 10 clicks



Prerequisites:

- Unity Hub (latest version)
- Unity editor (2022.3.62f1)
- AltTester Desktop App
- Counter Button project (from: https://github.com/Estoty/qa-engineer-test)
- AltTesterUnity SDK https://alttester.com/downloads/

Building the Counter button exe file:
- Clone the Counter Button project
- Open in Unity (matching the editor version used in this test project: 2022.3.62f1)
- Install AltTester SDK via Assets -> Import package -> Custom package
- Add dependencies to resolve errors (from https://alttester.com/docs/sdk/latest/pages/get-started.html )
- Drag AltTesterPrefab from Assets/AltTester/Runtime/Prefab in your scene hierarchy and save the scene
- In Unity open AltTester -> Altester Editor. Add your scene, set a build location and build the .exe file

Setup:
Launch necessary apps
- clone this repo
- Launch Unity Hub and add this project folder with the correct editor version
- run the Counter Button application exe file from the build folder
- Open AltTester Desktop and connect to aforementioned exe file

Run the tests
- In this project's Unity Editor open Test Runner (Window -> General -> Test Runner)
- Select PlayMode Tests
- Run all tests


Expected behaviour:
- Tests will connect to the running exe file (app)
- Test will interact with the Submit button and count will increase
- All three tests should pass

Pictures:
https://failiem.lv/u/2gacy8hsju


