<h1 align="center">Steam++ Tools 🧰</h1>

<div align="center">

「Steam++」is a toolkit that contains a variety of Steam tools, most of which require you to download and install Steam in order to use them.

![Release Download](https://img.shields.io/github/downloads/rmbadmin/SteamTools/latest/total?style=flat-square)
[![Release Version](https://img.shields.io/github/v/release/rmbadmin/SteamTools?style=flat-square)](https://github.com/rmbadmin/SteamTools/releases/latest)
[![GitHub license](https://img.shields.io/github/license/rmbadmin/SteamTools?style=flat-square)](LICENSE)
[![GitHub Star](https://img.shields.io/github/stars/rmbadmin/SteamTools?style=flat-square)](https://github.com/rmbadmin/SteamTools/stargazers)
[![GitHub Fork](https://img.shields.io/github/forks/rmbadmin/SteamTools?style=flat-square)](https://github.com/rmbadmin/SteamTools/network/members)
![GitHub repo size](https://img.shields.io/github/repo-size/rmbadmin/SteamTools?style=flat-square&color=3cb371)

</div>

English | [简体中文](./README.md)

## ✨ Functions
1. Local reverse proxy for Steam's community webpage to enable normal access in **the Chinese Mainland, Mainland of China**
2. Quickly switch the Steam account that the current PC has remembered to log into
	- This feature is to read the local user login records stored under the Steam path to directly display the operation, you can switch between multiple accounts without re-entering passwords and tokens.
3. Achievement stat modifications for Steam games
	- Function reference SteamAchievementManager for secondary development, modified the game list loading and operation ease of use. 
4. Steam Local Two-Step Authenticator
    - The function reference [WinAuth](https://github.com/winauth/winauth) is developed to enable you to view your token without launching the mobile version of Steam App, similar function software are [WinAuth](https://github.com/winauth/winauth), [SteamDesktopAuthenticator](https://github.com/Jessecar96/SteamDesktopAuthenticator).
5. Some game tools
	- Currently there is a forced game borderless windowing, CSGO fix VAC shield.

## 🖥 Operating Environment
- Windows 10 1607+
- Windows 8.1 / Windows Server 2012 R2
	- Prerequisites
	- Microsoft Visual C++ 2015-2019 Redistributable [64 bit](https://aka.ms/vs/16/release/vc_redist.x64.exe) / [32 bit](https://aka.ms/vs/16/release/vc_redist.x86.exe)
- Windows 7 SP1 [ESU](https://docs.microsoft.com/troubleshoot/windows-client/windows-7-eos-faq/windows-7-extended-security-updates-faq)
	- Prerequisites
	- Microsoft Visual C++ 2015-2019 Redistributable [64 bit](https://aka.ms/vs/16/release/vc_redist.x64.exe) / [32 bit](https://aka.ms/vs/16/release/vc_redist.x86.exe)
	- KB3063858 [64 bit](https://www.microsoft.com/download/details.aspx?id=47442) / [32 bit](https://www.microsoft.com/download/details.aspx?id=47409)
- ~~macOS 10.13 High Sierra Or Higher~~
<!--
- ~~Alpine Linux 3.11+~~
- ~~CentOS 7+~~
- ~~Debian 9+~~
- ~~Fedora 32+~~
- ~~Linux Mint 18+~~
- ~~openSUSE 15+~~
- ~~Red Hat Enterprise Linux 7+~~
- ~~SUSE Enterprise Linux (SLES) 12 SP2+~~
- ~~Ubuntu 20.10, 20.04, 18.04, 16.04~~
- ~~Android 5.0+~~
- ~~iOS 8.0+~~
-->

## 🌎 Roadmap
Read what we [milestones](https://github.com/SteamTools-Team/SteamTools/milestones), and feel free to ask questions.

## ⌨️ Development Environment
[Visual Studio 2019 Version 16.8 Or Higher](https://visualstudio.microsoft.com/vs/) Or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/) Or [JetBrains Rider](https://www.jetbrains.com/rider/) Or [Visual Studio Code](https://code.visualstudio.com/)
- Workload
	- Web and Cloud
		- ASP.NET and Web Development
	- Desktop and Mobile Applications
		- .NET Desktop Development
		- Mobile Development using .Net
	- Other Toolsets
		- .NET Core Cross Platform Development
- Single Component
	- GitHub Extension for Visual Studio
- [Visual Studio Marketplace](https://marketplace.visualstudio.com/)
	- [Avalonia for Visual Studio](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaforVisualStudio)
	- [NUnit VS Templates](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnitTemplatesforVisualStudio)

## 📄 Thanks to the following Open Source Projects
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
* [MetroRadiance](https://github.com/Grabacr07/MetroRadiance)
* [MetroTrilithon](https://github.com/Grabacr07/MetroTrilithon)
* [Livet](https://github.com/runceel/Livet)
* [StatefulModel](https://github.com/ugaya40/StatefulModel)
* [Hardcodet.NotifyIcon](https://github.com/HavenDV/Hardcodet.NotifyIcon.Wpf.NetCore)
* [System.Reactive](https://github.com/dotnet/reactive)
* [Titanium-Web-Proxy](https://github.com/justcoding121/Titanium-Web-Proxy)
* [Ninject](https://github.com/ninject/Ninject)
* [log4net](https://github.com/apache/logging-log4net)
* [SteamDB-API](https://github.com/SteamDB-API/api)
* [SteamAchievementManager](https://github.com/gibbed/SteamAchievementManager)
* [ArchiSteamFarm](https://github.com/JustArchiNET/ArchiSteamFarm)
* [WinAuth](https://github.com/winauth/winauth)
* [SteamDesktopAuthenticator](https://github.com/Jessecar96/SteamDesktopAuthenticator)
* [Gameloop.Vdf](https://github.com/shravan2x/Gameloop.Vdf)
* [Costura.Fody](https://github.com/Fody/Costura)
* [MessagePack-CSharp](https://github.com/neuecc/MessagePack-CSharp)
* [Nito.Comparers](https://github.com/StephenCleary/Comparers)
* [Crc32.NET](https://github.com/force-net/Crc32.NET)
* [gfoidl.Base64](https://github.com/gfoidl/Base64)
* [sqlite-net-pcl](https://github.com/praeclarum/sqlite-net)
* [Polly](https://github.com/App-vNext/Polly)
* [NLog](https://github.com/nlog/NLog)
* [NUnit](https://github.com/nunit/nunit)
* [ReactiveUI](https://github.com/reactiveui/reactiveui)
* [MessageBox.Avalonia](https://github.com/AvaloniaUtils/MessageBox.Avalonia)
* [AvaloniaUI](https://github.com/AvaloniaUI/Avalonia)
* [EntityFrameworkCore](https://github.com/dotnet/efcore)
* [ASP.NET Core](https://github.com/dotnet/aspnetcore)
* [Xamarin.Essentials](https://github.com/xamarin/essentials)
* [.NET Extensions](https://github.com/dotnet/extensions)
* [.NET Runtime](https://github.com/dotnet/runtime)
