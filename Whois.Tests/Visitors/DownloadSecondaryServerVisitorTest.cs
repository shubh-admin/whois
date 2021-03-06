﻿using NUnit.Framework;
using Whois.Extensions;
using Whois.Net;

namespace Whois.Visitors
{
    [TestFixture]
    public class DownloadSecondaryServerVisitorTest
    {
        private RedirectVisitor vistior;

        [SetUp]
        public void SetUp()
        {
            // Initialize visitor with the Fake TcpReader Factory so we get canned responses
            vistior = new RedirectVisitor { TcpReaderFactory = new FakeTcpReaderFactory() };
        }

        [Test]
        public void TestDownloadSecondaryServerVisitor()
        {
            ////var record = new WhoisRecord(FakeTcpReader.FakeGoogleResponse2);
            //record.Domain = "google.com";

            //record = vistior.Visit(record);

            //// Should of downloaded the MarkMonitor response (response 3)
            //Assert.Greater(record.Text.IndexOfLineContaining("MarkMonitor"), -1);
        }
    }
}
