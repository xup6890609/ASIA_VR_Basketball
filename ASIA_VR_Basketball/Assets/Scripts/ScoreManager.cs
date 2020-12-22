using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  [Header("得分介面")]
  public Text textScore;
  [Header("分數")]
  public int score;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}
