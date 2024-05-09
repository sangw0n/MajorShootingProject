namespace MajorProject.Lobby
{
    // # System
    using System.Collections;
    using System.Collections.Generic;

    // # Unity
    using UnityEngine;
    using UnityEngine.UI;

    public class ButtonManager : MonoBehaviour
    {
        // 버튼 변수 
        [SerializeField] private Button startButton;
        [SerializeField] private Button creditButton;
        [SerializeField] private Button settingButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button howtoplayButton;

        private void Start()
        {
            startButton.onClick.AddListener(() => OnClickStartBtn());


        }

        private void OnClickStartBtn()
        {
            Debug.Log("게임 시작!");
        }
    }
}