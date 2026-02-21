using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    // --- 추가된 부분: 싱글톤 ---
    public static ClickCounter instance;

    void Awake()
    {
        instance = this;
    }
    // ------------------------

    public TMP_Text textComponent;
    public int x = 0;
    public int y = 1;
    public int need = 20; // public으로 변경해야 밖에서 보입니다.

    public void OnButtonClick()
    {
        x = x + y;
    }

    public void OnButtonUpgradeClick()
    {
        if (x >= need)
        {
            y = y + 1;
            x = x - need;
            need = Mathf.RoundToInt(need * 1.25f);
        }
    }

    void Start()
    {
        if (textComponent == null) textComponent = GetComponentInChildren<TMP_Text>();
    }

    private void FixedUpdate()
    {
        textComponent.text = x.ToString();
    }
}
