/*
               File: ZUtil_GetRandomSituation
        Description: 获得抽查情况个数的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.35
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
   public class zutil_getrandomsituation : GXProcedure
   {
      public zutil_getrandomsituation( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_getrandomsituation( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_tApproveRandomNum ,
                           out long aP1_tApproveNum ,
                           out long aP2_tRecheckRandomNum ,
                           out long aP3_tRecheckNum )
      {
         this.AV9tApproveRandomNum = 0 ;
         this.AV8tApproveNum = 0 ;
         this.AV12tRecheckRandomNum = 0 ;
         this.AV11tRecheckNum = 0 ;
         initialize();
         executePrivate();
         aP0_tApproveRandomNum=this.AV9tApproveRandomNum;
         aP1_tApproveNum=this.AV8tApproveNum;
         aP2_tRecheckRandomNum=this.AV12tRecheckRandomNum;
         aP3_tRecheckNum=this.AV11tRecheckNum;
      }

      public long executeUdp( out long aP0_tApproveRandomNum ,
                              out long aP1_tApproveNum ,
                              out long aP2_tRecheckRandomNum )
      {
         this.AV9tApproveRandomNum = 0 ;
         this.AV8tApproveNum = 0 ;
         this.AV12tRecheckRandomNum = 0 ;
         this.AV11tRecheckNum = 0 ;
         initialize();
         executePrivate();
         aP0_tApproveRandomNum=this.AV9tApproveRandomNum;
         aP1_tApproveNum=this.AV8tApproveNum;
         aP2_tRecheckRandomNum=this.AV12tRecheckRandomNum;
         aP3_tRecheckNum=this.AV11tRecheckNum;
         return AV11tRecheckNum ;
      }

      public void executeSubmit( out long aP0_tApproveRandomNum ,
                                 out long aP1_tApproveNum ,
                                 out long aP2_tRecheckRandomNum ,
                                 out long aP3_tRecheckNum )
      {
         zutil_getrandomsituation objzutil_getrandomsituation;
         objzutil_getrandomsituation = new zutil_getrandomsituation();
         objzutil_getrandomsituation.AV9tApproveRandomNum = 0 ;
         objzutil_getrandomsituation.AV8tApproveNum = 0 ;
         objzutil_getrandomsituation.AV12tRecheckRandomNum = 0 ;
         objzutil_getrandomsituation.AV11tRecheckNum = 0 ;
         objzutil_getrandomsituation.context.SetSubmitInitialConfig(context);
         objzutil_getrandomsituation.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_getrandomsituation);
         aP0_tApproveRandomNum=this.AV9tApproveRandomNum;
         aP1_tApproveNum=this.AV8tApproveNum;
         aP2_tRecheckRandomNum=this.AV12tRecheckRandomNum;
         aP3_tRecheckNum=this.AV11tRecheckNum;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_getrandomsituation)stateInfo).executePrivate();
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
         AV10tCurrentTenantCode = context.GetCookie( "DAS_UserTInfo");
         AV9tApproveRandomNum = 0;
         AV8tApproveNum = 0;
         AV12tRecheckRandomNum = 0;
         AV11tRecheckNum = 0;
         /* Optimized group. */
         /* Using cursor P003S2 */
         pr_default.execute(0, new Object[] {AV10tCurrentTenantCode});
         cV9tApproveRandomNum = P003S2_AV9tApproveRandomNum[0];
         pr_default.close(0);
         AV9tApproveRandomNum = (long)(AV9tApproveRandomNum+cV9tApproveRandomNum*1);
         /* End optimized group. */
         /* Optimized group. */
         /* Using cursor P003S3 */
         pr_default.execute(1, new Object[] {AV10tCurrentTenantCode});
         cV8tApproveNum = P003S3_AV8tApproveNum[0];
         pr_default.close(1);
         AV8tApproveNum = (long)(AV8tApproveNum+cV8tApproveNum*1);
         /* End optimized group. */
         /* Optimized group. */
         /* Using cursor P003S4 */
         pr_default.execute(2, new Object[] {AV10tCurrentTenantCode});
         cV12tRecheckRandomNum = P003S4_AV12tRecheckRandomNum[0];
         pr_default.close(2);
         AV12tRecheckRandomNum = (long)(AV12tRecheckRandomNum+cV12tRecheckRandomNum*1);
         /* End optimized group. */
         /* Optimized group. */
         /* Using cursor P003S5 */
         pr_default.execute(3, new Object[] {AV10tCurrentTenantCode});
         cV11tRecheckNum = P003S5_AV11tRecheckNum[0];
         pr_default.close(3);
         AV11tRecheckNum = (long)(AV11tRecheckNum+cV11tRecheckNum*1);
         /* End optimized group. */
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
         AV10tCurrentTenantCode = "";
         scmdbuf = "";
         P003S2_AV9tApproveRandomNum = new long[1] ;
         P003S3_AV8tApproveNum = new long[1] ;
         P003S4_AV12tRecheckRandomNum = new long[1] ;
         P003S5_AV11tRecheckNum = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_getrandomsituation__default(),
            new Object[][] {
                new Object[] {
               P003S2_AV9tApproveRandomNum
               }
               , new Object[] {
               P003S3_AV8tApproveNum
               }
               , new Object[] {
               P003S4_AV12tRecheckRandomNum
               }
               , new Object[] {
               P003S5_AV11tRecheckNum
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV11tRecheckNum ;
      private long AV9tApproveRandomNum ;
      private long AV8tApproveNum ;
      private long AV12tRecheckRandomNum ;
      private long cV9tApproveRandomNum ;
      private long cV8tApproveNum ;
      private long cV12tRecheckRandomNum ;
      private long cV11tRecheckNum ;
      private String scmdbuf ;
      private String AV10tCurrentTenantCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P003S2_AV9tApproveRandomNum ;
      private long[] P003S3_AV8tApproveNum ;
      private long[] P003S4_AV12tRecheckRandomNum ;
      private long[] P003S5_AV11tRecheckNum ;
      private long aP0_tApproveRandomNum ;
      private long aP1_tApproveNum ;
      private long aP2_tRecheckRandomNum ;
      private long aP3_tRecheckNum ;
   }

   public class zutil_getrandomsituation__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP003S2 ;
          prmP003S2 = new Object[] {
          new Object[] {"@AV10tCurrentTenantCode",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP003S3 ;
          prmP003S3 = new Object[] {
          new Object[] {"@AV10tCurrentTenantCode",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP003S4 ;
          prmP003S4 = new Object[] {
          new Object[] {"@AV10tCurrentTenantCode",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP003S5 ;
          prmP003S5 = new Object[] {
          new Object[] {"@AV10tCurrentTenantCode",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003S2", "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK) WHERE ([BAS_TenantTenantCode] = RTRIM(LTRIM(@AV10tCurrentTenantCode))) AND ([BR_Encounter_IsRandApprove] = 1) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003S2,1,0,true,false )
             ,new CursorDef("P003S3", "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK) WHERE ([BAS_TenantTenantCode] = RTRIM(LTRIM(@AV10tCurrentTenantCode))) AND ([BR_Encounter_IsRandApprove] IS NULL) AND ([BR_Encounter_Status] <> 1 and [BR_Encounter_Status] <> 2) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003S3,1,0,true,false )
             ,new CursorDef("P003S4", "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK) WHERE ([BAS_TenantTenantCode] = RTRIM(LTRIM(@AV10tCurrentTenantCode))) AND ([BR_Encounter_IsRandRecheck] = 1) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003S4,1,0,true,false )
             ,new CursorDef("P003S5", "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK) WHERE ([BAS_TenantTenantCode] = RTRIM(LTRIM(@AV10tCurrentTenantCode))) AND ([BR_Encounter_IsRandRecheck] IS NULL) AND ([BR_Encounter_Status] = 6) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003S5,1,0,true,false )
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
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 3 :
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
