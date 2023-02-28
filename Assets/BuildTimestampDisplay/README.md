# Build Timestamp Display for Unity

This package allows you to display the latest build timestamp.

![Demo](https://user-images.githubusercontent.com/5264444/221815340-64b9bf2c-1b11-4390-845e-937102f98af9.jpg)

## :warning: THE PACKAGE AND NAMESPACE NAMES HAVE BEEN CHANGED IN THE LATEST VERSION! :warning:

- Ver. 2.x (Currect)
    - package name: `jp.gigacreation.tools.buildtimestampdisplay`
    - namespace: `GigaCreation.Tools.BuildTimestampDisplay`
- Ver. 1.x
    - package name: `com.gigacee.buildtimestampdisplay`
    - namespace: `BuildTimestampDisplay`

## 日本語による説明 / Explanation in Japanese

[Unity のビルド時刻を表示するスクリプトを公開しました](https://blog.gigacreation.jp/entry/2020/10/10/123134)

## Usage

1. Build your game.
1. `Assets/BuildTimestampDisplay/BuildTimestamp.asset` will be generated. It has fields of build started time.
![BuildTimestampAsset](https://user-images.githubusercontent.com/5264444/221815939-31b7211a-92cf-48ab-b2f2-8ec0c7c67b5e.jpg)
1. Create a GameObject in a canvas and attach `BuildTimestampDisplayLegacyText.cs` to it.
1. Click `Set BuildTimestamp Asset` button in Inspector.
![SetBuildTimestampAssetButton](https://user-images.githubusercontent.com/5264444/221816887-8158c410-3023-48a5-8981-b849f71c5500.jpg)
    - You can attach it by clicking `Add Component` > `GIGA CREATION` > `Build Timestamp Display Legacy Text`.
    - You can change text format and UTC offset.
1. Play the scene or rebuild the game and you can see the build timestamp on the screen!

---

:memo: You can also use `BuildTimestamp.asset` for any other purpose you like :wink:

## TextMesh Pro?

Of course, you can also use this package with TextMesh Pro! Please check `BuildTimestampDisplayTextMeshPro.cs` that included in `02 - TextMesh Pro` sample (you can import samples from the Package Manager window).

## Installation

### Package Manager

- `https://github.com/gigacreation/BuildTimestampDisplayForUnity.git?path=Assets/BuildTimestampDisplay`

### Manual

- Copy `Assets/BuildTimestampDisplay/` to your project.
