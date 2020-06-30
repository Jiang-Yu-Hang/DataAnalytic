/*
               File: ZBR_InsertInfoDataScoptes
        Description: 默认新增病种
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:13.51
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zbr_insertinfodatascoptes : GXProcedure
   {
      public zbr_insertinfodatascoptes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_insertinfodatascoptes( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Information_ID )
      {
         this.AV9iBR_Information_ID = aP0_iBR_Information_ID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_Information_ID )
      {
         zbr_insertinfodatascoptes objzbr_insertinfodatascoptes;
         objzbr_insertinfodatascoptes = new zbr_insertinfodatascoptes();
         objzbr_insertinfodatascoptes.AV9iBR_Information_ID = aP0_iBR_Information_ID;
         objzbr_insertinfodatascoptes.context.SetSubmitInitialConfig(context);
         objzbr_insertinfodatascoptes.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_insertinfodatascoptes);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_insertinfodatascoptes)stateInfo).executePrivate();
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
         AV11tResult = AV10websession.Get("DAS_UserPermission");
         AV12tSDT_MicroUserInfo.FromJSonString(AV11tResult, null);
         AV8BCBR_PatientReEntity = new SdtBR_PatientReEntity(context);
         AV8BCBR_PatientReEntity.gxTpr_Br_information_id = AV9iBR_Information_ID;
         AV8BCBR_PatientReEntity.gxTpr_Datapackage = StringUtil.Trim( ((String)((SdtSDT_MicroUserInfo_Tenants)AV12tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Item(1)));
         AV8BCBR_PatientReEntity.Save();
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
         AV11tResult = "";
         AV10websession = context.GetSession();
         AV12tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV8BCBR_PatientReEntity = new SdtBR_PatientReEntity(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV9iBR_Information_ID ;
      private String AV11tResult ;
      private IGxSession AV10websession ;
      private SdtBR_PatientReEntity AV8BCBR_PatientReEntity ;
      private SdtSDT_MicroUserInfo AV12tSDT_MicroUserInfo ;
   }

}
