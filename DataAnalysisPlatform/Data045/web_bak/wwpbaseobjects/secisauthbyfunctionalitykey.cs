/*
               File: WWPBaseObjects.SecIsAuthByFunctionalityKey
        Description: Is Authorized By Functionality
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:19.87
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secisauthbyfunctionalitykey : GXProcedure
   {
      public secisauthbyfunctionalitykey( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secisauthbyfunctionalitykey( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_SecFunctionalityKey ,
                           out bool aP1_IsAuthorized )
      {
         this.AV9SecFunctionalityKey = aP0_SecFunctionalityKey;
         this.AV8IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV8IsAuthorized;
      }

      public bool executeUdp( String aP0_SecFunctionalityKey )
      {
         this.AV9SecFunctionalityKey = aP0_SecFunctionalityKey;
         this.AV8IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV8IsAuthorized;
         return AV8IsAuthorized ;
      }

      public void executeSubmit( String aP0_SecFunctionalityKey ,
                                 out bool aP1_IsAuthorized )
      {
         secisauthbyfunctionalitykey objsecisauthbyfunctionalitykey;
         objsecisauthbyfunctionalitykey = new secisauthbyfunctionalitykey();
         objsecisauthbyfunctionalitykey.AV9SecFunctionalityKey = aP0_SecFunctionalityKey;
         objsecisauthbyfunctionalitykey.AV8IsAuthorized = false ;
         objsecisauthbyfunctionalitykey.context.SetSubmitInitialConfig(context);
         objsecisauthbyfunctionalitykey.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecisauthbyfunctionalitykey);
         aP1_IsAuthorized=this.AV8IsAuthorized;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secisauthbyfunctionalitykey)stateInfo).executePrivate();
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
         AV8IsAuthorized = false;
         AV15tResult = AV18websession.Get("DAS_UserPermission");
         AV16tSDT_MicroUserInfo.FromJSonString(AV15tResult, null);
         AV17tUserType = StringUtil.Str( (decimal)(AV16tSDT_MicroUserInfo.gxTpr_Usertype), 4, 0);
         if ( StringUtil.StrCmp(StringUtil.Trim( AV17tUserType), "2") == 0 )
         {
            AV14tPermissions = ((SdtSDT_MicroUserInfo_Tenants)AV16tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Permissions;
            if ( (AV14tPermissions.IndexOf(StringUtil.RTrim( AV9SecFunctionalityKey))>0) )
            {
               AV8IsAuthorized = true;
            }
            else
            {
               AV8IsAuthorized = false;
            }
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV17tUserType), "1") == 0 )
         {
            AV14tPermissions = ((SdtSDT_MicroUserInfo_Institutes)AV16tSDT_MicroUserInfo.gxTpr_Institutes.Item(1)).gxTpr_Permissions;
            if ( (AV14tPermissions.IndexOf(StringUtil.RTrim( AV9SecFunctionalityKey))>0) )
            {
               AV8IsAuthorized = true;
            }
            else
            {
               AV8IsAuthorized = false;
            }
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV17tUserType), "0") == 0 )
         {
            AV14tPermissions = AV16tSDT_MicroUserInfo.gxTpr_Permissions;
            if ( (AV14tPermissions.IndexOf(StringUtil.RTrim( AV9SecFunctionalityKey))>0) )
            {
               AV8IsAuthorized = true;
            }
            else
            {
               AV8IsAuthorized = false;
            }
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
         AV15tResult = "";
         AV18websession = context.GetSession();
         AV16tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV17tUserType = "";
         AV14tPermissions = new GxSimpleCollection<String>();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV8IsAuthorized ;
      private String AV9SecFunctionalityKey ;
      private String AV15tResult ;
      private String AV17tUserType ;
      private IGxSession AV18websession ;
      private bool aP1_IsAuthorized ;
      private GxSimpleCollection<String> AV14tPermissions ;
      private SdtSDT_MicroUserInfo AV16tSDT_MicroUserInfo ;
   }

}
