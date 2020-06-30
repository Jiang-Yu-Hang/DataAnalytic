/*
               File: BR_PathologyWWGetFilterData
        Description: BR_Pathology WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:2.21
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
   public class br_pathologywwgetfilterdata : GXProcedure
   {
      public br_pathologywwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathologywwgetfilterdata( IGxContext context )
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
         br_pathologywwgetfilterdata objbr_pathologywwgetfilterdata;
         objbr_pathologywwgetfilterdata = new br_pathologywwgetfilterdata();
         objbr_pathologywwgetfilterdata.AV31DDOName = aP0_DDOName;
         objbr_pathologywwgetfilterdata.AV29SearchTxt = aP1_SearchTxt;
         objbr_pathologywwgetfilterdata.AV30SearchTxtTo = aP2_SearchTxtTo;
         objbr_pathologywwgetfilterdata.AV35OptionsJson = "" ;
         objbr_pathologywwgetfilterdata.AV38OptionsDescJson = "" ;
         objbr_pathologywwgetfilterdata.AV40OptionIndexesJson = "" ;
         objbr_pathologywwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_pathologywwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_pathologywwgetfilterdata);
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_pathologywwgetfilterdata)stateInfo).executePrivate();
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
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_INFORMATION_PATIENTNO") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_INFORMATION_PATIENTNOOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGYID_PAHOSP") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGYID_PAHOSPOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGYID_PREPADIA") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGYID_PREPADIAOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGYID_PARESULT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGYID_PARESULTOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_DIA_NAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIA_NAMEOPTIONS' */
               S161 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_LYMPHRATE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_LYMPHRATEOPTIONS' */
               S171 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_METALOC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_METALOCOPTIONS' */
               S181 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
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
         if ( StringUtil.StrCmp(AV42Session.Get("BR_PathologyWWGridState"), "") == 0 )
         {
            AV44GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_PathologyWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV44GridState.FromXml(AV42Session.Get("BR_PathologyWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV63GXV1 = 1;
         while ( AV63GXV1 <= AV44GridState.gxTpr_Filtervalues.Count )
         {
            AV45GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV44GridState.gxTpr_Filtervalues.Item(AV63GXV1));
            if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV11TFBR_PathologyID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_PathologyID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV15TFBR_Information_PatientNo = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV16TFBR_Information_PatientNo_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_TESTID") == 0 )
            {
               AV17TFBR_PathologyID_TestID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV18TFBR_PathologyID_TestID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PADATE") == 0 )
            {
               AV19TFBR_PathologyID_PADate = context.localUtil.CToD( AV45GridStateFilterValue.gxTpr_Value, 0);
               AV20TFBR_PathologyID_PADate_To = context.localUtil.CToD( AV45GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAHOSP") == 0 )
            {
               AV21TFBR_PathologyID_PAHosp = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAHOSP_SEL") == 0 )
            {
               AV22TFBR_PathologyID_PAHosp_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAAGE") == 0 )
            {
               AV23TFBR_PathologyID_PAAge = (short)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV24TFBR_PathologyID_PAAge_To = (short)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PREPADIA") == 0 )
            {
               AV25TFBR_PathologyID_PrePaDia = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PREPADIA_SEL") == 0 )
            {
               AV26TFBR_PathologyID_PrePaDia_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PARESULT") == 0 )
            {
               AV27TFBR_PathologyID_PAResult = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PARESULT_SEL") == 0 )
            {
               AV28TFBR_PathologyID_PAResult_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIA_NAME") == 0 )
            {
               AV59TFBR_Pathology_Dia_Name = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIA_NAME_SEL") == 0 )
            {
               AV60TFBR_Pathology_Dia_Name_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_T") == 0 )
            {
               AV47TFBR_Pathology_T = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, ".");
               AV48TFBR_Pathology_T_To = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_N_SEL") == 0 )
            {
               AV49TFBR_Pathology_N_SelsJson = AV45GridStateFilterValue.gxTpr_Value;
               AV50TFBR_Pathology_N_Sels.FromJSonString(AV49TFBR_Pathology_N_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHNUM") == 0 )
            {
               AV51TFBR_Pathology_LymphNum = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, ".");
               AV52TFBR_Pathology_LymphNum_To = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHRATE") == 0 )
            {
               AV53TFBR_Pathology_LymphRate = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHRATE_SEL") == 0 )
            {
               AV54TFBR_Pathology_LymphRate_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_M_SEL") == 0 )
            {
               AV55TFBR_Pathology_M_SelsJson = AV45GridStateFilterValue.gxTpr_Value;
               AV56TFBR_Pathology_M_Sels.FromJSonString(AV55TFBR_Pathology_M_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_METALOC") == 0 )
            {
               AV57TFBR_Pathology_MetaLoc = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_METALOC_SEL") == 0 )
            {
               AV58TFBR_Pathology_MetaLoc_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            AV63GXV1 = (int)(AV63GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV15TFBR_Information_PatientNo = AV29SearchTxt;
         AV16TFBR_Information_PatientNo_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P2 */
         pr_default.execute(0, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2P2 = false;
            A85BR_Information_ID = P002P2_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P2_n36BR_Information_PatientNo[0];
            A319BR_Pathology_MetaLoc = P002P2_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P2_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P2_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P2_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P2_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P2_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P2_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P2_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P2_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P2_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P2_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P2_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P2_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P2_n326BR_Pathology_Dia_Name[0];
            A242BR_PathologyID_PAResult = P002P2_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P2_n242BR_PathologyID_PAResult[0];
            A241BR_PathologyID_PrePaDia = P002P2_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P2_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P2_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P2_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P2_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P2_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P2_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P2_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P2_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P2_n237BR_PathologyID_TestID[0];
            A19BR_EncounterID = P002P2_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P2_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P2_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P2_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P2_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002P2_A36BR_Information_PatientNo[0], A36BR_Information_PatientNo) == 0 ) )
            {
               BRK2P2 = false;
               A85BR_Information_ID = P002P2_A85BR_Information_ID[0];
               n85BR_Information_ID = P002P2_n85BR_Information_ID[0];
               A19BR_EncounterID = P002P2_A19BR_EncounterID[0];
               n19BR_EncounterID = P002P2_n19BR_EncounterID[0];
               A226BR_PathologyID = P002P2_A226BR_PathologyID[0];
               A85BR_Information_ID = P002P2_A85BR_Information_ID[0];
               n85BR_Information_ID = P002P2_n85BR_Information_ID[0];
               AV41count = (long)(AV41count+1);
               BRK2P2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A36BR_Information_PatientNo)) )
            {
               AV33Option = A36BR_Information_PatientNo;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P2 )
            {
               BRK2P2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_PATHOLOGYID_PAHOSPOPTIONS' Routine */
         AV21TFBR_PathologyID_PAHosp = AV29SearchTxt;
         AV22TFBR_PathologyID_PAHosp_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P3 */
         pr_default.execute(1, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2P4 = false;
            A85BR_Information_ID = P002P3_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P3_n85BR_Information_ID[0];
            A239BR_PathologyID_PAHosp = P002P3_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P3_n239BR_PathologyID_PAHosp[0];
            A319BR_Pathology_MetaLoc = P002P3_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P3_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P3_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P3_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P3_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P3_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P3_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P3_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P3_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P3_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P3_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P3_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P3_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P3_n326BR_Pathology_Dia_Name[0];
            A242BR_PathologyID_PAResult = P002P3_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P3_n242BR_PathologyID_PAResult[0];
            A241BR_PathologyID_PrePaDia = P002P3_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P3_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P3_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P3_n240BR_PathologyID_PAAge[0];
            A238BR_PathologyID_PADate = P002P3_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P3_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P3_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P3_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P3_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P3_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P3_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P3_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P3_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P3_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P3_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002P3_A239BR_PathologyID_PAHosp[0], A239BR_PathologyID_PAHosp) == 0 ) )
            {
               BRK2P4 = false;
               A226BR_PathologyID = P002P3_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A239BR_PathologyID_PAHosp)) )
            {
               AV33Option = A239BR_PathologyID_PAHosp;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P4 )
            {
               BRK2P4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_PATHOLOGYID_PREPADIAOPTIONS' Routine */
         AV25TFBR_PathologyID_PrePaDia = AV29SearchTxt;
         AV26TFBR_PathologyID_PrePaDia_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P4 */
         pr_default.execute(2, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK2P6 = false;
            A85BR_Information_ID = P002P4_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P4_n85BR_Information_ID[0];
            A241BR_PathologyID_PrePaDia = P002P4_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P4_n241BR_PathologyID_PrePaDia[0];
            A319BR_Pathology_MetaLoc = P002P4_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P4_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P4_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P4_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P4_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P4_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P4_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P4_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P4_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P4_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P4_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P4_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P4_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P4_n326BR_Pathology_Dia_Name[0];
            A242BR_PathologyID_PAResult = P002P4_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P4_n242BR_PathologyID_PAResult[0];
            A240BR_PathologyID_PAAge = P002P4_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P4_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P4_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P4_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P4_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P4_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P4_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P4_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P4_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P4_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P4_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P4_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P4_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P4_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P4_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P002P4_A241BR_PathologyID_PrePaDia[0], A241BR_PathologyID_PrePaDia) == 0 ) )
            {
               BRK2P6 = false;
               A226BR_PathologyID = P002P4_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A241BR_PathologyID_PrePaDia)) )
            {
               AV33Option = A241BR_PathologyID_PrePaDia;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P6 )
            {
               BRK2P6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_PATHOLOGYID_PARESULTOPTIONS' Routine */
         AV27TFBR_PathologyID_PAResult = AV29SearchTxt;
         AV28TFBR_PathologyID_PAResult_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P5 */
         pr_default.execute(3, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK2P8 = false;
            A85BR_Information_ID = P002P5_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P5_n85BR_Information_ID[0];
            A242BR_PathologyID_PAResult = P002P5_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P5_n242BR_PathologyID_PAResult[0];
            A319BR_Pathology_MetaLoc = P002P5_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P5_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P5_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P5_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P5_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P5_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P5_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P5_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P5_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P5_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P5_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P5_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P5_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P5_n326BR_Pathology_Dia_Name[0];
            A241BR_PathologyID_PrePaDia = P002P5_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P5_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P5_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P5_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P5_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P5_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P5_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P5_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P5_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P5_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P5_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P5_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P5_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P5_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P5_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P5_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P5_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P002P5_A242BR_PathologyID_PAResult[0], A242BR_PathologyID_PAResult) == 0 ) )
            {
               BRK2P8 = false;
               A226BR_PathologyID = P002P5_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A242BR_PathologyID_PAResult)) )
            {
               AV33Option = A242BR_PathologyID_PAResult;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P8 )
            {
               BRK2P8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
      }

      protected void S161( )
      {
         /* 'LOADBR_PATHOLOGY_DIA_NAMEOPTIONS' Routine */
         AV59TFBR_Pathology_Dia_Name = AV29SearchTxt;
         AV60TFBR_Pathology_Dia_Name_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P6 */
         pr_default.execute(4, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK2P10 = false;
            A85BR_Information_ID = P002P6_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P6_n85BR_Information_ID[0];
            A326BR_Pathology_Dia_Name = P002P6_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P6_n326BR_Pathology_Dia_Name[0];
            A319BR_Pathology_MetaLoc = P002P6_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P6_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P6_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P6_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P6_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P6_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P6_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P6_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P6_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P6_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P6_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P6_n314BR_Pathology_T[0];
            A242BR_PathologyID_PAResult = P002P6_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P6_n242BR_PathologyID_PAResult[0];
            A241BR_PathologyID_PrePaDia = P002P6_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P6_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P6_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P6_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P6_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P6_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P6_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P6_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P6_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P6_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P6_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P6_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P6_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P6_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P6_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P6_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(P002P6_A326BR_Pathology_Dia_Name[0], A326BR_Pathology_Dia_Name) == 0 ) )
            {
               BRK2P10 = false;
               A226BR_PathologyID = P002P6_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P10 = true;
               pr_default.readNext(4);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) )
            {
               AV33Option = A326BR_Pathology_Dia_Name;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P10 )
            {
               BRK2P10 = true;
               pr_default.readNext(4);
            }
         }
         pr_default.close(4);
      }

      protected void S171( )
      {
         /* 'LOADBR_PATHOLOGY_LYMPHRATEOPTIONS' Routine */
         AV53TFBR_Pathology_LymphRate = AV29SearchTxt;
         AV54TFBR_Pathology_LymphRate_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(5, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P7 */
         pr_default.execute(5, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(5) != 101) )
         {
            BRK2P12 = false;
            A85BR_Information_ID = P002P7_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P7_n85BR_Information_ID[0];
            A317BR_Pathology_LymphRate = P002P7_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P7_n317BR_Pathology_LymphRate[0];
            A319BR_Pathology_MetaLoc = P002P7_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P7_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P7_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P7_n318BR_Pathology_M[0];
            A316BR_Pathology_LymphNum = P002P7_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P7_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P7_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P7_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P7_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P7_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P7_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P7_n326BR_Pathology_Dia_Name[0];
            A242BR_PathologyID_PAResult = P002P7_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P7_n242BR_PathologyID_PAResult[0];
            A241BR_PathologyID_PrePaDia = P002P7_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P7_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P7_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P7_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P7_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P7_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P7_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P7_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P7_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P7_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P7_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P7_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P7_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P7_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P7_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P7_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P7_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(5) != 101) && ( StringUtil.StrCmp(P002P7_A317BR_Pathology_LymphRate[0], A317BR_Pathology_LymphRate) == 0 ) )
            {
               BRK2P12 = false;
               A226BR_PathologyID = P002P7_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P12 = true;
               pr_default.readNext(5);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A317BR_Pathology_LymphRate)) )
            {
               AV33Option = A317BR_Pathology_LymphRate;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P12 )
            {
               BRK2P12 = true;
               pr_default.readNext(5);
            }
         }
         pr_default.close(5);
      }

      protected void S181( )
      {
         /* 'LOADBR_PATHOLOGY_METALOCOPTIONS' Routine */
         AV57TFBR_Pathology_MetaLoc = AV29SearchTxt;
         AV58TFBR_Pathology_MetaLoc_Sel = "";
         AV65BR_PathologyWWDS_1_Tfbr_pathologyid = AV11TFBR_PathologyID;
         AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV12TFBR_PathologyID_To;
         AV67BR_PathologyWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV68BR_PathologyWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV17TFBR_PathologyID_TestID;
         AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV18TFBR_PathologyID_TestID_To;
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV19TFBR_PathologyID_PADate;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV20TFBR_PathologyID_PADate_To;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV21TFBR_PathologyID_PAHosp;
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV22TFBR_PathologyID_PAHosp_Sel;
         AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV23TFBR_PathologyID_PAAge;
         AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV24TFBR_PathologyID_PAAge_To;
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV25TFBR_PathologyID_PrePaDia;
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV26TFBR_PathologyID_PrePaDia_Sel;
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV27TFBR_PathologyID_PAResult;
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV28TFBR_PathologyID_PAResult_Sel;
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV59TFBR_Pathology_Dia_Name;
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV60TFBR_Pathology_Dia_Name_Sel;
         AV85BR_PathologyWWDS_21_Tfbr_pathology_t = AV47TFBR_Pathology_T;
         AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV48TFBR_Pathology_T_To;
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV50TFBR_Pathology_N_Sels;
         AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV51TFBR_Pathology_LymphNum;
         AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV52TFBR_Pathology_LymphNum_To;
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV53TFBR_Pathology_LymphRate;
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV54TFBR_Pathology_LymphRate_Sel;
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV56TFBR_Pathology_M_Sels;
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV57TFBR_Pathology_MetaLoc;
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV58TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(6, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor P002P8 */
         pr_default.execute(6, new Object[] {AV65BR_PathologyWWDS_1_Tfbr_pathologyid, AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV67BR_PathologyWWDS_3_Tfbr_encounterid, AV68BR_PathologyWWDS_4_Tfbr_encounterid_to, lV69BR_PathologyWWDS_5_Tfbr_information_patientno, AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV85BR_PathologyWWDS_21_Tfbr_pathology_t, AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         while ( (pr_default.getStatus(6) != 101) )
         {
            BRK2P14 = false;
            A85BR_Information_ID = P002P8_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P8_n85BR_Information_ID[0];
            A319BR_Pathology_MetaLoc = P002P8_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = P002P8_n319BR_Pathology_MetaLoc[0];
            A318BR_Pathology_M = P002P8_A318BR_Pathology_M[0];
            n318BR_Pathology_M = P002P8_n318BR_Pathology_M[0];
            A317BR_Pathology_LymphRate = P002P8_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = P002P8_n317BR_Pathology_LymphRate[0];
            A316BR_Pathology_LymphNum = P002P8_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = P002P8_n316BR_Pathology_LymphNum[0];
            A315BR_Pathology_N = P002P8_A315BR_Pathology_N[0];
            n315BR_Pathology_N = P002P8_n315BR_Pathology_N[0];
            A314BR_Pathology_T = P002P8_A314BR_Pathology_T[0];
            n314BR_Pathology_T = P002P8_n314BR_Pathology_T[0];
            A326BR_Pathology_Dia_Name = P002P8_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = P002P8_n326BR_Pathology_Dia_Name[0];
            A242BR_PathologyID_PAResult = P002P8_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = P002P8_n242BR_PathologyID_PAResult[0];
            A241BR_PathologyID_PrePaDia = P002P8_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = P002P8_n241BR_PathologyID_PrePaDia[0];
            A240BR_PathologyID_PAAge = P002P8_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = P002P8_n240BR_PathologyID_PAAge[0];
            A239BR_PathologyID_PAHosp = P002P8_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = P002P8_n239BR_PathologyID_PAHosp[0];
            A238BR_PathologyID_PADate = P002P8_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = P002P8_n238BR_PathologyID_PADate[0];
            A237BR_PathologyID_TestID = P002P8_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = P002P8_n237BR_PathologyID_TestID[0];
            A36BR_Information_PatientNo = P002P8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P8_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P002P8_A19BR_EncounterID[0];
            n19BR_EncounterID = P002P8_n19BR_EncounterID[0];
            A226BR_PathologyID = P002P8_A226BR_PathologyID[0];
            A85BR_Information_ID = P002P8_A85BR_Information_ID[0];
            n85BR_Information_ID = P002P8_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002P8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002P8_n36BR_Information_PatientNo[0];
            AV41count = 0;
            while ( (pr_default.getStatus(6) != 101) && ( StringUtil.StrCmp(P002P8_A319BR_Pathology_MetaLoc[0], A319BR_Pathology_MetaLoc) == 0 ) )
            {
               BRK2P14 = false;
               A226BR_PathologyID = P002P8_A226BR_PathologyID[0];
               AV41count = (long)(AV41count+1);
               BRK2P14 = true;
               pr_default.readNext(6);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A319BR_Pathology_MetaLoc)) )
            {
               AV33Option = A319BR_Pathology_MetaLoc;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2P14 )
            {
               BRK2P14 = true;
               pr_default.readNext(6);
            }
         }
         pr_default.close(6);
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
         AV15TFBR_Information_PatientNo = "";
         AV16TFBR_Information_PatientNo_Sel = "";
         AV19TFBR_PathologyID_PADate = DateTime.MinValue;
         AV20TFBR_PathologyID_PADate_To = DateTime.MinValue;
         AV21TFBR_PathologyID_PAHosp = "";
         AV22TFBR_PathologyID_PAHosp_Sel = "";
         AV25TFBR_PathologyID_PrePaDia = "";
         AV26TFBR_PathologyID_PrePaDia_Sel = "";
         AV27TFBR_PathologyID_PAResult = "";
         AV28TFBR_PathologyID_PAResult_Sel = "";
         AV59TFBR_Pathology_Dia_Name = "";
         AV60TFBR_Pathology_Dia_Name_Sel = "";
         AV49TFBR_Pathology_N_SelsJson = "";
         AV50TFBR_Pathology_N_Sels = new GxSimpleCollection<String>();
         AV53TFBR_Pathology_LymphRate = "";
         AV54TFBR_Pathology_LymphRate_Sel = "";
         AV55TFBR_Pathology_M_SelsJson = "";
         AV56TFBR_Pathology_M_Sels = new GxSimpleCollection<String>();
         AV57TFBR_Pathology_MetaLoc = "";
         AV58TFBR_Pathology_MetaLoc_Sel = "";
         AV69BR_PathologyWWDS_5_Tfbr_information_patientno = "";
         AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel = "";
         AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate = DateTime.MinValue;
         AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = DateTime.MinValue;
         AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = "";
         AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = "";
         AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = "";
         AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = "";
         AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = "";
         AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = "";
         AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = "";
         AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = "";
         AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels = new GxSimpleCollection<String>();
         AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = "";
         AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = "";
         AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels = new GxSimpleCollection<String>();
         AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = "";
         AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = "";
         scmdbuf = "";
         lV69BR_PathologyWWDS_5_Tfbr_information_patientno = "";
         lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = "";
         lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = "";
         lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = "";
         lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name = "";
         lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = "";
         lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc = "";
         A315BR_Pathology_N = "";
         A318BR_Pathology_M = "";
         A36BR_Information_PatientNo = "";
         A238BR_PathologyID_PADate = DateTime.MinValue;
         A239BR_PathologyID_PAHosp = "";
         A241BR_PathologyID_PrePaDia = "";
         A242BR_PathologyID_PAResult = "";
         A326BR_Pathology_Dia_Name = "";
         A317BR_Pathology_LymphRate = "";
         A319BR_Pathology_MetaLoc = "";
         P002P2_A85BR_Information_ID = new long[1] ;
         P002P2_n85BR_Information_ID = new bool[] {false} ;
         P002P2_A36BR_Information_PatientNo = new String[] {""} ;
         P002P2_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P2_A318BR_Pathology_M = new String[] {""} ;
         P002P2_n318BR_Pathology_M = new bool[] {false} ;
         P002P2_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P2_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P2_A315BR_Pathology_N = new String[] {""} ;
         P002P2_n315BR_Pathology_N = new bool[] {false} ;
         P002P2_A314BR_Pathology_T = new decimal[1] ;
         P002P2_n314BR_Pathology_T = new bool[] {false} ;
         P002P2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P2_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P2_A240BR_PathologyID_PAAge = new short[1] ;
         P002P2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P2_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P2_A237BR_PathologyID_TestID = new long[1] ;
         P002P2_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P2_A19BR_EncounterID = new long[1] ;
         P002P2_n19BR_EncounterID = new bool[] {false} ;
         P002P2_A226BR_PathologyID = new long[1] ;
         AV33Option = "";
         P002P3_A85BR_Information_ID = new long[1] ;
         P002P3_n85BR_Information_ID = new bool[] {false} ;
         P002P3_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P3_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P3_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P3_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P3_A318BR_Pathology_M = new String[] {""} ;
         P002P3_n318BR_Pathology_M = new bool[] {false} ;
         P002P3_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P3_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P3_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P3_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P3_A315BR_Pathology_N = new String[] {""} ;
         P002P3_n315BR_Pathology_N = new bool[] {false} ;
         P002P3_A314BR_Pathology_T = new decimal[1] ;
         P002P3_n314BR_Pathology_T = new bool[] {false} ;
         P002P3_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P3_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P3_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P3_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P3_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P3_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P3_A240BR_PathologyID_PAAge = new short[1] ;
         P002P3_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P3_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P3_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P3_A237BR_PathologyID_TestID = new long[1] ;
         P002P3_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P3_A36BR_Information_PatientNo = new String[] {""} ;
         P002P3_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P3_A19BR_EncounterID = new long[1] ;
         P002P3_n19BR_EncounterID = new bool[] {false} ;
         P002P3_A226BR_PathologyID = new long[1] ;
         P002P4_A85BR_Information_ID = new long[1] ;
         P002P4_n85BR_Information_ID = new bool[] {false} ;
         P002P4_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P4_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P4_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P4_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P4_A318BR_Pathology_M = new String[] {""} ;
         P002P4_n318BR_Pathology_M = new bool[] {false} ;
         P002P4_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P4_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P4_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P4_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P4_A315BR_Pathology_N = new String[] {""} ;
         P002P4_n315BR_Pathology_N = new bool[] {false} ;
         P002P4_A314BR_Pathology_T = new decimal[1] ;
         P002P4_n314BR_Pathology_T = new bool[] {false} ;
         P002P4_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P4_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P4_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P4_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P4_A240BR_PathologyID_PAAge = new short[1] ;
         P002P4_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P4_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P4_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P4_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P4_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P4_A237BR_PathologyID_TestID = new long[1] ;
         P002P4_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P4_A36BR_Information_PatientNo = new String[] {""} ;
         P002P4_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P4_A19BR_EncounterID = new long[1] ;
         P002P4_n19BR_EncounterID = new bool[] {false} ;
         P002P4_A226BR_PathologyID = new long[1] ;
         P002P5_A85BR_Information_ID = new long[1] ;
         P002P5_n85BR_Information_ID = new bool[] {false} ;
         P002P5_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P5_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P5_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P5_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P5_A318BR_Pathology_M = new String[] {""} ;
         P002P5_n318BR_Pathology_M = new bool[] {false} ;
         P002P5_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P5_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P5_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P5_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P5_A315BR_Pathology_N = new String[] {""} ;
         P002P5_n315BR_Pathology_N = new bool[] {false} ;
         P002P5_A314BR_Pathology_T = new decimal[1] ;
         P002P5_n314BR_Pathology_T = new bool[] {false} ;
         P002P5_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P5_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P5_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P5_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P5_A240BR_PathologyID_PAAge = new short[1] ;
         P002P5_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P5_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P5_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P5_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P5_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P5_A237BR_PathologyID_TestID = new long[1] ;
         P002P5_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P5_A36BR_Information_PatientNo = new String[] {""} ;
         P002P5_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P5_A19BR_EncounterID = new long[1] ;
         P002P5_n19BR_EncounterID = new bool[] {false} ;
         P002P5_A226BR_PathologyID = new long[1] ;
         P002P6_A85BR_Information_ID = new long[1] ;
         P002P6_n85BR_Information_ID = new bool[] {false} ;
         P002P6_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P6_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P6_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P6_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P6_A318BR_Pathology_M = new String[] {""} ;
         P002P6_n318BR_Pathology_M = new bool[] {false} ;
         P002P6_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P6_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P6_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P6_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P6_A315BR_Pathology_N = new String[] {""} ;
         P002P6_n315BR_Pathology_N = new bool[] {false} ;
         P002P6_A314BR_Pathology_T = new decimal[1] ;
         P002P6_n314BR_Pathology_T = new bool[] {false} ;
         P002P6_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P6_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P6_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P6_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P6_A240BR_PathologyID_PAAge = new short[1] ;
         P002P6_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P6_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P6_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P6_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P6_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P6_A237BR_PathologyID_TestID = new long[1] ;
         P002P6_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P6_A36BR_Information_PatientNo = new String[] {""} ;
         P002P6_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P6_A19BR_EncounterID = new long[1] ;
         P002P6_n19BR_EncounterID = new bool[] {false} ;
         P002P6_A226BR_PathologyID = new long[1] ;
         P002P7_A85BR_Information_ID = new long[1] ;
         P002P7_n85BR_Information_ID = new bool[] {false} ;
         P002P7_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P7_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P7_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P7_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P7_A318BR_Pathology_M = new String[] {""} ;
         P002P7_n318BR_Pathology_M = new bool[] {false} ;
         P002P7_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P7_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P7_A315BR_Pathology_N = new String[] {""} ;
         P002P7_n315BR_Pathology_N = new bool[] {false} ;
         P002P7_A314BR_Pathology_T = new decimal[1] ;
         P002P7_n314BR_Pathology_T = new bool[] {false} ;
         P002P7_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P7_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P7_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P7_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P7_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P7_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P7_A240BR_PathologyID_PAAge = new short[1] ;
         P002P7_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P7_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P7_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P7_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P7_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P7_A237BR_PathologyID_TestID = new long[1] ;
         P002P7_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P7_A36BR_Information_PatientNo = new String[] {""} ;
         P002P7_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P7_A19BR_EncounterID = new long[1] ;
         P002P7_n19BR_EncounterID = new bool[] {false} ;
         P002P7_A226BR_PathologyID = new long[1] ;
         P002P8_A85BR_Information_ID = new long[1] ;
         P002P8_n85BR_Information_ID = new bool[] {false} ;
         P002P8_A319BR_Pathology_MetaLoc = new String[] {""} ;
         P002P8_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         P002P8_A318BR_Pathology_M = new String[] {""} ;
         P002P8_n318BR_Pathology_M = new bool[] {false} ;
         P002P8_A317BR_Pathology_LymphRate = new String[] {""} ;
         P002P8_n317BR_Pathology_LymphRate = new bool[] {false} ;
         P002P8_A316BR_Pathology_LymphNum = new decimal[1] ;
         P002P8_n316BR_Pathology_LymphNum = new bool[] {false} ;
         P002P8_A315BR_Pathology_N = new String[] {""} ;
         P002P8_n315BR_Pathology_N = new bool[] {false} ;
         P002P8_A314BR_Pathology_T = new decimal[1] ;
         P002P8_n314BR_Pathology_T = new bool[] {false} ;
         P002P8_A326BR_Pathology_Dia_Name = new String[] {""} ;
         P002P8_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         P002P8_A242BR_PathologyID_PAResult = new String[] {""} ;
         P002P8_n242BR_PathologyID_PAResult = new bool[] {false} ;
         P002P8_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         P002P8_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         P002P8_A240BR_PathologyID_PAAge = new short[1] ;
         P002P8_n240BR_PathologyID_PAAge = new bool[] {false} ;
         P002P8_A239BR_PathologyID_PAHosp = new String[] {""} ;
         P002P8_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         P002P8_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         P002P8_n238BR_PathologyID_PADate = new bool[] {false} ;
         P002P8_A237BR_PathologyID_TestID = new long[1] ;
         P002P8_n237BR_PathologyID_TestID = new bool[] {false} ;
         P002P8_A36BR_Information_PatientNo = new String[] {""} ;
         P002P8_n36BR_Information_PatientNo = new bool[] {false} ;
         P002P8_A19BR_EncounterID = new long[1] ;
         P002P8_n19BR_EncounterID = new bool[] {false} ;
         P002P8_A226BR_PathologyID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologywwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002P2_A85BR_Information_ID, P002P2_n85BR_Information_ID, P002P2_A36BR_Information_PatientNo, P002P2_n36BR_Information_PatientNo, P002P2_A319BR_Pathology_MetaLoc, P002P2_n319BR_Pathology_MetaLoc, P002P2_A318BR_Pathology_M, P002P2_n318BR_Pathology_M, P002P2_A317BR_Pathology_LymphRate, P002P2_n317BR_Pathology_LymphRate,
               P002P2_A316BR_Pathology_LymphNum, P002P2_n316BR_Pathology_LymphNum, P002P2_A315BR_Pathology_N, P002P2_n315BR_Pathology_N, P002P2_A314BR_Pathology_T, P002P2_n314BR_Pathology_T, P002P2_A326BR_Pathology_Dia_Name, P002P2_n326BR_Pathology_Dia_Name, P002P2_A242BR_PathologyID_PAResult, P002P2_n242BR_PathologyID_PAResult,
               P002P2_A241BR_PathologyID_PrePaDia, P002P2_n241BR_PathologyID_PrePaDia, P002P2_A240BR_PathologyID_PAAge, P002P2_n240BR_PathologyID_PAAge, P002P2_A239BR_PathologyID_PAHosp, P002P2_n239BR_PathologyID_PAHosp, P002P2_A238BR_PathologyID_PADate, P002P2_n238BR_PathologyID_PADate, P002P2_A237BR_PathologyID_TestID, P002P2_n237BR_PathologyID_TestID,
               P002P2_A19BR_EncounterID, P002P2_n19BR_EncounterID, P002P2_A226BR_PathologyID
               }
               , new Object[] {
               P002P3_A85BR_Information_ID, P002P3_n85BR_Information_ID, P002P3_A239BR_PathologyID_PAHosp, P002P3_n239BR_PathologyID_PAHosp, P002P3_A319BR_Pathology_MetaLoc, P002P3_n319BR_Pathology_MetaLoc, P002P3_A318BR_Pathology_M, P002P3_n318BR_Pathology_M, P002P3_A317BR_Pathology_LymphRate, P002P3_n317BR_Pathology_LymphRate,
               P002P3_A316BR_Pathology_LymphNum, P002P3_n316BR_Pathology_LymphNum, P002P3_A315BR_Pathology_N, P002P3_n315BR_Pathology_N, P002P3_A314BR_Pathology_T, P002P3_n314BR_Pathology_T, P002P3_A326BR_Pathology_Dia_Name, P002P3_n326BR_Pathology_Dia_Name, P002P3_A242BR_PathologyID_PAResult, P002P3_n242BR_PathologyID_PAResult,
               P002P3_A241BR_PathologyID_PrePaDia, P002P3_n241BR_PathologyID_PrePaDia, P002P3_A240BR_PathologyID_PAAge, P002P3_n240BR_PathologyID_PAAge, P002P3_A238BR_PathologyID_PADate, P002P3_n238BR_PathologyID_PADate, P002P3_A237BR_PathologyID_TestID, P002P3_n237BR_PathologyID_TestID, P002P3_A36BR_Information_PatientNo, P002P3_n36BR_Information_PatientNo,
               P002P3_A19BR_EncounterID, P002P3_n19BR_EncounterID, P002P3_A226BR_PathologyID
               }
               , new Object[] {
               P002P4_A85BR_Information_ID, P002P4_n85BR_Information_ID, P002P4_A241BR_PathologyID_PrePaDia, P002P4_n241BR_PathologyID_PrePaDia, P002P4_A319BR_Pathology_MetaLoc, P002P4_n319BR_Pathology_MetaLoc, P002P4_A318BR_Pathology_M, P002P4_n318BR_Pathology_M, P002P4_A317BR_Pathology_LymphRate, P002P4_n317BR_Pathology_LymphRate,
               P002P4_A316BR_Pathology_LymphNum, P002P4_n316BR_Pathology_LymphNum, P002P4_A315BR_Pathology_N, P002P4_n315BR_Pathology_N, P002P4_A314BR_Pathology_T, P002P4_n314BR_Pathology_T, P002P4_A326BR_Pathology_Dia_Name, P002P4_n326BR_Pathology_Dia_Name, P002P4_A242BR_PathologyID_PAResult, P002P4_n242BR_PathologyID_PAResult,
               P002P4_A240BR_PathologyID_PAAge, P002P4_n240BR_PathologyID_PAAge, P002P4_A239BR_PathologyID_PAHosp, P002P4_n239BR_PathologyID_PAHosp, P002P4_A238BR_PathologyID_PADate, P002P4_n238BR_PathologyID_PADate, P002P4_A237BR_PathologyID_TestID, P002P4_n237BR_PathologyID_TestID, P002P4_A36BR_Information_PatientNo, P002P4_n36BR_Information_PatientNo,
               P002P4_A19BR_EncounterID, P002P4_n19BR_EncounterID, P002P4_A226BR_PathologyID
               }
               , new Object[] {
               P002P5_A85BR_Information_ID, P002P5_n85BR_Information_ID, P002P5_A242BR_PathologyID_PAResult, P002P5_n242BR_PathologyID_PAResult, P002P5_A319BR_Pathology_MetaLoc, P002P5_n319BR_Pathology_MetaLoc, P002P5_A318BR_Pathology_M, P002P5_n318BR_Pathology_M, P002P5_A317BR_Pathology_LymphRate, P002P5_n317BR_Pathology_LymphRate,
               P002P5_A316BR_Pathology_LymphNum, P002P5_n316BR_Pathology_LymphNum, P002P5_A315BR_Pathology_N, P002P5_n315BR_Pathology_N, P002P5_A314BR_Pathology_T, P002P5_n314BR_Pathology_T, P002P5_A326BR_Pathology_Dia_Name, P002P5_n326BR_Pathology_Dia_Name, P002P5_A241BR_PathologyID_PrePaDia, P002P5_n241BR_PathologyID_PrePaDia,
               P002P5_A240BR_PathologyID_PAAge, P002P5_n240BR_PathologyID_PAAge, P002P5_A239BR_PathologyID_PAHosp, P002P5_n239BR_PathologyID_PAHosp, P002P5_A238BR_PathologyID_PADate, P002P5_n238BR_PathologyID_PADate, P002P5_A237BR_PathologyID_TestID, P002P5_n237BR_PathologyID_TestID, P002P5_A36BR_Information_PatientNo, P002P5_n36BR_Information_PatientNo,
               P002P5_A19BR_EncounterID, P002P5_n19BR_EncounterID, P002P5_A226BR_PathologyID
               }
               , new Object[] {
               P002P6_A85BR_Information_ID, P002P6_n85BR_Information_ID, P002P6_A326BR_Pathology_Dia_Name, P002P6_n326BR_Pathology_Dia_Name, P002P6_A319BR_Pathology_MetaLoc, P002P6_n319BR_Pathology_MetaLoc, P002P6_A318BR_Pathology_M, P002P6_n318BR_Pathology_M, P002P6_A317BR_Pathology_LymphRate, P002P6_n317BR_Pathology_LymphRate,
               P002P6_A316BR_Pathology_LymphNum, P002P6_n316BR_Pathology_LymphNum, P002P6_A315BR_Pathology_N, P002P6_n315BR_Pathology_N, P002P6_A314BR_Pathology_T, P002P6_n314BR_Pathology_T, P002P6_A242BR_PathologyID_PAResult, P002P6_n242BR_PathologyID_PAResult, P002P6_A241BR_PathologyID_PrePaDia, P002P6_n241BR_PathologyID_PrePaDia,
               P002P6_A240BR_PathologyID_PAAge, P002P6_n240BR_PathologyID_PAAge, P002P6_A239BR_PathologyID_PAHosp, P002P6_n239BR_PathologyID_PAHosp, P002P6_A238BR_PathologyID_PADate, P002P6_n238BR_PathologyID_PADate, P002P6_A237BR_PathologyID_TestID, P002P6_n237BR_PathologyID_TestID, P002P6_A36BR_Information_PatientNo, P002P6_n36BR_Information_PatientNo,
               P002P6_A19BR_EncounterID, P002P6_n19BR_EncounterID, P002P6_A226BR_PathologyID
               }
               , new Object[] {
               P002P7_A85BR_Information_ID, P002P7_n85BR_Information_ID, P002P7_A317BR_Pathology_LymphRate, P002P7_n317BR_Pathology_LymphRate, P002P7_A319BR_Pathology_MetaLoc, P002P7_n319BR_Pathology_MetaLoc, P002P7_A318BR_Pathology_M, P002P7_n318BR_Pathology_M, P002P7_A316BR_Pathology_LymphNum, P002P7_n316BR_Pathology_LymphNum,
               P002P7_A315BR_Pathology_N, P002P7_n315BR_Pathology_N, P002P7_A314BR_Pathology_T, P002P7_n314BR_Pathology_T, P002P7_A326BR_Pathology_Dia_Name, P002P7_n326BR_Pathology_Dia_Name, P002P7_A242BR_PathologyID_PAResult, P002P7_n242BR_PathologyID_PAResult, P002P7_A241BR_PathologyID_PrePaDia, P002P7_n241BR_PathologyID_PrePaDia,
               P002P7_A240BR_PathologyID_PAAge, P002P7_n240BR_PathologyID_PAAge, P002P7_A239BR_PathologyID_PAHosp, P002P7_n239BR_PathologyID_PAHosp, P002P7_A238BR_PathologyID_PADate, P002P7_n238BR_PathologyID_PADate, P002P7_A237BR_PathologyID_TestID, P002P7_n237BR_PathologyID_TestID, P002P7_A36BR_Information_PatientNo, P002P7_n36BR_Information_PatientNo,
               P002P7_A19BR_EncounterID, P002P7_n19BR_EncounterID, P002P7_A226BR_PathologyID
               }
               , new Object[] {
               P002P8_A85BR_Information_ID, P002P8_n85BR_Information_ID, P002P8_A319BR_Pathology_MetaLoc, P002P8_n319BR_Pathology_MetaLoc, P002P8_A318BR_Pathology_M, P002P8_n318BR_Pathology_M, P002P8_A317BR_Pathology_LymphRate, P002P8_n317BR_Pathology_LymphRate, P002P8_A316BR_Pathology_LymphNum, P002P8_n316BR_Pathology_LymphNum,
               P002P8_A315BR_Pathology_N, P002P8_n315BR_Pathology_N, P002P8_A314BR_Pathology_T, P002P8_n314BR_Pathology_T, P002P8_A326BR_Pathology_Dia_Name, P002P8_n326BR_Pathology_Dia_Name, P002P8_A242BR_PathologyID_PAResult, P002P8_n242BR_PathologyID_PAResult, P002P8_A241BR_PathologyID_PrePaDia, P002P8_n241BR_PathologyID_PrePaDia,
               P002P8_A240BR_PathologyID_PAAge, P002P8_n240BR_PathologyID_PAAge, P002P8_A239BR_PathologyID_PAHosp, P002P8_n239BR_PathologyID_PAHosp, P002P8_A238BR_PathologyID_PADate, P002P8_n238BR_PathologyID_PADate, P002P8_A237BR_PathologyID_TestID, P002P8_n237BR_PathologyID_TestID, P002P8_A36BR_Information_PatientNo, P002P8_n36BR_Information_PatientNo,
               P002P8_A19BR_EncounterID, P002P8_n19BR_EncounterID, P002P8_A226BR_PathologyID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV23TFBR_PathologyID_PAAge ;
      private short AV24TFBR_PathologyID_PAAge_To ;
      private short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ;
      private short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ;
      private short A240BR_PathologyID_PAAge ;
      private int AV63GXV1 ;
      private int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ;
      private int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ;
      private long AV11TFBR_PathologyID ;
      private long AV12TFBR_PathologyID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV17TFBR_PathologyID_TestID ;
      private long AV18TFBR_PathologyID_TestID_To ;
      private long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ;
      private long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ;
      private long AV67BR_PathologyWWDS_3_Tfbr_encounterid ;
      private long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ;
      private long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ;
      private long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ;
      private long A226BR_PathologyID ;
      private long A19BR_EncounterID ;
      private long A237BR_PathologyID_TestID ;
      private long A85BR_Information_ID ;
      private long AV41count ;
      private decimal AV47TFBR_Pathology_T ;
      private decimal AV48TFBR_Pathology_T_To ;
      private decimal AV51TFBR_Pathology_LymphNum ;
      private decimal AV52TFBR_Pathology_LymphNum_To ;
      private decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ;
      private decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ;
      private decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ;
      private decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ;
      private decimal A314BR_Pathology_T ;
      private decimal A316BR_Pathology_LymphNum ;
      private String scmdbuf ;
      private DateTime AV19TFBR_PathologyID_PADate ;
      private DateTime AV20TFBR_PathologyID_PADate_To ;
      private DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ;
      private DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ;
      private DateTime A238BR_PathologyID_PADate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2P2 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool n318BR_Pathology_M ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n315BR_Pathology_N ;
      private bool n314BR_Pathology_T ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n238BR_PathologyID_PADate ;
      private bool n237BR_PathologyID_TestID ;
      private bool n19BR_EncounterID ;
      private bool BRK2P4 ;
      private bool BRK2P6 ;
      private bool BRK2P8 ;
      private bool BRK2P10 ;
      private bool BRK2P12 ;
      private bool BRK2P14 ;
      private String AV40OptionIndexesJson ;
      private String AV35OptionsJson ;
      private String AV38OptionsDescJson ;
      private String AV49TFBR_Pathology_N_SelsJson ;
      private String AV55TFBR_Pathology_M_SelsJson ;
      private String AV31DDOName ;
      private String AV29SearchTxt ;
      private String AV30SearchTxtTo ;
      private String AV15TFBR_Information_PatientNo ;
      private String AV16TFBR_Information_PatientNo_Sel ;
      private String AV21TFBR_PathologyID_PAHosp ;
      private String AV22TFBR_PathologyID_PAHosp_Sel ;
      private String AV25TFBR_PathologyID_PrePaDia ;
      private String AV26TFBR_PathologyID_PrePaDia_Sel ;
      private String AV27TFBR_PathologyID_PAResult ;
      private String AV28TFBR_PathologyID_PAResult_Sel ;
      private String AV59TFBR_Pathology_Dia_Name ;
      private String AV60TFBR_Pathology_Dia_Name_Sel ;
      private String AV53TFBR_Pathology_LymphRate ;
      private String AV54TFBR_Pathology_LymphRate_Sel ;
      private String AV57TFBR_Pathology_MetaLoc ;
      private String AV58TFBR_Pathology_MetaLoc_Sel ;
      private String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ;
      private String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ;
      private String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ;
      private String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ;
      private String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ;
      private String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ;
      private String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ;
      private String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ;
      private String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ;
      private String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ;
      private String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ;
      private String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ;
      private String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ;
      private String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ;
      private String lV69BR_PathologyWWDS_5_Tfbr_information_patientno ;
      private String lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ;
      private String lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ;
      private String lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ;
      private String lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ;
      private String lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ;
      private String lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ;
      private String A315BR_Pathology_N ;
      private String A318BR_Pathology_M ;
      private String A36BR_Information_PatientNo ;
      private String A239BR_PathologyID_PAHosp ;
      private String A241BR_PathologyID_PrePaDia ;
      private String A242BR_PathologyID_PAResult ;
      private String A326BR_Pathology_Dia_Name ;
      private String A317BR_Pathology_LymphRate ;
      private String A319BR_Pathology_MetaLoc ;
      private String AV33Option ;
      private IGxSession AV42Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002P2_A85BR_Information_ID ;
      private bool[] P002P2_n85BR_Information_ID ;
      private String[] P002P2_A36BR_Information_PatientNo ;
      private bool[] P002P2_n36BR_Information_PatientNo ;
      private String[] P002P2_A319BR_Pathology_MetaLoc ;
      private bool[] P002P2_n319BR_Pathology_MetaLoc ;
      private String[] P002P2_A318BR_Pathology_M ;
      private bool[] P002P2_n318BR_Pathology_M ;
      private String[] P002P2_A317BR_Pathology_LymphRate ;
      private bool[] P002P2_n317BR_Pathology_LymphRate ;
      private decimal[] P002P2_A316BR_Pathology_LymphNum ;
      private bool[] P002P2_n316BR_Pathology_LymphNum ;
      private String[] P002P2_A315BR_Pathology_N ;
      private bool[] P002P2_n315BR_Pathology_N ;
      private decimal[] P002P2_A314BR_Pathology_T ;
      private bool[] P002P2_n314BR_Pathology_T ;
      private String[] P002P2_A326BR_Pathology_Dia_Name ;
      private bool[] P002P2_n326BR_Pathology_Dia_Name ;
      private String[] P002P2_A242BR_PathologyID_PAResult ;
      private bool[] P002P2_n242BR_PathologyID_PAResult ;
      private String[] P002P2_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P2_n241BR_PathologyID_PrePaDia ;
      private short[] P002P2_A240BR_PathologyID_PAAge ;
      private bool[] P002P2_n240BR_PathologyID_PAAge ;
      private String[] P002P2_A239BR_PathologyID_PAHosp ;
      private bool[] P002P2_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P2_A238BR_PathologyID_PADate ;
      private bool[] P002P2_n238BR_PathologyID_PADate ;
      private long[] P002P2_A237BR_PathologyID_TestID ;
      private bool[] P002P2_n237BR_PathologyID_TestID ;
      private long[] P002P2_A19BR_EncounterID ;
      private bool[] P002P2_n19BR_EncounterID ;
      private long[] P002P2_A226BR_PathologyID ;
      private long[] P002P3_A85BR_Information_ID ;
      private bool[] P002P3_n85BR_Information_ID ;
      private String[] P002P3_A239BR_PathologyID_PAHosp ;
      private bool[] P002P3_n239BR_PathologyID_PAHosp ;
      private String[] P002P3_A319BR_Pathology_MetaLoc ;
      private bool[] P002P3_n319BR_Pathology_MetaLoc ;
      private String[] P002P3_A318BR_Pathology_M ;
      private bool[] P002P3_n318BR_Pathology_M ;
      private String[] P002P3_A317BR_Pathology_LymphRate ;
      private bool[] P002P3_n317BR_Pathology_LymphRate ;
      private decimal[] P002P3_A316BR_Pathology_LymphNum ;
      private bool[] P002P3_n316BR_Pathology_LymphNum ;
      private String[] P002P3_A315BR_Pathology_N ;
      private bool[] P002P3_n315BR_Pathology_N ;
      private decimal[] P002P3_A314BR_Pathology_T ;
      private bool[] P002P3_n314BR_Pathology_T ;
      private String[] P002P3_A326BR_Pathology_Dia_Name ;
      private bool[] P002P3_n326BR_Pathology_Dia_Name ;
      private String[] P002P3_A242BR_PathologyID_PAResult ;
      private bool[] P002P3_n242BR_PathologyID_PAResult ;
      private String[] P002P3_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P3_n241BR_PathologyID_PrePaDia ;
      private short[] P002P3_A240BR_PathologyID_PAAge ;
      private bool[] P002P3_n240BR_PathologyID_PAAge ;
      private DateTime[] P002P3_A238BR_PathologyID_PADate ;
      private bool[] P002P3_n238BR_PathologyID_PADate ;
      private long[] P002P3_A237BR_PathologyID_TestID ;
      private bool[] P002P3_n237BR_PathologyID_TestID ;
      private String[] P002P3_A36BR_Information_PatientNo ;
      private bool[] P002P3_n36BR_Information_PatientNo ;
      private long[] P002P3_A19BR_EncounterID ;
      private bool[] P002P3_n19BR_EncounterID ;
      private long[] P002P3_A226BR_PathologyID ;
      private long[] P002P4_A85BR_Information_ID ;
      private bool[] P002P4_n85BR_Information_ID ;
      private String[] P002P4_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P4_n241BR_PathologyID_PrePaDia ;
      private String[] P002P4_A319BR_Pathology_MetaLoc ;
      private bool[] P002P4_n319BR_Pathology_MetaLoc ;
      private String[] P002P4_A318BR_Pathology_M ;
      private bool[] P002P4_n318BR_Pathology_M ;
      private String[] P002P4_A317BR_Pathology_LymphRate ;
      private bool[] P002P4_n317BR_Pathology_LymphRate ;
      private decimal[] P002P4_A316BR_Pathology_LymphNum ;
      private bool[] P002P4_n316BR_Pathology_LymphNum ;
      private String[] P002P4_A315BR_Pathology_N ;
      private bool[] P002P4_n315BR_Pathology_N ;
      private decimal[] P002P4_A314BR_Pathology_T ;
      private bool[] P002P4_n314BR_Pathology_T ;
      private String[] P002P4_A326BR_Pathology_Dia_Name ;
      private bool[] P002P4_n326BR_Pathology_Dia_Name ;
      private String[] P002P4_A242BR_PathologyID_PAResult ;
      private bool[] P002P4_n242BR_PathologyID_PAResult ;
      private short[] P002P4_A240BR_PathologyID_PAAge ;
      private bool[] P002P4_n240BR_PathologyID_PAAge ;
      private String[] P002P4_A239BR_PathologyID_PAHosp ;
      private bool[] P002P4_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P4_A238BR_PathologyID_PADate ;
      private bool[] P002P4_n238BR_PathologyID_PADate ;
      private long[] P002P4_A237BR_PathologyID_TestID ;
      private bool[] P002P4_n237BR_PathologyID_TestID ;
      private String[] P002P4_A36BR_Information_PatientNo ;
      private bool[] P002P4_n36BR_Information_PatientNo ;
      private long[] P002P4_A19BR_EncounterID ;
      private bool[] P002P4_n19BR_EncounterID ;
      private long[] P002P4_A226BR_PathologyID ;
      private long[] P002P5_A85BR_Information_ID ;
      private bool[] P002P5_n85BR_Information_ID ;
      private String[] P002P5_A242BR_PathologyID_PAResult ;
      private bool[] P002P5_n242BR_PathologyID_PAResult ;
      private String[] P002P5_A319BR_Pathology_MetaLoc ;
      private bool[] P002P5_n319BR_Pathology_MetaLoc ;
      private String[] P002P5_A318BR_Pathology_M ;
      private bool[] P002P5_n318BR_Pathology_M ;
      private String[] P002P5_A317BR_Pathology_LymphRate ;
      private bool[] P002P5_n317BR_Pathology_LymphRate ;
      private decimal[] P002P5_A316BR_Pathology_LymphNum ;
      private bool[] P002P5_n316BR_Pathology_LymphNum ;
      private String[] P002P5_A315BR_Pathology_N ;
      private bool[] P002P5_n315BR_Pathology_N ;
      private decimal[] P002P5_A314BR_Pathology_T ;
      private bool[] P002P5_n314BR_Pathology_T ;
      private String[] P002P5_A326BR_Pathology_Dia_Name ;
      private bool[] P002P5_n326BR_Pathology_Dia_Name ;
      private String[] P002P5_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P5_n241BR_PathologyID_PrePaDia ;
      private short[] P002P5_A240BR_PathologyID_PAAge ;
      private bool[] P002P5_n240BR_PathologyID_PAAge ;
      private String[] P002P5_A239BR_PathologyID_PAHosp ;
      private bool[] P002P5_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P5_A238BR_PathologyID_PADate ;
      private bool[] P002P5_n238BR_PathologyID_PADate ;
      private long[] P002P5_A237BR_PathologyID_TestID ;
      private bool[] P002P5_n237BR_PathologyID_TestID ;
      private String[] P002P5_A36BR_Information_PatientNo ;
      private bool[] P002P5_n36BR_Information_PatientNo ;
      private long[] P002P5_A19BR_EncounterID ;
      private bool[] P002P5_n19BR_EncounterID ;
      private long[] P002P5_A226BR_PathologyID ;
      private long[] P002P6_A85BR_Information_ID ;
      private bool[] P002P6_n85BR_Information_ID ;
      private String[] P002P6_A326BR_Pathology_Dia_Name ;
      private bool[] P002P6_n326BR_Pathology_Dia_Name ;
      private String[] P002P6_A319BR_Pathology_MetaLoc ;
      private bool[] P002P6_n319BR_Pathology_MetaLoc ;
      private String[] P002P6_A318BR_Pathology_M ;
      private bool[] P002P6_n318BR_Pathology_M ;
      private String[] P002P6_A317BR_Pathology_LymphRate ;
      private bool[] P002P6_n317BR_Pathology_LymphRate ;
      private decimal[] P002P6_A316BR_Pathology_LymphNum ;
      private bool[] P002P6_n316BR_Pathology_LymphNum ;
      private String[] P002P6_A315BR_Pathology_N ;
      private bool[] P002P6_n315BR_Pathology_N ;
      private decimal[] P002P6_A314BR_Pathology_T ;
      private bool[] P002P6_n314BR_Pathology_T ;
      private String[] P002P6_A242BR_PathologyID_PAResult ;
      private bool[] P002P6_n242BR_PathologyID_PAResult ;
      private String[] P002P6_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P6_n241BR_PathologyID_PrePaDia ;
      private short[] P002P6_A240BR_PathologyID_PAAge ;
      private bool[] P002P6_n240BR_PathologyID_PAAge ;
      private String[] P002P6_A239BR_PathologyID_PAHosp ;
      private bool[] P002P6_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P6_A238BR_PathologyID_PADate ;
      private bool[] P002P6_n238BR_PathologyID_PADate ;
      private long[] P002P6_A237BR_PathologyID_TestID ;
      private bool[] P002P6_n237BR_PathologyID_TestID ;
      private String[] P002P6_A36BR_Information_PatientNo ;
      private bool[] P002P6_n36BR_Information_PatientNo ;
      private long[] P002P6_A19BR_EncounterID ;
      private bool[] P002P6_n19BR_EncounterID ;
      private long[] P002P6_A226BR_PathologyID ;
      private long[] P002P7_A85BR_Information_ID ;
      private bool[] P002P7_n85BR_Information_ID ;
      private String[] P002P7_A317BR_Pathology_LymphRate ;
      private bool[] P002P7_n317BR_Pathology_LymphRate ;
      private String[] P002P7_A319BR_Pathology_MetaLoc ;
      private bool[] P002P7_n319BR_Pathology_MetaLoc ;
      private String[] P002P7_A318BR_Pathology_M ;
      private bool[] P002P7_n318BR_Pathology_M ;
      private decimal[] P002P7_A316BR_Pathology_LymphNum ;
      private bool[] P002P7_n316BR_Pathology_LymphNum ;
      private String[] P002P7_A315BR_Pathology_N ;
      private bool[] P002P7_n315BR_Pathology_N ;
      private decimal[] P002P7_A314BR_Pathology_T ;
      private bool[] P002P7_n314BR_Pathology_T ;
      private String[] P002P7_A326BR_Pathology_Dia_Name ;
      private bool[] P002P7_n326BR_Pathology_Dia_Name ;
      private String[] P002P7_A242BR_PathologyID_PAResult ;
      private bool[] P002P7_n242BR_PathologyID_PAResult ;
      private String[] P002P7_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P7_n241BR_PathologyID_PrePaDia ;
      private short[] P002P7_A240BR_PathologyID_PAAge ;
      private bool[] P002P7_n240BR_PathologyID_PAAge ;
      private String[] P002P7_A239BR_PathologyID_PAHosp ;
      private bool[] P002P7_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P7_A238BR_PathologyID_PADate ;
      private bool[] P002P7_n238BR_PathologyID_PADate ;
      private long[] P002P7_A237BR_PathologyID_TestID ;
      private bool[] P002P7_n237BR_PathologyID_TestID ;
      private String[] P002P7_A36BR_Information_PatientNo ;
      private bool[] P002P7_n36BR_Information_PatientNo ;
      private long[] P002P7_A19BR_EncounterID ;
      private bool[] P002P7_n19BR_EncounterID ;
      private long[] P002P7_A226BR_PathologyID ;
      private long[] P002P8_A85BR_Information_ID ;
      private bool[] P002P8_n85BR_Information_ID ;
      private String[] P002P8_A319BR_Pathology_MetaLoc ;
      private bool[] P002P8_n319BR_Pathology_MetaLoc ;
      private String[] P002P8_A318BR_Pathology_M ;
      private bool[] P002P8_n318BR_Pathology_M ;
      private String[] P002P8_A317BR_Pathology_LymphRate ;
      private bool[] P002P8_n317BR_Pathology_LymphRate ;
      private decimal[] P002P8_A316BR_Pathology_LymphNum ;
      private bool[] P002P8_n316BR_Pathology_LymphNum ;
      private String[] P002P8_A315BR_Pathology_N ;
      private bool[] P002P8_n315BR_Pathology_N ;
      private decimal[] P002P8_A314BR_Pathology_T ;
      private bool[] P002P8_n314BR_Pathology_T ;
      private String[] P002P8_A326BR_Pathology_Dia_Name ;
      private bool[] P002P8_n326BR_Pathology_Dia_Name ;
      private String[] P002P8_A242BR_PathologyID_PAResult ;
      private bool[] P002P8_n242BR_PathologyID_PAResult ;
      private String[] P002P8_A241BR_PathologyID_PrePaDia ;
      private bool[] P002P8_n241BR_PathologyID_PrePaDia ;
      private short[] P002P8_A240BR_PathologyID_PAAge ;
      private bool[] P002P8_n240BR_PathologyID_PAAge ;
      private String[] P002P8_A239BR_PathologyID_PAHosp ;
      private bool[] P002P8_n239BR_PathologyID_PAHosp ;
      private DateTime[] P002P8_A238BR_PathologyID_PADate ;
      private bool[] P002P8_n238BR_PathologyID_PADate ;
      private long[] P002P8_A237BR_PathologyID_TestID ;
      private bool[] P002P8_n237BR_PathologyID_TestID ;
      private String[] P002P8_A36BR_Information_PatientNo ;
      private bool[] P002P8_n36BR_Information_PatientNo ;
      private long[] P002P8_A19BR_EncounterID ;
      private bool[] P002P8_n19BR_EncounterID ;
      private long[] P002P8_A226BR_PathologyID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV34Options ;
      private GxSimpleCollection<String> AV37OptionsDesc ;
      private GxSimpleCollection<String> AV39OptionIndexes ;
      private GxSimpleCollection<String> AV50TFBR_Pathology_N_Sels ;
      private GxSimpleCollection<String> AV56TFBR_Pathology_M_Sels ;
      private GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ;
      private GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV44GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV45GridStateFilterValue ;
   }

   public class br_pathologywwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002P2( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [28] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T3.[BR_Information_PatientNo], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int2[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int2[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int2[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int2[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int2[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int2[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int2[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int2[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int2[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int2[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int2[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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

      protected Object[] conditional_P002P3( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [28] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_PathologyID_PAHosp], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int4[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int4[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int4[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int4[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int4[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int4[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int4[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int4[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int4[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int4[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int4[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int4[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_PathologyID_PAHosp]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P002P4( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [28] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_PathologyID_PrePaDia], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int6[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int6[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int6[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int6[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int6[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int6[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int6[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int6[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int6[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int6[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int6[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int6[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int6[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_PathologyID_PrePaDia]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P002P5( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [28] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_PathologyID_PAResult], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int8[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int8[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int8[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int8[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int8[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int8[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int8[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int8[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int8[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int8[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int8[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int8[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int8[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int8[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int8[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_PathologyID_PAResult]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      protected Object[] conditional_P002P6( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [28] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Pathology_Dia_Name], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int10[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int10[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int10[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int10[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int10[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int10[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int10[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int10[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int10[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int10[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int10[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int10[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int10[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int10[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int10[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int10[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int10[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int10[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int10[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int10[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int10[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int10[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int10[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int10[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int10[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int10[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int10[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Pathology_Dia_Name]";
         GXv_Object11[0] = scmdbuf;
         GXv_Object11[1] = GXv_int10;
         return GXv_Object11 ;
      }

      protected Object[] conditional_P002P7( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int12 ;
         GXv_int12 = new short [28] ;
         Object[] GXv_Object13 ;
         GXv_Object13 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int12[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int12[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int12[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int12[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int12[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int12[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int12[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int12[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int12[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int12[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int12[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int12[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int12[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int12[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int12[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int12[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int12[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int12[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int12[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int12[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int12[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int12[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int12[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int12[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int12[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int12[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int12[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Pathology_LymphRate]";
         GXv_Object13[0] = scmdbuf;
         GXv_Object13[1] = GXv_int12;
         return GXv_Object13 ;
      }

      protected Object[] conditional_P002P8( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV65BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV67BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV68BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV69BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV85BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int14 ;
         GXv_int14 = new short [28] ;
         Object[] GXv_Object15 ;
         GXv_Object15 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV65BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV65BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int14[0] = 1;
         }
         if ( ! (0==AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int14[1] = 1;
         }
         if ( ! (0==AV67BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV67BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int14[2] = 1;
         }
         if ( ! (0==AV68BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV68BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int14[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV69BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int14[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int14[5] = 1;
         }
         if ( ! (0==AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int14[6] = 1;
         }
         if ( ! (0==AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int14[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int14[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int14[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int14[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int14[11] = 1;
         }
         if ( ! (0==AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int14[12] = 1;
         }
         if ( ! (0==AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int14[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int14[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int14[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int14[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int14[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int14[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int14[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV85BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV85BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int14[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int14[21] = 1;
         }
         if ( AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV87BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int14[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int14[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int14[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int14[25] = 1;
         }
         if ( AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV92BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int14[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Pathology_MetaLoc]";
         GXv_Object15[0] = scmdbuf;
         GXv_Object15[1] = GXv_int14;
         return GXv_Object15 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P002P2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 1 :
                     return conditional_P002P3(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 2 :
                     return conditional_P002P4(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 3 :
                     return conditional_P002P5(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 4 :
                     return conditional_P002P6(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 5 :
                     return conditional_P002P7(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
               case 6 :
                     return conditional_P002P8(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P2 ;
          prmP002P2 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P3 ;
          prmP002P3 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P4 ;
          prmP002P4 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P5 ;
          prmP002P5 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P6 ;
          prmP002P6 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P7 ;
          prmP002P7 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          /* Definition of lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmP002P8 ;
          prmP002P8 = new Object[] {
          new Object[] {"@AV65BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV70BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV71BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV72BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV73BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV74BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV75BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV78BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV79BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV80BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV81BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV82BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV83BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV84BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV85BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV86BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV88BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV89BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV90BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV94BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P2,100,0,true,false )
             ,new CursorDef("P002P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P3,100,0,true,false )
             ,new CursorDef("P002P4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P4,100,0,true,false )
             ,new CursorDef("P002P5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P5,100,0,true,false )
             ,new CursorDef("P002P6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P6,100,0,true,false )
             ,new CursorDef("P002P7", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P7,100,0,true,false )
             ,new CursorDef("P002P8", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P8,100,0,true,false )
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((short[]) buf[22])[0] = rslt.getShort(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[26])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((long[]) buf[28])[0] = rslt.getLong(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((short[]) buf[22])[0] = rslt.getShort(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
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
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.br_pathologywwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_pathologywwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_pathologywwgetfilterdata") )
          {
             return  ;
          }
          br_pathologywwgetfilterdata worker = new br_pathologywwgetfilterdata(context) ;
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
