/*
               File: testWEBS
        Description: test WEBS
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:48.79
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class testwebs : GXProcedure
   {
      public testwebs( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public testwebs( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_content )
      {
         this.AV9content = "" ;
         initialize();
         executePrivate();
         aP0_content=this.AV9content;
      }

      public String executeUdp( )
      {
         this.AV9content = "" ;
         initialize();
         executePrivate();
         aP0_content=this.AV9content;
         return AV9content ;
      }

      public void executeSubmit( out String aP0_content )
      {
         testwebs objtestwebs;
         objtestwebs = new testwebs();
         objtestwebs.AV9content = "" ;
         objtestwebs.context.SetSubmitInitialConfig(context);
         objtestwebs.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objtestwebs);
         aP0_content=this.AV9content;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((testwebs)stateInfo).executePrivate();
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
         AV13XT_Config.Load(9);
         AV9content = AV13XT_Config.gxTpr_Xt_configvalue1;
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
         AV13XT_Config = new SdtXT_Config(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV9content ;
      private String aP0_content ;
      private SdtXT_Config AV13XT_Config ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.testwebs_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class testwebs_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( out String content )
      {
         content = "" ;
         try
         {
            if ( ! ProcessHeaders("testwebs") )
            {
               return  ;
            }
            testwebs worker = new testwebs(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(out content );
            worker.cleanup( );
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
      }

   }

}
