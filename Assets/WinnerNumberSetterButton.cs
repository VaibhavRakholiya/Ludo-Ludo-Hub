using UnityEngine;
using UnityEngine.UI;

public class WinnerNumberSetterButton : MonoBehaviour
{
    [SerializeField] private int winnerNumber;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameManager.Instance.winnersNumber = winnerNumber;
        });
    }
}
