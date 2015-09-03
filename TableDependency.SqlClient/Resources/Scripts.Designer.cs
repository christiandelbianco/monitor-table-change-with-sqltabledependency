﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableDependency.SqlClient.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Scripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TableDependency.SqlClient.Resources.Scripts", typeof(Scripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE CONTRACT [{0}] ([{0}_Deleted] SENT BY INITIATOR, [{0}_Inserted] SENT BY INITIATOR, [{0}_Updated] SENT BY INITIATOR).
        /// </summary>
        internal static string CreateContract {
            get {
                return ResourceManager.GetString("CreateContract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE MESSAGE TYPE [{0}_Deleted] VALIDATION = NONE.
        /// </summary>
        internal static string CreateMessageDeleted {
            get {
                return ResourceManager.GetString("CreateMessageDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE MESSAGE TYPE [{0}_Inserted] VALIDATION = NONE.
        /// </summary>
        internal static string CreateMessageInserted {
            get {
                return ResourceManager.GetString("CreateMessageInserted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE MESSAGE TYPE [{0}_Updated] VALIDATION = NONE.
        /// </summary>
        internal static string CreateMessageUpdated {
            get {
                return ResourceManager.GetString("CreateMessageUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [{0}_QueueActivation] AS 
        ///BEGIN 
        ///	BEGIN TRANSACTION
        ///
        ///	IF EXISTS (SELECT * FROM sys.service_queues WHERE name = N&apos;{0}&apos;)
        ///	BEGIN
        ///		IF (SELECT COUNT(*) FROM [{0}] WHERE message_type_name = &apos;http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer&apos;) &gt; 0 
        ///		BEGIN 
        ///			{1}
        ///		END 
        ///	END
        ///
        ///	COMMIT TRANSACTION
        ///END.
        /// </summary>
        internal static string CreateProcedureQueueActivation {
            get {
                return ResourceManager.GetString("CreateProcedureQueueActivation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE QUEUE [{0}] 
        ///WITH STATUS = ON, 
        ///RETENTION = OFF, 
        ///POISON_MESSAGE_HANDLING (STATUS = OFF), 
        ///ACTIVATION (STATUS = ON, PROCEDURE_NAME = [{0}_QueueActivation], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER).
        /// </summary>
        internal static string CreateQueue {
            get {
                return ResourceManager.GetString("CreateQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE SERVICE [{0}] ON QUEUE [{0}] ([{0}]).
        /// </summary>
        internal static string CreateService {
            get {
                return ResourceManager.GetString("CreateService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [tr_{0}] ON [{1}] AFTER INSERT, DELETE, UPDATE AS 
        ///BEGIN
        ///	-- stop if no row was affected
        ///	IF @@ROWCOUNT = 0 RETURN
        ///
        ///	-- Turn off rows affected messages
        ///	SET NOCOUNT ON;
        ///
        ///	DECLARE @h AS UNIQUEIDENTIFIER
        ///	DECLARE @records XML
        ///	DECLARE @message NVARCHAR(MAX)
        ///	DECLARE @dmlType NVARCHAR(10)
        ///	DECLARE @rowsToProcess INT
        ///	DECLARE @currentRow INT = 0
        ///	DECLARE @modifiedRecordsTable TABLE ([RowNumber] INT IDENTITY(1, 1), {2})
        ///	
        ///	IF NOT EXISTS(SELECT * FROM INSERTED)
        ///	BEGIN
        ///		SET @dmlTy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateTrigger {
            get {
                return ResourceManager.GetString("CreateTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF EXISTS (SELECT * FROM sys.objects WHERE name = N&apos;tr_{0}&apos;) DROP TRIGGER [tr_{0}];
        ///IF EXISTS (SELECT * FROM sys.services WHERE name = N&apos;{0}&apos;) DROP SERVICE [{0}];
        ///IF EXISTS (SELECT * FROM sys.service_queues WHERE name = N&apos;{0}&apos;) DROP QUEUE [{0}];
        ///IF EXISTS (SELECT * FROM sys.service_contracts WHERE name = N&apos;{0}&apos;) DROP CONTRACT [{0}];
        ///IF EXISTS (SELECT * FROM sys.service_message_types WHERE name = N&apos;{0}_Deleted&apos;) DROP MESSAGE TYPE [{0}_Deleted];
        ///IF EXISTS (SELECT * FROM sys.service_message_types WHERE na [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ScriptDropAll {
            get {
                return ResourceManager.GetString("ScriptDropAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF ({0})
        ///			BEGIN
        ///				SET @dmlType = &apos;UPDATE&apos;
        ///				INSERT INTO @modifiedRecordsTable SELECT * FROM INSERTED AS [{1}]
        ///			END
        ///			ELSE
        ///			BEGIN
        ///				RETURN
        ///			END.
        /// </summary>
        internal static string TriggerUpdateWithColumns {
            get {
                return ResourceManager.GetString("TriggerUpdateWithColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///				SET @dmlType = &apos;UPDATE&apos;
        ///				INSERT INTO @modifiedRecordsTable SELECT * FROM INSERTED AS [{0}]
        ///.
        /// </summary>
        internal static string TriggerUpdateWithoutColuns {
            get {
                return ResourceManager.GetString("TriggerUpdateWithoutColuns", resourceCulture);
            }
        }
    }
}
