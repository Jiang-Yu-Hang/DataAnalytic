/*
               File: ZUtil_SetPassword
        Description: 加密的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:53.50
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
   public class zutil_setpassword : GXProcedure
   {
      public zutil_setpassword( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_setpassword( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_iJC_AccountPassword ,
                           out String aP1_oJC_AccountPassword )
      {
         this.AV9iJC_AccountPassword = aP0_iJC_AccountPassword;
         this.AV12oJC_AccountPassword = "" ;
         initialize();
         executePrivate();
         aP1_oJC_AccountPassword=this.AV12oJC_AccountPassword;
      }

      public String executeUdp( String aP0_iJC_AccountPassword )
      {
         this.AV9iJC_AccountPassword = aP0_iJC_AccountPassword;
         this.AV12oJC_AccountPassword = "" ;
         initialize();
         executePrivate();
         aP1_oJC_AccountPassword=this.AV12oJC_AccountPassword;
         return AV12oJC_AccountPassword ;
      }

      public void executeSubmit( String aP0_iJC_AccountPassword ,
                                 out String aP1_oJC_AccountPassword )
      {
         zutil_setpassword objzutil_setpassword;
         objzutil_setpassword = new zutil_setpassword();
         objzutil_setpassword.AV9iJC_AccountPassword = aP0_iJC_AccountPassword;
         objzutil_setpassword.AV12oJC_AccountPassword = "" ;
         objzutil_setpassword.context.SetSubmitInitialConfig(context);
         objzutil_setpassword.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_setpassword);
         aP1_oJC_AccountPassword=this.AV12oJC_AccountPassword;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_setpassword)stateInfo).executePrivate();
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
         AV12oJC_AccountPassword = Encrypt64( AV9iJC_AccountPassword, "F67AF57DA63E2EB33204C7B9390FFF75");
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV9iJC_AccountPassword ;
      private String AV12oJC_AccountPassword ;
      private String aP1_oJC_AccountPassword ;
   }

}
