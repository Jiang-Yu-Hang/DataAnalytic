/*
               File: BR_EnteringSubmitDetailGetFilterData
        Description: BR_Entering Submit Detail Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:40.68
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
   public class br_enteringsubmitdetailgetfilterdata : GXProcedure
   {
      public br_enteringsubmitdetailgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_enteringsubmitdetailgetfilterdata( IGxContext context )
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
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
         return AV28OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_enteringsubmitdetailgetfilterdata objbr_enteringsubmitdetailgetfilterdata;
         objbr_enteringsubmitdetailgetfilterdata = new br_enteringsubmitdetailgetfilterdata();
         objbr_enteringsubmitdetailgetfilterdata.AV19DDOName = aP0_DDOName;
         objbr_enteringsubmitdetailgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objbr_enteringsubmitdetailgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objbr_enteringsubmitdetailgetfilterdata.AV23OptionsJson = "" ;
         objbr_enteringsubmitdetailgetfilterdata.AV26OptionsDescJson = "" ;
         objbr_enteringsubmitdetailgetfilterdata.AV28OptionIndexesJson = "" ;
         objbr_enteringsubmitdetailgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_enteringsubmitdetailgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_enteringsubmitdetailgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_enteringsubmitdetailgetfilterdata)stateInfo).executePrivate();
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
         AV22Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV25OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV27OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_BR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTER_REFUSEREASON_REASONOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTER_REFUSEREASON_FREASONOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV23OptionsJson = AV22Options.ToJSonString(false);
         AV26OptionsDescJson = AV25OptionsDesc.ToJSonString(false);
         AV28OptionIndexesJson = AV27OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV30Session.Get("BR_EnteringSubmitDetailGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EnteringSubmitDetailGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("BR_EnteringSubmitDetailGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV44GXV1 = 1;
         while ( AV44GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV44GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTERREASON_VSTATUS") == 0 )
            {
               AV37BR_EncounterReason_vStatus = (short)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               AV13TFBR_Encounter_RefuseReason_Reason = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL") == 0 )
            {
               AV14TFBR_Encounter_RefuseReason_Reason_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE") == 0 )
            {
               AV15TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Value, 0);
               AV16TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FREASON") == 0 )
            {
               AV38TFBR_Encounter_RefuseReason_FReason = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL") == 0 )
            {
               AV39TFBR_Encounter_RefuseReason_FReason_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE") == 0 )
            {
               AV40TFBR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Value, 0);
               AV41TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Valueto, 0);
            }
            AV44GXV1 = (int)(AV44GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_ENCOUNTER_REFUSEREASON_REASONOPTIONS' Routine */
         AV13TFBR_Encounter_RefuseReason_Reason = AV17SearchTxt;
         AV14TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV37BR_EncounterReason_vStatus;
         AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV13TFBR_Encounter_RefuseReason_Reason;
         AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV14TFBR_Encounter_RefuseReason_Reason_Sel;
         AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV15TFBR_Encounter_RefuseReason_NoApproveDate;
         AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV16TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV38TFBR_Encounter_RefuseReason_FReason;
         AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV39TFBR_Encounter_RefuseReason_FReason_Sel;
         AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV40TFBR_Encounter_RefuseReason_FApproveDate;
         AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV41TFBR_Encounter_RefuseReason_FApproveDate_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                              AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                              AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                              AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                              AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                              AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                              AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                              AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                              AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                              A356BR_EncounterReason_vStatus ,
                                              A349BR_Encounter_RefuseReason_Reason ,
                                              A350BR_Encounter_RefuseReason_NoApproveDate ,
                                              A355BR_Encounter_RefuseReason_FReason ,
                                              A354BR_Encounter_RefuseReason_FApproveDate ,
                                              A19BR_EncounterID ,
                                              AV35BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason), "%", "");
         lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = StringUtil.Concat( StringUtil.RTrim( AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason), "%", "");
         /* Using cursor P003B2 */
         pr_default.execute(0, new Object[] {AV35BR_EncounterID, AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus, lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason, AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel, AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate, AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to, lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason, AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel, AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate, AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK3B2 = false;
            A19BR_EncounterID = P003B2_A19BR_EncounterID[0];
            A349BR_Encounter_RefuseReason_Reason = P003B2_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = P003B2_n349BR_Encounter_RefuseReason_Reason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = P003B2_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = P003B2_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A355BR_Encounter_RefuseReason_FReason = P003B2_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = P003B2_n355BR_Encounter_RefuseReason_FReason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = P003B2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = P003B2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A356BR_EncounterReason_vStatus = P003B2_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = P003B2_n356BR_EncounterReason_vStatus[0];
            A348BR_Encounter_RefuseReasonID = P003B2_A348BR_Encounter_RefuseReasonID[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P003B2_A349BR_Encounter_RefuseReason_Reason[0], A349BR_Encounter_RefuseReason_Reason) == 0 ) )
            {
               BRK3B2 = false;
               A348BR_Encounter_RefuseReasonID = P003B2_A348BR_Encounter_RefuseReasonID[0];
               AV29count = (long)(AV29count+1);
               BRK3B2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A349BR_Encounter_RefuseReason_Reason)) )
            {
               AV21Option = A349BR_Encounter_RefuseReason_Reason;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK3B2 )
            {
               BRK3B2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_ENCOUNTER_REFUSEREASON_FREASONOPTIONS' Routine */
         AV38TFBR_Encounter_RefuseReason_FReason = AV17SearchTxt;
         AV39TFBR_Encounter_RefuseReason_FReason_Sel = "";
         AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV37BR_EncounterReason_vStatus;
         AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV13TFBR_Encounter_RefuseReason_Reason;
         AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV14TFBR_Encounter_RefuseReason_Reason_Sel;
         AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV15TFBR_Encounter_RefuseReason_NoApproveDate;
         AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV16TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV38TFBR_Encounter_RefuseReason_FReason;
         AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV39TFBR_Encounter_RefuseReason_FReason_Sel;
         AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV40TFBR_Encounter_RefuseReason_FApproveDate;
         AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV41TFBR_Encounter_RefuseReason_FApproveDate_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                              AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                              AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                              AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                              AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                              AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                              AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                              AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                              AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                              A356BR_EncounterReason_vStatus ,
                                              A349BR_Encounter_RefuseReason_Reason ,
                                              A350BR_Encounter_RefuseReason_NoApproveDate ,
                                              A355BR_Encounter_RefuseReason_FReason ,
                                              A354BR_Encounter_RefuseReason_FApproveDate ,
                                              A19BR_EncounterID ,
                                              AV35BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason), "%", "");
         lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = StringUtil.Concat( StringUtil.RTrim( AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason), "%", "");
         /* Using cursor P003B3 */
         pr_default.execute(1, new Object[] {AV35BR_EncounterID, AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus, lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason, AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel, AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate, AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to, lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason, AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel, AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate, AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK3B4 = false;
            A19BR_EncounterID = P003B3_A19BR_EncounterID[0];
            A355BR_Encounter_RefuseReason_FReason = P003B3_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = P003B3_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = P003B3_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = P003B3_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = P003B3_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = P003B3_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A349BR_Encounter_RefuseReason_Reason = P003B3_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = P003B3_n349BR_Encounter_RefuseReason_Reason[0];
            A356BR_EncounterReason_vStatus = P003B3_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = P003B3_n356BR_EncounterReason_vStatus[0];
            A348BR_Encounter_RefuseReasonID = P003B3_A348BR_Encounter_RefuseReasonID[0];
            AV29count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P003B3_A355BR_Encounter_RefuseReason_FReason[0], A355BR_Encounter_RefuseReason_FReason) == 0 ) )
            {
               BRK3B4 = false;
               A348BR_Encounter_RefuseReasonID = P003B3_A348BR_Encounter_RefuseReasonID[0];
               AV29count = (long)(AV29count+1);
               BRK3B4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A355BR_Encounter_RefuseReason_FReason)) )
            {
               AV21Option = A355BR_Encounter_RefuseReason_FReason;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK3B4 )
            {
               BRK3B4 = true;
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
         AV22Options = new GxSimpleCollection<String>();
         AV25OptionsDesc = new GxSimpleCollection<String>();
         AV27OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV30Session = context.GetSession();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV13TFBR_Encounter_RefuseReason_Reason = "";
         AV14TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV15TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         AV16TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
         AV38TFBR_Encounter_RefuseReason_FReason = "";
         AV39TFBR_Encounter_RefuseReason_FReason_Sel = "";
         AV40TFBR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         AV41TFBR_Encounter_RefuseReason_FApproveDate_To = (DateTime)(DateTime.MinValue);
         AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = "";
         AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = "";
         AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = (DateTime)(DateTime.MinValue);
         AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = "";
         AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = "";
         AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = (DateTime)(DateTime.MinValue);
         AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = (DateTime)(DateTime.MinValue);
         scmdbuf = "";
         lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = "";
         lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         A355BR_Encounter_RefuseReason_FReason = "";
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         P003B2_A19BR_EncounterID = new long[1] ;
         P003B2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         P003B2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         P003B2_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         P003B2_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         P003B2_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         P003B2_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         P003B2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         P003B2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         P003B2_A356BR_EncounterReason_vStatus = new short[1] ;
         P003B2_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         P003B2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         AV21Option = "";
         P003B3_A19BR_EncounterID = new long[1] ;
         P003B3_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         P003B3_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         P003B3_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         P003B3_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         P003B3_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         P003B3_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         P003B3_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         P003B3_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         P003B3_A356BR_EncounterReason_vStatus = new short[1] ;
         P003B3_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         P003B3_A348BR_Encounter_RefuseReasonID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_enteringsubmitdetailgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P003B2_A19BR_EncounterID, P003B2_A349BR_Encounter_RefuseReason_Reason, P003B2_n349BR_Encounter_RefuseReason_Reason, P003B2_A354BR_Encounter_RefuseReason_FApproveDate, P003B2_n354BR_Encounter_RefuseReason_FApproveDate, P003B2_A355BR_Encounter_RefuseReason_FReason, P003B2_n355BR_Encounter_RefuseReason_FReason, P003B2_A350BR_Encounter_RefuseReason_NoApproveDate, P003B2_n350BR_Encounter_RefuseReason_NoApproveDate, P003B2_A356BR_EncounterReason_vStatus,
               P003B2_n356BR_EncounterReason_vStatus, P003B2_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               P003B3_A19BR_EncounterID, P003B3_A355BR_Encounter_RefuseReason_FReason, P003B3_n355BR_Encounter_RefuseReason_FReason, P003B3_A354BR_Encounter_RefuseReason_FApproveDate, P003B3_n354BR_Encounter_RefuseReason_FApproveDate, P003B3_A350BR_Encounter_RefuseReason_NoApproveDate, P003B3_n350BR_Encounter_RefuseReason_NoApproveDate, P003B3_A349BR_Encounter_RefuseReason_Reason, P003B3_n349BR_Encounter_RefuseReason_Reason, P003B3_A356BR_EncounterReason_vStatus,
               P003B3_n356BR_EncounterReason_vStatus, P003B3_A348BR_Encounter_RefuseReasonID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV37BR_EncounterReason_vStatus ;
      private short AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ;
      private short A356BR_EncounterReason_vStatus ;
      private int AV44GXV1 ;
      private long A19BR_EncounterID ;
      private long AV35BR_EncounterID ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long AV29count ;
      private String scmdbuf ;
      private DateTime AV15TFBR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime AV16TFBR_Encounter_RefuseReason_NoApproveDate_To ;
      private DateTime AV40TFBR_Encounter_RefuseReason_FApproveDate ;
      private DateTime AV41TFBR_Encounter_RefuseReason_FApproveDate_To ;
      private DateTime AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ;
      private DateTime AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ;
      private DateTime AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ;
      private DateTime AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK3B2 ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n354BR_Encounter_RefuseReason_FApproveDate ;
      private bool n355BR_Encounter_RefuseReason_FReason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n356BR_EncounterReason_vStatus ;
      private bool BRK3B4 ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV13TFBR_Encounter_RefuseReason_Reason ;
      private String AV14TFBR_Encounter_RefuseReason_Reason_Sel ;
      private String AV38TFBR_Encounter_RefuseReason_FReason ;
      private String AV39TFBR_Encounter_RefuseReason_FReason_Sel ;
      private String AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ;
      private String AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ;
      private String AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ;
      private String AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ;
      private String lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ;
      private String lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String A355BR_Encounter_RefuseReason_FReason ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P003B2_A19BR_EncounterID ;
      private String[] P003B2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] P003B2_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] P003B2_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] P003B2_n354BR_Encounter_RefuseReason_FApproveDate ;
      private String[] P003B2_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] P003B2_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] P003B2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] P003B2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] P003B2_A356BR_EncounterReason_vStatus ;
      private bool[] P003B2_n356BR_EncounterReason_vStatus ;
      private long[] P003B2_A348BR_Encounter_RefuseReasonID ;
      private long[] P003B3_A19BR_EncounterID ;
      private String[] P003B3_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] P003B3_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] P003B3_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] P003B3_n354BR_Encounter_RefuseReason_FApproveDate ;
      private DateTime[] P003B3_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] P003B3_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String[] P003B3_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] P003B3_n349BR_Encounter_RefuseReason_Reason ;
      private short[] P003B3_A356BR_EncounterReason_vStatus ;
      private bool[] P003B3_n356BR_EncounterReason_vStatus ;
      private long[] P003B3_A348BR_Encounter_RefuseReasonID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV22Options ;
      private GxSimpleCollection<String> AV25OptionsDesc ;
      private GxSimpleCollection<String> AV27OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
   }

   public class br_enteringsubmitdetailgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P003B2( IGxContext context ,
                                             short AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                             String AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             String AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                             String AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                             DateTime AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                             DateTime AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                             short A356BR_EncounterReason_vStatus ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             String A355BR_Encounter_RefuseReason_FReason ,
                                             DateTime A354BR_Encounter_RefuseReason_FApproveDate ,
                                             long A19BR_EncounterID ,
                                             long AV35BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [10] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_EncounterID], [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_FApproveDate], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV35BR_EncounterID)";
         if ( ! (0==AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus) )
         {
            sWhereString = sWhereString + " and ([BR_EncounterReason_vStatus] = @AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] like @lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] = @AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FReason] like @lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FReason] = @AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)";
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FApproveDate] >= @AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate)";
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FApproveDate] <= @AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to)";
         }
         else
         {
            GXv_int2[9] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Encounter_RefuseReason_Reason]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P003B3( IGxContext context ,
                                             short AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                             String AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             String AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                             String AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                             DateTime AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                             DateTime AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                             short A356BR_EncounterReason_vStatus ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             String A355BR_Encounter_RefuseReason_FReason ,
                                             DateTime A354BR_Encounter_RefuseReason_FApproveDate ,
                                             long A19BR_EncounterID ,
                                             long AV35BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [10] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_EncounterID], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Reason], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV35BR_EncounterID)";
         if ( ! (0==AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus) )
         {
            sWhereString = sWhereString + " and ([BR_EncounterReason_vStatus] = @AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus)";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] like @lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] = @AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FReason] like @lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FReason] = @AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FApproveDate] >= @AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate)";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_FApproveDate] <= @AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to)";
         }
         else
         {
            GXv_int4[9] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Encounter_RefuseReason_FReason]";
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
                     return conditional_P003B2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
               case 1 :
                     return conditional_P003B3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
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
          Object[] prmP003B2 ;
          prmP003B2 = new Object[] {
          new Object[] {"@AV35BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to",SqlDbType.DateTime,10,8}
          } ;
          Object[] prmP003B3 ;
          prmP003B3 = new Object[] {
          new Object[] {"@AV35BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV47BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV48BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV49BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV50BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV51BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV52BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV53BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV54BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to",SqlDbType.DateTime,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003B2,100,0,true,false )
             ,new CursorDef("P003B3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003B3,100,0,true,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[19]);
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
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[19]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_enteringsubmitdetailgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_enteringsubmitdetailgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_enteringsubmitdetailgetfilterdata") )
          {
             return  ;
          }
          br_enteringsubmitdetailgetfilterdata worker = new br_enteringsubmitdetailgetfilterdata(context) ;
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
