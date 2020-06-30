/*
               File: ZUtil_CheckSession
        Description: 检查session是否存在
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:23.87
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
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zutil_checksession : GXProcedure
   {
      public zutil_checksession( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_checksession( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out bool aP0_tCheckFlag )
      {
         this.AV18tCheckFlag = false ;
         initialize();
         executePrivate();
         aP0_tCheckFlag=this.AV18tCheckFlag;
      }

      public bool executeUdp( )
      {
         this.AV18tCheckFlag = false ;
         initialize();
         executePrivate();
         aP0_tCheckFlag=this.AV18tCheckFlag;
         return AV18tCheckFlag ;
      }

      public void executeSubmit( out bool aP0_tCheckFlag )
      {
         zutil_checksession objzutil_checksession;
         objzutil_checksession = new zutil_checksession();
         objzutil_checksession.AV18tCheckFlag = false ;
         objzutil_checksession.context.SetSubmitInitialConfig(context);
         objzutil_checksession.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_checksession);
         aP0_tCheckFlag=this.AV18tCheckFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_checksession)stateInfo).executePrivate();
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
         AV18tCheckFlag = false;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV8websession.Get("DAS_UserPermission")))) )
         {
            AV18tCheckFlag = true;
            AV15BCXT_Config.Load(4);
            AV13tTargetUrl = StringUtil.Trim( AV15BCXT_Config.gxTpr_Xt_configvalue2);
            CallWebObject(AV13tTargetUrl);
            context.wjLocDisableFrm = 0;
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
         AV8websession = context.GetSession();
         AV15BCXT_Config = new SdtXT_Config(context);
         AV13tTargetUrl = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV18tCheckFlag ;
      private String AV13tTargetUrl ;
      private IGxSession AV8websession ;
      private bool aP0_tCheckFlag ;
      private SdtXT_Config AV15BCXT_Config ;
   }

}
