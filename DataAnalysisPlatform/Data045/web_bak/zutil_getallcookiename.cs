/*
               File: ZUtil_GetAllCookieName
        Description: 获得所有的cookie名
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:39.86
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
   public class zutil_getallcookiename : GXProcedure
   {
      public zutil_getallcookiename( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_getallcookiename( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_oMessage )
      {
         this.AV14oMessage = "" ;
         initialize();
         executePrivate();
         aP0_oMessage=this.AV14oMessage;
      }

      public String executeUdp( )
      {
         this.AV14oMessage = "" ;
         initialize();
         executePrivate();
         aP0_oMessage=this.AV14oMessage;
         return AV14oMessage ;
      }

      public void executeSubmit( out String aP0_oMessage )
      {
         zutil_getallcookiename objzutil_getallcookiename;
         objzutil_getallcookiename = new zutil_getallcookiename();
         objzutil_getallcookiename.AV14oMessage = "" ;
         objzutil_getallcookiename.context.SetSubmitInitialConfig(context);
         objzutil_getallcookiename.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_getallcookiename);
         aP0_oMessage=this.AV14oMessage;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_getallcookiename)stateInfo).executePrivate();
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
         AV12tNewCookieCollection.Clear();
         AV18I = 1;
         while ( AV18I <= AV11tCookieCollection.Count )
         {
            AV15tSingleCookieName = StringUtil.Substring( AV11tCookieCollection.GetString(AV18I), 1, StringUtil.StringSearch( AV11tCookieCollection.GetString(AV18I), "=", 1)-1);
            AV12tNewCookieCollection.Add(AV15tSingleCookieName, 0);
            AV18I = (short)(AV18I+1);
         }
         AV14oMessage = AV12tNewCookieCollection.ToJSonString(false);
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
         AV12tNewCookieCollection = new GxSimpleCollection<String>();
         AV15tSingleCookieName = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV18I ;
      private String AV14oMessage ;
      private String AV10tAllCookieMess ;
      private String AV15tSingleCookieName ;
      private GxHttpRequest AV8httprequest ;
      private String aP0_oMessage ;
      private GxSimpleCollection<String> AV11tCookieCollection ;
      private GxSimpleCollection<String> AV12tNewCookieCollection ;
   }

}
