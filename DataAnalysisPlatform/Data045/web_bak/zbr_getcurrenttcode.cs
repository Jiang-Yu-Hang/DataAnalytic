/*
               File: ZBR_GetCurrentTCode
        Description: 获取当前的租户code
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:39.81
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
   public class zbr_getcurrenttcode : GXProcedure
   {
      public zbr_getcurrenttcode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_getcurrenttcode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_tCurrentCode )
      {
         this.AV8tCurrentCode = "" ;
         initialize();
         executePrivate();
         aP0_tCurrentCode=this.AV8tCurrentCode;
      }

      public String executeUdp( )
      {
         this.AV8tCurrentCode = "" ;
         initialize();
         executePrivate();
         aP0_tCurrentCode=this.AV8tCurrentCode;
         return AV8tCurrentCode ;
      }

      public void executeSubmit( out String aP0_tCurrentCode )
      {
         zbr_getcurrenttcode objzbr_getcurrenttcode;
         objzbr_getcurrenttcode = new zbr_getcurrenttcode();
         objzbr_getcurrenttcode.AV8tCurrentCode = "" ;
         objzbr_getcurrenttcode.context.SetSubmitInitialConfig(context);
         objzbr_getcurrenttcode.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_getcurrenttcode);
         aP0_tCurrentCode=this.AV8tCurrentCode;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_getcurrenttcode)stateInfo).executePrivate();
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
         AV9httprequest.GetHeader("cookie");
         AV8tCurrentCode = context.GetCookie( "DAS_UserTInfo");
         AV8tCurrentCode = StringUtil.Trim( AV8tCurrentCode);
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
         AV9httprequest = new GxHttpRequest( context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV8tCurrentCode ;
      private String aP0_tCurrentCode ;
      private GxHttpRequest AV9httprequest ;
   }

}
