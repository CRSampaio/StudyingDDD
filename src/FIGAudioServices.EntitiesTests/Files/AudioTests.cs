using FIGAudioServices.Entities.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIGAudioServices.EntitiesTests.Files;

[TestClass]
public class AudioTests
{
    [TestMethod]
    public void Instantiating_Audio_Setting_Filename_Should_Pass()
    {
        //Arrange
        var audio = new Audio();

        //Act
        audio.Filename = "Any filename";

        //Assert
        Assert.IsNotNull(audio.Filename);
    }

    [TestMethod]
    public void Instantiating_Audio_Setting_Filename_Null_Throws_Exception()
    {
        //Arrange
        var audio = new Audio();

        //Act & Assert
        Assert.ThrowsException<ArgumentNullException>(() => audio.Filename = null);
    }
}