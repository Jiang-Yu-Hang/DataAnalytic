/*
               File: WebPanel5GetFilterData
        Description: Web Panel5 Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 17:38:57.36
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
   public class webpanel5getfilterdata : GXProcedure
   {
      public webpanel5getfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public webpanel5getfilterdata( IGxContext context )
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
         webpanel5getfilterdata objwebpanel5getfilterdata;
         objwebpanel5getfilterdata = new webpanel5getfilterdata();
         objwebpanel5getfilterdata.AV35DDOName = aP0_DDOName;
         objwebpanel5getfilterdata.AV33SearchTxt = aP1_SearchTxt;
         objwebpanel5getfilterdata.AV34SearchTxtTo = aP2_SearchTxtTo;
         objwebpanel5getfilterdata.AV39OptionsJson = "" ;
         objwebpanel5getfilterdata.AV42OptionsDescJson = "" ;
         objwebpanel5getfilterdata.AV44OptionIndexesJson = "" ;
         objwebpanel5getfilterdata.context.SetSubmitInitialConfig(context);
         objwebpanel5getfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwebpanel5getfilterdata);
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((webpanel5getfilterdata)stateInfo).executePrivate();
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
         if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_DEPARTMENT") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_DEPARTMENTOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_ENCTYPE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_ENCTYPEOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_TENANTTENANTCODE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_TENANTTENANTCODEOPTIONS' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_INFORMATION_PATIENTNO") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_INFORMATION_PATIENTNOOPTIONS' */
            S151 ();
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
         if ( StringUtil.StrCmp(AV46Session.Get("WebPanel5GridState"), "") == 0 )
         {
            AV48GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WebPanel5GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV48GridState.FromXml(AV46Session.Get("WebPanel5GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV54GXV1 = 1;
         while ( AV54GXV1 <= AV48GridState.gxTpr_Filtervalues.Count )
         {
            AV49GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV48GridState.gxTpr_Filtervalues.Item(AV54GXV1));
            if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "VIEW_NE_STATUS") == 0 )
            {
               AV51view_NE_Status = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCOUNTERID") == 0 )
            {
               AV11TFview_NE_EncounterID = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV12TFview_NE_EncounterID_To = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT") == 0 )
            {
               AV13TFview_NE_Department = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT_SEL") == 0 )
            {
               AV14TFview_NE_Department_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE") == 0 )
            {
               AV15TFview_NE_ENCType = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV16TFview_NE_ENCType_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ADMITDATE") == 0 )
            {
               AV17TFview_NE_AdmitDate = context.localUtil.CToT( AV49GridStateFilterValue.gxTpr_Value, 0);
               AV18TFview_NE_AdmitDate_To = context.localUtil.CToT( AV49GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_STATUS_SEL") == 0 )
            {
               AV19TFview_NE_Status_SelsJson = AV49GridStateFilterValue.gxTpr_Value;
               AV20TFview_NE_Status_Sels.FromJSonString(AV19TFview_NE_Status_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISRANDRECHECK") == 0 )
            {
               AV21TFview_NE_IsRandRecheck = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV22TFview_NE_IsRandRecheck_To = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISRANDAPPROVE") == 0 )
            {
               AV23TFview_NE_IsRandApprove = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV24TFview_NE_IsRandApprove_To = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ISUPDATE") == 0 )
            {
               AV25TFview_NE_IsUpdate = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV26TFview_NE_IsUpdate_To = (short)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_TENANTTENANTCODE") == 0 )
            {
               AV27TFview_NE_TenantTenantCode = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_TENANTTENANTCODE_SEL") == 0 )
            {
               AV28TFview_NE_TenantTenantCode_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_INFORMATION_ID") == 0 )
            {
               AV29TFview_NE_Information_ID = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV30TFview_NE_Information_ID_To = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_INFORMATION_PATIENTNO") == 0 )
            {
               AV31TFview_NE_Information_PatientNo = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV32TFview_NE_Information_PatientNo_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            AV54GXV1 = (int)(AV54GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_NE_DEPARTMENTOPTIONS' Routine */
         AV13TFview_NE_Department = AV33SearchTxt;
         AV14TFview_NE_Department_Sel = "";
         AV56WebPanel5DS_1_View_ne_status = AV51view_NE_Status;
         AV57WebPanel5DS_2_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV58WebPanel5DS_3_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV59WebPanel5DS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV60WebPanel5DS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV61WebPanel5DS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV62WebPanel5DS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         AV63WebPanel5DS_8_Tfview_ne_admitdate = AV17TFview_NE_AdmitDate;
         AV64WebPanel5DS_9_Tfview_ne_admitdate_to = AV18TFview_NE_AdmitDate_To;
         AV65WebPanel5DS_10_Tfview_ne_status_sels = AV20TFview_NE_Status_Sels;
         AV66WebPanel5DS_11_Tfview_ne_israndrecheck = AV21TFview_NE_IsRandRecheck;
         AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to = AV22TFview_NE_IsRandRecheck_To;
         AV68WebPanel5DS_13_Tfview_ne_israndapprove = AV23TFview_NE_IsRandApprove;
         AV69WebPanel5DS_14_Tfview_ne_israndapprove_to = AV24TFview_NE_IsRandApprove_To;
         AV70WebPanel5DS_15_Tfview_ne_isupdate = AV25TFview_NE_IsUpdate;
         AV71WebPanel5DS_16_Tfview_ne_isupdate_to = AV26TFview_NE_IsUpdate_To;
         AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = AV27TFview_NE_TenantTenantCode;
         AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel = AV28TFview_NE_TenantTenantCode_Sel;
         AV74WebPanel5DS_19_Tfview_ne_information_id = AV29TFview_NE_Information_ID;
         AV75WebPanel5DS_20_Tfview_ne_information_id_to = AV30TFview_NE_Information_ID_To;
         AV76WebPanel5DS_21_Tfview_ne_information_patientno = AV31TFview_NE_Information_PatientNo;
         AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel = AV32TFview_NE_Information_PatientNo_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                              AV56WebPanel5DS_1_View_ne_status ,
                                              AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                              AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                              AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                              AV59WebPanel5DS_4_Tfview_ne_department ,
                                              AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                              AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                              AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                              AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels.Count ,
                                              AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                              AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                              AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                              AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                              AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                              AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                              AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                              AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                              AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                              AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                              AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                              AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A554view_NE_IsRandRecheck ,
                                              A555view_NE_IsRandApprove ,
                                              A556view_NE_IsUpdate ,
                                              A557view_NE_TenantTenantCode ,
                                              A558view_NE_Information_ID ,
                                              A559view_NE_Information_PatientNo } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59WebPanel5DS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department), "%", "");
         lV61WebPanel5DS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype), "%", "");
         lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = StringUtil.Concat( StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode), "%", "");
         lV76WebPanel5DS_21_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno), "%", "");
         /* Using cursor P004P2 */
         pr_default.execute(0, new Object[] {AV56WebPanel5DS_1_View_ne_status, AV57WebPanel5DS_2_Tfview_ne_encounterid, AV58WebPanel5DS_3_Tfview_ne_encounterid_to, lV59WebPanel5DS_4_Tfview_ne_department, AV60WebPanel5DS_5_Tfview_ne_department_sel, lV61WebPanel5DS_6_Tfview_ne_enctype, AV62WebPanel5DS_7_Tfview_ne_enctype_sel, AV63WebPanel5DS_8_Tfview_ne_admitdate, AV64WebPanel5DS_9_Tfview_ne_admitdate_to, AV66WebPanel5DS_11_Tfview_ne_israndrecheck, AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to, AV68WebPanel5DS_13_Tfview_ne_israndapprove, AV69WebPanel5DS_14_Tfview_ne_israndapprove_to, AV70WebPanel5DS_15_Tfview_ne_isupdate, AV71WebPanel5DS_16_Tfview_ne_isupdate_to, lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode, AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel, AV74WebPanel5DS_19_Tfview_ne_information_id, AV75WebPanel5DS_20_Tfview_ne_information_id_to, lV76WebPanel5DS_21_Tfview_ne_information_patientno, AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4P2 = false;
            A550view_NE_Department = P004P2_A550view_NE_Department[0];
            n550view_NE_Department = P004P2_n550view_NE_Department[0];
            A559view_NE_Information_PatientNo = P004P2_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004P2_n559view_NE_Information_PatientNo[0];
            A558view_NE_Information_ID = P004P2_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = P004P2_n558view_NE_Information_ID[0];
            A557view_NE_TenantTenantCode = P004P2_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004P2_n557view_NE_TenantTenantCode[0];
            A556view_NE_IsUpdate = P004P2_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004P2_n556view_NE_IsUpdate[0];
            A555view_NE_IsRandApprove = P004P2_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004P2_n555view_NE_IsRandApprove[0];
            A554view_NE_IsRandRecheck = P004P2_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004P2_n554view_NE_IsRandRecheck[0];
            A552view_NE_AdmitDate = P004P2_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004P2_n552view_NE_AdmitDate[0];
            A551view_NE_ENCType = P004P2_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004P2_n551view_NE_ENCType[0];
            A549view_NE_EncounterID = P004P2_A549view_NE_EncounterID[0];
            A553view_NE_Status = P004P2_A553view_NE_Status[0];
            n553view_NE_Status = P004P2_n553view_NE_Status[0];
            AV45count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004P2_A550view_NE_Department[0], A550view_NE_Department) == 0 ) )
            {
               BRK4P2 = false;
               A549view_NE_EncounterID = P004P2_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4P2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) )
            {
               AV37Option = A550view_NE_Department;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4P2 )
            {
               BRK4P2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_NE_ENCTYPEOPTIONS' Routine */
         AV15TFview_NE_ENCType = AV33SearchTxt;
         AV16TFview_NE_ENCType_Sel = "";
         AV56WebPanel5DS_1_View_ne_status = AV51view_NE_Status;
         AV57WebPanel5DS_2_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV58WebPanel5DS_3_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV59WebPanel5DS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV60WebPanel5DS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV61WebPanel5DS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV62WebPanel5DS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         AV63WebPanel5DS_8_Tfview_ne_admitdate = AV17TFview_NE_AdmitDate;
         AV64WebPanel5DS_9_Tfview_ne_admitdate_to = AV18TFview_NE_AdmitDate_To;
         AV65WebPanel5DS_10_Tfview_ne_status_sels = AV20TFview_NE_Status_Sels;
         AV66WebPanel5DS_11_Tfview_ne_israndrecheck = AV21TFview_NE_IsRandRecheck;
         AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to = AV22TFview_NE_IsRandRecheck_To;
         AV68WebPanel5DS_13_Tfview_ne_israndapprove = AV23TFview_NE_IsRandApprove;
         AV69WebPanel5DS_14_Tfview_ne_israndapprove_to = AV24TFview_NE_IsRandApprove_To;
         AV70WebPanel5DS_15_Tfview_ne_isupdate = AV25TFview_NE_IsUpdate;
         AV71WebPanel5DS_16_Tfview_ne_isupdate_to = AV26TFview_NE_IsUpdate_To;
         AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = AV27TFview_NE_TenantTenantCode;
         AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel = AV28TFview_NE_TenantTenantCode_Sel;
         AV74WebPanel5DS_19_Tfview_ne_information_id = AV29TFview_NE_Information_ID;
         AV75WebPanel5DS_20_Tfview_ne_information_id_to = AV30TFview_NE_Information_ID_To;
         AV76WebPanel5DS_21_Tfview_ne_information_patientno = AV31TFview_NE_Information_PatientNo;
         AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel = AV32TFview_NE_Information_PatientNo_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                              AV56WebPanel5DS_1_View_ne_status ,
                                              AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                              AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                              AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                              AV59WebPanel5DS_4_Tfview_ne_department ,
                                              AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                              AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                              AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                              AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels.Count ,
                                              AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                              AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                              AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                              AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                              AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                              AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                              AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                              AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                              AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                              AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                              AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                              AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A554view_NE_IsRandRecheck ,
                                              A555view_NE_IsRandApprove ,
                                              A556view_NE_IsUpdate ,
                                              A557view_NE_TenantTenantCode ,
                                              A558view_NE_Information_ID ,
                                              A559view_NE_Information_PatientNo } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59WebPanel5DS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department), "%", "");
         lV61WebPanel5DS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype), "%", "");
         lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = StringUtil.Concat( StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode), "%", "");
         lV76WebPanel5DS_21_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno), "%", "");
         /* Using cursor P004P3 */
         pr_default.execute(1, new Object[] {AV56WebPanel5DS_1_View_ne_status, AV57WebPanel5DS_2_Tfview_ne_encounterid, AV58WebPanel5DS_3_Tfview_ne_encounterid_to, lV59WebPanel5DS_4_Tfview_ne_department, AV60WebPanel5DS_5_Tfview_ne_department_sel, lV61WebPanel5DS_6_Tfview_ne_enctype, AV62WebPanel5DS_7_Tfview_ne_enctype_sel, AV63WebPanel5DS_8_Tfview_ne_admitdate, AV64WebPanel5DS_9_Tfview_ne_admitdate_to, AV66WebPanel5DS_11_Tfview_ne_israndrecheck, AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to, AV68WebPanel5DS_13_Tfview_ne_israndapprove, AV69WebPanel5DS_14_Tfview_ne_israndapprove_to, AV70WebPanel5DS_15_Tfview_ne_isupdate, AV71WebPanel5DS_16_Tfview_ne_isupdate_to, lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode, AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel, AV74WebPanel5DS_19_Tfview_ne_information_id, AV75WebPanel5DS_20_Tfview_ne_information_id_to, lV76WebPanel5DS_21_Tfview_ne_information_patientno, AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4P4 = false;
            A551view_NE_ENCType = P004P3_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004P3_n551view_NE_ENCType[0];
            A559view_NE_Information_PatientNo = P004P3_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004P3_n559view_NE_Information_PatientNo[0];
            A558view_NE_Information_ID = P004P3_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = P004P3_n558view_NE_Information_ID[0];
            A557view_NE_TenantTenantCode = P004P3_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004P3_n557view_NE_TenantTenantCode[0];
            A556view_NE_IsUpdate = P004P3_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004P3_n556view_NE_IsUpdate[0];
            A555view_NE_IsRandApprove = P004P3_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004P3_n555view_NE_IsRandApprove[0];
            A554view_NE_IsRandRecheck = P004P3_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004P3_n554view_NE_IsRandRecheck[0];
            A552view_NE_AdmitDate = P004P3_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004P3_n552view_NE_AdmitDate[0];
            A550view_NE_Department = P004P3_A550view_NE_Department[0];
            n550view_NE_Department = P004P3_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004P3_A549view_NE_EncounterID[0];
            A553view_NE_Status = P004P3_A553view_NE_Status[0];
            n553view_NE_Status = P004P3_n553view_NE_Status[0];
            AV45count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004P3_A551view_NE_ENCType[0], A551view_NE_ENCType) == 0 ) )
            {
               BRK4P4 = false;
               A549view_NE_EncounterID = P004P3_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4P4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) )
            {
               AV37Option = A551view_NE_ENCType;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4P4 )
            {
               BRK4P4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADVIEW_NE_TENANTTENANTCODEOPTIONS' Routine */
         AV27TFview_NE_TenantTenantCode = AV33SearchTxt;
         AV28TFview_NE_TenantTenantCode_Sel = "";
         AV56WebPanel5DS_1_View_ne_status = AV51view_NE_Status;
         AV57WebPanel5DS_2_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV58WebPanel5DS_3_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV59WebPanel5DS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV60WebPanel5DS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV61WebPanel5DS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV62WebPanel5DS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         AV63WebPanel5DS_8_Tfview_ne_admitdate = AV17TFview_NE_AdmitDate;
         AV64WebPanel5DS_9_Tfview_ne_admitdate_to = AV18TFview_NE_AdmitDate_To;
         AV65WebPanel5DS_10_Tfview_ne_status_sels = AV20TFview_NE_Status_Sels;
         AV66WebPanel5DS_11_Tfview_ne_israndrecheck = AV21TFview_NE_IsRandRecheck;
         AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to = AV22TFview_NE_IsRandRecheck_To;
         AV68WebPanel5DS_13_Tfview_ne_israndapprove = AV23TFview_NE_IsRandApprove;
         AV69WebPanel5DS_14_Tfview_ne_israndapprove_to = AV24TFview_NE_IsRandApprove_To;
         AV70WebPanel5DS_15_Tfview_ne_isupdate = AV25TFview_NE_IsUpdate;
         AV71WebPanel5DS_16_Tfview_ne_isupdate_to = AV26TFview_NE_IsUpdate_To;
         AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = AV27TFview_NE_TenantTenantCode;
         AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel = AV28TFview_NE_TenantTenantCode_Sel;
         AV74WebPanel5DS_19_Tfview_ne_information_id = AV29TFview_NE_Information_ID;
         AV75WebPanel5DS_20_Tfview_ne_information_id_to = AV30TFview_NE_Information_ID_To;
         AV76WebPanel5DS_21_Tfview_ne_information_patientno = AV31TFview_NE_Information_PatientNo;
         AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel = AV32TFview_NE_Information_PatientNo_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                              AV56WebPanel5DS_1_View_ne_status ,
                                              AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                              AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                              AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                              AV59WebPanel5DS_4_Tfview_ne_department ,
                                              AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                              AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                              AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                              AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels.Count ,
                                              AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                              AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                              AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                              AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                              AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                              AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                              AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                              AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                              AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                              AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                              AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                              AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A554view_NE_IsRandRecheck ,
                                              A555view_NE_IsRandApprove ,
                                              A556view_NE_IsUpdate ,
                                              A557view_NE_TenantTenantCode ,
                                              A558view_NE_Information_ID ,
                                              A559view_NE_Information_PatientNo } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59WebPanel5DS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department), "%", "");
         lV61WebPanel5DS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype), "%", "");
         lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = StringUtil.Concat( StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode), "%", "");
         lV76WebPanel5DS_21_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno), "%", "");
         /* Using cursor P004P4 */
         pr_default.execute(2, new Object[] {AV56WebPanel5DS_1_View_ne_status, AV57WebPanel5DS_2_Tfview_ne_encounterid, AV58WebPanel5DS_3_Tfview_ne_encounterid_to, lV59WebPanel5DS_4_Tfview_ne_department, AV60WebPanel5DS_5_Tfview_ne_department_sel, lV61WebPanel5DS_6_Tfview_ne_enctype, AV62WebPanel5DS_7_Tfview_ne_enctype_sel, AV63WebPanel5DS_8_Tfview_ne_admitdate, AV64WebPanel5DS_9_Tfview_ne_admitdate_to, AV66WebPanel5DS_11_Tfview_ne_israndrecheck, AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to, AV68WebPanel5DS_13_Tfview_ne_israndapprove, AV69WebPanel5DS_14_Tfview_ne_israndapprove_to, AV70WebPanel5DS_15_Tfview_ne_isupdate, AV71WebPanel5DS_16_Tfview_ne_isupdate_to, lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode, AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel, AV74WebPanel5DS_19_Tfview_ne_information_id, AV75WebPanel5DS_20_Tfview_ne_information_id_to, lV76WebPanel5DS_21_Tfview_ne_information_patientno, AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK4P6 = false;
            A557view_NE_TenantTenantCode = P004P4_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004P4_n557view_NE_TenantTenantCode[0];
            A559view_NE_Information_PatientNo = P004P4_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004P4_n559view_NE_Information_PatientNo[0];
            A558view_NE_Information_ID = P004P4_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = P004P4_n558view_NE_Information_ID[0];
            A556view_NE_IsUpdate = P004P4_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004P4_n556view_NE_IsUpdate[0];
            A555view_NE_IsRandApprove = P004P4_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004P4_n555view_NE_IsRandApprove[0];
            A554view_NE_IsRandRecheck = P004P4_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004P4_n554view_NE_IsRandRecheck[0];
            A552view_NE_AdmitDate = P004P4_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004P4_n552view_NE_AdmitDate[0];
            A551view_NE_ENCType = P004P4_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004P4_n551view_NE_ENCType[0];
            A550view_NE_Department = P004P4_A550view_NE_Department[0];
            n550view_NE_Department = P004P4_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004P4_A549view_NE_EncounterID[0];
            A553view_NE_Status = P004P4_A553view_NE_Status[0];
            n553view_NE_Status = P004P4_n553view_NE_Status[0];
            AV45count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P004P4_A557view_NE_TenantTenantCode[0], A557view_NE_TenantTenantCode) == 0 ) )
            {
               BRK4P6 = false;
               A549view_NE_EncounterID = P004P4_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4P6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A557view_NE_TenantTenantCode)) )
            {
               AV37Option = A557view_NE_TenantTenantCode;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4P6 )
            {
               BRK4P6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADVIEW_NE_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV31TFview_NE_Information_PatientNo = AV33SearchTxt;
         AV32TFview_NE_Information_PatientNo_Sel = "";
         AV56WebPanel5DS_1_View_ne_status = AV51view_NE_Status;
         AV57WebPanel5DS_2_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV58WebPanel5DS_3_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV59WebPanel5DS_4_Tfview_ne_department = AV13TFview_NE_Department;
         AV60WebPanel5DS_5_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV61WebPanel5DS_6_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV62WebPanel5DS_7_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         AV63WebPanel5DS_8_Tfview_ne_admitdate = AV17TFview_NE_AdmitDate;
         AV64WebPanel5DS_9_Tfview_ne_admitdate_to = AV18TFview_NE_AdmitDate_To;
         AV65WebPanel5DS_10_Tfview_ne_status_sels = AV20TFview_NE_Status_Sels;
         AV66WebPanel5DS_11_Tfview_ne_israndrecheck = AV21TFview_NE_IsRandRecheck;
         AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to = AV22TFview_NE_IsRandRecheck_To;
         AV68WebPanel5DS_13_Tfview_ne_israndapprove = AV23TFview_NE_IsRandApprove;
         AV69WebPanel5DS_14_Tfview_ne_israndapprove_to = AV24TFview_NE_IsRandApprove_To;
         AV70WebPanel5DS_15_Tfview_ne_isupdate = AV25TFview_NE_IsUpdate;
         AV71WebPanel5DS_16_Tfview_ne_isupdate_to = AV26TFview_NE_IsUpdate_To;
         AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = AV27TFview_NE_TenantTenantCode;
         AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel = AV28TFview_NE_TenantTenantCode_Sel;
         AV74WebPanel5DS_19_Tfview_ne_information_id = AV29TFview_NE_Information_ID;
         AV75WebPanel5DS_20_Tfview_ne_information_id_to = AV30TFview_NE_Information_ID_To;
         AV76WebPanel5DS_21_Tfview_ne_information_patientno = AV31TFview_NE_Information_PatientNo;
         AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel = AV32TFview_NE_Information_PatientNo_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                              AV56WebPanel5DS_1_View_ne_status ,
                                              AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                              AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                              AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                              AV59WebPanel5DS_4_Tfview_ne_department ,
                                              AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                              AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                              AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                              AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                              AV65WebPanel5DS_10_Tfview_ne_status_sels.Count ,
                                              AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                              AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                              AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                              AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                              AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                              AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                              AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                              AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                              AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                              AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                              AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                              AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType ,
                                              A552view_NE_AdmitDate ,
                                              A554view_NE_IsRandRecheck ,
                                              A555view_NE_IsRandApprove ,
                                              A556view_NE_IsUpdate ,
                                              A557view_NE_TenantTenantCode ,
                                              A558view_NE_Information_ID ,
                                              A559view_NE_Information_PatientNo } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59WebPanel5DS_4_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department), "%", "");
         lV61WebPanel5DS_6_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype), "%", "");
         lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = StringUtil.Concat( StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode), "%", "");
         lV76WebPanel5DS_21_Tfview_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno), "%", "");
         /* Using cursor P004P5 */
         pr_default.execute(3, new Object[] {AV56WebPanel5DS_1_View_ne_status, AV57WebPanel5DS_2_Tfview_ne_encounterid, AV58WebPanel5DS_3_Tfview_ne_encounterid_to, lV59WebPanel5DS_4_Tfview_ne_department, AV60WebPanel5DS_5_Tfview_ne_department_sel, lV61WebPanel5DS_6_Tfview_ne_enctype, AV62WebPanel5DS_7_Tfview_ne_enctype_sel, AV63WebPanel5DS_8_Tfview_ne_admitdate, AV64WebPanel5DS_9_Tfview_ne_admitdate_to, AV66WebPanel5DS_11_Tfview_ne_israndrecheck, AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to, AV68WebPanel5DS_13_Tfview_ne_israndapprove, AV69WebPanel5DS_14_Tfview_ne_israndapprove_to, AV70WebPanel5DS_15_Tfview_ne_isupdate, AV71WebPanel5DS_16_Tfview_ne_isupdate_to, lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode, AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel, AV74WebPanel5DS_19_Tfview_ne_information_id, AV75WebPanel5DS_20_Tfview_ne_information_id_to, lV76WebPanel5DS_21_Tfview_ne_information_patientno, AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK4P8 = false;
            A559view_NE_Information_PatientNo = P004P5_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = P004P5_n559view_NE_Information_PatientNo[0];
            A558view_NE_Information_ID = P004P5_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = P004P5_n558view_NE_Information_ID[0];
            A557view_NE_TenantTenantCode = P004P5_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = P004P5_n557view_NE_TenantTenantCode[0];
            A556view_NE_IsUpdate = P004P5_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = P004P5_n556view_NE_IsUpdate[0];
            A555view_NE_IsRandApprove = P004P5_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = P004P5_n555view_NE_IsRandApprove[0];
            A554view_NE_IsRandRecheck = P004P5_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = P004P5_n554view_NE_IsRandRecheck[0];
            A552view_NE_AdmitDate = P004P5_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = P004P5_n552view_NE_AdmitDate[0];
            A551view_NE_ENCType = P004P5_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004P5_n551view_NE_ENCType[0];
            A550view_NE_Department = P004P5_A550view_NE_Department[0];
            n550view_NE_Department = P004P5_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004P5_A549view_NE_EncounterID[0];
            A553view_NE_Status = P004P5_A553view_NE_Status[0];
            n553view_NE_Status = P004P5_n553view_NE_Status[0];
            AV45count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P004P5_A559view_NE_Information_PatientNo[0], A559view_NE_Information_PatientNo) == 0 ) )
            {
               BRK4P8 = false;
               A549view_NE_EncounterID = P004P5_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4P8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A559view_NE_Information_PatientNo)) )
            {
               AV37Option = A559view_NE_Information_PatientNo;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4P8 )
            {
               BRK4P8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
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
         AV13TFview_NE_Department = "";
         AV14TFview_NE_Department_Sel = "";
         AV15TFview_NE_ENCType = "";
         AV16TFview_NE_ENCType_Sel = "";
         AV17TFview_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         AV18TFview_NE_AdmitDate_To = (DateTime)(DateTime.MinValue);
         AV19TFview_NE_Status_SelsJson = "";
         AV20TFview_NE_Status_Sels = new GxSimpleCollection<short>();
         AV27TFview_NE_TenantTenantCode = "";
         AV28TFview_NE_TenantTenantCode_Sel = "";
         AV31TFview_NE_Information_PatientNo = "";
         AV32TFview_NE_Information_PatientNo_Sel = "";
         AV59WebPanel5DS_4_Tfview_ne_department = "";
         AV60WebPanel5DS_5_Tfview_ne_department_sel = "";
         AV61WebPanel5DS_6_Tfview_ne_enctype = "";
         AV62WebPanel5DS_7_Tfview_ne_enctype_sel = "";
         AV63WebPanel5DS_8_Tfview_ne_admitdate = (DateTime)(DateTime.MinValue);
         AV64WebPanel5DS_9_Tfview_ne_admitdate_to = (DateTime)(DateTime.MinValue);
         AV65WebPanel5DS_10_Tfview_ne_status_sels = new GxSimpleCollection<short>();
         AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = "";
         AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel = "";
         AV76WebPanel5DS_21_Tfview_ne_information_patientno = "";
         AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel = "";
         scmdbuf = "";
         lV59WebPanel5DS_4_Tfview_ne_department = "";
         lV61WebPanel5DS_6_Tfview_ne_enctype = "";
         lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode = "";
         lV76WebPanel5DS_21_Tfview_ne_information_patientno = "";
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         A552view_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         A557view_NE_TenantTenantCode = "";
         A559view_NE_Information_PatientNo = "";
         P004P2_A550view_NE_Department = new String[] {""} ;
         P004P2_n550view_NE_Department = new bool[] {false} ;
         P004P2_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004P2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004P2_A558view_NE_Information_ID = new long[1] ;
         P004P2_n558view_NE_Information_ID = new bool[] {false} ;
         P004P2_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004P2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004P2_A556view_NE_IsUpdate = new short[1] ;
         P004P2_n556view_NE_IsUpdate = new bool[] {false} ;
         P004P2_A555view_NE_IsRandApprove = new short[1] ;
         P004P2_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004P2_A554view_NE_IsRandRecheck = new short[1] ;
         P004P2_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004P2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004P2_n552view_NE_AdmitDate = new bool[] {false} ;
         P004P2_A551view_NE_ENCType = new String[] {""} ;
         P004P2_n551view_NE_ENCType = new bool[] {false} ;
         P004P2_A549view_NE_EncounterID = new long[1] ;
         P004P2_A553view_NE_Status = new short[1] ;
         P004P2_n553view_NE_Status = new bool[] {false} ;
         AV37Option = "";
         P004P3_A551view_NE_ENCType = new String[] {""} ;
         P004P3_n551view_NE_ENCType = new bool[] {false} ;
         P004P3_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004P3_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004P3_A558view_NE_Information_ID = new long[1] ;
         P004P3_n558view_NE_Information_ID = new bool[] {false} ;
         P004P3_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004P3_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004P3_A556view_NE_IsUpdate = new short[1] ;
         P004P3_n556view_NE_IsUpdate = new bool[] {false} ;
         P004P3_A555view_NE_IsRandApprove = new short[1] ;
         P004P3_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004P3_A554view_NE_IsRandRecheck = new short[1] ;
         P004P3_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004P3_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004P3_n552view_NE_AdmitDate = new bool[] {false} ;
         P004P3_A550view_NE_Department = new String[] {""} ;
         P004P3_n550view_NE_Department = new bool[] {false} ;
         P004P3_A549view_NE_EncounterID = new long[1] ;
         P004P3_A553view_NE_Status = new short[1] ;
         P004P3_n553view_NE_Status = new bool[] {false} ;
         P004P4_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004P4_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004P4_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004P4_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004P4_A558view_NE_Information_ID = new long[1] ;
         P004P4_n558view_NE_Information_ID = new bool[] {false} ;
         P004P4_A556view_NE_IsUpdate = new short[1] ;
         P004P4_n556view_NE_IsUpdate = new bool[] {false} ;
         P004P4_A555view_NE_IsRandApprove = new short[1] ;
         P004P4_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004P4_A554view_NE_IsRandRecheck = new short[1] ;
         P004P4_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004P4_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004P4_n552view_NE_AdmitDate = new bool[] {false} ;
         P004P4_A551view_NE_ENCType = new String[] {""} ;
         P004P4_n551view_NE_ENCType = new bool[] {false} ;
         P004P4_A550view_NE_Department = new String[] {""} ;
         P004P4_n550view_NE_Department = new bool[] {false} ;
         P004P4_A549view_NE_EncounterID = new long[1] ;
         P004P4_A553view_NE_Status = new short[1] ;
         P004P4_n553view_NE_Status = new bool[] {false} ;
         P004P5_A559view_NE_Information_PatientNo = new String[] {""} ;
         P004P5_n559view_NE_Information_PatientNo = new bool[] {false} ;
         P004P5_A558view_NE_Information_ID = new long[1] ;
         P004P5_n558view_NE_Information_ID = new bool[] {false} ;
         P004P5_A557view_NE_TenantTenantCode = new String[] {""} ;
         P004P5_n557view_NE_TenantTenantCode = new bool[] {false} ;
         P004P5_A556view_NE_IsUpdate = new short[1] ;
         P004P5_n556view_NE_IsUpdate = new bool[] {false} ;
         P004P5_A555view_NE_IsRandApprove = new short[1] ;
         P004P5_n555view_NE_IsRandApprove = new bool[] {false} ;
         P004P5_A554view_NE_IsRandRecheck = new short[1] ;
         P004P5_n554view_NE_IsRandRecheck = new bool[] {false} ;
         P004P5_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         P004P5_n552view_NE_AdmitDate = new bool[] {false} ;
         P004P5_A551view_NE_ENCType = new String[] {""} ;
         P004P5_n551view_NE_ENCType = new bool[] {false} ;
         P004P5_A550view_NE_Department = new String[] {""} ;
         P004P5_n550view_NE_Department = new bool[] {false} ;
         P004P5_A549view_NE_EncounterID = new long[1] ;
         P004P5_A553view_NE_Status = new short[1] ;
         P004P5_n553view_NE_Status = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.webpanel5getfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004P2_A550view_NE_Department, P004P2_n550view_NE_Department, P004P2_A559view_NE_Information_PatientNo, P004P2_n559view_NE_Information_PatientNo, P004P2_A558view_NE_Information_ID, P004P2_n558view_NE_Information_ID, P004P2_A557view_NE_TenantTenantCode, P004P2_n557view_NE_TenantTenantCode, P004P2_A556view_NE_IsUpdate, P004P2_n556view_NE_IsUpdate,
               P004P2_A555view_NE_IsRandApprove, P004P2_n555view_NE_IsRandApprove, P004P2_A554view_NE_IsRandRecheck, P004P2_n554view_NE_IsRandRecheck, P004P2_A552view_NE_AdmitDate, P004P2_n552view_NE_AdmitDate, P004P2_A551view_NE_ENCType, P004P2_n551view_NE_ENCType, P004P2_A549view_NE_EncounterID, P004P2_A553view_NE_Status,
               P004P2_n553view_NE_Status
               }
               , new Object[] {
               P004P3_A551view_NE_ENCType, P004P3_n551view_NE_ENCType, P004P3_A559view_NE_Information_PatientNo, P004P3_n559view_NE_Information_PatientNo, P004P3_A558view_NE_Information_ID, P004P3_n558view_NE_Information_ID, P004P3_A557view_NE_TenantTenantCode, P004P3_n557view_NE_TenantTenantCode, P004P3_A556view_NE_IsUpdate, P004P3_n556view_NE_IsUpdate,
               P004P3_A555view_NE_IsRandApprove, P004P3_n555view_NE_IsRandApprove, P004P3_A554view_NE_IsRandRecheck, P004P3_n554view_NE_IsRandRecheck, P004P3_A552view_NE_AdmitDate, P004P3_n552view_NE_AdmitDate, P004P3_A550view_NE_Department, P004P3_n550view_NE_Department, P004P3_A549view_NE_EncounterID, P004P3_A553view_NE_Status,
               P004P3_n553view_NE_Status
               }
               , new Object[] {
               P004P4_A557view_NE_TenantTenantCode, P004P4_n557view_NE_TenantTenantCode, P004P4_A559view_NE_Information_PatientNo, P004P4_n559view_NE_Information_PatientNo, P004P4_A558view_NE_Information_ID, P004P4_n558view_NE_Information_ID, P004P4_A556view_NE_IsUpdate, P004P4_n556view_NE_IsUpdate, P004P4_A555view_NE_IsRandApprove, P004P4_n555view_NE_IsRandApprove,
               P004P4_A554view_NE_IsRandRecheck, P004P4_n554view_NE_IsRandRecheck, P004P4_A552view_NE_AdmitDate, P004P4_n552view_NE_AdmitDate, P004P4_A551view_NE_ENCType, P004P4_n551view_NE_ENCType, P004P4_A550view_NE_Department, P004P4_n550view_NE_Department, P004P4_A549view_NE_EncounterID, P004P4_A553view_NE_Status,
               P004P4_n553view_NE_Status
               }
               , new Object[] {
               P004P5_A559view_NE_Information_PatientNo, P004P5_n559view_NE_Information_PatientNo, P004P5_A558view_NE_Information_ID, P004P5_n558view_NE_Information_ID, P004P5_A557view_NE_TenantTenantCode, P004P5_n557view_NE_TenantTenantCode, P004P5_A556view_NE_IsUpdate, P004P5_n556view_NE_IsUpdate, P004P5_A555view_NE_IsRandApprove, P004P5_n555view_NE_IsRandApprove,
               P004P5_A554view_NE_IsRandRecheck, P004P5_n554view_NE_IsRandRecheck, P004P5_A552view_NE_AdmitDate, P004P5_n552view_NE_AdmitDate, P004P5_A551view_NE_ENCType, P004P5_n551view_NE_ENCType, P004P5_A550view_NE_Department, P004P5_n550view_NE_Department, P004P5_A549view_NE_EncounterID, P004P5_A553view_NE_Status,
               P004P5_n553view_NE_Status
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV51view_NE_Status ;
      private short AV21TFview_NE_IsRandRecheck ;
      private short AV22TFview_NE_IsRandRecheck_To ;
      private short AV23TFview_NE_IsRandApprove ;
      private short AV24TFview_NE_IsRandApprove_To ;
      private short AV25TFview_NE_IsUpdate ;
      private short AV26TFview_NE_IsUpdate_To ;
      private short AV56WebPanel5DS_1_View_ne_status ;
      private short AV66WebPanel5DS_11_Tfview_ne_israndrecheck ;
      private short AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ;
      private short AV68WebPanel5DS_13_Tfview_ne_israndapprove ;
      private short AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ;
      private short AV70WebPanel5DS_15_Tfview_ne_isupdate ;
      private short AV71WebPanel5DS_16_Tfview_ne_isupdate_to ;
      private short A553view_NE_Status ;
      private short A554view_NE_IsRandRecheck ;
      private short A555view_NE_IsRandApprove ;
      private short A556view_NE_IsUpdate ;
      private int AV54GXV1 ;
      private int AV65WebPanel5DS_10_Tfview_ne_status_sels_Count ;
      private long AV11TFview_NE_EncounterID ;
      private long AV12TFview_NE_EncounterID_To ;
      private long AV29TFview_NE_Information_ID ;
      private long AV30TFview_NE_Information_ID_To ;
      private long AV57WebPanel5DS_2_Tfview_ne_encounterid ;
      private long AV58WebPanel5DS_3_Tfview_ne_encounterid_to ;
      private long AV74WebPanel5DS_19_Tfview_ne_information_id ;
      private long AV75WebPanel5DS_20_Tfview_ne_information_id_to ;
      private long A549view_NE_EncounterID ;
      private long A558view_NE_Information_ID ;
      private long AV45count ;
      private String scmdbuf ;
      private DateTime AV17TFview_NE_AdmitDate ;
      private DateTime AV18TFview_NE_AdmitDate_To ;
      private DateTime AV63WebPanel5DS_8_Tfview_ne_admitdate ;
      private DateTime AV64WebPanel5DS_9_Tfview_ne_admitdate_to ;
      private DateTime A552view_NE_AdmitDate ;
      private bool returnInSub ;
      private bool BRK4P2 ;
      private bool n550view_NE_Department ;
      private bool n559view_NE_Information_PatientNo ;
      private bool n558view_NE_Information_ID ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n556view_NE_IsUpdate ;
      private bool n555view_NE_IsRandApprove ;
      private bool n554view_NE_IsRandRecheck ;
      private bool n552view_NE_AdmitDate ;
      private bool n551view_NE_ENCType ;
      private bool n553view_NE_Status ;
      private bool BRK4P4 ;
      private bool BRK4P6 ;
      private bool BRK4P8 ;
      private String AV44OptionIndexesJson ;
      private String AV39OptionsJson ;
      private String AV42OptionsDescJson ;
      private String AV19TFview_NE_Status_SelsJson ;
      private String AV35DDOName ;
      private String AV33SearchTxt ;
      private String AV34SearchTxtTo ;
      private String AV13TFview_NE_Department ;
      private String AV14TFview_NE_Department_Sel ;
      private String AV15TFview_NE_ENCType ;
      private String AV16TFview_NE_ENCType_Sel ;
      private String AV27TFview_NE_TenantTenantCode ;
      private String AV28TFview_NE_TenantTenantCode_Sel ;
      private String AV31TFview_NE_Information_PatientNo ;
      private String AV32TFview_NE_Information_PatientNo_Sel ;
      private String AV59WebPanel5DS_4_Tfview_ne_department ;
      private String AV60WebPanel5DS_5_Tfview_ne_department_sel ;
      private String AV61WebPanel5DS_6_Tfview_ne_enctype ;
      private String AV62WebPanel5DS_7_Tfview_ne_enctype_sel ;
      private String AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ;
      private String AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ;
      private String AV76WebPanel5DS_21_Tfview_ne_information_patientno ;
      private String AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ;
      private String lV59WebPanel5DS_4_Tfview_ne_department ;
      private String lV61WebPanel5DS_6_Tfview_ne_enctype ;
      private String lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ;
      private String lV76WebPanel5DS_21_Tfview_ne_information_patientno ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String A557view_NE_TenantTenantCode ;
      private String A559view_NE_Information_PatientNo ;
      private String AV37Option ;
      private GxSimpleCollection<short> AV20TFview_NE_Status_Sels ;
      private GxSimpleCollection<short> AV65WebPanel5DS_10_Tfview_ne_status_sels ;
      private IGxSession AV46Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004P2_A550view_NE_Department ;
      private bool[] P004P2_n550view_NE_Department ;
      private String[] P004P2_A559view_NE_Information_PatientNo ;
      private bool[] P004P2_n559view_NE_Information_PatientNo ;
      private long[] P004P2_A558view_NE_Information_ID ;
      private bool[] P004P2_n558view_NE_Information_ID ;
      private String[] P004P2_A557view_NE_TenantTenantCode ;
      private bool[] P004P2_n557view_NE_TenantTenantCode ;
      private short[] P004P2_A556view_NE_IsUpdate ;
      private bool[] P004P2_n556view_NE_IsUpdate ;
      private short[] P004P2_A555view_NE_IsRandApprove ;
      private bool[] P004P2_n555view_NE_IsRandApprove ;
      private short[] P004P2_A554view_NE_IsRandRecheck ;
      private bool[] P004P2_n554view_NE_IsRandRecheck ;
      private DateTime[] P004P2_A552view_NE_AdmitDate ;
      private bool[] P004P2_n552view_NE_AdmitDate ;
      private String[] P004P2_A551view_NE_ENCType ;
      private bool[] P004P2_n551view_NE_ENCType ;
      private long[] P004P2_A549view_NE_EncounterID ;
      private short[] P004P2_A553view_NE_Status ;
      private bool[] P004P2_n553view_NE_Status ;
      private String[] P004P3_A551view_NE_ENCType ;
      private bool[] P004P3_n551view_NE_ENCType ;
      private String[] P004P3_A559view_NE_Information_PatientNo ;
      private bool[] P004P3_n559view_NE_Information_PatientNo ;
      private long[] P004P3_A558view_NE_Information_ID ;
      private bool[] P004P3_n558view_NE_Information_ID ;
      private String[] P004P3_A557view_NE_TenantTenantCode ;
      private bool[] P004P3_n557view_NE_TenantTenantCode ;
      private short[] P004P3_A556view_NE_IsUpdate ;
      private bool[] P004P3_n556view_NE_IsUpdate ;
      private short[] P004P3_A555view_NE_IsRandApprove ;
      private bool[] P004P3_n555view_NE_IsRandApprove ;
      private short[] P004P3_A554view_NE_IsRandRecheck ;
      private bool[] P004P3_n554view_NE_IsRandRecheck ;
      private DateTime[] P004P3_A552view_NE_AdmitDate ;
      private bool[] P004P3_n552view_NE_AdmitDate ;
      private String[] P004P3_A550view_NE_Department ;
      private bool[] P004P3_n550view_NE_Department ;
      private long[] P004P3_A549view_NE_EncounterID ;
      private short[] P004P3_A553view_NE_Status ;
      private bool[] P004P3_n553view_NE_Status ;
      private String[] P004P4_A557view_NE_TenantTenantCode ;
      private bool[] P004P4_n557view_NE_TenantTenantCode ;
      private String[] P004P4_A559view_NE_Information_PatientNo ;
      private bool[] P004P4_n559view_NE_Information_PatientNo ;
      private long[] P004P4_A558view_NE_Information_ID ;
      private bool[] P004P4_n558view_NE_Information_ID ;
      private short[] P004P4_A556view_NE_IsUpdate ;
      private bool[] P004P4_n556view_NE_IsUpdate ;
      private short[] P004P4_A555view_NE_IsRandApprove ;
      private bool[] P004P4_n555view_NE_IsRandApprove ;
      private short[] P004P4_A554view_NE_IsRandRecheck ;
      private bool[] P004P4_n554view_NE_IsRandRecheck ;
      private DateTime[] P004P4_A552view_NE_AdmitDate ;
      private bool[] P004P4_n552view_NE_AdmitDate ;
      private String[] P004P4_A551view_NE_ENCType ;
      private bool[] P004P4_n551view_NE_ENCType ;
      private String[] P004P4_A550view_NE_Department ;
      private bool[] P004P4_n550view_NE_Department ;
      private long[] P004P4_A549view_NE_EncounterID ;
      private short[] P004P4_A553view_NE_Status ;
      private bool[] P004P4_n553view_NE_Status ;
      private String[] P004P5_A559view_NE_Information_PatientNo ;
      private bool[] P004P5_n559view_NE_Information_PatientNo ;
      private long[] P004P5_A558view_NE_Information_ID ;
      private bool[] P004P5_n558view_NE_Information_ID ;
      private String[] P004P5_A557view_NE_TenantTenantCode ;
      private bool[] P004P5_n557view_NE_TenantTenantCode ;
      private short[] P004P5_A556view_NE_IsUpdate ;
      private bool[] P004P5_n556view_NE_IsUpdate ;
      private short[] P004P5_A555view_NE_IsRandApprove ;
      private bool[] P004P5_n555view_NE_IsRandApprove ;
      private short[] P004P5_A554view_NE_IsRandRecheck ;
      private bool[] P004P5_n554view_NE_IsRandRecheck ;
      private DateTime[] P004P5_A552view_NE_AdmitDate ;
      private bool[] P004P5_n552view_NE_AdmitDate ;
      private String[] P004P5_A551view_NE_ENCType ;
      private bool[] P004P5_n551view_NE_ENCType ;
      private String[] P004P5_A550view_NE_Department ;
      private bool[] P004P5_n550view_NE_Department ;
      private long[] P004P5_A549view_NE_EncounterID ;
      private short[] P004P5_A553view_NE_Status ;
      private bool[] P004P5_n553view_NE_Status ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV38Options ;
      private GxSimpleCollection<String> AV41OptionsDesc ;
      private GxSimpleCollection<String> AV43OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV48GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV49GridStateFilterValue ;
   }

   public class webpanel5getfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004P2( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                             short AV56WebPanel5DS_1_View_ne_status ,
                                             long AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                             long AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                             String AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                             String AV59WebPanel5DS_4_Tfview_ne_department ,
                                             String AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                             String AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                             DateTime AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                             DateTime AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                             int AV65WebPanel5DS_10_Tfview_ne_status_sels_Count ,
                                             short AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                             short AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                             short AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                             short AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                             short AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                             short AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                             String AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                             String AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                             long AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                             long AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                             String AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                             String AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             short A554view_NE_IsRandRecheck ,
                                             short A555view_NE_IsRandApprove ,
                                             short A556view_NE_IsUpdate ,
                                             String A557view_NE_TenantTenantCode ,
                                             long A558view_NE_Information_ID ,
                                             String A559view_NE_Information_PatientNo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [21] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Department], [view_NE_Information_PatientNo], [view_NE_Information_ID], [view_NE_TenantTenantCode], [view_NE_IsUpdate], [view_NE_IsRandApprove], [view_NE_IsRandRecheck], [view_NE_AdmitDate], [view_NE_ENCType], [view_NE_EncounterID], [view_NE_Status] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV56WebPanel5DS_1_View_ne_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV57WebPanel5DS_2_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV58WebPanel5DS_3_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV63WebPanel5DS_8_Tfview_ne_admitdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV64WebPanel5DS_9_Tfview_ne_admitdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( AV65WebPanel5DS_10_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV66WebPanel5DS_11_Tfview_ne_israndrecheck) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! (0==AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( ! (0==AV68WebPanel5DS_13_Tfview_ne_israndapprove) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( ! (0==AV69WebPanel5DS_14_Tfview_ne_israndapprove_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
         }
         else
         {
            GXv_int1[12] = 1;
         }
         if ( ! (0==AV70WebPanel5DS_15_Tfview_ne_isupdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
         }
         else
         {
            GXv_int1[13] = 1;
         }
         if ( ! (0==AV71WebPanel5DS_16_Tfview_ne_isupdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
         }
         else
         {
            GXv_int1[14] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
         }
         else
         {
            GXv_int1[15] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
         }
         else
         {
            GXv_int1[16] = 1;
         }
         if ( ! (0==AV74WebPanel5DS_19_Tfview_ne_information_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
         }
         else
         {
            GXv_int1[17] = 1;
         }
         if ( ! (0==AV75WebPanel5DS_20_Tfview_ne_information_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
         }
         else
         {
            GXv_int1[18] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
         }
         else
         {
            GXv_int1[19] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int1[20] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Department]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004P3( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                             short AV56WebPanel5DS_1_View_ne_status ,
                                             long AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                             long AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                             String AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                             String AV59WebPanel5DS_4_Tfview_ne_department ,
                                             String AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                             String AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                             DateTime AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                             DateTime AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                             int AV65WebPanel5DS_10_Tfview_ne_status_sels_Count ,
                                             short AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                             short AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                             short AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                             short AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                             short AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                             short AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                             String AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                             String AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                             long AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                             long AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                             String AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                             String AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             short A554view_NE_IsRandRecheck ,
                                             short A555view_NE_IsRandApprove ,
                                             short A556view_NE_IsUpdate ,
                                             String A557view_NE_TenantTenantCode ,
                                             long A558view_NE_Information_ID ,
                                             String A559view_NE_Information_PatientNo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [21] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_ENCType], [view_NE_Information_PatientNo], [view_NE_Information_ID], [view_NE_TenantTenantCode], [view_NE_IsUpdate], [view_NE_IsRandApprove], [view_NE_IsRandRecheck], [view_NE_AdmitDate], [view_NE_Department], [view_NE_EncounterID], [view_NE_Status] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV56WebPanel5DS_1_View_ne_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV57WebPanel5DS_2_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV58WebPanel5DS_3_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV63WebPanel5DS_8_Tfview_ne_admitdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV64WebPanel5DS_9_Tfview_ne_admitdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( AV65WebPanel5DS_10_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV66WebPanel5DS_11_Tfview_ne_israndrecheck) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (0==AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (0==AV68WebPanel5DS_13_Tfview_ne_israndapprove) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (0==AV69WebPanel5DS_14_Tfview_ne_israndapprove_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (0==AV70WebPanel5DS_15_Tfview_ne_isupdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (0==AV71WebPanel5DS_16_Tfview_ne_isupdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
         }
         else
         {
            GXv_int3[16] = 1;
         }
         if ( ! (0==AV74WebPanel5DS_19_Tfview_ne_information_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
         }
         else
         {
            GXv_int3[17] = 1;
         }
         if ( ! (0==AV75WebPanel5DS_20_Tfview_ne_information_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
         }
         else
         {
            GXv_int3[18] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
         }
         else
         {
            GXv_int3[19] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int3[20] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P004P4( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                             short AV56WebPanel5DS_1_View_ne_status ,
                                             long AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                             long AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                             String AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                             String AV59WebPanel5DS_4_Tfview_ne_department ,
                                             String AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                             String AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                             DateTime AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                             DateTime AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                             int AV65WebPanel5DS_10_Tfview_ne_status_sels_Count ,
                                             short AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                             short AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                             short AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                             short AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                             short AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                             short AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                             String AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                             String AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                             long AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                             long AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                             String AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                             String AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             short A554view_NE_IsRandRecheck ,
                                             short A555view_NE_IsRandApprove ,
                                             short A556view_NE_IsUpdate ,
                                             String A557view_NE_TenantTenantCode ,
                                             long A558view_NE_Information_ID ,
                                             String A559view_NE_Information_PatientNo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [21] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_TenantTenantCode], [view_NE_Information_PatientNo], [view_NE_Information_ID], [view_NE_IsUpdate], [view_NE_IsRandApprove], [view_NE_IsRandRecheck], [view_NE_AdmitDate], [view_NE_ENCType], [view_NE_Department], [view_NE_EncounterID], [view_NE_Status] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV56WebPanel5DS_1_View_ne_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV57WebPanel5DS_2_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV58WebPanel5DS_3_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV63WebPanel5DS_8_Tfview_ne_admitdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV64WebPanel5DS_9_Tfview_ne_admitdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( AV65WebPanel5DS_10_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV66WebPanel5DS_11_Tfview_ne_israndrecheck) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (0==AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (0==AV68WebPanel5DS_13_Tfview_ne_israndapprove) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (0==AV69WebPanel5DS_14_Tfview_ne_israndapprove_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (0==AV70WebPanel5DS_15_Tfview_ne_isupdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (0==AV71WebPanel5DS_16_Tfview_ne_isupdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
         }
         else
         {
            GXv_int5[16] = 1;
         }
         if ( ! (0==AV74WebPanel5DS_19_Tfview_ne_information_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
         }
         else
         {
            GXv_int5[17] = 1;
         }
         if ( ! (0==AV75WebPanel5DS_20_Tfview_ne_information_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
         }
         else
         {
            GXv_int5[18] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
         }
         else
         {
            GXv_int5[19] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int5[20] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_TenantTenantCode]";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      protected Object[] conditional_P004P5( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV65WebPanel5DS_10_Tfview_ne_status_sels ,
                                             short AV56WebPanel5DS_1_View_ne_status ,
                                             long AV57WebPanel5DS_2_Tfview_ne_encounterid ,
                                             long AV58WebPanel5DS_3_Tfview_ne_encounterid_to ,
                                             String AV60WebPanel5DS_5_Tfview_ne_department_sel ,
                                             String AV59WebPanel5DS_4_Tfview_ne_department ,
                                             String AV62WebPanel5DS_7_Tfview_ne_enctype_sel ,
                                             String AV61WebPanel5DS_6_Tfview_ne_enctype ,
                                             DateTime AV63WebPanel5DS_8_Tfview_ne_admitdate ,
                                             DateTime AV64WebPanel5DS_9_Tfview_ne_admitdate_to ,
                                             int AV65WebPanel5DS_10_Tfview_ne_status_sels_Count ,
                                             short AV66WebPanel5DS_11_Tfview_ne_israndrecheck ,
                                             short AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to ,
                                             short AV68WebPanel5DS_13_Tfview_ne_israndapprove ,
                                             short AV69WebPanel5DS_14_Tfview_ne_israndapprove_to ,
                                             short AV70WebPanel5DS_15_Tfview_ne_isupdate ,
                                             short AV71WebPanel5DS_16_Tfview_ne_isupdate_to ,
                                             String AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel ,
                                             String AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode ,
                                             long AV74WebPanel5DS_19_Tfview_ne_information_id ,
                                             long AV75WebPanel5DS_20_Tfview_ne_information_id_to ,
                                             String AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel ,
                                             String AV76WebPanel5DS_21_Tfview_ne_information_patientno ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             DateTime A552view_NE_AdmitDate ,
                                             short A554view_NE_IsRandRecheck ,
                                             short A555view_NE_IsRandApprove ,
                                             short A556view_NE_IsUpdate ,
                                             String A557view_NE_TenantTenantCode ,
                                             long A558view_NE_Information_ID ,
                                             String A559view_NE_Information_PatientNo )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [21] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Information_PatientNo], [view_NE_Information_ID], [view_NE_TenantTenantCode], [view_NE_IsUpdate], [view_NE_IsRandApprove], [view_NE_IsRandRecheck], [view_NE_AdmitDate], [view_NE_ENCType], [view_NE_Department], [view_NE_EncounterID], [view_NE_Status] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV56WebPanel5DS_1_View_ne_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Status] = @AV56WebPanel5DS_1_View_ne_status)";
            }
         }
         else
         {
            GXv_int7[0] = 1;
         }
         if ( ! (0==AV57WebPanel5DS_2_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV57WebPanel5DS_2_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int7[1] = 1;
         }
         if ( ! (0==AV58WebPanel5DS_3_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV58WebPanel5DS_3_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int7[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel5DS_4_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV59WebPanel5DS_4_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int7[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel5DS_5_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV60WebPanel5DS_5_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int7[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61WebPanel5DS_6_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV61WebPanel5DS_6_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int7[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62WebPanel5DS_7_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV62WebPanel5DS_7_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int7[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV63WebPanel5DS_8_Tfview_ne_admitdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] >= @AV63WebPanel5DS_8_Tfview_ne_admitdate)";
            }
         }
         else
         {
            GXv_int7[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV64WebPanel5DS_9_Tfview_ne_admitdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_AdmitDate] <= @AV64WebPanel5DS_9_Tfview_ne_admitdate_to)";
            }
         }
         else
         {
            GXv_int7[8] = 1;
         }
         if ( AV65WebPanel5DS_10_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV65WebPanel5DS_10_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV66WebPanel5DS_11_Tfview_ne_israndrecheck) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] >= @AV66WebPanel5DS_11_Tfview_ne_israndrecheck)";
            }
         }
         else
         {
            GXv_int7[9] = 1;
         }
         if ( ! (0==AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandRecheck] <= @AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to)";
            }
         }
         else
         {
            GXv_int7[10] = 1;
         }
         if ( ! (0==AV68WebPanel5DS_13_Tfview_ne_israndapprove) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] >= @AV68WebPanel5DS_13_Tfview_ne_israndapprove)";
            }
         }
         else
         {
            GXv_int7[11] = 1;
         }
         if ( ! (0==AV69WebPanel5DS_14_Tfview_ne_israndapprove_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsRandApprove] <= @AV69WebPanel5DS_14_Tfview_ne_israndapprove_to)";
            }
         }
         else
         {
            GXv_int7[12] = 1;
         }
         if ( ! (0==AV70WebPanel5DS_15_Tfview_ne_isupdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] >= @AV70WebPanel5DS_15_Tfview_ne_isupdate)";
            }
         }
         else
         {
            GXv_int7[13] = 1;
         }
         if ( ! (0==AV71WebPanel5DS_16_Tfview_ne_isupdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_IsUpdate] <= @AV71WebPanel5DS_16_Tfview_ne_isupdate_to)";
            }
         }
         else
         {
            GXv_int7[14] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] like @lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode)";
            }
         }
         else
         {
            GXv_int7[15] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_TenantTenantCode] = @AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel)";
            }
         }
         else
         {
            GXv_int7[16] = 1;
         }
         if ( ! (0==AV74WebPanel5DS_19_Tfview_ne_information_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] >= @AV74WebPanel5DS_19_Tfview_ne_information_id)";
            }
         }
         else
         {
            GXv_int7[17] = 1;
         }
         if ( ! (0==AV75WebPanel5DS_20_Tfview_ne_information_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_ID] <= @AV75WebPanel5DS_20_Tfview_ne_information_id_to)";
            }
         }
         else
         {
            GXv_int7[18] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76WebPanel5DS_21_Tfview_ne_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] like @lV76WebPanel5DS_21_Tfview_ne_information_patientno)";
            }
         }
         else
         {
            GXv_int7[19] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Information_PatientNo] = @AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int7[20] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Information_PatientNo]";
         GXv_Object8[0] = scmdbuf;
         GXv_Object8[1] = GXv_int7;
         return GXv_Object8 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P004P2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (short)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (int)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (String)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (short)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (long)dynConstraints[32] , (String)dynConstraints[33] );
               case 1 :
                     return conditional_P004P3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (short)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (int)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (String)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (short)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (long)dynConstraints[32] , (String)dynConstraints[33] );
               case 2 :
                     return conditional_P004P4(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (short)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (int)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (String)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (short)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (long)dynConstraints[32] , (String)dynConstraints[33] );
               case 3 :
                     return conditional_P004P5(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (short)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (int)dynConstraints[11] , (short)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (String)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (short)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (long)dynConstraints[32] , (String)dynConstraints[33] );
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
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP004P2 ;
          prmP004P2 = new Object[] {
          new Object[] {"@AV56WebPanel5DS_1_View_ne_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV57WebPanel5DS_2_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58WebPanel5DS_3_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59WebPanel5DS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel5DS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV61WebPanel5DS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV62WebPanel5DS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63WebPanel5DS_8_Tfview_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV64WebPanel5DS_9_Tfview_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV66WebPanel5DS_11_Tfview_ne_israndrecheck",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV68WebPanel5DS_13_Tfview_ne_israndapprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV69WebPanel5DS_14_Tfview_ne_israndapprove_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV70WebPanel5DS_15_Tfview_ne_isupdate",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV71WebPanel5DS_16_Tfview_ne_isupdate_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV74WebPanel5DS_19_Tfview_ne_information_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75WebPanel5DS_20_Tfview_ne_information_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV76WebPanel5DS_21_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004P3 ;
          prmP004P3 = new Object[] {
          new Object[] {"@AV56WebPanel5DS_1_View_ne_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV57WebPanel5DS_2_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58WebPanel5DS_3_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59WebPanel5DS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel5DS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV61WebPanel5DS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV62WebPanel5DS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63WebPanel5DS_8_Tfview_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV64WebPanel5DS_9_Tfview_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV66WebPanel5DS_11_Tfview_ne_israndrecheck",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV68WebPanel5DS_13_Tfview_ne_israndapprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV69WebPanel5DS_14_Tfview_ne_israndapprove_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV70WebPanel5DS_15_Tfview_ne_isupdate",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV71WebPanel5DS_16_Tfview_ne_isupdate_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV74WebPanel5DS_19_Tfview_ne_information_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75WebPanel5DS_20_Tfview_ne_information_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV76WebPanel5DS_21_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004P4 ;
          prmP004P4 = new Object[] {
          new Object[] {"@AV56WebPanel5DS_1_View_ne_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV57WebPanel5DS_2_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58WebPanel5DS_3_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59WebPanel5DS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel5DS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV61WebPanel5DS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV62WebPanel5DS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63WebPanel5DS_8_Tfview_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV64WebPanel5DS_9_Tfview_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV66WebPanel5DS_11_Tfview_ne_israndrecheck",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV68WebPanel5DS_13_Tfview_ne_israndapprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV69WebPanel5DS_14_Tfview_ne_israndapprove_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV70WebPanel5DS_15_Tfview_ne_isupdate",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV71WebPanel5DS_16_Tfview_ne_isupdate_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV74WebPanel5DS_19_Tfview_ne_information_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75WebPanel5DS_20_Tfview_ne_information_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV76WebPanel5DS_21_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004P5 ;
          prmP004P5 = new Object[] {
          new Object[] {"@AV56WebPanel5DS_1_View_ne_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV57WebPanel5DS_2_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58WebPanel5DS_3_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59WebPanel5DS_4_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel5DS_5_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV61WebPanel5DS_6_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV62WebPanel5DS_7_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63WebPanel5DS_8_Tfview_ne_admitdate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV64WebPanel5DS_9_Tfview_ne_admitdate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV66WebPanel5DS_11_Tfview_ne_israndrecheck",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV67WebPanel5DS_12_Tfview_ne_israndrecheck_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV68WebPanel5DS_13_Tfview_ne_israndapprove",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV69WebPanel5DS_14_Tfview_ne_israndapprove_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV70WebPanel5DS_15_Tfview_ne_isupdate",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV71WebPanel5DS_16_Tfview_ne_isupdate_to",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV72WebPanel5DS_17_Tfview_ne_tenanttenantcode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV73WebPanel5DS_18_Tfview_ne_tenanttenantcode_sel",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV74WebPanel5DS_19_Tfview_ne_information_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75WebPanel5DS_20_Tfview_ne_information_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV76WebPanel5DS_21_Tfview_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV77WebPanel5DS_22_Tfview_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004P2,100,0,true,false )
             ,new CursorDef("P004P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004P3,100,0,true,false )
             ,new CursorDef("P004P4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004P4,100,0,true,false )
             ,new CursorDef("P004P5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004P5,100,0,true,false )
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
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
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
                   stmt.SetParameter(sIdx, (short)parms[21]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[30]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[31]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[32]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[34]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[35]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[38]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[39]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[21]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[30]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[31]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[32]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[34]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[35]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[38]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[39]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[21]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[30]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[31]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[32]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[34]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[35]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[38]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[39]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[21]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[30]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[31]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[32]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[34]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[35]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[38]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[39]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.webpanel5getfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class webpanel5getfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("webpanel5getfilterdata") )
          {
             return  ;
          }
          webpanel5getfilterdata worker = new webpanel5getfilterdata(context) ;
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
