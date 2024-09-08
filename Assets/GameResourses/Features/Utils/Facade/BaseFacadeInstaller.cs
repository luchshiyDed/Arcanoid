namespace Project.Features.Utils.Facade
{
    using UnityEngine;

    /// <summary>
    /// Базовый инсталлер фасада
    /// </summary>
    public class BaseFacadeInstaller : MonoBehaviour
    {
        [SerializeField] protected BaseFacade facade = default;
        [SerializeField] protected BaseFacadeContainer container = default;
        protected virtual void Start() => container.Init(facade);
        protected virtual void OnDestroy() => container.Dispose();
    }
}
