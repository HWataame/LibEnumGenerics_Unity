# LibEnumGenerics for Unity

## 概要
C#の数値とジェネリック引数の列挙型の値を変換するライブラリである「LibEnumGenerics(https://github.com/HWataame/LibEnumGenerics)」をUnityのPackageManagerから導入しやすくしたものです

## 使用方法
![ヘッダー画像](https://github.com/user-attachments/assets/52edd13f-aecc-4d05-964b-d9bc2866807f)

### 数値をジェネリック引数の列挙型の値に変換する
```csharp
// where T : unmanaged, Enum
T enumValue = Enum<T>.ToEnum(intValue);
```

### ジェネリック引数の列挙型の値を整数値に変換する
```csharp
// where T : unmanaged, Enum
T intValue = Enum<T>.ToInt32(enumValue);
```

## 導入方法 / English "How to introduction" is below this
1. Gitをインストールする
2. 追加したいプロジェクトを開き、Package Managerを開く
3. 以下の文字列をコピー、またはこのページ上部の「<> Code」からClone URLをコピーする

    https://github.com/HWataame/LibEnumGenerics_Unity.git
4. 「Package Manager」ウィンドウの左上の「＋」ボタンをクリックし、「Install package from git URL...」を選択する

    ![導入方法01](https://github.com/user-attachments/assets/e990f479-376e-4506-9f35-3ca589fb7a31)
5. 入力欄に手順2でコピーしたURLを貼り付け、「Install」ボタンを押す

    ![導入方法02](https://github.com/user-attachments/assets/2c2bb99d-de92-45ae-af5b-657bda993936)
6. (必要に応じて)Assembly Definition Assetの管理下のコードで利用する場合は、`LibEnumGenerics`をAssembly Definition Referencesに追加する

    ![導入方法03(必要に応じて)](https://github.com/user-attachments/assets/e74e721e-2552-472d-a00f-c072f4a3eb9c)

## How to introduction / 日本語の「導入方法」は上にあります
1. Install Git to your computer.
2. Open Package Manager in the Unity project to which you want to add this feature.
3. Copy the following string, or copy the Clone URL from "<> Code" at the top of this page

    https://github.com/HWataame/LibEnumGenerics_Unity.git
4. Click the "+" button in the "Package Manager" window and select "Install package from git URL...".

    ![導入方法01](https://github.com/user-attachments/assets/e990f479-376e-4506-9f35-3ca589fb7a31)
5. Paste the URL copied in Step 2 into the input field and press the "Install" button.

    ![導入方法02](https://github.com/user-attachments/assets/2c2bb99d-de92-45ae-af5b-657bda993936)
6. (If necessary) For use in code under the control of Assembly Definition Asset...

   Add `LibEnumGenerics` to "Assembly Definition References" in your Assembly Definition Asset.

    ![導入方法03(必要に応じて)](https://github.com/user-attachments/assets/e74e721e-2552-472d-a00f-c072f4a3eb9c)

## 詳しい仕様
### ジェネリック引数の列挙型の制約

`where T : unmanaged, Enum`

(C#のソースで作成した列挙型はこの条件を満たします)

### 使用可能な型
- 数値 → 列挙型の値

`byte` `sbyte` `ushort` `short` `uint` `int` `ulong` `long`

`float` `double` (`long`型にキャストするヘルパー)

- 列挙型の値の値 → 整数値

`byte` `sbyte` `ushort` `short` `uint` `int` `ulong` `long`

## ライセンス / License
MITライセンスです / Using "MIT License"

[LISENCE](/LICENSE)
