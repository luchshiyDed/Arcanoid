namespace Project.Features.Carret
{
    using Utils.Facade;
    using UnityEngine;
    /// <summary>
    /// Класс отвечающий за контроль каретки игроком
    /// </summary>
    [CreateAssetMenu(fileName ="CarretMovement",menuName ="Project/Features/Carret/Movement")]
    public sealed class CarretMovementModel : AbstractModelFacade
    {
        /// <summary>
        /// Возвращает значение скорости
        /// </summary>
        public float Speed =>_speed;
        [SerializeField] private float _speed=1f;
    }
}

