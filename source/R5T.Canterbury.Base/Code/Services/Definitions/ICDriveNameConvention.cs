using System;

using R5T.T0064;


namespace R5T.Canterbury
{
    [ServiceDefinitionMarker]
    public interface ICDriveNameConvention : IServiceDefinition
    {
        string GetCDriveName();
    }
}
