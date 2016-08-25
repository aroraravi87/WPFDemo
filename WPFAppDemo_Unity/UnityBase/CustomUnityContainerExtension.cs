﻿#region Using directives

using Microsoft.Practices.Unity;
using WpfAppDemo_Library.DAL.AccountDao;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WpfAppDemo_Library.DAL.DashboardDao;
using WpfAppDemo_Library.DAL.DashboardDao.Interface;
using WpfAppDemo_Library.Manager.AccountManager;
using WpfAppDemo_Library.Manager.AccountManager.Interface;
using WpfAppDemo_Library.Manager.DashboardManager;

#endregion

namespace WPFAppDemo_Unity.UnityBase
{
    public class CustomUnityContainerExtension
    {
        /// <summary>
        /// The purpose of this class is to define the object registration activity for Unity Container
        /// In this class all application level object get registered
        /// </summary>
        public static void InitializeContainer()
        {
            ////Initializes Unity container
            InitializeUnityContainer();

            //Initializes Log Manager
           //CustomLogger.InitializeLogManager();
        }

        private static void InitializeUnityContainer()
        {
            CustomUnityContainer.Container = new UnityContainer();

            //call method to register business services
            RegisterBusinessServices();

            ////call method to register Persistence Layer clases
            RegisterPersistenceRepository();

            ////Registers the type mappings with the Unity container.
            RegisterTypes(CustomUnityContainer.Container);
        }

        /// <summary>
        /// This method is used to register the business services for dependency injection.
        /// </summary>
        private static void RegisterBusinessServices()
        {
            #region Registration of  Classes

            #region Custom DAO

            CustomUnityContainer.Register<IAccountDao, AccountDao>();
            CustomUnityContainer.Register<IDashboardDao, DashboardDao>();

            #endregion

            #region Custom Manager

            CustomUnityContainer.Register<IAccountManager, AccountManager>();
            CustomUnityContainer.Register<IDashboardManager, DashboardManager>();
            #endregion

            #endregion
        }

        /// <summary>
        /// This method is used to register the persistence layer repository for dependency injection.
        /// </summary>
        private static void RegisterPersistenceRepository()
        {
            //#region Registration of Persistence Layer Repository Classes

            //CustomUnityContainer.Register<IObjectMapper, ObjectMapper>();
            //CustomUnityContainer.Register(typeof(IGenericRepository<>), typeof(GenericRepositoryImpl<>));
            
            //#endregion
        }

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        private static void RegisterTypes(IUnityContainer container)
        {
            //container.RegisterType<IDbContext, RestaurantPOSEntities>();
            //container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}