﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Microsoft.VisualStudio.Shell.Interop;

internal static class IVsTaskFactory
{
    public static IVsTask FromResult(object? result)
    {
        var mock = new Mock<IVsTask>();

        mock.Setup(t => t.IsCompleted)
            .Returns(true);
        mock.Setup<object?>(t => t.GetResult())
            .Returns(result);

        return mock.Object;
    }
}
