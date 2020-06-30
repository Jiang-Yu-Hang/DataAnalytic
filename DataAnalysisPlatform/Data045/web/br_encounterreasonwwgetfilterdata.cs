/*
               File: BR_EncounterReasonWWGetFilterData
        Description: BR_Encounter Reason WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:7.2
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
   public class br_encounterreasonwwgetfilterdata : GXProcedure
   {
      public br_encounterreasonwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterreasonwwgetfilterdata( IGxContext context )
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
         this.AV26DDOName = aP0_DDOName;
         this.AV24SearchTxt = aP1_SearchTxt;
         this.AV25SearchTxtTo = aP2_SearchTxtTo;
         this.AV30OptionsJson = "" ;
         this.AV33OptionsDescJson = "" ;
         this.AV35OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV30OptionsJson;
         aP4_OptionsDescJson=this.AV33OptionsDescJson;
         aP5_OptionIndexesJson=this.AV35OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV26DDOName = aP0_DDOName;
         this.AV24SearchTxt = aP1_SearchTxt;
         this.AV25SearchTxtTo = aP2_SearchTxtTo;
         this.AV30OptionsJson = "" ;
         this.AV33OptionsDescJson = "" ;
         this.AV35OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV30OptionsJson;
         aP4_OptionsDescJson=this.AV33OptionsDescJson;
         aP5_OptionIndexesJson=this.AV35OptionIndexesJson;
         return AV35OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_encounterreasonwwgetfilterdata objbr_encounterreasonwwgetfilterdata;
         objbr_encounterreasonwwgetfilterdata = new br_encounterreasonwwgetfilterdata();
         objbr_encounterreasonwwgetfilterdata.AV26DDOName = aP0_DDOName;
         objbr_encounterreasonwwgetfilterdata.AV24SearchTxt = aP1_SearchTxt;
         objbr_encounterreasonwwgetfilterdata.AV25SearchTxtTo = aP2_SearchTxtTo;
         objbr_encounterreasonwwgetfilterdata.AV30OptionsJson = "" ;
         objbr_encounterreasonwwgetfilterdata.AV33OptionsDescJson = "" ;
         objbr_encounterreasonwwgetfilterdata.AV35OptionIndexesJson = "" ;
         objbr_encounterreasonwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encounterreasonwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encounterreasonwwgetfilterdata);
         aP3_OptionsJson=this.AV30OptionsJson;
         aP4_OptionsDescJson=this.AV33OptionsDescJson;
         aP5_OptionIndexesJson=this.AV35OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encounterreasonwwgetfilterdata)stateInfo).executePrivate();
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
         AV29Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV32OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV34OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_EncounterReason", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV26DDOName), "DDO_BR_ENCOUNTERREASON_REASON") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTERREASON_REASONOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV26DDOName), "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTERREASON_ISRANDAPPROVEROPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV30OptionsJson = AV29Options.ToJSonString(false);
         AV33OptionsDescJson = AV32OptionsDesc.ToJSonString(false);
         AV35OptionIndexesJson = AV34OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV37Session.Get("BR_EncounterReasonWWGridState"), "") == 0 )
         {
            AV39GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EncounterReasonWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV39GridState.FromXml(AV37Session.Get("BR_EncounterReasonWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV44GXV1 = 1;
         while ( AV44GXV1 <= AV39GridState.gxTpr_Filtervalues.Count )
         {
            AV40GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV39GridState.gxTpr_Filtervalues.Item(AV44GXV1));
            if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_ID") == 0 )
            {
               AV11TFBR_Encounter_ID = (long)(NumberUtil.Val( AV40GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Encounter_ID_To = (long)(NumberUtil.Val( AV40GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV40GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV40GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_REASON") == 0 )
            {
               AV15TFBR_EncounterReason_Reason = AV40GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_REASON_SEL") == 0 )
            {
               AV16TFBR_EncounterReason_Reason_Sel = AV40GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE") == 0 )
            {
               AV17TFBR_EncounterReason_IsRandNoApproveDate = context.localUtil.CToT( AV40GridStateFilterValue.gxTpr_Value, 0);
               AV18TFBR_EncounterReason_IsRandNoApproveDate_To = context.localUtil.CToT( AV40GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_ISRANDAPPROVE_SEL") == 0 )
            {
               AV19TFBR_EncounterReason_IsRandApprove_Sel = (short)(NumberUtil.Val( AV40GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_STATUS_SEL") == 0 )
            {
               AV20TFBR_EncounterReason_Status_SelsJson = AV40GridStateFilterValue.gxTpr_Value;
               AV21TFBR_EncounterReason_Status_Sels.FromJSonString(AV20TFBR_EncounterReason_Status_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_ISRANDAPPROVER") == 0 )
            {
               AV22TFBR_EncounterReason_IsRandApprover = AV40GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV40GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERREASON_ISRANDAPPROVER_SEL") == 0 )
            {
               AV23TFBR_EncounterReason_IsRandApprover_Sel = AV40GridStateFilterValue.gxTpr_Value;
            }
            AV44GXV1 = (int)(AV44GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_ENCOUNTERREASON_REASONOPTIONS' Routine */
         AV15TFBR_EncounterReason_Reason = AV24SearchTxt;
         AV16TFBR_EncounterReason_Reason_Sel = "";
         AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id = AV11TFBR_Encounter_ID;
         AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to = AV12TFBR_Encounter_ID_To;
         AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = AV15TFBR_EncounterReason_Reason;
         AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel = AV16TFBR_EncounterReason_Reason_Sel;
         AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate = AV17TFBR_EncounterReason_IsRandNoApproveDate;
         AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to = AV18TFBR_EncounterReason_IsRandNoApproveDate_To;
         AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel = AV19TFBR_EncounterReason_IsRandApprove_Sel;
         AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels = AV21TFBR_EncounterReason_Status_Sels;
         AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = AV22TFBR_EncounterReason_IsRandApprover;
         AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel = AV23TFBR_EncounterReason_IsRandApprover_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A343BR_EncounterReason_Status ,
                                              AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels ,
                                              AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id ,
                                              AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to ,
                                              AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid ,
                                              AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to ,
                                              AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel ,
                                              AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ,
                                              AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate ,
                                              AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to ,
                                              AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel ,
                                              AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels.Count ,
                                              AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel ,
                                              AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ,
                                              A347BR_Encounter_ID ,
                                              A19BR_EncounterID ,
                                              A340BR_EncounterReason_Reason ,
                                              A341BR_EncounterReason_IsRandNoApproveDate ,
                                              A342BR_EncounterReason_IsRandApprove ,
                                              A344BR_EncounterReason_IsRandApprover } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.SHORT, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = StringUtil.Concat( StringUtil.RTrim( AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason), "%", "");
         lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = StringUtil.Concat( StringUtil.RTrim( AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover), "%", "");
         /* Using cursor P00392 */
         pr_default.execute(0, new Object[] {AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id, AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to, AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid, AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to, lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason, AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel, AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate, AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to, lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover, AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK392 = false;
            A340BR_EncounterReason_Reason = P00392_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = P00392_n340BR_EncounterReason_Reason[0];
            A344BR_EncounterReason_IsRandApprover = P00392_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = P00392_n344BR_EncounterReason_IsRandApprover[0];
            A343BR_EncounterReason_Status = P00392_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = P00392_n343BR_EncounterReason_Status[0];
            A342BR_EncounterReason_IsRandApprove = P00392_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = P00392_n342BR_EncounterReason_IsRandApprove[0];
            A341BR_EncounterReason_IsRandNoApproveDate = P00392_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = P00392_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A19BR_EncounterID = P00392_A19BR_EncounterID[0];
            A347BR_Encounter_ID = P00392_A347BR_Encounter_ID[0];
            AV36count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00392_A340BR_EncounterReason_Reason[0], A340BR_EncounterReason_Reason) == 0 ) )
            {
               BRK392 = false;
               A347BR_Encounter_ID = P00392_A347BR_Encounter_ID[0];
               AV36count = (long)(AV36count+1);
               BRK392 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A340BR_EncounterReason_Reason)) )
            {
               AV28Option = A340BR_EncounterReason_Reason;
               AV29Options.Add(AV28Option, 0);
               AV34OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV36count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV29Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK392 )
            {
               BRK392 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_ENCOUNTERREASON_ISRANDAPPROVEROPTIONS' Routine */
         AV22TFBR_EncounterReason_IsRandApprover = AV24SearchTxt;
         AV23TFBR_EncounterReason_IsRandApprover_Sel = "";
         AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id = AV11TFBR_Encounter_ID;
         AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to = AV12TFBR_Encounter_ID_To;
         AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = AV15TFBR_EncounterReason_Reason;
         AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel = AV16TFBR_EncounterReason_Reason_Sel;
         AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate = AV17TFBR_EncounterReason_IsRandNoApproveDate;
         AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to = AV18TFBR_EncounterReason_IsRandNoApproveDate_To;
         AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel = AV19TFBR_EncounterReason_IsRandApprove_Sel;
         AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels = AV21TFBR_EncounterReason_Status_Sels;
         AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = AV22TFBR_EncounterReason_IsRandApprover;
         AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel = AV23TFBR_EncounterReason_IsRandApprover_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A343BR_EncounterReason_Status ,
                                              AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels ,
                                              AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id ,
                                              AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to ,
                                              AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid ,
                                              AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to ,
                                              AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel ,
                                              AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ,
                                              AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate ,
                                              AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to ,
                                              AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel ,
                                              AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels.Count ,
                                              AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel ,
                                              AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ,
                                              A347BR_Encounter_ID ,
                                              A19BR_EncounterID ,
                                              A340BR_EncounterReason_Reason ,
                                              A341BR_EncounterReason_IsRandNoApproveDate ,
                                              A342BR_EncounterReason_IsRandApprove ,
                                              A344BR_EncounterReason_IsRandApprover } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.SHORT, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = StringUtil.Concat( StringUtil.RTrim( AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason), "%", "");
         lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = StringUtil.Concat( StringUtil.RTrim( AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover), "%", "");
         /* Using cursor P00393 */
         pr_default.execute(1, new Object[] {AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id, AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to, AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid, AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to, lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason, AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel, AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate, AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to, lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover, AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK394 = false;
            A344BR_EncounterReason_IsRandApprover = P00393_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = P00393_n344BR_EncounterReason_IsRandApprover[0];
            A343BR_EncounterReason_Status = P00393_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = P00393_n343BR_EncounterReason_Status[0];
            A342BR_EncounterReason_IsRandApprove = P00393_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = P00393_n342BR_EncounterReason_IsRandApprove[0];
            A341BR_EncounterReason_IsRandNoApproveDate = P00393_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = P00393_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A340BR_EncounterReason_Reason = P00393_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = P00393_n340BR_EncounterReason_Reason[0];
            A19BR_EncounterID = P00393_A19BR_EncounterID[0];
            A347BR_Encounter_ID = P00393_A347BR_Encounter_ID[0];
            AV36count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00393_A344BR_EncounterReason_IsRandApprover[0], A344BR_EncounterReason_IsRandApprover) == 0 ) )
            {
               BRK394 = false;
               A347BR_Encounter_ID = P00393_A347BR_Encounter_ID[0];
               AV36count = (long)(AV36count+1);
               BRK394 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A344BR_EncounterReason_IsRandApprover)) )
            {
               AV28Option = A344BR_EncounterReason_IsRandApprover;
               AV29Options.Add(AV28Option, 0);
               AV34OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV36count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV29Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK394 )
            {
               BRK394 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
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
         AV29Options = new GxSimpleCollection<String>();
         AV32OptionsDesc = new GxSimpleCollection<String>();
         AV34OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV37Session = context.GetSession();
         AV39GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV40GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_EncounterReason_Reason = "";
         AV16TFBR_EncounterReason_Reason_Sel = "";
         AV17TFBR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         AV18TFBR_EncounterReason_IsRandNoApproveDate_To = (DateTime)(DateTime.MinValue);
         AV20TFBR_EncounterReason_Status_SelsJson = "";
         AV21TFBR_EncounterReason_Status_Sels = new GxSimpleCollection<short>();
         AV22TFBR_EncounterReason_IsRandApprover = "";
         AV23TFBR_EncounterReason_IsRandApprover_Sel = "";
         AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = "";
         AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel = "";
         AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate = (DateTime)(DateTime.MinValue);
         AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to = (DateTime)(DateTime.MinValue);
         AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels = new GxSimpleCollection<short>();
         AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = "";
         AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel = "";
         scmdbuf = "";
         lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason = "";
         lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover = "";
         A340BR_EncounterReason_Reason = "";
         A341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         A344BR_EncounterReason_IsRandApprover = "";
         P00392_A340BR_EncounterReason_Reason = new String[] {""} ;
         P00392_n340BR_EncounterReason_Reason = new bool[] {false} ;
         P00392_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         P00392_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         P00392_A343BR_EncounterReason_Status = new short[1] ;
         P00392_n343BR_EncounterReason_Status = new bool[] {false} ;
         P00392_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         P00392_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         P00392_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         P00392_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         P00392_A19BR_EncounterID = new long[1] ;
         P00392_A347BR_Encounter_ID = new long[1] ;
         AV28Option = "";
         P00393_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         P00393_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         P00393_A343BR_EncounterReason_Status = new short[1] ;
         P00393_n343BR_EncounterReason_Status = new bool[] {false} ;
         P00393_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         P00393_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         P00393_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         P00393_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         P00393_A340BR_EncounterReason_Reason = new String[] {""} ;
         P00393_n340BR_EncounterReason_Reason = new bool[] {false} ;
         P00393_A19BR_EncounterID = new long[1] ;
         P00393_A347BR_Encounter_ID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterreasonwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00392_A340BR_EncounterReason_Reason, P00392_n340BR_EncounterReason_Reason, P00392_A344BR_EncounterReason_IsRandApprover, P00392_n344BR_EncounterReason_IsRandApprover, P00392_A343BR_EncounterReason_Status, P00392_n343BR_EncounterReason_Status, P00392_A342BR_EncounterReason_IsRandApprove, P00392_n342BR_EncounterReason_IsRandApprove, P00392_A341BR_EncounterReason_IsRandNoApproveDate, P00392_n341BR_EncounterReason_IsRandNoApproveDate,
               P00392_A19BR_EncounterID, P00392_A347BR_Encounter_ID
               }
               , new Object[] {
               P00393_A344BR_EncounterReason_IsRandApprover, P00393_n344BR_EncounterReason_IsRandApprover, P00393_A343BR_EncounterReason_Status, P00393_n343BR_EncounterReason_Status, P00393_A342BR_EncounterReason_IsRandApprove, P00393_n342BR_EncounterReason_IsRandApprove, P00393_A341BR_EncounterReason_IsRandNoApproveDate, P00393_n341BR_EncounterReason_IsRandNoApproveDate, P00393_A340BR_EncounterReason_Reason, P00393_n340BR_EncounterReason_Reason,
               P00393_A19BR_EncounterID, P00393_A347BR_Encounter_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV19TFBR_EncounterReason_IsRandApprove_Sel ;
      private short AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel ;
      private short A343BR_EncounterReason_Status ;
      private int AV44GXV1 ;
      private int AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels_Count ;
      private long AV11TFBR_Encounter_ID ;
      private long AV12TFBR_Encounter_ID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id ;
      private long AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to ;
      private long AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid ;
      private long AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to ;
      private long A347BR_Encounter_ID ;
      private long A19BR_EncounterID ;
      private long AV36count ;
      private String scmdbuf ;
      private DateTime AV17TFBR_EncounterReason_IsRandNoApproveDate ;
      private DateTime AV18TFBR_EncounterReason_IsRandNoApproveDate_To ;
      private DateTime AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate ;
      private DateTime AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to ;
      private DateTime A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool A342BR_EncounterReason_IsRandApprove ;
      private bool BRK392 ;
      private bool n340BR_EncounterReason_Reason ;
      private bool n344BR_EncounterReason_IsRandApprover ;
      private bool n343BR_EncounterReason_Status ;
      private bool n342BR_EncounterReason_IsRandApprove ;
      private bool n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool BRK394 ;
      private String AV35OptionIndexesJson ;
      private String AV30OptionsJson ;
      private String AV33OptionsDescJson ;
      private String AV20TFBR_EncounterReason_Status_SelsJson ;
      private String AV26DDOName ;
      private String AV24SearchTxt ;
      private String AV25SearchTxtTo ;
      private String AV15TFBR_EncounterReason_Reason ;
      private String AV16TFBR_EncounterReason_Reason_Sel ;
      private String AV22TFBR_EncounterReason_IsRandApprover ;
      private String AV23TFBR_EncounterReason_IsRandApprover_Sel ;
      private String AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ;
      private String AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel ;
      private String AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ;
      private String AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel ;
      private String lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ;
      private String lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ;
      private String A340BR_EncounterReason_Reason ;
      private String A344BR_EncounterReason_IsRandApprover ;
      private String AV28Option ;
      private GxSimpleCollection<short> AV21TFBR_EncounterReason_Status_Sels ;
      private GxSimpleCollection<short> AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels ;
      private IGxSession AV37Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00392_A340BR_EncounterReason_Reason ;
      private bool[] P00392_n340BR_EncounterReason_Reason ;
      private String[] P00392_A344BR_EncounterReason_IsRandApprover ;
      private bool[] P00392_n344BR_EncounterReason_IsRandApprover ;
      private short[] P00392_A343BR_EncounterReason_Status ;
      private bool[] P00392_n343BR_EncounterReason_Status ;
      private bool[] P00392_A342BR_EncounterReason_IsRandApprove ;
      private bool[] P00392_n342BR_EncounterReason_IsRandApprove ;
      private DateTime[] P00392_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] P00392_n341BR_EncounterReason_IsRandNoApproveDate ;
      private long[] P00392_A19BR_EncounterID ;
      private long[] P00392_A347BR_Encounter_ID ;
      private String[] P00393_A344BR_EncounterReason_IsRandApprover ;
      private bool[] P00393_n344BR_EncounterReason_IsRandApprover ;
      private short[] P00393_A343BR_EncounterReason_Status ;
      private bool[] P00393_n343BR_EncounterReason_Status ;
      private bool[] P00393_A342BR_EncounterReason_IsRandApprove ;
      private bool[] P00393_n342BR_EncounterReason_IsRandApprove ;
      private DateTime[] P00393_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] P00393_n341BR_EncounterReason_IsRandNoApproveDate ;
      private String[] P00393_A340BR_EncounterReason_Reason ;
      private bool[] P00393_n340BR_EncounterReason_Reason ;
      private long[] P00393_A19BR_EncounterID ;
      private long[] P00393_A347BR_Encounter_ID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV29Options ;
      private GxSimpleCollection<String> AV32OptionsDesc ;
      private GxSimpleCollection<String> AV34OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV39GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV40GridStateFilterValue ;
   }

   public class br_encounterreasonwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00392( IGxContext context ,
                                             short A343BR_EncounterReason_Status ,
                                             GxSimpleCollection<short> AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels ,
                                             long AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id ,
                                             long AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to ,
                                             long AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid ,
                                             long AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to ,
                                             String AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel ,
                                             String AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ,
                                             DateTime AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate ,
                                             DateTime AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to ,
                                             short AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel ,
                                             int AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels_Count ,
                                             String AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel ,
                                             String AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ,
                                             long A347BR_Encounter_ID ,
                                             long A19BR_EncounterID ,
                                             String A340BR_EncounterReason_Reason ,
                                             DateTime A341BR_EncounterReason_IsRandNoApproveDate ,
                                             bool A342BR_EncounterReason_IsRandApprove ,
                                             String A344BR_EncounterReason_IsRandApprover )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [10] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_EncounterReason_Reason], [BR_EncounterReason_IsRandApprover], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterID], [BR_Encounter_ID] FROM [BR_EncounterReason] WITH (NOLOCK)";
         if ( ! (0==AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_ID] >= @AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_ID] >= @AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_ID] <= @AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_ID] <= @AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_Reason] like @lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_Reason] like @lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_Reason] = @AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_Reason] = @AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandNoApproveDate] >= @AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandNoApproveDate] >= @AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandNoApproveDate] <= @AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandNoApproveDate] <= @AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprove] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprove] = 1)";
            }
         }
         if ( AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprove] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprove] = 0)";
            }
         }
         if ( AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels, "[BR_EncounterReason_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels, "[BR_EncounterReason_Status] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprover] like @lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprover] like @lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprover] = @AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprover] = @AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_EncounterReason_Reason]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00393( IGxContext context ,
                                             short A343BR_EncounterReason_Status ,
                                             GxSimpleCollection<short> AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels ,
                                             long AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id ,
                                             long AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to ,
                                             long AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid ,
                                             long AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to ,
                                             String AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel ,
                                             String AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason ,
                                             DateTime AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate ,
                                             DateTime AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to ,
                                             short AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel ,
                                             int AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels_Count ,
                                             String AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel ,
                                             String AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover ,
                                             long A347BR_Encounter_ID ,
                                             long A19BR_EncounterID ,
                                             String A340BR_EncounterReason_Reason ,
                                             DateTime A341BR_EncounterReason_IsRandNoApproveDate ,
                                             bool A342BR_EncounterReason_IsRandApprove ,
                                             String A344BR_EncounterReason_IsRandApprover )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [10] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_EncounterReason_IsRandApprover], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterReason_Reason], [BR_EncounterID], [BR_Encounter_ID] FROM [BR_EncounterReason] WITH (NOLOCK)";
         if ( ! (0==AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_ID] >= @AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_ID] >= @AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_ID] <= @AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_ID] <= @AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_Reason] like @lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_Reason] like @lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_Reason] = @AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_Reason] = @AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandNoApproveDate] >= @AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandNoApproveDate] >= @AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandNoApproveDate] <= @AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandNoApproveDate] <= @AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprove] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprove] = 1)";
            }
         }
         if ( AV54BR_EncounterReasonWWDS_9_Tfbr_encounterreason_israndapprove_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprove] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprove] = 0)";
            }
         }
         if ( AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels, "[BR_EncounterReason_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV55BR_EncounterReasonWWDS_10_Tfbr_encounterreason_status_sels, "[BR_EncounterReason_Status] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprover] like @lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprover] like @lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterReason_IsRandApprover] = @AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterReason_IsRandApprover] = @AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_EncounterReason_IsRandApprover]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00392(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (bool)dynConstraints[18] , (String)dynConstraints[19] );
               case 1 :
                     return conditional_P00393(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (bool)dynConstraints[18] , (String)dynConstraints[19] );
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
          Object[] prmP00392 ;
          prmP00392 = new Object[] {
          new Object[] {"@AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id",SqlDbType.Decimal,15,0} ,
          new Object[] {"@AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to",SqlDbType.Decimal,15,0} ,
          new Object[] {"@AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP00393 ;
          prmP00393 = new Object[] {
          new Object[] {"@AV46BR_EncounterReasonWWDS_1_Tfbr_encounter_id",SqlDbType.Decimal,15,0} ,
          new Object[] {"@AV47BR_EncounterReasonWWDS_2_Tfbr_encounter_id_to",SqlDbType.Decimal,15,0} ,
          new Object[] {"@AV48BR_EncounterReasonWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_EncounterReasonWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV50BR_EncounterReasonWWDS_5_Tfbr_encounterreason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV51BR_EncounterReasonWWDS_6_Tfbr_encounterreason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV52BR_EncounterReasonWWDS_7_Tfbr_encounterreason_israndnoapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV53BR_EncounterReasonWWDS_8_Tfbr_encounterreason_israndnoapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV56BR_EncounterReasonWWDS_11_Tfbr_encounterreason_israndapprover",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_EncounterReasonWWDS_12_Tfbr_encounterreason_israndapprover_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00392", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00392,100,0,true,false )
             ,new CursorDef("P00393", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00393,100,0,true,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((bool[]) buf[6])[0] = rslt.getBool(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((bool[]) buf[4])[0] = rslt.getBool(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_encounterreasonwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encounterreasonwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encounterreasonwwgetfilterdata") )
          {
             return  ;
          }
          br_encounterreasonwwgetfilterdata worker = new br_encounterreasonwwgetfilterdata(context) ;
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
