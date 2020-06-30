/*
               File: ZBR_DeleteProcedure
        Description: 删除诊疗处理的所有的相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:3.52
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
   public class zbr_deleteprocedure : GXProcedure
   {
      public zbr_deleteprocedure( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deleteprocedure( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_ProcedureID )
      {
         this.AV10iBR_ProcedureID = aP0_iBR_ProcedureID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_ProcedureID )
      {
         zbr_deleteprocedure objzbr_deleteprocedure;
         objzbr_deleteprocedure = new zbr_deleteprocedure();
         objzbr_deleteprocedure.AV10iBR_ProcedureID = aP0_iBR_ProcedureID;
         objzbr_deleteprocedure.context.SetSubmitInitialConfig(context);
         objzbr_deleteprocedure.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deleteprocedure);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deleteprocedure)stateInfo).executePrivate();
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
         /* Using cursor P002Z2 */
         pr_default.execute(0, new Object[] {AV10iBR_ProcedureID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002Z3 */
         pr_default.execute(1, new Object[] {AV10iBR_ProcedureID});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002Z4 */
         pr_default.execute(2, new Object[] {AV10iBR_ProcedureID});
         pr_default.close(2);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
         /* End optimized DELETE. */
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV10iBR_ProcedureID), 18, 0)),  "诊疗处理",  "Delete",  1) ;
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deleteprocedure",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deleteprocedure__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV10iBR_ProcedureID ;
      private long A19BR_EncounterID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class zbr_deleteprocedure__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002Z2 ;
          prmP002Z2 = new Object[] {
          new Object[] {"@AV10iBR_ProcedureID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002Z3 ;
          prmP002Z3 = new Object[] {
          new Object[] {"@AV10iBR_ProcedureID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002Z4 ;
          prmP002Z4 = new Object[] {
          new Object[] {"@AV10iBR_ProcedureID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002Z2", "DELETE FROM [BR_Procedure_Radio]  WHERE [BR_ProcedureID] = @AV10iBR_ProcedureID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002Z2)
             ,new CursorDef("P002Z3", "DELETE FROM [BR_Procedure_Surgery]  WHERE [BR_ProcedureID] = @AV10iBR_ProcedureID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002Z3)
             ,new CursorDef("P002Z4", "DELETE FROM [BR_Procedure]  WHERE [BR_ProcedureID] = @AV10iBR_ProcedureID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002Z4)
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
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
