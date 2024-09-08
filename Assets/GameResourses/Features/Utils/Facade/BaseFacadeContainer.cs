namespace Project.Features.Utils.Facade
{

    using System;
    using UnityEngine;
    /// <summary>
    /// Базовый контейнер
    /// </summary>
    [CreateAssetMenu(fileName = "BaseContainer", menuName = "Project/Features/Utils/Container")]
    public class BaseFacadeContainer : ScriptableObject, IDisposable
    {
        /// <summary>
        /// Возращает Id контейнера
        /// </summary>
        public string Id => id;
        /// <summary>
        /// вызывается при инциилизации контейнера сущностью
        /// </summary>
        public event Action onInited = delegate { };

        /// <summary>
        /// вызывается при уборке сущности из контейнера
        /// </summary>
        public event Action onDisposed = delegate { };
        /// <summary>
        /// возвращает фасад хранимый в контейнере
        /// </summary>
        public BaseFacade Facade
        {
            get => _facade;
            private set
            {
                if (value != null)
                {
                    _facade = value;
                    onInited();
                }
                else
                {
                    onDisposed();
                }

            }

        }
        [SerializeField] protected string id = string.Empty;
        private BaseFacade _facade = default;
        public void Init(BaseFacade facade)
        {
            Facade = facade;
        }

        public void Dispose()
        {
            _facade = null;
            onDisposed();
        }
    }
}
