# Roslyn.Utilities [![Build status](https://ci.appveyor.com/api/projects/status/n9kt9gou453uk3iw/branch/master?svg=true)](https://ci.appveyor.com/project/IgorFesenko/roslyn-utilities/branch/master) [![NuGet Status](https://img.shields.io/nuget/v/Roslyn.Utilities.svg?style=flat)](https://www.nuget.org/packages/Roslyn.Utilities/)

**Description**

[Roslyn internal utilities](https://github.com/dotnet/roslyn/tree/master/src/Compilers/Core/Portable/InternalUtilities) as Nuget package.

**List of features**
* [OneOrMany](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/OneOrMany.cs) - Represents a single item or many items. Used when a collection usually contains a single item but sometimes might contain multiple.
* [ConcurrentLruCache](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/ConcurrentLruCache.cs) - Thread-safe cache with a fixed size that evicts the least recently used members.
* [ConsList+Extensions](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/ConsList%601.cs) - Lisp-like immutable list. Good to use when lists are always accessed from the head.
* [WeakList](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/WeakList.cs) - Represents an ordered sequence of weak references.
* [SpecializedCollections](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/SpecializedCollections.cs) - Contains methods to returns an empty collection without additional allocations.
* [ArrayExtensions](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/ArrayExtensions.cs) - Contains useful extension set for Arrays (manipulation, binary search, etc.).
* [BitArithmeticUtilities](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/BitArithmeticUtilities.cs) - Contains align and count bits methods.
* [ArrayBuilder](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/SharedCollections/ArrayBuilder.cs) - Contains optimized methods to create Arrays.
* [EnumerableExtensions](https://github.com/dotnet/roslyn/blob/master/src/Compilers/Core/Portable/InternalUtilities/EnumerableExtensions.cs) - Contains a set of useful methods, see details on repository.