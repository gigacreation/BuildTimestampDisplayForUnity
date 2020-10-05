# Build timestamp display for Unity

![build-timestamp-display-for-unity](https://user-images.githubusercontent.com/5264444/95020949-2c746f80-06a9-11eb-866d-0a808459a930.png)

Display the timestamp the game was built.

## Usage

1. Build your game.
2. After the game is built, the timestamp field in `Assets/BuildTimestampDisplay/BuildTimestamp.asset` will be updated.
![image](https://user-images.githubusercontent.com/5264444/95021130-2b900d80-06aa-11eb-9c99-9099cd66d32a.png)
3. Attach `BuildTimestampDisplay.cs` to uGUI Text and set `BuildTimestamp.asset`.
![image](https://user-images.githubusercontent.com/5264444/95082182-9fd3bb00-0755-11eb-84f3-e23b16fa547d.png)
    - You can attach it by clicking `Add Component` > `Gigacee` > `Build Timestamp Display`. 
4. Play the scene and the build timestamp is displayed on the screen!

---

:note: You can also use `BuildTimestamp.asset` for any other purpose you like :wink:

## Installation

### Package Manager

`https://github.com/Gigacee/build-timestamp-display-for-unity.git?path=Assets/BuildTimestampDisplay`

### Manual

Copy `Assets/BuildTimestampDisplay/` to your project.
