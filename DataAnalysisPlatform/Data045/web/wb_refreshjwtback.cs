/*
               File: WB_RefreshJWTBack
        Description: WB_Refresh JWTBack
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.65
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
   public class wb_refreshjwtback : GXProcedure
   {
      public wb_refreshjwtback( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wb_refreshjwtback( IGxContext context )
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
         wb_refreshjwtback objwb_refreshjwtback;
         objwb_refreshjwtback = new wb_refreshjwtback();
         objwb_refreshjwtback.AV11newToken = "" ;
         objwb_refreshjwtback.context.SetSubmitInitialConfig(context);
         objwb_refreshjwtback.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwb_refreshjwtback);
         aP0_newToken=this.AV11newToken;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wb_refreshjwtback)stateInfo).executePrivate();
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
            GXt_char1 = AV12tCookieContent;
            new zutil_gettargetcookievalue(context ).execute(  "GX_Cookie", out  GXt_char1) ;
            AV12tCookieContent = StringUtil.Trim( GXt_char1);
            AV12tCookieContent = StringUtil.StringReplace( StringUtil.StringReplace( StringUtil.StringReplace( AV12tCookieContent, "%2f", "/"), "%2b", "+"), "%3d", "=");
            AV11newToken = AV12tCookieContent;
            AV17tNewCookieContent = Decrypt64( AV12tCookieContent, "A803C9281F6C819705ADF9E4208BE89C");
            AV16WWPContext.FromXml(AV17tNewCookieContent, null, "WWPContext", "DataAnalysisPlatform");
            AV14tSDT_JWT = new SdtSDT_JWT(context);
            AV14tSDT_JWT.gxTpr_Name = AV16WWPContext.gxTpr_Username;
            AV14tSDT_JWT.gxTpr_Userid = AV16WWPContext.gxTpr_Userguid;
            AV14tSDT_JWT.gxTpr_Ip = AV16WWPContext.gxTpr_Clientip;
            AV14tSDT_JWT.gxTpr_Nbf = "123421423";
            AV14tSDT_JWT.gxTpr_Exp = "1740576564857";
            AV14tSDT_JWT.gxTpr_Iss = "das";
            AV14tSDT_JWT.gxTpr_Aud = "das";
            AV14tSDT_JWT.gxTpr_Iat = "124124214";
            AV13tCookieToken = "DAS_LoginUser=";
            AV18tNewJwtToken = AV10JWTEncode.encode(AV14tSDT_JWT.ToJSonString(false));
            AV13tCookieToken = AV13tCookieToken + StringUtil.Trim( AV18tNewJwtToken);
            AV13tCookieToken = AV13tCookieToken + "; path=/; HttpOnly; Expires=1969-12-31T23:59:59.000Z;";
            if ( ! context.isAjaxRequest( ) )
            {
               AV9httpresponse.AppendHeader("Access-Control-Allow-Credentials", "true");
            }
            if ( ! context.isAjaxRequest( ) )
            {
               AV9httpresponse.AppendHeader("Set-Cookie", AV13tCookieToken);
            }
            AV11newToken = AV18tNewJwtToken;
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
         AV12tCookieContent = "";
         GXt_char1 = "";
         AV17tNewCookieContent = "";
         AV16WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV14tSDT_JWT = new SdtSDT_JWT(context);
         AV13tCookieToken = "";
         AV18tNewJwtToken = "";
         AV10JWTEncode = new SdtJWTEncode(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String GXt_char1 ;
      private String AV11newToken ;
      private String AV12tCookieContent ;
      private String AV17tNewCookieContent ;
      private String AV13tCookieToken ;
      private String AV18tNewJwtToken ;
      private SdtJWTEncode AV10JWTEncode ;
      private String aP0_newToken ;
      private GxHttpRequest AV8httprequest ;
      private GxHttpResponse AV9httpresponse ;
      private SdtSDT_JWT AV14tSDT_JWT ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV16WWPContext ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.wb_refreshjwtback_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class wb_refreshjwtback_services : GxRestService
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
            if ( ! ProcessHeaders("wb_refreshjwtback") )
            {
               return  ;
            }
            wb_refreshjwtback worker = new wb_refreshjwtback(context) ;
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
