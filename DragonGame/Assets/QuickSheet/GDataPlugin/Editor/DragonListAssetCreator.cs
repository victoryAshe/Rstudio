using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/DragonList")]
    public static void CreateDragonListAssetFile()
    {
        DragonList asset = CustomAssetUtility.CreateAsset<DragonList>();
        asset.SheetName = "RStudio";
        asset.WorksheetName = "DragonList";
        EditorUtility.SetDirty(asset);        
    }
    
}