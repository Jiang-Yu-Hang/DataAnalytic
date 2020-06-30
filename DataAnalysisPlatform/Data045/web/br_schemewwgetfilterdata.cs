/*
               File: BR_SchemeWWGetFilterData
        Description: BR_Scheme WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:4.13
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
   public class br_schemewwgetfilterdata : GXProcedure
   {
      public br_schemewwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_schemewwgetfilterdata( IGxContext context )
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
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
         return AV34OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_schemewwgetfilterdata objbr_schemewwgetfilterdata;
         objbr_schemewwgetfilterdata = new br_schemewwgetfilterdata();
         objbr_schemewwgetfilterdata.AV25DDOName = aP0_DDOName;
         objbr_schemewwgetfilterdata.AV23SearchTxt = aP1_SearchTxt;
         objbr_schemewwgetfilterdata.AV24SearchTxtTo = aP2_SearchTxtTo;
         objbr_schemewwgetfilterdata.AV29OptionsJson = "" ;
         objbr_schemewwgetfilterdata.AV32OptionsDescJson = "" ;
         objbr_schemewwgetfilterdata.AV34OptionIndexesJson = "" ;
         objbr_schemewwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_schemewwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_schemewwgetfilterdata);
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_schemewwgetfilterdata)stateInfo).executePrivate();
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
         AV28Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_SCHEME_THERAPY_LINE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_SCHEME_THERAPY_LINEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_SCHEME_CHEM_DETAIL") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_SCHEME_CHEM_DETAILOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV29OptionsJson = AV28Options.ToJSonString(false);
         AV32OptionsDescJson = AV31OptionsDesc.ToJSonString(false);
         AV34OptionIndexesJson = AV33OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV36Session.Get("BR_SchemeWWGridState"), "") == 0 )
         {
            AV38GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_SchemeWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV38GridState.FromXml(AV36Session.Get("BR_SchemeWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV43GXV1 = 1;
         while ( AV43GXV1 <= AV38GridState.gxTpr_Filtervalues.Count )
         {
            AV39GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV38GridState.gxTpr_Filtervalues.Item(AV43GXV1));
            if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEMEID") == 0 )
            {
               AV11TFBR_SchemeID = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_SchemeID_To = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV15TFBR_Scheme_Chem_Regimens = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV16TFBR_Scheme_Chem_Regimens_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_THERAPY_LINE") == 0 )
            {
               AV17TFBR_Scheme_Therapy_Line = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_THERAPY_LINE_SEL") == 0 )
            {
               AV18TFBR_Scheme_Therapy_Line_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_CYCLE") == 0 )
            {
               AV19TFBR_Scheme_Chem_Cycle = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, ".");
               AV20TFBR_Scheme_Chem_Cycle_To = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_DETAIL") == 0 )
            {
               AV21TFBR_Scheme_Chem_Detail = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_DETAIL_SEL") == 0 )
            {
               AV22TFBR_Scheme_Chem_Detail_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            AV43GXV1 = (int)(AV43GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' Routine */
         AV15TFBR_Scheme_Chem_Regimens = AV23SearchTxt;
         AV16TFBR_Scheme_Chem_Regimens_Sel = "";
         AV45BR_SchemeWWDS_1_Tfbr_schemeid = AV11TFBR_SchemeID;
         AV46BR_SchemeWWDS_2_Tfbr_schemeid_to = AV12TFBR_SchemeID_To;
         AV47BR_SchemeWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV48BR_SchemeWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV15TFBR_Scheme_Chem_Regimens;
         AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV16TFBR_Scheme_Chem_Regimens_Sel;
         AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV17TFBR_Scheme_Therapy_Line;
         AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV18TFBR_Scheme_Therapy_Line_Sel;
         AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV19TFBR_Scheme_Chem_Cycle;
         AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV20TFBR_Scheme_Chem_Cycle_To;
         AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV21TFBR_Scheme_Chem_Detail;
         AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV22TFBR_Scheme_Chem_Detail_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                              AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                              AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                              AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                              AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                              AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                              AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                              AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                              AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                              AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                              AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                              AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                              A327BR_SchemeID ,
                                              A19BR_EncounterID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A329BR_Scheme_Therapy_Line ,
                                              A330BR_Scheme_Chem_Cycle ,
                                              A331BR_Scheme_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens), "%", "");
         lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = StringUtil.Concat( StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line), "%", "");
         lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail), "%", "");
         /* Using cursor P00302 */
         pr_default.execute(0, new Object[] {AV45BR_SchemeWWDS_1_Tfbr_schemeid, AV46BR_SchemeWWDS_2_Tfbr_schemeid_to, AV47BR_SchemeWWDS_3_Tfbr_encounterid, AV48BR_SchemeWWDS_4_Tfbr_encounterid_to, lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens, AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel, lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line, AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel, AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle, AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to, lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail, AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK302 = false;
            A328BR_Scheme_Chem_Regimens = P00302_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00302_n328BR_Scheme_Chem_Regimens[0];
            A331BR_Scheme_Chem_Detail = P00302_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = P00302_n331BR_Scheme_Chem_Detail[0];
            A330BR_Scheme_Chem_Cycle = P00302_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = P00302_n330BR_Scheme_Chem_Cycle[0];
            A329BR_Scheme_Therapy_Line = P00302_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = P00302_n329BR_Scheme_Therapy_Line[0];
            A19BR_EncounterID = P00302_A19BR_EncounterID[0];
            A327BR_SchemeID = P00302_A327BR_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00302_A328BR_Scheme_Chem_Regimens[0], A328BR_Scheme_Chem_Regimens) == 0 ) )
            {
               BRK302 = false;
               A327BR_SchemeID = P00302_A327BR_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK302 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) )
            {
               AV27Option = A328BR_Scheme_Chem_Regimens;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK302 )
            {
               BRK302 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_SCHEME_THERAPY_LINEOPTIONS' Routine */
         AV17TFBR_Scheme_Therapy_Line = AV23SearchTxt;
         AV18TFBR_Scheme_Therapy_Line_Sel = "";
         AV45BR_SchemeWWDS_1_Tfbr_schemeid = AV11TFBR_SchemeID;
         AV46BR_SchemeWWDS_2_Tfbr_schemeid_to = AV12TFBR_SchemeID_To;
         AV47BR_SchemeWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV48BR_SchemeWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV15TFBR_Scheme_Chem_Regimens;
         AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV16TFBR_Scheme_Chem_Regimens_Sel;
         AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV17TFBR_Scheme_Therapy_Line;
         AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV18TFBR_Scheme_Therapy_Line_Sel;
         AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV19TFBR_Scheme_Chem_Cycle;
         AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV20TFBR_Scheme_Chem_Cycle_To;
         AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV21TFBR_Scheme_Chem_Detail;
         AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV22TFBR_Scheme_Chem_Detail_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                              AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                              AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                              AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                              AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                              AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                              AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                              AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                              AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                              AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                              AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                              AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                              A327BR_SchemeID ,
                                              A19BR_EncounterID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A329BR_Scheme_Therapy_Line ,
                                              A330BR_Scheme_Chem_Cycle ,
                                              A331BR_Scheme_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens), "%", "");
         lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = StringUtil.Concat( StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line), "%", "");
         lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail), "%", "");
         /* Using cursor P00303 */
         pr_default.execute(1, new Object[] {AV45BR_SchemeWWDS_1_Tfbr_schemeid, AV46BR_SchemeWWDS_2_Tfbr_schemeid_to, AV47BR_SchemeWWDS_3_Tfbr_encounterid, AV48BR_SchemeWWDS_4_Tfbr_encounterid_to, lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens, AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel, lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line, AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel, AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle, AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to, lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail, AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK304 = false;
            A329BR_Scheme_Therapy_Line = P00303_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = P00303_n329BR_Scheme_Therapy_Line[0];
            A331BR_Scheme_Chem_Detail = P00303_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = P00303_n331BR_Scheme_Chem_Detail[0];
            A330BR_Scheme_Chem_Cycle = P00303_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = P00303_n330BR_Scheme_Chem_Cycle[0];
            A328BR_Scheme_Chem_Regimens = P00303_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00303_n328BR_Scheme_Chem_Regimens[0];
            A19BR_EncounterID = P00303_A19BR_EncounterID[0];
            A327BR_SchemeID = P00303_A327BR_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00303_A329BR_Scheme_Therapy_Line[0], A329BR_Scheme_Therapy_Line) == 0 ) )
            {
               BRK304 = false;
               A327BR_SchemeID = P00303_A327BR_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK304 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A329BR_Scheme_Therapy_Line)) )
            {
               AV27Option = A329BR_Scheme_Therapy_Line;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK304 )
            {
               BRK304 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_SCHEME_CHEM_DETAILOPTIONS' Routine */
         AV21TFBR_Scheme_Chem_Detail = AV23SearchTxt;
         AV22TFBR_Scheme_Chem_Detail_Sel = "";
         AV45BR_SchemeWWDS_1_Tfbr_schemeid = AV11TFBR_SchemeID;
         AV46BR_SchemeWWDS_2_Tfbr_schemeid_to = AV12TFBR_SchemeID_To;
         AV47BR_SchemeWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV48BR_SchemeWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV15TFBR_Scheme_Chem_Regimens;
         AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV16TFBR_Scheme_Chem_Regimens_Sel;
         AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV17TFBR_Scheme_Therapy_Line;
         AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV18TFBR_Scheme_Therapy_Line_Sel;
         AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV19TFBR_Scheme_Chem_Cycle;
         AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV20TFBR_Scheme_Chem_Cycle_To;
         AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV21TFBR_Scheme_Chem_Detail;
         AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV22TFBR_Scheme_Chem_Detail_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                              AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                              AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                              AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                              AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                              AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                              AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                              AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                              AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                              AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                              AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                              AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                              A327BR_SchemeID ,
                                              A19BR_EncounterID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A329BR_Scheme_Therapy_Line ,
                                              A330BR_Scheme_Chem_Cycle ,
                                              A331BR_Scheme_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens), "%", "");
         lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = StringUtil.Concat( StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line), "%", "");
         lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail), "%", "");
         /* Using cursor P00304 */
         pr_default.execute(2, new Object[] {AV45BR_SchemeWWDS_1_Tfbr_schemeid, AV46BR_SchemeWWDS_2_Tfbr_schemeid_to, AV47BR_SchemeWWDS_3_Tfbr_encounterid, AV48BR_SchemeWWDS_4_Tfbr_encounterid_to, lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens, AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel, lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line, AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel, AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle, AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to, lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail, AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK306 = false;
            A331BR_Scheme_Chem_Detail = P00304_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = P00304_n331BR_Scheme_Chem_Detail[0];
            A330BR_Scheme_Chem_Cycle = P00304_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = P00304_n330BR_Scheme_Chem_Cycle[0];
            A329BR_Scheme_Therapy_Line = P00304_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = P00304_n329BR_Scheme_Therapy_Line[0];
            A328BR_Scheme_Chem_Regimens = P00304_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00304_n328BR_Scheme_Chem_Regimens[0];
            A19BR_EncounterID = P00304_A19BR_EncounterID[0];
            A327BR_SchemeID = P00304_A327BR_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P00304_A331BR_Scheme_Chem_Detail[0], A331BR_Scheme_Chem_Detail) == 0 ) )
            {
               BRK306 = false;
               A327BR_SchemeID = P00304_A327BR_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK306 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A331BR_Scheme_Chem_Detail)) )
            {
               AV27Option = A331BR_Scheme_Chem_Detail;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK306 )
            {
               BRK306 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
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
         AV28Options = new GxSimpleCollection<String>();
         AV31OptionsDesc = new GxSimpleCollection<String>();
         AV33OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36Session = context.GetSession();
         AV38GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV39GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Scheme_Chem_Regimens = "";
         AV16TFBR_Scheme_Chem_Regimens_Sel = "";
         AV17TFBR_Scheme_Therapy_Line = "";
         AV18TFBR_Scheme_Therapy_Line_Sel = "";
         AV21TFBR_Scheme_Chem_Detail = "";
         AV22TFBR_Scheme_Chem_Detail_Sel = "";
         AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = "";
         AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = "";
         AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = "";
         AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = "";
         AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = "";
         AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = "";
         scmdbuf = "";
         lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = "";
         lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = "";
         lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = "";
         A328BR_Scheme_Chem_Regimens = "";
         A329BR_Scheme_Therapy_Line = "";
         A331BR_Scheme_Chem_Detail = "";
         P00302_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00302_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00302_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         P00302_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         P00302_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         P00302_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         P00302_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         P00302_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         P00302_A19BR_EncounterID = new long[1] ;
         P00302_A327BR_SchemeID = new long[1] ;
         AV27Option = "";
         P00303_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         P00303_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         P00303_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         P00303_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         P00303_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         P00303_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         P00303_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00303_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00303_A19BR_EncounterID = new long[1] ;
         P00303_A327BR_SchemeID = new long[1] ;
         P00304_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         P00304_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         P00304_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         P00304_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         P00304_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         P00304_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         P00304_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00304_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00304_A19BR_EncounterID = new long[1] ;
         P00304_A327BR_SchemeID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_schemewwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00302_A328BR_Scheme_Chem_Regimens, P00302_n328BR_Scheme_Chem_Regimens, P00302_A331BR_Scheme_Chem_Detail, P00302_n331BR_Scheme_Chem_Detail, P00302_A330BR_Scheme_Chem_Cycle, P00302_n330BR_Scheme_Chem_Cycle, P00302_A329BR_Scheme_Therapy_Line, P00302_n329BR_Scheme_Therapy_Line, P00302_A19BR_EncounterID, P00302_A327BR_SchemeID
               }
               , new Object[] {
               P00303_A329BR_Scheme_Therapy_Line, P00303_n329BR_Scheme_Therapy_Line, P00303_A331BR_Scheme_Chem_Detail, P00303_n331BR_Scheme_Chem_Detail, P00303_A330BR_Scheme_Chem_Cycle, P00303_n330BR_Scheme_Chem_Cycle, P00303_A328BR_Scheme_Chem_Regimens, P00303_n328BR_Scheme_Chem_Regimens, P00303_A19BR_EncounterID, P00303_A327BR_SchemeID
               }
               , new Object[] {
               P00304_A331BR_Scheme_Chem_Detail, P00304_n331BR_Scheme_Chem_Detail, P00304_A330BR_Scheme_Chem_Cycle, P00304_n330BR_Scheme_Chem_Cycle, P00304_A329BR_Scheme_Therapy_Line, P00304_n329BR_Scheme_Therapy_Line, P00304_A328BR_Scheme_Chem_Regimens, P00304_n328BR_Scheme_Chem_Regimens, P00304_A19BR_EncounterID, P00304_A327BR_SchemeID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV43GXV1 ;
      private long AV11TFBR_SchemeID ;
      private long AV12TFBR_SchemeID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV45BR_SchemeWWDS_1_Tfbr_schemeid ;
      private long AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ;
      private long AV47BR_SchemeWWDS_3_Tfbr_encounterid ;
      private long AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ;
      private long A327BR_SchemeID ;
      private long A19BR_EncounterID ;
      private long AV35count ;
      private decimal AV19TFBR_Scheme_Chem_Cycle ;
      private decimal AV20TFBR_Scheme_Chem_Cycle_To ;
      private decimal AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ;
      private decimal AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ;
      private decimal A330BR_Scheme_Chem_Cycle ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK302 ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n331BR_Scheme_Chem_Detail ;
      private bool n330BR_Scheme_Chem_Cycle ;
      private bool n329BR_Scheme_Therapy_Line ;
      private bool BRK304 ;
      private bool BRK306 ;
      private String AV34OptionIndexesJson ;
      private String AV29OptionsJson ;
      private String AV32OptionsDescJson ;
      private String AV25DDOName ;
      private String AV23SearchTxt ;
      private String AV24SearchTxtTo ;
      private String AV15TFBR_Scheme_Chem_Regimens ;
      private String AV16TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV17TFBR_Scheme_Therapy_Line ;
      private String AV18TFBR_Scheme_Therapy_Line_Sel ;
      private String AV21TFBR_Scheme_Chem_Detail ;
      private String AV22TFBR_Scheme_Chem_Detail_Sel ;
      private String AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ;
      private String AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ;
      private String AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ;
      private String AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ;
      private String AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ;
      private String AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ;
      private String lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ;
      private String lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ;
      private String lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A329BR_Scheme_Therapy_Line ;
      private String A331BR_Scheme_Chem_Detail ;
      private String AV27Option ;
      private IGxSession AV36Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00302_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00302_n328BR_Scheme_Chem_Regimens ;
      private String[] P00302_A331BR_Scheme_Chem_Detail ;
      private bool[] P00302_n331BR_Scheme_Chem_Detail ;
      private decimal[] P00302_A330BR_Scheme_Chem_Cycle ;
      private bool[] P00302_n330BR_Scheme_Chem_Cycle ;
      private String[] P00302_A329BR_Scheme_Therapy_Line ;
      private bool[] P00302_n329BR_Scheme_Therapy_Line ;
      private long[] P00302_A19BR_EncounterID ;
      private long[] P00302_A327BR_SchemeID ;
      private String[] P00303_A329BR_Scheme_Therapy_Line ;
      private bool[] P00303_n329BR_Scheme_Therapy_Line ;
      private String[] P00303_A331BR_Scheme_Chem_Detail ;
      private bool[] P00303_n331BR_Scheme_Chem_Detail ;
      private decimal[] P00303_A330BR_Scheme_Chem_Cycle ;
      private bool[] P00303_n330BR_Scheme_Chem_Cycle ;
      private String[] P00303_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00303_n328BR_Scheme_Chem_Regimens ;
      private long[] P00303_A19BR_EncounterID ;
      private long[] P00303_A327BR_SchemeID ;
      private String[] P00304_A331BR_Scheme_Chem_Detail ;
      private bool[] P00304_n331BR_Scheme_Chem_Detail ;
      private decimal[] P00304_A330BR_Scheme_Chem_Cycle ;
      private bool[] P00304_n330BR_Scheme_Chem_Cycle ;
      private String[] P00304_A329BR_Scheme_Therapy_Line ;
      private bool[] P00304_n329BR_Scheme_Therapy_Line ;
      private String[] P00304_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00304_n328BR_Scheme_Chem_Regimens ;
      private long[] P00304_A19BR_EncounterID ;
      private long[] P00304_A327BR_SchemeID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV28Options ;
      private GxSimpleCollection<String> AV31OptionsDesc ;
      private GxSimpleCollection<String> AV33OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV38GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV39GridStateFilterValue ;
   }

   public class br_schemewwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00302( IGxContext context ,
                                             long AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                             long AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                             long AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                             long AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                             String AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                             String AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                             String AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                             String AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                             decimal AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                             decimal AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                             String AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                             String AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                             long A327BR_SchemeID ,
                                             long A19BR_EncounterID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A329BR_Scheme_Therapy_Line ,
                                             decimal A330BR_Scheme_Chem_Cycle ,
                                             String A331BR_Scheme_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [12] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Scheme_Chem_Regimens], [BR_Scheme_Chem_Detail], [BR_Scheme_Chem_Cycle], [BR_Scheme_Therapy_Line], [BR_EncounterID], [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV45BR_SchemeWWDS_1_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV46BR_SchemeWWDS_2_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV47BR_SchemeWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV48BR_SchemeWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Scheme_Chem_Regimens]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00303( IGxContext context ,
                                             long AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                             long AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                             long AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                             long AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                             String AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                             String AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                             String AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                             String AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                             decimal AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                             decimal AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                             String AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                             String AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                             long A327BR_SchemeID ,
                                             long A19BR_EncounterID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A329BR_Scheme_Therapy_Line ,
                                             decimal A330BR_Scheme_Chem_Cycle ,
                                             String A331BR_Scheme_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Detail], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Regimens], [BR_EncounterID], [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV45BR_SchemeWWDS_1_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV46BR_SchemeWWDS_2_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV47BR_SchemeWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV48BR_SchemeWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Scheme_Therapy_Line]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P00304( IGxContext context ,
                                             long AV45BR_SchemeWWDS_1_Tfbr_schemeid ,
                                             long AV46BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                             long AV47BR_SchemeWWDS_3_Tfbr_encounterid ,
                                             long AV48BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                             String AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                             String AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                             String AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                             String AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                             decimal AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                             decimal AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                             String AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                             String AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                             long A327BR_SchemeID ,
                                             long A19BR_EncounterID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A329BR_Scheme_Therapy_Line ,
                                             decimal A330BR_Scheme_Chem_Cycle ,
                                             String A331BR_Scheme_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [12] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_Scheme_Chem_Detail], [BR_Scheme_Chem_Cycle], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Regimens], [BR_EncounterID], [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV45BR_SchemeWWDS_1_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] >= @AV45BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV46BR_SchemeWWDS_2_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] <= @AV46BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV47BR_SchemeWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV47BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV48BR_SchemeWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV48BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] like @lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] = @AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] like @lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] = @AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] >= @AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] <= @AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] like @lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] = @AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Scheme_Chem_Detail]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00302(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (decimal)dynConstraints[16] , (String)dynConstraints[17] );
               case 1 :
                     return conditional_P00303(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (decimal)dynConstraints[16] , (String)dynConstraints[17] );
               case 2 :
                     return conditional_P00304(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (decimal)dynConstraints[16] , (String)dynConstraints[17] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00302 ;
          prmP00302 = new Object[] {
          new Object[] {"@AV45BR_SchemeWWDS_1_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_SchemeWWDS_2_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_SchemeWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_SchemeWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP00303 ;
          prmP00303 = new Object[] {
          new Object[] {"@AV45BR_SchemeWWDS_1_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_SchemeWWDS_2_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_SchemeWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_SchemeWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP00304 ;
          prmP00304 = new Object[] {
          new Object[] {"@AV45BR_SchemeWWDS_1_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_SchemeWWDS_2_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_SchemeWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_SchemeWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_SchemeWWDS_7_Tfbr_scheme_therapy_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV52BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV53BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV54BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV55BR_SchemeWWDS_11_Tfbr_scheme_chem_detail",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00302", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00302,100,0,true,false )
             ,new CursorDef("P00303", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00303,100,0,true,false )
             ,new CursorDef("P00304", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00304,100,0,true,false )
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
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_schemewwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_schemewwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_schemewwgetfilterdata") )
          {
             return  ;
          }
          br_schemewwgetfilterdata worker = new br_schemewwgetfilterdata(context) ;
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
