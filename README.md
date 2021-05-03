# What is this repository ?

- Unity Programming Bible 第2版「Addressable Assets System によるアセット管理」章用のサンプルプロジェクトです。

# Environment

- Unity 2021.1.5
- Addressables v1.16.19

# Installation

- リポジトリ clone 後、普通にプロジェクトを開いてください。

# Files

## `Assets/Scenes/SampleScene.unity`

- 本サンプルのメインシーンです。
- 「ソーシャルゲームのキャラ図鑑」をイメージした構成になっています。
- シーンを再生すると、ランダムでキャラのインデックス（0 〜 2）が確定し、 `AssetReference` を用いて対応する画像と音声を読み込みます。

## `Assets/Images/*`

- 読み込む画像です。
- 画像は [いらすとや](https://www.irasutoya.com/) さんからお借りしました。

