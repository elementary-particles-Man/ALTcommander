using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Runtime.Serialization;

namespace ALTCommander.Tests
{
    [TestClass]
    public class FormatBytesTests
    {
        private static string InvokeAltCommanderForm(long bytes)
        {
            var type = typeof(AltCommander.AltCommanderForm);
            var method = type.GetMethod("FormatBytes", BindingFlags.NonPublic | BindingFlags.Instance);
            var instance = FormatterServices.GetUninitializedObject(type);
            return (string)method.Invoke(instance, new object[] { bytes });
        }

        private static string InvokeDirectorySelectDialog(long bytes)
        {
            var type = typeof(ALTCommander.DirectorySelectDialog);
            var method = type.GetMethod("FormatBytes", BindingFlags.NonPublic | BindingFlags.Instance);
            var instance = FormatterServices.GetUninitializedObject(type);
            return (string)method.Invoke(instance, new object[] { bytes });
        }

        [TestMethod]
        public void AltCommanderForm_Returns_NA_For_Negative()
        {
            Assert.AreEqual("N/A", InvokeAltCommanderForm(-1));
        }

        [TestMethod]
        public void AltCommanderForm_Returns_Zero_For_Zero()
        {
            Assert.AreEqual("0 B", InvokeAltCommanderForm(0));
        }

        [TestMethod]
        public void AltCommanderForm_Scales_Correctly()
        {
            Assert.AreEqual("512 B", InvokeAltCommanderForm(512));
            Assert.AreEqual("1 KB", InvokeAltCommanderForm(1024));
            Assert.AreEqual("1.5 KB", InvokeAltCommanderForm(1536));
            Assert.AreEqual("1 MB", InvokeAltCommanderForm(1048576));
        }

        [TestMethod]
        public void DirectorySelectDialog_Returns_NA_For_Negative()
        {
            Assert.AreEqual("N/A", InvokeDirectorySelectDialog(-1));
        }

        [TestMethod]
        public void DirectorySelectDialog_Returns_Zero_For_Zero()
        {
            Assert.AreEqual("0 B", InvokeDirectorySelectDialog(0));
        }

        [TestMethod]
        public void DirectorySelectDialog_Scales_Correctly()
        {
            Assert.AreEqual("512 B", InvokeDirectorySelectDialog(512));
            Assert.AreEqual("1 KB", InvokeDirectorySelectDialog(1024));
            Assert.AreEqual("2 KB", InvokeDirectorySelectDialog(1536));
            Assert.AreEqual("1 MB", InvokeDirectorySelectDialog(1048576));
        }
    }
}
