using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheckGold : MonoBehaviour
{
    public GameObject Gold_Text;
    public int Gold_added;
    public GameObject Gold_PlusText_obj;
    public Text Gold_PlusText;
    public static int Gold;

    void Start()
    {
        //일정 시간마다 더해줄 gold의 양
        Gold_added = 100;

        //1.5초가 지날 때마다 gold +
        InvokeRepeating("Invoke_GetGold", 1.0f, 1.0f);
        StartCoroutine("ShowAddedGold");
    }

    void Update()
    {
        Gold_Text.GetComponent<UILabel>().text = Gold + "G";
    }


    void Invoke_GetGold()
    {
        //1초가 지날 때마다 gold +
        Gold += Gold_added;
        
    }

    IEnumerator ShowAddedGold()
    {
        yield return new WaitForSeconds(0.7f);
        yield return StartCoroutine("AddedGold");
        
    }

    IEnumerator AddedGold()
    {
        Gold_PlusText.text = Gold_added + "G";
        Gold_PlusText_obj.SetActive(true);//gold가 추가됐음을 보여주는 텍스트 오브젝트

        yield return new WaitForSeconds(0.3f);
        Gold_PlusText_obj.SetActive(false);
        yield return StartCoroutine("ShowAddedGold");
    }
}
