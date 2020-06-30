/*
               File: ZBR_DeleteMedication_scheme
        Description: 删除药物治疗方案以及下面的药物详情
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:11.58
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
   public class zbr_deletemedication_scheme : GXProcedure
   {
      public zbr_deletemedication_scheme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deletemedication_scheme( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Medication_SchemeID )
      {
         this.AV8iBR_Medication_SchemeID = aP0_iBR_Medication_SchemeID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_Medication_SchemeID )
      {
         zbr_deletemedication_scheme objzbr_deletemedication_scheme;
         objzbr_deletemedication_scheme = new zbr_deletemedication_scheme();
         objzbr_deletemedication_scheme.AV8iBR_Medication_SchemeID = aP0_iBR_Medication_SchemeID;
         objzbr_deletemedication_scheme.context.SetSubmitInitialConfig(context);
         objzbr_deletemedication_scheme.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deletemedication_scheme);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deletemedication_scheme)stateInfo).executePrivate();
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
         /* Using cursor P002S2 */
         pr_default.execute(0, new Object[] {AV8iBR_Medication_SchemeID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002S3 */
         pr_default.execute(1, new Object[] {AV8iBR_Medication_SchemeID});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
         /* End optimized DELETE. */
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deletemedication_scheme",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deletemedication_scheme__default(),
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

      private long AV8iBR_Medication_SchemeID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class zbr_deletemedication_scheme__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002S2 ;
          prmP002S2 = new Object[] {
          new Object[] {"@AV8iBR_Medication_SchemeID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002S3 ;
          prmP002S3 = new Object[] {
          new Object[] {"@AV8iBR_Medication_SchemeID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002S2", "DELETE FROM [BR_Medication_Detail]  WHERE [BR_Medication_SchemeID] = @AV8iBR_Medication_SchemeID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002S2)
             ,new CursorDef("P002S3", "DELETE FROM [BR_Medication_Scheme]  WHERE [BR_Medication_SchemeID] = @AV8iBR_Medication_SchemeID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002S3)
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
