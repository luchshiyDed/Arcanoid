namespace Project.Features.Utils.Facade
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Абстрактная модель для фасада
    /// </summary>
    public abstract class AbstractModelFacade : ScriptableObject, IDisposable
    {
        /// <summary>
        /// Id данной модели
        /// </summary>
        public string Id => id;
        [SerializeField] protected string id = string.Empty;
        protected BaseFacade facade = default;

        /// <summary>
        /// Init facade
        /// </summary>
        /// <param name="facade"></param>
        public virtual void Initialize(BaseFacade facade)
        {
            this.facade = facade;
            InitModule();
        }

        /// <summary>
        /// Init module
        /// </summary>
        protected virtual void InitModule(){}
        /// <summary>
        /// After all modules inited
        /// </summary>
        public virtual void AfterInit(){}
        /// <summary>
        /// Cleaning module
        /// </summary>
        public virtual void Dispose(){}

    }
}