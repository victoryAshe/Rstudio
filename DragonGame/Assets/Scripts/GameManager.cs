using CSVLoader;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private CSVLoader.CSVManager _parseCsv;

    public CSVManager ParseCsv { get => _parseCsv; set => _parseCsv = value; }

    // Start is called before the first frame update
    void Start()
    {
        _parseCsv = GameObject.FindObjectOfType<CSVManager>();
        //엑셀 데이터의 정보를 불러옵니다.
        Debug.Log(_parseCsv.ReadCSV("아르곤").Dragon_Level);
    }


    public void StartMainGameScene()
    {
        //시작하기 버튼을 누르면 메인게임으로 이동
        SceneManager.LoadScene("MainGameScene");
    }
}
