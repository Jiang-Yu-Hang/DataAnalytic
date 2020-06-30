/*
               File: ZUtil_FindCountByPatientNo
        Description: 根据患者编号计算出当前的就诊次序的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:1.94
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
   public class zutil_findcountbypatientno : GXProcedure
   {
      public zutil_findcountbypatientno( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_findcountbypatientno( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Information_ID ,
                           out long aP1_tBR_Encounter_EncID )
      {
         this.AV8iBR_Information_ID = aP0_iBR_Information_ID;
         this.AV9tBR_Encounter_EncID = 0 ;
         initialize();
         executePrivate();
         aP1_tBR_Encounter_EncID=this.AV9tBR_Encounter_EncID;
      }

      public long executeUdp( long aP0_iBR_Information_ID )
      {
         this.AV8iBR_Information_ID = aP0_iBR_Information_ID;
         this.AV9tBR_Encounter_EncID = 0 ;
         initialize();
         executePrivate();
         aP1_tBR_Encounter_EncID=this.AV9tBR_Encounter_EncID;
         return AV9tBR_Encounter_EncID ;
      }

      public void executeSubmit( long aP0_iBR_Information_ID ,
                                 out long aP1_tBR_Encounter_EncID )
      {
         zutil_findcountbypatientno objzutil_findcountbypatientno;
         objzutil_findcountbypatientno = new zutil_findcountbypatientno();
         objzutil_findcountbypatientno.AV8iBR_Information_ID = aP0_iBR_Information_ID;
         objzutil_findcountbypatientno.AV9tBR_Encounter_EncID = 0 ;
         objzutil_findcountbypatientno.context.SetSubmitInitialConfig(context);
         objzutil_findcountbypatientno.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_findcountbypatientno);
         aP1_tBR_Encounter_EncID=this.AV9tBR_Encounter_EncID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_findcountbypatientno)stateInfo).executePrivate();
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
         AV10tflag = 0;
         AV13GXLvl2 = 0;
         /* Using cursor P001K2 */
         pr_default.execute(0, new Object[] {AV8iBR_Information_ID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A85BR_Information_ID = P001K2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001K2_n85BR_Information_ID[0];
            A35BR_Encounter_EncID = P001K2_A35BR_Encounter_EncID[0];
            n35BR_Encounter_EncID = P001K2_n35BR_Encounter_EncID[0];
            A19BR_EncounterID = P001K2_A19BR_EncounterID[0];
            AV13GXLvl2 = 1;
            if ( A35BR_Encounter_EncID > AV9tBR_Encounter_EncID )
            {
               AV9tBR_Encounter_EncID = A35BR_Encounter_EncID;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV13GXLvl2 == 0 )
         {
            AV10tflag = 1;
         }
         if ( AV10tflag == 1 )
         {
            AV9tBR_Encounter_EncID = 1;
         }
         else
         {
            AV9tBR_Encounter_EncID = (long)(AV9tBR_Encounter_EncID+1);
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
         P001K2_A85BR_Information_ID = new long[1] ;
         P001K2_n85BR_Information_ID = new bool[] {false} ;
         P001K2_A35BR_Encounter_EncID = new long[1] ;
         P001K2_n35BR_Encounter_EncID = new bool[] {false} ;
         P001K2_A19BR_EncounterID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_findcountbypatientno__default(),
            new Object[][] {
                new Object[] {
               P001K2_A85BR_Information_ID, P001K2_n85BR_Information_ID, P001K2_A35BR_Encounter_EncID, P001K2_n35BR_Encounter_EncID, P001K2_A19BR_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10tflag ;
      private short AV13GXLvl2 ;
      private long AV8iBR_Information_ID ;
      private long AV9tBR_Encounter_EncID ;
      private long A85BR_Information_ID ;
      private long A35BR_Encounter_EncID ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool n85BR_Information_ID ;
      private bool n35BR_Encounter_EncID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001K2_A85BR_Information_ID ;
      private bool[] P001K2_n85BR_Information_ID ;
      private long[] P001K2_A35BR_Encounter_EncID ;
      private bool[] P001K2_n35BR_Encounter_EncID ;
      private long[] P001K2_A19BR_EncounterID ;
      private long aP1_tBR_Encounter_EncID ;
   }

   public class zutil_findcountbypatientno__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001K2 ;
          prmP001K2 = new Object[] {
          new Object[] {"@AV8iBR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001K2", "SELECT [BR_Information_ID], [BR_Encounter_EncID], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8iBR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001K2,100,0,false,false )
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
