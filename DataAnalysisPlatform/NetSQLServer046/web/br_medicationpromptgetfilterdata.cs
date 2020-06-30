/*
               File: BR_MedicationPromptGetFilterData
        Description: BR_Medication Prompt Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:14.89
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_medicationpromptgetfilterdata : GXProcedure
   {
      public br_medicationpromptgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicationpromptgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
         return AV24OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_medicationpromptgetfilterdata objbr_medicationpromptgetfilterdata;
         objbr_medicationpromptgetfilterdata = new br_medicationpromptgetfilterdata();
         objbr_medicationpromptgetfilterdata.AV15DDOName = aP0_DDOName;
         objbr_medicationpromptgetfilterdata.AV13SearchTxt = aP1_SearchTxt;
         objbr_medicationpromptgetfilterdata.AV14SearchTxtTo = aP2_SearchTxtTo;
         objbr_medicationpromptgetfilterdata.AV19OptionsJson = "" ;
         objbr_medicationpromptgetfilterdata.AV22OptionsDescJson = "" ;
         objbr_medicationpromptgetfilterdata.AV24OptionIndexesJson = "" ;
         objbr_medicationpromptgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_medicationpromptgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_medicationpromptgetfilterdata);
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_medicationpromptgetfilterdata)stateInfo).executePrivate();
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
         AV18Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV21OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Medication", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV15DDOName), "DDO_BR_MEDICATION_RXUNIT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXUNITOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV19OptionsJson = AV18Options.ToJSonString(false);
         AV22OptionsDescJson = AV21OptionsDesc.ToJSonString(false);
         AV24OptionIndexesJson = AV23OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV26Session.Get("BR_MedicationPromptGridState"), "") == 0 )
         {
            AV28GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_MedicationPromptGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV28GridState.FromXml(AV26Session.Get("BR_MedicationPromptGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV35GXV1 = 1;
         while ( AV35GXV1 <= AV28GridState.gxTpr_Filtervalues.Count )
         {
            AV29GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV28GridState.gxTpr_Filtervalues.Item(AV35GXV1));
            if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "BR_MEDICATION_RXNAME") == 0 )
            {
               AV31BR_Medication_RXName = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT") == 0 )
            {
               AV11TFBR_Medication_RXUnit = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT_SEL") == 0 )
            {
               AV12TFBR_Medication_RXUnit_Sel = AV29GridStateFilterValue.gxTpr_Value;
            }
            AV35GXV1 = (int)(AV35GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_MEDICATION_RXUNITOPTIONS' Routine */
         AV11TFBR_Medication_RXUnit = AV13SearchTxt;
         AV12TFBR_Medication_RXUnit_Sel = "";
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV31BR_Medication_RXName ,
                                              AV12TFBR_Medication_RXUnit_Sel ,
                                              AV11TFBR_Medication_RXUnit ,
                                              A121BR_Medication_RXName ,
                                              A125BR_Medication_RXUnit ,
                                              A19BR_EncounterID ,
                                              AV32BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         lV31BR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV31BR_Medication_RXName), "%", "");
         lV11TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Medication_RXUnit), "%", "");
         /* Using cursor P00342 */
         pr_default.execute(0, new Object[] {AV32BR_EncounterID, lV31BR_Medication_RXName, lV11TFBR_Medication_RXUnit, AV12TFBR_Medication_RXUnit_Sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK342 = false;
            A19BR_EncounterID = P00342_A19BR_EncounterID[0];
            A125BR_Medication_RXUnit = P00342_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00342_n125BR_Medication_RXUnit[0];
            A121BR_Medication_RXName = P00342_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00342_n121BR_Medication_RXName[0];
            A119BR_MedicationID = P00342_A119BR_MedicationID[0];
            AV25count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00342_A125BR_Medication_RXUnit[0], A125BR_Medication_RXUnit) == 0 ) )
            {
               BRK342 = false;
               A119BR_MedicationID = P00342_A119BR_MedicationID[0];
               AV25count = (long)(AV25count+1);
               BRK342 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) )
            {
               AV17Option = A125BR_Medication_RXUnit;
               AV18Options.Add(AV17Option, 0);
               AV23OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV25count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV18Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK342 )
            {
               BRK342 = true;
               pr_default.readNext(0);
            }
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
         AV18Options = new GxSimpleCollection<String>();
         AV21OptionsDesc = new GxSimpleCollection<String>();
         AV23OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV26Session = context.GetSession();
         AV28GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV29GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV31BR_Medication_RXName = "";
         AV11TFBR_Medication_RXUnit = "";
         AV12TFBR_Medication_RXUnit_Sel = "";
         scmdbuf = "";
         lV31BR_Medication_RXName = "";
         lV11TFBR_Medication_RXUnit = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         P00342_A19BR_EncounterID = new long[1] ;
         P00342_A125BR_Medication_RXUnit = new String[] {""} ;
         P00342_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00342_A121BR_Medication_RXName = new String[] {""} ;
         P00342_n121BR_Medication_RXName = new bool[] {false} ;
         P00342_A119BR_MedicationID = new long[1] ;
         AV17Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationpromptgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00342_A19BR_EncounterID, P00342_A125BR_Medication_RXUnit, P00342_n125BR_Medication_RXUnit, P00342_A121BR_Medication_RXName, P00342_n121BR_Medication_RXName, P00342_A119BR_MedicationID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV35GXV1 ;
      private long A19BR_EncounterID ;
      private long AV32BR_EncounterID ;
      private long A119BR_MedicationID ;
      private long AV25count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK342 ;
      private bool n125BR_Medication_RXUnit ;
      private bool n121BR_Medication_RXName ;
      private String AV24OptionIndexesJson ;
      private String AV19OptionsJson ;
      private String AV22OptionsDescJson ;
      private String AV15DDOName ;
      private String AV13SearchTxt ;
      private String AV14SearchTxtTo ;
      private String AV31BR_Medication_RXName ;
      private String AV11TFBR_Medication_RXUnit ;
      private String AV12TFBR_Medication_RXUnit_Sel ;
      private String lV31BR_Medication_RXName ;
      private String lV11TFBR_Medication_RXUnit ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV17Option ;
      private IGxSession AV26Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00342_A19BR_EncounterID ;
      private String[] P00342_A125BR_Medication_RXUnit ;
      private bool[] P00342_n125BR_Medication_RXUnit ;
      private String[] P00342_A121BR_Medication_RXName ;
      private bool[] P00342_n121BR_Medication_RXName ;
      private long[] P00342_A119BR_MedicationID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV18Options ;
      private GxSimpleCollection<String> AV21OptionsDesc ;
      private GxSimpleCollection<String> AV23OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV28GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV29GridStateFilterValue ;
   }

   public class br_medicationpromptgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00342( IGxContext context ,
                                             String AV31BR_Medication_RXName ,
                                             String AV12TFBR_Medication_RXUnit_Sel ,
                                             String AV11TFBR_Medication_RXUnit ,
                                             String A121BR_Medication_RXName ,
                                             String A125BR_Medication_RXUnit ,
                                             long A19BR_EncounterID ,
                                             long AV32BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [4] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_EncounterID], [BR_Medication_RXUnit], [BR_Medication_RXName], [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV32BR_EncounterID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV31BR_Medication_RXName)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXName] like '%' + @lV31BR_Medication_RXName + '%')";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] like @lV11TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] = @AV12TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_RXUnit]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00342(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP00342 ;
          prmP00342 = new Object[] {
          new Object[] {"@AV32BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV31BR_Medication_RXName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV11TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00342", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00342,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_medicationpromptgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_medicationpromptgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("br_medicationpromptgetfilterdata") )
          {
             return  ;
          }
          br_medicationpromptgetfilterdata worker = new br_medicationpromptgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
