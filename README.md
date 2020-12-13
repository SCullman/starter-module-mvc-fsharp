# starter-module-mvc-fsharp - MVC F# 

**starter-module-mvc-fsharp** is a MVC module starter project for [DNN Platform](https://github.com/dnnsoftware/Dnn.Platform) (formerly known as DotNetNuke) made by and for the [DNN Community](https://dnncommunity.org). 

It is ported from [C#](https://github.com/DNNCommunity/starter-module-mvc) to F#.

## Installation

### Installation

Clone this repo into a clean directory of your choice.

```bash
git clone https://github.com/SCullman/starter-module-mvc-fsharp.git 
```



## Usage

1. Install DNN in a `.dnn\website` folder (root of directory in which this project is cloned).  
Hint:  (Install DNN to the folder `.\dnn` with [NVQuickSIte](https://github.com/nvisionative/nvQuickSite) )
2. Open solution file in Visual Studio 2019 (Run as Adminstrator...)
3. Build in `Debug` or `Release` mode

### Debug

By default this will compile the project and deploy it to the `.\dnn\Website` folder.  
- DLL and PDB files will be deployed to `.\dnn\Website\bin`
- All other relevant files will be deployed to `.\dnn\Website\DesktopModules\starter-module-mvc-fsharp`

### Release

By default this will create a module install package and place in `.\dnn\Website\Install\Module` so it will be in **Available Extensions** within DNN (SETTINGS > Extensions > Available Extensions).

## Contributing
Pull requests are welcome. Please open an issue first to document the bug or enhancement details.

## License
[![License: MIT](https://img.shields.io/badge/LICENSE-MIT-informational.svg)](https://opensource.org/licenses/MIT)