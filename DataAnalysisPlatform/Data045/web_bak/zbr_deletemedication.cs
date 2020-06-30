/*
               File: ZBR_DeleteMedication
        Description: 删除药物治疗的所有相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:32.33
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
using System.Data;
using GeneXus.Data;
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
   public class zbr_deletemedication : GXProcedure
   {
      public zbr_deletemedication( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deletemedication( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_EncounterID ,
                           long aP1_iBR_MedicationID )
      {
         this.AV9iBR_EncounterID = aP0_iBR_EncounterID;
         this.AV8iBR_MedicationID = aP1_iBR_MedicationID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_EncounterID ,
                                 long aP1_iBR_MedicationID )
      {
         zbr_deletemedication objzbr_deletemedication;
         objzbr_deletemedication = new zbr_deletemedication();
         objzbr_deletemedication.AV9iBR_EncounterID = aP0_iBR_EncounterID;
         objzbr_deletemedication.AV8iBR_MedicationID = aP1_iBR_MedicationID;
         objzbr_deletemedication.context.SetSubmitInitialConfig(context);
         objzbr_deletemedication.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deletemedication);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deletemedication)stateInfo).executePrivate();
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
         /* Optimized DELETE. */
         /* Using cursor P002T2 */
         pr_default.execute(0, new Object[] {AV8iBR_MedicationID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002T3 */
         pr_default.execute(1, new Object[] {AV8iBR_MedicationID});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
         /* End optimized DELETE. */
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV9iBR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV8iBR_MedicationID), 18, 0)),  "药物治疗",  "Delete",  1) ;
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deletemedication",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deletemedication__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV9iBR_EncounterID ;
      private long AV8iBR_MedicationID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class zbr_deletemedication__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002T2 ;
          prmP002T2 = new Object[] {
          new Object[] {"@AV8iBR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002T3 ;
          prmP002T3 = new Object[] {
          new Object[] {"@AV8iBR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002T2", "DELETE FROM [BR_Scheme_Medication]  WHERE [BR_MedicationID] = @AV8iBR_MedicationID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002T2)
             ,new CursorDef("P002T3", "DELETE FROM [BR_Medication]  WHERE [BR_MedicationID] = @AV8iBR_MedicationID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002T3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
