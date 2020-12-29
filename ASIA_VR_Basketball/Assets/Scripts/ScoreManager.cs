using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("得分介面")]
    public Text textScore;

    [Header("分數")]
    public int score;

    [Header("投進分數")]
    public int scoreIn = 2;

    [Header("進球音效")]
    public AudioClip soundIn;
    private AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();      //音效元件=取得元件<音效來源>
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "籃球")        //如果碰撞標籤是籃球就加分
        {
            AddScore();
        }
        
        // 如果碰撞到的跟物件名稱是Player就執行：
        if (other.transform.root.name=="Player")
        {
            scoreIn = 3;
        }
    
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.root.name=="Player")
        { 
            scoreIn = 2;
        }
    }
    /// <summary>
    /// 加分
    /// </summary>
    private void AddScore()
        {
        score+=scoreIn;
        textScore.text="分數："+score;
        aud.PlayOneShot(soundIn, 1.5f);
        }
 }

