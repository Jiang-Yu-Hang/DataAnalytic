/*
               File: BR_EncounterListGetFilterData
        Description: BR_Encounter List Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:44.56
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
   public class br_encounterlistgetfilterdata : GXProcedure
   {
      public br_encounterlistgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterlistgetfilterdata( IGxContext context )
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
         this.AV31DDOName = aP0_DDOName;
         this.AV29SearchTxt = aP1_SearchTxt;
         this.AV30SearchTxtTo = aP2_SearchTxtTo;
         this.AV35OptionsJson = "" ;
         this.AV38OptionsDescJson = "" ;
         this.AV40OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV31DDOName = aP0_DDOName;
         this.AV29SearchTxt = aP1_SearchTxt;
         this.AV30SearchTxtTo = aP2_SearchTxtTo;
         this.AV35OptionsJson = "" ;
         this.AV38OptionsDescJson = "" ;
         this.AV40OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
         return AV40OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_encounterlistgetfilterdata objbr_encounterlistgetfilterdata;
         objbr_encounterlistgetfilterdata = new br_encounterlistgetfilterdata();
         objbr_encounterlistgetfilterdata.AV31DDOName = aP0_DDOName;
         objbr_encounterlistgetfilterdata.AV29SearchTxt = aP1_SearchTxt;
         objbr_encounterlistgetfilterdata.AV30SearchTxtTo = aP2_SearchTxtTo;
         objbr_encounterlistgetfilterdata.AV35OptionsJson = "" ;
         objbr_encounterlistgetfilterdata.AV38OptionsDescJson = "" ;
         objbr_encounterlistgetfilterdata.AV40OptionIndexesJson = "" ;
         objbr_encounterlistgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encounterlistgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encounterlistgetfilterdata);
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encounterlistgetfilterdata)stateInfo).executePrivate();
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
         AV34Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV37OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV39OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_VIEW_NE_INFORMATION_PATIENTNO") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_INFORMATION_PATIENTNOOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_VIEW_NE_DEPARTMENT") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_DEPARTMENTOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_VIEW_NE_ENCTYPE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_ENCTYPEOPTIONS' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV35OptionsJson = AV34Options.ToJSonString(false);
         AV38OptionsDescJson = AV37OptionsDesc.ToJSonString(false);
         AV40OptionIndexesJson = AV39OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV42Session.Get("BR_EncounterListGridState"), "") == 0 )
         {
            AV44GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EncounterListGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV44GridState.FromXml(AV42Session.Get("BR_EncounterListGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV71GXV1 = 1;
         while ( AV71GXV1 <= AV44GridState.gxTpr_Filtervalues.Count )
         {
            AV45GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV44GridState.gxTpr_Filtervalues.Item(AV71GXV1));
            if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV47BR_Information_PatientNo = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "VIEW_NE_ISRANDAPPROVE") == 0 )
            {
               AV63view_NE_IsRandApprove = BooleanUtil.Val( AV45GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "VIEW_NE_ISRANDRECHECK") == 0 )
            {
               AV64view_NE_IsRandRecheck = BooleanUtil.Val( AV45GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "VIEW_NE_ISUPDATE") == 0 )
            {
               AV65view_NE_IsUpdate = BooleanUtil.Val( AV45GridStateFilterValue.gxTpr_Value);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCOUNTERID") == 0 )
            {
               AV11TFview_NE_EncounterID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV12TFview_NE_EncounterID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_INFORMATION_PATIENTNO") == 0 )
            {
               AV13TFview_NE_Information_PatientNo = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV14TFview_NE_Information_PatientNo_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT") == 0 )
            {
               AV15TFview_NE_Department = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT_SEL") == 0 )
            {
               AV16TFview_NE_Department_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE") == 0 )
            {
               AV17TFview_NE_ENCType = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV18TFview_NE_ENCType_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_STATUS_SEL") == 0 )
            {
               AV60TFview_NE_Status_SelsJson = AV45GridStateFilterValue.gxTpr_Value;
               AV61TFview_NE_Status_Sels.FromJSonString(AV60TFview_NE_Status_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISRANDAPPROVE_SEL") == 0 )
            {
               AV55TFview_NE_IsRandApprove_Sel = (short)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISRANDRECHECK_SEL") == 0 )
            {
               AV54TFview_NE_IsRandRecheck_Sel = (short)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISUPDATE_SEL") == 0 )
            {
               AV56TFview_NE_IsUpdate_Sel = (short)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
            }
            AV71GXV1 = (int)(AV71GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_NE_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV13TFview_NE_Information_PatientNo = AV29SearchTxt;
         AV14TFview_NE_Information_PatientNo_Sel = "";
         AV73BR_EncounterListDS_1_Br_information_patientno = AV47BR_Information_PatientNo;
         AV74BR_EncounterListDS_2_View_ne_israndapprove = AV63view_NE_IsRandApprove;
         AV75BR_EncounterListDS_3_View_ne_israndrecheck = AV64view_NE_IsRandRecheck;
         AV76BR_EncounterListDS_4_View_ne_isupdate = AV65view_NE_IsUpdate;
         AV77BR_EncounterListDS_5_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV79BR_EncounterListDS_7_Tfview_ne_information_patientno = AV13TFview_NE_Information_PatientNo;
         AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel = AV14TFview_NE_Information_PatientNo_Sel;
         AV81BR_EncounterListDS_9_Tfview_ne_department = AV15TFview_NE_Department;
         AV82BR_EncounterListDS_10_Tfview_ne_department_sel = AV16TFview_NE_Department_Sel;
         AV83BR_EncounterListDS_11_Tfview_ne_enctype = AV17TFview_NE_ENCType;
         AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel = AV18TFview_NE_ENCType_Sel;
         AV85BR_EncounterListDS_13_Tfview_ne_status_sels = AV61TFview_NE_Status_Sels;
         AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel = AV55TFview_NE_IsRandApprove_Sel;
         AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel = AV54TFview_NE_IsRandRecheck_Sel;
         AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel = AV56TFview_NE_IsUpdate_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                              AV73BR_EncounterListDS_1_Br_information_patientno ,
                                              AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                              AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                              AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                              AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                              AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                              AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                              AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                              AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                              AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                              AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                              AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels.Count ,
                                              AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                              AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                              AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                              AV51sBR_EncounterID ,
                                              AV50view_NE_AdmitDate ,
                                              AV68endview_NE_AdmitDate ,
                                              AV67tview_NE_Status ,
                                              A559view_NE_Information_PatientNo ,
                                              A555view_NE_IsRandApprove ,
                                              A554view_NE_IsRandRecheck ,
                                              A556view_NE_IsUpdate ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A557view_NE_TenantTenantCode ,
                                              AV52tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV73BR_EncounterListDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno), "%", "");
         lV79BR_EncounterListDS_7_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno), "%", "");
         lV81BR_EncounterListDS_9_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department), "%", "");
         lV83BR_EncounterListDS_11_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype), "%", "");
         lV51sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV51sBR_EncounterID), "%", "");
         /* Using cursor P004Q2 */
         pr_default.execute(0, new Object[] {AV52tCurrentCode, lV73BR_EncounterListDS_1_Br_information_patientno, AV74BR_EncounterListDS_2_View_ne_israndapprove, AV75BR_EncounterListDS_3_View_ne_israndrecheck, AV76BR_EncounterListDS_4_View_ne_isupdate, AV77BR_EncounterListDS_5_Tfview_ne_encounterid, AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to, lV79BR_EncounterListDS_7_Tfview_ne_information_patientno, AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel, lV81BR_EncounterListDS_9_Tfview_ne_department, AV82BR_EncounterListDS_10_Tfview_ne_department_sel, lV83BR_EncounterListDS_11_Tfview_ne_enctype, AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel, lV51sBR_EncounterID, AV50view_NE_AdmitDate, AV68endview_NE_AdmitDate, AV67tview_NE_Status});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4Q2 = false;
            A559view_NE_Information_PatientNo = P004Q2_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004Q2_n559view_NE_Information_PatientNo[0];
            A552view_NE_AdmitDate = P004Q2_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004Q2_n552view_NE_AdmitDate[0];
            A557view_NE_TenantTenantCode = P004Q2_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004Q2_n557view_NE_TenantTenantCode[0];
            A553view_NE_Status = P004Q2_A553view_NE_Status[0];
            n553view_NE_Status = P004Q2_n553view_NE_Status[0];
            A551view_NE_ENCType = P004Q2_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004Q2_n551view_NE_ENCType[0];
            A550view_NE_Department = P004Q2_A550view_NE_Department[0];
            n550view_NE_Department = P004Q2_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004Q2_A549view_NE_EncounterID[0];
            A556view_NE_IsUpdate = P004Q2_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004Q2_n556view_NE_IsUpdate[0];
            A554view_NE_IsRandRecheck = P004Q2_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004Q2_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = P004Q2_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004Q2_n555view_NE_IsRandApprove[0];
            AV41count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004Q2_A559view_NE_Information_PatientNo[0], A559view_NE_Information_PatientNo) == 0 ) )
            {
               BRK4Q2 = false;
               A549view_NE_EncounterID = P004Q2_A549view_NE_EncounterID[0];
               AV41count = (long)(AV41count+1);
               BRK4Q2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A559view_NE_Information_PatientNo)) )
            {
               AV33Option = A559view_NE_Information_PatientNo;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4Q2 )
            {
               BRK4Q2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_NE_DEPARTMENTOPTIONS' Routine */
         AV15TFview_NE_Department = AV29SearchTxt;
         AV16TFview_NE_Department_Sel = "";
         AV73BR_EncounterListDS_1_Br_information_patientno = AV47BR_Information_PatientNo;
         AV74BR_EncounterListDS_2_View_ne_israndapprove = AV63view_NE_IsRandApprove;
         AV75BR_EncounterListDS_3_View_ne_israndrecheck = AV64view_NE_IsRandRecheck;
         AV76BR_EncounterListDS_4_View_ne_isupdate = AV65view_NE_IsUpdate;
         AV77BR_EncounterListDS_5_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV79BR_EncounterListDS_7_Tfview_ne_information_patientno = AV13TFview_NE_Information_PatientNo;
         AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel = AV14TFview_NE_Information_PatientNo_Sel;
         AV81BR_EncounterListDS_9_Tfview_ne_department = AV15TFview_NE_Department;
         AV82BR_EncounterListDS_10_Tfview_ne_department_sel = AV16TFview_NE_Department_Sel;
         AV83BR_EncounterListDS_11_Tfview_ne_enctype = AV17TFview_NE_ENCType;
         AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel = AV18TFview_NE_ENCType_Sel;
         AV85BR_EncounterListDS_13_Tfview_ne_status_sels = AV61TFview_NE_Status_Sels;
         AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel = AV55TFview_NE_IsRandApprove_Sel;
         AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel = AV54TFview_NE_IsRandRecheck_Sel;
         AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel = AV56TFview_NE_IsUpdate_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                              AV73BR_EncounterListDS_1_Br_information_patientno ,
                                              AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                              AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                              AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                              AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                              AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                              AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                              AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                              AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                              AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                              AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                              AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels.Count ,
                                              AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                              AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                              AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                              AV51sBR_EncounterID ,
                                              AV50view_NE_AdmitDate ,
                                              AV68endview_NE_AdmitDate ,
                                              AV67tview_NE_Status ,
                                              A559view_NE_Information_PatientNo ,
                                              A555view_NE_IsRandApprove ,
                                              A554view_NE_IsRandRecheck ,
                                              A556view_NE_IsUpdate ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A557view_NE_TenantTenantCode ,
                                              AV52tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV73BR_EncounterListDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno), "%", "");
         lV79BR_EncounterListDS_7_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno), "%", "");
         lV81BR_EncounterListDS_9_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department), "%", "");
         lV83BR_EncounterListDS_11_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype), "%", "");
         lV51sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV51sBR_EncounterID), "%", "");
         /* Using cursor P004Q3 */
         pr_default.execute(1, new Object[] {AV52tCurrentCode, lV73BR_EncounterListDS_1_Br_information_patientno, AV74BR_EncounterListDS_2_View_ne_israndapprove, AV75BR_EncounterListDS_3_View_ne_israndrecheck, AV76BR_EncounterListDS_4_View_ne_isupdate, AV77BR_EncounterListDS_5_Tfview_ne_encounterid, AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to, lV79BR_EncounterListDS_7_Tfview_ne_information_patientno, AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel, lV81BR_EncounterListDS_9_Tfview_ne_department, AV82BR_EncounterListDS_10_Tfview_ne_department_sel, lV83BR_EncounterListDS_11_Tfview_ne_enctype, AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel, lV51sBR_EncounterID, AV50view_NE_AdmitDate, AV68endview_NE_AdmitDate, AV67tview_NE_Status});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4Q4 = false;
            A550view_NE_Department = P004Q3_A550view_NE_Department[0];
            n550view_NE_Department = P004Q3_n550view_NE_Department[0];
            A552view_NE_AdmitDate = P004Q3_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004Q3_n552view_NE_AdmitDate[0];
            A557view_NE_TenantTenantCode = P004Q3_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004Q3_n557view_NE_TenantTenantCode[0];
            A553view_NE_Status = P004Q3_A553view_NE_Status[0];
            n553view_NE_Status = P004Q3_n553view_NE_Status[0];
            A551view_NE_ENCType = P004Q3_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004Q3_n551view_NE_ENCType[0];
            A549view_NE_EncounterID = P004Q3_A549view_NE_EncounterID[0];
            A556view_NE_IsUpdate = P004Q3_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004Q3_n556view_NE_IsUpdate[0];
            A554view_NE_IsRandRecheck = P004Q3_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004Q3_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = P004Q3_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004Q3_n555view_NE_IsRandApprove[0];
            A559view_NE_Information_PatientNo = P004Q3_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004Q3_n559view_NE_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004Q3_A550view_NE_Department[0], A550view_NE_Department) == 0 ) )
            {
               BRK4Q4 = false;
               A549view_NE_EncounterID = P004Q3_A549view_NE_EncounterID[0];
               AV41count = (long)(AV41count+1);
               BRK4Q4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) )
            {
               AV33Option = A550view_NE_Department;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4Q4 )
            {
               BRK4Q4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADVIEW_NE_ENCTYPEOPTIONS' Routine */
         AV17TFview_NE_ENCType = AV29SearchTxt;
         AV18TFview_NE_ENCType_Sel = "";
         AV73BR_EncounterListDS_1_Br_information_patientno = AV47BR_Information_PatientNo;
         AV74BR_EncounterListDS_2_View_ne_israndapprove = AV63view_NE_IsRandApprove;
         AV75BR_EncounterListDS_3_View_ne_israndrecheck = AV64view_NE_IsRandRecheck;
         AV76BR_EncounterListDS_4_View_ne_isupdate = AV65view_NE_IsUpdate;
         AV77BR_EncounterListDS_5_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV79BR_EncounterListDS_7_Tfview_ne_information_patientno = AV13TFview_NE_Information_PatientNo;
         AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel = AV14TFview_NE_Information_PatientNo_Sel;
         AV81BR_EncounterListDS_9_Tfview_ne_department = AV15TFview_NE_Department;
         AV82BR_EncounterListDS_10_Tfview_ne_department_sel = AV16TFview_NE_Department_Sel;
         AV83BR_EncounterListDS_11_Tfview_ne_enctype = AV17TFview_NE_ENCType;
         AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel = AV18TFview_NE_ENCType_Sel;
         AV85BR_EncounterListDS_13_Tfview_ne_status_sels = AV61TFview_NE_Status_Sels;
         AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel = AV55TFview_NE_IsRandApprove_Sel;
         AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel = AV54TFview_NE_IsRandRecheck_Sel;
         AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel = AV56TFview_NE_IsUpdate_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                              AV73BR_EncounterListDS_1_Br_information_patientno ,
                                              AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                              AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                              AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                              AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                              AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                              AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                              AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                              AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                              AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                              AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                              AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                              AV85BR_EncounterListDS_13_Tfview_ne_status_sels.Count ,
                                              AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                              AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                              AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                              AV51sBR_EncounterID ,
                                              AV50view_NE_AdmitDate ,
                                              AV68endview_NE_AdmitDate ,
                                              AV67tview_NE_Status ,
                                              A559view_NE_Information_PatientNo ,
                                              A555view_NE_IsRandApprove ,
                                              A554view_NE_IsRandRecheck ,
                                              A556view_NE_IsUpdate ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A557view_NE_TenantTenantCode ,
                                              AV52tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV73BR_EncounterListDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno), "%", "");
         lV79BR_EncounterListDS_7_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno), "%", "");
         lV81BR_EncounterListDS_9_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department), "%", "");
         lV83BR_EncounterListDS_11_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype), "%", "");
         lV51sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV51sBR_EncounterID), "%", "");
         /* Using cursor P004Q4 */
         pr_default.execute(2, new Object[] {AV52tCurrentCode, lV73BR_EncounterListDS_1_Br_information_patientno, AV74BR_EncounterListDS_2_View_ne_israndapprove, AV75BR_EncounterListDS_3_View_ne_israndrecheck, AV76BR_EncounterListDS_4_View_ne_isupdate, AV77BR_EncounterListDS_5_Tfview_ne_encounterid, AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to, lV79BR_EncounterListDS_7_Tfview_ne_information_patientno, AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel, lV81BR_EncounterListDS_9_Tfview_ne_department, AV82BR_EncounterListDS_10_Tfview_ne_department_sel, lV83BR_EncounterListDS_11_Tfview_ne_enctype, AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel, lV51sBR_EncounterID, AV50view_NE_AdmitDate, AV68endview_NE_AdmitDate, AV67tview_NE_Status});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK4Q6 = false;
            A551view_NE_ENCType = P004Q4_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004Q4_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = P004Q4_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004Q4_n552view_NE_AdmitDate[0];
            A557view_NE_TenantTenantCode = P004Q4_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004Q4_n557view_NE_TenantTenantCode[0];
            A553view_NE_Status = P004Q4_A553view_NE_Status[0];
            n553view_NE_Status = P004Q4_n553view_NE_Status[0];
            A550view_NE_Department = P004Q4_A550view_NE_Department[0];
            n550view_NE_Department = P004Q4_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004Q4_A549view_NE_EncounterID[0];
            A556view_NE_IsUpdate = P004Q4_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004Q4_n556view_NE_IsUpdate[0];
            A554view_NE_IsRandRecheck = P004Q4_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004Q4_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = P004Q4_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004Q4_n555view_NE_IsRandApprove[0];
            A559view_NE_Information_PatientNo = P004Q4_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004Q4_n559view_NE_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P004Q4_A551view_NE_ENCType[0], A551view_NE_ENCType) == 0 ) )
            {
               BRK4Q6 = false;
               A549view_NE_EncounterID = P004Q4_A549view_NE_EncounterID[0];
               AV41count = (long)(AV41count+1);
               BRK4Q6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) )
            {
               AV33Option = A551view_NE_ENCType;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4Q6 )
            {
               BRK4Q6 = true;
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
         AV34Options = new GxSimpleCollection<String>();
         AV37OptionsDesc = new GxSimpleCollection<String>();
         AV39OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV42Session = context.GetSession();
         AV44GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV45GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV47BR_Information_PatientNo = "";
         AV13TFview_NE_Information_PatientNo = "";
         AV14TFview_NE_Information_PatientNo_Sel = "";
         AV15TFview_NE_Department = "";
         AV16TFview_NE_Department_Sel = "";
         AV17TFview_NE_ENCType = "";
         AV18TFview_NE_ENCType_Sel = "";
         AV60TFview_NE_Status_SelsJson = "";
         AV61TFview_NE_Status_Sels = new GxSimpleCollection<short>();
         AV73BR_EncounterListDS_1_Br_information_patientno = "";
         AV79BR_EncounterListDS_7_Tfview_ne_information_patientno = "";
         AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel = "";
         AV81BR_EncounterListDS_9_Tfview_ne_department = "";
         AV82BR_EncounterListDS_10_Tfview_ne_department_sel = "";
         AV83BR_EncounterListDS_11_Tfview_ne_enctype = "";
         AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel = "";
         AV85BR_EncounterListDS_13_Tfview_ne_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         lV73BR_EncounterListDS_1_Br_information_patientno = "";
         lV79BR_EncounterListDS_7_Tfview_ne_information_patientno = "";
         lV81BR_EncounterListDS_9_Tfview_ne_department = "";
         lV83BR_EncounterListDS_11_Tfview_ne_enctype = "";
         lV51sBR_EncounterID = "";
         AV51sBR_EncounterID = "";
         AV50view_NE_AdmitDate = DateTime.MinValue;
         AV68endview_NE_AdmitDate = DateTime.MinValue;
         A559view_NE_Information_PatientNo = "";
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         A552view_NE_AdmitDate = DateTime.MinValue;
         A557view_NE_TenantTenantCode = "";
         AV52tCurrentCode = "";
         P004Q2_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004Q2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004Q2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004Q2_n552view_NE_AdmitDate = new bool[] {false} ;
         P004Q2_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004Q2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004Q2_A553view_NE_Status = new short[1] ;
         P004Q2_n553view_NE_Status = new bool[] {false} ;
         P004Q2_A551view_NE_ENCType = new String[] {""} ;
         P004Q2_n551view_NE_ENCType = new bool[] {false} ;
         P004Q2_A550view_NE_Department = new String[] {""} ;
         P004Q2_n550view_NE_Department = new bool[] {false} ;
         P004Q2_A549view_NE_EncounterID = new long[1] ;
         P004Q2_A556view_NE_IsUpdate = new bool[] {false} ;
         P004Q2_n556view_NE_IsUpdate = new bool[] {false} ;
         P004Q2_A554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q2_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q2_A555view_NE_IsRandApprove = new bool[] {false} ;
         P004Q2_n555view_NE_IsRandApprove = new bool[] {false} ;
         AV33Option = "";
         P004Q3_A550view_NE_Department = new String[] {""} ;
         P004Q3_n550view_NE_Department = new bool[] {false} ;
         P004Q3_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004Q3_n552view_NE_AdmitDate = new bool[] {false} ;
         P004Q3_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004Q3_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004Q3_A553view_NE_Status = new short[1] ;
         P004Q3_n553view_NE_Status = new bool[] {false} ;
         P004Q3_A551view_NE_ENCType = new String[] {""} ;
         P004Q3_n551view_NE_ENCType = new bool[] {false} ;
         P004Q3_A549view_NE_EncounterID = new long[1] ;
         P004Q3_A556view_NE_IsUpdate = new bool[] {false} ;
         P004Q3_n556view_NE_IsUpdate = new bool[] {false} ;
         P004Q3_A554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q3_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q3_A555view_NE_IsRandApprove = new bool[] {false} ;
         P004Q3_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004Q3_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004Q3_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004Q4_A551view_NE_ENCType = new String[] {""} ;
         P004Q4_n551view_NE_ENCType = new bool[] {false} ;
         P004Q4_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004Q4_n552view_NE_AdmitDate = new bool[] {false} ;
         P004Q4_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004Q4_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004Q4_A553view_NE_Status = new short[1] ;
         P004Q4_n553view_NE_Status = new bool[] {false} ;
         P004Q4_A550view_NE_Department = new String[] {""} ;
         P004Q4_n550view_NE_Department = new bool[] {false} ;
         P004Q4_A549view_NE_EncounterID = new long[1] ;
         P004Q4_A556view_NE_IsUpdate = new bool[] {false} ;
         P004Q4_n556view_NE_IsUpdate = new bool[] {false} ;
         P004Q4_A554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q4_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004Q4_A555view_NE_IsRandApprove = new bool[] {false} ;
         P004Q4_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004Q4_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004Q4_n559view_NE_Information_PatientNo = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterlistgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004Q2_A559view_NE_Information_PatientNo, P004Q2_n559view_NE_Information_PatientNo, P004Q2_A552view_NE_AdmitDate, P004Q2_n552view_NE_AdmitDate, P004Q2_A557view_NE_TenantTenantCode, P004Q2_n557view_NE_TenantTenantCode, P004Q2_A553view_NE_Status, P004Q2_n553view_NE_Status, P004Q2_A551view_NE_ENCType, P004Q2_n551view_NE_ENCType,
               P004Q2_A550view_NE_Department, P004Q2_n550view_NE_Department, P004Q2_A549view_NE_EncounterID, P004Q2_A556view_NE_IsUpdate, P004Q2_n556view_NE_IsUpdate, P004Q2_A554view_NE_IsRandRecheck, P004Q2_n554view_NE_IsRandRecheck, P004Q2_A555view_NE_IsRandApprove, P004Q2_n555view_NE_IsRandApprove
               }
               , new Object[] {
               P004Q3_A550view_NE_Department, P004Q3_n550view_NE_Department, P004Q3_A552view_NE_AdmitDate, P004Q3_n552view_NE_AdmitDate, P004Q3_A557view_NE_TenantTenantCode, P004Q3_n557view_NE_TenantTenantCode, P004Q3_A553view_NE_Status, P004Q3_n553view_NE_Status, P004Q3_A551view_NE_ENCType, P004Q3_n551view_NE_ENCType,
               P004Q3_A549view_NE_EncounterID, P004Q3_A556view_NE_IsUpdate, P004Q3_n556view_NE_IsUpdate, P004Q3_A554view_NE_IsRandRecheck, P004Q3_n554view_NE_IsRandRecheck, P004Q3_A555view_NE_IsRandApprove, P004Q3_n555view_NE_IsRandApprove, P004Q3_A559view_NE_Information_PatientNo, P004Q3_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               P004Q4_A551view_NE_ENCType, P004Q4_n551view_NE_ENCType, P004Q4_A552view_NE_AdmitDate, P004Q4_n552view_NE_AdmitDate, P004Q4_A557view_NE_TenantTenantCode, P004Q4_n557view_NE_TenantTenantCode, P004Q4_A553view_NE_Status, P004Q4_n553view_NE_Status, P004Q4_A550view_NE_Department, P004Q4_n550view_NE_Department,
               P004Q4_A549view_NE_EncounterID, P004Q4_A556view_NE_IsUpdate, P004Q4_n556view_NE_IsUpdate, P004Q4_A554view_NE_IsRandRecheck, P004Q4_n554view_NE_IsRandRecheck, P004Q4_A555view_NE_IsRandApprove, P004Q4_n555view_NE_IsRandApprove, P004Q4_A559view_NE_Information_PatientNo, P004Q4_n559view_NE_Information_PatientNo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV55TFview_NE_IsRandApprove_Sel ;
      private short AV54TFview_NE_IsRandRecheck_Sel ;
      private short AV56TFview_NE_IsUpdate_Sel ;
      private short AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ;
      private short AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ;
      private short AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ;
      private short A553view_NE_Status ;
      private short AV67tview_NE_Status ;
      private int AV71GXV1 ;
      private int AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count ;
      private long AV11TFview_NE_EncounterID ;
      private long AV12TFview_NE_EncounterID_To ;
      private long AV77BR_EncounterListDS_5_Tfview_ne_encounterid ;
      private long AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ;
      private long A549view_NE_EncounterID ;
      private long AV41count ;
      private String scmdbuf ;
      private DateTime AV50view_NE_AdmitDate ;
      private DateTime AV68endview_NE_AdmitDate ;
      private DateTime A552view_NE_AdmitDate ;
      private bool returnInSub ;
      private bool AV63view_NE_IsRandApprove ;
      private bool AV64view_NE_IsRandRecheck ;
      private bool AV65view_NE_IsUpdate ;
      private bool AV74BR_EncounterListDS_2_View_ne_israndapprove ;
      private bool AV75BR_EncounterListDS_3_View_ne_israndrecheck ;
      private bool AV76BR_EncounterListDS_4_View_ne_isupdate ;
      private bool A555view_NE_IsRandApprove ;
      private bool A554view_NE_IsRandRecheck ;
      private bool A556view_NE_IsUpdate ;
      private bool BRK4Q2 ;
      private bool n559view_NE_Information_PatientNo ;
      private bool n552view_NE_AdmitDate ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n553view_NE_Status ;
      private bool n551view_NE_ENCType ;
      private bool n550view_NE_Department ;
      private bool n556view_NE_IsUpdate ;
      private bool n554view_NE_IsRandRecheck ;
      private bool n555view_NE_IsRandApprove ;
      private bool BRK4Q4 ;
      private bool BRK4Q6 ;
      private String AV40OptionIndexesJson ;
      private String AV35OptionsJson ;
      private String AV38OptionsDescJson ;
      private String AV60TFview_NE_Status_SelsJson ;
      private String AV31DDOName ;
      private String AV29SearchTxt ;
      private String AV30SearchTxtTo ;
      private String AV47BR_Information_PatientNo ;
      private String AV13TFview_NE_Information_PatientNo ;
      private String AV14TFview_NE_Information_PatientNo_Sel ;
      private String AV15TFview_NE_Department ;
      private String AV16TFview_NE_Department_Sel ;
      private String AV17TFview_NE_ENCType ;
      private String AV18TFview_NE_ENCType_Sel ;
      private String AV73BR_EncounterListDS_1_Br_information_patientno ;
      private String AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ;
      private String AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ;
      private String AV81BR_EncounterListDS_9_Tfview_ne_department ;
      private String AV82BR_EncounterListDS_10_Tfview_ne_department_sel ;
      private String AV83BR_EncounterListDS_11_Tfview_ne_enctype ;
      private String AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ;
      private String lV73BR_EncounterListDS_1_Br_information_patientno ;
      private String lV79BR_EncounterListDS_7_Tfview_ne_information_patientno ;
      private String lV81BR_EncounterListDS_9_Tfview_ne_department ;
      private String lV83BR_EncounterListDS_11_Tfview_ne_enctype ;
      private String lV51sBR_EncounterID ;
      private String AV51sBR_EncounterID ;
      private String A559view_NE_Information_PatientNo ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String A557view_NE_TenantTenantCode ;
      private String AV52tCurrentCode ;
      private String AV33Option ;
      private GxSimpleCollection<short> AV61TFview_NE_Status_Sels ;
      private GxSimpleCollection<short> AV85BR_EncounterListDS_13_Tfview_ne_status_sels ;
      private IGxSession AV42Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004Q2_A559view_NE_Information_PatientNo ;
      private bool[] P004Q2_n559view_NE_Information_PatientNo ;
      private DateTime[] P004Q2_A552view_NE_AdmitDate ;
      private bool[] P004Q2_n552view_NE_AdmitDate ;
      private String[] P004Q2_A557view_NE_TenantTenantCode ;
      private bool[] P004Q2_n557view_NE_TenantTenantCode ;
      private short[] P004Q2_A553view_NE_Status ;
      private bool[] P004Q2_n553view_NE_Status ;
      private String[] P004Q2_A551view_NE_ENCType ;
      private bool[] P004Q2_n551view_NE_ENCType ;
      private String[] P004Q2_A550view_NE_Department ;
      private bool[] P004Q2_n550view_NE_Department ;
      private long[] P004Q2_A549view_NE_EncounterID ;
      private bool[] P004Q2_A556view_NE_IsUpdate ;
      private bool[] P004Q2_n556view_NE_IsUpdate ;
      private bool[] P004Q2_A554view_NE_IsRandRecheck ;
      private bool[] P004Q2_n554view_NE_IsRandRecheck ;
      private bool[] P004Q2_A555view_NE_IsRandApprove ;
      private bool[] P004Q2_n555view_NE_IsRandApprove ;
      private String[] P004Q3_A550view_NE_Department ;
      private bool[] P004Q3_n550view_NE_Department ;
      private DateTime[] P004Q3_A552view_NE_AdmitDate ;
      private bool[] P004Q3_n552view_NE_AdmitDate ;
      private String[] P004Q3_A557view_NE_TenantTenantCode ;
      private bool[] P004Q3_n557view_NE_TenantTenantCode ;
      private short[] P004Q3_A553view_NE_Status ;
      private bool[] P004Q3_n553view_NE_Status ;
      private String[] P004Q3_A551view_NE_ENCType ;
      private bool[] P004Q3_n551view_NE_ENCType ;
      private long[] P004Q3_A549view_NE_EncounterID ;
      private bool[] P004Q3_A556view_NE_IsUpdate ;
      private bool[] P004Q3_n556view_NE_IsUpdate ;
      private bool[] P004Q3_A554view_NE_IsRandRecheck ;
      private bool[] P004Q3_n554view_NE_IsRandRecheck ;
      private bool[] P004Q3_A555view_NE_IsRandApprove ;
      private bool[] P004Q3_n555view_NE_IsRandApprove ;
      private String[] P004Q3_A559view_NE_Information_PatientNo ;
      private bool[] P004Q3_n559view_NE_Information_PatientNo ;
      private String[] P004Q4_A551view_NE_ENCType ;
      private bool[] P004Q4_n551view_NE_ENCType ;
      private DateTime[] P004Q4_A552view_NE_AdmitDate ;
      private bool[] P004Q4_n552view_NE_AdmitDate ;
      private String[] P004Q4_A557view_NE_TenantTenantCode ;
      private bool[] P004Q4_n557view_NE_TenantTenantCode ;
      private short[] P004Q4_A553view_NE_Status ;
      private bool[] P004Q4_n553view_NE_Status ;
      private String[] P004Q4_A550view_NE_Department ;
      private bool[] P004Q4_n550view_NE_Department ;
      private long[] P004Q4_A549view_NE_EncounterID ;
      private bool[] P004Q4_A556view_NE_IsUpdate ;
      private bool[] P004Q4_n556view_NE_IsUpdate ;
      private bool[] P004Q4_A554view_NE_IsRandRecheck ;
      private bool[] P004Q4_n554view_NE_IsRandRecheck ;
      private bool[] P004Q4_A555view_NE_IsRandApprove ;
      private bool[] P004Q4_n555view_NE_IsRandApprove ;
      private String[] P004Q4_A559view_NE_Information_PatientNo ;
      private bool[] P004Q4_n559view_NE_Information_PatientNo ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV34Options ;
      private GxSimpleCollection<String> AV37OptionsDesc ;
      private GxSimpleCollection<String> AV39OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV44GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV45GridStateFilterValue ;
   }

   public class br_encounterlistgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004Q2( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                             String AV73BR_EncounterListDS_1_Br_information_patientno ,
                                             bool AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                             bool AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                             bool AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                             long AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                             long AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                             String AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                             String AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                             String AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                             String AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                             String AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                             String AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                             int AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count ,
                                             short AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                             short AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                             short AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                             String AV51sBR_EncounterID ,
                                             DateTime AV50view_NE_AdmitDate ,
                                             DateTime AV68endview_NE_AdmitDate ,
                                             short AV67tview_NE_Status ,
                                             String A559view_NE_Information_PatientNo ,
                                             bool A555view_NE_IsRandApprove ,
                                             bool A554view_NE_IsRandRecheck ,
                                             bool A556view_NE_IsUpdate ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             String A557view_NE_TenantTenantCode ,
                                             String AV52tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [17] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Information_PatientNo], [view_NE_AdmitDate], [view_NE_TenantTenantCode], [view_NE_Status], [view_NE_ENCType], [view_NE_Department], [view_NE_EncounterID], [view_NE_IsUpdate], [view_NE_IsRandRecheck], [view_NE_IsRandApprove] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([view_NE_TenantTenantCode])) = @AV52tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like '%' + @lV73BR_EncounterListDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (false==AV74BR_EncounterListDS_2_View_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = @AV74BR_EncounterListDS_2_View_ne_israndapprove)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV75BR_EncounterListDS_3_View_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = @AV75BR_EncounterListDS_3_View_ne_israndrecheck)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (false==AV76BR_EncounterListDS_4_View_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = @AV76BR_EncounterListDS_4_View_ne_isupdate)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV77BR_EncounterListDS_5_Tfview_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV77BR_EncounterListDS_5_Tfview_ne_encounterid)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV79BR_EncounterListDS_7_Tfview_ne_information_patientno)";
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] like @lV81BR_EncounterListDS_9_Tfview_ne_department)";
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] = @AV82BR_EncounterListDS_10_Tfview_ne_department_sel)";
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV83BR_EncounterListDS_11_Tfview_ne_enctype)";
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)";
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV85BR_EncounterListDS_13_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 1)";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 0)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 1)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 0)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 1)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV51sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV50view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV50view_NE_AdmitDate)";
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV68endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV68endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int1[15] = 1;
         }
         if ( ! (0==AV67tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV67tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int1[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Information_PatientNo]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004Q3( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                             String AV73BR_EncounterListDS_1_Br_information_patientno ,
                                             bool AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                             bool AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                             bool AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                             long AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                             long AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                             String AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                             String AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                             String AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                             String AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                             String AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                             String AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                             int AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count ,
                                             short AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                             short AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                             short AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                             String AV51sBR_EncounterID ,
                                             DateTime AV50view_NE_AdmitDate ,
                                             DateTime AV68endview_NE_AdmitDate ,
                                             short AV67tview_NE_Status ,
                                             String A559view_NE_Information_PatientNo ,
                                             bool A555view_NE_IsRandApprove ,
                                             bool A554view_NE_IsRandRecheck ,
                                             bool A556view_NE_IsUpdate ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             String A557view_NE_TenantTenantCode ,
                                             String AV52tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [17] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Department], [view_NE_AdmitDate], [view_NE_TenantTenantCode], [view_NE_Status], [view_NE_ENCType], [view_NE_EncounterID], [view_NE_IsUpdate], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([view_NE_TenantTenantCode])) = @AV52tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like '%' + @lV73BR_EncounterListDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (false==AV74BR_EncounterListDS_2_View_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = @AV74BR_EncounterListDS_2_View_ne_israndapprove)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (false==AV75BR_EncounterListDS_3_View_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = @AV75BR_EncounterListDS_3_View_ne_israndrecheck)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (false==AV76BR_EncounterListDS_4_View_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = @AV76BR_EncounterListDS_4_View_ne_isupdate)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV77BR_EncounterListDS_5_Tfview_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV77BR_EncounterListDS_5_Tfview_ne_encounterid)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV79BR_EncounterListDS_7_Tfview_ne_information_patientno)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] like @lV81BR_EncounterListDS_9_Tfview_ne_department)";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] = @AV82BR_EncounterListDS_10_Tfview_ne_department_sel)";
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV83BR_EncounterListDS_11_Tfview_ne_enctype)";
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)";
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV85BR_EncounterListDS_13_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 1)";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 0)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 1)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 0)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 1)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV51sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV50view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV50view_NE_AdmitDate)";
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV68endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV68endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( ! (0==AV67tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV67tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int3[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Department]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P004Q4( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV85BR_EncounterListDS_13_Tfview_ne_status_sels ,
                                             String AV73BR_EncounterListDS_1_Br_information_patientno ,
                                             bool AV74BR_EncounterListDS_2_View_ne_israndapprove ,
                                             bool AV75BR_EncounterListDS_3_View_ne_israndrecheck ,
                                             bool AV76BR_EncounterListDS_4_View_ne_isupdate ,
                                             long AV77BR_EncounterListDS_5_Tfview_ne_encounterid ,
                                             long AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to ,
                                             String AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel ,
                                             String AV79BR_EncounterListDS_7_Tfview_ne_information_patientno ,
                                             String AV82BR_EncounterListDS_10_Tfview_ne_department_sel ,
                                             String AV81BR_EncounterListDS_9_Tfview_ne_department ,
                                             String AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel ,
                                             String AV83BR_EncounterListDS_11_Tfview_ne_enctype ,
                                             int AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count ,
                                             short AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel ,
                                             short AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel ,
                                             short AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel ,
                                             String AV51sBR_EncounterID ,
                                             DateTime AV50view_NE_AdmitDate ,
                                             DateTime AV68endview_NE_AdmitDate ,
                                             short AV67tview_NE_Status ,
                                             String A559view_NE_Information_PatientNo ,
                                             bool A555view_NE_IsRandApprove ,
                                             bool A554view_NE_IsRandRecheck ,
                                             bool A556view_NE_IsUpdate ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             String A557view_NE_TenantTenantCode ,
                                             String AV52tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [17] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_TenantTenantCode], [view_NE_Status], [view_NE_Department], [view_NE_EncounterID], [view_NE_IsUpdate], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([view_NE_TenantTenantCode])) = @AV52tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_EncounterListDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like '%' + @lV73BR_EncounterListDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (false==AV74BR_EncounterListDS_2_View_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = @AV74BR_EncounterListDS_2_View_ne_israndapprove)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (false==AV75BR_EncounterListDS_3_View_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = @AV75BR_EncounterListDS_3_View_ne_israndrecheck)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (false==AV76BR_EncounterListDS_4_View_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = @AV76BR_EncounterListDS_4_View_ne_isupdate)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (0==AV77BR_EncounterListDS_5_Tfview_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV77BR_EncounterListDS_5_Tfview_ne_encounterid)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_EncounterListDS_7_Tfview_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV79BR_EncounterListDS_7_Tfview_ne_information_patientno)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_EncounterListDS_9_Tfview_ne_department)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] like @lV81BR_EncounterListDS_9_Tfview_ne_department)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_EncounterListDS_10_Tfview_ne_department_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] = @AV82BR_EncounterListDS_10_Tfview_ne_department_sel)";
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_EncounterListDS_11_Tfview_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV83BR_EncounterListDS_11_Tfview_ne_enctype)";
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel)";
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( AV85BR_EncounterListDS_13_Tfview_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV85BR_EncounterListDS_13_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 1)";
         }
         if ( AV86BR_EncounterListDS_14_Tfview_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandApprove] = 0)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 1)";
         }
         if ( AV87BR_EncounterListDS_15_Tfview_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] = 0)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 1)";
         }
         if ( AV88BR_EncounterListDS_16_Tfview_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV51sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV50view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV50view_NE_AdmitDate)";
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV68endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV68endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( ! (0==AV67tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV67tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int5[16] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType]";
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
                     return conditional_P004Q2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
               case 1 :
                     return conditional_P004Q3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
               case 2 :
                     return conditional_P004Q4(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] );
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
          Object[] prmP004Q2 ;
          prmP004Q2 = new Object[] {
          new Object[] {"@AV52tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV73BR_EncounterListDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV74BR_EncounterListDS_2_View_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListDS_3_View_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListDS_4_View_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV77BR_EncounterListDS_5_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV79BR_EncounterListDS_7_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_EncounterListDS_9_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_EncounterListDS_10_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_EncounterListDS_11_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV51sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV50view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP004Q3 ;
          prmP004Q3 = new Object[] {
          new Object[] {"@AV52tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV73BR_EncounterListDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV74BR_EncounterListDS_2_View_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListDS_3_View_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListDS_4_View_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV77BR_EncounterListDS_5_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV79BR_EncounterListDS_7_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_EncounterListDS_9_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_EncounterListDS_10_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_EncounterListDS_11_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV51sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV50view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP004Q4 ;
          prmP004Q4 = new Object[] {
          new Object[] {"@AV52tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV73BR_EncounterListDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV74BR_EncounterListDS_2_View_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV75BR_EncounterListDS_3_View_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV76BR_EncounterListDS_4_View_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV77BR_EncounterListDS_5_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV78BR_EncounterListDS_6_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV79BR_EncounterListDS_7_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_EncounterListDS_8_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_EncounterListDS_9_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_EncounterListDS_10_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_EncounterListDS_11_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV84BR_EncounterListDS_12_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV51sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV50view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV68endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004Q2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004Q2,100,0,true,false )
             ,new CursorDef("P004Q3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004Q3,100,0,true,false )
             ,new CursorDef("P004Q4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004Q4,100,0,true,false )
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

 [ServiceContract(Namespace = "GeneXus.Programs.br_encounterlistgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encounterlistgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encounterlistgetfilterdata") )
          {
             return  ;
          }
          br_encounterlistgetfilterdata worker = new br_encounterlistgetfilterdata(context) ;
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
