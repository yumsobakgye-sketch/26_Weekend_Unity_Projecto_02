using System;
using UnityEngine;


public enum RSPInfo
{
    Rock,
    Scissors,
    Paper
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 

    public RSPInfo enemyInfo;
    public bool bEnemyTurnState = false;

    // 플레이어의 체력

    private void Awake()
    {
        Instance = this;
    }

    public enum GameFlowInfo
    {
        PlayerTurn,
        EnemyTurn,
    }

    private void SelectEnemyInfo()
    {
        int rValue = UnityEngine.Random.Range(0, 3);

        enemyInfo = (RSPInfo)rValue;

        bEnemyTurnState = false;
    }

    public void PlayGame(GameFlowInfo EGF)
    {
        switch (EGF)
        {
            case GameFlowInfo.PlayerTurn:

                // 플레이어의 버튼을 기다린다.

                break;
            case GameFlowInfo.EnemyTurn:

                bEnemyTurnState = true;
                SelectEnemyInfo();

                break;
            default:
                break;
        }
    }

    // 바위(0) -> 가위(1) -> 보(2)

    public void GameResult(RSPInfo playerInfo)
    {
        // round++

        if(playerInfo == RSPInfo.Rock)
        {
            if(enemyInfo == RSPInfo.Rock)
            {
                Debug.Log("비겼다.");
            }
            else if(enemyInfo == RSPInfo.Scissors)
            {
                Debug.Log("이겼다.");
            }
            else if((enemyInfo == RSPInfo.Paper))
            {
                Debug.Log("졌다.");
                // 체력을 1 깍는다.
            }
        }
    }

 

}