/*
               File: ZBR_CheckDefineCodeNameIfHas
        Description: 数据字典信息名称的唯一性
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:40.28
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
   public class zbr_checkdefinecodenameifhas : GXProcedure
   {
      public zbr_checkdefinecodenameifhas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_checkdefinecodenameifhas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_iType ,
                           String aP1_tNewXT_DefineCodeName ,
                           String aP2_tOldXT_DefineCodeName ,
                           long aP3_iXT_DefindcodeTypeID ,
                           out bool aP4_oFlag )
      {
         this.AV12iType = aP0_iType;
         this.AV9tNewXT_DefineCodeName = aP1_tNewXT_DefineCodeName;
         this.AV10tOldXT_DefineCodeName = aP2_tOldXT_DefineCodeName;
         this.AV11iXT_DefindcodeTypeID = aP3_iXT_DefindcodeTypeID;
         this.AV8oFlag = false ;
         initialize();
         executePrivate();
         aP4_oFlag=this.AV8oFlag;
      }

      public bool executeUdp( short aP0_iType ,
                              String aP1_tNewXT_DefineCodeName ,
                              String aP2_tOldXT_DefineCodeName ,
                              long aP3_iXT_DefindcodeTypeID )
      {
         this.AV12iType = aP0_iType;
         this.AV9tNewXT_DefineCodeName = aP1_tNewXT_DefineCodeName;
         this.AV10tOldXT_DefineCodeName = aP2_tOldXT_DefineCodeName;
         this.AV11iXT_DefindcodeTypeID = aP3_iXT_DefindcodeTypeID;
         this.AV8oFlag = false ;
         initialize();
         executePrivate();
         aP4_oFlag=this.AV8oFlag;
         return AV8oFlag ;
      }

      public void executeSubmit( short aP0_iType ,
                                 String aP1_tNewXT_DefineCodeName ,
                                 String aP2_tOldXT_DefineCodeName ,
                                 long aP3_iXT_DefindcodeTypeID ,
                                 out bool aP4_oFlag )
      {
         zbr_checkdefinecodenameifhas objzbr_checkdefinecodenameifhas;
         objzbr_checkdefinecodenameifhas = new zbr_checkdefinecodenameifhas();
         objzbr_checkdefinecodenameifhas.AV12iType = aP0_iType;
         objzbr_checkdefinecodenameifhas.AV9tNewXT_DefineCodeName = aP1_tNewXT_DefineCodeName;
         objzbr_checkdefinecodenameifhas.AV10tOldXT_DefineCodeName = aP2_tOldXT_DefineCodeName;
         objzbr_checkdefinecodenameifhas.AV11iXT_DefindcodeTypeID = aP3_iXT_DefindcodeTypeID;
         objzbr_checkdefinecodenameifhas.AV8oFlag = false ;
         objzbr_checkdefinecodenameifhas.context.SetSubmitInitialConfig(context);
         objzbr_checkdefinecodenameifhas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_checkdefinecodenameifhas);
         aP4_oFlag=this.AV8oFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_checkdefinecodenameifhas)stateInfo).executePrivate();
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
         AV8oFlag = true;
         new zbr_getcurrenttcode(context ).execute( out  AV13tCurrentCode) ;
         if ( AV12iType == 2 )
         {
            /* Using cursor P003K2 */
            pr_default.execute(0, new Object[] {AV11iXT_DefindcodeTypeID, AV13tCurrentCode, AV10tOldXT_DefineCodeName, AV9tNewXT_DefineCodeName});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A168XT_DefineCodeName = P003K2_A168XT_DefineCodeName[0];
               n168XT_DefineCodeName = P003K2_n168XT_DefineCodeName[0];
               A432XT_TenantCode = P003K2_A432XT_TenantCode[0];
               n432XT_TenantCode = P003K2_n432XT_TenantCode[0];
               A165XT_DefindcodeTypeID = P003K2_A165XT_DefindcodeTypeID[0];
               A167XT_DefineCodeID = P003K2_A167XT_DefineCodeID[0];
               AV8oFlag = false;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P003K3 */
            pr_default.execute(1, new Object[] {AV11iXT_DefindcodeTypeID, AV13tCurrentCode, AV9tNewXT_DefineCodeName});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A168XT_DefineCodeName = P003K3_A168XT_DefineCodeName[0];
               n168XT_DefineCodeName = P003K3_n168XT_DefineCodeName[0];
               A432XT_TenantCode = P003K3_A432XT_TenantCode[0];
               n432XT_TenantCode = P003K3_n432XT_TenantCode[0];
               A165XT_DefindcodeTypeID = P003K3_A165XT_DefindcodeTypeID[0];
               A167XT_DefineCodeID = P003K3_A167XT_DefineCodeID[0];
               AV8oFlag = false;
               pr_default.readNext(1);
            }
            pr_default.close(1);
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
         AV13tCurrentCode = "";
         scmdbuf = "";
         P003K2_A168XT_DefineCodeName = new String[] {""} ;
         P003K2_n168XT_DefineCodeName = new bool[] {false} ;
         P003K2_A432XT_TenantCode = new String[] {""} ;
         P003K2_n432XT_TenantCode = new bool[] {false} ;
         P003K2_A165XT_DefindcodeTypeID = new long[1] ;
         P003K2_A167XT_DefineCodeID = new long[1] ;
         A168XT_DefineCodeName = "";
         A432XT_TenantCode = "";
         P003K3_A168XT_DefineCodeName = new String[] {""} ;
         P003K3_n168XT_DefineCodeName = new bool[] {false} ;
         P003K3_A432XT_TenantCode = new String[] {""} ;
         P003K3_n432XT_TenantCode = new bool[] {false} ;
         P003K3_A165XT_DefindcodeTypeID = new long[1] ;
         P003K3_A167XT_DefineCodeID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_checkdefinecodenameifhas__default(),
            new Object[][] {
                new Object[] {
               P003K2_A168XT_DefineCodeName, P003K2_n168XT_DefineCodeName, P003K2_A432XT_TenantCode, P003K2_n432XT_TenantCode, P003K2_A165XT_DefindcodeTypeID, P003K2_A167XT_DefineCodeID
               }
               , new Object[] {
               P003K3_A168XT_DefineCodeName, P003K3_n168XT_DefineCodeName, P003K3_A432XT_TenantCode, P003K3_n432XT_TenantCode, P003K3_A165XT_DefindcodeTypeID, P003K3_A167XT_DefineCodeID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12iType ;
      private long AV11iXT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
      private long A167XT_DefineCodeID ;
      private String scmdbuf ;
      private bool AV8oFlag ;
      private bool n168XT_DefineCodeName ;
      private bool n432XT_TenantCode ;
      private String AV9tNewXT_DefineCodeName ;
      private String AV10tOldXT_DefineCodeName ;
      private String AV13tCurrentCode ;
      private String A168XT_DefineCodeName ;
      private String A432XT_TenantCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P003K2_A168XT_DefineCodeName ;
      private bool[] P003K2_n168XT_DefineCodeName ;
      private String[] P003K2_A432XT_TenantCode ;
      private bool[] P003K2_n432XT_TenantCode ;
      private long[] P003K2_A165XT_DefindcodeTypeID ;
      private long[] P003K2_A167XT_DefineCodeID ;
      private String[] P003K3_A168XT_DefineCodeName ;
      private bool[] P003K3_n168XT_DefineCodeName ;
      private String[] P003K3_A432XT_TenantCode ;
      private bool[] P003K3_n432XT_TenantCode ;
      private long[] P003K3_A165XT_DefindcodeTypeID ;
      private long[] P003K3_A167XT_DefineCodeID ;
      private bool aP4_oFlag ;
   }

   public class zbr_checkdefinecodenameifhas__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP003K2 ;
          prmP003K2 = new Object[] {
          new Object[] {"@AV11iXT_DefindcodeTypeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV13tCurrentCode",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV10tOldXT_DefineCodeName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV9tNewXT_DefineCodeName",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP003K3 ;
          prmP003K3 = new Object[] {
          new Object[] {"@AV11iXT_DefindcodeTypeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV13tCurrentCode",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV9tNewXT_DefineCodeName",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003K2", "SELECT [XT_DefineCodeName], [XT_TenantCode], [XT_DefindcodeTypeID], [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = @AV11iXT_DefindcodeTypeID) AND ([XT_TenantCode] = RTRIM(LTRIM(@AV13tCurrentCode))) AND ([XT_DefineCodeName] <> @AV10tOldXT_DefineCodeName) AND ([XT_DefineCodeName] = @AV9tNewXT_DefineCodeName) ORDER BY [XT_DefindcodeTypeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003K2,100,0,false,false )
             ,new CursorDef("P003K3", "SELECT [XT_DefineCodeName], [XT_TenantCode], [XT_DefindcodeTypeID], [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = @AV11iXT_DefindcodeTypeID) AND ([XT_TenantCode] = RTRIM(LTRIM(@AV13tCurrentCode))) AND ([XT_DefineCodeName] = @AV9tNewXT_DefineCodeName) ORDER BY [XT_DefindcodeTypeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003K3,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
