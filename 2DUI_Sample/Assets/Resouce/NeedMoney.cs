using UnityEngine;
using TMPro;

public class NeedMoney : MonoBehaviour
{
    public TMP_Text needText; // '필요 금액'을 표시할 텍스트 컴포넌트

    void Start()
    {
        if (needText == null) needText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // ClickCounter 인스턴스에 접속해서 need 값을 텍스트로 표시
        if (ClickCounter.instance != null)
        {
            needText.text = ClickCounter.instance.need.ToString();
        }
    }
}
