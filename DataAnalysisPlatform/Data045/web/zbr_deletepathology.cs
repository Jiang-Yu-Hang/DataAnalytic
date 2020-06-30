/*
               File: ZBR_DeletePathology
        Description: 删除病理学的所有相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:3.35
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
   public class zbr_deletepathology : GXProcedure
   {
      public zbr_deletepathology( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deletepathology( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_PathologyID )
      {
         this.AV8iBR_PathologyID = aP0_iBR_PathologyID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_PathologyID )
      {
         zbr_deletepathology objzbr_deletepathology;
         objzbr_deletepathology = new zbr_deletepathology();
         objzbr_deletepathology.AV8iBR_PathologyID = aP0_iBR_PathologyID;
         objzbr_deletepathology.context.SetSubmitInitialConfig(context);
         objzbr_deletepathology.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deletepathology);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deletepathology)stateInfo).executePrivate();
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
         /* Using cursor P002V2 */
         pr_default.execute(0, new Object[] {AV8iBR_PathologyID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A226BR_PathologyID = P002V2_A226BR_PathologyID[0];
            n226BR_PathologyID = P002V2_n226BR_PathologyID[0];
            /* Optimized DELETE. */
            /* Using cursor P002V3 */
            pr_default.execute(1, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
            /* End optimized DELETE. */
            /* Optimized DELETE. */
            /* Using cursor P002V4 */
            pr_default.execute(2, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
            /* End optimized DELETE. */
            /* Optimized DELETE. */
            /* Using cursor P002V5 */
            pr_default.execute(3, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Specimen") ;
            /* End optimized DELETE. */
            AV9tBR_PathologyID = A226BR_PathologyID;
            /* Using cursor P002V6 */
            pr_default.execute(4, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(4);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV9tBR_PathologyID), 18, 0)),  "病理学",  "Delete",  1) ;
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deletepathology",pr_default);
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
         scmdbuf = "";
         P002V2_A226BR_PathologyID = new long[1] ;
         P002V2_n226BR_PathologyID = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deletepathology__default(),
            new Object[][] {
                new Object[] {
               P002V2_A226BR_PathologyID
               }
               , new Object[] {
               }
               , new Object[] {
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

      private long AV8iBR_PathologyID ;
      private long A226BR_PathologyID ;
      private long AV9tBR_PathologyID ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool n226BR_PathologyID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002V2_A226BR_PathologyID ;
      private bool[] P002V2_n226BR_PathologyID ;
   }

   public class zbr_deletepathology__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002V2 ;
          prmP002V2 = new Object[] {
          new Object[] {"@AV8iBR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002V3 ;
          prmP002V3 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002V4 ;
          prmP002V4 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002V5 ;
          prmP002V5 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002V6 ;
          prmP002V6 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002V2", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (UPDLOCK) WHERE [BR_PathologyID] = @AV8iBR_PathologyID ORDER BY [BR_PathologyID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002V2,1,0,true,true )
             ,new CursorDef("P002V3", "DELETE FROM [BR_Pathology_Diag]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002V3)
             ,new CursorDef("P002V4", "DELETE FROM [BR_Pathology_Other]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002V4)
             ,new CursorDef("P002V5", "DELETE FROM [BR_Pathology_Specimen]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002V5)
             ,new CursorDef("P002V6", "DELETE FROM [BR_Pathology]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002V6)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
       }
    }

 }

}
