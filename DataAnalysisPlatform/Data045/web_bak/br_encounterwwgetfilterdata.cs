/*
               File: BR_EncounterWWGetFilterData
        Description: BR_Encounter WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 17:26:9.3
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
   public class br_encounterwwgetfilterdata : GXProcedure
   {
      public br_encounterwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterwwgetfilterdata( IGxContext context )
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
         br_encounterwwgetfilterdata objbr_encounterwwgetfilterdata;
         objbr_encounterwwgetfilterdata = new br_encounterwwgetfilterdata();
         objbr_encounterwwgetfilterdata.AV19DDOName = aP0_DDOName;
         objbr_encounterwwgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objbr_encounterwwgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objbr_encounterwwgetfilterdata.AV23OptionsJson = "" ;
         objbr_encounterwwgetfilterdata.AV26OptionsDescJson = "" ;
         objbr_encounterwwgetfilterdata.AV28OptionIndexesJson = "" ;
         objbr_encounterwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encounterwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encounterwwgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encounterwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_VIEW_NE_DEPARTMENT") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_DEPARTMENTOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_VIEW_NE_ENCTYPE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_ENCTYPEOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
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
         if ( StringUtil.StrCmp(AV30Session.Get("BR_EncounterWWGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EncounterWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("BR_EncounterWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV59GXV1 = 1;
         while ( AV59GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV59GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "VIEW_NE_INFORMATION_PATIENTNO") == 0 )
            {
               AV47view_NE_Information_PatientNo = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "VIEW_NE_ADMITDATE") == 0 )
            {
               AV50view_NE_AdmitDate = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Value, 0);
               AV48view_NE_AdmitDateOperator = AV33GridStateFilterValue.gxTpr_Operator;
               AV49view_NE_AdmitDate_To = context.localUtil.CToT( AV33GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT") == 0 )
            {
               AV13TFview_NE_Department = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT_SEL") == 0 )
            {
               AV14TFview_NE_Department_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE") == 0 )
            {
               AV15TFview_NE_ENCType = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV16TFview_NE_ENCType_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            AV59GXV1 = (int)(AV59GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_NE_DEPARTMENTOPTIONS' Routine */
         AV13TFview_NE_Department = AV17SearchTxt;
         AV14TFview_NE_Department_Sel = "";
         AV61BR_EncounterWWDS_1_View_ne_information_patientno = AV47view_NE_Information_PatientNo;
         AV62BR_EncounterWWDS_2_View_ne_admitdate = AV50view_NE_AdmitDate;
         AV63BR_EncounterWWDS_3_View_ne_admitdate_to = AV49view_NE_AdmitDate_To;
         AV64BR_EncounterWWDS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV65BR_EncounterWWDS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV66BR_EncounterWWDS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV61BR_EncounterWWDS_1_View_ne_information_patientno ,
                                              AV48view_NE_AdmitDateOperator ,
                                              AV62BR_EncounterWWDS_2_View_ne_admitdate ,
                                              AV63BR_EncounterWWDS_3_View_ne_admitdate_to ,
                                              AV65BR_EncounterWWDS_5_Tfview_ne_department_sel ,
                                              AV64BR_EncounterWWDS_4_Tfview_ne_department ,
                                              AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel ,
                                              AV66BR_EncounterWWDS_6_Tfview_ne_enctype ,
                                              AV43sBR_EncounterID ,
                                              AV52view_NE_IsRandApprove ,
                                              AV39BR_Encounter_Status ,
                                              A559view_NE_Information_PatientNo ,
                                              A552view_NE_AdmitDate ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A549view_NE_EncounterID ,
                                              AV56status ,
                                              A553view_NE_Status ,
                                              A557view_NE_TenantTenantCode ,
                                              AV44tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV61BR_EncounterWWDS_1_View_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV61BR_EncounterWWDS_1_View_ne_information_patientno), "%", "");
         lV64BR_EncounterWWDS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV64BR_EncounterWWDS_4_Tfview_ne_department), "%", "");
         lV66BR_EncounterWWDS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV66BR_EncounterWWDS_6_Tfview_ne_enctype), "%", "");
         lV43sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV43sBR_EncounterID), "%", "");
         /* Using cursor P004O2 */
         pr_default.execute(0, new Object[] {AV56status, AV44tCurrentCode, lV61BR_EncounterWWDS_1_View_ne_information_patientno, AV62BR_EncounterWWDS_2_View_ne_admitdate, AV63BR_EncounterWWDS_3_View_ne_admitdate_to, lV64BR_EncounterWWDS_4_Tfview_ne_department, AV65BR_EncounterWWDS_5_Tfview_ne_department_sel, lV66BR_EncounterWWDS_6_Tfview_ne_enctype, AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel, lV43sBR_EncounterID, AV52view_NE_IsRandApprove, AV56status, AV39BR_Encounter_Status});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4O2 = false;
            A557view_NE_TenantTenantCode = P004O2_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004O2_n557view_NE_TenantTenantCode[0];
            A550view_NE_Department = P004O2_A550view_NE_Department[0];
            n550view_NE_Department = P004O2_n550view_NE_Department[0];
            A553view_NE_Status = P004O2_A553view_NE_Status[0];
            n553view_NE_Status = P004O2_n553view_NE_Status[0];
            A549view_NE_EncounterID = P004O2_A549view_NE_EncounterID[0];
            A551view_NE_ENCType = P004O2_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004O2_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = P004O2_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004O2_n552view_NE_AdmitDate[0];
            A559view_NE_Information_PatientNo = P004O2_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004O2_n559view_NE_Information_PatientNo[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004O2_A550view_NE_Department[0], A550view_NE_Department) == 0 ) )
            {
               BRK4O2 = false;
               A549view_NE_EncounterID = P004O2_A549view_NE_EncounterID[0];
               AV29count = (long)(AV29count+1);
               BRK4O2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) )
            {
               AV21Option = A550view_NE_Department;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4O2 )
            {
               BRK4O2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_NE_ENCTYPEOPTIONS' Routine */
         AV15TFview_NE_ENCType = AV17SearchTxt;
         AV16TFview_NE_ENCType_Sel = "";
         AV61BR_EncounterWWDS_1_View_ne_information_patientno = AV47view_NE_Information_PatientNo;
         AV62BR_EncounterWWDS_2_View_ne_admitdate = AV50view_NE_AdmitDate;
         AV63BR_EncounterWWDS_3_View_ne_admitdate_to = AV49view_NE_AdmitDate_To;
         AV64BR_EncounterWWDS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV65BR_EncounterWWDS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV66BR_EncounterWWDS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV61BR_EncounterWWDS_1_View_ne_information_patientno ,
                                              AV48view_NE_AdmitDateOperator ,
                                              AV62BR_EncounterWWDS_2_View_ne_admitdate ,
                                              AV63BR_EncounterWWDS_3_View_ne_admitdate_to ,
                                              AV65BR_EncounterWWDS_5_Tfview_ne_department_sel ,
                                              AV64BR_EncounterWWDS_4_Tfview_ne_department ,
                                              AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel ,
                                              AV66BR_EncounterWWDS_6_Tfview_ne_enctype ,
                                              AV43sBR_EncounterID ,
                                              AV52view_NE_IsRandApprove ,
                                              AV39BR_Encounter_Status ,
                                              A559view_NE_Information_PatientNo ,
                                              A552view_NE_AdmitDate ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A549view_NE_EncounterID ,
                                              AV56status ,
                                              A553view_NE_Status ,
                                              A557view_NE_TenantTenantCode ,
                                              AV44tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV61BR_EncounterWWDS_1_View_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV61BR_EncounterWWDS_1_View_ne_information_patientno), "%", "");
         lV64BR_EncounterWWDS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV64BR_EncounterWWDS_4_Tfview_ne_department), "%", "");
         lV66BR_EncounterWWDS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV66BR_EncounterWWDS_6_Tfview_ne_enctype), "%", "");
         lV43sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV43sBR_EncounterID), "%", "");
         /* Using cursor P004O3 */
         pr_default.execute(1, new Object[] {AV56status, AV44tCurrentCode, lV61BR_EncounterWWDS_1_View_ne_information_patientno, AV62BR_EncounterWWDS_2_View_ne_admitdate, AV63BR_EncounterWWDS_3_View_ne_admitdate_to, lV64BR_EncounterWWDS_4_Tfview_ne_department, AV65BR_EncounterWWDS_5_Tfview_ne_department_sel, lV66BR_EncounterWWDS_6_Tfview_ne_enctype, AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel, lV43sBR_EncounterID, AV52view_NE_IsRandApprove, AV56status, AV39BR_Encounter_Status});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4O4 = false;
            A557view_NE_TenantTenantCode = P004O3_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004O3_n557view_NE_TenantTenantCode[0];
            A551view_NE_ENCType = P004O3_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004O3_n551view_NE_ENCType[0];
            A553view_NE_Status = P004O3_A553view_NE_Status[0];
            n553view_NE_Status = P004O3_n553view_NE_Status[0];
            A549view_NE_EncounterID = P004O3_A549view_NE_EncounterID[0];
            A550view_NE_Department = P004O3_A550view_NE_Department[0];
            n550view_NE_Department = P004O3_n550view_NE_Department[0];
            A552view_NE_AdmitDate = P004O3_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004O3_n552view_NE_AdmitDate[0];
            A559view_NE_Information_PatientNo = P004O3_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004O3_n559view_NE_Information_PatientNo[0];
            AV29count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004O3_A551view_NE_ENCType[0], A551view_NE_ENCType) == 0 ) )
            {
               BRK4O4 = false;
               A549view_NE_EncounterID = P004O3_A549view_NE_EncounterID[0];
               AV29count = (long)(AV29count+1);
               BRK4O4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) )
            {
               AV21Option = A551view_NE_ENCType;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4O4 )
            {
               BRK4O4 = true;
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
         AV47view_NE_Information_PatientNo = "";
         AV50view_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         AV49view_NE_AdmitDate_To = (DateTime)(DateTime.MinValue);
         AV13TFview_NE_Department = "";
         AV14TFview_NE_Department_Sel = "";
         AV15TFview_NE_ENCType = "";
         AV16TFview_NE_ENCType_Sel = "";
         AV61BR_EncounterWWDS_1_View_ne_information_patientno = "";
         AV62BR_EncounterWWDS_2_View_ne_admitdate = (DateTime)(DateTime.MinValue);
         AV63BR_EncounterWWDS_3_View_ne_admitdate_to = (DateTime)(DateTime.MinValue);
         AV64BR_EncounterWWDS_4_Tfview_ne_department = "";
         AV65BR_EncounterWWDS_5_Tfview_ne_department_sel = "";
         AV66BR_EncounterWWDS_6_Tfview_ne_enctype = "";
         AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel = "";
         scmdbuf = "";
         lV61BR_EncounterWWDS_1_View_ne_information_patientno = "";
         lV64BR_EncounterWWDS_4_Tfview_ne_department = "";
         lV66BR_EncounterWWDS_6_Tfview_ne_enctype = "";
         lV43sBR_EncounterID = "";
         AV43sBR_EncounterID = "";
         A559view_NE_Information_PatientNo = "";
         A552view_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         A557view_NE_TenantTenantCode = "";
         AV44tCurrentCode = "";
         P004O2_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004O2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004O2_A550view_NE_Department = new String[] {""} ;
         P004O2_n550view_NE_Department = new bool[] {false} ;
         P004O2_A553view_NE_Status = new short[1] ;
         P004O2_n553view_NE_Status = new bool[] {false} ;
         P004O2_A549view_NE_EncounterID = new long[1] ;
         P004O2_A551view_NE_ENCType = new String[] {""} ;
         P004O2_n551view_NE_ENCType = new bool[] {false} ;
         P004O2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004O2_n552view_NE_AdmitDate = new bool[] {false} ;
         P004O2_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004O2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         AV21Option = "";
         P004O3_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004O3_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004O3_A551view_NE_ENCType = new String[] {""} ;
         P004O3_n551view_NE_ENCType = new bool[] {false} ;
         P004O3_A553view_NE_Status = new short[1] ;
         P004O3_n553view_NE_Status = new bool[] {false} ;
         P004O3_A549view_NE_EncounterID = new long[1] ;
         P004O3_A550view_NE_Department = new String[] {""} ;
         P004O3_n550view_NE_Department = new bool[] {false} ;
         P004O3_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004O3_n552view_NE_AdmitDate = new bool[] {false} ;
         P004O3_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004O3_n559view_NE_Information_PatientNo = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004O2_A557view_NE_TenantTenantCode, P004O2_n557view_NE_TenantTenantCode, P004O2_A550view_NE_Department, P004O2_n550view_NE_Department, P004O2_A553view_NE_Status, P004O2_n553view_NE_Status, P004O2_A549view_NE_EncounterID, P004O2_A551view_NE_ENCType, P004O2_n551view_NE_ENCType, P004O2_A552view_NE_AdmitDate,
               P004O2_n552view_NE_AdmitDate, P004O2_A559view_NE_Information_PatientNo, P004O2_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               P004O3_A557view_NE_TenantTenantCode, P004O3_n557view_NE_TenantTenantCode, P004O3_A551view_NE_ENCType, P004O3_n551view_NE_ENCType, P004O3_A553view_NE_Status, P004O3_n553view_NE_Status, P004O3_A549view_NE_EncounterID, P004O3_A550view_NE_Department, P004O3_n550view_NE_Department, P004O3_A552view_NE_AdmitDate,
               P004O3_n552view_NE_AdmitDate, P004O3_A559view_NE_Information_PatientNo, P004O3_n559view_NE_Information_PatientNo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV48view_NE_AdmitDateOperator ;
      private short AV52view_NE_IsRandApprove ;
      private short AV39BR_Encounter_Status ;
      private short AV56status ;
      private short A553view_NE_Status ;
      private int AV59GXV1 ;
      private long A549view_NE_EncounterID ;
      private long AV29count ;
      private String scmdbuf ;
      private DateTime AV50view_NE_AdmitDate ;
      private DateTime AV49view_NE_AdmitDate_To ;
      private DateTime AV62BR_EncounterWWDS_2_View_ne_admitdate ;
      private DateTime AV63BR_EncounterWWDS_3_View_ne_admitdate_to ;
      private DateTime A552view_NE_AdmitDate ;
      private bool returnInSub ;
      private bool BRK4O2 ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n550view_NE_Department ;
      private bool n553view_NE_Status ;
      private bool n551view_NE_ENCType ;
      private bool n552view_NE_AdmitDate ;
      private bool n559view_NE_Information_PatientNo ;
      private bool BRK4O4 ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV47view_NE_Information_PatientNo ;
      private String AV13TFview_NE_Department ;
      private String AV14TFview_NE_Department_Sel ;
      private String AV15TFview_NE_ENCType ;
      private String AV16TFview_NE_ENCType_Sel ;
      private String AV61BR_EncounterWWDS_1_View_ne_information_patientno ;
      private String AV64BR_EncounterWWDS_4_Tfview_ne_department ;
      private String AV65BR_EncounterWWDS_5_Tfview_ne_department_sel ;
      private String AV66BR_EncounterWWDS_6_Tfview_ne_enctype ;
      private String AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel ;
      private String lV61BR_EncounterWWDS_1_View_ne_information_patientno ;
      private String lV64BR_EncounterWWDS_4_Tfview_ne_department ;
      private String lV66BR_EncounterWWDS_6_Tfview_ne_enctype ;
      private String lV43sBR_EncounterID ;
      private String AV43sBR_EncounterID ;
      private String A559view_NE_Information_PatientNo ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String A557view_NE_TenantTenantCode ;
      private String AV44tCurrentCode ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004O2_A557view_NE_TenantTenantCode ;
      private bool[] P004O2_n557view_NE_TenantTenantCode ;
      private String[] P004O2_A550view_NE_Department ;
      private bool[] P004O2_n550view_NE_Department ;
      private short[] P004O2_A553view_NE_Status ;
      private bool[] P004O2_n553view_NE_Status ;
      private long[] P004O2_A549view_NE_EncounterID ;
      private String[] P004O2_A551view_NE_ENCType ;
      private bool[] P004O2_n551view_NE_ENCType ;
      private DateTime[] P004O2_A552view_NE_AdmitDate ;
      private bool[] P004O2_n552view_NE_AdmitDate ;
      private String[] P004O2_A559view_NE_Information_PatientNo ;
      private bool[] P004O2_n559view_NE_Information_PatientNo ;
      private String[] P004O3_A557view_NE_TenantTenantCode ;
      private bool[] P004O3_n557view_NE_TenantTenantCode ;
      private String[] P004O3_A551view_NE_ENCType ;
      private bool[] P004O3_n551view_NE_ENCType ;
      private short[] P004O3_A553view_NE_Status ;
      private bool[] P004O3_n553view_NE_Status ;
      private long[] P004O3_A549view_NE_EncounterID ;
      private String[] P004O3_A550view_NE_Department ;
      private bool[] P004O3_n550view_NE_Department ;
      private DateTime[] P004O3_A552view_NE_AdmitDate ;
      private bool[] P004O3_n552view_NE_AdmitDate ;
      private String[] P004O3_A559view_NE_Information_PatientNo ;
      private bool[] P004O3_n559view_NE_Information_PatientNo ;
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

   public class br_encounterwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004O2( IGxContext context ,
                                             String AV61BR_EncounterWWDS_1_View_ne_information_patientno ,
                                             short AV48view_NE_AdmitDateOperator ,
                                             DateTime AV62BR_EncounterWWDS_2_View_ne_admitdate ,
                                             DateTime AV63BR_EncounterWWDS_3_View_ne_admitdate_to ,
                                             String AV65BR_EncounterWWDS_5_Tfview_ne_department_sel ,
                                             String AV64BR_EncounterWWDS_4_Tfview_ne_department ,
                                             String AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel ,
                                             String AV66BR_EncounterWWDS_6_Tfview_ne_enctype ,
                                             String AV43sBR_EncounterID ,
                                             short AV52view_NE_IsRandApprove ,
                                             short AV39BR_Encounter_Status ,
                                             String A559view_NE_Information_PatientNo ,
                                             DateTime A552view_NE_AdmitDate ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             long A549view_NE_EncounterID ,
                                             short AV56status ,
                                             short A553view_NE_Status ,
                                             String A557view_NE_TenantTenantCode ,
                                             String AV44tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [13] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_TenantTenantCode], [view_NE_Department], [view_NE_Status], [view_NE_EncounterID], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (@AV56status = [view_NE_Status])";
         scmdbuf = scmdbuf + " and ([view_NE_TenantTenantCode] = @AV44tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_EncounterWWDS_1_View_ne_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like '%' + @lV61BR_EncounterWWDS_1_View_ne_information_patientno + '%')";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ( AV48view_NE_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV62BR_EncounterWWDS_2_View_ne_admitdate) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV62BR_EncounterWWDS_2_View_ne_admitdate)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ( AV48view_NE_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV63BR_EncounterWWDS_3_View_ne_admitdate_to) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV63BR_EncounterWWDS_3_View_ne_admitdate_to)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_EncounterWWDS_4_Tfview_ne_department)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] like @lV64BR_EncounterWWDS_4_Tfview_ne_department)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] = @AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_EncounterWWDS_6_Tfview_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV66BR_EncounterWWDS_6_Tfview_ne_enctype)";
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)";
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV43sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! (0==AV52view_NE_IsRandApprove) )
         {
            sWhereString = sWhereString + " and (@AV52view_NE_IsRandApprove)";
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( ! (0==AV39BR_Encounter_Status) )
         {
            sWhereString = sWhereString + " and (@AV56status = @AV39BR_Encounter_Status)";
         }
         else
         {
            GXv_int1[11] = 1;
            GXv_int1[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Department]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004O3( IGxContext context ,
                                             String AV61BR_EncounterWWDS_1_View_ne_information_patientno ,
                                             short AV48view_NE_AdmitDateOperator ,
                                             DateTime AV62BR_EncounterWWDS_2_View_ne_admitdate ,
                                             DateTime AV63BR_EncounterWWDS_3_View_ne_admitdate_to ,
                                             String AV65BR_EncounterWWDS_5_Tfview_ne_department_sel ,
                                             String AV64BR_EncounterWWDS_4_Tfview_ne_department ,
                                             String AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel ,
                                             String AV66BR_EncounterWWDS_6_Tfview_ne_enctype ,
                                             String AV43sBR_EncounterID ,
                                             short AV52view_NE_IsRandApprove ,
                                             short AV39BR_Encounter_Status ,
                                             String A559view_NE_Information_PatientNo ,
                                             DateTime A552view_NE_AdmitDate ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             long A549view_NE_EncounterID ,
                                             short AV56status ,
                                             short A553view_NE_Status ,
                                             String A557view_NE_TenantTenantCode ,
                                             String AV44tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [13] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_TenantTenantCode], [view_NE_ENCType], [view_NE_Status], [view_NE_EncounterID], [view_NE_Department], [view_NE_AdmitDate], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (@AV56status = [view_NE_Status])";
         scmdbuf = scmdbuf + " and ([view_NE_TenantTenantCode] = @AV44tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_EncounterWWDS_1_View_ne_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like '%' + @lV61BR_EncounterWWDS_1_View_ne_information_patientno + '%')";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ( AV48view_NE_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV62BR_EncounterWWDS_2_View_ne_admitdate) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV62BR_EncounterWWDS_2_View_ne_admitdate)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ( AV48view_NE_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV63BR_EncounterWWDS_3_View_ne_admitdate_to) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV63BR_EncounterWWDS_3_View_ne_admitdate_to)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_EncounterWWDS_4_Tfview_ne_department)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] like @lV64BR_EncounterWWDS_4_Tfview_ne_department)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_Department] = @AV65BR_EncounterWWDS_5_Tfview_ne_department_sel)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_EncounterWWDS_6_Tfview_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV66BR_EncounterWWDS_6_Tfview_ne_enctype)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV43sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (0==AV52view_NE_IsRandApprove) )
         {
            sWhereString = sWhereString + " and (@AV52view_NE_IsRandApprove)";
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (0==AV39BR_Encounter_Status) )
         {
            sWhereString = sWhereString + " and (@AV56status = @AV39BR_Encounter_Status)";
         }
         else
         {
            GXv_int3[11] = 1;
            GXv_int3[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P004O2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (long)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
               case 1 :
                     return conditional_P004O3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (long)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
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
          Object[] prmP004O2 ;
          prmP004O2 = new Object[] {
          new Object[] {"@AV56status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV44tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_EncounterWWDS_1_View_ne_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV62BR_EncounterWWDS_2_View_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV63BR_EncounterWWDS_3_View_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV64BR_EncounterWWDS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV65BR_EncounterWWDS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV66BR_EncounterWWDS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV43sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV52view_NE_IsRandApprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV56status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV39BR_Encounter_Status",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP004O3 ;
          prmP004O3 = new Object[] {
          new Object[] {"@AV56status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV44tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_EncounterWWDS_1_View_ne_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV62BR_EncounterWWDS_2_View_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV63BR_EncounterWWDS_3_View_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV64BR_EncounterWWDS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV65BR_EncounterWWDS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV66BR_EncounterWWDS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV67BR_EncounterWWDS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV43sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV52view_NE_IsRandApprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV56status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV39BR_Encounter_Status",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004O2,100,0,true,false )
             ,new CursorDef("P004O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004O3,100,0,true,false )
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
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[25]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[25]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_encounterwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encounterwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encounterwwgetfilterdata") )
          {
             return  ;
          }
          br_encounterwwgetfilterdata worker = new br_encounterwwgetfilterdata(context) ;
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
