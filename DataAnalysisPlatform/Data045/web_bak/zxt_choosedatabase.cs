/*
               File: ZXT_ChooseDatabase
        Description: 选择数据库
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:2.60
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zxt_choosedatabase : GXProcedure
   {
      public zxt_choosedatabase( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zxt_choosedatabase( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref GxDataStore aP0_DBConnection )
      {
         this.AV8DBConnection = aP0_DBConnection;
         initialize();
         executePrivate();
         aP0_DBConnection=this.AV8DBConnection;
      }

      public GxDataStore executeUdp( )
      {
         this.AV8DBConnection = aP0_DBConnection;
         initialize();
         executePrivate();
         aP0_DBConnection=this.AV8DBConnection;
         return AV8DBConnection ;
      }

      public void executeSubmit( ref GxDataStore aP0_DBConnection )
      {
         zxt_choosedatabase objzxt_choosedatabase;
         objzxt_choosedatabase = new zxt_choosedatabase();
         objzxt_choosedatabase.AV8DBConnection = aP0_DBConnection;
         objzxt_choosedatabase.context.SetSubmitInitialConfig(context);
         objzxt_choosedatabase.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzxt_choosedatabase);
         aP0_DBConnection=this.AV8DBConnection;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zxt_choosedatabase)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV10tCurrentCode = context.GetCookie( "DAS_UserTInfo");
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV10tCurrentCode))) )
         {
            AV23SDT_Database = new SdtSDT_Database(context);
            AV25SessionInfo = AV24Websession.Get("Config_DataInfo");
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV25SessionInfo)) )
            {
               AV21BAS_Tenant.Load(AV10tCurrentCode);
               AV22SYS_Database.Load(AV21BAS_Tenant.gxTpr_Databaseid);
               AV14tDataBaseInfo = StringUtil.Trim( AV22SYS_Database.gxTpr_Connectionstring);
               AV17AddressIndex = (short)(StringUtil.StringSearch( AV14tDataBaseInfo, "data source=", 1));
               AV26SecureIndex = (short)(StringUtil.StringSearch( AV14tDataBaseInfo, "persist security info", 1));
               AV18DataNameIndex = (short)(StringUtil.StringSearch( AV14tDataBaseInfo, "initial catalog=", 1));
               AV16UserNameIndex = (short)(StringUtil.StringSearch( AV14tDataBaseInfo, "user id=", 1));
               AV15PasswordIndex = (short)(StringUtil.StringSearch( AV14tDataBaseInfo, "password=", 1));
               AV23SDT_Database.gxTpr_Databasename = StringUtil.Substring( AV14tDataBaseInfo, AV18DataNameIndex+16, AV26SecureIndex-17-AV18DataNameIndex);
               AV23SDT_Database.gxTpr_Dataaddress = StringUtil.Substring( AV14tDataBaseInfo, AV17AddressIndex+12, AV18DataNameIndex-13-AV17AddressIndex);
               AV23SDT_Database.gxTpr_Username = StringUtil.Substring( AV14tDataBaseInfo, AV16UserNameIndex+8, AV15PasswordIndex-9-AV16UserNameIndex);
               AV23SDT_Database.gxTpr_Userpwd = StringUtil.Substring( AV14tDataBaseInfo, AV15PasswordIndex+9, StringUtil.Len( AV14tDataBaseInfo)-9-AV15PasswordIndex);
               AV24Websession.Set("Config_DataInfo", AV23SDT_Database.ToJSonString(false));
            }
            else
            {
               AV23SDT_Database.FromJSonString(AV25SessionInfo, null);
            }
            AV8DBConnection = (GxDataStore)(context.GetDataStore( "Default"));
            AV8DBConnection.Connection.UserId = AV23SDT_Database.gxTpr_Username;
            AV8DBConnection.Connection.UserPassword = AV23SDT_Database.gxTpr_Userpwd;
            AV8DBConnection.Connection.Data = "DATABASE="+AV23SDT_Database.gxTpr_Databasename+";SERVER="+AV23SDT_Database.gxTpr_Dataaddress;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV10tCurrentCode = "";
         AV23SDT_Database = new SdtSDT_Database(context);
         AV25SessionInfo = "";
         AV24Websession = context.GetSession();
         AV21BAS_Tenant = new SdtBAS_Tenant(context);
         AV22SYS_Database = new SdtSYS_Database(context);
         AV14tDataBaseInfo = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV17AddressIndex ;
      private short AV26SecureIndex ;
      private short AV18DataNameIndex ;
      private short AV16UserNameIndex ;
      private short AV15PasswordIndex ;
      private String AV10tCurrentCode ;
      private String AV25SessionInfo ;
      private String AV14tDataBaseInfo ;
      private IGxSession AV24Websession ;
      private GxDataStore aP0_DBConnection ;
      private GxDataStore AV8DBConnection ;
      private SdtBAS_Tenant AV21BAS_Tenant ;
      private SdtSYS_Database AV22SYS_Database ;
      private SdtSDT_Database AV23SDT_Database ;
   }

}
