/*
               File: ZBR_CheckInfoIfInCode
        Description: 检查患者是否能够显示在当前租户中
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:41.37
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
   public class zbr_checkinfoifincode : GXProcedure
   {
      public zbr_checkinfoifincode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_checkinfoifincode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_iBAS_TenantTenantCode ,
                           bool aP1_IsManager ,
                           out GxSimpleCollection<long> aP2_oBR_Information_ID )
      {
         this.AV9iBAS_TenantTenantCode = aP0_iBAS_TenantTenantCode;
         this.AV18IsManager = aP1_IsManager;
         this.AV11oBR_Information_ID = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP2_oBR_Information_ID=this.AV11oBR_Information_ID;
      }

      public GxSimpleCollection<long> executeUdp( String aP0_iBAS_TenantTenantCode ,
                                                  bool aP1_IsManager )
      {
         this.AV9iBAS_TenantTenantCode = aP0_iBAS_TenantTenantCode;
         this.AV18IsManager = aP1_IsManager;
         this.AV11oBR_Information_ID = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP2_oBR_Information_ID=this.AV11oBR_Information_ID;
         return AV11oBR_Information_ID ;
      }

      public void executeSubmit( String aP0_iBAS_TenantTenantCode ,
                                 bool aP1_IsManager ,
                                 out GxSimpleCollection<long> aP2_oBR_Information_ID )
      {
         zbr_checkinfoifincode objzbr_checkinfoifincode;
         objzbr_checkinfoifincode = new zbr_checkinfoifincode();
         objzbr_checkinfoifincode.AV9iBAS_TenantTenantCode = aP0_iBAS_TenantTenantCode;
         objzbr_checkinfoifincode.AV18IsManager = aP1_IsManager;
         objzbr_checkinfoifincode.AV11oBR_Information_ID = new GxSimpleCollection<long>() ;
         objzbr_checkinfoifincode.context.SetSubmitInitialConfig(context);
         objzbr_checkinfoifincode.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_checkinfoifincode);
         aP2_oBR_Information_ID=this.AV11oBR_Information_ID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_checkinfoifincode)stateInfo).executePrivate();
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
         AV12oFirstBR_Information_ID.Clear();
         /* Using cursor P00422 */
         pr_default.execute(0, new Object[] {AV9iBAS_TenantTenantCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A360BAS_TenantTenantCode = P00422_A360BAS_TenantTenantCode[0];
            A85BR_Information_ID = P00422_A85BR_Information_ID[0];
            AV12oFirstBR_Information_ID.Add(A85BR_Information_ID, 0);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV11oBR_Information_ID.Clear();
         if ( AV18IsManager )
         {
            AV11oBR_Information_ID = AV12oFirstBR_Information_ID;
         }
         else
         {
            AV14tResult = AV13websession.Get("DAS_UserPermission");
            AV15tSDT_MicroUserInfo.FromJSonString(AV14tResult, null);
            AV16tDataPackage.Clear();
            AV17tNum = 1;
            while ( AV17tNum <= ((SdtSDT_MicroUserInfo_Tenants)AV15tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Count )
            {
               AV16tDataPackage.Add(StringUtil.Trim( ((String)((SdtSDT_MicroUserInfo_Tenants)AV15tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Item((int)(AV17tNum)))), 0);
               AV17tNum = (long)(AV17tNum+1);
            }
            pr_default.dynParam(1, new Object[]{ new Object[]{
                                                 A85BR_Information_ID ,
                                                 AV12oFirstBR_Information_ID ,
                                                 A366DataPackage ,
                                                 AV16tDataPackage } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.STRING
                                                 }
            } ) ;
            /* Using cursor P00423 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A366DataPackage = P00423_A366DataPackage[0];
               A85BR_Information_ID = P00423_A85BR_Information_ID[0];
               AV11oBR_Information_ID.Add(A85BR_Information_ID, 0);
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
         AV12oFirstBR_Information_ID = new GxSimpleCollection<long>();
         scmdbuf = "";
         P00422_A360BAS_TenantTenantCode = new String[] {""} ;
         P00422_A85BR_Information_ID = new long[1] ;
         A360BAS_TenantTenantCode = "";
         AV14tResult = "";
         AV13websession = context.GetSession();
         AV15tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV16tDataPackage = new GxSimpleCollection<String>();
         A366DataPackage = "";
         P00423_A366DataPackage = new String[] {""} ;
         P00423_A85BR_Information_ID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_checkinfoifincode__default(),
            new Object[][] {
                new Object[] {
               P00422_A360BAS_TenantTenantCode, P00422_A85BR_Information_ID
               }
               , new Object[] {
               P00423_A366DataPackage, P00423_A85BR_Information_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long A85BR_Information_ID ;
      private long AV17tNum ;
      private String scmdbuf ;
      private bool AV18IsManager ;
      private String AV9iBAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private String AV14tResult ;
      private String A366DataPackage ;
      private GxSimpleCollection<long> AV11oBR_Information_ID ;
      private GxSimpleCollection<long> AV12oFirstBR_Information_ID ;
      private IGxSession AV13websession ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00422_A360BAS_TenantTenantCode ;
      private long[] P00422_A85BR_Information_ID ;
      private String[] P00423_A366DataPackage ;
      private long[] P00423_A85BR_Information_ID ;
      private GxSimpleCollection<long> aP2_oBR_Information_ID ;
      private GxSimpleCollection<String> AV16tDataPackage ;
      private SdtSDT_MicroUserInfo AV15tSDT_MicroUserInfo ;
   }

   public class zbr_checkinfoifincode__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00423( IGxContext context ,
                                             long A85BR_Information_ID ,
                                             GxSimpleCollection<long> AV12oFirstBR_Information_ID ,
                                             String A366DataPackage ,
                                             GxSimpleCollection<String> AV16tDataPackage )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object1 ;
         GXv_Object1 = new Object [2] ;
         scmdbuf = "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV12oFirstBR_Information_ID, "[BR_Information_ID] IN (", ")") + ")";
         scmdbuf = scmdbuf + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV16tDataPackage, "[DataPackage] IN (", ")") + ")";
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Information_ID], [DataPackage]";
         GXv_Object1[0] = scmdbuf;
         return GXv_Object1 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_P00423(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP00422 ;
          prmP00422 = new Object[] {
          new Object[] {"@AV9iBAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmP00423 ;
          prmP00423 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00422", "SELECT [BAS_TenantTenantCode], [BR_Information_ID] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BAS_TenantTenantCode] = @AV9iBAS_TenantTenantCode ORDER BY [BAS_TenantTenantCode] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00422,100,0,false,false )
             ,new CursorDef("P00423", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00423,100,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
