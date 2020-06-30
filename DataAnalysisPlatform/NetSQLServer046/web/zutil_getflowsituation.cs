/*
               File: ZUtil_GetFlowSituation
        Description: 获取审批情况数量的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.76
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
   public class zutil_getflowsituation : GXProcedure
   {
      public zutil_getflowsituation( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_getflowsituation( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_oCount1 ,
                           out long aP1_oCount2 ,
                           out long aP2_oCount3 ,
                           out long aP3_oCount4 ,
                           out long aP4_oCount5 ,
                           out long aP5_oCount6 )
      {
         this.AV8oCount1 = 0 ;
         this.AV9oCount2 = 0 ;
         this.AV10oCount3 = 0 ;
         this.AV11oCount4 = 0 ;
         this.AV12oCount5 = 0 ;
         this.AV13oCount6 = 0 ;
         initialize();
         executePrivate();
         aP0_oCount1=this.AV8oCount1;
         aP1_oCount2=this.AV9oCount2;
         aP2_oCount3=this.AV10oCount3;
         aP3_oCount4=this.AV11oCount4;
         aP4_oCount5=this.AV12oCount5;
         aP5_oCount6=this.AV13oCount6;
      }

      public long executeUdp( out long aP0_oCount1 ,
                              out long aP1_oCount2 ,
                              out long aP2_oCount3 ,
                              out long aP3_oCount4 ,
                              out long aP4_oCount5 )
      {
         this.AV8oCount1 = 0 ;
         this.AV9oCount2 = 0 ;
         this.AV10oCount3 = 0 ;
         this.AV11oCount4 = 0 ;
         this.AV12oCount5 = 0 ;
         this.AV13oCount6 = 0 ;
         initialize();
         executePrivate();
         aP0_oCount1=this.AV8oCount1;
         aP1_oCount2=this.AV9oCount2;
         aP2_oCount3=this.AV10oCount3;
         aP3_oCount4=this.AV11oCount4;
         aP4_oCount5=this.AV12oCount5;
         aP5_oCount6=this.AV13oCount6;
         return AV13oCount6 ;
      }

      public void executeSubmit( out long aP0_oCount1 ,
                                 out long aP1_oCount2 ,
                                 out long aP2_oCount3 ,
                                 out long aP3_oCount4 ,
                                 out long aP4_oCount5 ,
                                 out long aP5_oCount6 )
      {
         zutil_getflowsituation objzutil_getflowsituation;
         objzutil_getflowsituation = new zutil_getflowsituation();
         objzutil_getflowsituation.AV8oCount1 = 0 ;
         objzutil_getflowsituation.AV9oCount2 = 0 ;
         objzutil_getflowsituation.AV10oCount3 = 0 ;
         objzutil_getflowsituation.AV11oCount4 = 0 ;
         objzutil_getflowsituation.AV12oCount5 = 0 ;
         objzutil_getflowsituation.AV13oCount6 = 0 ;
         objzutil_getflowsituation.context.SetSubmitInitialConfig(context);
         objzutil_getflowsituation.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_getflowsituation);
         aP0_oCount1=this.AV8oCount1;
         aP1_oCount2=this.AV9oCount2;
         aP2_oCount3=this.AV10oCount3;
         aP3_oCount4=this.AV11oCount4;
         aP4_oCount5=this.AV12oCount5;
         aP5_oCount6=this.AV13oCount6;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_getflowsituation)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV14WWPContext) ;
         AV17tCurrentTenantCode = context.GetCookie( "DAS_UserTInfo");
         AV8oCount1 = 0;
         AV9oCount2 = 0;
         AV10oCount3 = 0;
         AV11oCount4 = 0;
         AV12oCount5 = 0;
         AV13oCount6 = 0;
         /* Using cursor P00292 */
         pr_default.execute(0, new Object[] {AV17tCurrentTenantCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A360BAS_TenantTenantCode = P00292_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = P00292_n360BAS_TenantTenantCode[0];
            A172BR_Encounter_Status = P00292_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = P00292_n172BR_Encounter_Status[0];
            A19BR_EncounterID = P00292_A19BR_EncounterID[0];
            if ( A172BR_Encounter_Status == 1 )
            {
               AV8oCount1 = (long)(AV8oCount1+1);
            }
            else if ( A172BR_Encounter_Status == 2 )
            {
               AV9oCount2 = (long)(AV9oCount2+1);
            }
            else if ( A172BR_Encounter_Status == 3 )
            {
               AV10oCount3 = (long)(AV10oCount3+1);
            }
            else if ( A172BR_Encounter_Status == 4 )
            {
               AV11oCount4 = (long)(AV11oCount4+1);
            }
            else if ( A172BR_Encounter_Status == 5 )
            {
               AV12oCount5 = (long)(AV12oCount5+1);
            }
            else if ( A172BR_Encounter_Status == 6 )
            {
               AV13oCount6 = (long)(AV13oCount6+1);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         AV14WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17tCurrentTenantCode = "";
         scmdbuf = "";
         P00292_A360BAS_TenantTenantCode = new String[] {""} ;
         P00292_n360BAS_TenantTenantCode = new bool[] {false} ;
         P00292_A172BR_Encounter_Status = new short[1] ;
         P00292_n172BR_Encounter_Status = new bool[] {false} ;
         P00292_A19BR_EncounterID = new long[1] ;
         A360BAS_TenantTenantCode = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_getflowsituation__default(),
            new Object[][] {
                new Object[] {
               P00292_A360BAS_TenantTenantCode, P00292_n360BAS_TenantTenantCode, P00292_A172BR_Encounter_Status, P00292_n172BR_Encounter_Status, P00292_A19BR_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A172BR_Encounter_Status ;
      private long AV13oCount6 ;
      private long AV8oCount1 ;
      private long AV9oCount2 ;
      private long AV10oCount3 ;
      private long AV11oCount4 ;
      private long AV12oCount5 ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool n360BAS_TenantTenantCode ;
      private bool n172BR_Encounter_Status ;
      private String AV17tCurrentTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00292_A360BAS_TenantTenantCode ;
      private bool[] P00292_n360BAS_TenantTenantCode ;
      private short[] P00292_A172BR_Encounter_Status ;
      private bool[] P00292_n172BR_Encounter_Status ;
      private long[] P00292_A19BR_EncounterID ;
      private long aP0_oCount1 ;
      private long aP1_oCount2 ;
      private long aP2_oCount3 ;
      private long aP3_oCount4 ;
      private long aP4_oCount5 ;
      private long aP5_oCount6 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV14WWPContext ;
   }

   public class zutil_getflowsituation__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00292 ;
          prmP00292 = new Object[] {
          new Object[] {"@AV17tCurrentTenantCode",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00292", "SELECT [BAS_TenantTenantCode], [BR_Encounter_Status], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE RTRIM(LTRIM([BAS_TenantTenantCode])) = RTRIM(LTRIM(@AV17tCurrentTenantCode)) ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00292,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
