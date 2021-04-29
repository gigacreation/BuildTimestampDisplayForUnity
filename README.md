# Build Timestamp Display for Unity

![build-timestamp-display-for-unity](https://user-images.githubusercontent.com/5264444/103909925-9d637180-5147-11eb-957f-4c880eb90744.png)

Display the timestamp the game was built.

## 日本語による説明 / Explanation in Japanese

[Unity のビルド時刻を表示するスクリプトを公開しました](https://blog.gigacreation.jp/entry/2020/10/10/123134)

## Usage

1. Build your game.
2. `Assets/BuildTimestampDisplay/BuildTimestamp.asset` will be generated. It has fields of build started time.
![image](https://user-images.githubusercontent.com/5264444/103910707-7d807d80-5148-11eb-8ddc-ec4cdec380f0.png)
3. Attach `BuildTimestampDisplay.cs` to uGUI Text and set `BuildTimestamp.asset`.
![image](https://user-images.githubusercontent.com/5264444/116574519-c2732e80-a948-11eb-8c3b-a891685a170f.png)
    - You can attach it by clicking `Add Component` > `Gigacee` > `Build Timestamp Display`.
    - You can change text format and UTC offset.
4. Play the scene and the build timestamp is displayed on the screen!

---

:memo: You can also use `BuildTimestamp.asset` for any other purpose you like :wink:

### Tips

You can use this script with TextMesh Pro. Import `Sample2 - TextMesh Pro` from Package Manager window.

## Installation

### Package Manager

- `https://github.com/Gigacee/build-timestamp-display-for-unity.git?path=Assets/BuildTimestampDisplay`

### Manual

- Copy `Assets/BuildTimestampDisplay/` to your project.
