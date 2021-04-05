using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CSVLoader
{
    public class CSVManager : MonoBehaviour
    {
        public Dragon_User Info_DragonList;

        public Dragon_UserData ReadCSV(object _code)
        {
            Dragon_UserData _data = new Dragon_UserData();

            foreach(Dragon_UserData csvRead in Info_DragonList.dataArray)
            {
                int tempCode;

                if (int.TryParse(_code.ToString(), out tempCode))
                {
                    if (csvRead.Code == tempCode)
                    {
                        _data = csvRead;
                        break;
                    }
                }
                else
                {
                    if (csvRead.Dragonnames == _code.ToString())
                    {
                        _data = csvRead;
                        break;
                    }
                }
            }

            return _data;
        }
    }
}
