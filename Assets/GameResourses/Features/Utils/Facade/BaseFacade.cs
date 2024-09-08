namespace Project.Features.Utils.Facade
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Базовый фасад
    /// </summary>
    public class BaseFacade : MonoBehaviour
    {
        /// <summary>
        /// Список контроллеров фасада
        /// </summary>
        public IReadOnlyList<AbstractControllerFacade> Controllers => controllers;

        /// <summary>
        /// Список моделей фасада
        /// </summary>
        public IReadOnlyList<AbstractModelFacade> Models => models;

        /// <summary>
        /// Возвращает Id фасада
        /// </summary>
        public string Id => id;
        [SerializeField] protected string id = string.Empty;
        [SerializeField] protected List<AbstractControllerFacade> controllers = new List<AbstractControllerFacade>();
        [SerializeField] protected List<AbstractModelFacade> models = new List<AbstractModelFacade>();

        protected virtual void Awake()
        {

            models.ForEach(x => x.Initialize(this));
            controllers.ForEach(x => x.Initialize(this));
            models.ForEach(x => x.AfterInit());
            controllers.ForEach(x => x.AfterInit());
        }
        protected virtual void OnDestroy()
        {
            controllers.ForEach(x => x.Dispose());
            models.ForEach(x => x.Dispose());
        }

    }
}