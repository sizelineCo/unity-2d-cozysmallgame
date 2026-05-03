using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isGameEnded = false;

    void Awake()
    {
        Instance = this;
    }

    public void EndGame()
    {
        isGameEnded = true;
        Debug.Log("GAME ENDED");
    }
}