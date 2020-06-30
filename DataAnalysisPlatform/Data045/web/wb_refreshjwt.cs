/*
               File: WB_RefreshJWT
        Description: 刷新jwt的接口
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.49
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
   public class wb_refreshjwt : GXProcedure
   {
      public wb_refreshjwt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wb_refreshjwt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_newToken )
      {
         this.AV11newToken = "" ;
         initialize();
         executePrivate();
         aP0_newToken=this.AV11newToken;
      }

      public String executeUdp( )
      {
         this.AV11newToken = "" ;
         initialize();
         executePrivate();
         aP0_newToken=this.AV11newToken;
         return AV11newToken ;
      }

      public void executeSubmit( out String aP0_newToken )
      {
         wb_refreshjwt objwb_refreshjwt;
         objwb_refreshjwt = new wb_refreshjwt();
         objwb_refreshjwt.AV11newToken = "" ;
         objwb_refreshjwt.context.SetSubmitInitialConfig(context);
         objwb_refreshjwt.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwb_refreshjwt);
         aP0_newToken=this.AV11newToken;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wb_refreshjwt)stateInfo).executePrivate();
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
         AV8httprequest.GetHeader("Cookie");
         if ( ! context.isAjaxRequest( ) )
         {
            AV9httpresponse.AppendHeader("Access-Control-Allow-Origin", "*");
         }
         GXt_char1 = AV11newToken;
         new zutil_gettargetcookievalue(context ).execute(  "DAS_LoginUser", out  GXt_char1) ;
         AV11newToken = GXt_char1;
         if ( StringUtil.StrCmp(AV11newToken, "CookieFindError") != 0 )
         {
            AV11newToken = AV19JWTRefreshCode.refreshcode(AV11newToken);
            AV13tCookieToken = "DAS_LoginUser=";
            AV13tCookieToken = AV13tCookieToken + StringUtil.Trim( AV11newToken);
            AV13tCookieToken = AV13tCookieToken + "; path=/;Expires=1969-12-31T23:59:59.000Z;";
            if ( ! context.isAjaxRequest( ) )
            {
               AV9httpresponse.AppendHeader("Access-Control-Allow-Credentials", "true");
            }
            if ( ! context.isAjaxRequest( ) )
            {
               AV9httpresponse.AppendHeader("Set-Cookie", AV13tCookieToken);
            }
         }
         else
         {
            AV11newToken = "Refresh Error";
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
         AV8httprequest = new GxHttpRequest( context);
         AV9httpresponse = new GxHttpResponse( context);
         GXt_char1 = "";
         AV19JWTRefreshCode = new SdtJWTRefreshCode(context);
         AV13tCookieToken = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String GXt_char1 ;
      private String AV11newToken ;
      private String AV13tCookieToken ;
      private SdtJWTRefreshCode AV19JWTRefreshCode ;
      private String aP0_newToken ;
      private GxHttpRequest AV8httprequest ;
      private GxHttpResponse AV9httpresponse ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.wb_refreshjwt_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class wb_refreshjwt_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( out String newToken )
      {
         newToken = "" ;
         try
         {
            if ( ! ProcessHeaders("wb_refreshjwt") )
            {
               return  ;
            }
            wb_refreshjwt worker = new wb_refreshjwt(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(out newToken );
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
