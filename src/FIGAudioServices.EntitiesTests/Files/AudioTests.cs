using FIGAudioServices.Entities.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIGAudioServices.EntitiesTests.Files;

[TestClass]
public class AudioTests
{
    [TestMethod]
    public void AudioNullTest()
    {
        var audio = new Audio();
        Assert.IsNotNull(audio);
    }
}