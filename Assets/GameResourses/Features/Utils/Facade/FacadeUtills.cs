namespace Project.Features.Utils.Facade
{
    using System.Collections.Generic;
  
    /// <summary>
    /// Класс для повторяющихся операций над объектами фасада
    /// </summary>
    public static class FacadeUtils
    {
        /// <summary>
        /// поиск модели в фасаде
        /// </summary>
        /// <param name="facade"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T FindModel<T>(this BaseFacade facade) where T:AbstractModelFacade
        {
            return (T)((List<AbstractModelFacade>)facade.Models).Find(x=>x is T);
        }
        /// <summary>
        /// поиск контроллера в фасаде
        /// </summary>
        /// <param name="facade"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T FindController<T>(this BaseFacade facade) where T:AbstractControllerFacade
        {
            return (T)((List<AbstractControllerFacade>)facade.Controllers).Find(x=>x is T);
        }
    }
}