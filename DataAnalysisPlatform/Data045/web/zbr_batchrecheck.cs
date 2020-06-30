/*
               File: ZBR_BatchRecheck
        Description: 批量提交复审的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:43.72
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
   public class zbr_batchrecheck : GXProcedure
   {
      public zbr_batchrecheck( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_batchrecheck( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GxSimpleCollection<long> aP0_iAllBR_EncounterID )
      {
         this.AV15iAllBR_EncounterID = aP0_iAllBR_EncounterID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( GxSimpleCollection<long> aP0_iAllBR_EncounterID )
      {
         zbr_batchrecheck objzbr_batchrecheck;
         objzbr_batchrecheck = new zbr_batchrecheck();
         objzbr_batchrecheck.AV15iAllBR_EncounterID = aP0_iAllBR_EncounterID;
         objzbr_batchrecheck.context.SetSubmitInitialConfig(context);
         objzbr_batchrecheck.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_batchrecheck);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_batchrecheck)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV11WWPContext) ;
         AV12tFlag = true;
         AV13tAllEncounterIds = "";
         /* Using cursor P00242 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A172BR_Encounter_Status = P00242_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = P00242_n172BR_Encounter_Status[0];
            A19BR_EncounterID = P00242_A19BR_EncounterID[0];
            AV10BCBR_Encounter.Load(A19BR_EncounterID);
            AV10BCBR_Encounter.gxTpr_Br_encounter_status = 6;
            AV10BCBR_Encounter.gxTpr_Br_encounter_recheckuser = AV11WWPContext.gxTpr_Userdisplayname;
            AV10BCBR_Encounter.gxTpr_Br_encounter_recheckdate = DateTimeUtil.ServerNow( context, pr_default);
            AV10BCBR_Encounter.Save();
            if ( AV10BCBR_Encounter.Fail() )
            {
               AV12tFlag = false;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            else
            {
               AV13tAllEncounterIds = AV13tAllEncounterIds + StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)) + ",";
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12tFlag )
         {
            AV13tAllEncounterIds = StringUtil.Substring( AV13tAllEncounterIds, 1, StringUtil.Len( AV13tAllEncounterIds)-1);
            new zutil_recordlog(context ).execute(  AV13tAllEncounterIds,  "就诊信息",  "Batchapprove",  1) ;
            context.CommitDataStores("zbr_batchrecheck",pr_default);
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
         AV11WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV13tAllEncounterIds = "";
         scmdbuf = "";
         P00242_A172BR_Encounter_Status = new short[1] ;
         P00242_n172BR_Encounter_Status = new bool[] {false} ;
         P00242_A19BR_EncounterID = new long[1] ;
         AV10BCBR_Encounter = new SdtBR_Encounter(context);
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.zbr_batchrecheck__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_batchrecheck__default(),
            new Object[][] {
                new Object[] {
               P00242_A172BR_Encounter_Status, P00242_n172BR_Encounter_Status, P00242_A19BR_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A172BR_Encounter_Status ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool AV12tFlag ;
      private bool n172BR_Encounter_Status ;
      private String AV13tAllEncounterIds ;
      private GxSimpleCollection<long> AV15iAllBR_EncounterID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00242_A172BR_Encounter_Status ;
      private bool[] P00242_n172BR_Encounter_Status ;
      private long[] P00242_A19BR_EncounterID ;
      private IDataStoreProvider pr_datastore1 ;
      private SdtBR_Encounter AV10BCBR_Encounter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV11WWPContext ;
   }

   public class zbr_batchrecheck__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
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
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class zbr_batchrecheck__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmP00242 ;
        prmP00242 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("P00242", "SELECT [BR_Encounter_Status], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_Encounter_Status] = 4 ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00242,100,0,true,false )
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
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
