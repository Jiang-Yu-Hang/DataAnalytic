/*
               File: PC_IntialDefineCode
        Description: 初始化租户数据字典的数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:11.68
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
   public class pc_intialdefinecode : GXProcedure
   {
      public pc_intialdefinecode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pc_intialdefinecode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_iBAS_TenantTenantCode )
      {
         this.AV8iBAS_TenantTenantCode = aP0_iBAS_TenantTenantCode;
         initialize();
         executePrivate();
      }

      public void executeSubmit( String aP0_iBAS_TenantTenantCode )
      {
         pc_intialdefinecode objpc_intialdefinecode;
         objpc_intialdefinecode = new pc_intialdefinecode();
         objpc_intialdefinecode.AV8iBAS_TenantTenantCode = aP0_iBAS_TenantTenantCode;
         objpc_intialdefinecode.context.SetSubmitInitialConfig(context);
         objpc_intialdefinecode.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpc_intialdefinecode);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pc_intialdefinecode)stateInfo).executePrivate();
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
         /* Using cursor P00402 */
         pr_default.execute(0, new Object[] {AV8iBAS_TenantTenantCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            GXT402 = 0;
            A432XT_TenantCode = P00402_A432XT_TenantCode[0];
            n432XT_TenantCode = P00402_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = P00402_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = P00402_n510XT_DefineCodeIntialType[0];
            A167XT_DefineCodeID = P00402_A167XT_DefineCodeID[0];
            /* Using cursor P00403 */
            pr_default.execute(1, new Object[] {A167XT_DefineCodeID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
            GXT402 = 1;
            if ( GXT402 == 1 )
            {
               context.CommitDataStores("pc_intialdefinecode",pr_default);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P00404 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A510XT_DefineCodeIntialType = P00404_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = P00404_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = P00404_A165XT_DefindcodeTypeID[0];
            A168XT_DefineCodeName = P00404_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = P00404_n168XT_DefineCodeName[0];
            A431XT_TypeCode = P00404_A431XT_TypeCode[0];
            n431XT_TypeCode = P00404_n431XT_TypeCode[0];
            A167XT_DefineCodeID = P00404_A167XT_DefineCodeID[0];
            AV9BCXT_DefineCode = new SdtXT_DefineCode(context);
            AV9BCXT_DefineCode.gxTpr_Xt_defindcodetypeid = A165XT_DefindcodeTypeID;
            AV9BCXT_DefineCode.gxTpr_Xt_definecodename = StringUtil.Trim( A168XT_DefineCodeName);
            AV9BCXT_DefineCode.gxTpr_Xt_tenantcode = StringUtil.Trim( AV8iBAS_TenantTenantCode);
            AV9BCXT_DefineCode.gxTpr_Xt_typecode = StringUtil.Trim( A431XT_TypeCode);
            AV9BCXT_DefineCode.gxTpr_Xt_definecodeintialtype = 2;
            AV9BCXT_DefineCode.gxTv_SdtXT_DefineCode_Xt_definecodeorder_SetNull();
            AV9BCXT_DefineCode.Save();
            context.CommitDataStores("pc_intialdefinecode",pr_default);
            pr_default.readNext(2);
         }
         pr_default.close(2);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("pc_intialdefinecode",pr_default);
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
         P00402_A432XT_TenantCode = new String[] {""} ;
         P00402_n432XT_TenantCode = new bool[] {false} ;
         P00402_A510XT_DefineCodeIntialType = new short[1] ;
         P00402_n510XT_DefineCodeIntialType = new bool[] {false} ;
         P00402_A167XT_DefineCodeID = new long[1] ;
         A432XT_TenantCode = "";
         P00404_A510XT_DefineCodeIntialType = new short[1] ;
         P00404_n510XT_DefineCodeIntialType = new bool[] {false} ;
         P00404_A165XT_DefindcodeTypeID = new long[1] ;
         P00404_A168XT_DefineCodeName = new String[] {""} ;
         P00404_n168XT_DefineCodeName = new bool[] {false} ;
         P00404_A431XT_TypeCode = new String[] {""} ;
         P00404_n431XT_TypeCode = new bool[] {false} ;
         P00404_A167XT_DefineCodeID = new long[1] ;
         A168XT_DefineCodeName = "";
         A431XT_TypeCode = "";
         AV9BCXT_DefineCode = new SdtXT_DefineCode(context);
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.pc_intialdefinecode__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pc_intialdefinecode__default(),
            new Object[][] {
                new Object[] {
               P00402_A432XT_TenantCode, P00402_n432XT_TenantCode, P00402_A510XT_DefineCodeIntialType, P00402_n510XT_DefineCodeIntialType, P00402_A167XT_DefineCodeID
               }
               , new Object[] {
               }
               , new Object[] {
               P00404_A510XT_DefineCodeIntialType, P00404_n510XT_DefineCodeIntialType, P00404_A165XT_DefindcodeTypeID, P00404_A168XT_DefineCodeName, P00404_n168XT_DefineCodeName, P00404_A431XT_TypeCode, P00404_n431XT_TypeCode, P00404_A167XT_DefineCodeID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GXT402 ;
      private short A510XT_DefineCodeIntialType ;
      private long A167XT_DefineCodeID ;
      private long A165XT_DefindcodeTypeID ;
      private String scmdbuf ;
      private bool n432XT_TenantCode ;
      private bool n510XT_DefineCodeIntialType ;
      private bool n168XT_DefineCodeName ;
      private bool n431XT_TypeCode ;
      private String AV8iBAS_TenantTenantCode ;
      private String A432XT_TenantCode ;
      private String A168XT_DefineCodeName ;
      private String A431XT_TypeCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00402_A432XT_TenantCode ;
      private bool[] P00402_n432XT_TenantCode ;
      private short[] P00402_A510XT_DefineCodeIntialType ;
      private bool[] P00402_n510XT_DefineCodeIntialType ;
      private long[] P00402_A167XT_DefineCodeID ;
      private short[] P00404_A510XT_DefineCodeIntialType ;
      private bool[] P00404_n510XT_DefineCodeIntialType ;
      private long[] P00404_A165XT_DefindcodeTypeID ;
      private String[] P00404_A168XT_DefineCodeName ;
      private bool[] P00404_n168XT_DefineCodeName ;
      private String[] P00404_A431XT_TypeCode ;
      private bool[] P00404_n431XT_TypeCode ;
      private long[] P00404_A167XT_DefineCodeID ;
      private IDataStoreProvider pr_datastore1 ;
      private SdtXT_DefineCode AV9BCXT_DefineCode ;
   }

   public class pc_intialdefinecode__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class pc_intialdefinecode__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new UpdateCursor(def[1])
       ,new ForEachCursor(def[2])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmP00402 ;
        prmP00402 = new Object[] {
        new Object[] {"@AV8iBAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmP00403 ;
        prmP00403 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP00404 ;
        prmP00404 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("P00402", "SELECT [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefineCodeID] FROM [XT_DefineCode] WITH (UPDLOCK) WHERE ([XT_DefineCodeIntialType] = 2) AND ([XT_TenantCode] = @AV8iBAS_TenantTenantCode) ORDER BY [XT_DefineCodeID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00402,1,0,true,false )
           ,new CursorDef("P00403", "DELETE FROM [XT_DefineCode]  WHERE [XT_DefineCodeID] = @XT_DefineCodeID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00403)
           ,new CursorDef("P00404", "SELECT [XT_DefineCodeIntialType], [XT_DefindcodeTypeID], [XT_DefineCodeName], [XT_TypeCode], [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefineCodeIntialType] = 1 ORDER BY [XT_DefineCodeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00404,100,0,true,false )
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
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
