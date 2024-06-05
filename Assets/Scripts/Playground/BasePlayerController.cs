using UnityEngine;

namespace Playground
{
    public abstract class BasePlayerController : MonoBehaviour
    {
        protected InputController inputController;
        private bool _isBlocked;

        public virtual void Interact()
        {
            
        }

        protected virtual void Move()
        {
            
        }

        protected virtual void Rotate()
        {
            
        }

        protected virtual void Awake()
        {
            inputController = GetComponent<InputController>();
        }

        protected virtual void Update()
        {
            if (!inputController)
            {
                return;
            }
            
            if (_isBlocked)
            {
                return;
            }
            
            Move();
            Rotate();
        }
    }
}
