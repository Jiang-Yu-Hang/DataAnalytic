/*
               File: ZBR_InsertInfoProvider
        Description: 新增患者时自动保存该患者的分院
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:13.26
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
   public class zbr_insertinfoprovider : GXProcedure
   {
      public zbr_insertinfoprovider( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_insertinfoprovider( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Information_ID )
      {
         this.AV10iBR_Information_ID = aP0_iBR_Information_ID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_Information_ID )
      {
         zbr_insertinfoprovider objzbr_insertinfoprovider;
         objzbr_insertinfoprovider = new zbr_insertinfoprovider();
         objzbr_insertinfoprovider.AV10iBR_Information_ID = aP0_iBR_Information_ID;
         objzbr_insertinfoprovider.context.SetSubmitInitialConfig(context);
         objzbr_insertinfoprovider.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_insertinfoprovider);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_insertinfoprovider)stateInfo).executePrivate();
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
         AV11BR_PatientReTenant = new SdtBR_PatientReTenant(context);
         AV11BR_PatientReTenant.gxTpr_Br_information_id = AV10iBR_Information_ID;
         GXt_char1 = "";
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV11BR_PatientReTenant.gxTpr_Bas_tenanttenantcode = GXt_char1;
         AV11BR_PatientReTenant.Save();
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
         AV11BR_PatientReTenant = new SdtBR_PatientReTenant(context);
         GXt_char1 = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV10iBR_Information_ID ;
      private String GXt_char1 ;
      private SdtBR_PatientReTenant AV11BR_PatientReTenant ;
   }

}
