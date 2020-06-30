/*
               File: WWPBaseObjects.SecIsAuthByObjectName
        Description: Is Authorized By Object Name
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.17
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
   public class secisauthbyobjectname : GXProcedure
   {
      public secisauthbyobjectname( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secisauthbyobjectname( IGxContext context )
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
         this.AV11SecFunctionalityKey = aP0_SecFunctionalityKey;
         this.AV8IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV8IsAuthorized;
      }

      public bool executeUdp( String aP0_SecFunctionalityKey )
      {
         this.AV11SecFunctionalityKey = aP0_SecFunctionalityKey;
         this.AV8IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV8IsAuthorized;
         return AV8IsAuthorized ;
      }

      public void executeSubmit( String aP0_SecFunctionalityKey ,
                                 out bool aP1_IsAuthorized )
      {
         secisauthbyobjectname objsecisauthbyobjectname;
         objsecisauthbyobjectname = new secisauthbyobjectname();
         objsecisauthbyobjectname.AV11SecFunctionalityKey = aP0_SecFunctionalityKey;
         objsecisauthbyobjectname.AV8IsAuthorized = false ;
         objsecisauthbyobjectname.context.SetSubmitInitialConfig(context);
         objsecisauthbyobjectname.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecisauthbyobjectname);
         aP1_IsAuthorized=this.AV8IsAuthorized;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secisauthbyobjectname)stateInfo).executePrivate();
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
         AV8IsAuthorized = true;
         AV14tSDT_MicroUserInfo.FromJSonString(AV13tResult, null);
         AV15tUserType = StringUtil.Str( (decimal)(AV14tSDT_MicroUserInfo.gxTpr_Usertype), 4, 0);
         if ( StringUtil.StrCmp(StringUtil.Trim( AV15tUserType), "2") == 0 )
         {
            AV12tPermissions = ((SdtSDT_MicroUserInfo_Tenants)AV14tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Permissions;
            if ( (AV12tPermissions.IndexOf(StringUtil.RTrim( AV11SecFunctionalityKey))>0) )
            {
               GXt_boolean1 = AV8IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalityid(context ).execute(  A1SecFunctionalityId, out  GXt_boolean1) ;
               AV8IsAuthorized = GXt_boolean1;
            }
            else
            {
               AV8IsAuthorized = false;
            }
         }
         else
         {
            AV8IsAuthorized = false;
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV15tUserType), "1") == 0 )
         {
            AV12tPermissions = ((SdtSDT_MicroUserInfo_Institutes)AV14tSDT_MicroUserInfo.gxTpr_Institutes.Item(1)).gxTpr_Permissions;
            if ( (AV12tPermissions.IndexOf(StringUtil.RTrim( AV11SecFunctionalityKey))>0) )
            {
               GXt_boolean1 = AV8IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalityid(context ).execute(  A1SecFunctionalityId, out  GXt_boolean1) ;
               AV8IsAuthorized = GXt_boolean1;
            }
            else
            {
               AV8IsAuthorized = false;
            }
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV15tUserType), "0") == 0 )
         {
            AV12tPermissions = AV14tSDT_MicroUserInfo.gxTpr_Permissions;
            if ( (AV12tPermissions.IndexOf(StringUtil.RTrim( AV11SecFunctionalityKey))>0) )
            {
               GXt_boolean1 = AV8IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalityid(context ).execute(  A1SecFunctionalityId, out  GXt_boolean1) ;
               AV8IsAuthorized = GXt_boolean1;
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
         AV14tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV13tResult = "";
         AV15tUserType = "";
         AV12tPermissions = new GxSimpleCollection<String>();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long A1SecFunctionalityId ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private String AV11SecFunctionalityKey ;
      private String AV13tResult ;
      private String AV15tUserType ;
      private bool aP1_IsAuthorized ;
      private GxSimpleCollection<String> AV12tPermissions ;
      private SdtSDT_MicroUserInfo AV14tSDT_MicroUserInfo ;
   }

}
