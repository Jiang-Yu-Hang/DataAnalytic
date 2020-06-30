/*
               File: BR_DiagnosisWWGetFilterData
        Description: BR_Diagnosis WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:55.80
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
   public class br_diagnosiswwgetfilterdata : GXProcedure
   {
      public br_diagnosiswwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_diagnosiswwgetfilterdata( IGxContext context )
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
         this.AV33DDOName = aP0_DDOName;
         this.AV31SearchTxt = aP1_SearchTxt;
         this.AV32SearchTxtTo = aP2_SearchTxtTo;
         this.AV37OptionsJson = "" ;
         this.AV40OptionsDescJson = "" ;
         this.AV42OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV37OptionsJson;
         aP4_OptionsDescJson=this.AV40OptionsDescJson;
         aP5_OptionIndexesJson=this.AV42OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV33DDOName = aP0_DDOName;
         this.AV31SearchTxt = aP1_SearchTxt;
         this.AV32SearchTxtTo = aP2_SearchTxtTo;
         this.AV37OptionsJson = "" ;
         this.AV40OptionsDescJson = "" ;
         this.AV42OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV37OptionsJson;
         aP4_OptionsDescJson=this.AV40OptionsDescJson;
         aP5_OptionIndexesJson=this.AV42OptionIndexesJson;
         return AV42OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_diagnosiswwgetfilterdata objbr_diagnosiswwgetfilterdata;
         objbr_diagnosiswwgetfilterdata = new br_diagnosiswwgetfilterdata();
         objbr_diagnosiswwgetfilterdata.AV33DDOName = aP0_DDOName;
         objbr_diagnosiswwgetfilterdata.AV31SearchTxt = aP1_SearchTxt;
         objbr_diagnosiswwgetfilterdata.AV32SearchTxtTo = aP2_SearchTxtTo;
         objbr_diagnosiswwgetfilterdata.AV37OptionsJson = "" ;
         objbr_diagnosiswwgetfilterdata.AV40OptionsDescJson = "" ;
         objbr_diagnosiswwgetfilterdata.AV42OptionIndexesJson = "" ;
         objbr_diagnosiswwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_diagnosiswwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_diagnosiswwgetfilterdata);
         aP3_OptionsJson=this.AV37OptionsJson;
         aP4_OptionsDescJson=this.AV40OptionsDescJson;
         aP5_OptionIndexesJson=this.AV42OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_diagnosiswwgetfilterdata)stateInfo).executePrivate();
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
         AV36Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV39OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV41OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Diagnosis", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_INFORMATION_PATIENTNO") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_INFORMATION_PATIENTNOOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXID") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXIDOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXCODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXCODEOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXTYPE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXTYPEOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXTYPE_CODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXTYPE_CODEOPTIONS' */
               S161 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXTSOURCE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXTSOURCEOPTIONS' */
               S171 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXTSOURCE_CODEOPTIONS' */
               S181 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXDESCRIPTION") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXDESCRIPTIONOPTIONS' */
               S191 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_INITIALDX_CODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_INITIALDX_CODEOPTIONS' */
               S201 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_METASTASESDX_CODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_METASTASESDX_CODEOPTIONS' */
               S211 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV33DDOName), "DDO_BR_DIAGNOSIS_DXSOURCE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DIAGNOSIS_DXSOURCEOPTIONS' */
               S221 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV37OptionsJson = AV36Options.ToJSonString(false);
         AV40OptionsDescJson = AV39OptionsDesc.ToJSonString(false);
         AV42OptionIndexesJson = AV41OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV44Session.Get("BR_DiagnosisWWGridState"), "") == 0 )
         {
            AV46GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_DiagnosisWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV46GridState.FromXml(AV44Session.Get("BR_DiagnosisWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV65GXV1 = 1;
         while ( AV65GXV1 <= AV46GridState.gxTpr_Filtervalues.Count )
         {
            AV47GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV46GridState.gxTpr_Filtervalues.Item(AV65GXV1));
            if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSISID") == 0 )
            {
               AV11TFBR_DiagnosisID = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_DiagnosisID_To = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV15TFBR_Information_PatientNo = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV16TFBR_Information_PatientNo_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_NO") == 0 )
            {
               AV53TFBR_Diagnosis_No = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Value, "."));
               AV54TFBR_Diagnosis_No_To = (long)(NumberUtil.Val( AV47GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXID") == 0 )
            {
               AV17TFBR_Diagnosis_DXID = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXID_SEL") == 0 )
            {
               AV18TFBR_Diagnosis_DXID_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXCODE") == 0 )
            {
               AV19TFBR_Diagnosis_DXCode = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXCODE_SEL") == 0 )
            {
               AV20TFBR_Diagnosis_DXCode_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTYPE") == 0 )
            {
               AV21TFBR_Diagnosis_DXType = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTYPE_SEL") == 0 )
            {
               AV49TFBR_Diagnosis_DXType_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTYPE_CODE") == 0 )
            {
               AV55TFBR_Diagnosis_DXType_Code = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTYPE_CODE_SEL") == 0 )
            {
               AV56TFBR_Diagnosis_DXType_Code_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTSOURCE") == 0 )
            {
               AV23TFBR_Diagnosis_DXTsource = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTSOURCE_SEL") == 0 )
            {
               AV50TFBR_Diagnosis_DXTsource_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTSOURCE_CODE") == 0 )
            {
               AV57TFBR_Diagnosis_DXTsource_Code = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXTSOURCE_CODE_SEL") == 0 )
            {
               AV58TFBR_Diagnosis_DXTsource_Code_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXDESCRIPTION") == 0 )
            {
               AV25TFBR_Diagnosis_DXDescription = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXDESCRIPTION_SEL") == 0 )
            {
               AV26TFBR_Diagnosis_DXDescription_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_INITIALDX_SEL") == 0 )
            {
               AV27TFBR_Diagnosis_InitialDX_SelsJson = AV47GridStateFilterValue.gxTpr_Value;
               AV28TFBR_Diagnosis_InitialDX_Sels.FromJSonString(AV27TFBR_Diagnosis_InitialDX_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_INITIALDX_CODE") == 0 )
            {
               AV59TFBR_Diagnosis_InitialDX_Code = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_INITIALDX_CODE_SEL") == 0 )
            {
               AV60TFBR_Diagnosis_InitialDX_Code_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_METASTASESDX_SEL") == 0 )
            {
               AV29TFBR_Diagnosis_MetastasesDX_SelsJson = AV47GridStateFilterValue.gxTpr_Value;
               AV30TFBR_Diagnosis_MetastasesDX_Sels.FromJSonString(AV29TFBR_Diagnosis_MetastasesDX_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_METASTASESDX_CODE") == 0 )
            {
               AV61TFBR_Diagnosis_MetastasesDX_Code = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_METASTASESDX_CODE_SEL") == 0 )
            {
               AV62TFBR_Diagnosis_MetastasesDX_Code_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXSOURCE") == 0 )
            {
               AV51TFBR_Diagnosis_DXSource = AV47GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV47GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_DXSOURCE_SEL") == 0 )
            {
               AV52TFBR_Diagnosis_DXSource_Sel = AV47GridStateFilterValue.gxTpr_Value;
            }
            AV65GXV1 = (int)(AV65GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV15TFBR_Information_PatientNo = AV31SearchTxt;
         AV16TFBR_Information_PatientNo_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T2 */
         pr_default.execute(0, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK1T2 = false;
            A85BR_Information_ID = P001T2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T2_n36BR_Information_PatientNo[0];
            A260BR_Diagnosis_DXSource = P001T2_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T2_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T2_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T2_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T2_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T2_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T2_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T2_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T2_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T2_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T2_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T2_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T2_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T2_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T2_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T2_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T2_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T2_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T2_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T2_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T2_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T2_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T2_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T2_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T2_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T2_n513BR_Diagnosis_No[0];
            A19BR_EncounterID = P001T2_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T2_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T2_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001T2_A36BR_Information_PatientNo[0], A36BR_Information_PatientNo) == 0 ) )
            {
               BRK1T2 = false;
               A85BR_Information_ID = P001T2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001T2_n85BR_Information_ID[0];
               A19BR_EncounterID = P001T2_A19BR_EncounterID[0];
               A64BR_DiagnosisID = P001T2_A64BR_DiagnosisID[0];
               A85BR_Information_ID = P001T2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001T2_n85BR_Information_ID[0];
               AV43count = (long)(AV43count+1);
               BRK1T2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A36BR_Information_PatientNo)) )
            {
               AV35Option = A36BR_Information_PatientNo;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T2 )
            {
               BRK1T2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_DIAGNOSIS_DXIDOPTIONS' Routine */
         AV17TFBR_Diagnosis_DXID = AV31SearchTxt;
         AV18TFBR_Diagnosis_DXID_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T3 */
         pr_default.execute(1, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK1T4 = false;
            A85BR_Information_ID = P001T3_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T3_n85BR_Information_ID[0];
            A65BR_Diagnosis_DXID = P001T3_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T3_n65BR_Diagnosis_DXID[0];
            A260BR_Diagnosis_DXSource = P001T3_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T3_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T3_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T3_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T3_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T3_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T3_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T3_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T3_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T3_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T3_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T3_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T3_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T3_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T3_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T3_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T3_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T3_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T3_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T3_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T3_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T3_n66BR_Diagnosis_DXCode[0];
            A513BR_Diagnosis_No = P001T3_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T3_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T3_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T3_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T3_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T3_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T3_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T3_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P001T3_A65BR_Diagnosis_DXID[0], A65BR_Diagnosis_DXID) == 0 ) )
            {
               BRK1T4 = false;
               A64BR_DiagnosisID = P001T3_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A65BR_Diagnosis_DXID)) )
            {
               AV35Option = A65BR_Diagnosis_DXID;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T4 )
            {
               BRK1T4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_DIAGNOSIS_DXCODEOPTIONS' Routine */
         AV19TFBR_Diagnosis_DXCode = AV31SearchTxt;
         AV20TFBR_Diagnosis_DXCode_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T4 */
         pr_default.execute(2, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK1T6 = false;
            A85BR_Information_ID = P001T4_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T4_n85BR_Information_ID[0];
            A66BR_Diagnosis_DXCode = P001T4_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T4_n66BR_Diagnosis_DXCode[0];
            A260BR_Diagnosis_DXSource = P001T4_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T4_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T4_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T4_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T4_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T4_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T4_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T4_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T4_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T4_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T4_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T4_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T4_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T4_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T4_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T4_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T4_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T4_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T4_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T4_n67BR_Diagnosis_DXType[0];
            A65BR_Diagnosis_DXID = P001T4_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T4_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T4_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T4_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T4_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T4_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T4_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T4_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T4_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T4_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P001T4_A66BR_Diagnosis_DXCode[0], A66BR_Diagnosis_DXCode) == 0 ) )
            {
               BRK1T6 = false;
               A64BR_DiagnosisID = P001T4_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A66BR_Diagnosis_DXCode)) )
            {
               AV35Option = A66BR_Diagnosis_DXCode;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T6 )
            {
               BRK1T6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_DIAGNOSIS_DXTYPEOPTIONS' Routine */
         AV21TFBR_Diagnosis_DXType = AV31SearchTxt;
         AV49TFBR_Diagnosis_DXType_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T5 */
         pr_default.execute(3, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK1T8 = false;
            A85BR_Information_ID = P001T5_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T5_n85BR_Information_ID[0];
            A67BR_Diagnosis_DXType = P001T5_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T5_n67BR_Diagnosis_DXType[0];
            A260BR_Diagnosis_DXSource = P001T5_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T5_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T5_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T5_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T5_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T5_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T5_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T5_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T5_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T5_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T5_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T5_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T5_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T5_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T5_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T5_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T5_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T5_n466BR_Diagnosis_DXType_Code[0];
            A66BR_Diagnosis_DXCode = P001T5_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T5_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T5_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T5_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T5_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T5_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T5_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T5_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T5_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T5_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T5_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T5_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P001T5_A67BR_Diagnosis_DXType[0], A67BR_Diagnosis_DXType) == 0 ) )
            {
               BRK1T8 = false;
               A64BR_DiagnosisID = P001T5_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A67BR_Diagnosis_DXType)) )
            {
               AV35Option = A67BR_Diagnosis_DXType;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T8 )
            {
               BRK1T8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
      }

      protected void S161( )
      {
         /* 'LOADBR_DIAGNOSIS_DXTYPE_CODEOPTIONS' Routine */
         AV55TFBR_Diagnosis_DXType_Code = AV31SearchTxt;
         AV56TFBR_Diagnosis_DXType_Code_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T6 */
         pr_default.execute(4, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK1T10 = false;
            A85BR_Information_ID = P001T6_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T6_n85BR_Information_ID[0];
            A466BR_Diagnosis_DXType_Code = P001T6_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T6_n466BR_Diagnosis_DXType_Code[0];
            A260BR_Diagnosis_DXSource = P001T6_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T6_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T6_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T6_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T6_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T6_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T6_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T6_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T6_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T6_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T6_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T6_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T6_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T6_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T6_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T6_n68BR_Diagnosis_DXTsource[0];
            A67BR_Diagnosis_DXType = P001T6_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T6_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T6_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T6_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T6_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T6_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T6_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T6_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T6_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T6_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T6_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T6_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T6_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(P001T6_A466BR_Diagnosis_DXType_Code[0], A466BR_Diagnosis_DXType_Code) == 0 ) )
            {
               BRK1T10 = false;
               A64BR_DiagnosisID = P001T6_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T10 = true;
               pr_default.readNext(4);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A466BR_Diagnosis_DXType_Code)) )
            {
               AV35Option = A466BR_Diagnosis_DXType_Code;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T10 )
            {
               BRK1T10 = true;
               pr_default.readNext(4);
            }
         }
         pr_default.close(4);
      }

      protected void S171( )
      {
         /* 'LOADBR_DIAGNOSIS_DXTSOURCEOPTIONS' Routine */
         AV23TFBR_Diagnosis_DXTsource = AV31SearchTxt;
         AV50TFBR_Diagnosis_DXTsource_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(5, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T7 */
         pr_default.execute(5, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(5) != 101) )
         {
            BRK1T12 = false;
            A85BR_Information_ID = P001T7_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T7_n85BR_Information_ID[0];
            A68BR_Diagnosis_DXTsource = P001T7_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T7_n68BR_Diagnosis_DXTsource[0];
            A260BR_Diagnosis_DXSource = P001T7_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T7_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T7_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T7_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T7_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T7_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T7_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T7_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T7_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T7_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T7_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T7_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T7_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T7_n467BR_Diagnosis_DXTsource_Code[0];
            A466BR_Diagnosis_DXType_Code = P001T7_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T7_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T7_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T7_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T7_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T7_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T7_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T7_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T7_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T7_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T7_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T7_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T7_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T7_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T7_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T7_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(5) != 101) && ( StringUtil.StrCmp(P001T7_A68BR_Diagnosis_DXTsource[0], A68BR_Diagnosis_DXTsource) == 0 ) )
            {
               BRK1T12 = false;
               A64BR_DiagnosisID = P001T7_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T12 = true;
               pr_default.readNext(5);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) )
            {
               AV35Option = A68BR_Diagnosis_DXTsource;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T12 )
            {
               BRK1T12 = true;
               pr_default.readNext(5);
            }
         }
         pr_default.close(5);
      }

      protected void S181( )
      {
         /* 'LOADBR_DIAGNOSIS_DXTSOURCE_CODEOPTIONS' Routine */
         AV57TFBR_Diagnosis_DXTsource_Code = AV31SearchTxt;
         AV58TFBR_Diagnosis_DXTsource_Code_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(6, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T8 */
         pr_default.execute(6, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(6) != 101) )
         {
            BRK1T14 = false;
            A85BR_Information_ID = P001T8_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T8_n85BR_Information_ID[0];
            A467BR_Diagnosis_DXTsource_Code = P001T8_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T8_n467BR_Diagnosis_DXTsource_Code[0];
            A260BR_Diagnosis_DXSource = P001T8_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T8_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T8_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T8_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T8_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T8_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T8_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T8_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T8_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T8_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T8_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T8_n69BR_Diagnosis_DXDescription[0];
            A68BR_Diagnosis_DXTsource = P001T8_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T8_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T8_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T8_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T8_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T8_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T8_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T8_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T8_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T8_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T8_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T8_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T8_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T8_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T8_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T8_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T8_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T8_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(6) != 101) && ( StringUtil.StrCmp(P001T8_A467BR_Diagnosis_DXTsource_Code[0], A467BR_Diagnosis_DXTsource_Code) == 0 ) )
            {
               BRK1T14 = false;
               A64BR_DiagnosisID = P001T8_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T14 = true;
               pr_default.readNext(6);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A467BR_Diagnosis_DXTsource_Code)) )
            {
               AV35Option = A467BR_Diagnosis_DXTsource_Code;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T14 )
            {
               BRK1T14 = true;
               pr_default.readNext(6);
            }
         }
         pr_default.close(6);
      }

      protected void S191( )
      {
         /* 'LOADBR_DIAGNOSIS_DXDESCRIPTIONOPTIONS' Routine */
         AV25TFBR_Diagnosis_DXDescription = AV31SearchTxt;
         AV26TFBR_Diagnosis_DXDescription_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(7, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T9 */
         pr_default.execute(7, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(7) != 101) )
         {
            BRK1T16 = false;
            A85BR_Information_ID = P001T9_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T9_n85BR_Information_ID[0];
            A69BR_Diagnosis_DXDescription = P001T9_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T9_n69BR_Diagnosis_DXDescription[0];
            A260BR_Diagnosis_DXSource = P001T9_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T9_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T9_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T9_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T9_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T9_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T9_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T9_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T9_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T9_n70BR_Diagnosis_InitialDX[0];
            A467BR_Diagnosis_DXTsource_Code = P001T9_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T9_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T9_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T9_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T9_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T9_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T9_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T9_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T9_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T9_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T9_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T9_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T9_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T9_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T9_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T9_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T9_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T9_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T9_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T9_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T9_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T9_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(7) != 101) && ( StringUtil.StrCmp(P001T9_A69BR_Diagnosis_DXDescription[0], A69BR_Diagnosis_DXDescription) == 0 ) )
            {
               BRK1T16 = false;
               A64BR_DiagnosisID = P001T9_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T16 = true;
               pr_default.readNext(7);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) )
            {
               AV35Option = A69BR_Diagnosis_DXDescription;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T16 )
            {
               BRK1T16 = true;
               pr_default.readNext(7);
            }
         }
         pr_default.close(7);
      }

      protected void S201( )
      {
         /* 'LOADBR_DIAGNOSIS_INITIALDX_CODEOPTIONS' Routine */
         AV59TFBR_Diagnosis_InitialDX_Code = AV31SearchTxt;
         AV60TFBR_Diagnosis_InitialDX_Code_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(8, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T10 */
         pr_default.execute(8, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(8) != 101) )
         {
            BRK1T18 = false;
            A85BR_Information_ID = P001T10_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T10_n85BR_Information_ID[0];
            A503BR_Diagnosis_InitialDX_Code = P001T10_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T10_n503BR_Diagnosis_InitialDX_Code[0];
            A260BR_Diagnosis_DXSource = P001T10_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T10_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T10_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T10_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T10_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T10_n71BR_Diagnosis_MetastasesDX[0];
            A70BR_Diagnosis_InitialDX = P001T10_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T10_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T10_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T10_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T10_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T10_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T10_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T10_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T10_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T10_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T10_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T10_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T10_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T10_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T10_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T10_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T10_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T10_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T10_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T10_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T10_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T10_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T10_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T10_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T10_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T10_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(8) != 101) && ( StringUtil.StrCmp(P001T10_A503BR_Diagnosis_InitialDX_Code[0], A503BR_Diagnosis_InitialDX_Code) == 0 ) )
            {
               BRK1T18 = false;
               A64BR_DiagnosisID = P001T10_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T18 = true;
               pr_default.readNext(8);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A503BR_Diagnosis_InitialDX_Code)) )
            {
               AV35Option = A503BR_Diagnosis_InitialDX_Code;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T18 )
            {
               BRK1T18 = true;
               pr_default.readNext(8);
            }
         }
         pr_default.close(8);
      }

      protected void S211( )
      {
         /* 'LOADBR_DIAGNOSIS_METASTASESDX_CODEOPTIONS' Routine */
         AV61TFBR_Diagnosis_MetastasesDX_Code = AV31SearchTxt;
         AV62TFBR_Diagnosis_MetastasesDX_Code_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(9, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T11 */
         pr_default.execute(9, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(9) != 101) )
         {
            BRK1T20 = false;
            A85BR_Information_ID = P001T11_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T11_n85BR_Information_ID[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T11_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T11_n504BR_Diagnosis_MetastasesDX_Code[0];
            A260BR_Diagnosis_DXSource = P001T11_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T11_n260BR_Diagnosis_DXSource[0];
            A71BR_Diagnosis_MetastasesDX = P001T11_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T11_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T11_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T11_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T11_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T11_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T11_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T11_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T11_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T11_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T11_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T11_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T11_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T11_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T11_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T11_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T11_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T11_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T11_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T11_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T11_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T11_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T11_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T11_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T11_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T11_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T11_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T11_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T11_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T11_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(9) != 101) && ( StringUtil.StrCmp(P001T11_A504BR_Diagnosis_MetastasesDX_Code[0], A504BR_Diagnosis_MetastasesDX_Code) == 0 ) )
            {
               BRK1T20 = false;
               A64BR_DiagnosisID = P001T11_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T20 = true;
               pr_default.readNext(9);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A504BR_Diagnosis_MetastasesDX_Code)) )
            {
               AV35Option = A504BR_Diagnosis_MetastasesDX_Code;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T20 )
            {
               BRK1T20 = true;
               pr_default.readNext(9);
            }
         }
         pr_default.close(9);
      }

      protected void S221( )
      {
         /* 'LOADBR_DIAGNOSIS_DXSOURCEOPTIONS' Routine */
         AV51TFBR_Diagnosis_DXSource = AV31SearchTxt;
         AV52TFBR_Diagnosis_DXSource_Sel = "";
         AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid = AV11TFBR_DiagnosisID;
         AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to = AV12TFBR_DiagnosisID_To;
         AV69BR_DiagnosisWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no = AV53TFBR_Diagnosis_No;
         AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to = AV54TFBR_Diagnosis_No_To;
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = AV17TFBR_Diagnosis_DXID;
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = AV18TFBR_Diagnosis_DXID_Sel;
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = AV19TFBR_Diagnosis_DXCode;
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = AV20TFBR_Diagnosis_DXCode_Sel;
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = AV21TFBR_Diagnosis_DXType;
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = AV49TFBR_Diagnosis_DXType_Sel;
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = AV55TFBR_Diagnosis_DXType_Code;
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = AV56TFBR_Diagnosis_DXType_Code_Sel;
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = AV23TFBR_Diagnosis_DXTsource;
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = AV50TFBR_Diagnosis_DXTsource_Sel;
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = AV57TFBR_Diagnosis_DXTsource_Code;
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = AV58TFBR_Diagnosis_DXTsource_Code_Sel;
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = AV25TFBR_Diagnosis_DXDescription;
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = AV26TFBR_Diagnosis_DXDescription_Sel;
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = AV28TFBR_Diagnosis_InitialDX_Sels;
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = AV59TFBR_Diagnosis_InitialDX_Code;
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = AV60TFBR_Diagnosis_InitialDX_Code_Sel;
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = AV30TFBR_Diagnosis_MetastasesDX_Sels;
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = AV61TFBR_Diagnosis_MetastasesDX_Code;
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = AV62TFBR_Diagnosis_MetastasesDX_Code_Sel;
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = AV51TFBR_Diagnosis_DXSource;
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = AV52TFBR_Diagnosis_DXSource_Sel;
         pr_default.dynParam(10, new Object[]{ new Object[]{
                                              A70BR_Diagnosis_InitialDX ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              A71BR_Diagnosis_MetastasesDX ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels.Count ,
                                              AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels.Count ,
                                              AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              A64BR_DiagnosisID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A513BR_Diagnosis_No ,
                                              A65BR_Diagnosis_DXID ,
                                              A66BR_Diagnosis_DXCode ,
                                              A67BR_Diagnosis_DXType ,
                                              A466BR_Diagnosis_DXType_Code ,
                                              A68BR_Diagnosis_DXTsource ,
                                              A467BR_Diagnosis_DXTsource_Code ,
                                              A69BR_Diagnosis_DXDescription ,
                                              A503BR_Diagnosis_InitialDX_Code ,
                                              A504BR_Diagnosis_MetastasesDX_Code ,
                                              A260BR_Diagnosis_DXSource } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = StringUtil.Concat( StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid), "%", "");
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = StringUtil.Concat( StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode), "%", "");
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = StringUtil.Concat( StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype), "%", "");
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = StringUtil.Concat( StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code), "%", "");
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = StringUtil.Concat( StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource), "%", "");
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = StringUtil.Concat( StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code), "%", "");
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = StringUtil.Concat( StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription), "%", "");
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = StringUtil.Concat( StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code), "%", "");
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = StringUtil.Concat( StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code), "%", "");
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = StringUtil.Concat( StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource), "%", "");
         /* Using cursor P001T12 */
         pr_default.execute(10, new Object[] {AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid, AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to, AV69BR_DiagnosisWWDS_3_Tfbr_encounterid, AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to, lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno, AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel, AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no, AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to, lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid, AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel, lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode, AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel, lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype, AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel, lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code, AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel, lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource, AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel, lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code, AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel, lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription, AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel, lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code, AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel, lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code, AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel, lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource, AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel});
         while ( (pr_default.getStatus(10) != 101) )
         {
            BRK1T22 = false;
            A85BR_Information_ID = P001T12_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T12_n85BR_Information_ID[0];
            A260BR_Diagnosis_DXSource = P001T12_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = P001T12_n260BR_Diagnosis_DXSource[0];
            A504BR_Diagnosis_MetastasesDX_Code = P001T12_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = P001T12_n504BR_Diagnosis_MetastasesDX_Code[0];
            A71BR_Diagnosis_MetastasesDX = P001T12_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = P001T12_n71BR_Diagnosis_MetastasesDX[0];
            A503BR_Diagnosis_InitialDX_Code = P001T12_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = P001T12_n503BR_Diagnosis_InitialDX_Code[0];
            A70BR_Diagnosis_InitialDX = P001T12_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = P001T12_n70BR_Diagnosis_InitialDX[0];
            A69BR_Diagnosis_DXDescription = P001T12_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = P001T12_n69BR_Diagnosis_DXDescription[0];
            A467BR_Diagnosis_DXTsource_Code = P001T12_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = P001T12_n467BR_Diagnosis_DXTsource_Code[0];
            A68BR_Diagnosis_DXTsource = P001T12_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = P001T12_n68BR_Diagnosis_DXTsource[0];
            A466BR_Diagnosis_DXType_Code = P001T12_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = P001T12_n466BR_Diagnosis_DXType_Code[0];
            A67BR_Diagnosis_DXType = P001T12_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = P001T12_n67BR_Diagnosis_DXType[0];
            A66BR_Diagnosis_DXCode = P001T12_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = P001T12_n66BR_Diagnosis_DXCode[0];
            A65BR_Diagnosis_DXID = P001T12_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = P001T12_n65BR_Diagnosis_DXID[0];
            A513BR_Diagnosis_No = P001T12_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = P001T12_n513BR_Diagnosis_No[0];
            A36BR_Information_PatientNo = P001T12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T12_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001T12_A19BR_EncounterID[0];
            A64BR_DiagnosisID = P001T12_A64BR_DiagnosisID[0];
            A85BR_Information_ID = P001T12_A85BR_Information_ID[0];
            n85BR_Information_ID = P001T12_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001T12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001T12_n36BR_Information_PatientNo[0];
            AV43count = 0;
            while ( (pr_default.getStatus(10) != 101) && ( StringUtil.StrCmp(P001T12_A260BR_Diagnosis_DXSource[0], A260BR_Diagnosis_DXSource) == 0 ) )
            {
               BRK1T22 = false;
               A64BR_DiagnosisID = P001T12_A64BR_DiagnosisID[0];
               AV43count = (long)(AV43count+1);
               BRK1T22 = true;
               pr_default.readNext(10);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A260BR_Diagnosis_DXSource)) )
            {
               AV35Option = A260BR_Diagnosis_DXSource;
               AV36Options.Add(AV35Option, 0);
               AV41OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV43count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV36Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1T22 )
            {
               BRK1T22 = true;
               pr_default.readNext(10);
            }
         }
         pr_default.close(10);
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
         AV36Options = new GxSimpleCollection<String>();
         AV39OptionsDesc = new GxSimpleCollection<String>();
         AV41OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV44Session = context.GetSession();
         AV46GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV47GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Information_PatientNo = "";
         AV16TFBR_Information_PatientNo_Sel = "";
         AV17TFBR_Diagnosis_DXID = "";
         AV18TFBR_Diagnosis_DXID_Sel = "";
         AV19TFBR_Diagnosis_DXCode = "";
         AV20TFBR_Diagnosis_DXCode_Sel = "";
         AV21TFBR_Diagnosis_DXType = "";
         AV49TFBR_Diagnosis_DXType_Sel = "";
         AV55TFBR_Diagnosis_DXType_Code = "";
         AV56TFBR_Diagnosis_DXType_Code_Sel = "";
         AV23TFBR_Diagnosis_DXTsource = "";
         AV50TFBR_Diagnosis_DXTsource_Sel = "";
         AV57TFBR_Diagnosis_DXTsource_Code = "";
         AV58TFBR_Diagnosis_DXTsource_Code_Sel = "";
         AV25TFBR_Diagnosis_DXDescription = "";
         AV26TFBR_Diagnosis_DXDescription_Sel = "";
         AV27TFBR_Diagnosis_InitialDX_SelsJson = "";
         AV28TFBR_Diagnosis_InitialDX_Sels = new GxSimpleCollection<String>();
         AV59TFBR_Diagnosis_InitialDX_Code = "";
         AV60TFBR_Diagnosis_InitialDX_Code_Sel = "";
         AV29TFBR_Diagnosis_MetastasesDX_SelsJson = "";
         AV30TFBR_Diagnosis_MetastasesDX_Sels = new GxSimpleCollection<String>();
         AV61TFBR_Diagnosis_MetastasesDX_Code = "";
         AV62TFBR_Diagnosis_MetastasesDX_Code_Sel = "";
         AV51TFBR_Diagnosis_DXSource = "";
         AV52TFBR_Diagnosis_DXSource_Sel = "";
         AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = "";
         AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel = "";
         AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = "";
         AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel = "";
         AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = "";
         AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel = "";
         AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = "";
         AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel = "";
         AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = "";
         AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel = "";
         AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = "";
         AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel = "";
         AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = "";
         AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel = "";
         AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = "";
         AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel = "";
         AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels = new GxSimpleCollection<String>();
         AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = "";
         AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel = "";
         AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels = new GxSimpleCollection<String>();
         AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = "";
         AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel = "";
         AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = "";
         AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel = "";
         scmdbuf = "";
         lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno = "";
         lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid = "";
         lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode = "";
         lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype = "";
         lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code = "";
         lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource = "";
         lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code = "";
         lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription = "";
         lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code = "";
         lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code = "";
         lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource = "";
         A70BR_Diagnosis_InitialDX = "";
         A71BR_Diagnosis_MetastasesDX = "";
         A36BR_Information_PatientNo = "";
         A65BR_Diagnosis_DXID = "";
         A66BR_Diagnosis_DXCode = "";
         A67BR_Diagnosis_DXType = "";
         A466BR_Diagnosis_DXType_Code = "";
         A68BR_Diagnosis_DXTsource = "";
         A467BR_Diagnosis_DXTsource_Code = "";
         A69BR_Diagnosis_DXDescription = "";
         A503BR_Diagnosis_InitialDX_Code = "";
         A504BR_Diagnosis_MetastasesDX_Code = "";
         A260BR_Diagnosis_DXSource = "";
         P001T2_A85BR_Information_ID = new long[1] ;
         P001T2_n85BR_Information_ID = new bool[] {false} ;
         P001T2_A36BR_Information_PatientNo = new String[] {""} ;
         P001T2_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T2_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T2_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T2_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T2_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T2_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T2_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T2_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T2_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T2_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T2_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T2_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T2_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T2_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T2_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T2_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T2_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T2_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T2_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T2_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T2_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T2_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T2_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T2_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T2_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T2_A513BR_Diagnosis_No = new long[1] ;
         P001T2_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T2_A19BR_EncounterID = new long[1] ;
         P001T2_A64BR_DiagnosisID = new long[1] ;
         AV35Option = "";
         P001T3_A85BR_Information_ID = new long[1] ;
         P001T3_n85BR_Information_ID = new bool[] {false} ;
         P001T3_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T3_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T3_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T3_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T3_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T3_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T3_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T3_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T3_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T3_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T3_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T3_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T3_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T3_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T3_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T3_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T3_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T3_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T3_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T3_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T3_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T3_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T3_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T3_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T3_A513BR_Diagnosis_No = new long[1] ;
         P001T3_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T3_A36BR_Information_PatientNo = new String[] {""} ;
         P001T3_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T3_A19BR_EncounterID = new long[1] ;
         P001T3_A64BR_DiagnosisID = new long[1] ;
         P001T4_A85BR_Information_ID = new long[1] ;
         P001T4_n85BR_Information_ID = new bool[] {false} ;
         P001T4_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T4_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T4_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T4_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T4_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T4_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T4_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T4_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T4_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T4_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T4_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T4_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T4_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T4_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T4_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T4_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T4_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T4_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T4_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T4_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T4_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T4_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T4_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T4_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T4_A513BR_Diagnosis_No = new long[1] ;
         P001T4_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T4_A36BR_Information_PatientNo = new String[] {""} ;
         P001T4_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T4_A19BR_EncounterID = new long[1] ;
         P001T4_A64BR_DiagnosisID = new long[1] ;
         P001T5_A85BR_Information_ID = new long[1] ;
         P001T5_n85BR_Information_ID = new bool[] {false} ;
         P001T5_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T5_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T5_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T5_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T5_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T5_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T5_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T5_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T5_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T5_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T5_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T5_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T5_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T5_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T5_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T5_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T5_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T5_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T5_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T5_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T5_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T5_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T5_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T5_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T5_A513BR_Diagnosis_No = new long[1] ;
         P001T5_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T5_A36BR_Information_PatientNo = new String[] {""} ;
         P001T5_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T5_A19BR_EncounterID = new long[1] ;
         P001T5_A64BR_DiagnosisID = new long[1] ;
         P001T6_A85BR_Information_ID = new long[1] ;
         P001T6_n85BR_Information_ID = new bool[] {false} ;
         P001T6_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T6_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T6_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T6_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T6_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T6_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T6_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T6_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T6_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T6_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T6_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T6_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T6_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T6_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T6_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T6_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T6_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T6_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T6_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T6_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T6_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T6_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T6_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T6_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T6_A513BR_Diagnosis_No = new long[1] ;
         P001T6_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T6_A36BR_Information_PatientNo = new String[] {""} ;
         P001T6_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T6_A19BR_EncounterID = new long[1] ;
         P001T6_A64BR_DiagnosisID = new long[1] ;
         P001T7_A85BR_Information_ID = new long[1] ;
         P001T7_n85BR_Information_ID = new bool[] {false} ;
         P001T7_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T7_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T7_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T7_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T7_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T7_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T7_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T7_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T7_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T7_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T7_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T7_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T7_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T7_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T7_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T7_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T7_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T7_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T7_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T7_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T7_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T7_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T7_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T7_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T7_A513BR_Diagnosis_No = new long[1] ;
         P001T7_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T7_A36BR_Information_PatientNo = new String[] {""} ;
         P001T7_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T7_A19BR_EncounterID = new long[1] ;
         P001T7_A64BR_DiagnosisID = new long[1] ;
         P001T8_A85BR_Information_ID = new long[1] ;
         P001T8_n85BR_Information_ID = new bool[] {false} ;
         P001T8_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T8_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T8_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T8_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T8_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T8_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T8_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T8_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T8_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T8_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T8_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T8_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T8_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T8_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T8_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T8_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T8_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T8_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T8_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T8_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T8_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T8_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T8_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T8_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T8_A513BR_Diagnosis_No = new long[1] ;
         P001T8_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T8_A36BR_Information_PatientNo = new String[] {""} ;
         P001T8_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T8_A19BR_EncounterID = new long[1] ;
         P001T8_A64BR_DiagnosisID = new long[1] ;
         P001T9_A85BR_Information_ID = new long[1] ;
         P001T9_n85BR_Information_ID = new bool[] {false} ;
         P001T9_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T9_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T9_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T9_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T9_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T9_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T9_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T9_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T9_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T9_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T9_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T9_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T9_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T9_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T9_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T9_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T9_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T9_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T9_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T9_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T9_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T9_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T9_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T9_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T9_A513BR_Diagnosis_No = new long[1] ;
         P001T9_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T9_A36BR_Information_PatientNo = new String[] {""} ;
         P001T9_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T9_A19BR_EncounterID = new long[1] ;
         P001T9_A64BR_DiagnosisID = new long[1] ;
         P001T10_A85BR_Information_ID = new long[1] ;
         P001T10_n85BR_Information_ID = new bool[] {false} ;
         P001T10_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T10_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T10_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T10_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T10_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T10_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T10_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T10_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T10_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T10_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T10_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T10_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T10_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T10_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T10_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T10_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T10_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T10_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T10_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T10_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T10_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T10_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T10_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T10_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T10_A513BR_Diagnosis_No = new long[1] ;
         P001T10_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T10_A36BR_Information_PatientNo = new String[] {""} ;
         P001T10_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T10_A19BR_EncounterID = new long[1] ;
         P001T10_A64BR_DiagnosisID = new long[1] ;
         P001T11_A85BR_Information_ID = new long[1] ;
         P001T11_n85BR_Information_ID = new bool[] {false} ;
         P001T11_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T11_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T11_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T11_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T11_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T11_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T11_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T11_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T11_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T11_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T11_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T11_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T11_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T11_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T11_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T11_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T11_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T11_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T11_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T11_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T11_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T11_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T11_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T11_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T11_A513BR_Diagnosis_No = new long[1] ;
         P001T11_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T11_A36BR_Information_PatientNo = new String[] {""} ;
         P001T11_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T11_A19BR_EncounterID = new long[1] ;
         P001T11_A64BR_DiagnosisID = new long[1] ;
         P001T12_A85BR_Information_ID = new long[1] ;
         P001T12_n85BR_Information_ID = new bool[] {false} ;
         P001T12_A260BR_Diagnosis_DXSource = new String[] {""} ;
         P001T12_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         P001T12_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         P001T12_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         P001T12_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         P001T12_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         P001T12_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         P001T12_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         P001T12_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         P001T12_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         P001T12_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         P001T12_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         P001T12_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         P001T12_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         P001T12_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         P001T12_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         P001T12_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         P001T12_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         P001T12_A67BR_Diagnosis_DXType = new String[] {""} ;
         P001T12_n67BR_Diagnosis_DXType = new bool[] {false} ;
         P001T12_A66BR_Diagnosis_DXCode = new String[] {""} ;
         P001T12_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         P001T12_A65BR_Diagnosis_DXID = new String[] {""} ;
         P001T12_n65BR_Diagnosis_DXID = new bool[] {false} ;
         P001T12_A513BR_Diagnosis_No = new long[1] ;
         P001T12_n513BR_Diagnosis_No = new bool[] {false} ;
         P001T12_A36BR_Information_PatientNo = new String[] {""} ;
         P001T12_n36BR_Information_PatientNo = new bool[] {false} ;
         P001T12_A19BR_EncounterID = new long[1] ;
         P001T12_A64BR_DiagnosisID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosiswwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P001T2_A85BR_Information_ID, P001T2_n85BR_Information_ID, P001T2_A36BR_Information_PatientNo, P001T2_n36BR_Information_PatientNo, P001T2_A260BR_Diagnosis_DXSource, P001T2_n260BR_Diagnosis_DXSource, P001T2_A504BR_Diagnosis_MetastasesDX_Code, P001T2_n504BR_Diagnosis_MetastasesDX_Code, P001T2_A71BR_Diagnosis_MetastasesDX, P001T2_n71BR_Diagnosis_MetastasesDX,
               P001T2_A503BR_Diagnosis_InitialDX_Code, P001T2_n503BR_Diagnosis_InitialDX_Code, P001T2_A70BR_Diagnosis_InitialDX, P001T2_n70BR_Diagnosis_InitialDX, P001T2_A69BR_Diagnosis_DXDescription, P001T2_n69BR_Diagnosis_DXDescription, P001T2_A467BR_Diagnosis_DXTsource_Code, P001T2_n467BR_Diagnosis_DXTsource_Code, P001T2_A68BR_Diagnosis_DXTsource, P001T2_n68BR_Diagnosis_DXTsource,
               P001T2_A466BR_Diagnosis_DXType_Code, P001T2_n466BR_Diagnosis_DXType_Code, P001T2_A67BR_Diagnosis_DXType, P001T2_n67BR_Diagnosis_DXType, P001T2_A66BR_Diagnosis_DXCode, P001T2_n66BR_Diagnosis_DXCode, P001T2_A65BR_Diagnosis_DXID, P001T2_n65BR_Diagnosis_DXID, P001T2_A513BR_Diagnosis_No, P001T2_n513BR_Diagnosis_No,
               P001T2_A19BR_EncounterID, P001T2_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T3_A85BR_Information_ID, P001T3_n85BR_Information_ID, P001T3_A65BR_Diagnosis_DXID, P001T3_n65BR_Diagnosis_DXID, P001T3_A260BR_Diagnosis_DXSource, P001T3_n260BR_Diagnosis_DXSource, P001T3_A504BR_Diagnosis_MetastasesDX_Code, P001T3_n504BR_Diagnosis_MetastasesDX_Code, P001T3_A71BR_Diagnosis_MetastasesDX, P001T3_n71BR_Diagnosis_MetastasesDX,
               P001T3_A503BR_Diagnosis_InitialDX_Code, P001T3_n503BR_Diagnosis_InitialDX_Code, P001T3_A70BR_Diagnosis_InitialDX, P001T3_n70BR_Diagnosis_InitialDX, P001T3_A69BR_Diagnosis_DXDescription, P001T3_n69BR_Diagnosis_DXDescription, P001T3_A467BR_Diagnosis_DXTsource_Code, P001T3_n467BR_Diagnosis_DXTsource_Code, P001T3_A68BR_Diagnosis_DXTsource, P001T3_n68BR_Diagnosis_DXTsource,
               P001T3_A466BR_Diagnosis_DXType_Code, P001T3_n466BR_Diagnosis_DXType_Code, P001T3_A67BR_Diagnosis_DXType, P001T3_n67BR_Diagnosis_DXType, P001T3_A66BR_Diagnosis_DXCode, P001T3_n66BR_Diagnosis_DXCode, P001T3_A513BR_Diagnosis_No, P001T3_n513BR_Diagnosis_No, P001T3_A36BR_Information_PatientNo, P001T3_n36BR_Information_PatientNo,
               P001T3_A19BR_EncounterID, P001T3_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T4_A85BR_Information_ID, P001T4_n85BR_Information_ID, P001T4_A66BR_Diagnosis_DXCode, P001T4_n66BR_Diagnosis_DXCode, P001T4_A260BR_Diagnosis_DXSource, P001T4_n260BR_Diagnosis_DXSource, P001T4_A504BR_Diagnosis_MetastasesDX_Code, P001T4_n504BR_Diagnosis_MetastasesDX_Code, P001T4_A71BR_Diagnosis_MetastasesDX, P001T4_n71BR_Diagnosis_MetastasesDX,
               P001T4_A503BR_Diagnosis_InitialDX_Code, P001T4_n503BR_Diagnosis_InitialDX_Code, P001T4_A70BR_Diagnosis_InitialDX, P001T4_n70BR_Diagnosis_InitialDX, P001T4_A69BR_Diagnosis_DXDescription, P001T4_n69BR_Diagnosis_DXDescription, P001T4_A467BR_Diagnosis_DXTsource_Code, P001T4_n467BR_Diagnosis_DXTsource_Code, P001T4_A68BR_Diagnosis_DXTsource, P001T4_n68BR_Diagnosis_DXTsource,
               P001T4_A466BR_Diagnosis_DXType_Code, P001T4_n466BR_Diagnosis_DXType_Code, P001T4_A67BR_Diagnosis_DXType, P001T4_n67BR_Diagnosis_DXType, P001T4_A65BR_Diagnosis_DXID, P001T4_n65BR_Diagnosis_DXID, P001T4_A513BR_Diagnosis_No, P001T4_n513BR_Diagnosis_No, P001T4_A36BR_Information_PatientNo, P001T4_n36BR_Information_PatientNo,
               P001T4_A19BR_EncounterID, P001T4_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T5_A85BR_Information_ID, P001T5_n85BR_Information_ID, P001T5_A67BR_Diagnosis_DXType, P001T5_n67BR_Diagnosis_DXType, P001T5_A260BR_Diagnosis_DXSource, P001T5_n260BR_Diagnosis_DXSource, P001T5_A504BR_Diagnosis_MetastasesDX_Code, P001T5_n504BR_Diagnosis_MetastasesDX_Code, P001T5_A71BR_Diagnosis_MetastasesDX, P001T5_n71BR_Diagnosis_MetastasesDX,
               P001T5_A503BR_Diagnosis_InitialDX_Code, P001T5_n503BR_Diagnosis_InitialDX_Code, P001T5_A70BR_Diagnosis_InitialDX, P001T5_n70BR_Diagnosis_InitialDX, P001T5_A69BR_Diagnosis_DXDescription, P001T5_n69BR_Diagnosis_DXDescription, P001T5_A467BR_Diagnosis_DXTsource_Code, P001T5_n467BR_Diagnosis_DXTsource_Code, P001T5_A68BR_Diagnosis_DXTsource, P001T5_n68BR_Diagnosis_DXTsource,
               P001T5_A466BR_Diagnosis_DXType_Code, P001T5_n466BR_Diagnosis_DXType_Code, P001T5_A66BR_Diagnosis_DXCode, P001T5_n66BR_Diagnosis_DXCode, P001T5_A65BR_Diagnosis_DXID, P001T5_n65BR_Diagnosis_DXID, P001T5_A513BR_Diagnosis_No, P001T5_n513BR_Diagnosis_No, P001T5_A36BR_Information_PatientNo, P001T5_n36BR_Information_PatientNo,
               P001T5_A19BR_EncounterID, P001T5_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T6_A85BR_Information_ID, P001T6_n85BR_Information_ID, P001T6_A466BR_Diagnosis_DXType_Code, P001T6_n466BR_Diagnosis_DXType_Code, P001T6_A260BR_Diagnosis_DXSource, P001T6_n260BR_Diagnosis_DXSource, P001T6_A504BR_Diagnosis_MetastasesDX_Code, P001T6_n504BR_Diagnosis_MetastasesDX_Code, P001T6_A71BR_Diagnosis_MetastasesDX, P001T6_n71BR_Diagnosis_MetastasesDX,
               P001T6_A503BR_Diagnosis_InitialDX_Code, P001T6_n503BR_Diagnosis_InitialDX_Code, P001T6_A70BR_Diagnosis_InitialDX, P001T6_n70BR_Diagnosis_InitialDX, P001T6_A69BR_Diagnosis_DXDescription, P001T6_n69BR_Diagnosis_DXDescription, P001T6_A467BR_Diagnosis_DXTsource_Code, P001T6_n467BR_Diagnosis_DXTsource_Code, P001T6_A68BR_Diagnosis_DXTsource, P001T6_n68BR_Diagnosis_DXTsource,
               P001T6_A67BR_Diagnosis_DXType, P001T6_n67BR_Diagnosis_DXType, P001T6_A66BR_Diagnosis_DXCode, P001T6_n66BR_Diagnosis_DXCode, P001T6_A65BR_Diagnosis_DXID, P001T6_n65BR_Diagnosis_DXID, P001T6_A513BR_Diagnosis_No, P001T6_n513BR_Diagnosis_No, P001T6_A36BR_Information_PatientNo, P001T6_n36BR_Information_PatientNo,
               P001T6_A19BR_EncounterID, P001T6_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T7_A85BR_Information_ID, P001T7_n85BR_Information_ID, P001T7_A68BR_Diagnosis_DXTsource, P001T7_n68BR_Diagnosis_DXTsource, P001T7_A260BR_Diagnosis_DXSource, P001T7_n260BR_Diagnosis_DXSource, P001T7_A504BR_Diagnosis_MetastasesDX_Code, P001T7_n504BR_Diagnosis_MetastasesDX_Code, P001T7_A71BR_Diagnosis_MetastasesDX, P001T7_n71BR_Diagnosis_MetastasesDX,
               P001T7_A503BR_Diagnosis_InitialDX_Code, P001T7_n503BR_Diagnosis_InitialDX_Code, P001T7_A70BR_Diagnosis_InitialDX, P001T7_n70BR_Diagnosis_InitialDX, P001T7_A69BR_Diagnosis_DXDescription, P001T7_n69BR_Diagnosis_DXDescription, P001T7_A467BR_Diagnosis_DXTsource_Code, P001T7_n467BR_Diagnosis_DXTsource_Code, P001T7_A466BR_Diagnosis_DXType_Code, P001T7_n466BR_Diagnosis_DXType_Code,
               P001T7_A67BR_Diagnosis_DXType, P001T7_n67BR_Diagnosis_DXType, P001T7_A66BR_Diagnosis_DXCode, P001T7_n66BR_Diagnosis_DXCode, P001T7_A65BR_Diagnosis_DXID, P001T7_n65BR_Diagnosis_DXID, P001T7_A513BR_Diagnosis_No, P001T7_n513BR_Diagnosis_No, P001T7_A36BR_Information_PatientNo, P001T7_n36BR_Information_PatientNo,
               P001T7_A19BR_EncounterID, P001T7_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T8_A85BR_Information_ID, P001T8_n85BR_Information_ID, P001T8_A467BR_Diagnosis_DXTsource_Code, P001T8_n467BR_Diagnosis_DXTsource_Code, P001T8_A260BR_Diagnosis_DXSource, P001T8_n260BR_Diagnosis_DXSource, P001T8_A504BR_Diagnosis_MetastasesDX_Code, P001T8_n504BR_Diagnosis_MetastasesDX_Code, P001T8_A71BR_Diagnosis_MetastasesDX, P001T8_n71BR_Diagnosis_MetastasesDX,
               P001T8_A503BR_Diagnosis_InitialDX_Code, P001T8_n503BR_Diagnosis_InitialDX_Code, P001T8_A70BR_Diagnosis_InitialDX, P001T8_n70BR_Diagnosis_InitialDX, P001T8_A69BR_Diagnosis_DXDescription, P001T8_n69BR_Diagnosis_DXDescription, P001T8_A68BR_Diagnosis_DXTsource, P001T8_n68BR_Diagnosis_DXTsource, P001T8_A466BR_Diagnosis_DXType_Code, P001T8_n466BR_Diagnosis_DXType_Code,
               P001T8_A67BR_Diagnosis_DXType, P001T8_n67BR_Diagnosis_DXType, P001T8_A66BR_Diagnosis_DXCode, P001T8_n66BR_Diagnosis_DXCode, P001T8_A65BR_Diagnosis_DXID, P001T8_n65BR_Diagnosis_DXID, P001T8_A513BR_Diagnosis_No, P001T8_n513BR_Diagnosis_No, P001T8_A36BR_Information_PatientNo, P001T8_n36BR_Information_PatientNo,
               P001T8_A19BR_EncounterID, P001T8_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T9_A85BR_Information_ID, P001T9_n85BR_Information_ID, P001T9_A69BR_Diagnosis_DXDescription, P001T9_n69BR_Diagnosis_DXDescription, P001T9_A260BR_Diagnosis_DXSource, P001T9_n260BR_Diagnosis_DXSource, P001T9_A504BR_Diagnosis_MetastasesDX_Code, P001T9_n504BR_Diagnosis_MetastasesDX_Code, P001T9_A71BR_Diagnosis_MetastasesDX, P001T9_n71BR_Diagnosis_MetastasesDX,
               P001T9_A503BR_Diagnosis_InitialDX_Code, P001T9_n503BR_Diagnosis_InitialDX_Code, P001T9_A70BR_Diagnosis_InitialDX, P001T9_n70BR_Diagnosis_InitialDX, P001T9_A467BR_Diagnosis_DXTsource_Code, P001T9_n467BR_Diagnosis_DXTsource_Code, P001T9_A68BR_Diagnosis_DXTsource, P001T9_n68BR_Diagnosis_DXTsource, P001T9_A466BR_Diagnosis_DXType_Code, P001T9_n466BR_Diagnosis_DXType_Code,
               P001T9_A67BR_Diagnosis_DXType, P001T9_n67BR_Diagnosis_DXType, P001T9_A66BR_Diagnosis_DXCode, P001T9_n66BR_Diagnosis_DXCode, P001T9_A65BR_Diagnosis_DXID, P001T9_n65BR_Diagnosis_DXID, P001T9_A513BR_Diagnosis_No, P001T9_n513BR_Diagnosis_No, P001T9_A36BR_Information_PatientNo, P001T9_n36BR_Information_PatientNo,
               P001T9_A19BR_EncounterID, P001T9_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T10_A85BR_Information_ID, P001T10_n85BR_Information_ID, P001T10_A503BR_Diagnosis_InitialDX_Code, P001T10_n503BR_Diagnosis_InitialDX_Code, P001T10_A260BR_Diagnosis_DXSource, P001T10_n260BR_Diagnosis_DXSource, P001T10_A504BR_Diagnosis_MetastasesDX_Code, P001T10_n504BR_Diagnosis_MetastasesDX_Code, P001T10_A71BR_Diagnosis_MetastasesDX, P001T10_n71BR_Diagnosis_MetastasesDX,
               P001T10_A70BR_Diagnosis_InitialDX, P001T10_n70BR_Diagnosis_InitialDX, P001T10_A69BR_Diagnosis_DXDescription, P001T10_n69BR_Diagnosis_DXDescription, P001T10_A467BR_Diagnosis_DXTsource_Code, P001T10_n467BR_Diagnosis_DXTsource_Code, P001T10_A68BR_Diagnosis_DXTsource, P001T10_n68BR_Diagnosis_DXTsource, P001T10_A466BR_Diagnosis_DXType_Code, P001T10_n466BR_Diagnosis_DXType_Code,
               P001T10_A67BR_Diagnosis_DXType, P001T10_n67BR_Diagnosis_DXType, P001T10_A66BR_Diagnosis_DXCode, P001T10_n66BR_Diagnosis_DXCode, P001T10_A65BR_Diagnosis_DXID, P001T10_n65BR_Diagnosis_DXID, P001T10_A513BR_Diagnosis_No, P001T10_n513BR_Diagnosis_No, P001T10_A36BR_Information_PatientNo, P001T10_n36BR_Information_PatientNo,
               P001T10_A19BR_EncounterID, P001T10_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T11_A85BR_Information_ID, P001T11_n85BR_Information_ID, P001T11_A504BR_Diagnosis_MetastasesDX_Code, P001T11_n504BR_Diagnosis_MetastasesDX_Code, P001T11_A260BR_Diagnosis_DXSource, P001T11_n260BR_Diagnosis_DXSource, P001T11_A71BR_Diagnosis_MetastasesDX, P001T11_n71BR_Diagnosis_MetastasesDX, P001T11_A503BR_Diagnosis_InitialDX_Code, P001T11_n503BR_Diagnosis_InitialDX_Code,
               P001T11_A70BR_Diagnosis_InitialDX, P001T11_n70BR_Diagnosis_InitialDX, P001T11_A69BR_Diagnosis_DXDescription, P001T11_n69BR_Diagnosis_DXDescription, P001T11_A467BR_Diagnosis_DXTsource_Code, P001T11_n467BR_Diagnosis_DXTsource_Code, P001T11_A68BR_Diagnosis_DXTsource, P001T11_n68BR_Diagnosis_DXTsource, P001T11_A466BR_Diagnosis_DXType_Code, P001T11_n466BR_Diagnosis_DXType_Code,
               P001T11_A67BR_Diagnosis_DXType, P001T11_n67BR_Diagnosis_DXType, P001T11_A66BR_Diagnosis_DXCode, P001T11_n66BR_Diagnosis_DXCode, P001T11_A65BR_Diagnosis_DXID, P001T11_n65BR_Diagnosis_DXID, P001T11_A513BR_Diagnosis_No, P001T11_n513BR_Diagnosis_No, P001T11_A36BR_Information_PatientNo, P001T11_n36BR_Information_PatientNo,
               P001T11_A19BR_EncounterID, P001T11_A64BR_DiagnosisID
               }
               , new Object[] {
               P001T12_A85BR_Information_ID, P001T12_n85BR_Information_ID, P001T12_A260BR_Diagnosis_DXSource, P001T12_n260BR_Diagnosis_DXSource, P001T12_A504BR_Diagnosis_MetastasesDX_Code, P001T12_n504BR_Diagnosis_MetastasesDX_Code, P001T12_A71BR_Diagnosis_MetastasesDX, P001T12_n71BR_Diagnosis_MetastasesDX, P001T12_A503BR_Diagnosis_InitialDX_Code, P001T12_n503BR_Diagnosis_InitialDX_Code,
               P001T12_A70BR_Diagnosis_InitialDX, P001T12_n70BR_Diagnosis_InitialDX, P001T12_A69BR_Diagnosis_DXDescription, P001T12_n69BR_Diagnosis_DXDescription, P001T12_A467BR_Diagnosis_DXTsource_Code, P001T12_n467BR_Diagnosis_DXTsource_Code, P001T12_A68BR_Diagnosis_DXTsource, P001T12_n68BR_Diagnosis_DXTsource, P001T12_A466BR_Diagnosis_DXType_Code, P001T12_n466BR_Diagnosis_DXType_Code,
               P001T12_A67BR_Diagnosis_DXType, P001T12_n67BR_Diagnosis_DXType, P001T12_A66BR_Diagnosis_DXCode, P001T12_n66BR_Diagnosis_DXCode, P001T12_A65BR_Diagnosis_DXID, P001T12_n65BR_Diagnosis_DXID, P001T12_A513BR_Diagnosis_No, P001T12_n513BR_Diagnosis_No, P001T12_A36BR_Information_PatientNo, P001T12_n36BR_Information_PatientNo,
               P001T12_A19BR_EncounterID, P001T12_A64BR_DiagnosisID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV65GXV1 ;
      private int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ;
      private int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ;
      private long AV11TFBR_DiagnosisID ;
      private long AV12TFBR_DiagnosisID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV53TFBR_Diagnosis_No ;
      private long AV54TFBR_Diagnosis_No_To ;
      private long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ;
      private long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ;
      private long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ;
      private long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ;
      private long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ;
      private long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ;
      private long A64BR_DiagnosisID ;
      private long A19BR_EncounterID ;
      private long A513BR_Diagnosis_No ;
      private long A85BR_Information_ID ;
      private long AV43count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK1T2 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n260BR_Diagnosis_DXSource ;
      private bool n504BR_Diagnosis_MetastasesDX_Code ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool n503BR_Diagnosis_InitialDX_Code ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n467BR_Diagnosis_DXTsource_Code ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n466BR_Diagnosis_DXType_Code ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n513BR_Diagnosis_No ;
      private bool BRK1T4 ;
      private bool BRK1T6 ;
      private bool BRK1T8 ;
      private bool BRK1T10 ;
      private bool BRK1T12 ;
      private bool BRK1T14 ;
      private bool BRK1T16 ;
      private bool BRK1T18 ;
      private bool BRK1T20 ;
      private bool BRK1T22 ;
      private String AV42OptionIndexesJson ;
      private String AV37OptionsJson ;
      private String AV40OptionsDescJson ;
      private String AV27TFBR_Diagnosis_InitialDX_SelsJson ;
      private String AV29TFBR_Diagnosis_MetastasesDX_SelsJson ;
      private String AV33DDOName ;
      private String AV31SearchTxt ;
      private String AV32SearchTxtTo ;
      private String AV15TFBR_Information_PatientNo ;
      private String AV16TFBR_Information_PatientNo_Sel ;
      private String AV17TFBR_Diagnosis_DXID ;
      private String AV18TFBR_Diagnosis_DXID_Sel ;
      private String AV19TFBR_Diagnosis_DXCode ;
      private String AV20TFBR_Diagnosis_DXCode_Sel ;
      private String AV21TFBR_Diagnosis_DXType ;
      private String AV49TFBR_Diagnosis_DXType_Sel ;
      private String AV55TFBR_Diagnosis_DXType_Code ;
      private String AV56TFBR_Diagnosis_DXType_Code_Sel ;
      private String AV23TFBR_Diagnosis_DXTsource ;
      private String AV50TFBR_Diagnosis_DXTsource_Sel ;
      private String AV57TFBR_Diagnosis_DXTsource_Code ;
      private String AV58TFBR_Diagnosis_DXTsource_Code_Sel ;
      private String AV25TFBR_Diagnosis_DXDescription ;
      private String AV26TFBR_Diagnosis_DXDescription_Sel ;
      private String AV59TFBR_Diagnosis_InitialDX_Code ;
      private String AV60TFBR_Diagnosis_InitialDX_Code_Sel ;
      private String AV61TFBR_Diagnosis_MetastasesDX_Code ;
      private String AV62TFBR_Diagnosis_MetastasesDX_Code_Sel ;
      private String AV51TFBR_Diagnosis_DXSource ;
      private String AV52TFBR_Diagnosis_DXSource_Sel ;
      private String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ;
      private String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ;
      private String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ;
      private String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ;
      private String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ;
      private String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ;
      private String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ;
      private String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ;
      private String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ;
      private String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ;
      private String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ;
      private String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ;
      private String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ;
      private String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ;
      private String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ;
      private String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ;
      private String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ;
      private String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ;
      private String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ;
      private String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ;
      private String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ;
      private String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ;
      private String lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ;
      private String lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ;
      private String lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ;
      private String lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ;
      private String lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ;
      private String lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ;
      private String lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ;
      private String lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ;
      private String lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ;
      private String lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ;
      private String lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ;
      private String A70BR_Diagnosis_InitialDX ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String A36BR_Information_PatientNo ;
      private String A65BR_Diagnosis_DXID ;
      private String A66BR_Diagnosis_DXCode ;
      private String A67BR_Diagnosis_DXType ;
      private String A466BR_Diagnosis_DXType_Code ;
      private String A68BR_Diagnosis_DXTsource ;
      private String A467BR_Diagnosis_DXTsource_Code ;
      private String A69BR_Diagnosis_DXDescription ;
      private String A503BR_Diagnosis_InitialDX_Code ;
      private String A504BR_Diagnosis_MetastasesDX_Code ;
      private String A260BR_Diagnosis_DXSource ;
      private String AV35Option ;
      private IGxSession AV44Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001T2_A85BR_Information_ID ;
      private bool[] P001T2_n85BR_Information_ID ;
      private String[] P001T2_A36BR_Information_PatientNo ;
      private bool[] P001T2_n36BR_Information_PatientNo ;
      private String[] P001T2_A260BR_Diagnosis_DXSource ;
      private bool[] P001T2_n260BR_Diagnosis_DXSource ;
      private String[] P001T2_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T2_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T2_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T2_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T2_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T2_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T2_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T2_n70BR_Diagnosis_InitialDX ;
      private String[] P001T2_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T2_n69BR_Diagnosis_DXDescription ;
      private String[] P001T2_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T2_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T2_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T2_n68BR_Diagnosis_DXTsource ;
      private String[] P001T2_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T2_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T2_A67BR_Diagnosis_DXType ;
      private bool[] P001T2_n67BR_Diagnosis_DXType ;
      private String[] P001T2_A66BR_Diagnosis_DXCode ;
      private bool[] P001T2_n66BR_Diagnosis_DXCode ;
      private String[] P001T2_A65BR_Diagnosis_DXID ;
      private bool[] P001T2_n65BR_Diagnosis_DXID ;
      private long[] P001T2_A513BR_Diagnosis_No ;
      private bool[] P001T2_n513BR_Diagnosis_No ;
      private long[] P001T2_A19BR_EncounterID ;
      private long[] P001T2_A64BR_DiagnosisID ;
      private long[] P001T3_A85BR_Information_ID ;
      private bool[] P001T3_n85BR_Information_ID ;
      private String[] P001T3_A65BR_Diagnosis_DXID ;
      private bool[] P001T3_n65BR_Diagnosis_DXID ;
      private String[] P001T3_A260BR_Diagnosis_DXSource ;
      private bool[] P001T3_n260BR_Diagnosis_DXSource ;
      private String[] P001T3_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T3_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T3_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T3_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T3_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T3_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T3_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T3_n70BR_Diagnosis_InitialDX ;
      private String[] P001T3_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T3_n69BR_Diagnosis_DXDescription ;
      private String[] P001T3_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T3_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T3_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T3_n68BR_Diagnosis_DXTsource ;
      private String[] P001T3_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T3_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T3_A67BR_Diagnosis_DXType ;
      private bool[] P001T3_n67BR_Diagnosis_DXType ;
      private String[] P001T3_A66BR_Diagnosis_DXCode ;
      private bool[] P001T3_n66BR_Diagnosis_DXCode ;
      private long[] P001T3_A513BR_Diagnosis_No ;
      private bool[] P001T3_n513BR_Diagnosis_No ;
      private String[] P001T3_A36BR_Information_PatientNo ;
      private bool[] P001T3_n36BR_Information_PatientNo ;
      private long[] P001T3_A19BR_EncounterID ;
      private long[] P001T3_A64BR_DiagnosisID ;
      private long[] P001T4_A85BR_Information_ID ;
      private bool[] P001T4_n85BR_Information_ID ;
      private String[] P001T4_A66BR_Diagnosis_DXCode ;
      private bool[] P001T4_n66BR_Diagnosis_DXCode ;
      private String[] P001T4_A260BR_Diagnosis_DXSource ;
      private bool[] P001T4_n260BR_Diagnosis_DXSource ;
      private String[] P001T4_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T4_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T4_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T4_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T4_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T4_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T4_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T4_n70BR_Diagnosis_InitialDX ;
      private String[] P001T4_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T4_n69BR_Diagnosis_DXDescription ;
      private String[] P001T4_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T4_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T4_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T4_n68BR_Diagnosis_DXTsource ;
      private String[] P001T4_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T4_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T4_A67BR_Diagnosis_DXType ;
      private bool[] P001T4_n67BR_Diagnosis_DXType ;
      private String[] P001T4_A65BR_Diagnosis_DXID ;
      private bool[] P001T4_n65BR_Diagnosis_DXID ;
      private long[] P001T4_A513BR_Diagnosis_No ;
      private bool[] P001T4_n513BR_Diagnosis_No ;
      private String[] P001T4_A36BR_Information_PatientNo ;
      private bool[] P001T4_n36BR_Information_PatientNo ;
      private long[] P001T4_A19BR_EncounterID ;
      private long[] P001T4_A64BR_DiagnosisID ;
      private long[] P001T5_A85BR_Information_ID ;
      private bool[] P001T5_n85BR_Information_ID ;
      private String[] P001T5_A67BR_Diagnosis_DXType ;
      private bool[] P001T5_n67BR_Diagnosis_DXType ;
      private String[] P001T5_A260BR_Diagnosis_DXSource ;
      private bool[] P001T5_n260BR_Diagnosis_DXSource ;
      private String[] P001T5_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T5_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T5_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T5_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T5_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T5_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T5_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T5_n70BR_Diagnosis_InitialDX ;
      private String[] P001T5_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T5_n69BR_Diagnosis_DXDescription ;
      private String[] P001T5_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T5_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T5_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T5_n68BR_Diagnosis_DXTsource ;
      private String[] P001T5_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T5_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T5_A66BR_Diagnosis_DXCode ;
      private bool[] P001T5_n66BR_Diagnosis_DXCode ;
      private String[] P001T5_A65BR_Diagnosis_DXID ;
      private bool[] P001T5_n65BR_Diagnosis_DXID ;
      private long[] P001T5_A513BR_Diagnosis_No ;
      private bool[] P001T5_n513BR_Diagnosis_No ;
      private String[] P001T5_A36BR_Information_PatientNo ;
      private bool[] P001T5_n36BR_Information_PatientNo ;
      private long[] P001T5_A19BR_EncounterID ;
      private long[] P001T5_A64BR_DiagnosisID ;
      private long[] P001T6_A85BR_Information_ID ;
      private bool[] P001T6_n85BR_Information_ID ;
      private String[] P001T6_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T6_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T6_A260BR_Diagnosis_DXSource ;
      private bool[] P001T6_n260BR_Diagnosis_DXSource ;
      private String[] P001T6_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T6_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T6_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T6_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T6_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T6_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T6_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T6_n70BR_Diagnosis_InitialDX ;
      private String[] P001T6_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T6_n69BR_Diagnosis_DXDescription ;
      private String[] P001T6_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T6_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T6_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T6_n68BR_Diagnosis_DXTsource ;
      private String[] P001T6_A67BR_Diagnosis_DXType ;
      private bool[] P001T6_n67BR_Diagnosis_DXType ;
      private String[] P001T6_A66BR_Diagnosis_DXCode ;
      private bool[] P001T6_n66BR_Diagnosis_DXCode ;
      private String[] P001T6_A65BR_Diagnosis_DXID ;
      private bool[] P001T6_n65BR_Diagnosis_DXID ;
      private long[] P001T6_A513BR_Diagnosis_No ;
      private bool[] P001T6_n513BR_Diagnosis_No ;
      private String[] P001T6_A36BR_Information_PatientNo ;
      private bool[] P001T6_n36BR_Information_PatientNo ;
      private long[] P001T6_A19BR_EncounterID ;
      private long[] P001T6_A64BR_DiagnosisID ;
      private long[] P001T7_A85BR_Information_ID ;
      private bool[] P001T7_n85BR_Information_ID ;
      private String[] P001T7_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T7_n68BR_Diagnosis_DXTsource ;
      private String[] P001T7_A260BR_Diagnosis_DXSource ;
      private bool[] P001T7_n260BR_Diagnosis_DXSource ;
      private String[] P001T7_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T7_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T7_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T7_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T7_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T7_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T7_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T7_n70BR_Diagnosis_InitialDX ;
      private String[] P001T7_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T7_n69BR_Diagnosis_DXDescription ;
      private String[] P001T7_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T7_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T7_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T7_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T7_A67BR_Diagnosis_DXType ;
      private bool[] P001T7_n67BR_Diagnosis_DXType ;
      private String[] P001T7_A66BR_Diagnosis_DXCode ;
      private bool[] P001T7_n66BR_Diagnosis_DXCode ;
      private String[] P001T7_A65BR_Diagnosis_DXID ;
      private bool[] P001T7_n65BR_Diagnosis_DXID ;
      private long[] P001T7_A513BR_Diagnosis_No ;
      private bool[] P001T7_n513BR_Diagnosis_No ;
      private String[] P001T7_A36BR_Information_PatientNo ;
      private bool[] P001T7_n36BR_Information_PatientNo ;
      private long[] P001T7_A19BR_EncounterID ;
      private long[] P001T7_A64BR_DiagnosisID ;
      private long[] P001T8_A85BR_Information_ID ;
      private bool[] P001T8_n85BR_Information_ID ;
      private String[] P001T8_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T8_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T8_A260BR_Diagnosis_DXSource ;
      private bool[] P001T8_n260BR_Diagnosis_DXSource ;
      private String[] P001T8_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T8_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T8_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T8_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T8_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T8_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T8_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T8_n70BR_Diagnosis_InitialDX ;
      private String[] P001T8_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T8_n69BR_Diagnosis_DXDescription ;
      private String[] P001T8_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T8_n68BR_Diagnosis_DXTsource ;
      private String[] P001T8_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T8_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T8_A67BR_Diagnosis_DXType ;
      private bool[] P001T8_n67BR_Diagnosis_DXType ;
      private String[] P001T8_A66BR_Diagnosis_DXCode ;
      private bool[] P001T8_n66BR_Diagnosis_DXCode ;
      private String[] P001T8_A65BR_Diagnosis_DXID ;
      private bool[] P001T8_n65BR_Diagnosis_DXID ;
      private long[] P001T8_A513BR_Diagnosis_No ;
      private bool[] P001T8_n513BR_Diagnosis_No ;
      private String[] P001T8_A36BR_Information_PatientNo ;
      private bool[] P001T8_n36BR_Information_PatientNo ;
      private long[] P001T8_A19BR_EncounterID ;
      private long[] P001T8_A64BR_DiagnosisID ;
      private long[] P001T9_A85BR_Information_ID ;
      private bool[] P001T9_n85BR_Information_ID ;
      private String[] P001T9_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T9_n69BR_Diagnosis_DXDescription ;
      private String[] P001T9_A260BR_Diagnosis_DXSource ;
      private bool[] P001T9_n260BR_Diagnosis_DXSource ;
      private String[] P001T9_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T9_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T9_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T9_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T9_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T9_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T9_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T9_n70BR_Diagnosis_InitialDX ;
      private String[] P001T9_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T9_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T9_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T9_n68BR_Diagnosis_DXTsource ;
      private String[] P001T9_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T9_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T9_A67BR_Diagnosis_DXType ;
      private bool[] P001T9_n67BR_Diagnosis_DXType ;
      private String[] P001T9_A66BR_Diagnosis_DXCode ;
      private bool[] P001T9_n66BR_Diagnosis_DXCode ;
      private String[] P001T9_A65BR_Diagnosis_DXID ;
      private bool[] P001T9_n65BR_Diagnosis_DXID ;
      private long[] P001T9_A513BR_Diagnosis_No ;
      private bool[] P001T9_n513BR_Diagnosis_No ;
      private String[] P001T9_A36BR_Information_PatientNo ;
      private bool[] P001T9_n36BR_Information_PatientNo ;
      private long[] P001T9_A19BR_EncounterID ;
      private long[] P001T9_A64BR_DiagnosisID ;
      private long[] P001T10_A85BR_Information_ID ;
      private bool[] P001T10_n85BR_Information_ID ;
      private String[] P001T10_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T10_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T10_A260BR_Diagnosis_DXSource ;
      private bool[] P001T10_n260BR_Diagnosis_DXSource ;
      private String[] P001T10_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T10_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T10_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T10_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T10_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T10_n70BR_Diagnosis_InitialDX ;
      private String[] P001T10_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T10_n69BR_Diagnosis_DXDescription ;
      private String[] P001T10_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T10_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T10_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T10_n68BR_Diagnosis_DXTsource ;
      private String[] P001T10_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T10_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T10_A67BR_Diagnosis_DXType ;
      private bool[] P001T10_n67BR_Diagnosis_DXType ;
      private String[] P001T10_A66BR_Diagnosis_DXCode ;
      private bool[] P001T10_n66BR_Diagnosis_DXCode ;
      private String[] P001T10_A65BR_Diagnosis_DXID ;
      private bool[] P001T10_n65BR_Diagnosis_DXID ;
      private long[] P001T10_A513BR_Diagnosis_No ;
      private bool[] P001T10_n513BR_Diagnosis_No ;
      private String[] P001T10_A36BR_Information_PatientNo ;
      private bool[] P001T10_n36BR_Information_PatientNo ;
      private long[] P001T10_A19BR_EncounterID ;
      private long[] P001T10_A64BR_DiagnosisID ;
      private long[] P001T11_A85BR_Information_ID ;
      private bool[] P001T11_n85BR_Information_ID ;
      private String[] P001T11_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T11_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T11_A260BR_Diagnosis_DXSource ;
      private bool[] P001T11_n260BR_Diagnosis_DXSource ;
      private String[] P001T11_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T11_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T11_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T11_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T11_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T11_n70BR_Diagnosis_InitialDX ;
      private String[] P001T11_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T11_n69BR_Diagnosis_DXDescription ;
      private String[] P001T11_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T11_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T11_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T11_n68BR_Diagnosis_DXTsource ;
      private String[] P001T11_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T11_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T11_A67BR_Diagnosis_DXType ;
      private bool[] P001T11_n67BR_Diagnosis_DXType ;
      private String[] P001T11_A66BR_Diagnosis_DXCode ;
      private bool[] P001T11_n66BR_Diagnosis_DXCode ;
      private String[] P001T11_A65BR_Diagnosis_DXID ;
      private bool[] P001T11_n65BR_Diagnosis_DXID ;
      private long[] P001T11_A513BR_Diagnosis_No ;
      private bool[] P001T11_n513BR_Diagnosis_No ;
      private String[] P001T11_A36BR_Information_PatientNo ;
      private bool[] P001T11_n36BR_Information_PatientNo ;
      private long[] P001T11_A19BR_EncounterID ;
      private long[] P001T11_A64BR_DiagnosisID ;
      private long[] P001T12_A85BR_Information_ID ;
      private bool[] P001T12_n85BR_Information_ID ;
      private String[] P001T12_A260BR_Diagnosis_DXSource ;
      private bool[] P001T12_n260BR_Diagnosis_DXSource ;
      private String[] P001T12_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] P001T12_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] P001T12_A71BR_Diagnosis_MetastasesDX ;
      private bool[] P001T12_n71BR_Diagnosis_MetastasesDX ;
      private String[] P001T12_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] P001T12_n503BR_Diagnosis_InitialDX_Code ;
      private String[] P001T12_A70BR_Diagnosis_InitialDX ;
      private bool[] P001T12_n70BR_Diagnosis_InitialDX ;
      private String[] P001T12_A69BR_Diagnosis_DXDescription ;
      private bool[] P001T12_n69BR_Diagnosis_DXDescription ;
      private String[] P001T12_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] P001T12_n467BR_Diagnosis_DXTsource_Code ;
      private String[] P001T12_A68BR_Diagnosis_DXTsource ;
      private bool[] P001T12_n68BR_Diagnosis_DXTsource ;
      private String[] P001T12_A466BR_Diagnosis_DXType_Code ;
      private bool[] P001T12_n466BR_Diagnosis_DXType_Code ;
      private String[] P001T12_A67BR_Diagnosis_DXType ;
      private bool[] P001T12_n67BR_Diagnosis_DXType ;
      private String[] P001T12_A66BR_Diagnosis_DXCode ;
      private bool[] P001T12_n66BR_Diagnosis_DXCode ;
      private String[] P001T12_A65BR_Diagnosis_DXID ;
      private bool[] P001T12_n65BR_Diagnosis_DXID ;
      private long[] P001T12_A513BR_Diagnosis_No ;
      private bool[] P001T12_n513BR_Diagnosis_No ;
      private String[] P001T12_A36BR_Information_PatientNo ;
      private bool[] P001T12_n36BR_Information_PatientNo ;
      private long[] P001T12_A19BR_EncounterID ;
      private long[] P001T12_A64BR_DiagnosisID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV36Options ;
      private GxSimpleCollection<String> AV39OptionsDesc ;
      private GxSimpleCollection<String> AV41OptionIndexes ;
      private GxSimpleCollection<String> AV28TFBR_Diagnosis_InitialDX_Sels ;
      private GxSimpleCollection<String> AV30TFBR_Diagnosis_MetastasesDX_Sels ;
      private GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ;
      private GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV46GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV47GridStateFilterValue ;
   }

   public class br_diagnosiswwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001T2( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [28] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T3.[BR_Information_PatientNo], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int2[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int2[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int2[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int2[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int2[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int2[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int2[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int2[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int2[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int2[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int2[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int2[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T3.[BR_Information_PatientNo]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P001T3( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [28] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int4[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int4[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int4[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int4[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int4[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int4[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int4[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int4[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int4[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int4[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int4[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int4[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int4[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXID]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P001T4( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [28] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int6[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int6[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int6[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int6[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int6[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int6[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int6[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int6[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int6[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int6[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int6[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int6[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int6[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int6[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXCode]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P001T5( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [28] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int8[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int8[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int8[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int8[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int8[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int8[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int8[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int8[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int8[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int8[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int8[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int8[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int8[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int8[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int8[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int8[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXType]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      protected Object[] conditional_P001T6( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [28] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int10[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int10[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int10[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int10[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int10[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int10[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int10[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int10[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int10[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int10[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int10[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int10[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int10[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int10[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int10[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int10[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int10[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int10[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int10[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int10[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int10[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int10[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int10[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int10[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int10[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int10[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int10[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int10[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXType_Code]";
         GXv_Object11[0] = scmdbuf;
         GXv_Object11[1] = GXv_int10;
         return GXv_Object11 ;
      }

      protected Object[] conditional_P001T7( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int12 ;
         GXv_int12 = new short [28] ;
         Object[] GXv_Object13 ;
         GXv_Object13 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int12[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int12[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int12[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int12[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int12[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int12[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int12[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int12[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int12[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int12[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int12[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int12[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int12[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int12[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int12[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int12[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int12[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int12[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int12[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int12[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int12[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int12[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int12[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int12[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int12[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int12[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int12[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int12[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXTsource]";
         GXv_Object13[0] = scmdbuf;
         GXv_Object13[1] = GXv_int12;
         return GXv_Object13 ;
      }

      protected Object[] conditional_P001T8( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int14 ;
         GXv_int14 = new short [28] ;
         Object[] GXv_Object15 ;
         GXv_Object15 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int14[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int14[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int14[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int14[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int14[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int14[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int14[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int14[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int14[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int14[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int14[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int14[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int14[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int14[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int14[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int14[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int14[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int14[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int14[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int14[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int14[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int14[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int14[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int14[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int14[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int14[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int14[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int14[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXTsource_Code]";
         GXv_Object15[0] = scmdbuf;
         GXv_Object15[1] = GXv_int14;
         return GXv_Object15 ;
      }

      protected Object[] conditional_P001T9( IGxContext context ,
                                             String A70BR_Diagnosis_InitialDX ,
                                             GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                             String A71BR_Diagnosis_MetastasesDX ,
                                             GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                             long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                             long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                             long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                             long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                             String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                             long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                             long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                             String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                             String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                             String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                             String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                             String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                             String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                             String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                             String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                             String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                             String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                             String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                             String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                             String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                             String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                             int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                             String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                             String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                             int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                             String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                             String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                             String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                             String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                             long A64BR_DiagnosisID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A513BR_Diagnosis_No ,
                                             String A65BR_Diagnosis_DXID ,
                                             String A66BR_Diagnosis_DXCode ,
                                             String A67BR_Diagnosis_DXType ,
                                             String A466BR_Diagnosis_DXType_Code ,
                                             String A68BR_Diagnosis_DXTsource ,
                                             String A467BR_Diagnosis_DXTsource_Code ,
                                             String A69BR_Diagnosis_DXDescription ,
                                             String A503BR_Diagnosis_InitialDX_Code ,
                                             String A504BR_Diagnosis_MetastasesDX_Code ,
                                             String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int16 ;
         GXv_int16 = new short [28] ;
         Object[] GXv_Object17 ;
         GXv_Object17 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int16[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int16[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int16[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int16[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int16[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int16[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int16[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int16[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int16[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int16[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int16[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int16[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int16[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int16[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int16[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int16[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int16[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int16[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int16[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int16[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int16[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int16[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int16[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int16[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int16[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int16[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int16[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int16[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXDescription]";
         GXv_Object17[0] = scmdbuf;
         GXv_Object17[1] = GXv_int16;
         return GXv_Object17 ;
      }

      protected Object[] conditional_P001T10( IGxContext context ,
                                              String A70BR_Diagnosis_InitialDX ,
                                              GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              String A71BR_Diagnosis_MetastasesDX ,
                                              GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                              String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                              String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              long A64BR_DiagnosisID ,
                                              long A19BR_EncounterID ,
                                              String A36BR_Information_PatientNo ,
                                              long A513BR_Diagnosis_No ,
                                              String A65BR_Diagnosis_DXID ,
                                              String A66BR_Diagnosis_DXCode ,
                                              String A67BR_Diagnosis_DXType ,
                                              String A466BR_Diagnosis_DXType_Code ,
                                              String A68BR_Diagnosis_DXTsource ,
                                              String A467BR_Diagnosis_DXTsource_Code ,
                                              String A69BR_Diagnosis_DXDescription ,
                                              String A503BR_Diagnosis_InitialDX_Code ,
                                              String A504BR_Diagnosis_MetastasesDX_Code ,
                                              String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int18 ;
         GXv_int18 = new short [28] ;
         Object[] GXv_Object19 ;
         GXv_Object19 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int18[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int18[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int18[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int18[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int18[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int18[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int18[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int18[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int18[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int18[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int18[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int18[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int18[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int18[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int18[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int18[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int18[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int18[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int18[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int18[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int18[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int18[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int18[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int18[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int18[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int18[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int18[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int18[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_InitialDX_Code]";
         GXv_Object19[0] = scmdbuf;
         GXv_Object19[1] = GXv_int18;
         return GXv_Object19 ;
      }

      protected Object[] conditional_P001T11( IGxContext context ,
                                              String A70BR_Diagnosis_InitialDX ,
                                              GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              String A71BR_Diagnosis_MetastasesDX ,
                                              GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                              String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                              String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              long A64BR_DiagnosisID ,
                                              long A19BR_EncounterID ,
                                              String A36BR_Information_PatientNo ,
                                              long A513BR_Diagnosis_No ,
                                              String A65BR_Diagnosis_DXID ,
                                              String A66BR_Diagnosis_DXCode ,
                                              String A67BR_Diagnosis_DXType ,
                                              String A466BR_Diagnosis_DXType_Code ,
                                              String A68BR_Diagnosis_DXTsource ,
                                              String A467BR_Diagnosis_DXTsource_Code ,
                                              String A69BR_Diagnosis_DXDescription ,
                                              String A503BR_Diagnosis_InitialDX_Code ,
                                              String A504BR_Diagnosis_MetastasesDX_Code ,
                                              String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int20 ;
         GXv_int20 = new short [28] ;
         Object[] GXv_Object21 ;
         GXv_Object21 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int20[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int20[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int20[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int20[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int20[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int20[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int20[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int20[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int20[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int20[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int20[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int20[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int20[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int20[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int20[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int20[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int20[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int20[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int20[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int20[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int20[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int20[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int20[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int20[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int20[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int20[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int20[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int20[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_MetastasesDX_Code]";
         GXv_Object21[0] = scmdbuf;
         GXv_Object21[1] = GXv_int20;
         return GXv_Object21 ;
      }

      protected Object[] conditional_P001T12( IGxContext context ,
                                              String A70BR_Diagnosis_InitialDX ,
                                              GxSimpleCollection<String> AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels ,
                                              String A71BR_Diagnosis_MetastasesDX ,
                                              GxSimpleCollection<String> AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels ,
                                              long AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid ,
                                              long AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to ,
                                              long AV69BR_DiagnosisWWDS_3_Tfbr_encounterid ,
                                              long AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to ,
                                              String AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel ,
                                              String AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno ,
                                              long AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no ,
                                              long AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to ,
                                              String AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel ,
                                              String AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid ,
                                              String AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel ,
                                              String AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode ,
                                              String AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel ,
                                              String AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype ,
                                              String AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel ,
                                              String AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code ,
                                              String AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel ,
                                              String AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource ,
                                              String AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel ,
                                              String AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code ,
                                              String AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel ,
                                              String AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription ,
                                              int AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count ,
                                              String AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel ,
                                              String AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code ,
                                              int AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count ,
                                              String AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel ,
                                              String AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code ,
                                              String AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel ,
                                              String AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource ,
                                              long A64BR_DiagnosisID ,
                                              long A19BR_EncounterID ,
                                              String A36BR_Information_PatientNo ,
                                              long A513BR_Diagnosis_No ,
                                              String A65BR_Diagnosis_DXID ,
                                              String A66BR_Diagnosis_DXCode ,
                                              String A67BR_Diagnosis_DXType ,
                                              String A466BR_Diagnosis_DXType_Code ,
                                              String A68BR_Diagnosis_DXTsource ,
                                              String A467BR_Diagnosis_DXTsource_Code ,
                                              String A69BR_Diagnosis_DXDescription ,
                                              String A503BR_Diagnosis_InitialDX_Code ,
                                              String A504BR_Diagnosis_MetastasesDX_Code ,
                                              String A260BR_Diagnosis_DXSource )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int22 ;
         GXv_int22 = new short [28] ;
         Object[] GXv_Object23 ;
         GXv_Object23 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] >= @AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid)";
            }
         }
         else
         {
            GXv_int22[0] = 1;
         }
         if ( ! (0==AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_DiagnosisID] <= @AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to)";
            }
         }
         else
         {
            GXv_int22[1] = 1;
         }
         if ( ! (0==AV69BR_DiagnosisWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV69BR_DiagnosisWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int22[2] = 1;
         }
         if ( ! (0==AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int22[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int22[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int22[5] = 1;
         }
         if ( ! (0==AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] >= @AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no)";
            }
         }
         else
         {
            GXv_int22[6] = 1;
         }
         if ( ! (0==AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_No] <= @AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to)";
            }
         }
         else
         {
            GXv_int22[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] like @lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid)";
            }
         }
         else
         {
            GXv_int22[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXID] = @AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel)";
            }
         }
         else
         {
            GXv_int22[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] like @lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode)";
            }
         }
         else
         {
            GXv_int22[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXCode] = @AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel)";
            }
         }
         else
         {
            GXv_int22[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] like @lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype)";
            }
         }
         else
         {
            GXv_int22[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType] = @AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel)";
            }
         }
         else
         {
            GXv_int22[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] like @lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code)";
            }
         }
         else
         {
            GXv_int22[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXType_Code] = @AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel)";
            }
         }
         else
         {
            GXv_int22[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] like @lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource)";
            }
         }
         else
         {
            GXv_int22[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource] = @AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel)";
            }
         }
         else
         {
            GXv_int22[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] like @lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code)";
            }
         }
         else
         {
            GXv_int22[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXTsource_Code] = @AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel)";
            }
         }
         else
         {
            GXv_int22[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] like @lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription)";
            }
         }
         else
         {
            GXv_int22[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXDescription] = @AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel)";
            }
         }
         else
         {
            GXv_int22[21] = 1;
         }
         if ( AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV89BR_DiagnosisWWDS_23_Tfbr_diagnosis_initialdx_sels, "T1.[BR_Diagnosis_InitialDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] like @lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code)";
            }
         }
         else
         {
            GXv_int22[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_InitialDX_Code] = @AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel)";
            }
         }
         else
         {
            GXv_int22[23] = 1;
         }
         if ( AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_DiagnosisWWDS_26_Tfbr_diagnosis_metastasesdx_sels, "T1.[BR_Diagnosis_MetastasesDX] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] like @lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code)";
            }
         }
         else
         {
            GXv_int22[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_MetastasesDX_Code] = @AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel)";
            }
         }
         else
         {
            GXv_int22[25] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] like @lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource)";
            }
         }
         else
         {
            GXv_int22[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Diagnosis_DXSource] = @AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel)";
            }
         }
         else
         {
            GXv_int22[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Diagnosis_DXSource]";
         GXv_Object23[0] = scmdbuf;
         GXv_Object23[1] = GXv_int22;
         return GXv_Object23 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001T2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 1 :
                     return conditional_P001T3(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 2 :
                     return conditional_P001T4(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 3 :
                     return conditional_P001T5(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 4 :
                     return conditional_P001T6(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 5 :
                     return conditional_P001T7(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 6 :
                     return conditional_P001T8(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 7 :
                     return conditional_P001T9(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 8 :
                     return conditional_P001T10(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 9 :
                     return conditional_P001T11(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 10 :
                     return conditional_P001T12(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (String)dynConstraints[24] , (String)dynConstraints[25] , (int)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (int)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (String)dynConstraints[38] , (String)dynConstraints[39] , (String)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (String)dynConstraints[44] , (String)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
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
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001T2 ;
          prmP001T2 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T3 ;
          prmP001T3 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T4 ;
          prmP001T4 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T5 ;
          prmP001T5 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T6 ;
          prmP001T6 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T7 ;
          prmP001T7 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T8 ;
          prmP001T8 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T9 ;
          prmP001T9 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T10 ;
          prmP001T10 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T11 ;
          prmP001T11 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP001T12 ;
          prmP001T12 = new Object[] {
          new Object[] {"@AV67BR_DiagnosisWWDS_1_Tfbr_diagnosisid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_DiagnosisWWDS_2_Tfbr_diagnosisid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_DiagnosisWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_DiagnosisWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV71BR_DiagnosisWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV72BR_DiagnosisWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_DiagnosisWWDS_7_Tfbr_diagnosis_no",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV74BR_DiagnosisWWDS_8_Tfbr_diagnosis_no_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV75BR_DiagnosisWWDS_9_Tfbr_diagnosis_dxid",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_DiagnosisWWDS_10_Tfbr_diagnosis_dxid_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV77BR_DiagnosisWWDS_11_Tfbr_diagnosis_dxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV78BR_DiagnosisWWDS_12_Tfbr_diagnosis_dxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV79BR_DiagnosisWWDS_13_Tfbr_diagnosis_dxtype",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV80BR_DiagnosisWWDS_14_Tfbr_diagnosis_dxtype_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81BR_DiagnosisWWDS_15_Tfbr_diagnosis_dxtype_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_DiagnosisWWDS_16_Tfbr_diagnosis_dxtype_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_DiagnosisWWDS_17_Tfbr_diagnosis_dxtsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_DiagnosisWWDS_18_Tfbr_diagnosis_dxtsource_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85BR_DiagnosisWWDS_19_Tfbr_diagnosis_dxtsource_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV86BR_DiagnosisWWDS_20_Tfbr_diagnosis_dxtsource_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV87BR_DiagnosisWWDS_21_Tfbr_diagnosis_dxdescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_DiagnosisWWDS_22_Tfbr_diagnosis_dxdescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DiagnosisWWDS_24_Tfbr_diagnosis_initialdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DiagnosisWWDS_25_Tfbr_diagnosis_initialdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_DiagnosisWWDS_27_Tfbr_diagnosis_metastasesdx_code",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_DiagnosisWWDS_28_Tfbr_diagnosis_metastasesdx_code_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV95BR_DiagnosisWWDS_29_Tfbr_diagnosis_dxsource",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV96BR_DiagnosisWWDS_30_Tfbr_diagnosis_dxsource_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001T2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T2,100,0,true,false )
             ,new CursorDef("P001T3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T3,100,0,true,false )
             ,new CursorDef("P001T4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T4,100,0,true,false )
             ,new CursorDef("P001T5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T5,100,0,true,false )
             ,new CursorDef("P001T6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T6,100,0,true,false )
             ,new CursorDef("P001T7", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T7,100,0,true,false )
             ,new CursorDef("P001T8", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T8,100,0,true,false )
             ,new CursorDef("P001T9", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T9,100,0,true,false )
             ,new CursorDef("P001T10", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T10,100,0,true,false )
             ,new CursorDef("P001T11", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T11,100,0,true,false )
             ,new CursorDef("P001T12", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001T12,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((String[]) buf[26])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((long[]) buf[28])[0] = rslt.getLong(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 9 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
                return;
             case 10 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
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
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 4 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 5 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 6 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 7 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 8 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 9 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
             case 10 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_diagnosiswwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_diagnosiswwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_diagnosiswwgetfilterdata") )
          {
             return  ;
          }
          br_diagnosiswwgetfilterdata worker = new br_diagnosiswwgetfilterdata(context) ;
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
