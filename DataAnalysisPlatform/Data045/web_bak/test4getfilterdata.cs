/*
               File: Test4GetFilterData
        Description: Test4 Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 10:39:5.30
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class test4getfilterdata : GXProcedure
   {
      public test4getfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public test4getfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
         return AV44OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         test4getfilterdata objtest4getfilterdata;
         objtest4getfilterdata = new test4getfilterdata();
         objtest4getfilterdata.AV35DDOName = aP0_DDOName;
         objtest4getfilterdata.AV33SearchTxt = aP1_SearchTxt;
         objtest4getfilterdata.AV34SearchTxtTo = aP2_SearchTxtTo;
         objtest4getfilterdata.AV39OptionsJson = "" ;
         objtest4getfilterdata.AV42OptionsDescJson = "" ;
         objtest4getfilterdata.AV44OptionIndexesJson = "" ;
         objtest4getfilterdata.context.SetSubmitInitialConfig(context);
         objtest4getfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objtest4getfilterdata);
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((test4getfilterdata)stateInfo).executePrivate();
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
         AV39OptionsJson = "";
         AV42OptionsDescJson = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV44OptionIndexesJson ;
      private String AV39OptionsJson ;
      private String AV42OptionsDescJson ;
      private String AV35DDOName ;
      private String AV33SearchTxt ;
      private String AV34SearchTxtTo ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.test4getfilterdata_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class test4getfilterdata_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String DDOName ,
                           String SearchTxt ,
                           String SearchTxtTo ,
                           out String OptionsJson ,
                           out String OptionsDescJson ,
                           out String OptionIndexesJson )
      {
         OptionsJson = "" ;
         OptionsDescJson = "" ;
         OptionIndexesJson = "" ;
         try
         {
            if ( ! ProcessHeaders("test4getfilterdata") )
            {
               return  ;
            }
            test4getfilterdata worker = new test4getfilterdata(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
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
