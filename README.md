# glTFast BackSide - Unity 2022 Custom Fork

This is a custom fork of [glTFast](https://github.com/atteneder/glTFast) specifically enhanced for Volvo VCC AR applications with Unity 2022.

## Features

This fork includes the following enhancements over the original glTFast:

- **Extra Data Support**: Custom implementation for handling glTF extras data with Volvo-specific schemas
- **Clear Coat Support**: Enhanced material support for clear coat rendering
- **Unity 2022 Compatibility**: Updated for Unity 2022.3 LTS
- **Volvo VCC AR Optimizations**: Specific optimizations for Volvo car model rendering

## Installation

### Via Git URL (Recommended)

Add this to your Unity project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.designestjay.gltfast": "https://github.com/designestjay/Unity2022_GLTFast-BackSide.git"
  }
}
```

### Via Package Manager

1. Open Unity Package Manager
2. Click the "+" button
3. Select "Add package from git URL"
4. Enter: `https://github.com/designestjay/Unity2022_GLTFast-BackSide.git`

## Usage

This package works exactly like the original glTFast, but with additional features for Volvo VCC AR applications:

```csharp
using GLTFast;
using GLTFast.Schema;

// Access custom extra data
var extraData = FindObjectsOfType<ExtraData>();
var extraDataEX30 = FindObjectsOfType<ExtraDataEX30>();
```

## Dependencies

- Unity 2022.3 LTS or newer
- com.unity.modules.jsonserialize
- com.unity.modules.unitywebrequest
- com.unity.mathematics
- com.unity.burst

## Original glTFast

This package is based on the excellent [glTFast](https://github.com/atteneder/glTFast) library by Andreas Atteneder.

## License

This project maintains the same license as the original glTFast project. See [LICENSE.md](LICENSE.md) for details.

## Contributing

This is a specialized fork for Volvo VCC AR applications. For general glTFast improvements, please contribute to the [original glTFast repository](https://github.com/atteneder/glTFast).