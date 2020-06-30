/*
               File: ZBR_GetEncounterCount
        Description: 获得登录用户最近半年内的录入量
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.73
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
   public class zbr_getencountercount : GXProcedure
   {
      public zbr_getencountercount( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_getencountercount( IGxContext context )
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
         this.AV22oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV22oContent;
      }

      public String executeUdp( )
      {
         this.AV22oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV22oContent;
         return AV22oContent ;
      }

      public void executeSubmit( out String aP0_oContent )
      {
         zbr_getencountercount objzbr_getencountercount;
         objzbr_getencountercount = new zbr_getencountercount();
         objzbr_getencountercount.AV22oContent = "" ;
         objzbr_getencountercount.context.SetSubmitInitialConfig(context);
         objzbr_getencountercount.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_getencountercount);
         aP0_oContent=this.AV22oContent;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_getencountercount)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV10WWPContext) ;
         AV18tSDT_EncounterCount.Clear();
         AV9tNowDateTime = DateTimeUtil.ServerNow( context, pr_default);
         AV12tMonthName1 = DateTimeUtil.CMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -5), "chs");
         AV13tMonthName2 = DateTimeUtil.CMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -4), "chs");
         AV14tMonthName3 = DateTimeUtil.CMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -3), "chs");
         AV15tMonthName4 = DateTimeUtil.CMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -2), "chs");
         AV11tMonthName5 = DateTimeUtil.CMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -1), "chs");
         AV16tMonthName6 = DateTimeUtil.CMonth( AV9tNowDateTime, "chs");
         AV17tBeginDateTime = DateTimeUtil.ResetTime( DateTimeUtil.DateEndOfMonth( DateTimeUtil.AddMth( AV9tNowDateTime, -6)) ) ;
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV12tMonthName1;
         AV21tConditionMonthName = AV12tMonthName1;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV13tMonthName2;
         AV21tConditionMonthName = AV13tMonthName2;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV14tMonthName3;
         AV21tConditionMonthName = AV14tMonthName3;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV15tMonthName4;
         AV21tConditionMonthName = AV15tMonthName4;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV11tMonthName5;
         AV21tConditionMonthName = AV11tMonthName5;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV19tSubItem.gxTpr_Month = AV16tMonthName6;
         AV21tConditionMonthName = AV16tMonthName6;
         /* Execute user subroutine: 'GETCOUNTBYMONTH' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV19tSubItem.gxTpr_Value = StringUtil.Trim( StringUtil.Str( (decimal)(AV20tCount), 18, 0));
         AV18tSDT_EncounterCount.Add(AV19tSubItem, 0);
         AV22oContent = AV18tSDT_EncounterCount.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'GETCOUNTBYMONTH' Routine */
         AV20tCount = 0;
         /* Using cursor P00282 */
         pr_default.execute(0, new Object[] {AV10WWPContext.gxTpr_Userguid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A182BR_Encounter_CrtDate = P00282_A182BR_Encounter_CrtDate[0];
            n182BR_Encounter_CrtDate = P00282_n182BR_Encounter_CrtDate[0];
            A183BR_Encounter_CrtUser = P00282_A183BR_Encounter_CrtUser[0];
            n183BR_Encounter_CrtUser = P00282_n183BR_Encounter_CrtUser[0];
            A19BR_EncounterID = P00282_A19BR_EncounterID[0];
            if ( ( A182BR_Encounter_CrtDate > AV17tBeginDateTime ) && ( StringUtil.StrCmp(DateTimeUtil.CMonth( A182BR_Encounter_CrtDate, "chs"), AV21tConditionMonthName) == 0 ) )
            {
               AV20tCount = (long)(AV20tCount+1);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         AV10WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV18tSDT_EncounterCount = new GXBaseCollection<SdtSDT_EncounterCount_SDT_EncounterCountItem>( context, "SDT_EncounterCountItem", "DataAnalysisPlatform");
         AV9tNowDateTime = (DateTime)(DateTime.MinValue);
         AV12tMonthName1 = "";
         AV13tMonthName2 = "";
         AV14tMonthName3 = "";
         AV15tMonthName4 = "";
         AV11tMonthName5 = "";
         AV16tMonthName6 = "";
         AV17tBeginDateTime = (DateTime)(DateTime.MinValue);
         AV19tSubItem = new SdtSDT_EncounterCount_SDT_EncounterCountItem(context);
         AV21tConditionMonthName = "";
         scmdbuf = "";
         P00282_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         P00282_n182BR_Encounter_CrtDate = new bool[] {false} ;
         P00282_A183BR_Encounter_CrtUser = new String[] {""} ;
         P00282_n183BR_Encounter_CrtUser = new bool[] {false} ;
         P00282_A19BR_EncounterID = new long[1] ;
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         A183BR_Encounter_CrtUser = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_getencountercount__default(),
            new Object[][] {
                new Object[] {
               P00282_A182BR_Encounter_CrtDate, P00282_n182BR_Encounter_CrtDate, P00282_A183BR_Encounter_CrtUser, P00282_n183BR_Encounter_CrtUser, P00282_A19BR_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV20tCount ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private DateTime AV9tNowDateTime ;
      private DateTime AV17tBeginDateTime ;
      private DateTime A182BR_Encounter_CrtDate ;
      private bool returnInSub ;
      private bool n182BR_Encounter_CrtDate ;
      private bool n183BR_Encounter_CrtUser ;
      private String AV22oContent ;
      private String AV12tMonthName1 ;
      private String AV13tMonthName2 ;
      private String AV14tMonthName3 ;
      private String AV15tMonthName4 ;
      private String AV11tMonthName5 ;
      private String AV16tMonthName6 ;
      private String AV21tConditionMonthName ;
      private String A183BR_Encounter_CrtUser ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] P00282_A182BR_Encounter_CrtDate ;
      private bool[] P00282_n182BR_Encounter_CrtDate ;
      private String[] P00282_A183BR_Encounter_CrtUser ;
      private bool[] P00282_n183BR_Encounter_CrtUser ;
      private long[] P00282_A19BR_EncounterID ;
      private String aP0_oContent ;
      private GXBaseCollection<SdtSDT_EncounterCount_SDT_EncounterCountItem> AV18tSDT_EncounterCount ;
      private SdtSDT_EncounterCount_SDT_EncounterCountItem AV19tSubItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV10WWPContext ;
   }

   public class zbr_getencountercount__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00282 ;
          prmP00282 = new Object[] {
          new Object[] {"@AV10WWPContext__Userguid",SqlDbType.NVarChar,500,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00282", "SELECT [BR_Encounter_CrtDate], [BR_Encounter_CrtUser], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_Encounter_CrtUser] = RTRIM(LTRIM(@AV10WWPContext__Userguid)) ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00282,100,0,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
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
