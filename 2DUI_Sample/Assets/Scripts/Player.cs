using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI playerSelectText;
    
    public void SelectR()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Rock);

        playerSelectText.text = "바위";

    }

    public void SelectS()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Scissors);
        
        playerSelectText.text = "가위";

    }

    public void SelectP()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Paper);

        playerSelectText.text = "보";

    }

}
