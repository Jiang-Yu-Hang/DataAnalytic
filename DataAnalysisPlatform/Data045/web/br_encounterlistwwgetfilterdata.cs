/*
               File: BR_EncounterListwwGetFilterData
        Description: BR_Encounter Listww Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:11.49
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
   public class br_encounterlistwwgetfilterdata : GXProcedure
   {
      public br_encounterlistwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterlistwwgetfilterdata( IGxContext context )
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
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
         return AV44OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_encounterlistwwgetfilterdata objbr_encounterlistwwgetfilterdata;
         objbr_encounterlistwwgetfilterdata = new br_encounterlistwwgetfilterdata();
         objbr_encounterlistwwgetfilterdata.AV35DDOName = aP0_DDOName;
         objbr_encounterlistwwgetfilterdata.AV33SearchTxt = aP1_SearchTxt;
         objbr_encounterlistwwgetfilterdata.AV34SearchTxtTo = aP2_SearchTxtTo;
         objbr_encounterlistwwgetfilterdata.AV39OptionsJson = "" ;
         objbr_encounterlistwwgetfilterdata.AV42OptionsDescJson = "" ;
         objbr_encounterlistwwgetfilterdata.AV44OptionIndexesJson = "" ;
         objbr_encounterlistwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encounterlistwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encounterlistwwgetfilterdata);
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encounterlistwwgetfilterdata)stateInfo).executePrivate();
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
         AV38Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV41OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV43OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPEOPTIONS' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV39OptionsJson = AV38Options.ToJSonString(false);
         AV42OptionsDescJson = AV41OptionsDesc.ToJSonString(false);
         AV44OptionIndexesJson = AV43OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV46Session.Get("BR_EncounterListwwGridState"), "") == 0 )
         {
            AV48GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EncounterListwwGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV48GridState.FromXml(AV46Session.Get("BR_EncounterListwwGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV70GXV1 = 1;
         while ( AV70GXV1 <= AV48GridState.gxTpr_Filtervalues.Count )
         {
            AV49GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV48GridState.gxTpr_Filtervalues.Item(AV70GXV1));
            if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV51BR_Information_PatientNo = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE") == 0 )
            {
               AV60View_New_Encounter2view_NE_IsRandApprove = BooleanUtil.Val( AV49GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK") == 0 )
            {
               AV61View_New_Encounter2view_NE_IsRandRecheck = BooleanUtil.Val( AV49GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE") == 0 )
            {
               AV62View_New_Encounter2view_NE_IsUpdate = BooleanUtil.Val( AV49GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID") == 0 )
            {
               AV11TFView_New_Encounter2view_NE_EncounterID = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV12TFView_New_Encounter2view_NE_EncounterID_To = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO") == 0 )
            {
               AV31TFView_New_Encounter2view_NE_Information_PatientNo = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM") == 0 )
            {
               AV15TFView_New_Encounter2view_NE_Departmentadm = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL") == 0 )
            {
               AV16TFView_New_Encounter2view_NE_Departmentadm_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE") == 0 )
            {
               AV13TFView_New_Encounter2view_NE_ENCType = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV14TFView_New_Encounter2view_NE_ENCType_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SEL") == 0 )
            {
               AV63TFView_New_Encounter2view_NE_Status_SelsJson = AV49GridStateFilterValue.gxTpr_Value;
               AV64TFView_New_Encounter2view_NE_Status_Sels.FromJSonString(AV63TFView_New_Encounter2view_NE_Status_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL") == 0 )
            {
               AV65TFView_New_Encounter2view_NE_IsRandApprove_Sel = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL") == 0 )
            {
               AV66TFView_New_Encounter2view_NE_IsRandRecheck_Sel = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL") == 0 )
            {
               AV67TFView_New_Encounter2view_NE_IsUpdate_Sel = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
            }
            AV70GXV1 = (int)(AV70GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV31TFView_New_Encounter2view_NE_Information_PatientNo = AV33SearchTxt;
         AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel = "";
         AV72BR_EncounterListwwDS_1_Br_information_patientno = AV51BR_Information_PatientNo;
         AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV60View_New_Encounter2view_NE_IsRandApprove;
         AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV61View_New_Encounter2view_NE_IsRandRecheck;
         AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV62View_New_Encounter2view_NE_IsUpdate;
         AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV11TFView_New_Encounter2view_NE_EncounterID;
         AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV12TFView_New_Encounter2view_NE_EncounterID_To;
         AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV31TFView_New_Encounter2view_NE_Information_PatientNo;
         AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV15TFView_New_Encounter2view_NE_Departmentadm;
         AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV16TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV13TFView_New_Encounter2view_NE_ENCType;
         AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV14TFView_New_Encounter2view_NE_ENCType_Sel;
         AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV64TFView_New_Encounter2view_NE_Status_Sels;
         AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV65TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV66TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV67TFView_New_Encounter2view_NE_IsUpdate_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A595View_New_Encounter2view_NE_Status ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                              AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                              AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                              AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                              AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                              AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                              AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                              AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                              AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                              AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                              AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                              AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                              AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels.Count ,
                                              AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                              AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                              AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                              AV55sBR_EncounterID ,
                                              AV57view_NE_AdmitDate ,
                                              AV58endview_NE_AdmitDate ,
                                              AV59tview_NE_Status ,
                                              A601View_New_Encounter2view_NE_Information_PatientNo ,
                                              A597View_New_Encounter2view_NE_IsRandApprove ,
                                              A596View_New_Encounter2view_NE_IsRandRecheck ,
                                              A598View_New_Encounter2view_NE_IsUpdate ,
                                              A591View_New_Encounter2view_NE_EncounterID ,
                                              A593View_New_Encounter2view_NE_Departmentadm ,
                                              A592View_New_Encounter2view_NE_ENCType ,
                                              A594View_New_Encounter2view_NE_AdmitDate ,
                                              A599View_New_Encounter2view_NE_TenantTenantCode ,
                                              AV56tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV72BR_EncounterListwwDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno), "%", "");
         lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno), "%", "");
         lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = StringUtil.Concat( StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm), "%", "");
         lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype), "%", "");
         lV55sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV55sBR_EncounterID), "%", "");
         /* Using cursor P004T2 */
         pr_default.execute(0, new Object[] {AV56tCurrentCode, lV72BR_EncounterListwwDS_1_Br_information_patientno, AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove, AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck, AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate, AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid, AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to, lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno, AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel, lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm, AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel, lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype, AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel, lV55sBR_EncounterID, AV57view_NE_AdmitDate, AV58endview_NE_AdmitDate, AV59tview_NE_Status});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4T2 = false;
            A601View_New_Encounter2view_NE_Information_PatientNo = P004T2_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = P004T2_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            A594View_New_Encounter2view_NE_AdmitDate = P004T2_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = P004T2_n594View_New_Encounter2view_NE_AdmitDate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = P004T2_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = P004T2_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A595View_New_Encounter2view_NE_Status = P004T2_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = P004T2_n595View_New_Encounter2view_NE_Status[0];
            A592View_New_Encounter2view_NE_ENCType = P004T2_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = P004T2_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = P004T2_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = P004T2_n593View_New_Encounter2view_NE_Departmentadm[0];
            A591View_New_Encounter2view_NE_EncounterID = P004T2_A591View_New_Encounter2view_NE_EncounterID[0];
            A598View_New_Encounter2view_NE_IsUpdate = P004T2_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = P004T2_n598View_New_Encounter2view_NE_IsUpdate[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = P004T2_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = P004T2_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = P004T2_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = P004T2_n597View_New_Encounter2view_NE_IsRandApprove[0];
            AV45count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004T2_A601View_New_Encounter2view_NE_Information_PatientNo[0], A601View_New_Encounter2view_NE_Information_PatientNo) == 0 ) )
            {
               BRK4T2 = false;
               A591View_New_Encounter2view_NE_EncounterID = P004T2_A591View_New_Encounter2view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4T2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A601View_New_Encounter2view_NE_Information_PatientNo)) )
            {
               AV37Option = A601View_New_Encounter2view_NE_Information_PatientNo;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4T2 )
            {
               BRK4T2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMOPTIONS' Routine */
         AV15TFView_New_Encounter2view_NE_Departmentadm = AV33SearchTxt;
         AV16TFView_New_Encounter2view_NE_Departmentadm_Sel = "";
         AV72BR_EncounterListwwDS_1_Br_information_patientno = AV51BR_Information_PatientNo;
         AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV60View_New_Encounter2view_NE_IsRandApprove;
         AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV61View_New_Encounter2view_NE_IsRandRecheck;
         AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV62View_New_Encounter2view_NE_IsUpdate;
         AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV11TFView_New_Encounter2view_NE_EncounterID;
         AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV12TFView_New_Encounter2view_NE_EncounterID_To;
         AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV31TFView_New_Encounter2view_NE_Information_PatientNo;
         AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV15TFView_New_Encounter2view_NE_Departmentadm;
         AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV16TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV13TFView_New_Encounter2view_NE_ENCType;
         AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV14TFView_New_Encounter2view_NE_ENCType_Sel;
         AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV64TFView_New_Encounter2view_NE_Status_Sels;
         AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV65TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV66TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV67TFView_New_Encounter2view_NE_IsUpdate_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A595View_New_Encounter2view_NE_Status ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                              AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                              AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                              AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                              AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                              AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                              AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                              AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                              AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                              AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                              AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                              AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                              AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels.Count ,
                                              AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                              AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                              AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                              AV55sBR_EncounterID ,
                                              AV57view_NE_AdmitDate ,
                                              AV58endview_NE_AdmitDate ,
                                              AV59tview_NE_Status ,
                                              A601View_New_Encounter2view_NE_Information_PatientNo ,
                                              A597View_New_Encounter2view_NE_IsRandApprove ,
                                              A596View_New_Encounter2view_NE_IsRandRecheck ,
                                              A598View_New_Encounter2view_NE_IsUpdate ,
                                              A591View_New_Encounter2view_NE_EncounterID ,
                                              A593View_New_Encounter2view_NE_Departmentadm ,
                                              A592View_New_Encounter2view_NE_ENCType ,
                                              A594View_New_Encounter2view_NE_AdmitDate ,
                                              A599View_New_Encounter2view_NE_TenantTenantCode ,
                                              AV56tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV72BR_EncounterListwwDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno), "%", "");
         lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno), "%", "");
         lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = StringUtil.Concat( StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm), "%", "");
         lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype), "%", "");
         lV55sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV55sBR_EncounterID), "%", "");
         /* Using cursor P004T3 */
         pr_default.execute(1, new Object[] {AV56tCurrentCode, lV72BR_EncounterListwwDS_1_Br_information_patientno, AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove, AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck, AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate, AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid, AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to, lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno, AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel, lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm, AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel, lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype, AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel, lV55sBR_EncounterID, AV57view_NE_AdmitDate, AV58endview_NE_AdmitDate, AV59tview_NE_Status});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4T4 = false;
            A593View_New_Encounter2view_NE_Departmentadm = P004T3_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = P004T3_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = P004T3_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = P004T3_n594View_New_Encounter2view_NE_AdmitDate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = P004T3_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = P004T3_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A595View_New_Encounter2view_NE_Status = P004T3_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = P004T3_n595View_New_Encounter2view_NE_Status[0];
            A592View_New_Encounter2view_NE_ENCType = P004T3_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = P004T3_n592View_New_Encounter2view_NE_ENCType[0];
            A591View_New_Encounter2view_NE_EncounterID = P004T3_A591View_New_Encounter2view_NE_EncounterID[0];
            A598View_New_Encounter2view_NE_IsUpdate = P004T3_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = P004T3_n598View_New_Encounter2view_NE_IsUpdate[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = P004T3_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = P004T3_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = P004T3_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = P004T3_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = P004T3_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = P004T3_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            AV45count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004T3_A593View_New_Encounter2view_NE_Departmentadm[0], A593View_New_Encounter2view_NE_Departmentadm) == 0 ) )
            {
               BRK4T4 = false;
               A591View_New_Encounter2view_NE_EncounterID = P004T3_A591View_New_Encounter2view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4T4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A593View_New_Encounter2view_NE_Departmentadm)) )
            {
               AV37Option = A593View_New_Encounter2view_NE_Departmentadm;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4T4 )
            {
               BRK4T4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPEOPTIONS' Routine */
         AV13TFView_New_Encounter2view_NE_ENCType = AV33SearchTxt;
         AV14TFView_New_Encounter2view_NE_ENCType_Sel = "";
         AV72BR_EncounterListwwDS_1_Br_information_patientno = AV51BR_Information_PatientNo;
         AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV60View_New_Encounter2view_NE_IsRandApprove;
         AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV61View_New_Encounter2view_NE_IsRandRecheck;
         AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV62View_New_Encounter2view_NE_IsUpdate;
         AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV11TFView_New_Encounter2view_NE_EncounterID;
         AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV12TFView_New_Encounter2view_NE_EncounterID_To;
         AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV31TFView_New_Encounter2view_NE_Information_PatientNo;
         AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV15TFView_New_Encounter2view_NE_Departmentadm;
         AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV16TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV13TFView_New_Encounter2view_NE_ENCType;
         AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV14TFView_New_Encounter2view_NE_ENCType_Sel;
         AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV64TFView_New_Encounter2view_NE_Status_Sels;
         AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV65TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV66TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV67TFView_New_Encounter2view_NE_IsUpdate_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A595View_New_Encounter2view_NE_Status ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                              AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                              AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                              AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                              AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                              AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                              AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                              AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                              AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                              AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                              AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                              AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                              AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                              AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels.Count ,
                                              AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                              AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                              AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                              AV55sBR_EncounterID ,
                                              AV57view_NE_AdmitDate ,
                                              AV58endview_NE_AdmitDate ,
                                              AV59tview_NE_Status ,
                                              A601View_New_Encounter2view_NE_Information_PatientNo ,
                                              A597View_New_Encounter2view_NE_IsRandApprove ,
                                              A596View_New_Encounter2view_NE_IsRandRecheck ,
                                              A598View_New_Encounter2view_NE_IsUpdate ,
                                              A591View_New_Encounter2view_NE_EncounterID ,
                                              A593View_New_Encounter2view_NE_Departmentadm ,
                                              A592View_New_Encounter2view_NE_ENCType ,
                                              A594View_New_Encounter2view_NE_AdmitDate ,
                                              A599View_New_Encounter2view_NE_TenantTenantCode ,
                                              AV56tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV72BR_EncounterListwwDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno), "%", "");
         lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno), "%", "");
         lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = StringUtil.Concat( StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm), "%", "");
         lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype), "%", "");
         lV55sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV55sBR_EncounterID), "%", "");
         /* Using cursor P004T4 */
         pr_default.execute(2, new Object[] {AV56tCurrentCode, lV72BR_EncounterListwwDS_1_Br_information_patientno, AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove, AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck, AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate, AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid, AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to, lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno, AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel, lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm, AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel, lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype, AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel, lV55sBR_EncounterID, AV57view_NE_AdmitDate, AV58endview_NE_AdmitDate, AV59tview_NE_Status});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK4T6 = false;
            A592View_New_Encounter2view_NE_ENCType = P004T4_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = P004T4_n592View_New_Encounter2view_NE_ENCType[0];
            A594View_New_Encounter2view_NE_AdmitDate = P004T4_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = P004T4_n594View_New_Encounter2view_NE_AdmitDate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = P004T4_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = P004T4_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A595View_New_Encounter2view_NE_Status = P004T4_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = P004T4_n595View_New_Encounter2view_NE_Status[0];
            A593View_New_Encounter2view_NE_Departmentadm = P004T4_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = P004T4_n593View_New_Encounter2view_NE_Departmentadm[0];
            A591View_New_Encounter2view_NE_EncounterID = P004T4_A591View_New_Encounter2view_NE_EncounterID[0];
            A598View_New_Encounter2view_NE_IsUpdate = P004T4_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = P004T4_n598View_New_Encounter2view_NE_IsUpdate[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = P004T4_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = P004T4_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = P004T4_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = P004T4_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = P004T4_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = P004T4_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            AV45count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P004T4_A592View_New_Encounter2view_NE_ENCType[0], A592View_New_Encounter2view_NE_ENCType) == 0 ) )
            {
               BRK4T6 = false;
               A591View_New_Encounter2view_NE_EncounterID = P004T4_A591View_New_Encounter2view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4T6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A592View_New_Encounter2view_NE_ENCType)) )
            {
               AV37Option = A592View_New_Encounter2view_NE_ENCType;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4T6 )
            {
               BRK4T6 = true;
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
         AV38Options = new GxSimpleCollection<String>();
         AV41OptionsDesc = new GxSimpleCollection<String>();
         AV43OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV46Session = context.GetSession();
         AV48GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV49GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV51BR_Information_PatientNo = "";
         AV31TFView_New_Encounter2view_NE_Information_PatientNo = "";
         AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel = "";
         AV15TFView_New_Encounter2view_NE_Departmentadm = "";
         AV16TFView_New_Encounter2view_NE_Departmentadm_Sel = "";
         AV13TFView_New_Encounter2view_NE_ENCType = "";
         AV14TFView_New_Encounter2view_NE_ENCType_Sel = "";
         AV63TFView_New_Encounter2view_NE_Status_SelsJson = "";
         AV64TFView_New_Encounter2view_NE_Status_Sels = new GxSimpleCollection<short>();
         AV72BR_EncounterListwwDS_1_Br_information_patientno = "";
         AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = "";
         AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = "";
         AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = "";
         AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = "";
         AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = "";
         AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = "";
         AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         lV72BR_EncounterListwwDS_1_Br_information_patientno = "";
         lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = "";
         lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = "";
         lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = "";
         lV55sBR_EncounterID = "";
         AV55sBR_EncounterID = "";
         AV57view_NE_AdmitDate = DateTime.MinValue;
         AV58endview_NE_AdmitDate = DateTime.MinValue;
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         A593View_New_Encounter2view_NE_Departmentadm = "";
         A592View_New_Encounter2view_NE_ENCType = "";
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         AV56tCurrentCode = "";
         P004T2_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         P004T2_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         P004T2_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004T2_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         P004T2_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         P004T2_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         P004T2_A595View_New_Encounter2view_NE_Status = new short[1] ;
         P004T2_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         P004T2_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         P004T2_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         P004T2_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         P004T2_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         P004T2_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         P004T2_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T2_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T2_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T2_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T2_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         P004T2_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         AV37Option = "";
         P004T3_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         P004T3_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         P004T3_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004T3_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         P004T3_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         P004T3_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         P004T3_A595View_New_Encounter2view_NE_Status = new short[1] ;
         P004T3_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         P004T3_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         P004T3_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         P004T3_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         P004T3_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T3_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T3_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T3_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T3_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         P004T3_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         P004T3_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         P004T3_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         P004T4_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         P004T4_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         P004T4_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004T4_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         P004T4_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         P004T4_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         P004T4_A595View_New_Encounter2view_NE_Status = new short[1] ;
         P004T4_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         P004T4_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         P004T4_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         P004T4_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         P004T4_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T4_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         P004T4_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T4_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         P004T4_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         P004T4_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         P004T4_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         P004T4_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterlistwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004T2_A601View_New_Encounter2view_NE_Information_PatientNo, P004T2_n601View_New_Encounter2view_NE_Information_PatientNo, P004T2_A594View_New_Encounter2view_NE_AdmitDate, P004T2_n594View_New_Encounter2view_NE_AdmitDate, P004T2_A599View_New_Encounter2view_NE_TenantTenantCode, P004T2_n599View_New_Encounter2view_NE_TenantTenantCode, P004T2_A595View_New_Encounter2view_NE_Status, P004T2_n595View_New_Encounter2view_NE_Status, P004T2_A592View_New_Encounter2view_NE_ENCType, P004T2_n592View_New_Encounter2view_NE_ENCType,
               P004T2_A593View_New_Encounter2view_NE_Departmentadm, P004T2_n593View_New_Encounter2view_NE_Departmentadm, P004T2_A591View_New_Encounter2view_NE_EncounterID, P004T2_A598View_New_Encounter2view_NE_IsUpdate, P004T2_n598View_New_Encounter2view_NE_IsUpdate, P004T2_A596View_New_Encounter2view_NE_IsRandRecheck, P004T2_n596View_New_Encounter2view_NE_IsRandRecheck, P004T2_A597View_New_Encounter2view_NE_IsRandApprove, P004T2_n597View_New_Encounter2view_NE_IsRandApprove
               }
               , new Object[] {
               P004T3_A593View_New_Encounter2view_NE_Departmentadm, P004T3_n593View_New_Encounter2view_NE_Departmentadm, P004T3_A594View_New_Encounter2view_NE_AdmitDate, P004T3_n594View_New_Encounter2view_NE_AdmitDate, P004T3_A599View_New_Encounter2view_NE_TenantTenantCode, P004T3_n599View_New_Encounter2view_NE_TenantTenantCode, P004T3_A595View_New_Encounter2view_NE_Status, P004T3_n595View_New_Encounter2view_NE_Status, P004T3_A592View_New_Encounter2view_NE_ENCType, P004T3_n592View_New_Encounter2view_NE_ENCType,
               P004T3_A591View_New_Encounter2view_NE_EncounterID, P004T3_A598View_New_Encounter2view_NE_IsUpdate, P004T3_n598View_New_Encounter2view_NE_IsUpdate, P004T3_A596View_New_Encounter2view_NE_IsRandRecheck, P004T3_n596View_New_Encounter2view_NE_IsRandRecheck, P004T3_A597View_New_Encounter2view_NE_IsRandApprove, P004T3_n597View_New_Encounter2view_NE_IsRandApprove, P004T3_A601View_New_Encounter2view_NE_Information_PatientNo, P004T3_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               P004T4_A592View_New_Encounter2view_NE_ENCType, P004T4_n592View_New_Encounter2view_NE_ENCType, P004T4_A594View_New_Encounter2view_NE_AdmitDate, P004T4_n594View_New_Encounter2view_NE_AdmitDate, P004T4_A599View_New_Encounter2view_NE_TenantTenantCode, P004T4_n599View_New_Encounter2view_NE_TenantTenantCode, P004T4_A595View_New_Encounter2view_NE_Status, P004T4_n595View_New_Encounter2view_NE_Status, P004T4_A593View_New_Encounter2view_NE_Departmentadm, P004T4_n593View_New_Encounter2view_NE_Departmentadm,
               P004T4_A591View_New_Encounter2view_NE_EncounterID, P004T4_A598View_New_Encounter2view_NE_IsUpdate, P004T4_n598View_New_Encounter2view_NE_IsUpdate, P004T4_A596View_New_Encounter2view_NE_IsRandRecheck, P004T4_n596View_New_Encounter2view_NE_IsRandRecheck, P004T4_A597View_New_Encounter2view_NE_IsRandApprove, P004T4_n597View_New_Encounter2view_NE_IsRandApprove, P004T4_A601View_New_Encounter2view_NE_Information_PatientNo, P004T4_n601View_New_Encounter2view_NE_Information_PatientNo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV65TFView_New_Encounter2view_NE_IsRandApprove_Sel ;
      private short AV66TFView_New_Encounter2view_NE_IsRandRecheck_Sel ;
      private short AV67TFView_New_Encounter2view_NE_IsUpdate_Sel ;
      private short AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ;
      private short AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ;
      private short AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ;
      private short A595View_New_Encounter2view_NE_Status ;
      private short AV59tview_NE_Status ;
      private int AV70GXV1 ;
      private int AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ;
      private long AV11TFView_New_Encounter2view_NE_EncounterID ;
      private long AV12TFView_New_Encounter2view_NE_EncounterID_To ;
      private long AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ;
      private long AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ;
      private long A591View_New_Encounter2view_NE_EncounterID ;
      private long AV45count ;
      private String scmdbuf ;
      private DateTime AV57view_NE_AdmitDate ;
      private DateTime AV58endview_NE_AdmitDate ;
      private DateTime A594View_New_Encounter2view_NE_AdmitDate ;
      private bool returnInSub ;
      private bool AV60View_New_Encounter2view_NE_IsRandApprove ;
      private bool AV61View_New_Encounter2view_NE_IsRandRecheck ;
      private bool AV62View_New_Encounter2view_NE_IsUpdate ;
      private bool AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ;
      private bool AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ;
      private bool AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ;
      private bool A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool A598View_New_Encounter2view_NE_IsUpdate ;
      private bool BRK4T2 ;
      private bool n601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool n594View_New_Encounter2view_NE_AdmitDate ;
      private bool n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool n595View_New_Encounter2view_NE_Status ;
      private bool n592View_New_Encounter2view_NE_ENCType ;
      private bool n593View_New_Encounter2view_NE_Departmentadm ;
      private bool n598View_New_Encounter2view_NE_IsUpdate ;
      private bool n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool BRK4T4 ;
      private bool BRK4T6 ;
      private String AV44OptionIndexesJson ;
      private String AV39OptionsJson ;
      private String AV42OptionsDescJson ;
      private String AV63TFView_New_Encounter2view_NE_Status_SelsJson ;
      private String AV35DDOName ;
      private String AV33SearchTxt ;
      private String AV34SearchTxtTo ;
      private String AV51BR_Information_PatientNo ;
      private String AV31TFView_New_Encounter2view_NE_Information_PatientNo ;
      private String AV32TFView_New_Encounter2view_NE_Information_PatientNo_Sel ;
      private String AV15TFView_New_Encounter2view_NE_Departmentadm ;
      private String AV16TFView_New_Encounter2view_NE_Departmentadm_Sel ;
      private String AV13TFView_New_Encounter2view_NE_ENCType ;
      private String AV14TFView_New_Encounter2view_NE_ENCType_Sel ;
      private String AV72BR_EncounterListwwDS_1_Br_information_patientno ;
      private String AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ;
      private String AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ;
      private String AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ;
      private String AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ;
      private String AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ;
      private String AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ;
      private String lV72BR_EncounterListwwDS_1_Br_information_patientno ;
      private String lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ;
      private String lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ;
      private String lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ;
      private String lV55sBR_EncounterID ;
      private String AV55sBR_EncounterID ;
      private String A601View_New_Encounter2view_NE_Information_PatientNo ;
      private String A593View_New_Encounter2view_NE_Departmentadm ;
      private String A592View_New_Encounter2view_NE_ENCType ;
      private String A599View_New_Encounter2view_NE_TenantTenantCode ;
      private String AV56tCurrentCode ;
      private String AV37Option ;
      private GxSimpleCollection<short> AV64TFView_New_Encounter2view_NE_Status_Sels ;
      private GxSimpleCollection<short> AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ;
      private IGxSession AV46Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004T2_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] P004T2_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private DateTime[] P004T2_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] P004T2_n594View_New_Encounter2view_NE_AdmitDate ;
      private String[] P004T2_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] P004T2_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private short[] P004T2_A595View_New_Encounter2view_NE_Status ;
      private bool[] P004T2_n595View_New_Encounter2view_NE_Status ;
      private String[] P004T2_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] P004T2_n592View_New_Encounter2view_NE_ENCType ;
      private String[] P004T2_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] P004T2_n593View_New_Encounter2view_NE_Departmentadm ;
      private long[] P004T2_A591View_New_Encounter2view_NE_EncounterID ;
      private bool[] P004T2_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T2_n598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T2_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T2_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T2_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] P004T2_n597View_New_Encounter2view_NE_IsRandApprove ;
      private String[] P004T3_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] P004T3_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] P004T3_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] P004T3_n594View_New_Encounter2view_NE_AdmitDate ;
      private String[] P004T3_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] P004T3_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private short[] P004T3_A595View_New_Encounter2view_NE_Status ;
      private bool[] P004T3_n595View_New_Encounter2view_NE_Status ;
      private String[] P004T3_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] P004T3_n592View_New_Encounter2view_NE_ENCType ;
      private long[] P004T3_A591View_New_Encounter2view_NE_EncounterID ;
      private bool[] P004T3_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T3_n598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T3_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T3_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T3_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] P004T3_n597View_New_Encounter2view_NE_IsRandApprove ;
      private String[] P004T3_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] P004T3_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private String[] P004T4_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] P004T4_n592View_New_Encounter2view_NE_ENCType ;
      private DateTime[] P004T4_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] P004T4_n594View_New_Encounter2view_NE_AdmitDate ;
      private String[] P004T4_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] P004T4_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private short[] P004T4_A595View_New_Encounter2view_NE_Status ;
      private bool[] P004T4_n595View_New_Encounter2view_NE_Status ;
      private String[] P004T4_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] P004T4_n593View_New_Encounter2view_NE_Departmentadm ;
      private long[] P004T4_A591View_New_Encounter2view_NE_EncounterID ;
      private bool[] P004T4_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T4_n598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] P004T4_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T4_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] P004T4_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] P004T4_n597View_New_Encounter2view_NE_IsRandApprove ;
      private String[] P004T4_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] P004T4_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV38Options ;
      private GxSimpleCollection<String> AV41OptionsDesc ;
      private GxSimpleCollection<String> AV43OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV48GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV49GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
   }

   public class br_encounterlistwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004T2( IGxContext context ,
                                             short A595View_New_Encounter2view_NE_Status ,
                                             GxSimpleCollection<short> AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                             String AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                             bool AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                             bool AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                             bool AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                             long AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                             long AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                             String AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                             String AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                             String AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                             String AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                             String AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                             String AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                             int AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ,
                                             short AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                             short AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                             short AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                             String AV55sBR_EncounterID ,
                                             DateTime AV57view_NE_AdmitDate ,
                                             DateTime AV58endview_NE_AdmitDate ,
                                             short AV59tview_NE_Status ,
                                             String A601View_New_Encounter2view_NE_Information_PatientNo ,
                                             bool A597View_New_Encounter2view_NE_IsRandApprove ,
                                             bool A596View_New_Encounter2view_NE_IsRandRecheck ,
                                             bool A598View_New_Encounter2view_NE_IsUpdate ,
                                             long A591View_New_Encounter2view_NE_EncounterID ,
                                             String A593View_New_Encounter2view_NE_Departmentadm ,
                                             String A592View_New_Encounter2view_NE_ENCType ,
                                             DateTime A594View_New_Encounter2view_NE_AdmitDate ,
                                             String A599View_New_Encounter2view_NE_TenantTenantCode ,
                                             String AV56tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [17] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [View_New_Encounter2view_NE_Information_PatientNo], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove] FROM [View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([View_New_Encounter2view_NE_TenantTenantCode])) = @AV56tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like '%' + @lV72BR_EncounterListwwDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (false==AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = @AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = @AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (false==AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = @AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] >= @AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] <= @AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like @lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)";
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] = @AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] like @lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)";
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] = @AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)";
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] like @lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)";
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] = @AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)";
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels, "[View_New_Encounter2view_NE_Status] IN (", ")") + ")";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 1)";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 0)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 1)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 0)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 1)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([View_New_Encounter2view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV55sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV57view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] >= @AV57view_NE_AdmitDate)";
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV58endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] <= @AV58endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int1[15] = 1;
         }
         if ( ! (0==AV59tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([View_New_Encounter2view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV59tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int1[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [View_New_Encounter2view_NE_Information_PatientNo]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004T3( IGxContext context ,
                                             short A595View_New_Encounter2view_NE_Status ,
                                             GxSimpleCollection<short> AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                             String AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                             bool AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                             bool AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                             bool AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                             long AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                             long AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                             String AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                             String AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                             String AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                             String AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                             String AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                             String AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                             int AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ,
                                             short AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                             short AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                             short AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                             String AV55sBR_EncounterID ,
                                             DateTime AV57view_NE_AdmitDate ,
                                             DateTime AV58endview_NE_AdmitDate ,
                                             short AV59tview_NE_Status ,
                                             String A601View_New_Encounter2view_NE_Information_PatientNo ,
                                             bool A597View_New_Encounter2view_NE_IsRandApprove ,
                                             bool A596View_New_Encounter2view_NE_IsRandRecheck ,
                                             bool A598View_New_Encounter2view_NE_IsUpdate ,
                                             long A591View_New_Encounter2view_NE_EncounterID ,
                                             String A593View_New_Encounter2view_NE_Departmentadm ,
                                             String A592View_New_Encounter2view_NE_ENCType ,
                                             DateTime A594View_New_Encounter2view_NE_AdmitDate ,
                                             String A599View_New_Encounter2view_NE_TenantTenantCode ,
                                             String AV56tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [17] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([View_New_Encounter2view_NE_TenantTenantCode])) = @AV56tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like '%' + @lV72BR_EncounterListwwDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (false==AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = @AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (false==AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = @AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (false==AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = @AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] >= @AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] <= @AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like @lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] = @AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] like @lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] = @AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)";
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] like @lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)";
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] = @AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)";
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels, "[View_New_Encounter2view_NE_Status] IN (", ")") + ")";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 1)";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 0)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 1)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 0)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 1)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([View_New_Encounter2view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV55sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV57view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] >= @AV57view_NE_AdmitDate)";
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV58endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] <= @AV58endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( ! (0==AV59tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([View_New_Encounter2view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV59tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int3[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [View_New_Encounter2view_NE_Departmentadm]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P004T4( IGxContext context ,
                                             short A595View_New_Encounter2view_NE_Status ,
                                             GxSimpleCollection<short> AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                             String AV72BR_EncounterListwwDS_1_Br_information_patientno ,
                                             bool AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                             bool AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                             bool AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                             long AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                             long AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                             String AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                             String AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                             String AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                             String AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                             String AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                             String AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                             int AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ,
                                             short AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                             short AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                             short AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                             String AV55sBR_EncounterID ,
                                             DateTime AV57view_NE_AdmitDate ,
                                             DateTime AV58endview_NE_AdmitDate ,
                                             short AV59tview_NE_Status ,
                                             String A601View_New_Encounter2view_NE_Information_PatientNo ,
                                             bool A597View_New_Encounter2view_NE_IsRandApprove ,
                                             bool A596View_New_Encounter2view_NE_IsRandRecheck ,
                                             bool A598View_New_Encounter2view_NE_IsUpdate ,
                                             long A591View_New_Encounter2view_NE_EncounterID ,
                                             String A593View_New_Encounter2view_NE_Departmentadm ,
                                             String A592View_New_Encounter2view_NE_ENCType ,
                                             DateTime A594View_New_Encounter2view_NE_AdmitDate ,
                                             String A599View_New_Encounter2view_NE_TenantTenantCode ,
                                             String AV56tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [17] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([View_New_Encounter2view_NE_TenantTenantCode])) = @AV56tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_EncounterListwwDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like '%' + @lV72BR_EncounterListwwDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (false==AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = @AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (false==AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = @AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (false==AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = @AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (0==AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] >= @AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] <= @AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like @lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] = @AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] like @lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] = @AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)";
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] like @lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)";
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] = @AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)";
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV84BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels, "[View_New_Encounter2view_NE_Status] IN (", ")") + ")";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 1)";
         }
         if ( AV85BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 0)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 1)";
         }
         if ( AV86BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 0)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 1)";
         }
         if ( AV87BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([View_New_Encounter2view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV55sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV57view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] >= @AV57view_NE_AdmitDate)";
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV58endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] <= @AV58endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( ! (0==AV59tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([View_New_Encounter2view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV59tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int5[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [View_New_Encounter2view_NE_ENCType]";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P004T2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
               case 1 :
                     return conditional_P004T3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
               case 2 :
                     return conditional_P004T4(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
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
          Object[] prmP004T2 ;
          prmP004T2 = new Object[] {
          new Object[] {"@AV56tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV72BR_EncounterListwwDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV57view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP004T3 ;
          prmP004T3 = new Object[] {
          new Object[] {"@AV56tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV72BR_EncounterListwwDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV57view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP004T4 ;
          prmP004T4 = new Object[] {
          new Object[] {"@AV56tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV72BR_EncounterListwwDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV74BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV79BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV80BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV81BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV82BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV83BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV57view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004T2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004T2,100,0,true,false )
             ,new CursorDef("P004T3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004T3,100,0,true,false )
             ,new CursorDef("P004T4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004T4,100,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                ((bool[]) buf[13])[0] = rslt.getBool(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((bool[]) buf[15])[0] = rslt.getBool(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((bool[]) buf[17])[0] = rslt.getBool(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.getBool(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((bool[]) buf[13])[0] = rslt.getBool(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((bool[]) buf[15])[0] = rslt.getBool(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.getBool(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((bool[]) buf[13])[0] = rslt.getBool(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((bool[]) buf[15])[0] = rslt.getBool(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
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
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_encounterlistwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encounterlistwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encounterlistwwgetfilterdata") )
          {
             return  ;
          }
          br_encounterlistwwgetfilterdata worker = new br_encounterlistwwgetfilterdata(context) ;
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
