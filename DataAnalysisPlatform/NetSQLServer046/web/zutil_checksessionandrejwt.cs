/*
               File: ZUtil_CheckSessionAndReJWT
        Description: 检查session的方法并且刷新JWT
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:8.52
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
   public class zutil_checksessionandrejwt : GXProcedure
   {
      public zutil_checksessionandrejwt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_checksessionandrejwt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         zutil_checksessionandrejwt objzutil_checksessionandrejwt;
         objzutil_checksessionandrejwt = new zutil_checksessionandrejwt();
         objzutil_checksessionandrejwt.context.SetSubmitInitialConfig(context);
         objzutil_checksessionandrejwt.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_checksessionandrejwt);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_checksessionandrejwt)stateInfo).executePrivate();
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
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11websession.Get("DAS_UserPermission")))) )
         {
            AV10tCookieContent = context.GetCookie( "DAS_LoginUser");
            if ( StringUtil.StrCmp(StringUtil.Trim( AV19JWTDecode.decode(AV10tCookieContent)), "DecodeFail") != 0 )
            {
               AV10tCookieContent = AV20JWTRefreshCode.refreshcode(AV10tCookieContent);
               AV22jwtcookie.Name = "DAS_LoginUser";
               AV22jwtcookie.CurrentValue = AV10tCookieContent;
               AV22jwtcookie.Path = "/";
               AV22jwtcookie.HttpOnly = false;
               AV23httpresponse.SetCookie(AV22jwtcookie);
            }
            else
            {
               new wb_logout(context ).execute( out  AV14tSetFlag) ;
               AV15BCXT_Config.Load(4);
               AV16tTargetUrl = StringUtil.Trim( AV15BCXT_Config.gxTpr_Xt_configvalue2);
               AV17tCurPage = AV18httprequest.BaseURL;
               AV17tCurPage = AV17tCurPage + AV18httprequest.ScriptName;
               AV16tTargetUrl = AV16tTargetUrl + "?returnurl=";
               AV16tTargetUrl = AV16tTargetUrl + AV17tCurPage;
               CallWebObject(AV16tTargetUrl);
               context.wjLocDisableFrm = 0;
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
         AV11websession = context.GetSession();
         AV10tCookieContent = "";
         AV19JWTDecode = new SdtJWTDecode(context);
         AV20JWTRefreshCode = new SdtJWTRefreshCode(context);
         AV22jwtcookie = new GxHttpCookie();
         AV23httpresponse = new GxHttpResponse( context);
         AV15BCXT_Config = new SdtXT_Config(context);
         AV16tTargetUrl = "";
         AV17tCurPage = "";
         AV18httprequest = new GxHttpRequest( context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV14tSetFlag ;
      private String AV10tCookieContent ;
      private String AV16tTargetUrl ;
      private String AV17tCurPage ;
      private IGxSession AV11websession ;
      private SdtJWTDecode AV19JWTDecode ;
      private SdtJWTRefreshCode AV20JWTRefreshCode ;
      private GxHttpCookie AV22jwtcookie ;
      private GxHttpRequest AV18httprequest ;
      private GxHttpResponse AV23httpresponse ;
      private SdtXT_Config AV15BCXT_Config ;
   }

}
