# Veldrid

#### Veldrid is a cross-platform, graphics API-agnostic rendering and compute library for .NET Core. It provides a powerful, unified interface to a system's GPU and includes more advanced features than any other .NET library. Unlike other platform or vendor-specific technologies, Veldrid can be used to create high-performance 3D applications that are truly portable

![Sponza](https://i.imgur.com/p6juqm9.jpg)

___As of February 2023, [@mellinoe](https://github.com/mellinoe) is no longer able to publicly share updates to Veldrid and related libraries, thus this fork.
If you're interested in the original project, feel free to reach out to its contributors or join Veldrid's [discord server](https://discord.gg/s5EvvWJ) for more information about the status of the project___

### Supported frameworks
* .NET Core >= **10**
* That's it

### Supported backends
* ~~Direct3D 12~~ (sometime in the future)
* Direct3D 11
* Vulkan
* Metal
* OpenGL 3
* OpenGL ES 3

### Documentation
**While this fork doesn't have its own documentation and probably won't be getting one anytime soon, you can still check out** [Veldrid's documentiation on its official website](https://mellinoe.github.io/veldrid-docs/)

### Download
This fork of Veldrid is available as a NuGet package:
[![NuGet](https://img.shields.io/nuget/v/DawnestOfBread.Veldrid.svg)](https://www.nuget.org/packages/DawnestOfBread.Veldrid)

### Build instructions
Veldrid uses the standard .NET Core tooling. [Install the tools](https://www.microsoft.com/net/download/core) and build normally (`dotnet build`).

Run the NeoDemo program to see a quick demonstration of the rendering capabilities of the library.

### Acknowledgements
**Massive thanks to [@mellinoe](https://github.com/mellinoe) for creating Veldrid and making many of my projects - including this one - possible**
