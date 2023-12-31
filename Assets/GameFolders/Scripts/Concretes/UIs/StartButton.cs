using GameProject3.Abstracts.UIs;
using GameProject3.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace GameProject3.UIs
{
    public class StartButton : BaseButton
    {

        protected override void HandleOnButtonClicked()
        {
            GameManager.Instance.LoadLevel("Game");
        }
    }
}

