namespace Project.Features.Utils.Facade
{
    using UnityEngine;

    /// <summary>
    /// Базовый провайдер
    /// </summary>
    public abstract class BaseFacadeProvider : MonoBehaviour
    {
        [SerializeField] protected BaseFacadeContainer container = default;

        protected virtual void OnEnable()
        {
            if (container.Facade != null)
            {
                OnEntityInited();
            }
            container.onInited += OnEntityInited;
            container.onDisposed += OnEntityDisposed;
        }
        protected virtual void OnDisable()
        {
            container.onInited -= OnEntityInited;
            container.onDisposed -= OnEntityDisposed;
        }

        /// <summary>
        /// Вызывается при появлении сущности в контейнере
        /// </summary>
        protected virtual void OnEntityInited(){}

        /// <summary>
        /// Вызывается при уборки сущности из контейнера
        /// </summary>
        protected virtual void OnEntityDisposed(){}
    }
}