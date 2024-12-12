﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using Microsoft.VisualStudio.ProjectSystem.VS.HotReload;

namespace Microsoft.VisualStudio.ProjectSystem.VS;

internal static class IProjectHotReloadNotificationServiceFactory
{
    public static IProjectHotReloadNotificationService Create()
    {
        var mock = new Mock<IProjectHotReloadNotificationService>();

        return mock.Object;
    }
}
