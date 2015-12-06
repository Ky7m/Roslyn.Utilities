// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace Roslyn.Utilities.Tests.Helpers.Assert
{
    /// <summary>
    /// Helpers for testing equality APIs. 
    /// Gives us more control than calling Assert.Equals.
    /// </summary>
    public static class EqualityTesting
    {
        public static void AssertEqual<T>(IEquatable<T> x, IEquatable<T> y)
        {
            Xunit.Assert.True(x.Equals(y));
            Xunit.Assert.True(((object)x).Equals(y));
            Xunit.Assert.Equal(x.GetHashCode(), y.GetHashCode());
        }

        public static void AssertNotEqual<T>(IEquatable<T> x, IEquatable<T> y)
        {
            Xunit.Assert.False(x.Equals(y));
            Xunit.Assert.False(((object)x).Equals(y));
        }
    }
}
