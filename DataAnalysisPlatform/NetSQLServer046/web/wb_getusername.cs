/*
               File: WB_GetUserName
        Description: 获取用户的名称
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:8.12
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
   public class wb_getusername : GXProcedure
   {
      public wb_getusername( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wb_getusername( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_icontent ,
                           String aP1_ijwtcontent ,
                           String aP2_tenant_cookie ,
                           out String aP3_oUserName ,
                           out int aP4_oUserType ,
                           out short aP5_oTenantsNum ,
                           out String aP6_oRDashAdd )
      {
         this.AV15icontent = aP0_icontent;
         this.AV19ijwtcontent = aP1_ijwtcontent;
         this.AV25tenant_cookie = aP2_tenant_cookie;
         this.AV8oUserName = "" ;
         this.AV17oUserType = 0 ;
         this.AV18oTenantsNum = 0 ;
         this.AV26oRDashAdd = "" ;
         initialize();
         executePrivate();
         aP3_oUserName=this.AV8oUserName;
         aP4_oUserType=this.AV17oUserType;
         aP5_oTenantsNum=this.AV18oTenantsNum;
         aP6_oRDashAdd=this.AV26oRDashAdd;
      }

      public String executeUdp( String aP0_icontent ,
                                String aP1_ijwtcontent ,
                                String aP2_tenant_cookie ,
                                out String aP3_oUserName ,
                                out int aP4_oUserType ,
                                out short aP5_oTenantsNum )
      {
         this.AV15icontent = aP0_icontent;
         this.AV19ijwtcontent = aP1_ijwtcontent;
         this.AV25tenant_cookie = aP2_tenant_cookie;
         this.AV8oUserName = "" ;
         this.AV17oUserType = 0 ;
         this.AV18oTenantsNum = 0 ;
         this.AV26oRDashAdd = "" ;
         initialize();
         executePrivate();
         aP3_oUserName=this.AV8oUserName;
         aP4_oUserType=this.AV17oUserType;
         aP5_oTenantsNum=this.AV18oTenantsNum;
         aP6_oRDashAdd=this.AV26oRDashAdd;
         return AV26oRDashAdd ;
      }

      public void executeSubmit( String aP0_icontent ,
                                 String aP1_ijwtcontent ,
                                 String aP2_tenant_cookie ,
                                 out String aP3_oUserName ,
                                 out int aP4_oUserType ,
                                 out short aP5_oTenantsNum ,
                                 out String aP6_oRDashAdd )
      {
         wb_getusername objwb_getusername;
         objwb_getusername = new wb_getusername();
         objwb_getusername.AV15icontent = aP0_icontent;
         objwb_getusername.AV19ijwtcontent = aP1_ijwtcontent;
         objwb_getusername.AV25tenant_cookie = aP2_tenant_cookie;
         objwb_getusername.AV8oUserName = "" ;
         objwb_getusername.AV17oUserType = 0 ;
         objwb_getusername.AV18oTenantsNum = 0 ;
         objwb_getusername.AV26oRDashAdd = "" ;
         objwb_getusername.context.SetSubmitInitialConfig(context);
         objwb_getusername.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwb_getusername);
         aP3_oUserName=this.AV8oUserName;
         aP4_oUserType=this.AV17oUserType;
         aP5_oTenantsNum=this.AV18oTenantsNum;
         aP6_oRDashAdd=this.AV26oRDashAdd;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wb_getusername)stateInfo).executePrivate();
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
         if ( ! context.isAjaxRequest( ) )
         {
            AV16httpresponse.AppendHeader("Access-Control-Allow-Origin", "*");
         }
         if ( ! context.isAjaxRequest( ) )
         {
            AV16httpresponse.AppendHeader("Access-Control-Allow-Methods", "*");
         }
         if ( ! context.isAjaxRequest( ) )
         {
            AV16httpresponse.AppendHeader("Access-Control-Allow-Headers", "Content-Type");
         }
         if ( StringUtil.StrCmp(StringUtil.Trim( AV20JWTDecode.decode(AV19ijwtcontent)), "DecodeFail") != 0 )
         {
            AV14tDecryptContent = Decrypt64( StringUtil.Trim( AV15icontent), "A803C9281F6C819705ADF9E4208BE89C");
            AV10WWPContext.FromXml(AV14tDecryptContent, null, "WWPContext", "DataAnalysisPlatform");
            AV8oUserName = StringUtil.Trim( AV10WWPContext.gxTpr_Userdisplayname);
            AV17oUserType = AV10WWPContext.gxTpr_Usertype;
            AV18oTenantsNum = AV10WWPContext.gxTpr_Currenttnum;
            AV24tName = AV25tenant_cookie;
         }
         AV27XT_Config.Load(9);
         AV26oRDashAdd = AV27XT_Config.gxTpr_Xt_configvalue1;
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
         AV16httpresponse = new GxHttpResponse( context);
         AV20JWTDecode = new SdtJWTDecode(context);
         AV14tDecryptContent = "";
         AV10WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV24tName = "";
         AV27XT_Config = new SdtXT_Config(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV18oTenantsNum ;
      private int AV17oUserType ;
      private String AV14tDecryptContent ;
      private String AV15icontent ;
      private String AV19ijwtcontent ;
      private String AV25tenant_cookie ;
      private String AV26oRDashAdd ;
      private String AV8oUserName ;
      private String AV24tName ;
      private SdtJWTDecode AV20JWTDecode ;
      private String aP3_oUserName ;
      private int aP4_oUserType ;
      private short aP5_oTenantsNum ;
      private String aP6_oRDashAdd ;
      private GxHttpResponse AV16httpresponse ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV10WWPContext ;
      private SdtXT_Config AV27XT_Config ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.wb_getusername_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class wb_getusername_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String icontent ,
                           String ijwtcontent ,
                           String tenant_cookie ,
                           out String oUserName ,
                           out String oUserType ,
                           out short oTenantsNum ,
                           out String oRDashAdd )
      {
         oUserName = "" ;
         oUserType = "" ;
         oTenantsNum = 0 ;
         oRDashAdd = "" ;
         try
         {
            if ( ! ProcessHeaders("wb_getusername") )
            {
               return  ;
            }
            wb_getusername worker = new wb_getusername(context) ;
            worker.IsMain = RunAsMain ;
            int gxroUserType = 0 ;
            gxroUserType = (int)(NumberUtil.Val( (String)(oUserType), "."));
            worker.execute(icontent,ijwtcontent,tenant_cookie,out oUserName,out gxroUserType,out oTenantsNum,out oRDashAdd );
            worker.cleanup( );
            oUserType = StringUtil.LTrim( StringUtil.Str( (decimal)(gxroUserType), 9, 0)) ;
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
