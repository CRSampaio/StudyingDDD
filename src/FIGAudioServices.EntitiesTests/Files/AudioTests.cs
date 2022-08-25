using FIGAudioServices.Entities.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIGAudioServices.EntitiesTests.Files;

[TestClass]
public class AudioTests
{
    [TestMethod]
    public void AudioTest()
    {
        //Arrange
        var audio = new Audio();

        //Act
        audio.Filename = "Any filename";

        //Assert
        Assert.IsNotNull(audio.Filename);
    }
}