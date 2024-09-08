namespace Project.Features.Utils
{
    using System;
    using UnityEngine;
    /// <summary>
    /// абстрактный класс для Триггера
    /// </summary>
    public abstract class AbstractTrigger<T> : MonoBehaviour where T : Component
    {
        /// <summary>
        /// Получение компонента
        /// </summary>
        public event Action onTriggerEnter = delegate { };
        /// <summary>
        /// Потеря компонента
        /// </summary>
        public event Action onTriggerExit = delegate { };
        protected T targetComponent = default;
        public T Target=>targetComponent;
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<T>(out targetComponent))
            {
                onTriggerEnter();
            }
        }
        protected virtual void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent<T>(out targetComponent))
            {
                onTriggerExit();
            }
        }

    }
}