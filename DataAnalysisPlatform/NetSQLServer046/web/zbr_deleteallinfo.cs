/*
               File: ZBR_DeleteAllInfo
        Description: 删除患者的所有相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.90
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
   public class zbr_deleteallinfo : GXProcedure
   {
      public zbr_deleteallinfo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deleteallinfo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Information_ID )
      {
         this.AV8iBR_Information_ID = aP0_iBR_Information_ID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_Information_ID )
      {
         zbr_deleteallinfo objzbr_deleteallinfo;
         objzbr_deleteallinfo = new zbr_deleteallinfo();
         objzbr_deleteallinfo.AV8iBR_Information_ID = aP0_iBR_Information_ID;
         objzbr_deleteallinfo.context.SetSubmitInitialConfig(context);
         objzbr_deleteallinfo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deleteallinfo);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deleteallinfo)stateInfo).executePrivate();
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
         /* Using cursor P002A2 */
         pr_default.execute(0, new Object[] {AV8iBR_Information_ID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A85BR_Information_ID = P002A2_A85BR_Information_ID[0];
            n85BR_Information_ID = P002A2_n85BR_Information_ID[0];
            A19BR_EncounterID = P002A2_A19BR_EncounterID[0];
            new zbr_deleteencounter(context ).execute(  A19BR_EncounterID) ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Optimized DELETE. */
         /* Using cursor P002A3 */
         pr_default.execute(1, new Object[] {AV8iBR_Information_ID});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("JC_Provider_Br_Information") ;
         /* End optimized DELETE. */
         /* Using cursor P002A4 */
         pr_default.execute(2, new Object[] {AV8iBR_Information_ID});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A85BR_Information_ID = P002A4_A85BR_Information_ID[0];
            n85BR_Information_ID = P002A4_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002A4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002A4_n36BR_Information_PatientNo[0];
            AV9tBR_Information_PatientNo = A36BR_Information_PatientNo;
            /* Using cursor P002A5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Information") ;
            new zutil_recordlog(context ).execute(  AV9tBR_Information_PatientNo,  "患者信息",  "Delete",  1) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deleteallinfo",pr_default);
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
         P002A2_A85BR_Information_ID = new long[1] ;
         P002A2_n85BR_Information_ID = new bool[] {false} ;
         P002A2_A19BR_EncounterID = new long[1] ;
         P002A4_A85BR_Information_ID = new long[1] ;
         P002A4_n85BR_Information_ID = new bool[] {false} ;
         P002A4_A36BR_Information_PatientNo = new String[] {""} ;
         P002A4_n36BR_Information_PatientNo = new bool[] {false} ;
         A36BR_Information_PatientNo = "";
         AV9tBR_Information_PatientNo = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deleteallinfo__default(),
            new Object[][] {
                new Object[] {
               P002A2_A85BR_Information_ID, P002A2_n85BR_Information_ID, P002A2_A19BR_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               P002A4_A85BR_Information_ID, P002A4_A36BR_Information_PatientNo, P002A4_n36BR_Information_PatientNo
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8iBR_Information_ID ;
      private long A85BR_Information_ID ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private String AV9tBR_Information_PatientNo ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002A2_A85BR_Information_ID ;
      private bool[] P002A2_n85BR_Information_ID ;
      private long[] P002A2_A19BR_EncounterID ;
      private long[] P002A4_A85BR_Information_ID ;
      private bool[] P002A4_n85BR_Information_ID ;
      private String[] P002A4_A36BR_Information_PatientNo ;
      private bool[] P002A4_n36BR_Information_PatientNo ;
   }

   public class zbr_deleteallinfo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002A2 ;
          prmP002A2 = new Object[] {
          new Object[] {"@AV8iBR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002A3 ;
          prmP002A3 = new Object[] {
          new Object[] {"@AV8iBR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002A4 ;
          prmP002A4 = new Object[] {
          new Object[] {"@AV8iBR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002A5 ;
          prmP002A5 = new Object[] {
          new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002A2", "SELECT [BR_Information_ID], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8iBR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002A2,100,0,true,false )
             ,new CursorDef("P002A3", "DELETE FROM [JC_Provider_Br_Information]  WHERE [BR_Information_ID] = @AV8iBR_Information_ID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002A3)
             ,new CursorDef("P002A4", "SELECT TOP 1 [BR_Information_ID], [BR_Information_PatientNo] FROM [BR_Information] WITH (UPDLOCK) WHERE [BR_Information_ID] = @AV8iBR_Information_ID ORDER BY [BR_Information_ID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002A4,1,0,true,true )
             ,new CursorDef("P002A5", "DELETE FROM [BR_Information]  WHERE [BR_Information_ID] = @BR_Information_ID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002A5)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
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
       }
    }

 }

}
