Prerequisites:

- Unity Hub (latest version)
- Unity editor (2022.3.62f1)
- AltTester Desktop App
- Counter Button application build (from: https://github.com/Estoty/qa-engineer-test)

Setup:
Launch necessary apps
- clone this repo
- Launch Unity Hub and add this project folder with the correct editor version
- run the built Counter Button application exe file
- Open AltTester Destop and connect to aforementioned exe file

Run the tests
- In Unity Editor open Test Runner (Window -> General -> Test Runner)
- Select PlayMode Tests
- Run all tests


Expected behaviour:
- Tests will connect to the running exe file (app)
- Test will interact with the Submit button and count will increase
- All three tests should pass
