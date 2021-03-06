﻿namespace ICSSoft.Services
{
    using Microsoft.Practices.Unity;

    /// <summary>
    /// Сервис для получения текущего пользователя.
    /// </summary>
    public static partial class CurrentUserService
    {
        /// <summary>
        /// Контейнер Unity Framework.
        /// </summary>
        private static IUnityContainer _container;

        /// <summary>
        /// Пользователь по умолчанию, используемый в случае, если тип пользователя 
        /// не зарегистрирован в конфигурации unity, либо его не удалось разрешить.
        /// </summary>
        private static IUser _defaultUser;

        /// <summary>
        /// Инициализация сервиса.
        /// </summary>
        static CurrentUserService()
        {
            Reset();
        }

        /// <summary>
        /// Текущий пользователь.
        /// </summary>
        public static IUser CurrentUser
        {
            get { return GetRegisteredUser() ?? _defaultUser; }
        }

        /// <summary>
        /// Изменить способ получения текущего пользователя.
        /// </summary>
        /// <typeparam name="T">Класс, ответственный за работу с текущим пользователем.</typeparam>
        public static void ResolveUser<T>() where T : IUser
        {
            _container.RegisterType<IUser, T>(new ContainerControlledLifetimeManager());
        }

        /// <summary>
        /// Инициализирует настройки сервиса по умолчанию.
        /// </summary>
        public static void Reset()
        {
            _container = UnityFactory.CreateContainer();
            _defaultUser = new CurrentUser();
        }

        /// <summary>
        /// Получить пользователя, тип которого зарегистрирован в конфигурации unity.
        /// </summary>
        /// <returns>Данные о зарегистрированном пользователе, либо <c>null</c>, если его не удалось разрешить.</returns>
        private static IUser GetRegisteredUser()
        {
            return _container.IsRegistered<IUser>() ? _container.Resolve<IUser>() : null;
        }
    }
}
