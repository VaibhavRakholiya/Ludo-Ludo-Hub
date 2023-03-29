using UnityEngine;

public class TestManager : MonoBehaviour
{
  public static TestManager Instance;
  public bool isCustomPawnPath;
  public bool isCustomDice;
  
  public int customPawnPath;
  public int customDiceAmount;
  
  private void Awake()
  {
    if (Instance == null)
    {
      Instance = this;
      DontDestroyOnLoad(gameObject);
    }
    else
    {
      Destroy(gameObject);
    }
  }
}
