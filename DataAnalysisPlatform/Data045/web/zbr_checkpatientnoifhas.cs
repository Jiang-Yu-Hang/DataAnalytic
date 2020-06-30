/*
               File: ZBR_CheckPatientNoIfHas
        Description: 检查患者编号是否被使用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:5.8
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
   public class zbr_checkpatientnoifhas : GXProcedure
   {
      public zbr_checkpatientnoifhas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_checkpatientnoifhas( IGxContext context )
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
                           String aP1_tNewBR_Information_PatientNo ,
                           String aP2_tOldBR_Information_PatientNo ,
                           out bool aP3_oFlag )
      {
         this.AV11iType = aP0_iType;
         this.AV8tNewBR_Information_PatientNo = aP1_tNewBR_Information_PatientNo;
         this.AV9tOldBR_Information_PatientNo = aP2_tOldBR_Information_PatientNo;
         this.AV10oFlag = false ;
         initialize();
         executePrivate();
         aP3_oFlag=this.AV10oFlag;
      }

      public bool executeUdp( short aP0_iType ,
                              String aP1_tNewBR_Information_PatientNo ,
                              String aP2_tOldBR_Information_PatientNo )
      {
         this.AV11iType = aP0_iType;
         this.AV8tNewBR_Information_PatientNo = aP1_tNewBR_Information_PatientNo;
         this.AV9tOldBR_Information_PatientNo = aP2_tOldBR_Information_PatientNo;
         this.AV10oFlag = false ;
         initialize();
         executePrivate();
         aP3_oFlag=this.AV10oFlag;
         return AV10oFlag ;
      }

      public void executeSubmit( short aP0_iType ,
                                 String aP1_tNewBR_Information_PatientNo ,
                                 String aP2_tOldBR_Information_PatientNo ,
                                 out bool aP3_oFlag )
      {
         zbr_checkpatientnoifhas objzbr_checkpatientnoifhas;
         objzbr_checkpatientnoifhas = new zbr_checkpatientnoifhas();
         objzbr_checkpatientnoifhas.AV11iType = aP0_iType;
         objzbr_checkpatientnoifhas.AV8tNewBR_Information_PatientNo = aP1_tNewBR_Information_PatientNo;
         objzbr_checkpatientnoifhas.AV9tOldBR_Information_PatientNo = aP2_tOldBR_Information_PatientNo;
         objzbr_checkpatientnoifhas.AV10oFlag = false ;
         objzbr_checkpatientnoifhas.context.SetSubmitInitialConfig(context);
         objzbr_checkpatientnoifhas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_checkpatientnoifhas);
         aP3_oFlag=this.AV10oFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_checkpatientnoifhas)stateInfo).executePrivate();
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
         AV10oFlag = true;
         if ( AV11iType == 2 )
         {
            /* Using cursor P00352 */
            pr_default.execute(0, new Object[] {AV9tOldBR_Information_PatientNo, AV8tNewBR_Information_PatientNo});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A36BR_Information_PatientNo = P00352_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = P00352_n36BR_Information_PatientNo[0];
               A85BR_Information_ID = P00352_A85BR_Information_ID[0];
               AV10oFlag = false;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00353 */
            pr_default.execute(1, new Object[] {AV8tNewBR_Information_PatientNo});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A36BR_Information_PatientNo = P00353_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = P00353_n36BR_Information_PatientNo[0];
               A85BR_Information_ID = P00353_A85BR_Information_ID[0];
               AV10oFlag = false;
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
         scmdbuf = "";
         P00352_A36BR_Information_PatientNo = new String[] {""} ;
         P00352_n36BR_Information_PatientNo = new bool[] {false} ;
         P00352_A85BR_Information_ID = new long[1] ;
         A36BR_Information_PatientNo = "";
         P00353_A36BR_Information_PatientNo = new String[] {""} ;
         P00353_n36BR_Information_PatientNo = new bool[] {false} ;
         P00353_A85BR_Information_ID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_checkpatientnoifhas__default(),
            new Object[][] {
                new Object[] {
               P00352_A36BR_Information_PatientNo, P00352_n36BR_Information_PatientNo, P00352_A85BR_Information_ID
               }
               , new Object[] {
               P00353_A36BR_Information_PatientNo, P00353_n36BR_Information_PatientNo, P00353_A85BR_Information_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11iType ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private bool AV10oFlag ;
      private bool n36BR_Information_PatientNo ;
      private String AV8tNewBR_Information_PatientNo ;
      private String AV9tOldBR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00352_A36BR_Information_PatientNo ;
      private bool[] P00352_n36BR_Information_PatientNo ;
      private long[] P00352_A85BR_Information_ID ;
      private String[] P00353_A36BR_Information_PatientNo ;
      private bool[] P00353_n36BR_Information_PatientNo ;
      private long[] P00353_A85BR_Information_ID ;
      private bool aP3_oFlag ;
   }

   public class zbr_checkpatientnoifhas__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00352 ;
          prmP00352 = new Object[] {
          new Object[] {"@AV9tOldBR_Information_PatientNo",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV8tNewBR_Information_PatientNo",SqlDbType.NVarChar,2000,0}
          } ;
          Object[] prmP00353 ;
          prmP00353 = new Object[] {
          new Object[] {"@AV8tNewBR_Information_PatientNo",SqlDbType.NVarChar,2000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00352", "SELECT [BR_Information_PatientNo], [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE ([BR_Information_PatientNo] <> @AV9tOldBR_Information_PatientNo) AND ([BR_Information_PatientNo] = @AV8tNewBR_Information_PatientNo) ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00352,100,0,false,false )
             ,new CursorDef("P00353", "SELECT [BR_Information_PatientNo], [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_PatientNo] = @AV8tNewBR_Information_PatientNo ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00353,100,0,false,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
