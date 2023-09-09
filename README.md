# Arcade Paradise Unbreakable Plugin
Arcade Paradiseのゲーム機を壊れないようにするプラグインです。  
これを導入するとゲーム機が故障した時に出現するゴキブリ達に怯えることなくゲームをプレイできるようになります！  
すでにゲーム機が壊れているセーブデータをロードした場合は修理された状態になります。

This is a plug-in that prevents Arcade Paradise game consoles from being damaged.
By introducing this, you will be able to play games without being scared of the cockroaches that appear when your game console breaks down!
If you load save data whose game console is already broken, it will be repaired.

![(サムネイル.PNG)](https://github.com/forest-soft/arcade_paradise_unbreakable_plugin/blob/master/%E3%82%B5%E3%83%A0%E3%83%8D%E3%82%A4%E3%83%AB.PNG)

# 動作環境
Windows10、Steam版で動作確認をしました。

# 使い方
1. 「BepInEx_UnityIL2CPP_x64_6.0.0-pre.1.zip」をダウンロードしてください。
    * https://github.com/BepInEx/BepInEx/releases/tag/v6.0.0-pre.1
    * 6系の新しいバージョンが出ていれば新しいものを入れてください。
2. 上記のzipファイルを解凍して出てきた以下のフォルダ&ファイルをArcade Paradiseのインストールフォルダにある「ArcadeParadise.exe」と同じ階層にコピーしてください。  
Arcade Paradiseのインストールフォルダは「C:\Program Files (x86)\Steam\steamapps\common\Arcade」などです。
    * BepInEx
    * mono
    * doorstop_config.ini
    * winhttp.dll
3. 「ArcadeParadise.exe」と同じ階層に「1388870」と書いた「steam_appid.txt」を作成してください。
4. 「ArcadeParadise.exe」を起動して、そのまま終了してください。
    * 初回起動時はBepInExが各種ファイルを生成するので少し時間かかります。
    * 先ほどコピーしたBepInExフォルダに入り、configやpluginsなどのフォルダが出来上がっていれば成功です。
5. 本プラグインを「{Arcade Paradiseのインストールフォルダ}\BepInEx\plugins」にコピーしてください。
    * https://github.com/forest-soft/arcade_paradise_unbreakable_plugin/releases
6. Arcade Paradiseを起動すれば完了です！

# 補足
* BepInExが読み込まれているか確認したい場合は「\BepInEx\config\BepInEx.cfg」の85行目あたりの「Enabled = false」を「Enabled = true」にしてください。  
BepInExのログを表示するウインドウが表示されるようになります。
```
80: [Logging.Console]
81: 
82: ## Enables showing a console for log output.
83: # Setting type: Boolean
84: # Default value: false
85: Enabled = false　←の「false」を「true」にしてください。
```
* Steamクライアントの「プレイ」ボタンから起動する際にBepInExが読み込まれていない場合はSteamクライアントを再起動してみてください。


# Operating environment
Operation has been confirmed on Windows 10 and Steam version.

# Installation
1. Please download 「BepInEx_UnityIL2CPP_x64_6.0.0-pre.1.zip」.
    * https://github.com/BepInEx/BepInEx/releases/tag/v6.0.0-pre.1
    * If a new version of the 6 series is released, please install the new version.
2. Unzip the above zip file and copy the following folders and files to the same level as "ArcadeParadise.exe" in the Arcade Paradise installation folder.
The installation folder of Arcade Paradise is "C:\Program Files (x86)\Steam\steamapps\common\Arcade" etc.
    * BepInEx
    * mono
    * doorstop_config.ini
    * winhttp.dll
3. Please create "steam_appid.txt" with "1388870" written in the same layer as "ArcadeParadise.exe".
4. Start "ArcadeParadise.exe" and exit it.
    * When you start it for the first time, BepInEx will generate various files, so it will take some time.
    * Enter the BepInEx folder you copied earlier, and if folders such as config and plugins are created, it is a success.
5. Please copy this plugin to "{Arcade Paradise installation folder}\BepInEx\plugins".
    * https://github.com/forest-soft/arcade_paradise_unbreakable_plugin/releases
6. Launch Arcade Paradise and you're done!

# Supplement
* If you want to check whether BepInEx is loaded, change "Enabled = false" to "Enabled = true" around line 85 of "\BepInEx\config\BepInEx.cfg".
A window displaying the BepInEx log will now be displayed.
```
80: [Logging.Console]
81: 
82: ## Enables showing a console for log output.
83: # Setting type: Boolean
84: # Default value: false
85: Enabled = false　←Please change "false" to "true".
```
* If BepInEx is not loaded when you launch it from the "Play" button on the Steam client, try restarting the Steam client.

