using AltTester.AltTesterSDK.Driver;
using NUnit.Framework;

public class CountButtonTests
{
    private AltDriver _driver;

    [SetUp]
    public void Setup()
    {
        _driver = new AltDriver();
        _driver.LoadScene("SampleScene");
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Stop();
    }

    [Test]
    public void SubmitButton_IsInteractable()
    {
        var submitButton = _driver.WaitForObject(By.NAME, "SubmitButton");
        Assert.IsTrue(submitButton.enabled, "Submit button must be interactable");
    }

    [Test]
    public void Count_Increases_WhenSubmitPressed()
    {
        var submitButton = _driver.WaitForObject(By.NAME, "SubmitButton");
        var countText = _driver.WaitForObject(By.NAME, "Count");

        int initialCount = int.Parse(countText.GetText());
        submitButton.Tap();
        int newCount = int.Parse(countText.GetText());

        Assert.AreEqual(initialCount + 1, newCount, "Count did not increase by 1 after pressing Submit");
    }

    [Test]
    public void Count_IsTen_AfterTenSubmits()
    {
        var submitButton = _driver.WaitForObject(By.NAME, "SubmitButton");
        var countText = _driver.WaitForObject(By.NAME, "Count");

        for (int i = 0; i < 10; i++)
        {
            submitButton.Tap();
        }

        int finalCount = int.Parse(countText.GetText());
        Assert.AreEqual(10, finalCount, "Count must  be exactly 10 after pressing Submit 10 times");
    }
}
