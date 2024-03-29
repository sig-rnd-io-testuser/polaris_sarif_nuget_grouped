﻿namespace UnitTests.GrainInterfaces
{
    public interface IKeyExtensionTestGrain : IGrainWithGuidCompoundKey
    {
        Task<IKeyExtensionTestGrain> GetGrainReference();
        Task<string> GetActivationId();
    }
}
