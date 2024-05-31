using DG.Tweening;
using UnityEngine;

namespace Root
{
    public abstract class BaseScreen : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;
        
        public virtual void Initialize()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
            _canvasGroup.alpha = 0.0f;
        }

        public virtual void ShowScreen()
        {
            gameObject.SetActive(true);
            _canvasGroup.DOFade(1.0f, 0.3f);
        }
        
        public virtual void HideScreen()
        {
            _canvasGroup.DOFade(0.0f, 0.3f);
            gameObject.SetActive(false);
        }
        
    }
}
