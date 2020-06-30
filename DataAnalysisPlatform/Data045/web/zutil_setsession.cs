/*
               File: ZUtil_SetSession
        Description: …Ë÷√session
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:45.81
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
   public class zutil_setsession : GXProcedure
   {
      public zutil_setsession( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_setsession( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_WWPContext )
      {
         this.AV11WWPContext = aP0_WWPContext;
         initialize();
         executePrivate();
      }

      public void executeSubmit( GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_WWPContext )
      {
         zutil_setsession objzutil_setsession;
         objzutil_setsession = new zutil_setsession();
         objzutil_setsession.AV11WWPContext = aP0_WWPContext;
         objzutil_setsession.context.SetSubmitInitialConfig(context);
         objzutil_setsession.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_setsession);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_setsession)stateInfo).executePrivate();
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
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV8websession.Get("DAS_UserPermission")))) )
         {
            AV10tCookieContent = context.GetCookie( "DAS_LoginUser");
            if ( StringUtil.StrCmp(StringUtil.Trim( AV12JWTDecode.decode(AV10tCookieContent)), "DecodeFail") != 0 )
            {
               AV15BCXT_Config.Load(6);
               AV18tTargetAPI = StringUtil.Trim( AV15BCXT_Config.gxTpr_Xt_configvalue3);
               AV9httpclient.Host = AV18tTargetAPI;
               AV9httpclient.AddHeader("Connection", "keep-alive");
               AV9httpclient.AddHeader("Content-Type", "application/json; charset=utf-8");
               AV10tCookieContent = "DAS_LoginUser=" + StringUtil.Trim( AV10tCookieContent) + ";";
               AV9httpclient.AddHeader("Cookie", AV10tCookieContent);
               AV9httpclient.Execute("Get", "/api/User/getpermission?userid="+StringUtil.Trim( StringUtil.Upper( AV11WWPContext.gxTpr_Userguid)));
               AV8websession.Set("DAS_UserPermission", StringUtil.Trim( AV9httpclient.ToString()));
            }
            else
            {
               new wb_logout(context ).execute( out  AV14tSetFlag) ;
               AV15BCXT_Config.Load(4);
               AV13tTargetUrl = StringUtil.Trim( AV15BCXT_Config.gxTpr_Xt_configvalue2);
               CallWebObject(AV13tTargetUrl);
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
         AV8websession = context.GetSession();
         AV10tCookieContent = "";
         AV12JWTDecode = new SdtJWTDecode(context);
         AV15BCXT_Config = new SdtXT_Config(context);
         AV18tTargetAPI = "";
         AV9httpclient = new GxHttpClient( context);
         AV13tTargetUrl = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV14tSetFlag ;
      private String AV10tCookieContent ;
      private String AV18tTargetAPI ;
      private String AV13tTargetUrl ;
      private IGxSession AV8websession ;
      private SdtJWTDecode AV12JWTDecode ;
      private GxHttpClient AV9httpclient ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV11WWPContext ;
      private SdtXT_Config AV15BCXT_Config ;
   }

}
