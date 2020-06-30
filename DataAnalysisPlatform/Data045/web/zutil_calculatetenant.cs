/*
               File: ZUtil_CalculateTenant
        Description: 计算租户就诊信息统计的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.34
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
   public class zutil_calculatetenant : GXProcedure
   {
      public zutil_calculatetenant( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_calculatetenant( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_oContent )
      {
         this.AV8oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV8oContent;
      }

      public String executeUdp( )
      {
         this.AV8oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV8oContent;
         return AV8oContent ;
      }

      public void executeSubmit( out String aP0_oContent )
      {
         zutil_calculatetenant objzutil_calculatetenant;
         objzutil_calculatetenant = new zutil_calculatetenant();
         objzutil_calculatetenant.AV8oContent = "" ;
         objzutil_calculatetenant.context.SetSubmitInitialConfig(context);
         objzutil_calculatetenant.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_calculatetenant);
         aP0_oContent=this.AV8oContent;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_calculatetenant)stateInfo).executePrivate();
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
         AV10SDT_EntityCount.Clear();
         /* Using cursor P003R2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A360BAS_TenantTenantCode = P003R2_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = P003R2_n360BAS_TenantTenantCode[0];
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) || P003R2_n360BAS_TenantTenantCode[0] )
            {
            }
            else
            {
               AV11SDT_EntityCountItem = new SdtSDT_EntityCount(context);
               AV11SDT_EntityCountItem.gxTpr_Entityname = StringUtil.Trim( A360BAS_TenantTenantCode);
               AV10SDT_EntityCount.Add(AV11SDT_EntityCountItem, 0);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV14tNewSDT_EntityCount.Clear();
         AV20GXV1 = 1;
         while ( AV20GXV1 <= AV10SDT_EntityCount.Count )
         {
            AV12SDT_EntityCountItemCheck = ((SdtSDT_EntityCount)AV10SDT_EntityCount.Item(AV20GXV1));
            AV12SDT_EntityCountItemCheck.gxTpr_Value = 0;
            /* Optimized group. */
            /* Using cursor P003R3 */
            pr_default.execute(1, new Object[] {AV12SDT_EntityCountItemCheck.gxTpr_Entityname});
            aggopt0 = P003R3_Aaggopt0[0];
            pr_default.close(1);
            AV12SDT_EntityCountItemCheck.gxTpr_Value = (long)(AV12SDT_EntityCountItemCheck.gxTpr_Value+aggopt0*1);
            /* End optimized group. */
            AV14tNewSDT_EntityCount.Add(AV12SDT_EntityCountItemCheck, 0);
            AV20GXV1 = (int)(AV20GXV1+1);
         }
         AV8oContent = AV14tNewSDT_EntityCount.ToJSonString(false);
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
         AV10SDT_EntityCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         scmdbuf = "";
         P003R2_A360BAS_TenantTenantCode = new String[] {""} ;
         P003R2_n360BAS_TenantTenantCode = new bool[] {false} ;
         A360BAS_TenantTenantCode = "";
         AV11SDT_EntityCountItem = new SdtSDT_EntityCount(context);
         AV14tNewSDT_EntityCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         AV12SDT_EntityCountItemCheck = new SdtSDT_EntityCount(context);
         P003R3_Aaggopt0 = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_calculatetenant__default(),
            new Object[][] {
                new Object[] {
               P003R2_A360BAS_TenantTenantCode, P003R2_n360BAS_TenantTenantCode
               }
               , new Object[] {
               P003R3_Aaggopt0
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV20GXV1 ;
      private long aggopt0 ;
      private String scmdbuf ;
      private bool n360BAS_TenantTenantCode ;
      private String AV8oContent ;
      private String A360BAS_TenantTenantCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P003R2_A360BAS_TenantTenantCode ;
      private bool[] P003R2_n360BAS_TenantTenantCode ;
      private long[] P003R3_Aaggopt0 ;
      private String aP0_oContent ;
      private GXBaseCollection<SdtSDT_EntityCount> AV10SDT_EntityCount ;
      private GXBaseCollection<SdtSDT_EntityCount> AV14tNewSDT_EntityCount ;
      private SdtSDT_EntityCount AV11SDT_EntityCountItem ;
      private SdtSDT_EntityCount AV12SDT_EntityCountItemCheck ;
   }

   public class zutil_calculatetenant__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP003R2 ;
          prmP003R2 = new Object[] {
          } ;
          Object[] prmP003R3 ;
          prmP003R3 = new Object[] {
          new Object[] {"@AV12SDT__1Entityname",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003R2", "SELECT DISTINCT [BAS_TenantTenantCode] FROM [BR_Encounter] WITH (NOLOCK) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003R2,100,0,false,false )
             ,new CursorDef("P003R3", "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK) WHERE RTRIM(LTRIM([BAS_TenantTenantCode])) = @AV12SDT__1Entityname ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003R3,1,0,true,false )
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
                return;
             case 1 :
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
