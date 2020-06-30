/*
               File: ZUtil_GetTargetCookieValue
        Description: 获得指定的cookie内容
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:20.5
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
   public class zutil_gettargetcookievalue : GXProcedure
   {
      public zutil_gettargetcookievalue( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_gettargetcookievalue( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_iTargetName ,
                           out String aP1_tCookieValue )
      {
         this.AV9iTargetName = aP0_iTargetName;
         this.AV12tCookieValue = "" ;
         initialize();
         executePrivate();
         aP1_tCookieValue=this.AV12tCookieValue;
      }

      public String executeUdp( String aP0_iTargetName )
      {
         this.AV9iTargetName = aP0_iTargetName;
         this.AV12tCookieValue = "" ;
         initialize();
         executePrivate();
         aP1_tCookieValue=this.AV12tCookieValue;
         return AV12tCookieValue ;
      }

      public void executeSubmit( String aP0_iTargetName ,
                                 out String aP1_tCookieValue )
      {
         zutil_gettargetcookievalue objzutil_gettargetcookievalue;
         objzutil_gettargetcookievalue = new zutil_gettargetcookievalue();
         objzutil_gettargetcookievalue.AV9iTargetName = aP0_iTargetName;
         objzutil_gettargetcookievalue.AV12tCookieValue = "" ;
         objzutil_gettargetcookievalue.context.SetSubmitInitialConfig(context);
         objzutil_gettargetcookievalue.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_gettargetcookievalue);
         aP1_tCookieValue=this.AV12tCookieValue;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_gettargetcookievalue)stateInfo).executePrivate();
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
         AV10tAllCookieMess = AV8httprequest.GetHeader("Cookie");
         AV11tCookieCollection = GxRegex.Split(AV10tAllCookieMess,";");
         AV12tCookieValue = "";
         AV16I = 1;
         while ( AV16I <= AV11tCookieCollection.Count )
         {
            AV13tSingleCookieName = StringUtil.Substring( AV11tCookieCollection.GetString(AV16I), 1, StringUtil.StringSearch( AV11tCookieCollection.GetString(AV16I), "=", 1)-1);
            if ( StringUtil.StrCmp(AV9iTargetName, StringUtil.Trim( AV13tSingleCookieName)) == 0 )
            {
               AV12tCookieValue = StringUtil.Substring( AV11tCookieCollection.GetString(AV16I), StringUtil.StringSearch( AV11tCookieCollection.GetString(AV16I), "=", 1)+1, StringUtil.Len( AV11tCookieCollection.GetString(AV16I))-StringUtil.StringSearch( AV11tCookieCollection.GetString(AV16I), "=", 1));
               if (true) break;
            }
            AV16I = (short)(AV16I+1);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12tCookieValue))) )
         {
            AV12tCookieValue = "CookieFindError";
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
         AV10tAllCookieMess = "";
         AV8httprequest = new GxHttpRequest( context);
         AV11tCookieCollection = new GxSimpleCollection<String>();
         AV13tSingleCookieName = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV16I ;
      private String AV9iTargetName ;
      private String AV12tCookieValue ;
      private String AV10tAllCookieMess ;
      private String AV13tSingleCookieName ;
      private GxHttpRequest AV8httprequest ;
      private String aP1_tCookieValue ;
      private GxSimpleCollection<String> AV11tCookieCollection ;
   }

}
