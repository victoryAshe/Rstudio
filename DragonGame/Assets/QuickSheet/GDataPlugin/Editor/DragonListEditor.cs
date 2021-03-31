using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(DragonList))]
public class DragonListEditor : BaseGoogleEditor<DragonList>
{	    
    public override bool Load()
    {        
        DragonList targetData = target as DragonList;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<DragonListData>(targetData.WorksheetName) ?? db.CreateTable<DragonListData>(targetData.WorksheetName);
        
        List<DragonListData> myDataList = new List<DragonListData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            DragonListData data = new DragonListData();
            
            data = Cloner.DeepCopy<DragonListData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
