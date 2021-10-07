using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    public GameObject OptPanel;

    public static bool IsStrong = false; //강하게를 눌렀는지
    public static bool IsWeak = false; //약하게를 눌렀는지
    public static bool IsLeftJump = false; //왼쪽 도약 키를 눌렀는지
    public static bool IsRightJump = false; //오른쪽 도약 키를 눌렀는지

    private bool IsStop = false; //옵션을 눌렀는지

    public static bool isFIrstJump = true;

    private void Start()
    {
        OptPanel.SetActive(false);
    }

    public void Strong()
    {
       IsStrong = true;

    }

    public void Weak()
    {
        IsWeak = true;
    }

    public void LeftJump()
    {
       IsLeftJump = true;
    }

    public void RightJump()
    {
       IsRightJump = true;
    }

    public void TimeNotMove()
    {
        if (!IsStop)
        {
            Time.timeScale = 0; //시간 멈춤
            OptPanel.SetActive(true); //옵션 판넬 보이게 함
            IsStop = true;
        }
        else
        {
            Time.timeScale = 1; //시간 움직임
            OptPanel.SetActive(false); //옵션 판넬 안보이게 함
            IsStop = false;
        }
    }

    public void IsMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void Again()
    {
        SceneManager.LoadScene("InGame");
    }
}
