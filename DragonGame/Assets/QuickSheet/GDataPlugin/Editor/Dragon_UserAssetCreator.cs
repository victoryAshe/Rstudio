using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/Dragon_User")]
    public static void CreateDragon_UserAssetFile()
    {
        Dragon_User asset = CustomAssetUtility.CreateAsset<Dragon_User>();
        asset.SheetName = "RStudio";
        asset.WorksheetName = "Dragon_User";
        EditorUtility.SetDirty(asset);        
    }
    
}