﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// MasterUpdateObjectTest.
    /// </summary>
    // *** Start programmer edit section *** (MasterUpdateObjectTest CustomAttributes)

    // *** End programmer edit section *** (MasterUpdateObjectTest CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("MasterUpdateObjectTestE", new string[] {
            "MasterName"})]
    public class MasterUpdateObjectTest : ICSSoft.STORMNET.DataObject
    {
        
        private string fMasterName;
        
        // *** Start programmer edit section *** (MasterUpdateObjectTest CustomMembers)

        // *** End programmer edit section *** (MasterUpdateObjectTest CustomMembers)

        
        /// <summary>
        /// MasterName.
        /// </summary>
        // *** Start programmer edit section *** (MasterUpdateObjectTest.MasterName CustomAttributes)

        // *** End programmer edit section *** (MasterUpdateObjectTest.MasterName CustomAttributes)
        [StrLen(255)]
        public virtual string MasterName
        {
            get
            {
                // *** Start programmer edit section *** (MasterUpdateObjectTest.MasterName Get start)

                // *** End programmer edit section *** (MasterUpdateObjectTest.MasterName Get start)
                string result = this.fMasterName;
                // *** Start programmer edit section *** (MasterUpdateObjectTest.MasterName Get end)

                // *** End programmer edit section *** (MasterUpdateObjectTest.MasterName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MasterUpdateObjectTest.MasterName Set start)

                // *** End programmer edit section *** (MasterUpdateObjectTest.MasterName Set start)
                this.fMasterName = value;
                // *** Start programmer edit section *** (MasterUpdateObjectTest.MasterName Set end)

                // *** End programmer edit section *** (MasterUpdateObjectTest.MasterName Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "MasterUpdateObjectTestE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View MasterUpdateObjectTestE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("MasterUpdateObjectTestE", typeof(NewPlatform.Flexberry.ORM.Tests.MasterUpdateObjectTest));
                }
            }
        }
    }
}
