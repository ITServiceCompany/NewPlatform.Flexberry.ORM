﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18010
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSSoft.STORMNET.Business.Audit.Objects
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;


    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Класс, содержащий настройки аудита по приложению
    /// </summary>
    // *** Start programmer edit section *** (AuditAppSetting CustomAttributes)

    // *** End programmer edit section *** (AuditAppSetting CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class AuditAppSetting : ICSSoft.STORMNET.DataObject
    {

        private string fAppName;

        private bool fAuditEnabled = false;

        private bool fIsDatabaseLocal = true;

        private string fAuditConnectionStringName;

        private string fAuditWinServiceUrl;

        private bool fWriteSessions = true;

        private ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode fDefaultWriteMode;

        private ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditDSSetting fAuditDSSettings;

        private ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditClassSetting fAuditClassSettings;

        // *** Start programmer edit section *** (AuditAppSetting CustomMembers)

        // *** End programmer edit section *** (AuditAppSetting CustomMembers)


        /// <summary>
        /// Имя приложения
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AppName CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AppName CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string AppName
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AppName Get start)

                // *** End programmer edit section *** (AuditAppSetting.AppName Get start)
                string result = this.fAppName;
                // *** Start programmer edit section *** (AuditAppSetting.AppName Get end)

                // *** End programmer edit section *** (AuditAppSetting.AppName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AppName Set start)

                // *** End programmer edit section *** (AuditAppSetting.AppName Set start)
                this.fAppName = value;
                // *** Start programmer edit section *** (AuditAppSetting.AppName Set end)

                // *** End programmer edit section *** (AuditAppSetting.AppName Set end)
            }
        }

        /// <summary>
        /// Включён ли аудит в приложении
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AuditEnabled CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AuditEnabled CustomAttributes)
        public virtual bool AuditEnabled
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditEnabled Get start)

                // *** End programmer edit section *** (AuditAppSetting.AuditEnabled Get start)
                bool result = this.fAuditEnabled;
                // *** Start programmer edit section *** (AuditAppSetting.AuditEnabled Get end)

                // *** End programmer edit section *** (AuditAppSetting.AuditEnabled Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditEnabled Set start)

                // *** End programmer edit section *** (AuditAppSetting.AuditEnabled Set start)
                this.fAuditEnabled = value;
                // *** Start programmer edit section *** (AuditAppSetting.AuditEnabled Set end)

                // *** End programmer edit section *** (AuditAppSetting.AuditEnabled Set end)
            }
        }

        /// <summary>
        /// Является ли база данных с аудитом локальной
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.IsDatabaseLocal CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.IsDatabaseLocal CustomAttributes)
        public virtual bool IsDatabaseLocal
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.IsDatabaseLocal Get start)

                // *** End programmer edit section *** (AuditAppSetting.IsDatabaseLocal Get start)
                bool result = this.fIsDatabaseLocal;
                // *** Start programmer edit section *** (AuditAppSetting.IsDatabaseLocal Get end)

                // *** End programmer edit section *** (AuditAppSetting.IsDatabaseLocal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.IsDatabaseLocal Set start)

                // *** End programmer edit section *** (AuditAppSetting.IsDatabaseLocal Set start)
                this.fIsDatabaseLocal = value;
                // *** Start programmer edit section *** (AuditAppSetting.IsDatabaseLocal Set end)

                // *** End programmer edit section *** (AuditAppSetting.IsDatabaseLocal Set end)
            }
        }

        /// <summary>
        /// Строка соединения с базой аудита
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AuditConnectionStringName CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AuditConnectionStringName CustomAttributes)
        [StrLen(255)]
        public virtual string AuditConnectionStringName
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditConnectionStringName Get start)

                // *** End programmer edit section *** (AuditAppSetting.AuditConnectionStringName Get start)
                string result = this.fAuditConnectionStringName;
                // *** Start programmer edit section *** (AuditAppSetting.AuditConnectionStringName Get end)

                // *** End programmer edit section *** (AuditAppSetting.AuditConnectionStringName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditConnectionStringName Set start)

                // *** End programmer edit section *** (AuditAppSetting.AuditConnectionStringName Set start)
                this.fAuditConnectionStringName = value;
                // *** Start programmer edit section *** (AuditAppSetting.AuditConnectionStringName Set end)

                // *** End programmer edit section *** (AuditAppSetting.AuditConnectionStringName Set end)
            }
        }

        /// <summary>
        /// Адрес win-сервиса аудита
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AuditWinServiceUrl CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AuditWinServiceUrl CustomAttributes)
        [StrLen(255)]
        public virtual string AuditWinServiceUrl
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Get start)

                // *** End programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Get start)
                string result = this.fAuditWinServiceUrl;
                // *** Start programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Get end)

                // *** End programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Set start)

                // *** End programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Set start)
                this.fAuditWinServiceUrl = value;
                // *** Start programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Set end)

                // *** End programmer edit section *** (AuditAppSetting.AuditWinServiceUrl Set end)
            }
        }

        /// <summary>
        /// Писать ли сессии пользователей
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.WriteSessions CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.WriteSessions CustomAttributes)
        public virtual bool WriteSessions
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.WriteSessions Get start)

                // *** End programmer edit section *** (AuditAppSetting.WriteSessions Get start)
                bool result = this.fWriteSessions;
                // *** Start programmer edit section *** (AuditAppSetting.WriteSessions Get end)

                // *** End programmer edit section *** (AuditAppSetting.WriteSessions Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.WriteSessions Set start)

                // *** End programmer edit section *** (AuditAppSetting.WriteSessions Set start)
                this.fWriteSessions = value;
                // *** Start programmer edit section *** (AuditAppSetting.WriteSessions Set end)

                // *** End programmer edit section *** (AuditAppSetting.WriteSessions Set end)
            }
        }

        /// <summary>
        /// Режим записи по умолчанию (если мы не можем определить класс и режим записи для него)
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.DefaultWriteMode CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.DefaultWriteMode CustomAttributes)
        public virtual ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode DefaultWriteMode
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.DefaultWriteMode Get start)

                // *** End programmer edit section *** (AuditAppSetting.DefaultWriteMode Get start)
                ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode result = this.fDefaultWriteMode;
                // *** Start programmer edit section *** (AuditAppSetting.DefaultWriteMode Get end)

                // *** End programmer edit section *** (AuditAppSetting.DefaultWriteMode Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.DefaultWriteMode Set start)

                // *** End programmer edit section *** (AuditAppSetting.DefaultWriteMode Set start)
                this.fDefaultWriteMode = value;
                // *** Start programmer edit section *** (AuditAppSetting.DefaultWriteMode Set end)

                // *** End programmer edit section *** (AuditAppSetting.DefaultWriteMode Set end)
            }
        }

        /// <summary>
        /// Класс, содержащий настройки аудита по приложению
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AuditDSSettings CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AuditDSSettings CustomAttributes)
        public virtual ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditDSSetting AuditDSSettings
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditDSSettings Get start)

                // *** End programmer edit section *** (AuditAppSetting.AuditDSSettings Get start)
                if ((this.fAuditDSSettings == null))
                {
                    this.fAuditDSSettings = new ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditDSSetting(this);
                }
                ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditDSSetting result = this.fAuditDSSettings;
                // *** Start programmer edit section *** (AuditAppSetting.AuditDSSettings Get end)

                // *** End programmer edit section *** (AuditAppSetting.AuditDSSettings Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditDSSettings Set start)

                // *** End programmer edit section *** (AuditAppSetting.AuditDSSettings Set start)
                this.fAuditDSSettings = value;
                // *** Start programmer edit section *** (AuditAppSetting.AuditDSSettings Set end)

                // *** End programmer edit section *** (AuditAppSetting.AuditDSSettings Set end)
            }
        }

        /// <summary>
        /// Класс, содержащий настройки аудита по приложению
        /// </summary>
        // *** Start programmer edit section *** (AuditAppSetting.AuditClassSettings CustomAttributes)

        // *** End programmer edit section *** (AuditAppSetting.AuditClassSettings CustomAttributes)
        public virtual ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditClassSetting AuditClassSettings
        {
            get
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditClassSettings Get start)

                // *** End programmer edit section *** (AuditAppSetting.AuditClassSettings Get start)
                if ((this.fAuditClassSettings == null))
                {
                    this.fAuditClassSettings = new ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditClassSetting(this);
                }
                ICSSoft.STORMNET.Business.Audit.Objects.DetailArrayOfAuditClassSetting result = this.fAuditClassSettings;
                // *** Start programmer edit section *** (AuditAppSetting.AuditClassSettings Get end)

                // *** End programmer edit section *** (AuditAppSetting.AuditClassSettings Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (AuditAppSetting.AuditClassSettings Set start)

                // *** End programmer edit section *** (AuditAppSetting.AuditClassSettings Set start)
                this.fAuditClassSettings = value;
                // *** Start programmer edit section *** (AuditAppSetting.AuditClassSettings Set end)

                // *** End programmer edit section *** (AuditAppSetting.AuditClassSettings Set end)
            }
        }
    }
}
