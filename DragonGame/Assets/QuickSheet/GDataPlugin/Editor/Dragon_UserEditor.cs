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
[CustomEditor(typeof(Dragon_User))]
public class Dragon_UserEditor : BaseGoogleEditor<Dragon_User>
{	    
    public override bool Load()
    {        
        Dragon_User targetData = target as Dragon_User;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<Dragon_UserData>(targetData.WorksheetName) ?? db.CreateTable<Dragon_UserData>(targetData.WorksheetName);
        
        List<Dragon_UserData> myDataList = new List<Dragon_UserData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            Dragon_UserData data = new Dragon_UserData();
            
            data = Cloner.DeepCopy<Dragon_UserData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
