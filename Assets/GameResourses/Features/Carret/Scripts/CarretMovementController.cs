namespace Project.Features.Carret
{
    using Utils.Facade;
    using UnityEngine;
    /// <summary>
    /// Класс отвечающий за контроль каретки игроком
    /// </summary>
    public sealed class CarretMovementController : AbstractControllerFacade
    {
        private Rigidbody _rigidbody=default;
        private CarretMovementModel _model=default;

        protected override void InitModule()
        {
            base.InitModule();
            _rigidbody=facade.GetComponent<Rigidbody>();
            _model=facade.FindModel<CarretMovementModel>();
        }
        private void FixedUpdate()
        {
            _rigidbody.velocity= Input.GetAxis("Horizontal")*_model.Speed*Time.timeScale*Vector3.forward;
        }
    }
}

