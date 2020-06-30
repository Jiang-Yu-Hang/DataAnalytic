/*
               File: ZUtil_SetJwt
        Description: 设置jwt的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:19.62
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
   public class zutil_setjwt : GXProcedure
   {
      public zutil_setjwt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_setjwt( IGxContext context )
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
         zutil_setjwt objzutil_setjwt;
         objzutil_setjwt = new zutil_setjwt();
         objzutil_setjwt.context.SetSubmitInitialConfig(context);
         objzutil_setjwt.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_setjwt);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_setjwt)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         AV8tSDT_JWT = new SdtSDT_JWT(context);
         AV8tSDT_JWT.gxTpr_Name = AV9WWPContext.gxTpr_Username;
         AV8tSDT_JWT.gxTpr_Userid = StringUtil.Trim( AV9WWPContext.gxTpr_Userguid);
         AV8tSDT_JWT.gxTpr_Ip = AV9WWPContext.gxTpr_Clientip;
         AV8tSDT_JWT.gxTpr_Nbf = "123421423";
         AV8tSDT_JWT.gxTpr_Exp = "1740576564857";
         AV8tSDT_JWT.gxTpr_Iss = "das";
         AV8tSDT_JWT.gxTpr_Aud = "das";
         AV8tSDT_JWT.gxTpr_Iat = "124124214";
         AV10tJWTTokenContent = AV11JWTEncode.encode(AV8tSDT_JWT.ToJSonString(false));
         AV16jwtcookie.Name = "DAS_LoginUser";
         AV16jwtcookie.CurrentValue = AV10tJWTTokenContent;
         AV16jwtcookie.Path = "/";
         AV16jwtcookie.HttpOnly = false;
         AV17httpresponse.SetCookie(AV16jwtcookie);
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
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8tSDT_JWT = new SdtSDT_JWT(context);
         AV10tJWTTokenContent = "";
         AV11JWTEncode = new SdtJWTEncode(context);
         AV16jwtcookie = new GxHttpCookie();
         AV17httpresponse = new GxHttpResponse( context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV10tJWTTokenContent ;
      private SdtJWTEncode AV11JWTEncode ;
      private GxHttpCookie AV16jwtcookie ;
      private GxHttpResponse AV17httpresponse ;
      private SdtSDT_JWT AV8tSDT_JWT ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
   }

}
