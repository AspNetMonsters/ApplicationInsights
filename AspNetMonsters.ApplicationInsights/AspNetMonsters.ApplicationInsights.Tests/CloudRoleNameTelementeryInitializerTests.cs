using AspNetMonsters.ApplicationInsights.TelemetryInitializers;
using Microsoft.ApplicationInsights.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AspNetMonsters.ApplicationInsights.Tests
{
    public class CloudRoleNameTelementeryInitializerTests
    {
        [Fact]
        public void ShouldSetCloudRoleNameOnTelemetry()
        {
            var cloudRoleName = "MyFancyApp";
            var sut = new CloudRoleNameTelemetryInitializer(cloudRoleName);

            var telemetry = new RequestTelemetry();

            sut.Initialize(telemetry);

            Assert.Equal(cloudRoleName, telemetry.Context.Cloud.RoleName);
        }
    }
}
