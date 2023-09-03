# Arcade Paradise Unbreakable Plugin
Arcade Paradiseのゲーム機を壊れないようにするプラグインです。
これを導入するとゲーム機が故障した時に出現するゴキブリ達に怯えることなくゲームをプレイできるようになります！

# 動作環境
Windows10、Steam版で動作確認をしました。

# 使い方
1. 「BepInEx_UnityIL2CPP_x64_6.0.0-pre.1.zip」をダウンロードしてください。
    * https://github.com/BepInEx/BepInEx/releases/tag/v6.0.0-pre.1
    * 6系の新しいバージョンが出ていれば新しいものを入れてください。
2. 上記のzipファイルを解凍して出てきた以下のフォルダ、ファイルをArcade Paradiseのインストールフォルダの「ArcadeParadise.exe」と同じ階層にコピーしてください。
    * BepInEx
    * mono
    * doorstop_config.ini
    * winhttp.dll
    * Arcade Paradiseのインストールフォルダは「C:\Program Files (x86)\Steam\steamapps\common\Arcade」などです。
4. 「ArcadeParadise.exe」を起動して、そのまま終了してください。
    * 初回起動時はBepInExが各種ファイルを生成するので少し時間かかります。
    * 先ほどコピーしたBepInExフォルダに入り、configやpluginsなどのフォルダが出来上がっていれば成功です。
5. 本プラグインを「{Arcade Paradiseのインストールフォルダ}\BepInEx\plugins」にコピーしてください。

これでインストール完了です！
