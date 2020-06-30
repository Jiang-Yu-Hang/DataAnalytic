/*
               File: WB_CheckJWTIfCorrect
        Description: 检查jwt数据是否正确的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:19.12
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
   public class wb_checkjwtifcorrect : GXProcedure
   {
      public wb_checkjwtifcorrect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wb_checkjwtifcorrect( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_iCheckToken ,
                           out bool aP1_tCorrectFlag )
      {
         this.AV9iCheckToken = aP0_iCheckToken;
         this.AV15tCorrectFlag = false ;
         initialize();
         executePrivate();
         aP1_tCorrectFlag=this.AV15tCorrectFlag;
      }

      public bool executeUdp( String aP0_iCheckToken )
      {
         this.AV9iCheckToken = aP0_iCheckToken;
         this.AV15tCorrectFlag = false ;
         initialize();
         executePrivate();
         aP1_tCorrectFlag=this.AV15tCorrectFlag;
         return AV15tCorrectFlag ;
      }

      public void executeSubmit( String aP0_iCheckToken ,
                                 out bool aP1_tCorrectFlag )
      {
         wb_checkjwtifcorrect objwb_checkjwtifcorrect;
         objwb_checkjwtifcorrect = new wb_checkjwtifcorrect();
         objwb_checkjwtifcorrect.AV9iCheckToken = aP0_iCheckToken;
         objwb_checkjwtifcorrect.AV15tCorrectFlag = false ;
         objwb_checkjwtifcorrect.context.SetSubmitInitialConfig(context);
         objwb_checkjwtifcorrect.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwb_checkjwtifcorrect);
         aP1_tCorrectFlag=this.AV15tCorrectFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wb_checkjwtifcorrect)stateInfo).executePrivate();
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
         AV8tClientAddress = context.GetRemoteAddress( );
         AV11tContent = AV19JWTDecode.decode(AV9iCheckToken);
         AV10tSDT_JWT.FromJSonString(AV11tContent, null);
         AV15tCorrectFlag = true;
         AV11tContent = StringUtil.Trim( AV10tSDT_JWT.gxTpr_Ip);
         if ( AV15tCorrectFlag )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV8tClientAddress), StringUtil.Trim( AV10tSDT_JWT.gxTpr_Ip)) != 0 )
            {
               AV15tCorrectFlag = false;
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
         AV8tClientAddress = "";
         AV11tContent = "";
         AV19JWTDecode = new SdtJWTDecode(context);
         AV10tSDT_JWT = new SdtSDT_JWT(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV15tCorrectFlag ;
      private String AV9iCheckToken ;
      private String AV8tClientAddress ;
      private String AV11tContent ;
      private SdtJWTDecode AV19JWTDecode ;
      private bool aP1_tCorrectFlag ;
      private SdtSDT_JWT AV10tSDT_JWT ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.wb_checkjwtifcorrect_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class wb_checkjwtifcorrect_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( String iCheckToken ,
                           out bool tCorrectFlag )
      {
         tCorrectFlag = false ;
         try
         {
            if ( ! ProcessHeaders("wb_checkjwtifcorrect") )
            {
               return  ;
            }
            wb_checkjwtifcorrect worker = new wb_checkjwtifcorrect(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(iCheckToken,out tCorrectFlag );
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
