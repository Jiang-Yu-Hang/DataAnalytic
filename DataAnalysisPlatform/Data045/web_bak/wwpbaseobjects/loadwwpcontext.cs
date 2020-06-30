/*
               File: WWPBaseObjects.LoadWWPContext
        Description: Load Work With Plus Context
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:19.62
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
   public class loadwwpcontext : GXProcedure
   {
      public loadwwpcontext( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public loadwwpcontext( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context )
      {
         this.AV8Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context) ;
         initialize();
         executePrivate();
         aP0_Context=this.AV8Context;
      }

      public GeneXus.Programs.wwpbaseobjects.SdtWWPContext executeUdp( )
      {
         this.AV8Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context) ;
         initialize();
         executePrivate();
         aP0_Context=this.AV8Context;
         return AV8Context ;
      }

      public void executeSubmit( out GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context )
      {
         loadwwpcontext objloadwwpcontext;
         objloadwwpcontext = new loadwwpcontext();
         objloadwwpcontext.AV8Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context) ;
         objloadwwpcontext.context.SetSubmitInitialConfig(context);
         objloadwwpcontext.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloadwwpcontext);
         aP0_Context=this.AV8Context;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadwwpcontext)stateInfo).executePrivate();
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
         AV10tCookieContent = context.GetCookie( "GX_Cookie");
         AV10tCookieContent = Decrypt64( AV10tCookieContent, "A803C9281F6C819705ADF9E4208BE89C");
         AV8Context.FromXml(AV10tCookieContent, null, "WWPContext", "DataAnalysisPlatform");
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
         AV10tCookieContent = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV10tCookieContent ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8Context ;
   }

}
