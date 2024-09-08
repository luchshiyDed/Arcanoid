namespace Project.Features.Utils.Facade
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Абстрактный контроллер для фасада
    /// </summary>
    public abstract class AbstractControllerFacade : MonoBehaviour, IDisposable
    {
        /// <summary>
        /// Id данного контроллера
        /// </summary>
        public string Id => id;
        [SerializeField] protected string id = string.Empty;
        protected BaseFacade facade = default;


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